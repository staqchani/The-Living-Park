# Mobile-to-VR migration plan

Use E:\Projects\Personals\VR Park as the independent VR project root. It is writable and already contains project documentation. The preferred E:\Projects\The Living Park VR path in the specification is outside the current writable roots. Create the Unity project only in Milestone 1 after confirming the creation workflow will preserve these documents. The mobile project remains read-only.

| Mobile implementation reviewed | VR decision |
| --- | --- |
| Assets/Offline/LocalProgress.cs, OfflineEconomyConfig.cs and VirtualCurrencyEconomy.cs | Reference integer minor units, purchase deduplication and recovery patterns. Implement a shared VR ledger and authoritative balances without mobile-profile dependencies. |
| BuildPlatform, OfflinePlacementIdentity and TDTK construction UI | Reference footprints, placement identity and costs. Replace touch/mobile UI and scene coupling with XR commands, ghost previews, atomic validation and path graph updates. |
| Peep, NavMeshPeep, PeepSpawner, PeepAIBehaviour and RegisterRequest | Reference activity categories, destinations and requests. Build bounded utility AI, demand aggregation and logical/rendered visitor separation. |
| EmployeeManager, CleanerEmployee and MechanicEmployee | Reference role responsibilities. Implement exclusive tasks, zones, salaries and measurable servicing. |
| RideController, HassansRide, RidesRegistry and RideAction | Reference ride timing, configuration and operational behavior. Rebuild queue ownership, ticketing, state machine and tracked seat anchors. |
| Shop, ShopManager and ShopAction | Reference shop needs and transactions. Implement inventory, staffing and ledger connections. |
| SaveManagerAli, SaveToJson and LocalProgress | Reference recovery and stable identity. Write an independent versioned park save. Mobile save import has no defined contract in the VR spec. |
| Mobile objective rewards and park unlocks documented in OFFLINE_MOBILE.md | Reference reward deduplication. Implement data-driven Alex missions, reputation and unlocks from the VR specification. |
| Mobile canvases, touch, TDTK and legacy network/commerce integrations | Exclude from VR import. Design tracked XR and world-space interaction for the new project. |
| Candidate mobile art | Review original license and dependency closure; extract validated visual assets only. Use original Blender replacements where rights or suitability remain unverified. |

## Integration order and risks

1. Verify project creation, package restore and XR initialization first. Match the installed Unity version where package support permits. Keep package selection explicit and review Android player settings through a real build.
2. Review candidate GUID closure, artwork provenance and Unity import metrics in a separate sandbox. FBX embedded animation, binary Unity references and runtime resource loading require import or code inspection. Record import manifests and never resolve conflicts by touching the source.
3. Prototype tabletop mode and human-scale navigation with original blockout art. Track park coordinates independently of XR tracking. Verify teleport, snap turn and transitions.
4. Build paths and authoritative simulation before attempting populated park scenes. Track CPU/GPU frame time, memory, skinned meshes and navigation work. Test destructive path edits and ride cancellations before expanding content.
5. Model motion sickness risk early. Require intensity warning, tracked head control, dependable boarding/unloading and emergency exit. Collect Quest evidence when device access is available.
6. Deliver the Grand Reopening scenario and all three operational attractions before advancing to advanced campaign. Use the tracker for exact gate dependencies.

Current risks include unknown third-party reuse rights, binary asset dependency blind spots, Android build validation pending and an ADB daemon failure. Candidate reuse can proceed only after entitlement and verification. Original replacement work remains independent.
