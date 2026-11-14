using System;
using System.Linq;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.XR.Management;
using UnityEditor.XR.Management.Metadata;
using UnityEditor.XR.OpenXR.Features;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.Management;
using UnityEngine.XR.OpenXR;
using UnityEngine.XR.OpenXR.Features.Interactions;
using UnityEngine.XR.OpenXR.Features.MetaQuestSupport;

namespace LivingPark.Editor
{
    public static class QuestFoundationSetup
    {
        private const string SettingsPath = "Assets/_TheLivingPark/Quest XR Settings.asset";
        private const string OpenXRLoader = "UnityEngine.XR.OpenXR.OpenXRLoader";

        public static void BuildAndroid()
        {
            var args = Environment.GetCommandLineArgs();
            int index = Array.IndexOf(args, "-buildOutput");
            if (index < 0 || index + 1 >= args.Length ||
                !args[index + 1].EndsWith(".apk", StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("Pass -buildOutput followed by an APK path.");

            ConfigureQuest();
            var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
            {
                scenes = EditorBuildSettings.scenes.Where(scene => scene.enabled).Select(scene => scene.path).ToArray(),
                locationPathName = args[index + 1],
                target = BuildTarget.Android
            });
            if (report.summary.result != BuildResult.Succeeded)
                throw new InvalidOperationException($"Android build ended with {report.summary.result}.");
        }

        [MenuItem("Living Park/Configure Quest Foundation")]
        public static void ConfigureQuest()
        {
            const BuildTargetGroup target = BuildTargetGroup.Android;
            var settings = AssetDatabase.LoadAssetAtPath<XRGeneralSettingsPerBuildTarget>(SettingsPath);
            if (settings == null)
            {
                settings = ScriptableObject.CreateInstance<XRGeneralSettingsPerBuildTarget>();
                AssetDatabase.CreateAsset(settings, SettingsPath);
            }
            EditorBuildSettings.AddConfigObject(XRGeneralSettings.k_SettingsKey, settings, true);
            if (!settings.HasSettingsForBuildTarget(target))
                settings.CreateDefaultSettingsForBuildTarget(target);
            if (!settings.HasManagerSettingsForBuildTarget(target))
                settings.CreateDefaultManagerSettingsForBuildTarget(target);

            var general = settings.SettingsForBuildTarget(target);
            var manager = settings.ManagerSettingsForBuildTarget(target);
            if (string.IsNullOrEmpty(AssetDatabase.GetAssetPath(general)))
                AssetDatabase.AddObjectToAsset(general, settings);
            if (string.IsNullOrEmpty(AssetDatabase.GetAssetPath(manager)))
                AssetDatabase.AddObjectToAsset(manager, settings);

            if (!manager.activeLoaders.Any(loader => loader != null && loader.GetType().FullName == OpenXRLoader) &&
                !XRPackageMetadataStore.AssignLoader(manager, OpenXRLoader, target))
                throw new InvalidOperationException("Could not assign Android OpenXR loader.");

            general.InitManagerOnStart = true;
            FeatureHelpers.RefreshFeatures(target);
            var openXR = OpenXRSettings.GetSettingsForBuildTargetGroup(target);
            openXR.renderMode = OpenXRSettings.RenderMode.SinglePassInstanced;
            EditorUtility.SetDirty(openXR);
            EnableFeature(target, MetaQuestFeature.featureId);
            EnableFeature(target, OculusTouchControllerProfile.featureId);
            EnableFeature(target, MetaQuestTouchPlusControllerProfile.featureId);
            PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel32;
            PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
            PlayerSettings.Android.applicationEntry = AndroidApplicationEntry.GameActivity;
            PlayerSettings.SetScriptingBackend(NamedBuildTarget.Android, ScriptingImplementation.IL2CPP);
            PlayerSettings.SetUseDefaultGraphicsAPIs(BuildTarget.Android, false);
            PlayerSettings.SetGraphicsAPIs(BuildTarget.Android, new[] { GraphicsDeviceType.Vulkan });

            EditorUtility.SetDirty(general);
            EditorUtility.SetDirty(manager);
            EditorUtility.SetDirty(settings);
            AssetDatabase.SaveAssets();
            Debug.Log("Living Park Android OpenXR configured. Run the Android Project Validation checks before building.");
        }

        private static void EnableFeature(BuildTargetGroup target, string id)
        {
            var feature = FeatureHelpers.GetFeatureWithIdForBuildTarget(target, id);
            if (feature == null)
                throw new InvalidOperationException("OpenXR feature unavailable: " + id);
            feature.enabled = true;
            EditorUtility.SetDirty(feature);
        }
    }
}
