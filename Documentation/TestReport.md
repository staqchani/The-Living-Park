# Milestone 1 verification

## Current result

The Unity 6000.3.7f1 project contains a URP bootstrap scene and the XR foundation. The interactive Unity Editor imported the project, ran all seven EditMode tests successfully, and started the park scene with one XR Origin and zero Console errors during desktop startup. Android OpenXR settings were generated. A desktop Tab input attempt did not visibly switch modes. Quest controller tracking, mode switching and comfort remain unverified.

## Android rebuild

The first APK completed successfully. Its manifest lists Quest 3 and 3S, but its launcher is UnityPlayerActivity. The project now selects Game Activity. Build a fresh APK before headset testing.

```powershell
unity build --target Android --execute-method LivingPark.Editor.QuestFoundationSetup.BuildAndroid --output-path The-Living-Park-M1-GameActivity.apk
```

Inspect the new APK with Android SDK aapt dump xmltree and confirm UnityPlayerGameActivity and the Quest device declarations.

## Reproduce in a licensed Unity session

1. Open the VR Park root in Unity Hub with Unity 6000.3.7f1 and Android Build Support. Resolve the dependencies in Packages/manifest.json from the Unity registry or an approved Unity package cache. Confirm the Console has zero compile errors.
2. Run **Living Park → Configure Quest Foundation**. Switch the active build profile to Android. Run XR Plug-in Management → Project Validation on Android. Confirm OpenXR starts automatically, Meta Quest Support includes Quest 3 and 3S, and Oculus Touch and Meta Quest Touch Plus profiles are enabled. Verify Vulkan, ARM64, IL2CPP and single-pass instanced rendering in the active settings.
3. Run the LivingPark.XR.Tests EditMode assembly through Unity Test Runner. Expect seven cases, including a miniature transform round trip that requires the Unity runtime.
4. Open Assets/_TheLivingPark/Scenes/Park/ParkFoundation.unity and enter Play Mode. Confirm one XR Origin, two controller rays and the park environment. Tab toggles modes in the Editor, C toggles posture, and Equals cycles miniature scale while in Architect Mode. Verify the scene starts without critical errors.
5. Build an Android development APK with the Park Foundation scene. Restore ADB, authorize the headset and confirm it appears in adb devices -l. Install and start the APK on Quest 3 or 3S. Capture the build result, device and OS versions, and player log.
6. In Visitor Mode, point either controller at open ground and press its trigger to teleport. Aim beyond the ground or next to kiosk, gate or tree footprints and confirm rejected destinations leave the origin in place. Use the right stick for 30-degree snap turns. Hold and release the stick to check intentional turning behavior. Press the left secondary button to toggle seated and standing tracking requests and verify usable eye height while preserving head tracking.
7. Press the left primary button to enter Architect Mode. Confirm the model stays anchored as the user moves their head. Pan with the left stick, rotate with the right stick and cycle its scale with the right secondary button. Select a valid miniature ground location with a trigger and press the right primary button to enter Visitor Mode at the corresponding park point. Press the teleport trigger and mode button in the same input frame and verify that the origin cannot move during Architect Mode. Verify that returning via the left primary button also works and that loss of controller tracking removes its ray.

Capture any runtime errors with the reproduction steps. Milestone 2 depends on full Milestone 1 acceptance.
