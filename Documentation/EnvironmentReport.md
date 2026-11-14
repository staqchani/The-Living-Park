# Milestone 0 environment report

| Check | Observed |
| --- | --- |
| Target workspace | E:\Projects\Personals\VR Park was empty at first inspection. No existing Unity project or Git working tree was detected here. |
| Mobile source | E:\Projects\Roller Coaster Mobile contains Assets, Packages and ProjectSettings. ProjectVersion.txt records 6000.3.7f1. Manifest includes URP 17.3.0 and AI Navigation 2.0.9. |
| Unity Editor | Installed Unity 6000.3.7f1 (696ec25a53d1) at C:\Program Files\Unity\Hub\Editor\6000.3.7f1\Editor\Unity.exe. The unity executable on PATH is a CLI shim, version 1.0.0-beta.8. |
| Unity Hub | C:\Program Files\Unity Hub\Unity Hub.exe exists. |
| Blender | Installed executable reports Blender 5.2.3 LTS. |
| Python | Python 3.12.10 with Pillow 13.0.0. |
| Android SDK | Unity AndroidPlayer module present with SDK platforms 34, 35 and 36. |
| Android NDK/JDK | Bundled NDK r27c (27.2.12479018) and Temurin OpenJDK 17.0.9. |
| ADB | Bundled platform-tools 36.0.0-13206524, ADB 1.0.41. The devices command failed to start or contact its daemon. Device status is unknown. |
| Git | 2.56.0.windows.3. Workspace git status reported no repository. |
| Free storage | E: approximately 184.8 GiB and C: approximately 190.7 GiB when inspected. |

A build has yet to validate Unity licensing, package resolution or the Android toolchain end to end. For Quest verification, rerun the bundled adb devices command in a session with a functioning daemon, connect a developer-enabled Quest via USB and authorize debugging. Record the model, OS, APK and test results when a headset session actually runs.
