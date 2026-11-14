# Implementation tracker

[Master specification](MASTER_SPEC.md) is authoritative. Each source clause is linked by line; repeated clauses retain separate IDs so every source occurrence remains visible. Milestone assignments outside Â§25 are planning decisions. At kickoff in each milestone, link cross-system tasks to their actual predecessor task IDs and add runnable acceptance cases. The gate table records verification evidence and blockers. Recorded means addressed in a Milestone 0 document. Pending import means the check applies before reuse. Ongoing means a recurring instruction or reporting check. Conditional and Deferred preserve the source's qualifiers. Release criteria still apply where the source makes them mandatory.

The Grand Reopening (Â§27) is an end-to-end gate after Milestone 6 before advanced campaign work. Â§10.3 also requires three operating attractions for the first vertical slice; the Milestone 4 ride gate supplies all three before reopening acceptance. Preserve both requirements.

| Gate ID | Milestone | Depends on | Status | Acceptance and evidence |
| --- | --- | --- | --- | --- |
| M0-SPEC | 0 | â€” | Verified | Recovered source, all 2,380 lines; 48,589 UTF-8 bytes. |
| M0-ENV | 0 | â€” | Verified | [Tool inventory and limits](../Documentation/EnvironmentReport.md). |
| M0-ASSETS | 0 | M0-ENV | Verified | Recursive inventory, read-only source scan, and conditional reuse decisions in [Asset audit](../Documentation/AssetAudit.md). |
| M0-REUSE | 0 | M0-ASSETS | Blocked for individual candidates | Establish entitlement and verify dependency closure, mesh cost, materials, animation and XR behavior before any import. No assets reused in Milestone 0. Unverified candidates default to original replacements. |
| M0-PLAN | 0 | M0-ASSETS | Verified | [Migration plan](../Documentation/MigrationPlan.md) establishes target path, alternatives, and risks. |
| M0-GIT | 0 | â€” | Blocked | Git installed; workspace has no repository. Commit when a repository is available. |
| M0-GATE | 0 | M0-SPEC, M0-ENV, M0-ASSETS, M0-PLAN | Verified | Read-only audit, documented reuse decisions, and writable separate project path. Remaining candidate checks apply before reuse. |
| M1-GATE | 1 | M0-GATE | Blocked | Interactive Unity compile and 7 EditMode tests passed. Desktop scene startup and Android XR configuration observed. The original Android APK built successfully with the legacy Activity. Game Activity is now saved. Corrected APK and Quest runtime acceptance remain open. [Verification](../Documentation/TestReport.md) |
| M2-GATE | 2 | M1-GATE | Source implemented, verification deferred | Catalog, grid previews and edits, connected path layout, costs and versioned save/load are wired into Architect Mode. Unity compile and acceptance checks deferred to end of project by user direction. |
| M3-GATE | 3 | M2-GATE | Pending | Verify the Milestone 3 acceptance criteria in Â§25; attach evidence and record blockers. |
| M4-GATE | 4 | M3-GATE | Pending | Verify the Milestone 4 acceptance criteria in Â§25; attach evidence and record blockers. |
| M5-GATE | 5 | M4-GATE | Pending | Verify the Milestone 5 acceptance criteria in Â§25; attach evidence and record blockers. |
| M6-GATE | 6 | M5-GATE | Pending | Verify the Milestone 6 acceptance criteria in Â§25; attach evidence and record blockers. |
| M7-GATE | 7 | M6-GATE, VS-GATE | Pending | Verify the Milestone 7 acceptance criteria in Â§25; attach evidence and record blockers. |
| M8-GATE | 8 | M7-GATE | Pending | Verify the Milestone 8 acceptance criteria in Â§25; attach evidence and record blockers. |
| M9-GATE | 9 | M8-GATE | Pending | Verify the Milestone 9 acceptance criteria in Â§25; attach evidence and record blockers. |
| M10-GATE | 10 | M9-GATE | Pending | Verify the Milestone 10 acceptance criteria in Â§25; attach evidence and record blockers. |
| VS-GATE | 6 | M6-GATE, M4-GATE | Pending | Verify all 17 Grand Reopening steps and operation of the three initial rides. |

## Source requirements

## Mission and proposed layout

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S00-L6 | 10 | M9-GATE | Pending | [L6](MASTER_SPEC.md#L6) You are an autonomous senior Unity VR engineering team consisting of: | Trace the stated mission or discipline to delivery evidence. |
| S00-L8 | 10 | M9-GATE | Pending | [L8](MASTER_SPEC.md#L8) - Lead Unity XR Engineer | Trace the stated mission or discipline to delivery evidence. |
| S00-L9 | 10 | M9-GATE | Pending | [L9](MASTER_SPEC.md#L9) - Senior Gameplay Programmer | Trace the stated mission or discipline to delivery evidence. |
| S00-L10 | 10 | M9-GATE | Pending | [L10](MASTER_SPEC.md#L10) - VR Interaction Designer | Trace the stated mission or discipline to delivery evidence. |
| S00-L11 | 10 | M9-GATE | Pending | [L11](MASTER_SPEC.md#L11) - Game Systems Architect | Trace the stated mission or discipline to delivery evidence. |
| S00-L12 | 10 | M9-GATE | Pending | [L12](MASTER_SPEC.md#L12) - AI and Simulation Engineer | Trace the stated mission or discipline to delivery evidence. |
| S00-L13 | 10 | M9-GATE | Pending | [L13](MASTER_SPEC.md#L13) - Technical Artist and Blender Specialist | Trace the stated mission or discipline to delivery evidence. |
| S00-L14 | 10 | M9-GATE | Pending | [L14](MASTER_SPEC.md#L14) - Environment and Level Designer | Trace the stated mission or discipline to delivery evidence. |
| S00-L15 | 10 | M9-GATE | Pending | [L15](MASTER_SPEC.md#L15) - UI/UX Designer | Trace the stated mission or discipline to delivery evidence. |
| S00-L16 | 10 | M9-GATE | Pending | [L16](MASTER_SPEC.md#L16) - Audio Designer | Trace the stated mission or discipline to delivery evidence. |
| S00-L17 | 10 | M9-GATE | Pending | [L17](MASTER_SPEC.md#L17) - Performance Optimization Engineer | Trace the stated mission or discipline to delivery evidence. |
| S00-L18 | 10 | M9-GATE | Pending | [L18](MASTER_SPEC.md#L18) - QA Automation Engineer | Trace the stated mission or discipline to delivery evidence. |
| S00-L19 | 10 | M9-GATE | Pending | [L19](MASTER_SPEC.md#L19) - Technical Producer | Trace the stated mission or discipline to delivery evidence. |
| S00-L21 | 10 | M9-GATE | Pending | [L21](MASTER_SPEC.md#L21) Your mission is to **build a complete, playable, immersive amusement park management VR game called "The Living Park"** using Unity 6 LTS, C#, OpenXR, and Blender. | Trace the stated mission or discipline to delivery evidence. |
| S00-L23 | 10 | M9-GATE | Pending | [L23](MASTER_SPEC.md#L23) This is an implementation task, not merely a planning task. | Trace the stated mission or discipline to delivery evidence. |
| S00-L25 | 10 | M9-GATE | Pending | [L25](MASTER_SPEC.md#L25) Inspect the existing mobile amusement park project, reuse suitable assets, create a separate VR project, implement the game systems, produce a playable vertical slice, and progressively expand toward the complete game. | Trace the stated mission or discipline to delivery evidence. |
| S00-L27 | 10 | M9-GATE | Pending | [L27](MASTER_SPEC.md#L27) Do not stop after generating architecture documents or placeholder scripts. Implement, integrate, compile, test, and verify the actual systems. | Trace the stated mission or discipline to delivery evidence. |
| S00-L29 | 10 | M9-GATE | Pending | [L29](MASTER_SPEC.md#L29) Prioritize a stable, enjoyable, performant VR experience over implementing a large number of unfinished features. | Trace the stated mission or discipline to delivery evidence. |
| S06-L442 | 1 | M0-GATE | Conditional | [L442](MASTER_SPEC.md#L442) _TheLivingPark/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L443 | 1 | M0-GATE | Conditional | [L443](MASTER_SPEC.md#L443) Art/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L444 | 1 | M0-GATE | Conditional | [L444](MASTER_SPEC.md#L444) Characters/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L445 | 1 | M0-GATE | Conditional | [L445](MASTER_SPEC.md#L445) Attractions/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L446 | 1 | M0-GATE | Conditional | [L446](MASTER_SPEC.md#L446) Buildings/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L447 | 1 | M0-GATE | Conditional | [L447](MASTER_SPEC.md#L447) Environment/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L448 | 1 | M0-GATE | Conditional | [L448](MASTER_SPEC.md#L448) Props/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L449 | 1 | M0-GATE | Conditional | [L449](MASTER_SPEC.md#L449) Materials/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L450 | 1 | M0-GATE | Conditional | [L450](MASTER_SPEC.md#L450) Textures/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L451 | 1 | M0-GATE | Conditional | [L451](MASTER_SPEC.md#L451) VFX/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L452 | 1 | M0-GATE | Conditional | [L452](MASTER_SPEC.md#L452) Audio/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L453 | 1 | M0-GATE | Conditional | [L453](MASTER_SPEC.md#L453) Ambient/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L454 | 1 | M0-GATE | Conditional | [L454](MASTER_SPEC.md#L454) Music/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L455 | 1 | M0-GATE | Conditional | [L455](MASTER_SPEC.md#L455) Rides/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L456 | 1 | M0-GATE | Conditional | [L456](MASTER_SPEC.md#L456) UI/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L457 | 1 | M0-GATE | Conditional | [L457](MASTER_SPEC.md#L457) Visitors/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L458 | 1 | M0-GATE | Conditional | [L458](MASTER_SPEC.md#L458) Animations/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L459 | 1 | M0-GATE | Conditional | [L459](MASTER_SPEC.md#L459) Prefabs/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L460 | 1 | M0-GATE | Conditional | [L460](MASTER_SPEC.md#L460) Attractions/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L461 | 1 | M0-GATE | Conditional | [L461](MASTER_SPEC.md#L461) Visitors/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L462 | 1 | M0-GATE | Conditional | [L462](MASTER_SPEC.md#L462) Employees/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L463 | 1 | M0-GATE | Conditional | [L463](MASTER_SPEC.md#L463) Buildings/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L464 | 1 | M0-GATE | Conditional | [L464](MASTER_SPEC.md#L464) Environment/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L465 | 1 | M0-GATE | Conditional | [L465](MASTER_SPEC.md#L465) UI/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L466 | 1 | M0-GATE | Conditional | [L466](MASTER_SPEC.md#L466) XR/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L467 | 1 | M0-GATE | Conditional | [L467](MASTER_SPEC.md#L467) Scenes/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L468 | 1 | M0-GATE | Conditional | [L468](MASTER_SPEC.md#L468) Bootstrap/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L469 | 1 | M0-GATE | Conditional | [L469](MASTER_SPEC.md#L469) MainMenu/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L470 | 1 | M0-GATE | Conditional | [L470](MASTER_SPEC.md#L470) Park/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L471 | 1 | M0-GATE | Conditional | [L471](MASTER_SPEC.md#L471) Testing/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L472 | 1 | M0-GATE | Conditional | [L472](MASTER_SPEC.md#L472) Scripts/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L473 | 1 | M0-GATE | Conditional | [L473](MASTER_SPEC.md#L473) Core/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L474 | 1 | M0-GATE | Conditional | [L474](MASTER_SPEC.md#L474) Simulation/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L475 | 1 | M0-GATE | Conditional | [L475](MASTER_SPEC.md#L475) Economy/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L476 | 1 | M0-GATE | Conditional | [L476](MASTER_SPEC.md#L476) Construction/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L477 | 1 | M0-GATE | Conditional | [L477](MASTER_SPEC.md#L477) Attractions/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L478 | 1 | M0-GATE | Conditional | [L478](MASTER_SPEC.md#L478) Visitors/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L479 | 1 | M0-GATE | Conditional | [L479](MASTER_SPEC.md#L479) Employees/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L480 | 1 | M0-GATE | Conditional | [L480](MASTER_SPEC.md#L480) Navigation/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L481 | 1 | M0-GATE | Conditional | [L481](MASTER_SPEC.md#L481) XR/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L482 | 1 | M0-GATE | Conditional | [L482](MASTER_SPEC.md#L482) UI/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L483 | 1 | M0-GATE | Conditional | [L483](MASTER_SPEC.md#L483) Campaign/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L484 | 1 | M0-GATE | Conditional | [L484](MASTER_SPEC.md#L484) Progression/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L485 | 1 | M0-GATE | Conditional | [L485](MASTER_SPEC.md#L485) Persistence/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L486 | 1 | M0-GATE | Conditional | [L486](MASTER_SPEC.md#L486) Audio/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L487 | 1 | M0-GATE | Conditional | [L487](MASTER_SPEC.md#L487) Optimization/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L488 | 1 | M0-GATE | Conditional | [L488](MASTER_SPEC.md#L488) Debugging/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L489 | 1 | M0-GATE | Conditional | [L489](MASTER_SPEC.md#L489) ScriptableObjects/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L490 | 1 | M0-GATE | Conditional | [L490](MASTER_SPEC.md#L490) Attractions/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L491 | 1 | M0-GATE | Conditional | [L491](MASTER_SPEC.md#L491) Visitors/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L492 | 1 | M0-GATE | Conditional | [L492](MASTER_SPEC.md#L492) Employees/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L493 | 1 | M0-GATE | Conditional | [L493](MASTER_SPEC.md#L493) Shops/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L494 | 1 | M0-GATE | Conditional | [L494](MASTER_SPEC.md#L494) Missions/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L495 | 1 | M0-GATE | Conditional | [L495](MASTER_SPEC.md#L495) Economy/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L496 | 1 | M0-GATE | Conditional | [L496](MASTER_SPEC.md#L496) Settings/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L497 | 1 | M0-GATE | Conditional | [L497](MASTER_SPEC.md#L497) Settings/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L498 | 1 | M0-GATE | Conditional | [L498](MASTER_SPEC.md#L498) Tests/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L499 | 1 | M0-GATE | Conditional | [L499](MASTER_SPEC.md#L499) EditMode/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L500 | 1 | M0-GATE | Conditional | [L500](MASTER_SPEC.md#L500) PlayMode/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L501 | 1 | M0-GATE | Conditional | [L501](MASTER_SPEC.md#L501) Resources/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L502 | 1 | M0-GATE | Conditional | [L502](MASTER_SPEC.md#L502) Addressables/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L505 | 1 | M0-GATE | Conditional | [L505](MASTER_SPEC.md#L505) Blender/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L506 | 1 | M0-GATE | Conditional | [L506](MASTER_SPEC.md#L506) Models/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L507 | 1 | M0-GATE | Conditional | [L507](MASTER_SPEC.md#L507) Scripts/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L508 | 1 | M0-GATE | Conditional | [L508](MASTER_SPEC.md#L508) Rigs/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L509 | 1 | M0-GATE | Conditional | [L509](MASTER_SPEC.md#L509) Animations/ | Create the suggested folder when needed, or record its equivalent location. |
| S06-L512 | 1 | M0-GATE | Conditional | [L512](MASTER_SPEC.md#L512) AssetAudit.md | Create the suggested folder when needed, or record its equivalent location. |
| S06-L513 | 1 | M0-GATE | Conditional | [L513](MASTER_SPEC.md#L513) AssetInventory.csv | Create the suggested folder when needed, or record its equivalent location. |
| S06-L514 | 1 | M0-GATE | Conditional | [L514](MASTER_SPEC.md#L514) MigrationPlan.md | Create the suggested folder when needed, or record its equivalent location. |
| S06-L515 | 1 | M0-GATE | Conditional | [L515](MASTER_SPEC.md#L515) Architecture.md | Create the suggested folder when needed, or record its equivalent location. |
| S06-L516 | 1 | M0-GATE | Conditional | [L516](MASTER_SPEC.md#L516) DevelopmentLog.md | Create the suggested folder when needed, or record its equivalent location. |
| S06-L517 | 1 | M0-GATE | Conditional | [L517](MASTER_SPEC.md#L517) PerformanceReport.md | Create the suggested folder when needed, or record its equivalent location. |
| S06-L518 | 1 | M0-GATE | Conditional | [L518](MASTER_SPEC.md#L518) TestReport.md | Create the suggested folder when needed, or record its equivalent location. |
| S06-L519 | 1 | M0-GATE | Conditional | [L519](MASTER_SPEC.md#L519) KnownIssues.md | Create the suggested folder when needed, or record its equivalent location. |

### 1. PROJECT INFORMATION

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S01-L35 | 1 | M0-GATE | Pending | [L35](MASTER_SPEC.md#L35) **Game Title:** The Living Park | Verify **Game Title:** The Living Park |
| S01-L37 | 1 | M0-GATE | Pending | [L37](MASTER_SPEC.md#L37) **Genre:** VR Amusement Park Management / Tycoon / Simulation / Immersive Sandbox | Verify **Genre:** VR Amusement Park Management / Tycoon / Simulation / Immersive Sandbox |
| S01-L39 | 1 | M0-GATE | Pending | [L39](MASTER_SPEC.md#L39) **Primary Platform:** Meta Quest 3 and Quest 3S standalone | Verify **Primary Platform:** Meta Quest 3 and Quest 3S standalone |
| S01-L41 | 1 | M0-GATE | Pending | [L41](MASTER_SPEC.md#L41) **Secondary Compatibility Target:** Meta Quest 2, using reduced visual and simulation quality where required | Verify **Secondary Compatibility Target:** Meta Quest 2, using reduced visual and simulation quality where required |
| S01-L43 | 1 | M0-GATE | Pending | [L43](MASTER_SPEC.md#L43) **Game Engine:** Unity 6 LTS, using an installed supported version | Verify **Game Engine:** Unity 6 LTS, using an installed supported version |
| S01-L45 | 1 | M0-GATE | Pending | [L45](MASTER_SPEC.md#L45) **Language:** C# | Verify **Language:** C# |
| S01-L47 | 1 | M0-GATE | Pending | [L47](MASTER_SPEC.md#L47) **Render Pipeline:** Universal Render Pipeline (URP) | Verify **Render Pipeline:** Universal Render Pipeline (URP) |
| S01-L49 | 1 | M0-GATE | Pending | [L49](MASTER_SPEC.md#L49) **XR Runtime:** OpenXR with Meta Quest-compatible features | Verify **XR Runtime:** OpenXR with Meta Quest-compatible features |
| S01-L51 | 1 | M0-GATE | Pending | [L51](MASTER_SPEC.md#L51) **XR Interaction:** Unity XR Interaction Toolkit and Input System | Verify **XR Interaction:** Unity XR Interaction Toolkit and Input System |
| S01-L53 | 1 | M0-GATE | Pending | [L53](MASTER_SPEC.md#L53) **3D Asset Creation:** Blender, preferably using Python automation | Verify **3D Asset Creation:** Blender, preferably using Python automation |
| S01-L55 | 1 | M0-GATE | Pending | [L55](MASTER_SPEC.md#L55) **Visual Style:** Stylized realistic, colorful, visually appealing, optimized for standalone VR | Verify **Visual Style:** Stylized realistic, colorful, visually appealing, optimized for standalone VR |
| S01-L57 | 1 | M0-GATE | Pending | [L57](MASTER_SPEC.md#L57) **Gameplay:** Offline single-player first, with an extensible architecture for future multiplayer | Verify **Gameplay:** Offline single-player first, with an extensible architecture for future multiplayer |
| S01-L59 | 1 | M0-GATE | Pending | [L59](MASTER_SPEC.md#L59) **Primary Input:** Meta Quest Touch controllers | Verify **Primary Input:** Meta Quest Touch controllers |
| S01-L61 | 1 | M0-GATE | Conditional | [L61](MASTER_SPEC.md#L61) **Optional Input:** Hand tracking only after controller gameplay is complete and verified | Verify **Optional Input:** Hand tracking only after controller gameplay is complete and verified |
| S01-L63 | 1 | M0-GATE | Pending | [L63](MASTER_SPEC.md#L63) **Target Refresh Rate:** 72 Hz baseline, with 90 Hz as an optimization goal on supported devices | Verify **Target Refresh Rate:** 72 Hz baseline, with 90 Hz as an optimization goal on supported devices |
| S01-L65 | 1 | M0-GATE | Pending | [L65](MASTER_SPEC.md#L65) **Project Scope:** Create a new Unity VR project, selectively reusing existing mobile game assets and systems | Verify **Project Scope:** Create a new Unity VR project, selectively reusing existing mobile game assets and systems |
| S01-L69 | 1 | M0-GATE | Pending | [L69](MASTER_SPEC.md#L69) Source Asset Directory / `E:\Projects\Roller Coaster Mobile\Assets` | Verify Source Asset Directory / `E:\Projects\Roller Coaster Mobile\Assets` |
| S01-L73 | 1 | M0-GATE | Pending | [L73](MASTER_SPEC.md#L73) New Project Directory / Prefer: | Verify New Project Directory / Prefer: |
| S01-L75 | 1 | M0-GATE | Pending | [L75](MASTER_SPEC.md#L75) New Project Directory / `E:\Projects\The Living Park VR` | Verify New Project Directory / `E:\Projects\The Living Park VR` |
| S01-L77 | 1 | M0-GATE | Pending | [L77](MASTER_SPEC.md#L77) New Project Directory / If the workspace or permissions prevent creation at this path, use an appropriate accessible workspace and document the chosen location. | Verify New Project Directory / If the workspace or permissions prevent creation at this path, use an appropriate accessible workspace and document the chosen location. |
| S01-L79 | 1 | M0-GATE | Pending | [L79](MASTER_SPEC.md#L79) New Project Directory / **CRITICAL:** | Verify New Project Directory / **CRITICAL:** |
| S01-L81 | 1 | M0-GATE | Pending | [L81](MASTER_SPEC.md#L81) New Project Directory / The existing mobile project is a valuable source project. Never modify, delete, rename, overwrite, or reimport files inside the original source project. | Verify New Project Directory / The existing mobile project is a valuable source project. Never modify, delete, rename, overwrite, or reimport files inside the original source project. |
| S01-L83 | 1 | M0-GATE | Pending | [L83](MASTER_SPEC.md#L83) New Project Directory / Create an independent VR project. | Verify New Project Directory / Create an independent VR project. |
| S01-L85 | 1 | M0-GATE | Pending | [L85](MASTER_SPEC.md#L85) New Project Directory / Preserve original assets and their licenses. | Verify New Project Directory / Preserve original assets and their licenses. |
| S01-L87 | 1 | M0-GATE | Pending | [L87](MASTER_SPEC.md#L87) New Project Directory / Do not assume any asset is compatible until inspected. | Verify New Project Directory / Do not assume any asset is compatible until inspected. |

### 2. GAME VISION

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S02-L93 | 7 | M6-GATE | Pending | [L93](MASTER_SPEC.md#L93) The Living Park is a VR amusement park management simulation in which the player inherits an abandoned amusement park and gradually transforms it into a world-class entertainment destination. | Verify The Living Park is a VR amusement park management simulation in which the player inherits an abandoned amusement park and gradually transforms it into a world-class entertainment destination. |
| S02-L95 | 7 | M6-GATE | Pending | [L95](MASTER_SPEC.md#L95) Unlike traditional park management games, the player can physically enter and experience the park they create. | Verify Unlike traditional park management games, the player can physically enter and experience the park they create. |
| S02-L97 | 7 | M6-GATE | Pending | [L97](MASTER_SPEC.md#L97) The game must combine three gameplay pillars: | Verify The game must combine three gameplay pillars: |
| S02-L101 | 7 | M6-GATE | Pending | [L101](MASTER_SPEC.md#L101) CREATE / Design and construct attractions, shops, paths, decorations, themed areas, and park facilities. | Verify CREATE / Design and construct attractions, shops, paths, decorations, themed areas, and park facilities. |
| S02-L105 | 7 | M6-GATE | Pending | [L105](MASTER_SPEC.md#L105) MANAGE / Operate a profitable amusement park by satisfying visitors, managing employees, maintaining attractions, controlling finances, and expanding operations. | Verify MANAGE / Operate a profitable amusement park by satisfying visitors, managing employees, maintaining attractions, controlling finances, and expanding operations. |
| S02-L109 | 7 | M6-GATE | Pending | [L109](MASTER_SPEC.md#L109) EXPERIENCE / Walk through the park in first-person VR, interact with visitors and staff, board attractions, and personally enjoy the amusement park. | Verify EXPERIENCE / Walk through the park in first-person VR, interact with visitors and staff, board attractions, and personally enjoy the amusement park. |
| S02-L111 | 7 | M6-GATE | Pending | [L111](MASTER_SPEC.md#L111) EXPERIENCE / All three pillars must be integrated into one persistent simulation. | Verify EXPERIENCE / All three pillars must be integrated into one persistent simulation. |
| S02-L113 | 7 | M6-GATE | Pending | [L113](MASTER_SPEC.md#L113) EXPERIENCE / The game should feel alive. | Verify EXPERIENCE / The game should feel alive. |
| S02-L115 | 7 | M6-GATE | Pending | [L115](MASTER_SPEC.md#L115) EXPERIENCE / Visitors should have meaningful needs, behaviors, destinations, reactions, and consequences. | Verify EXPERIENCE / Visitors should have meaningful needs, behaviors, destinations, reactions, and consequences. |
| S02-L117 | 7 | M6-GATE | Pending | [L117](MASTER_SPEC.md#L117) EXPERIENCE / Employees should visibly perform their assigned jobs. | Verify EXPERIENCE / Employees should visibly perform their assigned jobs. |
| S02-L119 | 7 | M6-GATE | Pending | [L119](MASTER_SPEC.md#L119) EXPERIENCE / Attractions should operate as functioning interactive experiences rather than decorative objects. | Verify EXPERIENCE / Attractions should operate as functioning interactive experiences rather than decorative objects. |
| S02-L121 | 7 | M6-GATE | Pending | [L121](MASTER_SPEC.md#L121) EXPERIENCE / Management decisions should visibly affect the park. | Verify EXPERIENCE / Management decisions should visibly affect the park. |

### 3. STORY AND CAMPAIGN

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S03-L131 | 7 | M6-GATE | Pending | [L131](MASTER_SPEC.md#L131) Prologue: The Forgotten Wonderland / The player inherits an abandoned amusement park. | Verify Prologue: The Forgotten Wonderland / The player inherits an abandoned amusement park. |
| S03-L133 | 7 | M6-GATE | Pending | [L133](MASTER_SPEC.md#L133) Prologue: The Forgotten Wonderland / The entrance is damaged, the pathways are overgrown, and several attractions are no longer operational. | Verify Prologue: The Forgotten Wonderland / The entrance is damaged, the pathways are overgrown, and several attractions are no longer operational. |
| S03-L135 | 7 | M6-GATE | Pending | [L135](MASTER_SPEC.md#L135) Prologue: The Forgotten Wonderland / A friendly AI park advisor named Alex introduces the player to the location. | Verify Prologue: The Forgotten Wonderland / A friendly AI park advisor named Alex introduces the player to the location. |
| S03-L137 | 7 | M6-GATE | Pending | [L137](MASTER_SPEC.md#L137) Prologue: The Forgotten Wonderland / Opening dialogue: | Verify Prologue: The Forgotten Wonderland / Opening dialogue: |
| S03-L139 | 7 | M6-GATE | Pending | [L139](MASTER_SPEC.md#L139) Prologue: The Forgotten Wonderland / "Welcome, Boss! This park used to bring happiness to thousands of people. Families came here to celebrate, children experienced their first roller coaster, and every corner was filled with laughter. But the magic disappeared. Now it's your turn to bring it back." | Verify Prologue: The Forgotten Wonderland / "Welcome, Boss! This park used to bring happiness to thousands of people. Families came here to celebrate, children experienced their first roller coaster, and every corner was filled with laughter. But the magic disappeared. Now it's your turn to bring it back." |
| S03-L141 | 7 | M6-GATE | Pending | [L141](MASTER_SPEC.md#L141) Prologue: The Forgotten Wonderland / The player receives a small starting budget, a limited buildable area, and a few basic construction options. | Verify Prologue: The Forgotten Wonderland / The player receives a small starting budget, a limited buildable area, and a few basic construction options. |
| S03-L143 | 7 | M6-GATE | Pending | [L143](MASTER_SPEC.md#L143) Prologue: The Forgotten Wonderland / The player's first goal is to restore the park and reopen its gates. | Verify Prologue: The Forgotten Wonderland / The player's first goal is to restore the park and reopen its gates. |
| S03-L147 | 7 | M6-GATE | Pending | [L147](MASTER_SPEC.md#L147) Chapter 1: The Grand Reopening / Objectives: | Verify Chapter 1: The Grand Reopening / Objectives: |
| S03-L149 | 7 | M6-GATE | Pending | [L149](MASTER_SPEC.md#L149) Chapter 1: The Grand Reopening / Objectives / Inspect the abandoned park. | Demonstrate or document Chapter 1: The Grand Reopening / Inspect the abandoned park. |
| S03-L150 | 7 | M6-GATE | Pending | [L150](MASTER_SPEC.md#L150) Chapter 1: The Grand Reopening / Objectives / Restore the entrance. | Demonstrate or document Chapter 1: The Grand Reopening / Restore the entrance. |
| S03-L151 | 7 | M6-GATE | Pending | [L151](MASTER_SPEC.md#L151) Chapter 1: The Grand Reopening / Objectives / Construct a connected pedestrian pathway. | Demonstrate or document Chapter 1: The Grand Reopening / Construct a connected pedestrian pathway. |
| S03-L152 | 7 | M6-GATE | Pending | [L152](MASTER_SPEC.md#L152) Chapter 1: The Grand Reopening / Objectives / Place a basic attraction. | Demonstrate or document Chapter 1: The Grand Reopening / Place a basic attraction. |
| S03-L153 | 7 | M6-GATE | Pending | [L153](MASTER_SPEC.md#L153) Chapter 1: The Grand Reopening / Objectives / Build a food or drink stall. | Demonstrate or document Chapter 1: The Grand Reopening / Build a food or drink stall. |
| S03-L154 | 7 | M6-GATE | Pending | [L154](MASTER_SPEC.md#L154) Chapter 1: The Grand Reopening / Objectives / Install benches and trash bins. | Demonstrate or document Chapter 1: The Grand Reopening / Install benches and trash bins. |
| S03-L155 | 7 | M6-GATE | Pending | [L155](MASTER_SPEC.md#L155) Chapter 1: The Grand Reopening / Objectives / Hire the first cleaner. | Demonstrate or document Chapter 1: The Grand Reopening / Hire the first cleaner. |
| S03-L156 | 7 | M6-GATE | Pending | [L156](MASTER_SPEC.md#L156) Chapter 1: The Grand Reopening / Objectives / Set an attraction ticket price. | Demonstrate or document Chapter 1: The Grand Reopening / Set an attraction ticket price. |
| S03-L157 | 7 | M6-GATE | Pending | [L157](MASTER_SPEC.md#L157) Chapter 1: The Grand Reopening / Objectives / Open the park. | Demonstrate or document Chapter 1: The Grand Reopening / Open the park. |
| S03-L158 | 7 | M6-GATE | Pending | [L158](MASTER_SPEC.md#L158) Chapter 1: The Grand Reopening / Objectives / Welcome the first visitors. | Demonstrate or document Chapter 1: The Grand Reopening / Welcome the first visitors. |
| S03-L160 | 7 | M6-GATE | Pending | [L160](MASTER_SPEC.md#L160) Chapter 1: The Grand Reopening / When the park opens, visitors enter through the gates and navigate toward available attractions. | Verify Chapter 1: The Grand Reopening / When the park opens, visitors enter through the gates and navigate toward available attractions. |
| S03-L162 | 7 | M6-GATE | Pending | [L162](MASTER_SPEC.md#L162) Chapter 1: The Grand Reopening / Their needs and spending begin the economy simulation. | Verify Chapter 1: The Grand Reopening / Their needs and spending begin the economy simulation. |
| S03-L164 | 7 | M6-GATE | Pending | [L164](MASTER_SPEC.md#L164) Chapter 1: The Grand Reopening / Reward: | Verify Chapter 1: The Grand Reopening / Reward: |
| S03-L166 | 7 | M6-GATE | Pending | [L166](MASTER_SPEC.md#L166) Chapter 1: The Grand Reopening / Reward / New attraction unlock | Demonstrate or document Chapter 1: The Grand Reopening / New attraction unlock |
| S03-L167 | 7 | M6-GATE | Pending | [L167](MASTER_SPEC.md#L167) Chapter 1: The Grand Reopening / Reward / Additional construction budget | Demonstrate or document Chapter 1: The Grand Reopening / Additional construction budget |
| S03-L168 | 7 | M6-GATE | Pending | [L168](MASTER_SPEC.md#L168) Chapter 1: The Grand Reopening / Reward / First reputation star | Demonstrate or document Chapter 1: The Grand Reopening / First reputation star |
| S03-L172 | 7 | M6-GATE | Pending | [L172](MASTER_SPEC.md#L172) Chapter 2: Every Visitor Has a Story / Introduce visitor personalities, demands, and satisfaction. | Verify Chapter 2: Every Visitor Has a Story / Introduce visitor personalities, demands, and satisfaction. |
| S03-L174 | 7 | M6-GATE | Pending | [L174](MASTER_SPEC.md#L174) Chapter 2: Every Visitor Has a Story / Visitors may request: | Verify Chapter 2: Every Visitor Has a Story / Visitors may request: |
| S03-L176 | 7 | M6-GATE | Pending | [L176](MASTER_SPEC.md#L176) Chapter 2: Every Visitor Has a Story / Visitors may request / Roller coasters | Demonstrate or document Chapter 2: Every Visitor Has a Story / Roller coasters |
| S03-L177 | 7 | M6-GATE | Pending | [L177](MASTER_SPEC.md#L177) Chapter 2: Every Visitor Has a Story / Visitors may request / Family rides | Demonstrate or document Chapter 2: Every Visitor Has a Story / Family rides |
| S03-L178 | 7 | M6-GATE | Pending | [L178](MASTER_SPEC.md#L178) Chapter 2: Every Visitor Has a Story / Visitors may request / Gentle attractions | Demonstrate or document Chapter 2: Every Visitor Has a Story / Gentle attractions |
| S03-L179 | 7 | M6-GATE | Pending | [L179](MASTER_SPEC.md#L179) Chapter 2: Every Visitor Has a Story / Visitors may request / Food and drinks | Demonstrate or document Chapter 2: Every Visitor Has a Story / Food and drinks |
| S03-L180 | 7 | M6-GATE | Pending | [L180](MASTER_SPEC.md#L180) Chapter 2: Every Visitor Has a Story / Visitors may request / Restrooms | Demonstrate or document Chapter 2: Every Visitor Has a Story / Restrooms |
| S03-L181 | 7 | M6-GATE | Pending | [L181](MASTER_SPEC.md#L181) Chapter 2: Every Visitor Has a Story / Visitors may request / Seating areas | Demonstrate or document Chapter 2: Every Visitor Has a Story / Seating areas |
| S03-L182 | 7 | M6-GATE | Pending | [L182](MASTER_SPEC.md#L182) Chapter 2: Every Visitor Has a Story / Visitors may request / Shade | Demonstrate or document Chapter 2: Every Visitor Has a Story / Shade |
| S03-L183 | 7 | M6-GATE | Pending | [L183](MASTER_SPEC.md#L183) Chapter 2: Every Visitor Has a Story / Visitors may request / Better cleanliness | Demonstrate or document Chapter 2: Every Visitor Has a Story / Better cleanliness |
| S03-L184 | 7 | M6-GATE | Pending | [L184](MASTER_SPEC.md#L184) Chapter 2: Every Visitor Has a Story / Visitors may request / Shorter queues | Demonstrate or document Chapter 2: Every Visitor Has a Story / Shorter queues |
| S03-L185 | 7 | M6-GATE | Pending | [L185](MASTER_SPEC.md#L185) Chapter 2: Every Visitor Has a Story / Visitors may request / Affordable prices | Demonstrate or document Chapter 2: Every Visitor Has a Story / Affordable prices |
| S03-L186 | 7 | M6-GATE | Pending | [L186](MASTER_SPEC.md#L186) Chapter 2: Every Visitor Has a Story / Visitors may request / Additional themed decorations | Demonstrate or document Chapter 2: Every Visitor Has a Story / Additional themed decorations |
| S03-L188 | 7 | M6-GATE | Pending | [L188](MASTER_SPEC.md#L188) Chapter 2: Every Visitor Has a Story / The player must observe visitor thoughts and prioritize construction decisions. | Verify Chapter 2: Every Visitor Has a Story / The player must observe visitor thoughts and prioritize construction decisions. |
| S03-L190 | 7 | M6-GATE | Pending | [L190](MASTER_SPEC.md#L190) Chapter 2: Every Visitor Has a Story / Not every request must be fulfilled immediately. | Verify Chapter 2: Every Visitor Has a Story / Not every request must be fulfilled immediately. |
| S03-L192 | 7 | M6-GATE | Pending | [L192](MASTER_SPEC.md#L192) Chapter 2: Every Visitor Has a Story / Requests should be aggregated and weighted by demand, cost, reputation, and expected profitability. | Verify Chapter 2: Every Visitor Has a Story / Requests should be aggregated and weighted by demand, cost, reputation, and expected profitability. |
| S03-L196 | 7 | M6-GATE | Pending | [L196](MASTER_SPEC.md#L196) Chapter 3: Behind the Magic / Introduce operational management. | Verify Chapter 3: Behind the Magic / Introduce operational management. |
| S03-L198 | 7 | M6-GATE | Pending | [L198](MASTER_SPEC.md#L198) Chapter 3: Behind the Magic / Challenges include: | Verify Chapter 3: Behind the Magic / Challenges include: |
| S03-L200 | 7 | M6-GATE | Pending | [L200](MASTER_SPEC.md#L200) Chapter 3: Behind the Magic / Challenges include / Litter accumulation | Demonstrate or document Chapter 3: Behind the Magic / Litter accumulation |
| S03-L201 | 7 | M6-GATE | Pending | [L201](MASTER_SPEC.md#L201) Chapter 3: Behind the Magic / Challenges include / Vomit after intense attractions | Demonstrate or document Chapter 3: Behind the Magic / Vomit after intense attractions |
| S03-L202 | 7 | M6-GATE | Pending | [L202](MASTER_SPEC.md#L202) Chapter 3: Behind the Magic / Challenges include / Long queues | Demonstrate or document Chapter 3: Behind the Magic / Long queues |
| S03-L203 | 7 | M6-GATE | Pending | [L203](MASTER_SPEC.md#L203) Chapter 3: Behind the Magic / Challenges include / Broken rides | Demonstrate or document Chapter 3: Behind the Magic / Broken rides |
| S03-L204 | 7 | M6-GATE | Pending | [L204](MASTER_SPEC.md#L204) Chapter 3: Behind the Magic / Challenges include / Maintenance costs | Demonstrate or document Chapter 3: Behind the Magic / Maintenance costs |
| S03-L205 | 7 | M6-GATE | Pending | [L205](MASTER_SPEC.md#L205) Chapter 3: Behind the Magic / Challenges include / Employee salaries | Demonstrate or document Chapter 3: Behind the Magic / Employee salaries |
| S03-L206 | 7 | M6-GATE | Pending | [L206](MASTER_SPEC.md#L206) Chapter 3: Behind the Magic / Challenges include / Shop inventory | Demonstrate or document Chapter 3: Behind the Magic / Shop inventory |
| S03-L207 | 7 | M6-GATE | Pending | [L207](MASTER_SPEC.md#L207) Chapter 3: Behind the Magic / Challenges include / Staff fatigue | Demonstrate or document Chapter 3: Behind the Magic / Staff fatigue |
| S03-L208 | 7 | M6-GATE | Pending | [L208](MASTER_SPEC.md#L208) Chapter 3: Behind the Magic / Challenges include / Visitor dissatisfaction | Demonstrate or document Chapter 3: Behind the Magic / Visitor dissatisfaction |
| S03-L210 | 7 | M6-GATE | Pending | [L210](MASTER_SPEC.md#L210) Chapter 3: Behind the Magic / The player must hire employees, assign responsibilities, and improve operations. | Verify Chapter 3: Behind the Magic / The player must hire employees, assign responsibilities, and improve operations. |
| S03-L214 | 7 | M6-GATE | Pending | [L214](MASTER_SPEC.md#L214) Chapter 4: Expansion and Discovery / Unlock additional land and themed zones. | Verify Chapter 4: Expansion and Discovery / Unlock additional land and themed zones. |
| S03-L216 | 7 | M6-GATE | Conditional | [L216](MASTER_SPEC.md#L216) Chapter 4: Expansion and Discovery / Potential areas: | Verify Chapter 4: Expansion and Discovery / Potential areas: |
| S03-L218 | 7 | M6-GATE | Pending | [L218](MASTER_SPEC.md#L218) Chapter 4: Expansion and Discovery / Potential areas / Fantasy Kingdom | Demonstrate or document Chapter 4: Expansion and Discovery / Fantasy Kingdom |
| S03-L219 | 7 | M6-GATE | Pending | [L219](MASTER_SPEC.md#L219) Chapter 4: Expansion and Discovery / Potential areas / Pirate Cove | Demonstrate or document Chapter 4: Expansion and Discovery / Pirate Cove |
| S03-L220 | 7 | M6-GATE | Pending | [L220](MASTER_SPEC.md#L220) Chapter 4: Expansion and Discovery / Potential areas / Dino Valley | Demonstrate or document Chapter 4: Expansion and Discovery / Dino Valley |
| S03-L221 | 7 | M6-GATE | Pending | [L221](MASTER_SPEC.md#L221) Chapter 4: Expansion and Discovery / Potential areas / Adventure Island | Demonstrate or document Chapter 4: Expansion and Discovery / Adventure Island |
| S03-L222 | 7 | M6-GATE | Pending | [L222](MASTER_SPEC.md#L222) Chapter 4: Expansion and Discovery / Potential areas / Future World | Demonstrate or document Chapter 4: Expansion and Discovery / Future World |
| S03-L224 | 7 | M6-GATE | Pending | [L224](MASTER_SPEC.md#L224) Chapter 4: Expansion and Discovery / Each zone introduces new decorations, attractions, visitor preferences, and management challenges. | Verify Chapter 4: Expansion and Discovery / Each zone introduces new decorations, attractions, visitor preferences, and management challenges. |
| S03-L228 | 7 | M6-GATE | Pending | [L228](MASTER_SPEC.md#L228) Chapter 5: Experience Your Creation / Introduce the immersive VR attraction system. | Verify Chapter 5: Experience Your Creation / Introduce the immersive VR attraction system. |
| S03-L230 | 7 | M6-GATE | Pending | [L230](MASTER_SPEC.md#L230) Chapter 5: Experience Your Creation / The player can: | Verify Chapter 5: Experience Your Creation / The player can: |
| S03-L232 | 7 | M6-GATE | Pending | [L232](MASTER_SPEC.md#L232) Chapter 5: Experience Your Creation / The player can / Walk through the park. | Demonstrate or document Chapter 5: Experience Your Creation / Walk through the park. |
| S03-L233 | 7 | M6-GATE | Pending | [L233](MASTER_SPEC.md#L233) Chapter 5: Experience Your Creation / The player can / Join attraction queues. | Demonstrate or document Chapter 5: Experience Your Creation / Join attraction queues. |
| S03-L234 | 7 | M6-GATE | Pending | [L234](MASTER_SPEC.md#L234) Chapter 5: Experience Your Creation / The player can / Board functioning rides. | Demonstrate or document Chapter 5: Experience Your Creation / Board functioning rides. |
| S03-L235 | 7 | M6-GATE | Pending | [L235](MASTER_SPEC.md#L235) Chapter 5: Experience Your Creation / The player can / Experience a roller coaster. | Demonstrate or document Chapter 5: Experience Your Creation / Experience a roller coaster. |
| S03-L236 | 7 | M6-GATE | Pending | [L236](MASTER_SPEC.md#L236) Chapter 5: Experience Your Creation / The player can / Ride a Ferris wheel. | Demonstrate or document Chapter 5: Experience Your Creation / Ride a Ferris wheel. |
| S03-L237 | 7 | M6-GATE | Pending | [L237](MASTER_SPEC.md#L237) Chapter 5: Experience Your Creation / The player can / Enjoy a carousel. | Demonstrate or document Chapter 5: Experience Your Creation / Enjoy a carousel. |
| S03-L238 | 7 | M6-GATE | Pending | [L238](MASTER_SPEC.md#L238) Chapter 5: Experience Your Creation / The player can / Inspect attractions. | Demonstrate or document Chapter 5: Experience Your Creation / Inspect attractions. |
| S03-L239 | 7 | M6-GATE | Pending | [L239](MASTER_SPEC.md#L239) Chapter 5: Experience Your Creation / The player can / Observe visitors during rides. | Demonstrate or document Chapter 5: Experience Your Creation / Observe visitors during rides. |
| S03-L241 | 7 | M6-GATE | Pending | [L241](MASTER_SPEC.md#L241) Chapter 5: Experience Your Creation / The player's own ride experiences should connect to management decisions. | Verify Chapter 5: Experience Your Creation / The player's own ride experiences should connect to management decisions. |
| S03-L243 | 7 | M6-GATE | Pending | [L243](MASTER_SPEC.md#L243) Chapter 5: Experience Your Creation / For example, after riding a roller coaster, the player can inspect its intensity rating, guest feedback, operating costs, and maintenance status. | Verify Chapter 5: Experience Your Creation / For example, after riding a roller coaster, the player can inspect its intensity rating, guest feedback, operating costs, and maintenance status. |
| S03-L247 | 7 | M6-GATE | Pending | [L247](MASTER_SPEC.md#L247) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through: | Verify Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through: |
| S03-L249 | 7 | M6-GATE | Pending | [L249](MASTER_SPEC.md#L249) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Visitor satisfaction | Demonstrate or document Chapter 6: The Five-Star Destination / Visitor satisfaction |
| S03-L250 | 7 | M6-GATE | Pending | [L250](MASTER_SPEC.md#L250) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Financial stability | Demonstrate or document Chapter 6: The Five-Star Destination / Financial stability |
| S03-L251 | 7 | M6-GATE | Pending | [L251](MASTER_SPEC.md#L251) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Cleanliness | Demonstrate or document Chapter 6: The Five-Star Destination / Cleanliness |
| S03-L252 | 7 | M6-GATE | Pending | [L252](MASTER_SPEC.md#L252) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Attraction diversity | Demonstrate or document Chapter 6: The Five-Star Destination / Attraction diversity |
| S03-L253 | 7 | M6-GATE | Pending | [L253](MASTER_SPEC.md#L253) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Operational reliability | Demonstrate or document Chapter 6: The Five-Star Destination / Operational reliability |
| S03-L254 | 7 | M6-GATE | Pending | [L254](MASTER_SPEC.md#L254) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Safety | Demonstrate or document Chapter 6: The Five-Star Destination / Safety |
| S03-L255 | 7 | M6-GATE | Pending | [L255](MASTER_SPEC.md#L255) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Guest comfort | Demonstrate or document Chapter 6: The Five-Star Destination / Guest comfort |
| S03-L256 | 7 | M6-GATE | Pending | [L256](MASTER_SPEC.md#L256) Chapter 6: The Five-Star Destination / The player must achieve a five-star park reputation through / Staff efficiency | Demonstrate or document Chapter 6: The Five-Star Destination / Staff efficiency |
| S03-L258 | 7 | M6-GATE | Pending | [L258](MASTER_SPEC.md#L258) Chapter 6: The Five-Star Destination / After reaching five stars, unlock sandbox continuation. | Verify Chapter 6: The Five-Star Destination / After reaching five stars, unlock sandbox continuation. |
| S03-L260 | 7 | M6-GATE | Pending | [L260](MASTER_SPEC.md#L260) Chapter 6: The Five-Star Destination / The player can keep building, managing, and exploring. | Verify Chapter 6: The Five-Star Destination / The player can keep building, managing, and exploring. |

### 4. EXECUTION RULES FOR CODEX

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S04-L266 | 0 | â€” | Ongoing | [L266](MASTER_SPEC.md#L266) Follow these rules throughout development. | Verify Follow these rules throughout development. |
| S04-L268 | 0 | â€” | Ongoing | [L268](MASTER_SPEC.md#L268) Inspect the actual environment before making assumptions. | Demonstrate or document Inspect the actual environment before making assumptions. |
| S04-L269 | 0 | â€” | Ongoing | [L269](MASTER_SPEC.md#L269) Check installed Unity, Blender, Android SDK, Java, and available build tools. | Demonstrate or document Check installed Unity, Blender, Android SDK, Java, and available build tools. |
| S04-L270 | 0 | â€” | Ongoing | [L270](MASTER_SPEC.md#L270) Preserve all existing source project files. | Demonstrate or document Preserve all existing source project files. |
| S04-L271 | 0 | â€” | Ongoing | [L271](MASTER_SPEC.md#L271) Create a new Unity project. | Demonstrate or document Create a new Unity project. |
| S04-L272 | 0 | â€” | Ongoing | [L272](MASTER_SPEC.md#L272) Use established Unity packages rather than inventing unnecessary frameworks. | Demonstrate or document Use established Unity packages rather than inventing unnecessary frameworks. |
| S04-L273 | 0 | â€” | Ongoing | [L273](MASTER_SPEC.md#L273) Prefer modular, maintainable, testable C#. | Demonstrate or document Prefer modular, maintainable, testable C#. |
| S04-L274 | 0 | â€” | Ongoing | [L274](MASTER_SPEC.md#L274) Use ScriptableObjects for static game definitions and configuration. | Demonstrate or document Use ScriptableObjects for static game definitions and configuration. |
| S04-L275 | 0 | â€” | Ongoing | [L275](MASTER_SPEC.md#L275) Separate simulation logic from visual presentation. | Demonstrate or document Separate simulation logic from visual presentation. |
| S04-L276 | 0 | â€” | Ongoing | [L276](MASTER_SPEC.md#L276) Use dependency injection or explicit composition where practical. | Demonstrate or document Use dependency injection or explicit composition where practical. |
| S04-L277 | 0 | â€” | Ongoing | [L277](MASTER_SPEC.md#L277) Avoid excessive global singletons. | Demonstrate or document Avoid excessive global singletons. |
| S04-L278 | 0 | â€” | Ongoing | [L278](MASTER_SPEC.md#L278) Avoid large monolithic manager classes. | Demonstrate or document Avoid large monolithic manager classes. |
| S04-L279 | 0 | â€” | Ongoing | [L279](MASTER_SPEC.md#L279) Do not use obsolete Unity APIs where supported modern equivalents exist. | Demonstrate or document Do not use obsolete Unity APIs where supported modern equivalents exist. |
| S04-L280 | 0 | â€” | Ongoing | [L280](MASTER_SPEC.md#L280) Avoid runtime FindObjectOfType or expensive scene searches inside update loops. | Demonstrate or document Avoid runtime FindObjectOfType or expensive scene searches inside update loops. |
| S04-L281 | 0 | â€” | Ongoing | [L281](MASTER_SPEC.md#L281) Do not perform expensive AI calculations for every visitor every frame. | Demonstrate or document Do not perform expensive AI calculations for every visitor every frame. |
| S04-L282 | 0 | â€” | Ongoing | [L282](MASTER_SPEC.md#L282) Use pooling and batched simulation where appropriate. | Demonstrate or document Use pooling and batched simulation where appropriate. |
| S04-L283 | 0 | â€” | Ongoing | [L283](MASTER_SPEC.md#L283) Never generate fake successful test results. | Demonstrate or document Never generate fake successful test results. |
| S04-L284 | 0 | â€” | Ongoing | [L284](MASTER_SPEC.md#L284) Never claim an APK was tested on Quest without actually running it on a device. | Demonstrate or document Never claim an APK was tested on Quest without actually running it on a device. |
| S04-L285 | 0 | â€” | Ongoing | [L285](MASTER_SPEC.md#L285) Log implementation progress, blockers, test results, and performance measurements. | Demonstrate or document Log implementation progress, blockers, test results, and performance measurements. |
| S04-L286 | 0 | â€” | Ongoing | [L286](MASTER_SPEC.md#L286) Make changes incrementally and validate after major milestones. | Demonstrate or document Make changes incrementally and validate after major milestones. |
| S04-L287 | 0 | â€” | Ongoing | [L287](MASTER_SPEC.md#L287) Never silently replace functional systems with decorative placeholders. | Demonstrate or document Never silently replace functional systems with decorative placeholders. |
| S04-L289 | 0 | â€” | Ongoing | [L289](MASTER_SPEC.md#L289) When tools are missing, continue with tasks that can be completed and report the exact blocker. | Verify When tools are missing, continue with tasks that can be completed and report the exact blocker. |

### 5. PHASE 0 â€” ENVIRONMENT AND ASSET AUDIT

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S05-L295 | 0 | â€” | Active | [L295](MASTER_SPEC.md#L295) Before creating gameplay systems, perform a comprehensive audit. | Verify Before creating gameplay systems, perform a comprehensive audit. |
| S05-L299 | 0 | M0-ENV | Verified | [L299](MASTER_SPEC.md#L299) 5.1 Environment Inspection / Detect: | Verify 5.1 Environment Inspection / Detect: |
| S05-L301 | 0 | M0-ENV | Verified | [L301](MASTER_SPEC.md#L301) 5.1 Environment Inspection / Detect / Installed Unity Editor versions | Provide evidence for 5.1 Environment Inspection / Installed Unity Editor versions |
| S05-L302 | 0 | M0-ENV | Verified | [L302](MASTER_SPEC.md#L302) 5.1 Environment Inspection / Detect / Unity Hub availability | Provide evidence for 5.1 Environment Inspection / Unity Hub availability |
| S05-L303 | 0 | M0-ENV | Verified | [L303](MASTER_SPEC.md#L303) 5.1 Environment Inspection / Detect / Blender installation and version | Provide evidence for 5.1 Environment Inspection / Blender installation and version |
| S05-L304 | 0 | M0-ENV | Verified | [L304](MASTER_SPEC.md#L304) 5.1 Environment Inspection / Detect / Python availability | Provide evidence for 5.1 Environment Inspection / Python availability |
| S05-L305 | 0 | M0-ENV | Verified | [L305](MASTER_SPEC.md#L305) 5.1 Environment Inspection / Detect / Android SDK and NDK | Provide evidence for 5.1 Environment Inspection / Android SDK and NDK |
| S05-L306 | 0 | M0-ENV | Verified | [L306](MASTER_SPEC.md#L306) 5.1 Environment Inspection / Detect / Java/JDK | Provide evidence for 5.1 Environment Inspection / Java/JDK |
| S05-L307 | 0 | M0-ENV | Verified | [L307](MASTER_SPEC.md#L307) 5.1 Environment Inspection / Detect / ADB | Provide evidence for 5.1 Environment Inspection / ADB |
| S05-L308 | 0 | M0-ENV | Verified | [L308](MASTER_SPEC.md#L308) 5.1 Environment Inspection / Detect / Git | Provide evidence for 5.1 Environment Inspection / Git |
| S05-L309 | 0 | M0-ENV | Verified | [L309](MASTER_SPEC.md#L309) 5.1 Environment Inspection / Detect / Available storage space | Provide evidence for 5.1 Environment Inspection / Available storage space |
| S05-L310 | 0 | M0-ENV | Verified | [L310](MASTER_SPEC.md#L310) 5.1 Environment Inspection / Detect / Existing Unity project structure | Provide evidence for 5.1 Environment Inspection / Existing Unity project structure |
| S05-L312 | 0 | M0-ENV | Verified | [L312](MASTER_SPEC.md#L312) 5.1 Environment Inspection / Prefer Unity 6 LTS. | Verify 5.1 Environment Inspection / Prefer Unity 6 LTS. |
| S05-L314 | 0 | M0-ENV | Verified | [L314](MASTER_SPEC.md#L314) 5.1 Environment Inspection / If the installed editor is a different supported Unity 6 version, document compatibility decisions. | Verify 5.1 Environment Inspection / If the installed editor is a different supported Unity 6 version, document compatibility decisions. |
| S05-L318 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L318](MASTER_SPEC.md#L318) 5.2 Existing Asset Inspection / Inspect: | Verify 5.2 Existing Asset Inspection / Inspect: |
| S05-L320 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L320](MASTER_SPEC.md#L320) 5.2 Existing Asset Inspection / `E:\Projects\Roller Coaster Mobile\Assets` | Verify 5.2 Existing Asset Inspection / `E:\Projects\Roller Coaster Mobile\Assets` |
| S05-L322 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L322](MASTER_SPEC.md#L322) 5.2 Existing Asset Inspection / Read the source project's Unity version and package manifest if available, without modifying the source. | Verify 5.2 Existing Asset Inspection / Read the source project's Unity version and package manifest if available, without modifying the source. |
| S05-L324 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L324](MASTER_SPEC.md#L324) 5.2 Existing Asset Inspection / Recursively inventory: | Verify 5.2 Existing Asset Inspection / Recursively inventory: |
| S05-L326 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L326](MASTER_SPEC.md#L326) 5.2 Existing Asset Inspection / Recursively inventory / Prefabs | Demonstrate or document 5.2 Existing Asset Inspection / Prefabs |
| S05-L327 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L327](MASTER_SPEC.md#L327) 5.2 Existing Asset Inspection / Recursively inventory / Meshes | Demonstrate or document 5.2 Existing Asset Inspection / Meshes |
| S05-L328 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L328](MASTER_SPEC.md#L328) 5.2 Existing Asset Inspection / Recursively inventory / FBX files | Demonstrate or document 5.2 Existing Asset Inspection / FBX files |
| S05-L329 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L329](MASTER_SPEC.md#L329) 5.2 Existing Asset Inspection / Recursively inventory / Materials | Demonstrate or document 5.2 Existing Asset Inspection / Materials |
| S05-L330 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L330](MASTER_SPEC.md#L330) 5.2 Existing Asset Inspection / Recursively inventory / Textures | Demonstrate or document 5.2 Existing Asset Inspection / Textures |
| S05-L331 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L331](MASTER_SPEC.md#L331) 5.2 Existing Asset Inspection / Recursively inventory / Shaders | Demonstrate or document 5.2 Existing Asset Inspection / Shaders |
| S05-L332 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L332](MASTER_SPEC.md#L332) 5.2 Existing Asset Inspection / Recursively inventory / Animations | Demonstrate or document 5.2 Existing Asset Inspection / Animations |
| S05-L333 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L333](MASTER_SPEC.md#L333) 5.2 Existing Asset Inspection / Recursively inventory / Animator Controllers | Demonstrate or document 5.2 Existing Asset Inspection / Animator Controllers |
| S05-L334 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L334](MASTER_SPEC.md#L334) 5.2 Existing Asset Inspection / Recursively inventory / Audio clips | Demonstrate or document 5.2 Existing Asset Inspection / Audio clips |
| S05-L335 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L335](MASTER_SPEC.md#L335) 5.2 Existing Asset Inspection / Recursively inventory / Scripts | Demonstrate or document 5.2 Existing Asset Inspection / Scripts |
| S05-L336 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L336](MASTER_SPEC.md#L336) 5.2 Existing Asset Inspection / Recursively inventory / ScriptableObjects | Demonstrate or document 5.2 Existing Asset Inspection / ScriptableObjects |
| S05-L337 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L337](MASTER_SPEC.md#L337) 5.2 Existing Asset Inspection / Recursively inventory / Scenes | Demonstrate or document 5.2 Existing Asset Inspection / Scenes |
| S05-L338 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L338](MASTER_SPEC.md#L338) 5.2 Existing Asset Inspection / Recursively inventory / UI assets | Demonstrate or document 5.2 Existing Asset Inspection / UI assets |
| S05-L339 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L339](MASTER_SPEC.md#L339) 5.2 Existing Asset Inspection / Recursively inventory / Terrain | Demonstrate or document 5.2 Existing Asset Inspection / Terrain |
| S05-L340 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L340](MASTER_SPEC.md#L340) 5.2 Existing Asset Inspection / Recursively inventory / Lighting assets | Demonstrate or document 5.2 Existing Asset Inspection / Lighting assets |
| S05-L341 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L341](MASTER_SPEC.md#L341) 5.2 Existing Asset Inspection / Recursively inventory / Third-party packages | Demonstrate or document 5.2 Existing Asset Inspection / Third-party packages |
| S05-L342 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L342](MASTER_SPEC.md#L342) 5.2 Existing Asset Inspection / Recursively inventory / Editor tools | Demonstrate or document 5.2 Existing Asset Inspection / Editor tools |
| S05-L343 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L343](MASTER_SPEC.md#L343) 5.2 Existing Asset Inspection / Recursively inventory / Plugins | Demonstrate or document 5.2 Existing Asset Inspection / Plugins |
| S05-L345 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L345](MASTER_SPEC.md#L345) 5.2 Existing Asset Inspection / Generate: | Verify 5.2 Existing Asset Inspection / Generate: |
| S05-L347 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L347](MASTER_SPEC.md#L347) 5.2 Existing Asset Inspection / `Documentation/AssetAudit.md` | Verify 5.2 Existing Asset Inspection / `Documentation/AssetAudit.md` |
| S05-L349 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L349](MASTER_SPEC.md#L349) 5.2 Existing Asset Inspection / `Documentation/AssetInventory.csv` | Verify 5.2 Existing Asset Inspection / `Documentation/AssetInventory.csv` |
| S05-L351 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L351](MASTER_SPEC.md#L351) 5.2 Existing Asset Inspection / Include: | Verify 5.2 Existing Asset Inspection / Include: |
| S05-L353 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L353](MASTER_SPEC.md#L353) 5.2 Existing Asset Inspection / Include / Asset name | Provide evidence for 5.2 Existing Asset Inspection / Asset name |
| S05-L354 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L354](MASTER_SPEC.md#L354) 5.2 Existing Asset Inspection / Include / Original path | Provide evidence for 5.2 Existing Asset Inspection / Original path |
| S05-L355 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L355](MASTER_SPEC.md#L355) 5.2 Existing Asset Inspection / Include / Type | Provide evidence for 5.2 Existing Asset Inspection / Type |
| S05-L356 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L356](MASTER_SPEC.md#L356) 5.2 Existing Asset Inspection / Include / Dependencies | Provide evidence for 5.2 Existing Asset Inspection / Dependencies |
| S05-L357 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L357](MASTER_SPEC.md#L357) 5.2 Existing Asset Inspection / Include / Source/license information where available | Provide evidence for 5.2 Existing Asset Inspection / Source/license information where available |
| S05-L358 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L358](MASTER_SPEC.md#L358) 5.2 Existing Asset Inspection / Include / Polygon count where measurable | Provide evidence for 5.2 Existing Asset Inspection / Polygon count where measurable |
| S05-L359 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L359](MASTER_SPEC.md#L359) 5.2 Existing Asset Inspection / Include / Texture dimensions | Provide evidence for 5.2 Existing Asset Inspection / Texture dimensions |
| S05-L360 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L360](MASTER_SPEC.md#L360) 5.2 Existing Asset Inspection / Include / Shader compatibility | Provide evidence for 5.2 Existing Asset Inspection / Shader compatibility |
| S05-L361 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L361](MASTER_SPEC.md#L361) 5.2 Existing Asset Inspection / Include / Animation availability | Provide evidence for 5.2 Existing Asset Inspection / Animation availability |
| S05-L362 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L362](MASTER_SPEC.md#L362) 5.2 Existing Asset Inspection / Include / Estimated VR suitability | Provide evidence for 5.2 Existing Asset Inspection / Estimated VR suitability |
| S05-L363 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L363](MASTER_SPEC.md#L363) 5.2 Existing Asset Inspection / Include / Reuse decision | Provide evidence for 5.2 Existing Asset Inspection / Reuse decision |
| S05-L364 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L364](MASTER_SPEC.md#L364) 5.2 Existing Asset Inspection / Include / Required conversion work | Provide evidence for 5.2 Existing Asset Inspection / Required conversion work |
| S05-L368 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L368](MASTER_SPEC.md#L368) 5.3 Asset Classification / Classify each relevant asset as: | Verify 5.3 Asset Classification / Classify each relevant asset as: |
| S05-L370 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L370](MASTER_SPEC.md#L370) 5.3 Asset Classification / **A â€” Reuse directly** | Verify 5.3 Asset Classification / **A â€” Reuse directly** |
| S05-L372 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L372](MASTER_SPEC.md#L372) 5.3 Asset Classification / Suitable for VR with minimal changes. | Verify 5.3 Asset Classification / Suitable for VR with minimal changes. |
| S05-L374 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L374](MASTER_SPEC.md#L374) 5.3 Asset Classification / **B â€” Reuse after optimization** | Verify 5.3 Asset Classification / **B â€” Reuse after optimization** |
| S05-L376 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L376](MASTER_SPEC.md#L376) 5.3 Asset Classification / Requires mesh simplification, texture reduction, material conversion, or prefab adjustments. | Verify 5.3 Asset Classification / Requires mesh simplification, texture reduction, material conversion, or prefab adjustments. |
| S05-L378 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L378](MASTER_SPEC.md#L378) 5.3 Asset Classification / **C â€” Reference only** | Verify 5.3 Asset Classification / **C â€” Reference only** |
| S05-L380 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L380](MASTER_SPEC.md#L380) 5.3 Asset Classification / Useful for visual or functional reference but not suitable for direct reuse. | Verify 5.3 Asset Classification / Useful for visual or functional reference but not suitable for direct reuse. |
| S05-L382 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L382](MASTER_SPEC.md#L382) 5.3 Asset Classification / **D â€” Replace** | Verify 5.3 Asset Classification / **D â€” Replace** |
| S05-L384 | 0 | M0-ASSETS, M0-REUSE | Recorded | [L384](MASTER_SPEC.md#L384) 5.3 Asset Classification / Unsuitable, broken, excessively expensive, incompatible, or lacking valid reuse rights. | Verify 5.3 Asset Classification / Unsuitable, broken, excessively expensive, incompatible, or lacking valid reuse rights. |
| S05-L388 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L388](MASTER_SPEC.md#L388) 5.4 Dependency Safety / When copying assets: | Verify 5.4 Dependency Safety / When copying assets: |
| S05-L390 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L390](MASTER_SPEC.md#L390) 5.4 Dependency Safety / When copying assets / Preserve required `.meta` files. | Demonstrate or document 5.4 Dependency Safety / Preserve required `.meta` files. |
| S05-L391 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L391](MASTER_SPEC.md#L391) 5.4 Dependency Safety / When copying assets / Preserve GUID relationships where possible. | Demonstrate or document 5.4 Dependency Safety / Preserve GUID relationships where possible. |
| S05-L392 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L392](MASTER_SPEC.md#L392) 5.4 Dependency Safety / When copying assets / Copy necessary dependencies. | Demonstrate or document 5.4 Dependency Safety / Copy necessary dependencies. |
| S05-L393 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L393](MASTER_SPEC.md#L393) 5.4 Dependency Safety / When copying assets / Avoid duplicate conflicting scripts. | Demonstrate or document 5.4 Dependency Safety / Avoid duplicate conflicting scripts. |
| S05-L394 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L394](MASTER_SPEC.md#L394) 5.4 Dependency Safety / When copying assets / Do not import unrelated packages. | Demonstrate or document 5.4 Dependency Safety / Do not import unrelated packages. |
| S05-L395 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L395](MASTER_SPEC.md#L395) 5.4 Dependency Safety / When copying assets / Do not copy unsupported mobile SDKs. | Demonstrate or document 5.4 Dependency Safety / Do not copy unsupported mobile SDKs. |
| S05-L396 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L396](MASTER_SPEC.md#L396) 5.4 Dependency Safety / When copying assets / Do not import advertising or analytics integrations unless explicitly required. | Demonstrate or document 5.4 Dependency Safety / Do not import advertising or analytics integrations unless explicitly required. |
| S05-L397 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L397](MASTER_SPEC.md#L397) 5.4 Dependency Safety / When copying assets / Avoid copying entire asset folders without reviewing their contents. | Demonstrate or document 5.4 Dependency Safety / Avoid copying entire asset folders without reviewing their contents. |
| S05-L398 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L398](MASTER_SPEC.md#L398) 5.4 Dependency Safety / When copying assets / Keep a manifest of copied assets. | Demonstrate or document 5.4 Dependency Safety / Keep a manifest of copied assets. |
| S05-L400 | 0 | M0-ASSETS, M0-REUSE | Pending import | [L400](MASTER_SPEC.md#L400) 5.4 Dependency Safety / For third-party assets, verify the available license or entitlement before reuse. If licensing cannot be established, flag the asset and use an original replacement. | Verify 5.4 Dependency Safety / For third-party assets, verify the available license or entitlement before reuse. If licensing cannot be established, flag the asset and use an original replacement. |
| S05-L404 | 0 | M0-PLAN | Recorded | [L404](MASTER_SPEC.md#L404) 5.5 Existing Gameplay Audit / Inspect the mobile game's scripts for reusable logic. | Verify 5.5 Existing Gameplay Audit / Inspect the mobile game's scripts for reusable logic. |
| S05-L406 | 0 | M0-PLAN | Recorded | [L406](MASTER_SPEC.md#L406) 5.5 Existing Gameplay Audit / Identify: | Verify 5.5 Existing Gameplay Audit / Identify: |
| S05-L408 | 0 | M0-PLAN | Recorded | [L408](MASTER_SPEC.md#L408) 5.5 Existing Gameplay Audit / Identify / Park economy | Demonstrate or document 5.5 Existing Gameplay Audit / Park economy |
| S05-L409 | 0 | M0-PLAN | Recorded | [L409](MASTER_SPEC.md#L409) 5.5 Existing Gameplay Audit / Identify / Ride placement | Demonstrate or document 5.5 Existing Gameplay Audit / Ride placement |
| S05-L410 | 0 | M0-PLAN | Recorded | [L410](MASTER_SPEC.md#L410) 5.5 Existing Gameplay Audit / Identify / Building construction | Demonstrate or document 5.5 Existing Gameplay Audit / Building construction |
| S05-L411 | 0 | M0-PLAN | Recorded | [L411](MASTER_SPEC.md#L411) 5.5 Existing Gameplay Audit / Identify / Guest navigation | Demonstrate or document 5.5 Existing Gameplay Audit / Guest navigation |
| S05-L412 | 0 | M0-PLAN | Recorded | [L412](MASTER_SPEC.md#L412) 5.5 Existing Gameplay Audit / Identify / Guest demand systems | Demonstrate or document 5.5 Existing Gameplay Audit / Guest demand systems |
| S05-L413 | 0 | M0-PLAN | Recorded | [L413](MASTER_SPEC.md#L413) 5.5 Existing Gameplay Audit / Identify / Staff management | Demonstrate or document 5.5 Existing Gameplay Audit / Staff management |
| S05-L414 | 0 | M0-PLAN | Recorded | [L414](MASTER_SPEC.md#L414) 5.5 Existing Gameplay Audit / Identify / Ride operation | Demonstrate or document 5.5 Existing Gameplay Audit / Ride operation |
| S05-L415 | 0 | M0-PLAN | Recorded | [L415](MASTER_SPEC.md#L415) 5.5 Existing Gameplay Audit / Identify / Ticket pricing | Demonstrate or document 5.5 Existing Gameplay Audit / Ticket pricing |
| S05-L416 | 0 | M0-PLAN | Recorded | [L416](MASTER_SPEC.md#L416) 5.5 Existing Gameplay Audit / Identify / Shop management | Demonstrate or document 5.5 Existing Gameplay Audit / Shop management |
| S05-L417 | 0 | M0-PLAN | Recorded | [L417](MASTER_SPEC.md#L417) 5.5 Existing Gameplay Audit / Identify / Save/load | Demonstrate or document 5.5 Existing Gameplay Audit / Save/load |
| S05-L418 | 0 | M0-PLAN | Recorded | [L418](MASTER_SPEC.md#L418) 5.5 Existing Gameplay Audit / Identify / Progression | Demonstrate or document 5.5 Existing Gameplay Audit / Progression |
| S05-L419 | 0 | M0-PLAN | Recorded | [L419](MASTER_SPEC.md#L419) 5.5 Existing Gameplay Audit / Identify / Mission systems | Demonstrate or document 5.5 Existing Gameplay Audit / Mission systems |
| S05-L421 | 0 | M0-PLAN | Recorded | [L421](MASTER_SPEC.md#L421) 5.5 Existing Gameplay Audit / Do not blindly copy existing scripts. | Verify 5.5 Existing Gameplay Audit / Do not blindly copy existing scripts. |
| S05-L423 | 0 | M0-PLAN | Recorded | [L423](MASTER_SPEC.md#L423) 5.5 Existing Gameplay Audit / Extract reusable gameplay logic into VR-independent systems where practical. | Verify 5.5 Existing Gameplay Audit / Extract reusable gameplay logic into VR-independent systems where practical. |
| S05-L425 | 0 | M0-PLAN | Recorded | [L425](MASTER_SPEC.md#L425) 5.5 Existing Gameplay Audit / Replace mobile-specific input and UI layers with XR implementations. | Verify 5.5 Existing Gameplay Audit / Replace mobile-specific input and UI layers with XR implementations. |
| S05-L427 | 0 | M0-PLAN | Recorded | [L427](MASTER_SPEC.md#L427) 5.5 Existing Gameplay Audit / Deliver: | Verify 5.5 Existing Gameplay Audit / Deliver: |
| S05-L429 | 0 | M0-PLAN | Recorded | [L429](MASTER_SPEC.md#L429) 5.5 Existing Gameplay Audit / `Documentation/MigrationPlan.md` | Verify 5.5 Existing Gameplay Audit / `Documentation/MigrationPlan.md` |
| S05-L431 | 0 | M0-PLAN | Recorded | [L431](MASTER_SPEC.md#L431) 5.5 Existing Gameplay Audit / The migration plan must explain which existing systems will be reused, rewritten, or replaced. | Verify 5.5 Existing Gameplay Audit / The migration plan must explain which existing systems will be reused, rewritten, or replaced. |

### 6. NEW UNITY PROJECT STRUCTURE

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S06-L437 | 1 | M0-GATE | Pending | [L437](MASTER_SPEC.md#L437) Create a separate Unity project. | Verify Create a separate Unity project. |
| S06-L439 | 1 | M0-GATE | Pending | [L439](MASTER_SPEC.md#L439) Suggested organization: | Verify Suggested organization: |
| S06-L441 | 1 | M0-GATE | Pending | [L441](MASTER_SPEC.md#L441) Assets/ | Verify Assets/ |
| S06-L504 | 1 | M0-GATE | Pending | [L504](MASTER_SPEC.md#L504) ExternalSources/ | Verify ExternalSources/ |
| S06-L511 | 1 | M0-GATE | Pending | [L511](MASTER_SPEC.md#L511) Documentation/ | Verify Documentation/ |
| S06-L521 | 1 | M0-GATE | Pending | [L521](MASTER_SPEC.md#L521) Keep Blender source files and asset generation scripts outside Unity's Assets directory. | Verify Keep Blender source files and asset generation scripts outside Unity's Assets directory. |
| S06-L523 | 1 | M0-GATE | Pending | [L523](MASTER_SPEC.md#L523) Only runtime-ready exports belong inside Unity. | Verify Only runtime-ready exports belong inside Unity. |
| S06-L525 | 1 | M0-GATE | Pending | [L525](MASTER_SPEC.md#L525) Do not use Resources as the default asset-loading mechanism. | Verify Do not use Resources as the default asset-loading mechanism. |
| S06-L527 | 1 | M0-GATE | Pending | [L527](MASTER_SPEC.md#L527) Use Addressables when their complexity is justified. | Verify Use Addressables when their complexity is justified. |

### 7. TECHNICAL ARCHITECTURE

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S07-L533 | 1 | M0-GATE | Pending | [L533](MASTER_SPEC.md#L533) Use a modular, event-driven architecture. | Verify Use a modular, event-driven architecture. |
| S07-L535 | 1 | M0-GATE | Pending | [L535](MASTER_SPEC.md#L535) Separate the game into the following layers. | Verify Separate the game into the following layers. |
| S07-L539 | 1 | M0-GATE | Pending | [L539](MASTER_SPEC.md#L539) 7.1 Core Layer / Responsibilities: | Verify 7.1 Core Layer / Responsibilities: |
| S07-L541 | 1 | M0-GATE | Pending | [L541](MASTER_SPEC.md#L541) 7.1 Core Layer / Responsibilities / Game lifecycle | Demonstrate or document 7.1 Core Layer / Game lifecycle |
| S07-L542 | 1 | M0-GATE | Pending | [L542](MASTER_SPEC.md#L542) 7.1 Core Layer / Responsibilities / Dependency initialization | Demonstrate or document 7.1 Core Layer / Dependency initialization |
| S07-L543 | 1 | M0-GATE | Pending | [L543](MASTER_SPEC.md#L543) 7.1 Core Layer / Responsibilities / Game state | Demonstrate or document 7.1 Core Layer / Game state |
| S07-L544 | 1 | M0-GATE | Pending | [L544](MASTER_SPEC.md#L544) 7.1 Core Layer / Responsibilities / Scene transitions | Demonstrate or document 7.1 Core Layer / Scene transitions |
| S07-L545 | 1 | M0-GATE | Pending | [L545](MASTER_SPEC.md#L545) 7.1 Core Layer / Responsibilities / Time simulation | Demonstrate or document 7.1 Core Layer / Time simulation |
| S07-L546 | 1 | M0-GATE | Pending | [L546](MASTER_SPEC.md#L546) 7.1 Core Layer / Responsibilities / Pause/resume | Demonstrate or document 7.1 Core Layer / Pause/resume |
| S07-L547 | 1 | M0-GATE | Pending | [L547](MASTER_SPEC.md#L547) 7.1 Core Layer / Responsibilities / Configuration | Demonstrate or document 7.1 Core Layer / Configuration |
| S07-L548 | 1 | M0-GATE | Pending | [L548](MASTER_SPEC.md#L548) 7.1 Core Layer / Responsibilities / Event dispatching | Demonstrate or document 7.1 Core Layer / Event dispatching |
| S07-L549 | 1 | M0-GATE | Pending | [L549](MASTER_SPEC.md#L549) 7.1 Core Layer / Responsibilities / Save/load coordination | Demonstrate or document 7.1 Core Layer / Save/load coordination |
| S07-L551 | 1 | M0-GATE | Pending | [L551](MASTER_SPEC.md#L551) 7.1 Core Layer / Suggested systems: | Verify 7.1 Core Layer / Suggested systems: |
| S07-L553 | 1 | M0-GATE | Pending | [L553](MASTER_SPEC.md#L553) 7.1 Core Layer / GameBootstrap | Verify 7.1 Core Layer / GameBootstrap |
| S07-L555 | 1 | M0-GATE | Pending | [L555](MASTER_SPEC.md#L555) 7.1 Core Layer / GameSession | Verify 7.1 Core Layer / GameSession |
| S07-L557 | 1 | M0-GATE | Pending | [L557](MASTER_SPEC.md#L557) 7.1 Core Layer / GameTimeService | Verify 7.1 Core Layer / GameTimeService |
| S07-L559 | 1 | M0-GATE | Pending | [L559](MASTER_SPEC.md#L559) 7.1 Core Layer / GameStateCoordinator | Verify 7.1 Core Layer / GameStateCoordinator |
| S07-L561 | 1 | M0-GATE | Pending | [L561](MASTER_SPEC.md#L561) 7.1 Core Layer / GameEventBus | Verify 7.1 Core Layer / GameEventBus |
| S07-L563 | 1 | M0-GATE | Pending | [L563](MASTER_SPEC.md#L563) 7.1 Core Layer / SaveGameService | Verify 7.1 Core Layer / SaveGameService |
| S07-L565 | 1 | M0-GATE | Pending | [L565](MASTER_SPEC.md#L565) 7.1 Core Layer / ConfigurationService | Verify 7.1 Core Layer / ConfigurationService |
| S07-L569 | 1 | M0-GATE | Pending | [L569](MASTER_SPEC.md#L569) 7.2 Simulation Layer / Responsible for authoritative park simulation. | Verify 7.2 Simulation Layer / Responsible for authoritative park simulation. |
| S07-L571 | 1 | M0-GATE | Pending | [L571](MASTER_SPEC.md#L571) 7.2 Simulation Layer / Systems: | Verify 7.2 Simulation Layer / Systems: |
| S07-L573 | 1 | M0-GATE | Pending | [L573](MASTER_SPEC.md#L573) 7.2 Simulation Layer / ParkSimulation | Verify 7.2 Simulation Layer / ParkSimulation |
| S07-L575 | 1 | M0-GATE | Pending | [L575](MASTER_SPEC.md#L575) 7.2 Simulation Layer / GuestSimulation | Verify 7.2 Simulation Layer / GuestSimulation |
| S07-L577 | 1 | M0-GATE | Pending | [L577](MASTER_SPEC.md#L577) 7.2 Simulation Layer / StaffSimulation | Verify 7.2 Simulation Layer / StaffSimulation |
| S07-L579 | 1 | M0-GATE | Pending | [L579](MASTER_SPEC.md#L579) 7.2 Simulation Layer / AttractionSimulation | Verify 7.2 Simulation Layer / AttractionSimulation |
| S07-L581 | 1 | M0-GATE | Pending | [L581](MASTER_SPEC.md#L581) 7.2 Simulation Layer / EconomySimulation | Verify 7.2 Simulation Layer / EconomySimulation |
| S07-L583 | 1 | M0-GATE | Pending | [L583](MASTER_SPEC.md#L583) 7.2 Simulation Layer / DemandSimulation | Verify 7.2 Simulation Layer / DemandSimulation |
| S07-L585 | 1 | M0-GATE | Pending | [L585](MASTER_SPEC.md#L585) 7.2 Simulation Layer / QueueSimulation | Verify 7.2 Simulation Layer / QueueSimulation |
| S07-L587 | 1 | M0-GATE | Pending | [L587](MASTER_SPEC.md#L587) 7.2 Simulation Layer / MaintenanceSimulation | Verify 7.2 Simulation Layer / MaintenanceSimulation |
| S07-L589 | 1 | M0-GATE | Pending | [L589](MASTER_SPEC.md#L589) 7.2 Simulation Layer / CleanlinessSimulation | Verify 7.2 Simulation Layer / CleanlinessSimulation |
| S07-L591 | 1 | M0-GATE | Pending | [L591](MASTER_SPEC.md#L591) 7.2 Simulation Layer / ReputationSimulation | Verify 7.2 Simulation Layer / ReputationSimulation |
| S07-L593 | 1 | M0-GATE | Pending | [L593](MASTER_SPEC.md#L593) 7.2 Simulation Layer / The simulation should remain functional independently of the VR player camera. | Verify 7.2 Simulation Layer / The simulation should remain functional independently of the VR player camera. |
| S07-L595 | 1 | M0-GATE | Pending | [L595](MASTER_SPEC.md#L595) 7.2 Simulation Layer / The game must not depend on the player's physical proximity for financial or operational calculations. | Verify 7.2 Simulation Layer / The game must not depend on the player's physical proximity for financial or operational calculations. |
| S07-L599 | 1 | M0-GATE | Pending | [L599](MASTER_SPEC.md#L599) 7.3 Presentation Layer / Responsibilities: | Verify 7.3 Presentation Layer / Responsibilities: |
| S07-L601 | 1 | M0-GATE | Pending | [L601](MASTER_SPEC.md#L601) 7.3 Presentation Layer / Responsibilities / Character animation | Demonstrate or document 7.3 Presentation Layer / Character animation |
| S07-L602 | 1 | M0-GATE | Pending | [L602](MASTER_SPEC.md#L602) 7.3 Presentation Layer / Responsibilities / Ride animation | Demonstrate or document 7.3 Presentation Layer / Ride animation |
| S07-L603 | 1 | M0-GATE | Pending | [L603](MASTER_SPEC.md#L603) 7.3 Presentation Layer / Responsibilities / VFX | Demonstrate or document 7.3 Presentation Layer / VFX |
| S07-L604 | 1 | M0-GATE | Pending | [L604](MASTER_SPEC.md#L604) 7.3 Presentation Layer / Responsibilities / Audio | Demonstrate or document 7.3 Presentation Layer / Audio |
| S07-L605 | 1 | M0-GATE | Pending | [L605](MASTER_SPEC.md#L605) 7.3 Presentation Layer / Responsibilities / XR UI | Demonstrate or document 7.3 Presentation Layer / XR UI |
| S07-L606 | 1 | M0-GATE | Pending | [L606](MASTER_SPEC.md#L606) 7.3 Presentation Layer / Responsibilities / Interaction feedback | Demonstrate or document 7.3 Presentation Layer / Interaction feedback |
| S07-L607 | 1 | M0-GATE | Pending | [L607](MASTER_SPEC.md#L607) 7.3 Presentation Layer / Responsibilities / Environment presentation | Demonstrate or document 7.3 Presentation Layer / Environment presentation |
| S07-L609 | 1 | M0-GATE | Pending | [L609](MASTER_SPEC.md#L609) 7.3 Presentation Layer / Use presentation adapters to reflect simulation state. | Verify 7.3 Presentation Layer / Use presentation adapters to reflect simulation state. |
| S07-L613 | 1 | M0-GATE | Pending | [L613](MASTER_SPEC.md#L613) 7.4 Data Layer / Use ScriptableObjects for: | Verify 7.4 Data Layer / Use ScriptableObjects for: |
| S07-L615 | 1 | M0-GATE | Pending | [L615](MASTER_SPEC.md#L615) 7.4 Data Layer / Use ScriptableObjects for / Attraction definitions | Demonstrate or document 7.4 Data Layer / Attraction definitions |
| S07-L616 | 1 | M0-GATE | Pending | [L616](MASTER_SPEC.md#L616) 7.4 Data Layer / Use ScriptableObjects for / Shop definitions | Demonstrate or document 7.4 Data Layer / Shop definitions |
| S07-L617 | 1 | M0-GATE | Pending | [L617](MASTER_SPEC.md#L617) 7.4 Data Layer / Use ScriptableObjects for / Employee types | Demonstrate or document 7.4 Data Layer / Employee types |
| S07-L618 | 1 | M0-GATE | Pending | [L618](MASTER_SPEC.md#L618) 7.4 Data Layer / Use ScriptableObjects for / Visitor archetypes | Demonstrate or document 7.4 Data Layer / Visitor archetypes |
| S07-L619 | 1 | M0-GATE | Pending | [L619](MASTER_SPEC.md#L619) 7.4 Data Layer / Use ScriptableObjects for / Mission definitions | Demonstrate or document 7.4 Data Layer / Mission definitions |
| S07-L620 | 1 | M0-GATE | Pending | [L620](MASTER_SPEC.md#L620) 7.4 Data Layer / Use ScriptableObjects for / Upgrade definitions | Demonstrate or document 7.4 Data Layer / Upgrade definitions |
| S07-L621 | 1 | M0-GATE | Pending | [L621](MASTER_SPEC.md#L621) 7.4 Data Layer / Use ScriptableObjects for / Economic configuration | Demonstrate or document 7.4 Data Layer / Economic configuration |
| S07-L622 | 1 | M0-GATE | Pending | [L622](MASTER_SPEC.md#L622) 7.4 Data Layer / Use ScriptableObjects for / Park zones | Demonstrate or document 7.4 Data Layer / Park zones |
| S07-L624 | 1 | M0-GATE | Pending | [L624](MASTER_SPEC.md#L624) 7.4 Data Layer / Runtime state must be stored separately from immutable definitions. | Verify 7.4 Data Layer / Runtime state must be stored separately from immutable definitions. |
| S07-L628 | 1 | M0-GATE | Pending | [L628](MASTER_SPEC.md#L628) 7.5 Save Layer / Save persistent data such as: | Verify 7.5 Save Layer / Save persistent data such as: |
| S07-L630 | 1 | M0-GATE | Pending | [L630](MASTER_SPEC.md#L630) 7.5 Save Layer / Save persistent data such as / Park layout | Demonstrate or document 7.5 Save Layer / Park layout |
| S07-L631 | 1 | M0-GATE | Pending | [L631](MASTER_SPEC.md#L631) 7.5 Save Layer / Save persistent data such as / Constructed attractions | Demonstrate or document 7.5 Save Layer / Constructed attractions |
| S07-L632 | 1 | M0-GATE | Pending | [L632](MASTER_SPEC.md#L632) 7.5 Save Layer / Save persistent data such as / Paths | Demonstrate or document 7.5 Save Layer / Paths |
| S07-L633 | 1 | M0-GATE | Pending | [L633](MASTER_SPEC.md#L633) 7.5 Save Layer / Save persistent data such as / Buildings | Demonstrate or document 7.5 Save Layer / Buildings |
| S07-L634 | 1 | M0-GATE | Pending | [L634](MASTER_SPEC.md#L634) 7.5 Save Layer / Save persistent data such as / Finances | Demonstrate or document 7.5 Save Layer / Finances |
| S07-L635 | 1 | M0-GATE | Pending | [L635](MASTER_SPEC.md#L635) 7.5 Save Layer / Save persistent data such as / Employee assignments | Demonstrate or document 7.5 Save Layer / Employee assignments |
| S07-L636 | 1 | M0-GATE | Pending | [L636](MASTER_SPEC.md#L636) 7.5 Save Layer / Save persistent data such as / Ride settings | Demonstrate or document 7.5 Save Layer / Ride settings |
| S07-L637 | 1 | M0-GATE | Pending | [L637](MASTER_SPEC.md#L637) 7.5 Save Layer / Save persistent data such as / Park reputation | Demonstrate or document 7.5 Save Layer / Park reputation |
| S07-L638 | 1 | M0-GATE | Pending | [L638](MASTER_SPEC.md#L638) 7.5 Save Layer / Save persistent data such as / Research unlocks | Demonstrate or document 7.5 Save Layer / Research unlocks |
| S07-L639 | 1 | M0-GATE | Pending | [L639](MASTER_SPEC.md#L639) 7.5 Save Layer / Save persistent data such as / Campaign progression | Demonstrate or document 7.5 Save Layer / Campaign progression |
| S07-L640 | 1 | M0-GATE | Pending | [L640](MASTER_SPEC.md#L640) 7.5 Save Layer / Save persistent data such as / Visitor statistics | Demonstrate or document 7.5 Save Layer / Visitor statistics |
| S07-L641 | 1 | M0-GATE | Pending | [L641](MASTER_SPEC.md#L641) 7.5 Save Layer / Save persistent data such as / User preferences | Demonstrate or document 7.5 Save Layer / User preferences |
| S07-L643 | 1 | M0-GATE | Pending | [L643](MASTER_SPEC.md#L643) 7.5 Save Layer / Use stable IDs and a versioned save schema. | Verify 7.5 Save Layer / Use stable IDs and a versioned save schema. |
| S07-L645 | 1 | M0-GATE | Pending | [L645](MASTER_SPEC.md#L645) 7.5 Save Layer / Do not serialize direct Unity object references into portable save data. | Verify 7.5 Save Layer / Do not serialize direct Unity object references into portable save data. |
| S07-L647 | 1 | M0-GATE | Pending | [L647](MASTER_SPEC.md#L647) 7.5 Save Layer / Implement save migration support for future schema changes. | Verify 7.5 Save Layer / Implement save migration support for future schema changes. |
| S07-L649 | 1 | M0-GATE | Pending | [L649](MASTER_SPEC.md#L649) 7.5 Save Layer / Use safe write procedures with temporary files and backups. | Verify 7.5 Save Layer / Use safe write procedures with temporary files and backups. |

### 8. XR PLAYER SYSTEM

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S08-L655 | 1 | M0-GATE | Pending | [L655](MASTER_SPEC.md#L655) Implement two complementary gameplay modes. | Verify Implement two complementary gameplay modes. |
| S08-L659 | 1 | M0-GATE | Pending | [L659](MASTER_SPEC.md#L659) 8.1 Architect Mode â€” God Mode / The player views the park as a miniature interactive world. | Verify 8.1 Architect Mode â€” God Mode / The player views the park as a miniature interactive world. |
| S08-L661 | 1 | M0-GATE | Pending | [L661](MASTER_SPEC.md#L661) 8.1 Architect Mode â€” God Mode / Requirements: | Verify 8.1 Architect Mode â€” God Mode / Requirements: |
| S08-L663 | 1 | M0-GATE | Pending | [L663](MASTER_SPEC.md#L663) 8.1 Architect Mode â€” God Mode / Requirements / View park from above. | Demonstrate or document 8.1 Architect Mode â€” God Mode / View park from above. |
| S08-L664 | 1 | M0-GATE | Pending | [L664](MASTER_SPEC.md#L664) 8.1 Architect Mode â€” God Mode / Requirements / Scale the miniature park. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Scale the miniature park. |
| S08-L665 | 1 | M0-GATE | Pending | [L665](MASTER_SPEC.md#L665) 8.1 Architect Mode â€” God Mode / Requirements / Pan and rotate the view. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Pan and rotate the view. |
| S08-L666 | 1 | M0-GATE | Pending | [L666](MASTER_SPEC.md#L666) 8.1 Architect Mode â€” God Mode / Requirements / Select buildings using XR rays. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Select buildings using XR rays. |
| S08-L667 | 2 | M1-GATE | Pending | [L667](MASTER_SPEC.md#L667) 8.1 Architect Mode â€” God Mode / Requirements / Grab construction previews. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Grab construction previews. |
| S08-L668 | 2 | M1-GATE | Pending | [L668](MASTER_SPEC.md#L668) 8.1 Architect Mode â€” God Mode / Requirements / Rotate attractions. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Rotate attractions. |
| S08-L669 | 2 | M1-GATE | Pending | [L669](MASTER_SPEC.md#L669) 8.1 Architect Mode â€” God Mode / Requirements / Snap structures to valid locations. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Snap structures to valid locations. |
| S08-L670 | 2 | M1-GATE | Pending | [L670](MASTER_SPEC.md#L670) 8.1 Architect Mode â€” God Mode / Requirements / Draw paths. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Draw paths. |
| S08-L671 | 2 | M1-GATE | Pending | [L671](MASTER_SPEC.md#L671) 8.1 Architect Mode â€” God Mode / Requirements / Inspect attraction statistics. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Inspect attraction statistics. |
| S08-L672 | 3 | M2-GATE | Pending | [L672](MASTER_SPEC.md#L672) 8.1 Architect Mode â€” God Mode / Requirements / View guest demand heatmaps. | Demonstrate or document 8.1 Architect Mode â€” God Mode / View guest demand heatmaps. |
| S08-L673 | 5 | M4-GATE | Pending | [L673](MASTER_SPEC.md#L673) 8.1 Architect Mode â€” God Mode / Requirements / View staff coverage. | Demonstrate or document 8.1 Architect Mode â€” God Mode / View staff coverage. |
| S08-L674 | 6 | M5-GATE | Pending | [L674](MASTER_SPEC.md#L674) 8.1 Architect Mode â€” God Mode / Requirements / View financial information. | Demonstrate or document 8.1 Architect Mode â€” God Mode / View financial information. |
| S08-L675 | 1 | M0-GATE | Pending | [L675](MASTER_SPEC.md#L675) 8.1 Architect Mode â€” God Mode / Requirements / Enter first-person mode at a selected location. | Demonstrate or document 8.1 Architect Mode â€” God Mode / Enter first-person mode at a selected location. |
| S08-L677 | 1 | M0-GATE | Pending | [L677](MASTER_SPEC.md#L677) 8.1 Architect Mode â€” God Mode / Prefer a stable tabletop-style miniature park presentation. | Verify 8.1 Architect Mode â€” God Mode / Prefer a stable tabletop-style miniature park presentation. |
| S08-L679 | 1 | M0-GATE | Pending | [L679](MASTER_SPEC.md#L679) 8.1 Architect Mode â€” God Mode / Do not move the physical XR tracking origin unpredictably. | Verify 8.1 Architect Mode â€” God Mode / Do not move the physical XR tracking origin unpredictably. |
| S08-L681 | 1 | M0-GATE | Pending | [L681](MASTER_SPEC.md#L681) 8.1 Architect Mode â€” God Mode / Provide comfortable transitions. | Verify 8.1 Architect Mode â€” God Mode / Provide comfortable transitions. |
| S08-L685 | 1 | M0-GATE | Pending | [L685](MASTER_SPEC.md#L685) 8.2 Visitor Mode â€” Human Mode / The player enters the park at human scale. | Verify 8.2 Visitor Mode â€” Human Mode / The player enters the park at human scale. |
| S08-L687 | 1 | M0-GATE | Pending | [L687](MASTER_SPEC.md#L687) 8.2 Visitor Mode â€” Human Mode / Requirements: | Verify 8.2 Visitor Mode â€” Human Mode / Requirements: |
| S08-L689 | 1 | M0-GATE | Pending | [L689](MASTER_SPEC.md#L689) 8.2 Visitor Mode â€” Human Mode / Requirements / First-person VR | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / First-person VR |
| S08-L690 | 1 | M0-GATE | Pending | [L690](MASTER_SPEC.md#L690) 8.2 Visitor Mode â€” Human Mode / Requirements / Teleport locomotion | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Teleport locomotion |
| S08-L691 | 1 | M0-GATE | Conditional | [L691](MASTER_SPEC.md#L691) 8.2 Visitor Mode â€” Human Mode / Requirements / Optional smooth locomotion | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Optional smooth locomotion |
| S08-L692 | 1 | M0-GATE | Pending | [L692](MASTER_SPEC.md#L692) 8.2 Visitor Mode â€” Human Mode / Requirements / Snap turning | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Snap turning |
| S08-L693 | 1 | M0-GATE | Conditional | [L693](MASTER_SPEC.md#L693) 8.2 Visitor Mode â€” Human Mode / Requirements / Optional smooth turning | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Optional smooth turning |
| S08-L694 | 1 | M0-GATE | Pending | [L694](MASTER_SPEC.md#L694) 8.2 Visitor Mode â€” Human Mode / Requirements / Seated mode | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Seated mode |
| S08-L695 | 1 | M0-GATE | Pending | [L695](MASTER_SPEC.md#L695) 8.2 Visitor Mode â€” Human Mode / Requirements / Standing mode | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Standing mode |
| S08-L696 | 1 | M0-GATE | Pending | [L696](MASTER_SPEC.md#L696) 8.2 Visitor Mode â€” Human Mode / Requirements / Controller interaction | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Controller interaction |
| S08-L697 | 2 | M1-GATE | Pending | [L697](MASTER_SPEC.md#L697) 8.2 Visitor Mode â€” Human Mode / Requirements / Wrist-mounted management interface | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Wrist-mounted management interface |
| S08-L698 | 1 | M0-GATE | Pending | [L698](MASTER_SPEC.md#L698) 8.2 Visitor Mode â€” Human Mode / Requirements / Object inspection | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Object inspection |
| S08-L699 | 4 | M3-GATE | Pending | [L699](MASTER_SPEC.md#L699) 8.2 Visitor Mode â€” Human Mode / Requirements / Ride boarding | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Ride boarding |
| S08-L700 | 5 | M4-GATE | Pending | [L700](MASTER_SPEC.md#L700) 8.2 Visitor Mode â€” Human Mode / Requirements / Staff interaction | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Staff interaction |
| S08-L701 | 3 | M2-GATE | Pending | [L701](MASTER_SPEC.md#L701) 8.2 Visitor Mode â€” Human Mode / Requirements / Guest interaction | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Guest interaction |
| S08-L702 | 1 | M0-GATE | Pending | [L702](MASTER_SPEC.md#L702) 8.2 Visitor Mode â€” Human Mode / Requirements / Park exploration | Demonstrate or document 8.2 Visitor Mode â€” Human Mode / Park exploration |
| S08-L704 | 1 | M0-GATE | Pending | [L704](MASTER_SPEC.md#L704) 8.2 Visitor Mode â€” Human Mode / Use XR Interaction Toolkit for core interaction patterns. | Verify 8.2 Visitor Mode â€” Human Mode / Use XR Interaction Toolkit for core interaction patterns. |
| S08-L708 | 1 | M0-GATE | Pending | [L708](MASTER_SPEC.md#L708) 8.3 VR Comfort / Provide: | Verify 8.3 VR Comfort / Provide: |
| S08-L710 | 1 | M0-GATE | Pending | [L710](MASTER_SPEC.md#L710) 8.3 VR Comfort / Provide / Teleportation as the default. | Demonstrate or document 8.3 VR Comfort / Teleportation as the default. |
| S08-L711 | 1 | M0-GATE | Pending | [L711](MASTER_SPEC.md#L711) 8.3 VR Comfort / Provide / Snap turning as the default. | Demonstrate or document 8.3 VR Comfort / Snap turning as the default. |
| S08-L712 | 1 | M0-GATE | Pending | [L712](MASTER_SPEC.md#L712) 8.3 VR Comfort / Provide / Adjustable movement speed. | Demonstrate or document 8.3 VR Comfort / Adjustable movement speed. |
| S08-L713 | 1 | M0-GATE | Conditional | [L713](MASTER_SPEC.md#L713) 8.3 VR Comfort / Provide / Optional movement vignette. | Demonstrate or document 8.3 VR Comfort / Optional movement vignette. |
| S08-L714 | 1 | M0-GATE | Pending | [L714](MASTER_SPEC.md#L714) 8.3 VR Comfort / Provide / Seated and standing height calibration. | Demonstrate or document 8.3 VR Comfort / Seated and standing height calibration. |
| S08-L715 | 1 | M0-GATE | Conditional | [L715](MASTER_SPEC.md#L715) 8.3 VR Comfort / Provide / Controller rebinding where feasible. | Demonstrate or document 8.3 VR Comfort / Controller rebinding where feasible. |
| S08-L716 | 1 | M0-GATE | Pending | [L716](MASTER_SPEC.md#L716) 8.3 VR Comfort / Provide / Left-handed interaction preference. | Demonstrate or document 8.3 VR Comfort / Left-handed interaction preference. |
| S08-L717 | 1 | M0-GATE | Pending | [L717](MASTER_SPEC.md#L717) 8.3 VR Comfort / Provide / Comfortable UI viewing distances. | Demonstrate or document 8.3 VR Comfort / Comfortable UI viewing distances. |
| S08-L718 | 1 | M0-GATE | Pending | [L718](MASTER_SPEC.md#L718) 8.3 VR Comfort / Provide / Avoidance of forced camera movement. | Demonstrate or document 8.3 VR Comfort / Avoidance of forced camera movement. |
| S08-L719 | 1 | M0-GATE | Pending | [L719](MASTER_SPEC.md#L719) 8.3 VR Comfort / Provide / Pause and recenter options. | Demonstrate or document 8.3 VR Comfort / Pause and recenter options. |
| S08-L720 | 1 | M0-GATE | Pending | [L720](MASTER_SPEC.md#L720) 8.3 VR Comfort / Provide / Motion intensity warnings for rides. | Demonstrate or document 8.3 VR Comfort / Motion intensity warnings for rides. |
| S08-L722 | 1 | M0-GATE | Pending | [L722](MASTER_SPEC.md#L722) 8.3 VR Comfort / Never animate the XR camera independently of tracked head movement. | Verify 8.3 VR Comfort / Never animate the XR camera independently of tracked head movement. |

### 9. CONSTRUCTION AND BUILDING SYSTEM

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S09-L728 | 2 | M1-GATE | Pending | [L728](MASTER_SPEC.md#L728) Implement a modular construction framework. | Verify Implement a modular construction framework. |
| S09-L732 | 2 | M1-GATE | Pending | [L732](MASTER_SPEC.md#L732) 9.1 Construction Catalog / Categories: | Verify 9.1 Construction Catalog / Categories: |
| S09-L734 | 2 | M1-GATE | Pending | [L734](MASTER_SPEC.md#L734) 9.1 Construction Catalog / Categories / Attractions | Demonstrate or document 9.1 Construction Catalog / Attractions |
| S09-L735 | 2 | M1-GATE | Pending | [L735](MASTER_SPEC.md#L735) 9.1 Construction Catalog / Categories / Shops | Demonstrate or document 9.1 Construction Catalog / Shops |
| S09-L736 | 2 | M1-GATE | Pending | [L736](MASTER_SPEC.md#L736) 9.1 Construction Catalog / Categories / Facilities | Demonstrate or document 9.1 Construction Catalog / Facilities |
| S09-L737 | 2 | M1-GATE | Pending | [L737](MASTER_SPEC.md#L737) 9.1 Construction Catalog / Categories / Paths | Demonstrate or document 9.1 Construction Catalog / Paths |
| S09-L738 | 2 | M1-GATE | Pending | [L738](MASTER_SPEC.md#L738) 9.1 Construction Catalog / Categories / Decorations | Demonstrate or document 9.1 Construction Catalog / Decorations |
| S09-L739 | 2 | M1-GATE | Pending | [L739](MASTER_SPEC.md#L739) 9.1 Construction Catalog / Categories / Utilities | Demonstrate or document 9.1 Construction Catalog / Utilities |
| S09-L740 | 2 | M1-GATE | Pending | [L740](MASTER_SPEC.md#L740) 9.1 Construction Catalog / Categories / Staff Buildings | Demonstrate or document 9.1 Construction Catalog / Staff Buildings |
| S09-L741 | 2 | M1-GATE | Pending | [L741](MASTER_SPEC.md#L741) 9.1 Construction Catalog / Categories / Landscaping | Demonstrate or document 9.1 Construction Catalog / Landscaping |
| S09-L742 | 2 | M1-GATE | Pending | [L742](MASTER_SPEC.md#L742) 9.1 Construction Catalog / Categories / Themed Structures | Demonstrate or document 9.1 Construction Catalog / Themed Structures |
| S09-L746 | 2 | M1-GATE | Pending | [L746](MASTER_SPEC.md#L746) 9.2 Building Placement / Requirements: | Verify 9.2 Building Placement / Requirements: |
| S09-L748 | 2 | M1-GATE | Pending | [L748](MASTER_SPEC.md#L748) 9.2 Building Placement / Requirements / XR controller selection | Demonstrate or document 9.2 Building Placement / XR controller selection |
| S09-L749 | 2 | M1-GATE | Pending | [L749](MASTER_SPEC.md#L749) 9.2 Building Placement / Requirements / Holographic preview | Demonstrate or document 9.2 Building Placement / Holographic preview |
| S09-L750 | 2 | M1-GATE | Pending | [L750](MASTER_SPEC.md#L750) 9.2 Building Placement / Requirements / Valid placement feedback | Demonstrate or document 9.2 Building Placement / Valid placement feedback |
| S09-L751 | 2 | M1-GATE | Pending | [L751](MASTER_SPEC.md#L751) 9.2 Building Placement / Requirements / Invalid placement feedback | Demonstrate or document 9.2 Building Placement / Invalid placement feedback |
| S09-L752 | 2 | M1-GATE | Pending | [L752](MASTER_SPEC.md#L752) 9.2 Building Placement / Requirements / Collision checks | Demonstrate or document 9.2 Building Placement / Collision checks |
| S09-L753 | 2 | M1-GATE | Pending | [L753](MASTER_SPEC.md#L753) 9.2 Building Placement / Requirements / Terrain alignment | Demonstrate or document 9.2 Building Placement / Terrain alignment |
| S09-L754 | 2 | M1-GATE | Pending | [L754](MASTER_SPEC.md#L754) 9.2 Building Placement / Requirements / Rotation | Demonstrate or document 9.2 Building Placement / Rotation |
| S09-L755 | 2 | M1-GATE | Pending | [L755](MASTER_SPEC.md#L755) 9.2 Building Placement / Requirements / Placement confirmation | Demonstrate or document 9.2 Building Placement / Placement confirmation |
| S09-L756 | 2 | M1-GATE | Pending | [L756](MASTER_SPEC.md#L756) 9.2 Building Placement / Requirements / Cancellation | Demonstrate or document 9.2 Building Placement / Cancellation |
| S09-L757 | 2 | M1-GATE | Pending | [L757](MASTER_SPEC.md#L757) 9.2 Building Placement / Requirements / Construction cost preview | Demonstrate or document 9.2 Building Placement / Construction cost preview |
| S09-L758 | 2 | M1-GATE | Pending | [L758](MASTER_SPEC.md#L758) 9.2 Building Placement / Requirements / Construction completion | Demonstrate or document 9.2 Building Placement / Construction completion |
| S09-L759 | 2 | M1-GATE | Pending | [L759](MASTER_SPEC.md#L759) 9.2 Building Placement / Requirements / Building relocation | Demonstrate or document 9.2 Building Placement / Building relocation |
| S09-L760 | 2 | M1-GATE | Pending | [L760](MASTER_SPEC.md#L760) 9.2 Building Placement / Requirements / Building deletion with confirmation | Demonstrate or document 9.2 Building Placement / Building deletion with confirmation |
| S09-L762 | 2 | M1-GATE | Pending | [L762](MASTER_SPEC.md#L762) 9.2 Building Placement / Use a consistent world coordinate system. | Verify 9.2 Building Placement / Use a consistent world coordinate system. |
| S09-L764 | 2 | M1-GATE | Conditional | [L764](MASTER_SPEC.md#L764) 9.2 Building Placement / Support optional grid snapping and free placement where appropriate. | Verify 9.2 Building Placement / Support optional grid snapping and free placement where appropriate. |
| S09-L768 | 2 | M1-GATE | Pending | [L768](MASTER_SPEC.md#L768) 9.3 Placement Validation / Validate: | Verify 9.3 Placement Validation / Validate: |
| S09-L770 | 2 | M1-GATE | Pending | [L770](MASTER_SPEC.md#L770) 9.3 Placement Validation / Validate / Available funds | Demonstrate or document 9.3 Placement Validation / Available funds |
| S09-L771 | 2 | M1-GATE | Pending | [L771](MASTER_SPEC.md#L771) 9.3 Placement Validation / Validate / Terrain suitability | Demonstrate or document 9.3 Placement Validation / Terrain suitability |
| S09-L772 | 2 | M1-GATE | Pending | [L772](MASTER_SPEC.md#L772) 9.3 Placement Validation / Validate / Overlap with existing structures | Demonstrate or document 9.3 Placement Validation / Overlap with existing structures |
| S09-L773 | 2 | M1-GATE | Pending | [L773](MASTER_SPEC.md#L773) 9.3 Placement Validation / Validate / Path access | Demonstrate or document 9.3 Placement Validation / Path access |
| S09-L774 | 2 | M1-GATE | Pending | [L774](MASTER_SPEC.md#L774) 9.3 Placement Validation / Validate / Entrance/exit connections | Demonstrate or document 9.3 Placement Validation / Entrance/exit connections |
| S09-L775 | 2 | M1-GATE | Pending | [L775](MASTER_SPEC.md#L775) 9.3 Placement Validation / Validate / Park boundaries | Demonstrate or document 9.3 Placement Validation / Park boundaries |
| S09-L776 | 2 | M1-GATE | Pending | [L776](MASTER_SPEC.md#L776) 9.3 Placement Validation / Validate / Required clearances | Demonstrate or document 9.3 Placement Validation / Required clearances |
| S09-L777 | 2 | M1-GATE | Pending | [L777](MASTER_SPEC.md#L777) 9.3 Placement Validation / Validate / Unlock requirements | Demonstrate or document 9.3 Placement Validation / Unlock requirements |
| S09-L779 | 2 | M1-GATE | Pending | [L779](MASTER_SPEC.md#L779) 9.3 Placement Validation / Invalid buildings must not charge money. | Verify 9.3 Placement Validation / Invalid buildings must not charge money. |
| S09-L781 | 2 | M1-GATE | Pending | [L781](MASTER_SPEC.md#L781) 9.3 Placement Validation / Construction transactions should be atomic. | Verify 9.3 Placement Validation / Construction transactions should be atomic. |
| S09-L785 | 2 | M1-GATE | Pending | [L785](MASTER_SPEC.md#L785) 9.4 Path System / Paths are essential. | Verify 9.4 Path System / Paths are essential. |
| S09-L787 | 2 | M1-GATE | Pending | [L787](MASTER_SPEC.md#L787) 9.4 Path System / Implement: | Verify 9.4 Path System / Implement: |
| S09-L789 | 2 | M1-GATE | Pending | [L789](MASTER_SPEC.md#L789) 9.4 Path System / Implement / Path placement | Demonstrate or document 9.4 Path System / Path placement |
| S09-L790 | 2 | M1-GATE | Pending | [L790](MASTER_SPEC.md#L790) 9.4 Path System / Implement / Path removal | Demonstrate or document 9.4 Path System / Path removal |
| S09-L791 | 2 | M1-GATE | Pending | [L791](MASTER_SPEC.md#L791) 9.4 Path System / Implement / Connectivity | Demonstrate or document 9.4 Path System / Connectivity |
| S09-L792 | 2 | M1-GATE | Pending | [L792](MASTER_SPEC.md#L792) 9.4 Path System / Implement / Guest navigation | Demonstrate or document 9.4 Path System / Guest navigation |
| S09-L793 | 2 | M1-GATE | Pending | [L793](MASTER_SPEC.md#L793) 9.4 Path System / Implement / Queue paths | Demonstrate or document 9.4 Path System / Queue paths |
| S09-L794 | 2 | M1-GATE | Pending | [L794](MASTER_SPEC.md#L794) 9.4 Path System / Implement / Staff access | Demonstrate or document 9.4 Path System / Staff access |
| S09-L795 | 2 | M1-GATE | Pending | [L795](MASTER_SPEC.md#L795) 9.4 Path System / Implement / Entrance connections | Demonstrate or document 9.4 Path System / Entrance connections |
| S09-L796 | 2 | M1-GATE | Pending | [L796](MASTER_SPEC.md#L796) 9.4 Path System / Implement / Path width categories | Demonstrate or document 9.4 Path System / Path width categories |
| S09-L798 | 2 | M1-GATE | Pending | [L798](MASTER_SPEC.md#L798) 9.4 Path System / The navigation system must update after construction changes. | Verify 9.4 Path System / The navigation system must update after construction changes. |
| S09-L800 | 2 | M1-GATE | Pending | [L800](MASTER_SPEC.md#L800) 9.4 Path System / Avoid full navigation rebuilds for every small placement. | Verify 9.4 Path System / Avoid full navigation rebuilds for every small placement. |

### 10. ATTRACTION SYSTEM

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S10-L806 | 4 | M3-GATE | Pending | [L806](MASTER_SPEC.md#L806) All attractions should share a common operational framework. | Verify All attractions should share a common operational framework. |
| S10-L808 | 4 | M3-GATE | Conditional | [L808](MASTER_SPEC.md#L808) Suggested interfaces: | Verify Suggested interfaces: |
| S10-L810 | 4 | M3-GATE | Pending | [L810](MASTER_SPEC.md#L810) IAttraction | Verify IAttraction |
| S10-L812 | 4 | M3-GATE | Pending | [L812](MASTER_SPEC.md#L812) IRideableAttraction | Verify IRideableAttraction |
| S10-L814 | 4 | M3-GATE | Pending | [L814](MASTER_SPEC.md#L814) IMaintainable | Verify IMaintainable |
| S10-L816 | 4 | M3-GATE | Pending | [L816](MASTER_SPEC.md#L816) IRevenueGenerator | Verify IRevenueGenerator |
| S10-L818 | 4 | M3-GATE | Pending | [L818](MASTER_SPEC.md#L818) IQueueProvider | Verify IQueueProvider |
| S10-L820 | 4 | M3-GATE | Pending | [L820](MASTER_SPEC.md#L820) Use composition rather than forcing all attractions into a deep inheritance hierarchy. | Verify Use composition rather than forcing all attractions into a deep inheritance hierarchy. |
| S10-L824 | 4 | M3-GATE | Pending | [L824](MASTER_SPEC.md#L824) 10.1 Attraction Data / Each attraction has: | Verify 10.1 Attraction Data / Each attraction has: |
| S10-L826 | 4 | M3-GATE | Pending | [L826](MASTER_SPEC.md#L826) 10.1 Attraction Data / Each attraction has / Unique ID | Demonstrate or document 10.1 Attraction Data / Unique ID |
| S10-L827 | 4 | M3-GATE | Pending | [L827](MASTER_SPEC.md#L827) 10.1 Attraction Data / Each attraction has / Name | Demonstrate or document 10.1 Attraction Data / Name |
| S10-L828 | 4 | M3-GATE | Pending | [L828](MASTER_SPEC.md#L828) 10.1 Attraction Data / Each attraction has / Type | Demonstrate or document 10.1 Attraction Data / Type |
| S10-L829 | 4 | M3-GATE | Pending | [L829](MASTER_SPEC.md#L829) 10.1 Attraction Data / Each attraction has / Construction cost | Demonstrate or document 10.1 Attraction Data / Construction cost |
| S10-L830 | 4 | M3-GATE | Pending | [L830](MASTER_SPEC.md#L830) 10.1 Attraction Data / Each attraction has / Ticket price | Demonstrate or document 10.1 Attraction Data / Ticket price |
| S10-L831 | 4 | M3-GATE | Pending | [L831](MASTER_SPEC.md#L831) 10.1 Attraction Data / Each attraction has / Capacity | Demonstrate or document 10.1 Attraction Data / Capacity |
| S10-L832 | 4 | M3-GATE | Pending | [L832](MASTER_SPEC.md#L832) 10.1 Attraction Data / Each attraction has / Cycle duration | Demonstrate or document 10.1 Attraction Data / Cycle duration |
| S10-L833 | 4 | M3-GATE | Pending | [L833](MASTER_SPEC.md#L833) 10.1 Attraction Data / Each attraction has / Excitement | Demonstrate or document 10.1 Attraction Data / Excitement |
| S10-L834 | 4 | M3-GATE | Pending | [L834](MASTER_SPEC.md#L834) 10.1 Attraction Data / Each attraction has / Intensity | Demonstrate or document 10.1 Attraction Data / Intensity |
| S10-L835 | 4 | M3-GATE | Pending | [L835](MASTER_SPEC.md#L835) 10.1 Attraction Data / Each attraction has / Nausea tendency | Demonstrate or document 10.1 Attraction Data / Nausea tendency |
| S10-L836 | 4 | M3-GATE | Pending | [L836](MASTER_SPEC.md#L836) 10.1 Attraction Data / Each attraction has / Reliability | Demonstrate or document 10.1 Attraction Data / Reliability |
| S10-L837 | 4 | M3-GATE | Pending | [L837](MASTER_SPEC.md#L837) 10.1 Attraction Data / Each attraction has / Maintenance cost | Demonstrate or document 10.1 Attraction Data / Maintenance cost |
| S10-L838 | 4 | M3-GATE | Pending | [L838](MASTER_SPEC.md#L838) 10.1 Attraction Data / Each attraction has / Operating cost | Demonstrate or document 10.1 Attraction Data / Operating cost |
| S10-L839 | 4 | M3-GATE | Pending | [L839](MASTER_SPEC.md#L839) 10.1 Attraction Data / Each attraction has / Popularity | Demonstrate or document 10.1 Attraction Data / Popularity |
| S10-L840 | 4 | M3-GATE | Pending | [L840](MASTER_SPEC.md#L840) 10.1 Attraction Data / Each attraction has / Required staff | Demonstrate or document 10.1 Attraction Data / Required staff |
| S10-L841 | 4 | M3-GATE | Pending | [L841](MASTER_SPEC.md#L841) 10.1 Attraction Data / Each attraction has / Queue capacity | Demonstrate or document 10.1 Attraction Data / Queue capacity |
| S10-L842 | 4 | M3-GATE | Pending | [L842](MASTER_SPEC.md#L842) 10.1 Attraction Data / Each attraction has / Current condition | Demonstrate or document 10.1 Attraction Data / Current condition |
| S10-L843 | 4 | M3-GATE | Pending | [L843](MASTER_SPEC.md#L843) 10.1 Attraction Data / Each attraction has / Operational state | Demonstrate or document 10.1 Attraction Data / Operational state |
| S10-L847 | 4 | M3-GATE | Pending | [L847](MASTER_SPEC.md#L847) 10.2 Attraction Lifecycle / States: | Verify 10.2 Attraction Lifecycle / States: |
| S10-L849 | 4 | M3-GATE | Pending | [L849](MASTER_SPEC.md#L849) 10.2 Attraction Lifecycle / States / Under Construction | Demonstrate or document 10.2 Attraction Lifecycle / Under Construction |
| S10-L850 | 4 | M3-GATE | Pending | [L850](MASTER_SPEC.md#L850) 10.2 Attraction Lifecycle / States / Closed | Demonstrate or document 10.2 Attraction Lifecycle / Closed |
| S10-L851 | 4 | M3-GATE | Pending | [L851](MASTER_SPEC.md#L851) 10.2 Attraction Lifecycle / States / Opening | Demonstrate or document 10.2 Attraction Lifecycle / Opening |
| S10-L852 | 4 | M3-GATE | Pending | [L852](MASTER_SPEC.md#L852) 10.2 Attraction Lifecycle / States / Operating | Demonstrate or document 10.2 Attraction Lifecycle / Operating |
| S10-L853 | 4 | M3-GATE | Pending | [L853](MASTER_SPEC.md#L853) 10.2 Attraction Lifecycle / States / Boarding | Demonstrate or document 10.2 Attraction Lifecycle / Boarding |
| S10-L854 | 4 | M3-GATE | Pending | [L854](MASTER_SPEC.md#L854) 10.2 Attraction Lifecycle / States / Running | Demonstrate or document 10.2 Attraction Lifecycle / Running |
| S10-L855 | 4 | M3-GATE | Pending | [L855](MASTER_SPEC.md#L855) 10.2 Attraction Lifecycle / States / Unloading | Demonstrate or document 10.2 Attraction Lifecycle / Unloading |
| S10-L856 | 4 | M3-GATE | Pending | [L856](MASTER_SPEC.md#L856) 10.2 Attraction Lifecycle / States / Maintenance | Demonstrate or document 10.2 Attraction Lifecycle / Maintenance |
| S10-L857 | 4 | M3-GATE | Pending | [L857](MASTER_SPEC.md#L857) 10.2 Attraction Lifecycle / States / Broken Down | Demonstrate or document 10.2 Attraction Lifecycle / Broken Down |
| S10-L859 | 4 | M3-GATE | Pending | [L859](MASTER_SPEC.md#L859) 10.2 Attraction Lifecycle / Transitions must be validated. | Verify 10.2 Attraction Lifecycle / Transitions must be validated. |
| S10-L861 | 4 | M3-GATE | Pending | [L861](MASTER_SPEC.md#L861) 10.2 Attraction Lifecycle / An attraction must not accept new riders while broken, closed, or under maintenance. | Verify 10.2 Attraction Lifecycle / An attraction must not accept new riders while broken, closed, or under maintenance. |
| S10-L865 | 4 | M3-GATE | Pending | [L865](MASTER_SPEC.md#L865) 10.3 Initial Attractions / Implement at least three fully functional attractions for the first vertical slice. | Verify 10.3 Initial Attractions / Implement at least three fully functional attractions for the first vertical slice. |
| S10-L869 | 4 | M3-GATE | Pending | [L869](MASTER_SPEC.md#L869) Carousel / Rotating platform | Demonstrate or document Carousel / Rotating platform |
| S10-L870 | 4 | M3-GATE | Pending | [L870](MASTER_SPEC.md#L870) Carousel / Animated ride seats | Demonstrate or document Carousel / Animated ride seats |
| S10-L871 | 4 | M3-GATE | Pending | [L871](MASTER_SPEC.md#L871) Carousel / Guest boarding | Demonstrate or document Carousel / Guest boarding |
| S10-L872 | 4 | M3-GATE | Pending | [L872](MASTER_SPEC.md#L872) Carousel / Ride cycle | Demonstrate or document Carousel / Ride cycle |
| S10-L873 | 4 | M3-GATE | Pending | [L873](MASTER_SPEC.md#L873) Carousel / Ticket payment | Demonstrate or document Carousel / Ticket payment |
| S10-L874 | 4 | M3-GATE | Pending | [L874](MASTER_SPEC.md#L874) Carousel / Operational controls | Demonstrate or document Carousel / Operational controls |
| S10-L875 | 4 | M3-GATE | Pending | [L875](MASTER_SPEC.md#L875) Carousel / Player ride support | Demonstrate or document Carousel / Player ride support |
| S10-L879 | 4 | M3-GATE | Pending | [L879](MASTER_SPEC.md#L879) Ferris Wheel / Rotating wheel | Demonstrate or document Ferris Wheel / Rotating wheel |
| S10-L880 | 4 | M3-GATE | Pending | [L880](MASTER_SPEC.md#L880) Ferris Wheel / Suspended gondolas | Demonstrate or document Ferris Wheel / Suspended gondolas |
| S10-L881 | 4 | M3-GATE | Pending | [L881](MASTER_SPEC.md#L881) Ferris Wheel / Boarding/unloading | Demonstrate or document Ferris Wheel / Boarding/unloading |
| S10-L882 | 4 | M3-GATE | Pending | [L882](MASTER_SPEC.md#L882) Ferris Wheel / Ticket payment | Demonstrate or document Ferris Wheel / Ticket payment |
| S10-L883 | 4 | M3-GATE | Pending | [L883](MASTER_SPEC.md#L883) Ferris Wheel / Ride cycle | Demonstrate or document Ferris Wheel / Ride cycle |
| S10-L884 | 4 | M3-GATE | Pending | [L884](MASTER_SPEC.md#L884) Ferris Wheel / Player ride support | Demonstrate or document Ferris Wheel / Player ride support |
| S10-L888 | 4 | M3-GATE | Pending | [L888](MASTER_SPEC.md#L888) Roller Coaster / Functional track | Demonstrate or document Roller Coaster / Functional track |
| S10-L889 | 4 | M3-GATE | Pending | [L889](MASTER_SPEC.md#L889) Roller Coaster / Train movement | Demonstrate or document Roller Coaster / Train movement |
| S10-L890 | 4 | M3-GATE | Conditional | [L890](MASTER_SPEC.md#L890) Roller Coaster / Multiple cars if practical | Demonstrate or document Roller Coaster / Multiple cars if practical |
| S10-L891 | 4 | M3-GATE | Pending | [L891](MASTER_SPEC.md#L891) Roller Coaster / Station | Demonstrate or document Roller Coaster / Station |
| S10-L892 | 4 | M3-GATE | Pending | [L892](MASTER_SPEC.md#L892) Roller Coaster / Boarding/unloading | Demonstrate or document Roller Coaster / Boarding/unloading |
| S10-L893 | 4 | M3-GATE | Pending | [L893](MASTER_SPEC.md#L893) Roller Coaster / Ticket payment | Demonstrate or document Roller Coaster / Ticket payment |
| S10-L894 | 4 | M3-GATE | Pending | [L894](MASTER_SPEC.md#L894) Roller Coaster / Ride cycle | Demonstrate or document Roller Coaster / Ride cycle |
| S10-L895 | 4 | M3-GATE | Pending | [L895](MASTER_SPEC.md#L895) Roller Coaster / Player ride support | Demonstrate or document Roller Coaster / Player ride support |
| S10-L896 | 4 | M3-GATE | Pending | [L896](MASTER_SPEC.md#L896) Roller Coaster / Intensity and nausea ratings | Demonstrate or document Roller Coaster / Intensity and nausea ratings |
| S10-L898 | 4 | M3-GATE | Pending | [L898](MASTER_SPEC.md#L898) Roller Coaster / Start with a predefined roller coaster track. | Verify Roller Coaster / Start with a predefined roller coaster track. |
| S10-L900 | 10 | M9-GATE | Deferred | [L900](MASTER_SPEC.md#L900) Roller Coaster / A fully editable spline coaster builder is a later milestone. | Verify Roller Coaster / A fully editable spline coaster builder is a later milestone. |
| S10-L902 | 4 | M3-GATE | Pending | [L902](MASTER_SPEC.md#L902) Roller Coaster / Do not attempt a sophisticated coaster editor before the basic simulation and ride experience are stable. | Verify Roller Coaster / Do not attempt a sophisticated coaster editor before the basic simulation and ride experience are stable. |
| S10-L906 | 4 | M3-GATE | Pending | [L906](MASTER_SPEC.md#L906) 10.4 Ride Economics / A guest should pay when the attraction's configured payment event occurs. | Verify 10.4 Ride Economics / A guest should pay when the attraction's configured payment event occurs. |
| S10-L908 | 4 | M3-GATE | Pending | [L908](MASTER_SPEC.md#L908) 10.4 Ride Economics / For the initial implementation, charge when the guest successfully enters the ride's boarding process. | Verify 10.4 Ride Economics / For the initial implementation, charge when the guest successfully enters the ride's boarding process. |
| S10-L910 | 4 | M3-GATE | Pending | [L910](MASTER_SPEC.md#L910) 10.4 Ride Economics / Prevent duplicate charges. | Verify 10.4 Ride Economics / Prevent duplicate charges. |
| S10-L912 | 4 | M3-GATE | Pending | [L912](MASTER_SPEC.md#L912) 10.4 Ride Economics / Refund or compensate guests when a paid ride is canceled before operation according to configured park policy. | Verify 10.4 Ride Economics / Refund or compensate guests when a paid ride is canceled before operation according to configured park policy. |
| S10-L914 | 4 | M3-GATE | Pending | [L914](MASTER_SPEC.md#L914) 10.4 Ride Economics / Record revenue in the park ledger. | Verify 10.4 Ride Economics / Record revenue in the park ledger. |
| S10-L918 | 4 | M3-GATE | Pending | [L918](MASTER_SPEC.md#L918) 10.5 Player Ride Experience / The player can: | Verify 10.5 Player Ride Experience / The player can: |
| S10-L920 | 4 | M3-GATE | Pending | [L920](MASTER_SPEC.md#L920) 10.5 Player Ride Experience / The player can / Approach the attraction. | Demonstrate or document 10.5 Player Ride Experience / Approach the attraction. |
| S10-L921 | 4 | M3-GATE | Pending | [L921](MASTER_SPEC.md#L921) 10.5 Player Ride Experience / The player can / Select a ride interaction. | Demonstrate or document 10.5 Player Ride Experience / Select a ride interaction. |
| S10-L922 | 4 | M3-GATE | Pending | [L922](MASTER_SPEC.md#L922) 10.5 Player Ride Experience / The player can / Enter the boarding area. | Demonstrate or document 10.5 Player Ride Experience / Enter the boarding area. |
| S10-L923 | 4 | M3-GATE | Pending | [L923](MASTER_SPEC.md#L923) 10.5 Player Ride Experience / The player can / Choose an available seat. | Demonstrate or document 10.5 Player Ride Experience / Choose an available seat. |
| S10-L924 | 4 | M3-GATE | Pending | [L924](MASTER_SPEC.md#L924) 10.5 Player Ride Experience / The player can / Board the ride. | Demonstrate or document 10.5 Player Ride Experience / Board the ride. |
| S10-L925 | 4 | M3-GATE | Pending | [L925](MASTER_SPEC.md#L925) 10.5 Player Ride Experience / The player can / Experience the ride. | Demonstrate or document 10.5 Player Ride Experience / Experience the ride. |
| S10-L926 | 4 | M3-GATE | Pending | [L926](MASTER_SPEC.md#L926) 10.5 Player Ride Experience / The player can / Exit safely after completion. | Demonstrate or document 10.5 Player Ride Experience / Exit safely after completion. |
| S10-L928 | 4 | M3-GATE | Pending | [L928](MASTER_SPEC.md#L928) 10.5 Player Ride Experience / Implement ride seat anchoring that respects XR tracking. | Verify 10.5 Player Ride Experience / Implement ride seat anchoring that respects XR tracking. |
| S10-L930 | 4 | M3-GATE | Pending | [L930](MASTER_SPEC.md#L930) 10.5 Player Ride Experience / Never forcibly rotate the player's head. | Verify 10.5 Player Ride Experience / Never forcibly rotate the player's head. |
| S10-L932 | 4 | M3-GATE | Pending | [L932](MASTER_SPEC.md#L932) 10.5 Player Ride Experience / Provide an emergency comfort exit. | Verify 10.5 Player Ride Experience / Provide an emergency comfort exit. |
| S10-L934 | 4 | M3-GATE | Pending | [L934](MASTER_SPEC.md#L934) 10.5 Player Ride Experience / Ensure player boarding does not interfere with the AI simulation. | Verify 10.5 Player Ride Experience / Ensure player boarding does not interfere with the AI simulation. |

### 11. PEEP AI SYSTEM

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S11-L940 | 3 | M2-GATE | Pending | [L940](MASTER_SPEC.md#L940) Peeps are simulated visitors with needs, preferences, and behaviors. | Verify Peeps are simulated visitors with needs, preferences, and behaviors. |
| S11-L942 | 3 | M2-GATE | Pending | [L942](MASTER_SPEC.md#L942) The AI must create believable park activity without requiring expensive generative AI inference. | Verify The AI must create believable park activity without requiring expensive generative AI inference. |
| S11-L946 | 3 | M2-GATE | Pending | [L946](MASTER_SPEC.md#L946) 11.1 Visitor Attributes / Each visitor has: | Verify 11.1 Visitor Attributes / Each visitor has: |
| S11-L948 | 3 | M2-GATE | Pending | [L948](MASTER_SPEC.md#L948) 11.1 Visitor Attributes / Each visitor has / Unique ID | Demonstrate or document 11.1 Visitor Attributes / Unique ID |
| S11-L949 | 3 | M2-GATE | Pending | [L949](MASTER_SPEC.md#L949) 11.1 Visitor Attributes / Each visitor has / Archetype | Demonstrate or document 11.1 Visitor Attributes / Archetype |
| S11-L950 | 3 | M2-GATE | Pending | [L950](MASTER_SPEC.md#L950) 11.1 Visitor Attributes / Each visitor has / Age category | Demonstrate or document 11.1 Visitor Attributes / Age category |
| S11-L951 | 3 | M2-GATE | Pending | [L951](MASTER_SPEC.md#L951) 11.1 Visitor Attributes / Each visitor has / Group ID | Demonstrate or document 11.1 Visitor Attributes / Group ID |
| S11-L952 | 3 | M2-GATE | Pending | [L952](MASTER_SPEC.md#L952) 11.1 Visitor Attributes / Each visitor has / Budget | Demonstrate or document 11.1 Visitor Attributes / Budget |
| S11-L953 | 3 | M2-GATE | Pending | [L953](MASTER_SPEC.md#L953) 11.1 Visitor Attributes / Each visitor has / Happiness | Demonstrate or document 11.1 Visitor Attributes / Happiness |
| S11-L954 | 3 | M2-GATE | Pending | [L954](MASTER_SPEC.md#L954) 11.1 Visitor Attributes / Each visitor has / Hunger | Demonstrate or document 11.1 Visitor Attributes / Hunger |
| S11-L955 | 3 | M2-GATE | Pending | [L955](MASTER_SPEC.md#L955) 11.1 Visitor Attributes / Each visitor has / Thirst | Demonstrate or document 11.1 Visitor Attributes / Thirst |
| S11-L956 | 3 | M2-GATE | Pending | [L956](MASTER_SPEC.md#L956) 11.1 Visitor Attributes / Each visitor has / Energy | Demonstrate or document 11.1 Visitor Attributes / Energy |
| S11-L957 | 3 | M2-GATE | Pending | [L957](MASTER_SPEC.md#L957) 11.1 Visitor Attributes / Each visitor has / Nausea | Demonstrate or document 11.1 Visitor Attributes / Nausea |
| S11-L958 | 3 | M2-GATE | Pending | [L958](MASTER_SPEC.md#L958) 11.1 Visitor Attributes / Each visitor has / Patience | Demonstrate or document 11.1 Visitor Attributes / Patience |
| S11-L959 | 3 | M2-GATE | Pending | [L959](MASTER_SPEC.md#L959) 11.1 Visitor Attributes / Each visitor has / Cleanliness sensitivity | Demonstrate or document 11.1 Visitor Attributes / Cleanliness sensitivity |
| S11-L960 | 3 | M2-GATE | Pending | [L960](MASTER_SPEC.md#L960) 11.1 Visitor Attributes / Each visitor has / Preferred ride intensity | Demonstrate or document 11.1 Visitor Attributes / Preferred ride intensity |
| S11-L961 | 3 | M2-GATE | Pending | [L961](MASTER_SPEC.md#L961) 11.1 Visitor Attributes / Each visitor has / Spending preference | Demonstrate or document 11.1 Visitor Attributes / Spending preference |
| S11-L962 | 3 | M2-GATE | Pending | [L962](MASTER_SPEC.md#L962) 11.1 Visitor Attributes / Each visitor has / Current destination | Demonstrate or document 11.1 Visitor Attributes / Current destination |
| S11-L963 | 3 | M2-GATE | Pending | [L963](MASTER_SPEC.md#L963) 11.1 Visitor Attributes / Each visitor has / Current activity | Demonstrate or document 11.1 Visitor Attributes / Current activity |
| S11-L964 | 3 | M2-GATE | Pending | [L964](MASTER_SPEC.md#L964) 11.1 Visitor Attributes / Each visitor has / Satisfaction history | Demonstrate or document 11.1 Visitor Attributes / Satisfaction history |
| S11-L966 | 3 | M2-GATE | Pending | [L966](MASTER_SPEC.md#L966) 11.1 Visitor Attributes / Do not require a remote AI API for basic visitor behavior. | Verify 11.1 Visitor Attributes / Do not require a remote AI API for basic visitor behavior. |
| S11-L970 | 3 | M2-GATE | Conditional | [L970](MASTER_SPEC.md#L970) 11.2 Visitor Archetypes / Examples: | Verify 11.2 Visitor Archetypes / Examples: |
| S11-L972 | 3 | M2-GATE | Pending | [L972](MASTER_SPEC.md#L972) 11.2 Visitor Archetypes / Examples / Thrill Seeker | Demonstrate or document 11.2 Visitor Archetypes / Thrill Seeker |
| S11-L973 | 3 | M2-GATE | Pending | [L973](MASTER_SPEC.md#L973) 11.2 Visitor Archetypes / Examples / Family Visitor | Demonstrate or document 11.2 Visitor Archetypes / Family Visitor |
| S11-L974 | 3 | M2-GATE | Pending | [L974](MASTER_SPEC.md#L974) 11.2 Visitor Archetypes / Examples / Young Child | Demonstrate or document 11.2 Visitor Archetypes / Young Child |
| S11-L975 | 3 | M2-GATE | Pending | [L975](MASTER_SPEC.md#L975) 11.2 Visitor Archetypes / Examples / Casual Tourist | Demonstrate or document 11.2 Visitor Archetypes / Casual Tourist |
| S11-L976 | 3 | M2-GATE | Pending | [L976](MASTER_SPEC.md#L976) 11.2 Visitor Archetypes / Examples / Food Lover | Demonstrate or document 11.2 Visitor Archetypes / Food Lover |
| S11-L977 | 3 | M2-GATE | Pending | [L977](MASTER_SPEC.md#L977) 11.2 Visitor Archetypes / Examples / Budget Visitor | Demonstrate or document 11.2 Visitor Archetypes / Budget Visitor |
| S11-L978 | 3 | M2-GATE | Pending | [L978](MASTER_SPEC.md#L978) 11.2 Visitor Archetypes / Examples / VIP Guest | Demonstrate or document 11.2 Visitor Archetypes / VIP Guest |
| S11-L979 | 3 | M2-GATE | Pending | [L979](MASTER_SPEC.md#L979) 11.2 Visitor Archetypes / Examples / Relaxed Explorer | Demonstrate or document 11.2 Visitor Archetypes / Relaxed Explorer |
| S11-L981 | 3 | M2-GATE | Pending | [L981](MASTER_SPEC.md#L981) 11.2 Visitor Archetypes / Each archetype should influence decision weights. | Verify 11.2 Visitor Archetypes / Each archetype should influence decision weights. |
| S11-L985 | 3 | M2-GATE | Pending | [L985](MASTER_SPEC.md#L985) 11.3 Decision Making / Use a utility-based decision system or another explainable, efficient architecture. | Verify 11.3 Decision Making / Use a utility-based decision system or another explainable, efficient architecture. |
| S11-L987 | 3 | M2-GATE | Pending | [L987](MASTER_SPEC.md#L987) 11.3 Decision Making / Possible actions: | Verify 11.3 Decision Making / Possible actions: |
| S11-L989 | 3 | M2-GATE | Pending | [L989](MASTER_SPEC.md#L989) 11.3 Decision Making / Possible actions / Enter park | Demonstrate or document 11.3 Decision Making / Enter park |
| S11-L990 | 3 | M2-GATE | Pending | [L990](MASTER_SPEC.md#L990) 11.3 Decision Making / Possible actions / Select attraction | Demonstrate or document 11.3 Decision Making / Select attraction |
| S11-L991 | 3 | M2-GATE | Pending | [L991](MASTER_SPEC.md#L991) 11.3 Decision Making / Possible actions / Walk to attraction | Demonstrate or document 11.3 Decision Making / Walk to attraction |
| S11-L992 | 3 | M2-GATE | Pending | [L992](MASTER_SPEC.md#L992) 11.3 Decision Making / Possible actions / Join queue | Demonstrate or document 11.3 Decision Making / Join queue |
| S11-L993 | 3 | M2-GATE | Pending | [L993](MASTER_SPEC.md#L993) 11.3 Decision Making / Possible actions / Ride attraction | Demonstrate or document 11.3 Decision Making / Ride attraction |
| S11-L994 | 3 | M2-GATE | Pending | [L994](MASTER_SPEC.md#L994) 11.3 Decision Making / Possible actions / Buy food | Demonstrate or document 11.3 Decision Making / Buy food |
| S11-L995 | 3 | M2-GATE | Pending | [L995](MASTER_SPEC.md#L995) 11.3 Decision Making / Possible actions / Buy drink | Demonstrate or document 11.3 Decision Making / Buy drink |
| S11-L996 | 3 | M2-GATE | Pending | [L996](MASTER_SPEC.md#L996) 11.3 Decision Making / Possible actions / Visit restroom | Demonstrate or document 11.3 Decision Making / Visit restroom |
| S11-L997 | 3 | M2-GATE | Pending | [L997](MASTER_SPEC.md#L997) 11.3 Decision Making / Possible actions / Rest on bench | Demonstrate or document 11.3 Decision Making / Rest on bench |
| S11-L998 | 3 | M2-GATE | Pending | [L998](MASTER_SPEC.md#L998) 11.3 Decision Making / Possible actions / Explore | Demonstrate or document 11.3 Decision Making / Explore |
| S11-L999 | 3 | M2-GATE | Pending | [L999](MASTER_SPEC.md#L999) 11.3 Decision Making / Possible actions / Complain | Demonstrate or document 11.3 Decision Making / Complain |
| S11-L1000 | 3 | M2-GATE | Pending | [L1000](MASTER_SPEC.md#L1000) 11.3 Decision Making / Possible actions / Leave park | Demonstrate or document 11.3 Decision Making / Leave park |
| S11-L1002 | 3 | M2-GATE | Pending | [L1002](MASTER_SPEC.md#L1002) 11.3 Decision Making / Evaluate needs periodically rather than every frame. | Verify 11.3 Decision Making / Evaluate needs periodically rather than every frame. |
| S11-L1004 | 3 | M2-GATE | Pending | [L1004](MASTER_SPEC.md#L1004) 11.3 Decision Making / Use deterministic random seeds where useful for debugging. | Verify 11.3 Decision Making / Use deterministic random seeds where useful for debugging. |
| S11-L1008 | 3 | M2-GATE | Pending | [L1008](MASTER_SPEC.md#L1008) 11.4 Visitor Demand System / Visitors generate demand signals. | Verify 11.4 Visitor Demand System / Visitors generate demand signals. |
| S11-L1010 | 3 | M2-GATE | Conditional | [L1010](MASTER_SPEC.md#L1010) 11.4 Visitor Demand System / Examples: | Verify 11.4 Visitor Demand System / Examples: |
| S11-L1012 | 3 | M2-GATE | Pending | [L1012](MASTER_SPEC.md#L1012) 11.4 Visitor Demand System / "I wish this park had a bigger roller coaster." | Verify 11.4 Visitor Demand System / "I wish this park had a bigger roller coaster." |
| S11-L1014 | 3 | M2-GATE | Pending | [L1014](MASTER_SPEC.md#L1014) 11.4 Visitor Demand System / "There aren't enough food stalls." | Verify 11.4 Visitor Demand System / "There aren't enough food stalls." |
| S11-L1016 | 3 | M2-GATE | Pending | [L1016](MASTER_SPEC.md#L1016) 11.4 Visitor Demand System / "The queues are too long." | Verify 11.4 Visitor Demand System / "The queues are too long." |
| S11-L1018 | 3 | M2-GATE | Pending | [L1018](MASTER_SPEC.md#L1018) 11.4 Visitor Demand System / "This park needs more benches." | Verify 11.4 Visitor Demand System / "This park needs more benches." |
| S11-L1020 | 3 | M2-GATE | Pending | [L1020](MASTER_SPEC.md#L1020) 11.4 Visitor Demand System / Demand must affect the management interface. | Verify 11.4 Visitor Demand System / Demand must affect the management interface. |
| S11-L1022 | 3 | M2-GATE | Pending | [L1022](MASTER_SPEC.md#L1022) 11.4 Visitor Demand System / Aggregate similar requests into actionable insights. | Verify 11.4 Visitor Demand System / Aggregate similar requests into actionable insights. |
| S11-L1024 | 3 | M2-GATE | Pending | [L1024](MASTER_SPEC.md#L1024) 11.4 Visitor Demand System / Example: | Verify 11.4 Visitor Demand System / Example: |
| S11-L1026 | 3 | M2-GATE | Pending | [L1026](MASTER_SPEC.md#L1026) 11.4 Visitor Demand System / Roller Coaster Demand: High | Verify 11.4 Visitor Demand System / Roller Coaster Demand: High |
| S11-L1028 | 3 | M2-GATE | Pending | [L1028](MASTER_SPEC.md#L1028) 11.4 Visitor Demand System / Food Stall Demand: Medium | Verify 11.4 Visitor Demand System / Food Stall Demand: Medium |
| S11-L1030 | 3 | M2-GATE | Pending | [L1030](MASTER_SPEC.md#L1030) 11.4 Visitor Demand System / Restroom Demand: Critical | Verify 11.4 Visitor Demand System / Restroom Demand: Critical |
| S11-L1032 | 3 | M2-GATE | Pending | [L1032](MASTER_SPEC.md#L1032) 11.4 Visitor Demand System / The player should be able to select a demand and see relevant construction options. | Verify 11.4 Visitor Demand System / The player should be able to select a demand and see relevant construction options. |
| S11-L1036 | 3 | M2-GATE | Pending | [L1036](MASTER_SPEC.md#L1036) 11.5 Visitor Memory / Track lightweight memories such as: | Verify 11.5 Visitor Memory / Track lightweight memories such as: |
| S11-L1038 | 3 | M2-GATE | Pending | [L1038](MASTER_SPEC.md#L1038) 11.5 Visitor Memory / Track lightweight memories such as / Favorite attraction | Demonstrate or document 11.5 Visitor Memory / Favorite attraction |
| S11-L1039 | 3 | M2-GATE | Pending | [L1039](MASTER_SPEC.md#L1039) 11.5 Visitor Memory / Track lightweight memories such as / Last bad experience | Demonstrate or document 11.5 Visitor Memory / Last bad experience |
| S11-L1040 | 3 | M2-GATE | Pending | [L1040](MASTER_SPEC.md#L1040) 11.5 Visitor Memory / Track lightweight memories such as / Longest queue frustration | Demonstrate or document 11.5 Visitor Memory / Longest queue frustration |
| S11-L1041 | 3 | M2-GATE | Pending | [L1041](MASTER_SPEC.md#L1041) 11.5 Visitor Memory / Track lightweight memories such as / Food satisfaction | Demonstrate or document 11.5 Visitor Memory / Food satisfaction |
| S11-L1042 | 3 | M2-GATE | Pending | [L1042](MASTER_SPEC.md#L1042) 11.5 Visitor Memory / Track lightweight memories such as / Ride nausea | Demonstrate or document 11.5 Visitor Memory / Ride nausea |
| S11-L1043 | 3 | M2-GATE | Pending | [L1043](MASTER_SPEC.md#L1043) 11.5 Visitor Memory / Track lightweight memories such as / Overall visit satisfaction | Demonstrate or document 11.5 Visitor Memory / Overall visit satisfaction |
| S11-L1045 | 3 | M2-GATE | Pending | [L1045](MASTER_SPEC.md#L1045) 11.5 Visitor Memory / Use these to influence future decisions and repeat visits. | Verify 11.5 Visitor Memory / Use these to influence future decisions and repeat visits. |
| S11-L1047 | 3 | M2-GATE | Pending | [L1047](MASTER_SPEC.md#L1047) 11.5 Visitor Memory / Do not store unlimited event histories per guest. | Verify 11.5 Visitor Memory / Do not store unlimited event histories per guest. |
| S11-L1051 | 3 | M2-GATE | Pending | [L1051](MASTER_SPEC.md#L1051) 11.6 Visitor Navigation / Use an efficient pedestrian navigation system. | Verify 11.6 Visitor Navigation / Use an efficient pedestrian navigation system. |
| S11-L1053 | 3 | M2-GATE | Pending | [L1053](MASTER_SPEC.md#L1053) 11.6 Visitor Navigation / Requirements: | Verify 11.6 Visitor Navigation / Requirements: |
| S11-L1055 | 3 | M2-GATE | Pending | [L1055](MASTER_SPEC.md#L1055) 11.6 Visitor Navigation / Requirements / Paths as valid pedestrian areas | Demonstrate or document 11.6 Visitor Navigation / Paths as valid pedestrian areas |
| S11-L1056 | 3 | M2-GATE | Pending | [L1056](MASTER_SPEC.md#L1056) 11.6 Visitor Navigation / Requirements / Entrance and exit navigation | Demonstrate or document 11.6 Visitor Navigation / Entrance and exit navigation |
| S11-L1057 | 3 | M2-GATE | Pending | [L1057](MASTER_SPEC.md#L1057) 11.6 Visitor Navigation / Requirements / Attraction destinations | Demonstrate or document 11.6 Visitor Navigation / Attraction destinations |
| S11-L1058 | 3 | M2-GATE | Pending | [L1058](MASTER_SPEC.md#L1058) 11.6 Visitor Navigation / Requirements / Queue destinations | Demonstrate or document 11.6 Visitor Navigation / Queue destinations |
| S11-L1059 | 3 | M2-GATE | Pending | [L1059](MASTER_SPEC.md#L1059) 11.6 Visitor Navigation / Requirements / Shop destinations | Demonstrate or document 11.6 Visitor Navigation / Shop destinations |
| S11-L1060 | 3 | M2-GATE | Pending | [L1060](MASTER_SPEC.md#L1060) 11.6 Visitor Navigation / Requirements / Dynamic path changes | Demonstrate or document 11.6 Visitor Navigation / Dynamic path changes |
| S11-L1061 | 3 | M2-GATE | Pending | [L1061](MASTER_SPEC.md#L1061) 11.6 Visitor Navigation / Requirements / Local avoidance where affordable | Demonstrate or document 11.6 Visitor Navigation / Local avoidance where affordable |
| S11-L1062 | 3 | M2-GATE | Pending | [L1062](MASTER_SPEC.md#L1062) 11.6 Visitor Navigation / Requirements / Guest groups remaining reasonably coherent | Demonstrate or document 11.6 Visitor Navigation / Guest groups remaining reasonably coherent |
| S11-L1064 | 3 | M2-GATE | Pending | [L1064](MASTER_SPEC.md#L1064) 11.6 Visitor Navigation / For Quest performance, separate logical guests from high-detail rendered guests. | Verify 11.6 Visitor Navigation / For Quest performance, separate logical guests from high-detail rendered guests. |
| S11-L1066 | 3 | M2-GATE | Pending | [L1066](MASTER_SPEC.md#L1066) 11.6 Visitor Navigation / Support different simulation fidelity levels based on distance and visibility. | Verify 11.6 Visitor Navigation / Support different simulation fidelity levels based on distance and visibility. |

### 12. CLEANLINESS AND WASTE SYSTEM

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S12-L1072 | 5 | M4-GATE | Pending | [L1072](MASTER_SPEC.md#L1072) Implement visible environmental cleanliness mechanics. | Verify Implement visible environmental cleanliness mechanics. |
| S12-L1076 | 5 | M4-GATE | Pending | [L1076](MASTER_SPEC.md#L1076) 12.1 Waste Types / Litter | Demonstrate or document 12.1 Waste Types / Litter |
| S12-L1077 | 5 | M4-GATE | Pending | [L1077](MASTER_SPEC.md#L1077) 12.1 Waste Types / Food waste | Demonstrate or document 12.1 Waste Types / Food waste |
| S12-L1078 | 5 | M4-GATE | Pending | [L1078](MASTER_SPEC.md#L1078) 12.1 Waste Types / Drink containers | Demonstrate or document 12.1 Waste Types / Drink containers |
| S12-L1079 | 5 | M4-GATE | Pending | [L1079](MASTER_SPEC.md#L1079) 12.1 Waste Types / Vomit | Demonstrate or document 12.1 Waste Types / Vomit |
| S12-L1081 | 5 | M4-GATE | Pending | [L1081](MASTER_SPEC.md#L1081) 12.1 Waste Types / Waste generation should depend on guest behavior and attraction intensity. | Verify 12.1 Waste Types / Waste generation should depend on guest behavior and attraction intensity. |
| S12-L1085 | 5 | M4-GATE | Pending | [L1085](MASTER_SPEC.md#L1085) 12.2 Trash Bins / Trash bins reduce littering probability. | Verify 12.2 Trash Bins / Trash bins reduce littering probability. |
| S12-L1087 | 5 | M4-GATE | Pending | [L1087](MASTER_SPEC.md#L1087) 12.2 Trash Bins / Track: | Verify 12.2 Trash Bins / Track: |
| S12-L1089 | 5 | M4-GATE | Pending | [L1089](MASTER_SPEC.md#L1089) 12.2 Trash Bins / Track / Capacity | Demonstrate or document 12.2 Trash Bins / Capacity |
| S12-L1090 | 5 | M4-GATE | Pending | [L1090](MASTER_SPEC.md#L1090) 12.2 Trash Bins / Track / Fill level | Demonstrate or document 12.2 Trash Bins / Fill level |
| S12-L1091 | 5 | M4-GATE | Pending | [L1091](MASTER_SPEC.md#L1091) 12.2 Trash Bins / Track / Coverage area | Demonstrate or document 12.2 Trash Bins / Coverage area |
| S12-L1092 | 5 | M4-GATE | Pending | [L1092](MASTER_SPEC.md#L1092) 12.2 Trash Bins / Track / Emptying requirements | Demonstrate or document 12.2 Trash Bins / Emptying requirements |
| S12-L1096 | 5 | M4-GATE | Pending | [L1096](MASTER_SPEC.md#L1096) 12.3 Cleaner AI / Cleaners should: | Verify 12.3 Cleaner AI / Cleaners should: |
| S12-L1098 | 5 | M4-GATE | Pending | [L1098](MASTER_SPEC.md#L1098) 12.3 Cleaner AI / Cleaners should / Receive cleaning tasks. | Demonstrate or document 12.3 Cleaner AI / Receive cleaning tasks. |
| S12-L1099 | 5 | M4-GATE | Pending | [L1099](MASTER_SPEC.md#L1099) 12.3 Cleaner AI / Cleaners should / Navigate to waste. | Demonstrate or document 12.3 Cleaner AI / Navigate to waste. |
| S12-L1100 | 5 | M4-GATE | Pending | [L1100](MASTER_SPEC.md#L1100) 12.3 Cleaner AI / Cleaners should / Play cleaning animations. | Demonstrate or document 12.3 Cleaner AI / Play cleaning animations. |
| S12-L1101 | 5 | M4-GATE | Pending | [L1101](MASTER_SPEC.md#L1101) 12.3 Cleaner AI / Cleaners should / Remove waste. | Demonstrate or document 12.3 Cleaner AI / Remove waste. |
| S12-L1102 | 5 | M4-GATE | Pending | [L1102](MASTER_SPEC.md#L1102) 12.3 Cleaner AI / Cleaners should / Empty trash bins. | Demonstrate or document 12.3 Cleaner AI / Empty trash bins. |
| S12-L1103 | 5 | M4-GATE | Pending | [L1103](MASTER_SPEC.md#L1103) 12.3 Cleaner AI / Cleaners should / Return to assigned zones. | Demonstrate or document 12.3 Cleaner AI / Return to assigned zones. |
| S12-L1105 | 5 | M4-GATE | Pending | [L1105](MASTER_SPEC.md#L1105) 12.3 Cleaner AI / Use a centralized task dispatcher to avoid multiple cleaners targeting the same task. | Verify 12.3 Cleaner AI / Use a centralized task dispatcher to avoid multiple cleaners targeting the same task. |
| S12-L1109 | 5 | M4-GATE | Pending | [L1109](MASTER_SPEC.md#L1109) 12.4 Cleanliness Effects / Dirty areas reduce: | Verify 12.4 Cleanliness Effects / Dirty areas reduce: |
| S12-L1111 | 5 | M4-GATE | Pending | [L1111](MASTER_SPEC.md#L1111) 12.4 Cleanliness Effects / Dirty areas reduce / Visitor happiness | Demonstrate or document 12.4 Cleanliness Effects / Visitor happiness |
| S12-L1112 | 5 | M4-GATE | Pending | [L1112](MASTER_SPEC.md#L1112) 12.4 Cleanliness Effects / Dirty areas reduce / Park reputation | Demonstrate or document 12.4 Cleanliness Effects / Park reputation |
| S12-L1113 | 5 | M4-GATE | Pending | [L1113](MASTER_SPEC.md#L1113) 12.4 Cleanliness Effects / Dirty areas reduce / Guest willingness to remain | Demonstrate or document 12.4 Cleanliness Effects / Guest willingness to remain |
| S12-L1115 | 5 | M4-GATE | Pending | [L1115](MASTER_SPEC.md#L1115) 12.4 Cleanliness Effects / Use a spatial cleanliness model rather than one arbitrary global counter. | Verify 12.4 Cleanliness Effects / Use a spatial cleanliness model rather than one arbitrary global counter. |

### 13. EMPLOYEE MANAGEMENT

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S13-L1121 | 5 | M4-GATE | Pending | [L1121](MASTER_SPEC.md#L1121) Implement a staff management system. | Verify Implement a staff management system. |
| S13-L1127 | 5 | M4-GATE | Pending | [L1127](MASTER_SPEC.md#L1127) Cleaner / Removes litter, vomit, and overflowing waste. | Verify Cleaner / Removes litter, vomit, and overflowing waste. |
| S13-L1131 | 5 | M4-GATE | Pending | [L1131](MASTER_SPEC.md#L1131) Mechanic / Inspects and repairs attractions. | Verify Mechanic / Inspects and repairs attractions. |
| S13-L1135 | 5 | M4-GATE | Pending | [L1135](MASTER_SPEC.md#L1135) Ride Operator / Operates attractions and manages boarding. | Verify Ride Operator / Operates attractions and manages boarding. |
| S13-L1139 | 5 | M4-GATE | Pending | [L1139](MASTER_SPEC.md#L1139) Shopkeeper / Operates food, drink, and merchandise shops. | Verify Shopkeeper / Operates food, drink, and merchandise shops. |
| S13-L1143 | 5 | M4-GATE | Pending | [L1143](MASTER_SPEC.md#L1143) Security Guard / Handles defined park security events. | Verify Security Guard / Handles defined park security events. |
| S13-L1147 | 5 | M4-GATE | Pending | [L1147](MASTER_SPEC.md#L1147) Entertainer / Improves guest mood in assigned areas. | Verify Entertainer / Improves guest mood in assigned areas. |
| S13-L1151 | 5 | M4-GATE | Pending | [L1151](MASTER_SPEC.md#L1151) Staff Attributes / Employee ID | Demonstrate or document Staff Attributes / Employee ID |
| S13-L1152 | 5 | M4-GATE | Pending | [L1152](MASTER_SPEC.md#L1152) Staff Attributes / Name | Demonstrate or document Staff Attributes / Name |
| S13-L1153 | 5 | M4-GATE | Pending | [L1153](MASTER_SPEC.md#L1153) Staff Attributes / Role | Demonstrate or document Staff Attributes / Role |
| S13-L1154 | 5 | M4-GATE | Pending | [L1154](MASTER_SPEC.md#L1154) Staff Attributes / Salary | Demonstrate or document Staff Attributes / Salary |
| S13-L1155 | 5 | M4-GATE | Pending | [L1155](MASTER_SPEC.md#L1155) Staff Attributes / Skill | Demonstrate or document Staff Attributes / Skill |
| S13-L1156 | 5 | M4-GATE | Pending | [L1156](MASTER_SPEC.md#L1156) Staff Attributes / Efficiency | Demonstrate or document Staff Attributes / Efficiency |
| S13-L1157 | 5 | M4-GATE | Pending | [L1157](MASTER_SPEC.md#L1157) Staff Attributes / Morale | Demonstrate or document Staff Attributes / Morale |
| S13-L1158 | 5 | M4-GATE | Pending | [L1158](MASTER_SPEC.md#L1158) Staff Attributes / Fatigue | Demonstrate or document Staff Attributes / Fatigue |
| S13-L1159 | 5 | M4-GATE | Pending | [L1159](MASTER_SPEC.md#L1159) Staff Attributes / Assigned zone | Demonstrate or document Staff Attributes / Assigned zone |
| S13-L1160 | 5 | M4-GATE | Pending | [L1160](MASTER_SPEC.md#L1160) Staff Attributes / Current task | Demonstrate or document Staff Attributes / Current task |
| S13-L1161 | 5 | M4-GATE | Pending | [L1161](MASTER_SPEC.md#L1161) Staff Attributes / Employment status | Demonstrate or document Staff Attributes / Employment status |
| S13-L1165 | 5 | M4-GATE | Pending | [L1165](MASTER_SPEC.md#L1165) Staff Management UI / The player can: | Verify Staff Management UI / The player can: |
| S13-L1167 | 5 | M4-GATE | Pending | [L1167](MASTER_SPEC.md#L1167) Staff Management UI / The player can / Hire staff | Demonstrate or document Staff Management UI / Hire staff |
| S13-L1168 | 5 | M4-GATE | Pending | [L1168](MASTER_SPEC.md#L1168) Staff Management UI / The player can / Dismiss staff | Demonstrate or document Staff Management UI / Dismiss staff |
| S13-L1169 | 5 | M4-GATE | Pending | [L1169](MASTER_SPEC.md#L1169) Staff Management UI / The player can / Assign work zones | Demonstrate or document Staff Management UI / Assign work zones |
| S13-L1170 | 5 | M4-GATE | Pending | [L1170](MASTER_SPEC.md#L1170) Staff Management UI / The player can / View salaries | Demonstrate or document Staff Management UI / View salaries |
| S13-L1171 | 5 | M4-GATE | Pending | [L1171](MASTER_SPEC.md#L1171) Staff Management UI / The player can / View workload | Demonstrate or document Staff Management UI / View workload |
| S13-L1172 | 5 | M4-GATE | Pending | [L1172](MASTER_SPEC.md#L1172) Staff Management UI / The player can / Change assignments | Demonstrate or document Staff Management UI / Change assignments |
| S13-L1173 | 5 | M4-GATE | Pending | [L1173](MASTER_SPEC.md#L1173) Staff Management UI / The player can / Inspect performance | Demonstrate or document Staff Management UI / Inspect performance |
| S13-L1174 | 5 | M4-GATE | Pending | [L1174](MASTER_SPEC.md#L1174) Staff Management UI / The player can / Upgrade training | Demonstrate or document Staff Management UI / Upgrade training |
| S13-L1176 | 5 | M4-GATE | Pending | [L1176](MASTER_SPEC.md#L1176) Staff Management UI / Staff must visibly perform meaningful tasks. | Verify Staff Management UI / Staff must visibly perform meaningful tasks. |
| S13-L1178 | 5 | M4-GATE | Pending | [L1178](MASTER_SPEC.md#L1178) Staff Management UI / Use behavior states and task scheduling. | Verify Staff Management UI / Use behavior states and task scheduling. |
| S13-L1180 | 5 | M4-GATE | Pending | [L1180](MASTER_SPEC.md#L1180) Staff Management UI / Do not update every employee's decisions every frame. | Verify Staff Management UI / Do not update every employee's decisions every frame. |

### 14. MAINTENANCE AND SAFETY

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S14-L1186 | 5 | M4-GATE | Pending | [L1186](MASTER_SPEC.md#L1186) Attractions experience gradual wear. | Verify Attractions experience gradual wear. |
| S14-L1188 | 5 | M4-GATE | Pending | [L1188](MASTER_SPEC.md#L1188) Track: | Verify Track: |
| S14-L1190 | 5 | M4-GATE | Pending | [L1190](MASTER_SPEC.md#L1190) Track / Condition | Demonstrate or document Condition |
| S14-L1191 | 5 | M4-GATE | Pending | [L1191](MASTER_SPEC.md#L1191) Track / Reliability | Demonstrate or document Reliability |
| S14-L1192 | 5 | M4-GATE | Pending | [L1192](MASTER_SPEC.md#L1192) Track / Inspection interval | Demonstrate or document Inspection interval |
| S14-L1193 | 5 | M4-GATE | Pending | [L1193](MASTER_SPEC.md#L1193) Track / Maintenance cost | Demonstrate or document Maintenance cost |
| S14-L1194 | 5 | M4-GATE | Pending | [L1194](MASTER_SPEC.md#L1194) Track / Current fault | Demonstrate or document Current fault |
| S14-L1195 | 5 | M4-GATE | Pending | [L1195](MASTER_SPEC.md#L1195) Track / Operational state | Demonstrate or document Operational state |
| S14-L1197 | 5 | M4-GATE | Pending | [L1197](MASTER_SPEC.md#L1197) Mechanics must inspect and repair attractions. | Verify Mechanics must inspect and repair attractions. |
| S14-L1199 | 5 | M4-GATE | Pending | [L1199](MASTER_SPEC.md#L1199) An attraction with an unsafe condition must automatically stop accepting new riders. | Verify An attraction with an unsafe condition must automatically stop accepting new riders. |
| S14-L1201 | 5 | M4-GATE | Pending | [L1201](MASTER_SPEC.md#L1201) Implement safe breakdown handling. | Verify Implement safe breakdown handling. |
| S14-L1203 | 5 | M4-GATE | Pending | [L1203](MASTER_SPEC.md#L1203) Avoid graphic injuries or realistic disaster simulation. | Verify Avoid graphic injuries or realistic disaster simulation. |
| S14-L1205 | 5 | M4-GATE | Pending | [L1205](MASTER_SPEC.md#L1205) Breakdowns should primarily create operational and financial challenges. | Verify Breakdowns should primarily create operational and financial challenges. |
| S14-L1207 | 5 | M4-GATE | Pending | [L1207](MASTER_SPEC.md#L1207) Provide player-facing alerts such as: | Verify Provide player-facing alerts such as: |
| S14-L1209 | 5 | M4-GATE | Pending | [L1209](MASTER_SPEC.md#L1209) "Ferris Wheel requires maintenance." | Verify "Ferris Wheel requires maintenance." |
| S14-L1211 | 5 | M4-GATE | Pending | [L1211](MASTER_SPEC.md#L1211) "Roller Coaster temporarily closed." | Verify "Roller Coaster temporarily closed." |
| S14-L1213 | 5 | M4-GATE | Pending | [L1213](MASTER_SPEC.md#L1213) "Mechanic assigned to Carousel." | Verify "Mechanic assigned to Carousel." |
| S14-L1215 | 5 | M4-GATE | Conditional | [L1215](MASTER_SPEC.md#L1215) Optional immersive mechanic tasks may include: | Verify Optional immersive mechanic tasks may include: |
| S14-L1217 | 5 | M4-GATE | Conditional | [L1217](MASTER_SPEC.md#L1217) Optional immersive mechanic tasks may include / Inspecting a control panel | Demonstrate or document Inspecting a control panel |
| S14-L1218 | 5 | M4-GATE | Conditional | [L1218](MASTER_SPEC.md#L1218) Optional immersive mechanic tasks may include / Replacing a component | Demonstrate or document Replacing a component |
| S14-L1219 | 5 | M4-GATE | Conditional | [L1219](MASTER_SPEC.md#L1219) Optional immersive mechanic tasks may include / Resetting a maintenance indicator | Demonstrate or document Resetting a maintenance indicator |
| S14-L1221 | 5 | M4-GATE | Conditional | [L1221](MASTER_SPEC.md#L1221) Manual repair tasks should be optional. | Verify Manual repair tasks should be optional. |

### 15. SHOPS AND FACILITIES

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S15-L1227 | 6 | M5-GATE | Pending | [L1227](MASTER_SPEC.md#L1227) Implement shops as operational businesses. | Verify Implement shops as operational businesses. |
| S15-L1231 | 6 | M5-GATE | Pending | [L1231](MASTER_SPEC.md#L1231) Shop Types / Food Stall | Demonstrate or document Shop Types / Food Stall |
| S15-L1232 | 6 | M5-GATE | Pending | [L1232](MASTER_SPEC.md#L1232) Shop Types / Drink Stall | Demonstrate or document Shop Types / Drink Stall |
| S15-L1233 | 6 | M5-GATE | Pending | [L1233](MASTER_SPEC.md#L1233) Shop Types / Ice Cream Shop | Demonstrate or document Shop Types / Ice Cream Shop |
| S15-L1234 | 6 | M5-GATE | Pending | [L1234](MASTER_SPEC.md#L1234) Shop Types / Gift Shop | Demonstrate or document Shop Types / Gift Shop |
| S15-L1238 | 6 | M5-GATE | Pending | [L1238](MASTER_SPEC.md#L1238) Facilities / Restroom | Demonstrate or document Facilities / Restroom |
| S15-L1239 | 6 | M5-GATE | Pending | [L1239](MASTER_SPEC.md#L1239) Facilities / First Aid Station | Demonstrate or document Facilities / First Aid Station |
| S15-L1240 | 6 | M5-GATE | Pending | [L1240](MASTER_SPEC.md#L1240) Facilities / Seating Area | Demonstrate or document Facilities / Seating Area |
| S15-L1241 | 6 | M5-GATE | Pending | [L1241](MASTER_SPEC.md#L1241) Facilities / Trash Bin | Demonstrate or document Facilities / Trash Bin |
| S15-L1242 | 6 | M5-GATE | Pending | [L1242](MASTER_SPEC.md#L1242) Facilities / Staff Room | Demonstrate or document Facilities / Staff Room |
| S15-L1244 | 6 | M5-GATE | Pending | [L1244](MASTER_SPEC.md#L1244) Facilities / Each shop may have: | Verify Facilities / Each shop may have: |
| S15-L1246 | 6 | M5-GATE | Pending | [L1246](MASTER_SPEC.md#L1246) Facilities / Each shop may have / Construction cost | Demonstrate or document Facilities / Construction cost |
| S15-L1247 | 6 | M5-GATE | Pending | [L1247](MASTER_SPEC.md#L1247) Facilities / Each shop may have / Product pricing | Demonstrate or document Facilities / Product pricing |
| S15-L1248 | 6 | M5-GATE | Pending | [L1248](MASTER_SPEC.md#L1248) Facilities / Each shop may have / Inventory | Demonstrate or document Facilities / Inventory |
| S15-L1249 | 6 | M5-GATE | Pending | [L1249](MASTER_SPEC.md#L1249) Facilities / Each shop may have / Operating cost | Demonstrate or document Facilities / Operating cost |
| S15-L1250 | 6 | M5-GATE | Pending | [L1250](MASTER_SPEC.md#L1250) Facilities / Each shop may have / Staff requirement | Demonstrate or document Facilities / Staff requirement |
| S15-L1251 | 6 | M5-GATE | Pending | [L1251](MASTER_SPEC.md#L1251) Facilities / Each shop may have / Capacity | Demonstrate or document Facilities / Capacity |
| S15-L1252 | 6 | M5-GATE | Pending | [L1252](MASTER_SPEC.md#L1252) Facilities / Each shop may have / Customer demand | Demonstrate or document Facilities / Customer demand |
| S15-L1253 | 6 | M5-GATE | Pending | [L1253](MASTER_SPEC.md#L1253) Facilities / Each shop may have / Revenue | Demonstrate or document Facilities / Revenue |
| S15-L1254 | 6 | M5-GATE | Pending | [L1254](MASTER_SPEC.md#L1254) Facilities / Each shop may have / Profit | Demonstrate or document Facilities / Profit |
| S15-L1256 | 6 | M5-GATE | Pending | [L1256](MASTER_SPEC.md#L1256) Facilities / The first vertical slice may use simplified inventory, but purchases, demand, staff requirements, and financial effects must function. | Verify Facilities / The first vertical slice may use simplified inventory, but purchases, demand, staff requirements, and financial effects must function. |

### 16. ECONOMY SYSTEM

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S16-L1262 | 6 | M5-GATE | Pending | [L1262](MASTER_SPEC.md#L1262) Build a coherent park economy. | Verify Build a coherent park economy. |
| S16-L1266 | 4 | M3-GATE | Pending | [L1266](MASTER_SPEC.md#L1266) Revenue / Ride tickets | Demonstrate or document Revenue / Ride tickets |
| S16-L1267 | 6 | M5-GATE | Conditional | [L1267](MASTER_SPEC.md#L1267) Revenue / Park entrance fees, if enabled | Demonstrate or document Revenue / Park entrance fees, if enabled |
| S16-L1268 | 6 | M5-GATE | Pending | [L1268](MASTER_SPEC.md#L1268) Revenue / Food sales | Demonstrate or document Revenue / Food sales |
| S16-L1269 | 6 | M5-GATE | Pending | [L1269](MASTER_SPEC.md#L1269) Revenue / Drink sales | Demonstrate or document Revenue / Drink sales |
| S16-L1270 | 6 | M5-GATE | Pending | [L1270](MASTER_SPEC.md#L1270) Revenue / Merchandise sales | Demonstrate or document Revenue / Merchandise sales |
| S16-L1271 | 6 | M5-GATE | Pending | [L1271](MASTER_SPEC.md#L1271) Revenue / Special events | Demonstrate or document Revenue / Special events |
| S16-L1275 | 2 | M1-GATE | Pending | [L1275](MASTER_SPEC.md#L1275) Expenses / Construction | Demonstrate or document Expenses / Construction |
| S16-L1276 | 5 | M4-GATE | Pending | [L1276](MASTER_SPEC.md#L1276) Expenses / Employee wages | Demonstrate or document Expenses / Employee wages |
| S16-L1277 | 5 | M4-GATE | Pending | [L1277](MASTER_SPEC.md#L1277) Expenses / Maintenance | Demonstrate or document Expenses / Maintenance |
| S16-L1278 | 6 | M5-GATE | Pending | [L1278](MASTER_SPEC.md#L1278) Expenses / Shop inventory | Demonstrate or document Expenses / Shop inventory |
| S16-L1279 | 6 | M5-GATE | Pending | [L1279](MASTER_SPEC.md#L1279) Expenses / Attraction operation | Demonstrate or document Expenses / Attraction operation |
| S16-L1280 | 6 | M5-GATE | Pending | [L1280](MASTER_SPEC.md#L1280) Expenses / Research | Demonstrate or document Expenses / Research |
| S16-L1281 | 6 | M5-GATE | Pending | [L1281](MASTER_SPEC.md#L1281) Expenses / Park upgrades | Demonstrate or document Expenses / Park upgrades |
| S16-L1285 | 6 | M5-GATE | Pending | [L1285](MASTER_SPEC.md#L1285) Financial Ledger / Record all transactions. | Verify Financial Ledger / Record all transactions. |
| S16-L1287 | 6 | M5-GATE | Pending | [L1287](MASTER_SPEC.md#L1287) Financial Ledger / Every transaction should have: | Verify Financial Ledger / Every transaction should have: |
| S16-L1289 | 6 | M5-GATE | Pending | [L1289](MASTER_SPEC.md#L1289) Financial Ledger / Every transaction should have / ID | Demonstrate or document Financial Ledger / ID |
| S16-L1290 | 6 | M5-GATE | Pending | [L1290](MASTER_SPEC.md#L1290) Financial Ledger / Every transaction should have / Timestamp | Demonstrate or document Financial Ledger / Timestamp |
| S16-L1291 | 6 | M5-GATE | Pending | [L1291](MASTER_SPEC.md#L1291) Financial Ledger / Every transaction should have / Category | Demonstrate or document Financial Ledger / Category |
| S16-L1292 | 6 | M5-GATE | Pending | [L1292](MASTER_SPEC.md#L1292) Financial Ledger / Every transaction should have / Amount | Demonstrate or document Financial Ledger / Amount |
| S16-L1293 | 6 | M5-GATE | Pending | [L1293](MASTER_SPEC.md#L1293) Financial Ledger / Every transaction should have / Source | Demonstrate or document Financial Ledger / Source |
| S16-L1294 | 6 | M5-GATE | Pending | [L1294](MASTER_SPEC.md#L1294) Financial Ledger / Every transaction should have / Description | Demonstrate or document Financial Ledger / Description |
| S16-L1296 | 6 | M5-GATE | Pending | [L1296](MASTER_SPEC.md#L1296) Financial Ledger / Implement: | Verify Financial Ledger / Implement: |
| S16-L1298 | 2 | M1-GATE | Pending | [L1298](MASTER_SPEC.md#L1298) Financial Ledger / Implement / Current balance | Demonstrate or document Financial Ledger / Current balance |
| S16-L1299 | 6 | M5-GATE | Pending | [L1299](MASTER_SPEC.md#L1299) Financial Ledger / Implement / Daily revenue | Demonstrate or document Financial Ledger / Daily revenue |
| S16-L1300 | 6 | M5-GATE | Pending | [L1300](MASTER_SPEC.md#L1300) Financial Ledger / Implement / Daily expenses | Demonstrate or document Financial Ledger / Daily expenses |
| S16-L1301 | 6 | M5-GATE | Pending | [L1301](MASTER_SPEC.md#L1301) Financial Ledger / Implement / Profit/loss | Demonstrate or document Financial Ledger / Profit/loss |
| S16-L1302 | 6 | M5-GATE | Pending | [L1302](MASTER_SPEC.md#L1302) Financial Ledger / Implement / Attraction profitability | Demonstrate or document Financial Ledger / Attraction profitability |
| S16-L1303 | 6 | M5-GATE | Pending | [L1303](MASTER_SPEC.md#L1303) Financial Ledger / Implement / Shop profitability | Demonstrate or document Financial Ledger / Shop profitability |
| S16-L1304 | 6 | M5-GATE | Pending | [L1304](MASTER_SPEC.md#L1304) Financial Ledger / Implement / Salary costs | Demonstrate or document Financial Ledger / Salary costs |
| S16-L1305 | 5 | M4-GATE | Pending | [L1305](MASTER_SPEC.md#L1305) Financial Ledger / Implement / Maintenance costs | Demonstrate or document Financial Ledger / Maintenance costs |
| S16-L1307 | 2 | M1-GATE | Pending | [L1307](MASTER_SPEC.md#L1307) Financial Ledger / Prevent negative balances unless a debt system is explicitly enabled. | Verify Financial Ledger / Prevent negative balances unless a debt system is explicitly enabled. |
| S16-L1309 | 2 | M1-GATE | Pending | [L1309](MASTER_SPEC.md#L1309) Financial Ledger / Use consistent currency rounding and integer minor units where appropriate. | Verify Financial Ledger / Use consistent currency rounding and integer minor units where appropriate. |

### 17. REPUTATION AND PROGRESSION

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S17-L1315 | 7 | M6-GATE | Pending | [L1315](MASTER_SPEC.md#L1315) Create a five-star reputation system. | Verify Create a five-star reputation system. |
| S17-L1317 | 7 | M6-GATE | Pending | [L1317](MASTER_SPEC.md#L1317) Reputation depends on: | Verify Reputation depends on: |
| S17-L1319 | 7 | M6-GATE | Pending | [L1319](MASTER_SPEC.md#L1319) Reputation depends on / Visitor happiness | Demonstrate or document Visitor happiness |
| S17-L1320 | 7 | M6-GATE | Pending | [L1320](MASTER_SPEC.md#L1320) Reputation depends on / Cleanliness | Demonstrate or document Cleanliness |
| S17-L1321 | 7 | M6-GATE | Pending | [L1321](MASTER_SPEC.md#L1321) Reputation depends on / Queue satisfaction | Demonstrate or document Queue satisfaction |
| S17-L1322 | 7 | M6-GATE | Pending | [L1322](MASTER_SPEC.md#L1322) Reputation depends on / Ride variety | Demonstrate or document Ride variety |
| S17-L1323 | 7 | M6-GATE | Pending | [L1323](MASTER_SPEC.md#L1323) Reputation depends on / Reliability | Demonstrate or document Reliability |
| S17-L1324 | 7 | M6-GATE | Pending | [L1324](MASTER_SPEC.md#L1324) Reputation depends on / Pricing satisfaction | Demonstrate or document Pricing satisfaction |
| S17-L1325 | 7 | M6-GATE | Pending | [L1325](MASTER_SPEC.md#L1325) Reputation depends on / Facilities | Demonstrate or document Facilities |
| S17-L1326 | 7 | M6-GATE | Pending | [L1326](MASTER_SPEC.md#L1326) Reputation depends on / Staff service | Demonstrate or document Staff service |
| S17-L1328 | 7 | M6-GATE | Pending | [L1328](MASTER_SPEC.md#L1328) Use configurable weighted metrics. | Verify Use configurable weighted metrics. |
| S17-L1330 | 7 | M6-GATE | Pending | [L1330](MASTER_SPEC.md#L1330) Avoid arbitrary reputation increases that ignore park performance. | Verify Avoid arbitrary reputation increases that ignore park performance. |
| S17-L1334 | 7 | M6-GATE | Pending | [L1334](MASTER_SPEC.md#L1334) Progression / Unlock: | Verify Progression / Unlock: |
| S17-L1336 | 7 | M6-GATE | Pending | [L1336](MASTER_SPEC.md#L1336) Progression / Unlock / New attractions | Demonstrate or document Progression / New attractions |
| S17-L1337 | 7 | M6-GATE | Pending | [L1337](MASTER_SPEC.md#L1337) Progression / Unlock / New shops | Demonstrate or document Progression / New shops |
| S17-L1338 | 7 | M6-GATE | Pending | [L1338](MASTER_SPEC.md#L1338) Progression / Unlock / New themed areas | Demonstrate or document Progression / New themed areas |
| S17-L1339 | 7 | M6-GATE | Pending | [L1339](MASTER_SPEC.md#L1339) Progression / Unlock / Additional land | Demonstrate or document Progression / Additional land |
| S17-L1340 | 7 | M6-GATE | Pending | [L1340](MASTER_SPEC.md#L1340) Progression / Unlock / Staff training | Demonstrate or document Progression / Staff training |
| S17-L1341 | 7 | M6-GATE | Pending | [L1341](MASTER_SPEC.md#L1341) Progression / Unlock / Park upgrades | Demonstrate or document Progression / Park upgrades |
| S17-L1342 | 7 | M6-GATE | Pending | [L1342](MASTER_SPEC.md#L1342) Progression / Unlock / Decorative items | Demonstrate or document Progression / Decorative items |
| S17-L1344 | 7 | M6-GATE | Pending | [L1344](MASTER_SPEC.md#L1344) Progression / Provide research costs and requirements. | Verify Progression / Provide research costs and requirements. |
| S17-L1348 | 7 | M6-GATE | Pending | [L1348](MASTER_SPEC.md#L1348) Campaign Missions / Use data-driven mission definitions. | Verify Campaign Missions / Use data-driven mission definitions. |
| S17-L1350 | 7 | M6-GATE | Pending | [L1350](MASTER_SPEC.md#L1350) Campaign Missions / Mission types: | Verify Campaign Missions / Mission types: |
| S17-L1352 | 7 | M6-GATE | Pending | [L1352](MASTER_SPEC.md#L1352) Campaign Missions / Mission types / Construct attraction | Demonstrate or document Campaign Missions / Construct attraction |
| S17-L1353 | 7 | M6-GATE | Pending | [L1353](MASTER_SPEC.md#L1353) Campaign Missions / Mission types / Earn revenue | Demonstrate or document Campaign Missions / Earn revenue |
| S17-L1354 | 7 | M6-GATE | Pending | [L1354](MASTER_SPEC.md#L1354) Campaign Missions / Mission types / Reach visitor count | Demonstrate or document Campaign Missions / Reach visitor count |
| S17-L1355 | 7 | M6-GATE | Pending | [L1355](MASTER_SPEC.md#L1355) Campaign Missions / Mission types / Achieve happiness target | Demonstrate or document Campaign Missions / Achieve happiness target |
| S17-L1356 | 7 | M6-GATE | Pending | [L1356](MASTER_SPEC.md#L1356) Campaign Missions / Mission types / Hire employees | Demonstrate or document Campaign Missions / Hire employees |
| S17-L1357 | 7 | M6-GATE | Pending | [L1357](MASTER_SPEC.md#L1357) Campaign Missions / Mission types / Maintain cleanliness | Demonstrate or document Campaign Missions / Maintain cleanliness |
| S17-L1358 | 7 | M6-GATE | Pending | [L1358](MASTER_SPEC.md#L1358) Campaign Missions / Mission types / Reach reputation level | Demonstrate or document Campaign Missions / Reach reputation level |
| S17-L1359 | 7 | M6-GATE | Pending | [L1359](MASTER_SPEC.md#L1359) Campaign Missions / Mission types / Complete ride experience | Demonstrate or document Campaign Missions / Complete ride experience |
| S17-L1361 | 7 | M6-GATE | Pending | [L1361](MASTER_SPEC.md#L1361) Campaign Missions / Track mission completion through simulation events. | Verify Campaign Missions / Track mission completion through simulation events. |

### 18. VR USER INTERFACE

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S18-L1367 | 1 | M0-GATE | Pending | [L1367](MASTER_SPEC.md#L1367) The interface must be designed for VR, not copied directly from mobile. | Verify The interface must be designed for VR, not copied directly from mobile. |
| S18-L1371 | 1 | M0-GATE | Pending | [L1371](MASTER_SPEC.md#L1371) Wrist Dashboard / Provide access to: | Verify Wrist Dashboard / Provide access to: |
| S18-L1373 | 6 | M5-GATE | Pending | [L1373](MASTER_SPEC.md#L1373) Wrist Dashboard / Provide access to / Park balance | Demonstrate or document Wrist Dashboard / Park balance |
| S18-L1374 | 3 | M2-GATE | Pending | [L1374](MASTER_SPEC.md#L1374) Wrist Dashboard / Provide access to / Visitor count | Demonstrate or document Wrist Dashboard / Visitor count |
| S18-L1375 | 3 | M2-GATE | Pending | [L1375](MASTER_SPEC.md#L1375) Wrist Dashboard / Provide access to / Happiness | Demonstrate or document Wrist Dashboard / Happiness |
| S18-L1376 | 7 | M6-GATE | Pending | [L1376](MASTER_SPEC.md#L1376) Wrist Dashboard / Provide access to / Reputation | Demonstrate or document Wrist Dashboard / Reputation |
| S18-L1377 | 1 | M0-GATE | Pending | [L1377](MASTER_SPEC.md#L1377) Wrist Dashboard / Provide access to / Alerts | Demonstrate or document Wrist Dashboard / Alerts |
| S18-L1378 | 2 | M1-GATE | Pending | [L1378](MASTER_SPEC.md#L1378) Wrist Dashboard / Provide access to / Build menu | Demonstrate or document Wrist Dashboard / Build menu |
| S18-L1379 | 5 | M4-GATE | Pending | [L1379](MASTER_SPEC.md#L1379) Wrist Dashboard / Provide access to / Staff menu | Demonstrate or document Wrist Dashboard / Staff menu |
| S18-L1380 | 6 | M5-GATE | Pending | [L1380](MASTER_SPEC.md#L1380) Wrist Dashboard / Provide access to / Finance menu | Demonstrate or document Wrist Dashboard / Finance menu |
| S18-L1381 | 7 | M6-GATE | Pending | [L1381](MASTER_SPEC.md#L1381) Wrist Dashboard / Provide access to / Missions | Demonstrate or document Wrist Dashboard / Missions |
| S18-L1382 | 1 | M0-GATE | Pending | [L1382](MASTER_SPEC.md#L1382) Wrist Dashboard / Provide access to / Settings | Demonstrate or document Wrist Dashboard / Settings |
| S18-L1386 | 1 | M0-GATE | Pending | [L1386](MASTER_SPEC.md#L1386) Architect Mode UI / Provide: | Verify Architect Mode UI / Provide: |
| S18-L1388 | 2 | M1-GATE | Pending | [L1388](MASTER_SPEC.md#L1388) Architect Mode UI / Provide / Building catalog | Demonstrate or document Architect Mode UI / Building catalog |
| S18-L1389 | 2 | M1-GATE | Pending | [L1389](MASTER_SPEC.md#L1389) Architect Mode UI / Provide / Placement controls | Demonstrate or document Architect Mode UI / Placement controls |
| S18-L1390 | 2 | M1-GATE | Pending | [L1390](MASTER_SPEC.md#L1390) Architect Mode UI / Provide / Attraction details | Demonstrate or document Architect Mode UI / Attraction details |
| S18-L1391 | 3 | M2-GATE | Pending | [L1391](MASTER_SPEC.md#L1391) Architect Mode UI / Provide / Demand heatmaps | Demonstrate or document Architect Mode UI / Demand heatmaps |
| S18-L1392 | 5 | M4-GATE | Pending | [L1392](MASTER_SPEC.md#L1392) Architect Mode UI / Provide / Staff coverage | Demonstrate or document Architect Mode UI / Staff coverage |
| S18-L1393 | 6 | M5-GATE | Pending | [L1393](MASTER_SPEC.md#L1393) Architect Mode UI / Provide / Financial overlays | Demonstrate or document Architect Mode UI / Financial overlays |
| S18-L1397 | 3 | M2-GATE | Pending | [L1397](MASTER_SPEC.md#L1397) Visitor Inspection / Point at a visitor and select them to view: | Verify Visitor Inspection / Point at a visitor and select them to view: |
| S18-L1399 | 3 | M2-GATE | Pending | [L1399](MASTER_SPEC.md#L1399) Visitor Inspection / Point at a visitor and select them to view / Current happiness | Demonstrate or document Visitor Inspection / Current happiness |
| S18-L1400 | 3 | M2-GATE | Pending | [L1400](MASTER_SPEC.md#L1400) Visitor Inspection / Point at a visitor and select them to view / Needs | Demonstrate or document Visitor Inspection / Needs |
| S18-L1401 | 3 | M2-GATE | Pending | [L1401](MASTER_SPEC.md#L1401) Visitor Inspection / Point at a visitor and select them to view / Destination | Demonstrate or document Visitor Inspection / Destination |
| S18-L1402 | 3 | M2-GATE | Pending | [L1402](MASTER_SPEC.md#L1402) Visitor Inspection / Point at a visitor and select them to view / Recent complaint | Demonstrate or document Visitor Inspection / Recent complaint |
| S18-L1403 | 3 | M2-GATE | Pending | [L1403](MASTER_SPEC.md#L1403) Visitor Inspection / Point at a visitor and select them to view / Spending | Demonstrate or document Visitor Inspection / Spending |
| S18-L1404 | 3 | M2-GATE | Pending | [L1404](MASTER_SPEC.md#L1404) Visitor Inspection / Point at a visitor and select them to view / Attraction preference | Demonstrate or document Visitor Inspection / Attraction preference |
| S18-L1408 | 1 | M0-GATE | Pending | [L1408](MASTER_SPEC.md#L1408) Design Requirements / Large readable text | Demonstrate or document Design Requirements / Large readable text |
| S18-L1409 | 1 | M0-GATE | Pending | [L1409](MASTER_SPEC.md#L1409) Design Requirements / High contrast | Demonstrate or document Design Requirements / High contrast |
| S18-L1410 | 1 | M0-GATE | Pending | [L1410](MASTER_SPEC.md#L1410) Design Requirements / Comfortable panel distance | Demonstrate or document Design Requirements / Comfortable panel distance |
| S18-L1411 | 1 | M0-GATE | Pending | [L1411](MASTER_SPEC.md#L1411) Design Requirements / Minimal unnecessary UI clutter | Demonstrate or document Design Requirements / Minimal unnecessary UI clutter |
| S18-L1412 | 1 | M0-GATE | Pending | [L1412](MASTER_SPEC.md#L1412) Design Requirements / Clear controller interaction | Demonstrate or document Design Requirements / Clear controller interaction |
| S18-L1413 | 1 | M0-GATE | Pending | [L1413](MASTER_SPEC.md#L1413) Design Requirements / Visual and audio feedback | Demonstrate or document Design Requirements / Visual and audio feedback |
| S18-L1414 | 1 | M0-GATE | Pending | [L1414](MASTER_SPEC.md#L1414) Design Requirements / No essential information placed outside comfortable viewing areas | Demonstrate or document Design Requirements / No essential information placed outside comfortable viewing areas |
| S18-L1416 | 1 | M0-GATE | Pending | [L1416](MASTER_SPEC.md#L1416) Design Requirements / Use Unity UI Toolkit where appropriate for management and non-world-space screens, and XR-compatible world-space UI solutions for in-world interaction. | Verify Design Requirements / Use Unity UI Toolkit where appropriate for management and non-world-space screens, and XR-compatible world-space UI solutions for in-world interaction. |
| S18-L1418 | 1 | M0-GATE | Pending | [L1418](MASTER_SPEC.md#L1418) Design Requirements / Do not assume standard screen-space UI Toolkit panels automatically support XR ray interaction. | Verify Design Requirements / Do not assume standard screen-space UI Toolkit panels automatically support XR ray interaction. |
| S18-L1420 | 1 | M0-GATE | Pending | [L1420](MASTER_SPEC.md#L1420) Design Requirements / Verify the selected UI integration on the target device. | Verify Design Requirements / Verify the selected UI integration on the target device. |

### 19. BLENDER ASSET GENERATION

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S19-L1426 | 8 | M7-GATE | Pending | [L1426](MASTER_SPEC.md#L1426) Use Blender to create original missing assets. | Verify Use Blender to create original missing assets. |
| S19-L1428 | 8 | M7-GATE | Pending | [L1428](MASTER_SPEC.md#L1428) Prefer reproducible Python generation scripts for procedural geometry. | Verify Prefer reproducible Python generation scripts for procedural geometry. |
| S19-L1430 | 8 | M7-GATE | Pending | [L1430](MASTER_SPEC.md#L1430) Keep editable `.blend` files. | Verify Keep editable `.blend` files. |
| S19-L1432 | 8 | M7-GATE | Pending | [L1432](MASTER_SPEC.md#L1432) Export runtime-ready FBX or glTF assets using a verified Unity-compatible workflow. | Verify Export runtime-ready FBX or glTF assets using a verified Unity-compatible workflow. |
| S19-L1438 | 8 | M7-GATE | Pending | [L1438](MASTER_SPEC.md#L1438) Environment / Park entrance | Demonstrate or document Environment / Park entrance |
| S19-L1439 | 8 | M7-GATE | Pending | [L1439](MASTER_SPEC.md#L1439) Environment / Fences | Demonstrate or document Environment / Fences |
| S19-L1440 | 8 | M7-GATE | Pending | [L1440](MASTER_SPEC.md#L1440) Environment / Path tiles | Demonstrate or document Environment / Path tiles |
| S19-L1441 | 8 | M7-GATE | Pending | [L1441](MASTER_SPEC.md#L1441) Environment / Trees | Demonstrate or document Environment / Trees |
| S19-L1442 | 8 | M7-GATE | Pending | [L1442](MASTER_SPEC.md#L1442) Environment / Bushes | Demonstrate or document Environment / Bushes |
| S19-L1443 | 8 | M7-GATE | Pending | [L1443](MASTER_SPEC.md#L1443) Environment / Flower beds | Demonstrate or document Environment / Flower beds |
| S19-L1444 | 8 | M7-GATE | Pending | [L1444](MASTER_SPEC.md#L1444) Environment / Grass props | Demonstrate or document Environment / Grass props |
| S19-L1445 | 8 | M7-GATE | Pending | [L1445](MASTER_SPEC.md#L1445) Environment / Rocks | Demonstrate or document Environment / Rocks |
| S19-L1446 | 8 | M7-GATE | Pending | [L1446](MASTER_SPEC.md#L1446) Environment / Lamps | Demonstrate or document Environment / Lamps |
| S19-L1447 | 8 | M7-GATE | Pending | [L1447](MASTER_SPEC.md#L1447) Environment / Signs | Demonstrate or document Environment / Signs |
| S19-L1448 | 8 | M7-GATE | Pending | [L1448](MASTER_SPEC.md#L1448) Environment / Benches | Demonstrate or document Environment / Benches |
| S19-L1449 | 8 | M7-GATE | Pending | [L1449](MASTER_SPEC.md#L1449) Environment / Trash bins | Demonstrate or document Environment / Trash bins |
| S19-L1453 | 8 | M7-GATE | Pending | [L1453](MASTER_SPEC.md#L1453) Buildings / Ticket booth | Demonstrate or document Buildings / Ticket booth |
| S19-L1454 | 8 | M7-GATE | Pending | [L1454](MASTER_SPEC.md#L1454) Buildings / Food stall | Demonstrate or document Buildings / Food stall |
| S19-L1455 | 8 | M7-GATE | Pending | [L1455](MASTER_SPEC.md#L1455) Buildings / Drink stall | Demonstrate or document Buildings / Drink stall |
| S19-L1456 | 8 | M7-GATE | Pending | [L1456](MASTER_SPEC.md#L1456) Buildings / Gift shop | Demonstrate or document Buildings / Gift shop |
| S19-L1457 | 8 | M7-GATE | Pending | [L1457](MASTER_SPEC.md#L1457) Buildings / Restroom | Demonstrate or document Buildings / Restroom |
| S19-L1458 | 8 | M7-GATE | Pending | [L1458](MASTER_SPEC.md#L1458) Buildings / Staff building | Demonstrate or document Buildings / Staff building |
| S19-L1459 | 8 | M7-GATE | Pending | [L1459](MASTER_SPEC.md#L1459) Buildings / Maintenance shed | Demonstrate or document Buildings / Maintenance shed |
| S19-L1463 | 8 | M7-GATE | Pending | [L1463](MASTER_SPEC.md#L1463) Attractions / Carousel | Demonstrate or document Attractions / Carousel |
| S19-L1464 | 8 | M7-GATE | Pending | [L1464](MASTER_SPEC.md#L1464) Attractions / Ferris wheel | Demonstrate or document Attractions / Ferris wheel |
| S19-L1465 | 8 | M7-GATE | Pending | [L1465](MASTER_SPEC.md#L1465) Attractions / Roller coaster | Demonstrate or document Attractions / Roller coaster |
| S19-L1466 | 8 | M7-GATE | Pending | [L1466](MASTER_SPEC.md#L1466) Attractions / Ride stations | Demonstrate or document Attractions / Ride stations |
| S19-L1467 | 8 | M7-GATE | Pending | [L1467](MASTER_SPEC.md#L1467) Attractions / Queue barriers | Demonstrate or document Attractions / Queue barriers |
| S19-L1471 | 8 | M7-GATE | Pending | [L1471](MASTER_SPEC.md#L1471) Characters / Adult visitor | Demonstrate or document Characters / Adult visitor |
| S19-L1472 | 8 | M7-GATE | Pending | [L1472](MASTER_SPEC.md#L1472) Characters / Child visitor | Demonstrate or document Characters / Child visitor |
| S19-L1473 | 8 | M7-GATE | Pending | [L1473](MASTER_SPEC.md#L1473) Characters / Cleaner | Demonstrate or document Characters / Cleaner |
| S19-L1474 | 8 | M7-GATE | Pending | [L1474](MASTER_SPEC.md#L1474) Characters / Mechanic | Demonstrate or document Characters / Mechanic |
| S19-L1475 | 8 | M7-GATE | Pending | [L1475](MASTER_SPEC.md#L1475) Characters / Ride operator | Demonstrate or document Characters / Ride operator |
| S19-L1476 | 8 | M7-GATE | Pending | [L1476](MASTER_SPEC.md#L1476) Characters / Shopkeeper | Demonstrate or document Characters / Shopkeeper |
| S19-L1477 | 8 | M7-GATE | Pending | [L1477](MASTER_SPEC.md#L1477) Characters / Security guard | Demonstrate or document Characters / Security guard |
| S19-L1478 | 8 | M7-GATE | Pending | [L1478](MASTER_SPEC.md#L1478) Characters / Entertainer | Demonstrate or document Characters / Entertainer |
| S19-L1482 | 8 | M7-GATE | Pending | [L1482](MASTER_SPEC.md#L1482) Props / Food containers | Demonstrate or document Props / Food containers |
| S19-L1483 | 8 | M7-GATE | Pending | [L1483](MASTER_SPEC.md#L1483) Props / Drinks | Demonstrate or document Props / Drinks |
| S19-L1484 | 8 | M7-GATE | Pending | [L1484](MASTER_SPEC.md#L1484) Props / Cleaning equipment | Demonstrate or document Props / Cleaning equipment |
| S19-L1485 | 8 | M7-GATE | Pending | [L1485](MASTER_SPEC.md#L1485) Props / Toolboxes | Demonstrate or document Props / Toolboxes |
| S19-L1486 | 8 | M7-GATE | Pending | [L1486](MASTER_SPEC.md#L1486) Props / Tickets | Demonstrate or document Props / Tickets |
| S19-L1487 | 8 | M7-GATE | Pending | [L1487](MASTER_SPEC.md#L1487) Props / Park maps | Demonstrate or document Props / Park maps |
| S19-L1488 | 8 | M7-GATE | Pending | [L1488](MASTER_SPEC.md#L1488) Props / Decorative flags | Demonstrate or document Props / Decorative flags |
| S19-L1492 | 8 | M7-GATE | Pending | [L1492](MASTER_SPEC.md#L1492) 19.2 Art Direction / Use stylized realistic visuals. | Verify 19.2 Art Direction / Use stylized realistic visuals. |
| S19-L1494 | 8 | M7-GATE | Pending | [L1494](MASTER_SPEC.md#L1494) 19.2 Art Direction / Requirements: | Verify 19.2 Art Direction / Requirements: |
| S19-L1496 | 8 | M7-GATE | Pending | [L1496](MASTER_SPEC.md#L1496) 19.2 Art Direction / Requirements / Appealing proportions | Demonstrate or document 19.2 Art Direction / Appealing proportions |
| S19-L1497 | 8 | M7-GATE | Pending | [L1497](MASTER_SPEC.md#L1497) 19.2 Art Direction / Requirements / Readable silhouettes | Demonstrate or document 19.2 Art Direction / Readable silhouettes |
| S19-L1498 | 8 | M7-GATE | Pending | [L1498](MASTER_SPEC.md#L1498) 19.2 Art Direction / Requirements / Cohesive color palette | Demonstrate or document 19.2 Art Direction / Cohesive color palette |
| S19-L1499 | 8 | M7-GATE | Pending | [L1499](MASTER_SPEC.md#L1499) 19.2 Art Direction / Requirements / Physically plausible materials | Demonstrate or document 19.2 Art Direction / Physically plausible materials |
| S19-L1500 | 8 | M7-GATE | Pending | [L1500](MASTER_SPEC.md#L1500) 19.2 Art Direction / Requirements / Controlled texture detail | Demonstrate or document 19.2 Art Direction / Controlled texture detail |
| S19-L1501 | 8 | M7-GATE | Pending | [L1501](MASTER_SPEC.md#L1501) 19.2 Art Direction / Requirements / Optimized geometry | Demonstrate or document 19.2 Art Direction / Optimized geometry |
| S19-L1502 | 8 | M7-GATE | Pending | [L1502](MASTER_SPEC.md#L1502) 19.2 Art Direction / Requirements / Consistent scale | Demonstrate or document 19.2 Art Direction / Consistent scale |
| S19-L1503 | 8 | M7-GATE | Pending | [L1503](MASTER_SPEC.md#L1503) 19.2 Art Direction / Requirements / Pleasant lighting | Demonstrate or document 19.2 Art Direction / Pleasant lighting |
| S19-L1504 | 8 | M7-GATE | Pending | [L1504](MASTER_SPEC.md#L1504) 19.2 Art Direction / Requirements / Family-friendly presentation | Demonstrate or document 19.2 Art Direction / Family-friendly presentation |
| S19-L1506 | 8 | M7-GATE | Pending | [L1506](MASTER_SPEC.md#L1506) 19.2 Art Direction / Avoid photorealistic assets that require expensive rendering techniques. | Verify 19.2 Art Direction / Avoid photorealistic assets that require expensive rendering techniques. |
| S19-L1510 | 8 | M7-GATE | Pending | [L1510](MASTER_SPEC.md#L1510) 19.3 Character Animation / Create or reuse legally compatible animations for: | Verify 19.3 Character Animation / Create or reuse legally compatible animations for: |
| S19-L1512 | 8 | M7-GATE | Pending | [L1512](MASTER_SPEC.md#L1512) 19.3 Character Animation / Create or reuse legally compatible animations for / Idle | Demonstrate or document 19.3 Character Animation / Idle |
| S19-L1513 | 8 | M7-GATE | Pending | [L1513](MASTER_SPEC.md#L1513) 19.3 Character Animation / Create or reuse legally compatible animations for / Walk | Demonstrate or document 19.3 Character Animation / Walk |
| S19-L1514 | 8 | M7-GATE | Pending | [L1514](MASTER_SPEC.md#L1514) 19.3 Character Animation / Create or reuse legally compatible animations for / Run | Demonstrate or document 19.3 Character Animation / Run |
| S19-L1515 | 8 | M7-GATE | Pending | [L1515](MASTER_SPEC.md#L1515) 19.3 Character Animation / Create or reuse legally compatible animations for / Sit | Demonstrate or document 19.3 Character Animation / Sit |
| S19-L1516 | 8 | M7-GATE | Pending | [L1516](MASTER_SPEC.md#L1516) 19.3 Character Animation / Create or reuse legally compatible animations for / Eat | Demonstrate or document 19.3 Character Animation / Eat |
| S19-L1517 | 8 | M7-GATE | Pending | [L1517](MASTER_SPEC.md#L1517) 19.3 Character Animation / Create or reuse legally compatible animations for / Drink | Demonstrate or document 19.3 Character Animation / Drink |
| S19-L1518 | 8 | M7-GATE | Pending | [L1518](MASTER_SPEC.md#L1518) 19.3 Character Animation / Create or reuse legally compatible animations for / Celebrate | Demonstrate or document 19.3 Character Animation / Celebrate |
| S19-L1519 | 8 | M7-GATE | Pending | [L1519](MASTER_SPEC.md#L1519) 19.3 Character Animation / Create or reuse legally compatible animations for / Complain | Demonstrate or document 19.3 Character Animation / Complain |
| S19-L1520 | 8 | M7-GATE | Pending | [L1520](MASTER_SPEC.md#L1520) 19.3 Character Animation / Create or reuse legally compatible animations for / Queue | Demonstrate or document 19.3 Character Animation / Queue |
| S19-L1521 | 8 | M7-GATE | Pending | [L1521](MASTER_SPEC.md#L1521) 19.3 Character Animation / Create or reuse legally compatible animations for / Board ride | Demonstrate or document 19.3 Character Animation / Board ride |
| S19-L1522 | 8 | M7-GATE | Pending | [L1522](MASTER_SPEC.md#L1522) 19.3 Character Animation / Create or reuse legally compatible animations for / Exit ride | Demonstrate or document 19.3 Character Animation / Exit ride |
| S19-L1523 | 8 | M7-GATE | Pending | [L1523](MASTER_SPEC.md#L1523) 19.3 Character Animation / Create or reuse legally compatible animations for / Clean | Demonstrate or document 19.3 Character Animation / Clean |
| S19-L1524 | 8 | M7-GATE | Pending | [L1524](MASTER_SPEC.md#L1524) 19.3 Character Animation / Create or reuse legally compatible animations for / Repair | Demonstrate or document 19.3 Character Animation / Repair |
| S19-L1525 | 8 | M7-GATE | Pending | [L1525](MASTER_SPEC.md#L1525) 19.3 Character Animation / Create or reuse legally compatible animations for / Operate ride | Demonstrate or document 19.3 Character Animation / Operate ride |
| S19-L1527 | 8 | M7-GATE | Pending | [L1527](MASTER_SPEC.md#L1527) 19.3 Character Animation / Use animation retargeting when appropriate. | Verify 19.3 Character Animation / Use animation retargeting when appropriate. |
| S19-L1529 | 8 | M7-GATE | Pending | [L1529](MASTER_SPEC.md#L1529) 19.3 Character Animation / If procedural rigging cannot produce acceptable animation quality, document the limitation and use a compatible existing animation source or create simpler original animations. | Verify 19.3 Character Animation / If procedural rigging cannot produce acceptable animation quality, document the limitation and use a compatible existing animation source or create simpler original animations. |
| S19-L1531 | 8 | M7-GATE | Pending | [L1531](MASTER_SPEC.md#L1531) 19.3 Character Animation / Do not claim Blender generated polished character animation unless the exported animation has been inspected. | Verify 19.3 Character Animation / Do not claim Blender generated polished character animation unless the exported animation has been inspected. |
| S19-L1535 | 8 | M7-GATE | Pending | [L1535](MASTER_SPEC.md#L1535) 19.4 Asset Optimization / Create appropriate LODs. | Verify 19.4 Asset Optimization / Create appropriate LODs. |
| S19-L1537 | 8 | M7-GATE | Pending | [L1537](MASTER_SPEC.md#L1537) 19.4 Asset Optimization / Prefer: | Verify 19.4 Asset Optimization / Prefer: |
| S19-L1539 | 8 | M7-GATE | Pending | [L1539](MASTER_SPEC.md#L1539) 19.4 Asset Optimization / Prefer / Shared materials | Demonstrate or document 19.4 Asset Optimization / Shared materials |
| S19-L1540 | 8 | M7-GATE | Pending | [L1540](MASTER_SPEC.md#L1540) 19.4 Asset Optimization / Prefer / Texture atlases | Demonstrate or document 19.4 Asset Optimization / Texture atlases |
| S19-L1541 | 8 | M7-GATE | Pending | [L1541](MASTER_SPEC.md#L1541) 19.4 Asset Optimization / Prefer / Low material counts | Demonstrate or document 19.4 Asset Optimization / Low material counts |
| S19-L1542 | 8 | M7-GATE | Pending | [L1542](MASTER_SPEC.md#L1542) 19.4 Asset Optimization / Prefer / Efficient UV layouts | Demonstrate or document 19.4 Asset Optimization / Efficient UV layouts |
| S19-L1543 | 8 | M7-GATE | Pending | [L1543](MASTER_SPEC.md#L1543) 19.4 Asset Optimization / Prefer / Reusable modular geometry | Demonstrate or document 19.4 Asset Optimization / Reusable modular geometry |
| S19-L1544 | 8 | M7-GATE | Pending | [L1544](MASTER_SPEC.md#L1544) 19.4 Asset Optimization / Prefer / Simple collision meshes | Demonstrate or document 19.4 Asset Optimization / Simple collision meshes |
| S19-L1546 | 8 | M7-GATE | Pending | [L1546](MASTER_SPEC.md#L1546) 19.4 Asset Optimization / Avoid excessive transparency. | Verify 19.4 Asset Optimization / Avoid excessive transparency. |
| S19-L1548 | 8 | M7-GATE | Pending | [L1548](MASTER_SPEC.md#L1548) 19.4 Asset Optimization / Avoid high-resolution textures without justification. | Verify 19.4 Asset Optimization / Avoid high-resolution textures without justification. |
| S19-L1550 | 8 | M7-GATE | Pending | [L1550](MASTER_SPEC.md#L1550) 19.4 Asset Optimization / Use baked lighting where appropriate. | Verify 19.4 Asset Optimization / Use baked lighting where appropriate. |
| S19-L1554 | 8 | M7-GATE | Pending | [L1554](MASTER_SPEC.md#L1554) 19.5 Blender Deliverables / For generated assets, preserve: | Verify 19.5 Blender Deliverables / For generated assets, preserve: |
| S19-L1556 | 8 | M7-GATE | Pending | [L1556](MASTER_SPEC.md#L1556) 19.5 Blender Deliverables / For generated assets, preserve / Blender source file | Demonstrate or document 19.5 Blender Deliverables / Blender source file |
| S19-L1557 | 8 | M7-GATE | Pending | [L1557](MASTER_SPEC.md#L1557) 19.5 Blender Deliverables / For generated assets, preserve / Generation script, where applicable | Demonstrate or document 19.5 Blender Deliverables / Generation script, where applicable |
| S19-L1558 | 8 | M7-GATE | Pending | [L1558](MASTER_SPEC.md#L1558) 19.5 Blender Deliverables / For generated assets, preserve / Exported model | Demonstrate or document 19.5 Blender Deliverables / Exported model |
| S19-L1559 | 8 | M7-GATE | Pending | [L1559](MASTER_SPEC.md#L1559) 19.5 Blender Deliverables / For generated assets, preserve / Texture sources | Demonstrate or document 19.5 Blender Deliverables / Texture sources |
| S19-L1560 | 8 | M7-GATE | Pending | [L1560](MASTER_SPEC.md#L1560) 19.5 Blender Deliverables / For generated assets, preserve / Material documentation | Demonstrate or document 19.5 Blender Deliverables / Material documentation |
| S19-L1561 | 8 | M7-GATE | Pending | [L1561](MASTER_SPEC.md#L1561) 19.5 Blender Deliverables / For generated assets, preserve / Preview image | Demonstrate or document 19.5 Blender Deliverables / Preview image |
| S19-L1562 | 8 | M7-GATE | Pending | [L1562](MASTER_SPEC.md#L1562) 19.5 Blender Deliverables / For generated assets, preserve / License/provenance notes | Demonstrate or document 19.5 Blender Deliverables / License/provenance notes |

### 20. ENVIRONMENT AND IMMERSION

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S20-L1568 | 8 | M7-GATE | Pending | [L1568](MASTER_SPEC.md#L1568) Create a coherent theme park environment. | Verify Create a coherent theme park environment. |
| S20-L1572 | 8 | M7-GATE | Pending | [L1572](MASTER_SPEC.md#L1572) Initial Environment / Include: | Verify Initial Environment / Include: |
| S20-L1574 | 8 | M7-GATE | Pending | [L1574](MASTER_SPEC.md#L1574) Initial Environment / Include / Main entrance | Provide evidence for Initial Environment / Main entrance |
| S20-L1575 | 8 | M7-GATE | Pending | [L1575](MASTER_SPEC.md#L1575) Initial Environment / Include / Ticket booth | Provide evidence for Initial Environment / Ticket booth |
| S20-L1576 | 8 | M7-GATE | Pending | [L1576](MASTER_SPEC.md#L1576) Initial Environment / Include / Central plaza | Provide evidence for Initial Environment / Central plaza |
| S20-L1577 | 8 | M7-GATE | Pending | [L1577](MASTER_SPEC.md#L1577) Initial Environment / Include / Pedestrian paths | Provide evidence for Initial Environment / Pedestrian paths |
| S20-L1578 | 8 | M7-GATE | Pending | [L1578](MASTER_SPEC.md#L1578) Initial Environment / Include / Landscaping | Provide evidence for Initial Environment / Landscaping |
| S20-L1579 | 8 | M7-GATE | Pending | [L1579](MASTER_SPEC.md#L1579) Initial Environment / Include / Attraction plots | Provide evidence for Initial Environment / Attraction plots |
| S20-L1580 | 8 | M7-GATE | Pending | [L1580](MASTER_SPEC.md#L1580) Initial Environment / Include / Shops | Provide evidence for Initial Environment / Shops |
| S20-L1581 | 8 | M7-GATE | Pending | [L1581](MASTER_SPEC.md#L1581) Initial Environment / Include / Rest areas | Provide evidence for Initial Environment / Rest areas |
| S20-L1582 | 8 | M7-GATE | Pending | [L1582](MASTER_SPEC.md#L1582) Initial Environment / Include / Park boundary | Provide evidence for Initial Environment / Park boundary |
| S20-L1586 | 8 | M7-GATE | Pending | [L1586](MASTER_SPEC.md#L1586) Environmental Effects / Implement: | Verify Environmental Effects / Implement: |
| S20-L1588 | 8 | M7-GATE | Pending | [L1588](MASTER_SPEC.md#L1588) Environmental Effects / Implement / Ambient crowd sounds | Demonstrate or document Environmental Effects / Ambient crowd sounds |
| S20-L1589 | 8 | M7-GATE | Pending | [L1589](MASTER_SPEC.md#L1589) Environmental Effects / Implement / Ride mechanical audio | Demonstrate or document Environmental Effects / Ride mechanical audio |
| S20-L1590 | 8 | M7-GATE | Pending | [L1590](MASTER_SPEC.md#L1590) Environmental Effects / Implement / Attraction music | Demonstrate or document Environmental Effects / Attraction music |
| S20-L1591 | 8 | M7-GATE | Pending | [L1591](MASTER_SPEC.md#L1591) Environmental Effects / Implement / Footsteps | Demonstrate or document Environmental Effects / Footsteps |
| S20-L1592 | 8 | M7-GATE | Pending | [L1592](MASTER_SPEC.md#L1592) Environmental Effects / Implement / Shop sounds | Demonstrate or document Environmental Effects / Shop sounds |
| S20-L1593 | 8 | M7-GATE | Pending | [L1593](MASTER_SPEC.md#L1593) Environmental Effects / Implement / Staff interaction sounds | Demonstrate or document Environmental Effects / Staff interaction sounds |
| S20-L1594 | 8 | M7-GATE | Pending | [L1594](MASTER_SPEC.md#L1594) Environmental Effects / Implement / Spatial audio where beneficial | Demonstrate or document Environmental Effects / Spatial audio where beneficial |
| S20-L1598 | 8 | M7-GATE | Pending | [L1598](MASTER_SPEC.md#L1598) Day and Night / Implement a controllable day/night cycle. | Verify Day and Night / Implement a controllable day/night cycle. |
| S20-L1600 | 8 | M7-GATE | Pending | [L1600](MASTER_SPEC.md#L1600) Day and Night / For standalone Quest, prioritize efficient lighting. | Verify Day and Night / For standalone Quest, prioritize efficient lighting. |
| S20-L1602 | 8 | M7-GATE | Pending | [L1602](MASTER_SPEC.md#L1602) Day and Night / Use baked lighting and limited dynamic lighting. | Verify Day and Night / Use baked lighting and limited dynamic lighting. |
| S20-L1604 | 8 | M7-GATE | Pending | [L1604](MASTER_SPEC.md#L1604) Day and Night / Nighttime should look attractive without requiring expensive real-time shadows. | Verify Day and Night / Nighttime should look attractive without requiring expensive real-time shadows. |
| S20-L1608 | 10 | M9-GATE | Deferred | [L1608](MASTER_SPEC.md#L1608) Weather / Weather is a later milestone. | Verify Weather / Weather is a later milestone. |
| S20-L1610 | 8 | M7-GATE | Pending | [L1610](MASTER_SPEC.md#L1610) Weather / Possible conditions: | Verify Weather / Possible conditions: |
| S20-L1612 | 10 | M9-GATE | Deferred | [L1612](MASTER_SPEC.md#L1612) Weather / Possible conditions / Sunny | Demonstrate or document Weather / Sunny |
| S20-L1613 | 10 | M9-GATE | Deferred | [L1613](MASTER_SPEC.md#L1613) Weather / Possible conditions / Cloudy | Demonstrate or document Weather / Cloudy |
| S20-L1614 | 10 | M9-GATE | Deferred | [L1614](MASTER_SPEC.md#L1614) Weather / Possible conditions / Light rain | Demonstrate or document Weather / Light rain |
| S20-L1616 | 8 | M7-GATE | Pending | [L1616](MASTER_SPEC.md#L1616) Weather / Weather may affect visitor demand and attraction operations. | Verify Weather / Weather may affect visitor demand and attraction operations. |
| S20-L1618 | 8 | M7-GATE | Pending | [L1618](MASTER_SPEC.md#L1618) Weather / Do not prioritize weather over core gameplay. | Verify Weather / Do not prioritize weather over core gameplay. |

### 21. MULTIPLAYER-READY DESIGN

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S21-L1624 | 1 | M0-GATE | Pending | [L1624](MASTER_SPEC.md#L1624) The first release is offline single-player. | Verify The first release is offline single-player. |
| S21-L1626 | 1 | M0-GATE | Pending | [L1626](MASTER_SPEC.md#L1626) Do not introduce networking dependencies into the initial playable build. | Verify Do not introduce networking dependencies into the initial playable build. |
| S21-L1628 | 1 | M0-GATE | Pending | [L1628](MASTER_SPEC.md#L1628) However, prepare the architecture for future multiplayer. | Verify However, prepare the architecture for future multiplayer. |
| S21-L1630 | 1 | M0-GATE | Pending | [L1630](MASTER_SPEC.md#L1630) Separate: | Verify Separate: |
| S21-L1632 | 1 | M0-GATE | Pending | [L1632](MASTER_SPEC.md#L1632) Separate / Park authoritative state | Demonstrate or document Park authoritative state |
| S21-L1633 | 1 | M0-GATE | Pending | [L1633](MASTER_SPEC.md#L1633) Separate / Visitor simulation | Demonstrate or document Visitor simulation |
| S21-L1634 | 1 | M0-GATE | Pending | [L1634](MASTER_SPEC.md#L1634) Separate / Player representation | Demonstrate or document Player representation |
| S21-L1635 | 1 | M0-GATE | Pending | [L1635](MASTER_SPEC.md#L1635) Separate / Player interaction | Demonstrate or document Player interaction |
| S21-L1636 | 1 | M0-GATE | Pending | [L1636](MASTER_SPEC.md#L1636) Separate / Ownership permissions | Demonstrate or document Ownership permissions |
| S21-L1637 | 1 | M0-GATE | Pending | [L1637](MASTER_SPEC.md#L1637) Separate / Persistent data | Demonstrate or document Persistent data |
| S21-L1639 | 10 | M9-GATE | Deferred | [L1639](MASTER_SPEC.md#L1639) Potential future multiplayer features: | Verify Potential future multiplayer features: |
| S21-L1641 | 10 | M9-GATE | Deferred | [L1641](MASTER_SPEC.md#L1641) Potential future multiplayer features / Visit another player's park | Demonstrate or document Visit another player's park |
| S21-L1642 | 10 | M9-GATE | Deferred | [L1642](MASTER_SPEC.md#L1642) Potential future multiplayer features / Ride attractions together | Demonstrate or document Ride attractions together |
| S21-L1643 | 10 | M9-GATE | Deferred | [L1643](MASTER_SPEC.md#L1643) Potential future multiplayer features / Social exploration | Demonstrate or document Social exploration |
| S21-L1644 | 10 | M9-GATE | Deferred | [L1644](MASTER_SPEC.md#L1644) Potential future multiplayer features / Cooperative park management | Demonstrate or document Cooperative park management |
| S21-L1645 | 10 | M9-GATE | Deferred | [L1645](MASTER_SPEC.md#L1645) Potential future multiplayer features / Shared park events | Demonstrate or document Shared park events |
| S21-L1647 | 10 | M9-GATE | Deferred | [L1647](MASTER_SPEC.md#L1647) Real players should not automatically use the same economic model as simulated visitors. | Verify Real players should not automatically use the same economic model as simulated visitors. |
| S21-L1649 | 10 | M9-GATE | Deferred | [L1649](MASTER_SPEC.md#L1649) Future multiplayer must explicitly define ownership, permissions, and transaction authority. | Verify Future multiplayer must explicitly define ownership, permissions, and transaction authority. |
| S21-L1651 | 10 | M9-GATE | Deferred | [L1651](MASTER_SPEC.md#L1651) Do not implement Photon, Netcode, or networking infrastructure until the offline vertical slice is stable. | Verify Do not implement Photon, Netcode, or networking infrastructure until the offline vertical slice is stable. |

### 22. PERFORMANCE OPTIMIZATION

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S22-L1657 | 9 | M8-GATE | Pending | [L1657](MASTER_SPEC.md#L1657) The game must be designed for standalone Meta Quest from the beginning. | Verify The game must be designed for standalone Meta Quest from the beginning. |
| S22-L1661 | 9 | M8-GATE | Pending | [L1661](MASTER_SPEC.md#L1661) 22.1 Performance Targets / Primary baseline: | Verify 22.1 Performance Targets / Primary baseline: |
| S22-L1663 | 9 | M8-GATE | Pending | [L1663](MASTER_SPEC.md#L1663) 22.1 Performance Targets / Primary baseline / 72 Hz | Demonstrate or document 22.1 Performance Targets / 72 Hz |
| S22-L1664 | 9 | M8-GATE | Pending | [L1664](MASTER_SPEC.md#L1664) 22.1 Performance Targets / Primary baseline / Approximately 13.9 ms frame budget | Demonstrate or document 22.1 Performance Targets / Approximately 13.9 ms frame budget |
| S22-L1665 | 9 | M8-GATE | Pending | [L1665](MASTER_SPEC.md#L1665) 22.1 Performance Targets / Primary baseline / Stable stereo rendering | Demonstrate or document 22.1 Performance Targets / Stable stereo rendering |
| S22-L1666 | 9 | M8-GATE | Pending | [L1666](MASTER_SPEC.md#L1666) 22.1 Performance Targets / Primary baseline / No persistent frame drops during ordinary park operation | Demonstrate or document 22.1 Performance Targets / No persistent frame drops during ordinary park operation |
| S22-L1668 | 9 | M8-GATE | Conditional | [L1668](MASTER_SPEC.md#L1668) 22.1 Performance Targets / 90 Hz is a stretch goal for capable devices and reduced-complexity scenes. | Verify 22.1 Performance Targets / 90 Hz is a stretch goal for capable devices and reduced-complexity scenes. |
| S22-L1670 | 9 | M8-GATE | Pending | [L1670](MASTER_SPEC.md#L1670) 22.1 Performance Targets / Performance must be verified on actual hardware. | Verify 22.1 Performance Targets / Performance must be verified on actual hardware. |
| S22-L1674 | 9 | M8-GATE | Pending | [L1674](MASTER_SPEC.md#L1674) 22.2 Rendering / Use: | Verify 22.2 Rendering / Use: |
| S22-L1676 | 9 | M8-GATE | Pending | [L1676](MASTER_SPEC.md#L1676) 22.2 Rendering / Use / URP | Demonstrate or document 22.2 Rendering / URP |
| S22-L1677 | 9 | M8-GATE | Pending | [L1677](MASTER_SPEC.md#L1677) 22.2 Rendering / Use / OpenXR-compatible rendering | Demonstrate or document 22.2 Rendering / OpenXR-compatible rendering |
| S22-L1678 | 9 | M8-GATE | Pending | [L1678](MASTER_SPEC.md#L1678) 22.2 Rendering / Use / Single-pass instanced or multiview stereo as supported by the selected configuration | Demonstrate or document 22.2 Rendering / Single-pass instanced or multiview stereo as supported by the selected configuration |
| S22-L1679 | 9 | M8-GATE | Pending | [L1679](MASTER_SPEC.md#L1679) 22.2 Rendering / Use / GPU instancing | Demonstrate or document 22.2 Rendering / GPU instancing |
| S22-L1680 | 9 | M8-GATE | Pending | [L1680](MASTER_SPEC.md#L1680) 22.2 Rendering / Use / Static batching where appropriate | Demonstrate or document 22.2 Rendering / Static batching where appropriate |
| S22-L1681 | 9 | M8-GATE | Pending | [L1681](MASTER_SPEC.md#L1681) 22.2 Rendering / Use / Occlusion culling where effective | Demonstrate or document 22.2 Rendering / Occlusion culling where effective |
| S22-L1682 | 9 | M8-GATE | Pending | [L1682](MASTER_SPEC.md#L1682) 22.2 Rendering / Use / LOD groups | Demonstrate or document 22.2 Rendering / LOD groups |
| S22-L1683 | 9 | M8-GATE | Pending | [L1683](MASTER_SPEC.md#L1683) 22.2 Rendering / Use / Baked lighting | Demonstrate or document 22.2 Rendering / Baked lighting |
| S22-L1684 | 9 | M8-GATE | Pending | [L1684](MASTER_SPEC.md#L1684) 22.2 Rendering / Use / Efficient shaders | Demonstrate or document 22.2 Rendering / Efficient shaders |
| S22-L1685 | 9 | M8-GATE | Pending | [L1685](MASTER_SPEC.md#L1685) 22.2 Rendering / Use / Texture compression suitable for Quest | Demonstrate or document 22.2 Rendering / Texture compression suitable for Quest |
| S22-L1686 | 9 | M8-GATE | Pending | [L1686](MASTER_SPEC.md#L1686) 22.2 Rendering / Use / Conservative shadow settings | Demonstrate or document 22.2 Rendering / Conservative shadow settings |
| S22-L1688 | 9 | M8-GATE | Pending | [L1688](MASTER_SPEC.md#L1688) 22.2 Rendering / Avoid: | Verify 22.2 Rendering / Avoid: |
| S22-L1690 | 9 | M8-GATE | Pending | [L1690](MASTER_SPEC.md#L1690) 22.2 Rendering / Avoid / Expensive post-processing | Show the shipped configuration/behavior avoids 22.2 Rendering / Expensive post-processing |
| S22-L1691 | 9 | M8-GATE | Pending | [L1691](MASTER_SPEC.md#L1691) 22.2 Rendering / Avoid / Unnecessary transparent surfaces | Show the shipped configuration/behavior avoids 22.2 Rendering / Unnecessary transparent surfaces |
| S22-L1692 | 9 | M8-GATE | Pending | [L1692](MASTER_SPEC.md#L1692) 22.2 Rendering / Avoid / Excessive real-time lights | Show the shipped configuration/behavior avoids 22.2 Rendering / Excessive real-time lights |
| S22-L1693 | 9 | M8-GATE | Pending | [L1693](MASTER_SPEC.md#L1693) 22.2 Rendering / Avoid / Expensive screen-space effects | Show the shipped configuration/behavior avoids 22.2 Rendering / Expensive screen-space effects |
| S22-L1694 | 9 | M8-GATE | Pending | [L1694](MASTER_SPEC.md#L1694) 22.2 Rendering / Avoid / High overdraw | Show the shipped configuration/behavior avoids 22.2 Rendering / High overdraw |
| S22-L1695 | 9 | M8-GATE | Pending | [L1695](MASTER_SPEC.md#L1695) 22.2 Rendering / Avoid / Large numbers of skinned meshes | Show the shipped configuration/behavior avoids 22.2 Rendering / Large numbers of skinned meshes |
| S22-L1696 | 9 | M8-GATE | Pending | [L1696](MASTER_SPEC.md#L1696) 22.2 Rendering / Avoid / Heavy particle systems | Show the shipped configuration/behavior avoids 22.2 Rendering / Heavy particle systems |
| S22-L1700 | 9 | M8-GATE | Pending | [L1700](MASTER_SPEC.md#L1700) 22.3 Visitor Optimization / Use multiple levels of simulation fidelity. | Verify 22.3 Visitor Optimization / Use multiple levels of simulation fidelity. |
| S22-L1704 | 9 | M8-GATE | Pending | [L1704](MASTER_SPEC.md#L1704) Near Visitors / Full character rendering | Demonstrate or document Near Visitors / Full character rendering |
| S22-L1705 | 9 | M8-GATE | Pending | [L1705](MASTER_SPEC.md#L1705) Near Visitors / Animation | Demonstrate or document Near Visitors / Animation |
| S22-L1706 | 9 | M8-GATE | Pending | [L1706](MASTER_SPEC.md#L1706) Near Visitors / Local avoidance | Demonstrate or document Near Visitors / Local avoidance |
| S22-L1707 | 9 | M8-GATE | Pending | [L1707](MASTER_SPEC.md#L1707) Near Visitors / Interactive inspection | Demonstrate or document Near Visitors / Interactive inspection |
| S22-L1711 | 9 | M8-GATE | Pending | [L1711](MASTER_SPEC.md#L1711) Medium-Distance Visitors / Simplified animation | Demonstrate or document Medium-Distance Visitors / Simplified animation |
| S22-L1712 | 9 | M8-GATE | Pending | [L1712](MASTER_SPEC.md#L1712) Medium-Distance Visitors / Reduced decision frequency | Demonstrate or document Medium-Distance Visitors / Reduced decision frequency |
| S22-L1713 | 9 | M8-GATE | Pending | [L1713](MASTER_SPEC.md#L1713) Medium-Distance Visitors / Lower-detail meshes | Demonstrate or document Medium-Distance Visitors / Lower-detail meshes |
| S22-L1717 | 9 | M8-GATE | Pending | [L1717](MASTER_SPEC.md#L1717) Distant Visitors / Aggregated or lightweight simulation | Demonstrate or document Distant Visitors / Aggregated or lightweight simulation |
| S22-L1718 | 9 | M8-GATE | Pending | [L1718](MASTER_SPEC.md#L1718) Distant Visitors / Reduced rendering | Demonstrate or document Distant Visitors / Reduced rendering |
| S22-L1719 | 9 | M8-GATE | Pending | [L1719](MASTER_SPEC.md#L1719) Distant Visitors / Simplified movement | Demonstrate or document Distant Visitors / Simplified movement |
| S22-L1721 | 9 | M8-GATE | Pending | [L1721](MASTER_SPEC.md#L1721) Distant Visitors / Use object pooling. | Verify Distant Visitors / Use object pooling. |
| S22-L1723 | 9 | M8-GATE | Pending | [L1723](MASTER_SPEC.md#L1723) Distant Visitors / Use spatial partitioning. | Verify Distant Visitors / Use spatial partitioning. |
| S22-L1725 | 9 | M8-GATE | Pending | [L1725](MASTER_SPEC.md#L1725) Distant Visitors / Avoid per-frame allocations. | Verify Distant Visitors / Avoid per-frame allocations. |
| S22-L1729 | 9 | M8-GATE | Pending | [L1729](MASTER_SPEC.md#L1729) 22.4 Simulation Scheduling / Different systems should update at appropriate intervals. | Verify 22.4 Simulation Scheduling / Different systems should update at appropriate intervals. |
| S22-L1731 | 9 | M8-GATE | Conditional | [L1731](MASTER_SPEC.md#L1731) 22.4 Simulation Scheduling / Examples: | Verify 22.4 Simulation Scheduling / Examples: |
| S22-L1733 | 9 | M8-GATE | Pending | [L1733](MASTER_SPEC.md#L1733) 22.4 Simulation Scheduling / Examples / Immediate interaction: event-driven | Demonstrate or document 22.4 Simulation Scheduling / Immediate interaction: event-driven |
| S22-L1734 | 9 | M8-GATE | Pending | [L1734](MASTER_SPEC.md#L1734) 22.4 Simulation Scheduling / Examples / Movement: frame-based or appropriate fixed-step updates | Demonstrate or document 22.4 Simulation Scheduling / Movement: frame-based or appropriate fixed-step updates |
| S22-L1735 | 9 | M8-GATE | Pending | [L1735](MASTER_SPEC.md#L1735) 22.4 Simulation Scheduling / Examples / Guest decisions: scheduled intervals | Demonstrate or document 22.4 Simulation Scheduling / Guest decisions: scheduled intervals |
| S22-L1736 | 9 | M8-GATE | Pending | [L1736](MASTER_SPEC.md#L1736) 22.4 Simulation Scheduling / Examples / Economy: simulation ticks | Demonstrate or document 22.4 Simulation Scheduling / Economy: simulation ticks |
| S22-L1737 | 9 | M8-GATE | Pending | [L1737](MASTER_SPEC.md#L1737) 22.4 Simulation Scheduling / Examples / Staff task allocation: periodic | Demonstrate or document 22.4 Simulation Scheduling / Staff task allocation: periodic |
| S22-L1738 | 9 | M8-GATE | Pending | [L1738](MASTER_SPEC.md#L1738) 22.4 Simulation Scheduling / Examples / Demand aggregation: periodic | Demonstrate or document 22.4 Simulation Scheduling / Demand aggregation: periodic |
| S22-L1739 | 9 | M8-GATE | Pending | [L1739](MASTER_SPEC.md#L1739) 22.4 Simulation Scheduling / Examples / Reputation: periodic | Demonstrate or document 22.4 Simulation Scheduling / Reputation: periodic |
| S22-L1741 | 9 | M8-GATE | Pending | [L1741](MASTER_SPEC.md#L1741) 22.4 Simulation Scheduling / Keep simulation time separate from real-world frame timing. | Verify 22.4 Simulation Scheduling / Keep simulation time separate from real-world frame timing. |
| S22-L1745 | 9 | M8-GATE | Pending | [L1745](MASTER_SPEC.md#L1745) 22.5 Performance Budgets / Establish initial budgets for: | Verify 22.5 Performance Budgets / Establish initial budgets for: |
| S22-L1747 | 9 | M8-GATE | Pending | [L1747](MASTER_SPEC.md#L1747) 22.5 Performance Budgets / Establish initial budgets for / Draw calls | Demonstrate or document 22.5 Performance Budgets / Draw calls |
| S22-L1748 | 9 | M8-GATE | Pending | [L1748](MASTER_SPEC.md#L1748) 22.5 Performance Budgets / Establish initial budgets for / Rendered triangles | Demonstrate or document 22.5 Performance Budgets / Rendered triangles |
| S22-L1749 | 9 | M8-GATE | Pending | [L1749](MASTER_SPEC.md#L1749) 22.5 Performance Budgets / Establish initial budgets for / Skinned meshes | Demonstrate or document 22.5 Performance Budgets / Skinned meshes |
| S22-L1750 | 9 | M8-GATE | Pending | [L1750](MASTER_SPEC.md#L1750) 22.5 Performance Budgets / Establish initial budgets for / Visible guests | Demonstrate or document 22.5 Performance Budgets / Visible guests |
| S22-L1751 | 9 | M8-GATE | Pending | [L1751](MASTER_SPEC.md#L1751) 22.5 Performance Budgets / Establish initial budgets for / CPU frame time | Demonstrate or document 22.5 Performance Budgets / CPU frame time |
| S22-L1752 | 9 | M8-GATE | Pending | [L1752](MASTER_SPEC.md#L1752) 22.5 Performance Budgets / Establish initial budgets for / GPU frame time | Demonstrate or document 22.5 Performance Budgets / GPU frame time |
| S22-L1753 | 9 | M8-GATE | Pending | [L1753](MASTER_SPEC.md#L1753) 22.5 Performance Budgets / Establish initial budgets for / Memory | Demonstrate or document 22.5 Performance Budgets / Memory |
| S22-L1754 | 9 | M8-GATE | Pending | [L1754](MASTER_SPEC.md#L1754) 22.5 Performance Budgets / Establish initial budgets for / Garbage collection | Demonstrate or document 22.5 Performance Budgets / Garbage collection |
| S22-L1755 | 9 | M8-GATE | Pending | [L1755](MASTER_SPEC.md#L1755) 22.5 Performance Budgets / Establish initial budgets for / Audio voices | Demonstrate or document 22.5 Performance Budgets / Audio voices |
| S22-L1756 | 9 | M8-GATE | Pending | [L1756](MASTER_SPEC.md#L1756) 22.5 Performance Budgets / Establish initial budgets for / Texture usage | Demonstrate or document 22.5 Performance Budgets / Texture usage |
| S22-L1758 | 9 | M8-GATE | Pending | [L1758](MASTER_SPEC.md#L1758) 22.5 Performance Budgets / These budgets must be measured and revised using device profiling rather than treated as universal hardware guarantees. | Verify 22.5 Performance Budgets / These budgets must be measured and revised using device profiling rather than treated as universal hardware guarantees. |
| S22-L1762 | 9 | M8-GATE | Pending | [L1762](MASTER_SPEC.md#L1762) 22.6 Profiling / Use: | Verify 22.6 Profiling / Use: |
| S22-L1764 | 9 | M8-GATE | Pending | [L1764](MASTER_SPEC.md#L1764) 22.6 Profiling / Use / Unity Profiler | Demonstrate or document 22.6 Profiling / Unity Profiler |
| S22-L1765 | 9 | M8-GATE | Pending | [L1765](MASTER_SPEC.md#L1765) 22.6 Profiling / Use / Unity Frame Debugger | Demonstrate or document 22.6 Profiling / Unity Frame Debugger |
| S22-L1766 | 9 | M8-GATE | Pending | [L1766](MASTER_SPEC.md#L1766) 22.6 Profiling / Use / Memory Profiler | Demonstrate or document 22.6 Profiling / Memory Profiler |
| S22-L1767 | 9 | M8-GATE | Pending | [L1767](MASTER_SPEC.md#L1767) 22.6 Profiling / Use / Android logcat | Demonstrate or document 22.6 Profiling / Android logcat |
| S22-L1768 | 9 | M8-GATE | Pending | [L1768](MASTER_SPEC.md#L1768) 22.6 Profiling / Use / Meta Quest performance tools where available | Demonstrate or document 22.6 Profiling / Meta Quest performance tools where available |
| S22-L1770 | 9 | M8-GATE | Pending | [L1770](MASTER_SPEC.md#L1770) 22.6 Profiling / Record results from representative park scenes. | Verify 22.6 Profiling / Record results from representative park scenes. |
| S22-L1772 | 9 | M8-GATE | Pending | [L1772](MASTER_SPEC.md#L1772) 22.6 Profiling / Test low, medium, and high visitor populations. | Verify 22.6 Profiling / Test low, medium, and high visitor populations. |
| S22-L1774 | 9 | M8-GATE | Pending | [L1774](MASTER_SPEC.md#L1774) 22.6 Profiling / Do not claim performance targets are met based only on editor testing. | Verify 22.6 Profiling / Do not claim performance targets are met based only on editor testing. |

### 23. SAVE AND LOAD

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S23-L1780 | 2 | M1-GATE | Pending | [L1780](MASTER_SPEC.md#L1780) Implement persistent park saves. | Verify Implement persistent park saves. |
| S23-L1782 | 2 | M1-GATE | Pending | [L1782](MASTER_SPEC.md#L1782) Requirements: | Verify Requirements: |
| S23-L1784 | 10 | M9-GATE | Pending | [L1784](MASTER_SPEC.md#L1784) Requirements / New game | Demonstrate or document New game |
| S23-L1785 | 10 | M9-GATE | Pending | [L1785](MASTER_SPEC.md#L1785) Requirements / Continue game | Demonstrate or document Continue game |
| S23-L1786 | 2 | M1-GATE | Pending | [L1786](MASTER_SPEC.md#L1786) Requirements / Manual save | Demonstrate or document Manual save |
| S23-L1787 | 2 | M1-GATE | Pending | [L1787](MASTER_SPEC.md#L1787) Requirements / Autosave | Demonstrate or document Autosave |
| S23-L1788 | 10 | M9-GATE | Conditional | [L1788](MASTER_SPEC.md#L1788) Requirements / Multiple save slots where practical | Demonstrate or document Multiple save slots where practical |
| S23-L1789 | 2 | M1-GATE | Pending | [L1789](MASTER_SPEC.md#L1789) Requirements / Save versioning | Demonstrate or document Save versioning |
| S23-L1790 | 2 | M1-GATE | Pending | [L1790](MASTER_SPEC.md#L1790) Requirements / Corruption detection | Demonstrate or document Corruption detection |
| S23-L1791 | 2 | M1-GATE | Pending | [L1791](MASTER_SPEC.md#L1791) Requirements / Backup recovery | Demonstrate or document Backup recovery |
| S23-L1792 | 10 | M9-GATE | Pending | [L1792](MASTER_SPEC.md#L1792) Requirements / Player preferences | Demonstrate or document Player preferences |
| S23-L1794 | 2 | M1-GATE | Pending | [L1794](MASTER_SPEC.md#L1794) Persist: | Verify Persist: |
| S23-L1796 | 2 | M1-GATE | Pending | [L1796](MASTER_SPEC.md#L1796) Persist / Building positions and rotations | Demonstrate or document Building positions and rotations |
| S23-L1797 | 2 | M1-GATE | Pending | [L1797](MASTER_SPEC.md#L1797) Persist / Attraction states | Demonstrate or document Attraction states |
| S23-L1798 | 2 | M1-GATE | Pending | [L1798](MASTER_SPEC.md#L1798) Persist / Shop states | Demonstrate or document Shop states |
| S23-L1799 | 2 | M1-GATE | Pending | [L1799](MASTER_SPEC.md#L1799) Persist / Paths | Demonstrate or document Paths |
| S23-L1800 | 2 | M1-GATE | Pending | [L1800](MASTER_SPEC.md#L1800) Persist / Staff | Demonstrate or document Staff |
| S23-L1801 | 2 | M1-GATE | Pending | [L1801](MASTER_SPEC.md#L1801) Persist / Economy | Demonstrate or document Economy |
| S23-L1802 | 2 | M1-GATE | Pending | [L1802](MASTER_SPEC.md#L1802) Persist / Reputation | Demonstrate or document Reputation |
| S23-L1803 | 2 | M1-GATE | Pending | [L1803](MASTER_SPEC.md#L1803) Persist / Unlocks | Demonstrate or document Unlocks |
| S23-L1804 | 2 | M1-GATE | Pending | [L1804](MASTER_SPEC.md#L1804) Persist / Mission progress | Demonstrate or document Mission progress |
| S23-L1805 | 2 | M1-GATE | Pending | [L1805](MASTER_SPEC.md#L1805) Persist / Time | Demonstrate or document Time |
| S23-L1806 | 2 | M1-GATE | Pending | [L1806](MASTER_SPEC.md#L1806) Persist / Park settings | Demonstrate or document Park settings |
| S23-L1808 | 2 | M1-GATE | Pending | [L1808](MASTER_SPEC.md#L1808) Validate save/load with automated round-trip tests. | Verify Validate save/load with automated round-trip tests. |

### 24. AUDIO DESIGN

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S24-L1814 | 8 | M7-GATE | Pending | [L1814](MASTER_SPEC.md#L1814) Create a coherent audio experience. | Verify Create a coherent audio experience. |
| S24-L1816 | 8 | M7-GATE | Pending | [L1816](MASTER_SPEC.md#L1816) Audio categories: | Verify Audio categories: |
| S24-L1818 | 8 | M7-GATE | Pending | [L1818](MASTER_SPEC.md#L1818) Audio categories / Ambient park sounds | Demonstrate or document Ambient park sounds |
| S24-L1819 | 8 | M7-GATE | Pending | [L1819](MASTER_SPEC.md#L1819) Audio categories / Visitor reactions | Demonstrate or document Visitor reactions |
| S24-L1820 | 8 | M7-GATE | Pending | [L1820](MASTER_SPEC.md#L1820) Audio categories / Ride sounds | Demonstrate or document Ride sounds |
| S24-L1821 | 8 | M7-GATE | Pending | [L1821](MASTER_SPEC.md#L1821) Audio categories / Mechanical sounds | Demonstrate or document Mechanical sounds |
| S24-L1822 | 8 | M7-GATE | Pending | [L1822](MASTER_SPEC.md#L1822) Audio categories / UI feedback | Demonstrate or document UI feedback |
| S24-L1823 | 8 | M7-GATE | Pending | [L1823](MASTER_SPEC.md#L1823) Audio categories / Construction sounds | Demonstrate or document Construction sounds |
| S24-L1824 | 8 | M7-GATE | Pending | [L1824](MASTER_SPEC.md#L1824) Audio categories / Cleaning sounds | Demonstrate or document Cleaning sounds |
| S24-L1825 | 8 | M7-GATE | Pending | [L1825](MASTER_SPEC.md#L1825) Audio categories / Repair sounds | Demonstrate or document Repair sounds |
| S24-L1826 | 8 | M7-GATE | Pending | [L1826](MASTER_SPEC.md#L1826) Audio categories / Music | Demonstrate or document Music |
| S24-L1827 | 8 | M7-GATE | Pending | [L1827](MASTER_SPEC.md#L1827) Audio categories / Mission completion | Demonstrate or document Mission completion |
| S24-L1829 | 8 | M7-GATE | Pending | [L1829](MASTER_SPEC.md#L1829) Use spatial audio selectively. | Verify Use spatial audio selectively. |
| S24-L1831 | 8 | M7-GATE | Pending | [L1831](MASTER_SPEC.md#L1831) Avoid excessive simultaneous audio sources. | Verify Avoid excessive simultaneous audio sources. |
| S24-L1833 | 8 | M7-GATE | Pending | [L1833](MASTER_SPEC.md#L1833) Create an audio mixer with adjustable categories. | Verify Create an audio mixer with adjustable categories. |
| S24-L1835 | 8 | M7-GATE | Pending | [L1835](MASTER_SPEC.md#L1835) Implement volume settings. | Verify Implement volume settings. |
| S24-L1837 | 8 | M7-GATE | Pending | [L1837](MASTER_SPEC.md#L1837) Do not use copyrighted music without appropriate rights. | Verify Do not use copyrighted music without appropriate rights. |
| S24-L1839 | 8 | M7-GATE | Pending | [L1839](MASTER_SPEC.md#L1839) If audio generation tools are unavailable, use original synthesized sounds or properly licensed audio and document their source. | Verify If audio generation tools are unavailable, use original synthesized sounds or properly licensed audio and document their source. |

### 25. DEVELOPMENT MILESTONES

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S25-L1845 | 0 | â€” | Active | [L1845](MASTER_SPEC.md#L1845) Implement in the following order. | Verify Implement in the following order. |
| S25-L1849 | 0 | M0-GATE | Verified | [L1849](MASTER_SPEC.md#L1849) MILESTONE 0 â€” Project Audit / Deliver: | Verify MILESTONE 0 â€” Project Audit / Deliver: |
| S25-L1851 | 0 | M0-GATE | Verified | [L1851](MASTER_SPEC.md#L1851) MILESTONE 0 â€” Project Audit / Deliver / Environment report | [Environment report](../Documentation/EnvironmentReport.md) records the installed tools, Unity project structure, storage and ADB failure. |
| S25-L1852 | 0 | M0-GATE | Verified | [L1852](MASTER_SPEC.md#L1852) MILESTONE 0 â€” Project Audit / Deliver / Asset inventory | [Asset inventory](../Documentation/AssetInventory.csv) contains 11,653 records. Every recorded source path existed at recheck. |
| S25-L1853 | 0 | M0-GATE | Verified | [L1853](MASTER_SPEC.md#L1853) MILESTONE 0 â€” Project Audit / Deliver / Reuse decisions | [Asset audit](../Documentation/AssetAudit.md) records 120 conditional candidates, 11,526 reference-only assets, 7 replacements and zero approved direct imports. |
| S25-L1854 | 0 | M0-GATE | Verified | [L1854](MASTER_SPEC.md#L1854) MILESTONE 0 â€” Project Audit / Deliver / Migration plan | [Migration plan](../Documentation/MigrationPlan.md) maps mobile systems to VR decisions and identifies the independent project root. |
| S25-L1855 | 0 | M0-GATE | Verified | [L1855](MASTER_SPEC.md#L1855) MILESTONE 0 â€” Project Audit / Deliver / Technical risks | [Migration plan](../Documentation/MigrationPlan.md) and [environment report](../Documentation/EnvironmentReport.md) record reuse, dependency, Android build and ADB risks. |
| S25-L1857 | 0 | M0-GATE | Verified | [L1857](MASTER_SPEC.md#L1857) MILESTONE 0 â€” Project Audit / Acceptance: | See M0-GATE and the three acceptance rows below. |
| S25-L1859 | 0 | M0-GATE | Verified | [L1859](MASTER_SPEC.md#L1859) MILESTONE 0 â€” Project Audit / Acceptance / Original mobile project untouched | [Asset audit](../Documentation/AssetAudit.md) records matching pre- and post-inventory metadata snapshots. The recheck used read-only source operations. |
| S25-L1860 | 0 | M0-GATE | Verified | [L1860](MASTER_SPEC.md#L1860) MILESTONE 0 â€” Project Audit / Acceptance / All reused assets documented | Zero imports in Milestone 0. Record source, destination, rights and conversion details before any later import. |
| S25-L1861 | 0 | M0-GATE | Verified | [L1861](MASTER_SPEC.md#L1861) MILESTONE 0 â€” Project Audit / Acceptance / New project path established | Independent root is E:/Projects/Personals/VR Park. The documentation write and validation succeeded here. |
| S25-L1865 | 1 | M0-GATE | Pending | [L1865](MASTER_SPEC.md#L1865) MILESTONE 1 â€” VR Foundation / Implement: | Verify MILESTONE 1 â€” VR Foundation / Implement: |
| S25-L1867 | 1 | M0-GATE | Verified in Editor | [L1867](MASTER_SPEC.md#L1867) MILESTONE 1 â€” VR Foundation / Implement / Unity VR project | Unity imported the pinned packages and created the project assemblies. |
| S25-L1868 | 1 | S25-L1867 | Configured in Editor | [L1868](MASTER_SPEC.md#L1868) MILESTONE 1 â€” VR Foundation / Implement / OpenXR configuration | Generated Android OpenXR loader and Quest feature assets. Android validation and headset startup remain open. |
| S25-L1869 | 1 | S25-L1867 | Desktop verified | [L1869](MASTER_SPEC.md#L1869) MILESTONE 1 â€” VR Foundation / Implement / XR Origin | One XR Origin initialized in desktop Play Mode. Head and controller tracking require Quest. |
| S25-L1870 | 1 | S25-L1868, S25-L1869 | Source compiled | [L1870](MASTER_SPEC.md#L1870) MILESTONE 1 â€” VR Foundation / Implement / Controller input | Verify both Touch controller rays, triggers and thumbsticks on Quest. |
| S25-L1871 | 1 | S25-L1870 | Source compiled | [L1871](MASTER_SPEC.md#L1871) MILESTONE 1 â€” VR Foundation / Implement / Teleportation | Verify teleport lands on valid ground and rejects occupied areas and edges. Three managed boundary cases passed. |
| S25-L1872 | 1 | S25-L1870 | Source compiled | [L1872](MASTER_SPEC.md#L1872) MILESTONE 1 â€” VR Foundation / Implement / Snap turning | Two managed snap-input tests passed for release-to-rearm and filtering. Verify one 30-degree turn per stick deflection on Quest. |
| S25-L1873 | 1 | S25-L1869 | Source compiled | [L1873](MASTER_SPEC.md#L1873) MILESTONE 1 â€” VR Foundation / Implement / Seated/standing support | Verify device/floor tracking requests and usable seated/standing eye height. |
| S25-L1874 | 1 | S25-L1867 | Desktop verified | [L1874](MASTER_SPEC.md#L1874) MILESTONE 1 â€” VR Foundation / Implement / Basic park environment | Visitor park and URP materials rendered. Tabletop rendering remains to be verified. |
| S25-L1875 | 1 | S25-L1870, S25-L1874 | Source compiled | [L1875](MASTER_SPEC.md#L1875) MILESTONE 1 â€” VR Foundation / Implement / Architect Mode prototype | Verify miniature pan, yaw, scale and ground selection without moving the rig on entry. |
| S25-L1876 | 1 | S25-L1871, S25-L1872, S25-L1873, S25-L1874 | Source compiled | [L1876](MASTER_SPEC.md#L1876) MILESTONE 1 â€” VR Foundation / Implement / Visitor Mode prototype | Verify human-scale exploration and arrival from a selected miniature location. |
| S25-L1878 | 1 | M0-GATE | Pending | [L1878](MASTER_SPEC.md#L1878) MILESTONE 1 â€” VR Foundation / Acceptance: | Verify MILESTONE 1 â€” VR Foundation / Acceptance: |
| S25-L1880 | 1 | S25-L1867 | Verified in Editor | [L1880](MASTER_SPEC.md#L1880) MILESTONE 1 â€” VR Foundation / Acceptance / Project compiles | Unity 6000.3.7f1 compiled the project. EditMode Test Runner reported 7 passed and 0 failed. |
| S25-L1881 | 1 | S25-L1868, S25-L1869 | Blocked | [L1881](MASTER_SPEC.md#L1881) MILESTONE 1 â€” VR Foundation / Acceptance / XR rig initializes | Start a Quest build and verify OpenXR initialization, head pose and controller tracking. |
| S25-L1882 | 1 | S25-L1870, S25-L1871, S25-L1872, S25-L1873 | Blocked | [L1882](MASTER_SPEC.md#L1882) MILESTONE 1 â€” VR Foundation / Acceptance / VR interaction works | Exercise controller input, teleport, snap turn and posture on Quest. |
| S25-L1883 | 1 | S25-L1875, S25-L1876 | Partial verification | [L1883](MASTER_SPEC.md#L1883) MILESTONE 1 â€” VR Foundation / Acceptance / Mode switching works | Unity miniature-coordinate round-trip passed. The keyboard smoke attempt did not visibly switch modes. Full mode switching remains open. |
| S25-L1884 | 1 | S25-L1880, S25-L1881, S25-L1882, S25-L1883 | Partial verification | [L1884](MASTER_SPEC.md#L1884) MILESTONE 1 â€” VR Foundation / Acceptance / No critical runtime errors | Desktop scene startup showed zero Console errors. Review Quest player logs after the device smoke test. |
| S25-L1888 | 2 | M1-GATE | Pending | [L1888](MASTER_SPEC.md#L1888) MILESTONE 2 â€” Park Construction / Implement: | Verify MILESTONE 2 â€” Park Construction / Implement: |
| S25-L1890 | 2 | M1-GATE | Source implemented, verification deferred | [L1890](MASTER_SPEC.md#L1890) MILESTONE 2 â€” Park Construction / Implement / Construction catalog | Demonstrate or document MILESTONE 2 â€” Park Construction / Construction catalog |
| S25-L1891 | 2 | M1-GATE | Source implemented, verification deferred | [L1891](MASTER_SPEC.md#L1891) MILESTONE 2 â€” Park Construction / Implement / Building previews | Demonstrate or document MILESTONE 2 â€” Park Construction / Building previews |
| S25-L1892 | 2 | M1-GATE | Source implemented, verification deferred | [L1892](MASTER_SPEC.md#L1892) MILESTONE 2 â€” Park Construction / Implement / Placement validation | Demonstrate or document MILESTONE 2 â€” Park Construction / Placement validation |
| S25-L1893 | 2 | M1-GATE | Source implemented, verification deferred | [L1893](MASTER_SPEC.md#L1893) MILESTONE 2 â€” Park Construction / Implement / Building rotation | Demonstrate or document MILESTONE 2 â€” Park Construction / Building rotation |
| S25-L1894 | 2 | M1-GATE | Source implemented, verification deferred | [L1894](MASTER_SPEC.md#L1894) MILESTONE 2 â€” Park Construction / Implement / Placement confirmation | Demonstrate or document MILESTONE 2 â€” Park Construction / Placement confirmation |
| S25-L1895 | 2 | M1-GATE | Source implemented, verification deferred | [L1895](MASTER_SPEC.md#L1895) MILESTONE 2 â€” Park Construction / Implement / Path placement | Demonstrate or document MILESTONE 2 â€” Park Construction / Path placement |
| S25-L1896 | 2 | M1-GATE | Source implemented, verification deferred | [L1896](MASTER_SPEC.md#L1896) MILESTONE 2 â€” Park Construction / Implement / Building deletion | Demonstrate or document MILESTONE 2 â€” Park Construction / Building deletion |
| S25-L1897 | 2 | M1-GATE | Source implemented, verification deferred | [L1897](MASTER_SPEC.md#L1897) MILESTONE 2 â€” Park Construction / Implement / Basic save/load | Demonstrate or document MILESTONE 2 â€” Park Construction / Basic save/load |
| S25-L1899 | 2 | M1-GATE | Pending | [L1899](MASTER_SPEC.md#L1899) MILESTONE 2 â€” Park Construction / Acceptance: | Verify MILESTONE 2 â€” Park Construction / Acceptance: |
| S25-L1901 | 2 | M1-GATE | Verification deferred | [L1901](MASTER_SPEC.md#L1901) MILESTONE 2 â€” Park Construction / Acceptance / Player can build a connected park | Demonstrate MILESTONE 2 â€” Park Construction / Player can build a connected park |
| S25-L1902 | 2 | M1-GATE | Verification deferred | [L1902](MASTER_SPEC.md#L1902) MILESTONE 2 â€” Park Construction / Acceptance / Invalid placement is rejected | Demonstrate MILESTONE 2 â€” Park Construction / Invalid placement is rejected |
| S25-L1903 | 2 | M1-GATE | Verification deferred | [L1903](MASTER_SPEC.md#L1903) MILESTONE 2 â€” Park Construction / Acceptance / Costs are applied correctly | Demonstrate MILESTONE 2 â€” Park Construction / Costs are applied correctly |
| S25-L1904 | 2 | M1-GATE | Verification deferred | [L1904](MASTER_SPEC.md#L1904) MILESTONE 2 â€” Park Construction / Acceptance / Layout persists after loading | Demonstrate MILESTONE 2 â€” Park Construction / Layout persists after loading |
| S25-L1908 | 3 | M2-GATE | Pending | [L1908](MASTER_SPEC.md#L1908) MILESTONE 3 â€” Visitor Simulation / Implement: | Verify MILESTONE 3 â€” Visitor Simulation / Implement: |
| S25-L1910 | 3 | M2-GATE | Pending | [L1910](MASTER_SPEC.md#L1910) MILESTONE 3 â€” Visitor Simulation / Implement / Guest spawning | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Guest spawning |
| S25-L1911 | 3 | M2-GATE | Pending | [L1911](MASTER_SPEC.md#L1911) MILESTONE 3 â€” Visitor Simulation / Implement / Guest navigation | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Guest navigation |
| S25-L1912 | 3 | M2-GATE | Pending | [L1912](MASTER_SPEC.md#L1912) MILESTONE 3 â€” Visitor Simulation / Implement / Guest archetypes | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Guest archetypes |
| S25-L1913 | 3 | M2-GATE | Pending | [L1913](MASTER_SPEC.md#L1913) MILESTONE 3 â€” Visitor Simulation / Implement / Basic needs | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Basic needs |
| S25-L1914 | 3 | M2-GATE | Pending | [L1914](MASTER_SPEC.md#L1914) MILESTONE 3 â€” Visitor Simulation / Implement / Destination selection | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Destination selection |
| S25-L1915 | 3 | M2-GATE | Pending | [L1915](MASTER_SPEC.md#L1915) MILESTONE 3 â€” Visitor Simulation / Implement / Attraction demand | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Attraction demand |
| S25-L1916 | 3 | M2-GATE | Pending | [L1916](MASTER_SPEC.md#L1916) MILESTONE 3 â€” Visitor Simulation / Implement / Happiness | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Happiness |
| S25-L1917 | 3 | M2-GATE | Pending | [L1917](MASTER_SPEC.md#L1917) MILESTONE 3 â€” Visitor Simulation / Implement / Park entrance/exit | Demonstrate or document MILESTONE 3 â€” Visitor Simulation / Park entrance/exit |
| S25-L1919 | 3 | M2-GATE | Pending | [L1919](MASTER_SPEC.md#L1919) MILESTONE 3 â€” Visitor Simulation / Acceptance: | Verify MILESTONE 3 â€” Visitor Simulation / Acceptance: |
| S25-L1921 | 3 | M2-GATE | Pending | [L1921](MASTER_SPEC.md#L1921) MILESTONE 3 â€” Visitor Simulation / Acceptance / Guests navigate connected paths | Demonstrate MILESTONE 3 â€” Visitor Simulation / Guests navigate connected paths |
| S25-L1922 | 3 | M2-GATE | Pending | [L1922](MASTER_SPEC.md#L1922) MILESTONE 3 â€” Visitor Simulation / Acceptance / Guests respond to available facilities | Demonstrate MILESTONE 3 â€” Visitor Simulation / Guests respond to available facilities |
| S25-L1923 | 3 | M2-GATE | Pending | [L1923](MASTER_SPEC.md#L1923) MILESTONE 3 â€” Visitor Simulation / Acceptance / Guest decisions affect park metrics | Demonstrate MILESTONE 3 â€” Visitor Simulation / Guest decisions affect park metrics |
| S25-L1924 | 3 | M2-GATE | Pending | [L1924](MASTER_SPEC.md#L1924) MILESTONE 3 â€” Visitor Simulation / Acceptance / Simulation remains stable under repeated spawning | Demonstrate MILESTONE 3 â€” Visitor Simulation / Simulation remains stable under repeated spawning |
| S25-L1928 | 4 | M3-GATE | Pending | [L1928](MASTER_SPEC.md#L1928) MILESTONE 4 â€” Attraction Operations / Implement: | Verify MILESTONE 4 â€” Attraction Operations / Implement: |
| S25-L1930 | 4 | M3-GATE | Pending | [L1930](MASTER_SPEC.md#L1930) MILESTONE 4 â€” Attraction Operations / Implement / Carousel | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Carousel |
| S25-L1931 | 4 | M3-GATE | Pending | [L1931](MASTER_SPEC.md#L1931) MILESTONE 4 â€” Attraction Operations / Implement / Ferris wheel | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Ferris wheel |
| S25-L1932 | 4 | M3-GATE | Pending | [L1932](MASTER_SPEC.md#L1932) MILESTONE 4 â€” Attraction Operations / Implement / Roller coaster | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Roller coaster |
| S25-L1933 | 4 | M3-GATE | Pending | [L1933](MASTER_SPEC.md#L1933) MILESTONE 4 â€” Attraction Operations / Implement / Queue systems | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Queue systems |
| S25-L1934 | 4 | M3-GATE | Pending | [L1934](MASTER_SPEC.md#L1934) MILESTONE 4 â€” Attraction Operations / Implement / Ticket payments | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Ticket payments |
| S25-L1935 | 4 | M3-GATE | Pending | [L1935](MASTER_SPEC.md#L1935) MILESTONE 4 â€” Attraction Operations / Implement / Ride cycles | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Ride cycles |
| S25-L1936 | 4 | M3-GATE | Pending | [L1936](MASTER_SPEC.md#L1936) MILESTONE 4 â€” Attraction Operations / Implement / Player boarding | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Player boarding |
| S25-L1937 | 4 | M3-GATE | Pending | [L1937](MASTER_SPEC.md#L1937) MILESTONE 4 â€” Attraction Operations / Implement / Player ride experience | Demonstrate or document MILESTONE 4 â€” Attraction Operations / Player ride experience |
| S25-L1939 | 4 | M3-GATE | Pending | [L1939](MASTER_SPEC.md#L1939) MILESTONE 4 â€” Attraction Operations / Acceptance: | Verify MILESTONE 4 â€” Attraction Operations / Acceptance: |
| S25-L1941 | 4 | M3-GATE | Pending | [L1941](MASTER_SPEC.md#L1941) MILESTONE 4 â€” Attraction Operations / Acceptance / All three attractions operate | Demonstrate MILESTONE 4 â€” Attraction Operations / All three attractions operate |
| S25-L1942 | 4 | M3-GATE | Pending | [L1942](MASTER_SPEC.md#L1942) MILESTONE 4 â€” Attraction Operations / Acceptance / AI guests can use attractions | Demonstrate MILESTONE 4 â€” Attraction Operations / AI guests can use attractions |
| S25-L1943 | 4 | M3-GATE | Pending | [L1943](MASTER_SPEC.md#L1943) MILESTONE 4 â€” Attraction Operations / Acceptance / Revenue is recorded correctly | Demonstrate MILESTONE 4 â€” Attraction Operations / Revenue is recorded correctly |
| S25-L1944 | 4 | M3-GATE | Pending | [L1944](MASTER_SPEC.md#L1944) MILESTONE 4 â€” Attraction Operations / Acceptance / Player can experience all three in VR | Demonstrate MILESTONE 4 â€” Attraction Operations / Player can experience all three in VR |
| S25-L1945 | 4 | M3-GATE | Pending | [L1945](MASTER_SPEC.md#L1945) MILESTONE 4 â€” Attraction Operations / Acceptance / Boarding and exiting are reliable | Demonstrate MILESTONE 4 â€” Attraction Operations / Boarding and exiting are reliable |
| S25-L1949 | 5 | M4-GATE | Pending | [L1949](MASTER_SPEC.md#L1949) MILESTONE 5 â€” Staff and Maintenance / Implement: | Verify MILESTONE 5 â€” Staff and Maintenance / Implement: |
| S25-L1951 | 5 | M4-GATE | Pending | [L1951](MASTER_SPEC.md#L1951) MILESTONE 5 â€” Staff and Maintenance / Implement / Cleaner AI | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Cleaner AI |
| S25-L1952 | 5 | M4-GATE | Pending | [L1952](MASTER_SPEC.md#L1952) MILESTONE 5 â€” Staff and Maintenance / Implement / Mechanic AI | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Mechanic AI |
| S25-L1953 | 5 | M4-GATE | Pending | [L1953](MASTER_SPEC.md#L1953) MILESTONE 5 â€” Staff and Maintenance / Implement / Ride operators | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Ride operators |
| S25-L1954 | 5 | M4-GATE | Pending | [L1954](MASTER_SPEC.md#L1954) MILESTONE 5 â€” Staff and Maintenance / Implement / Litter | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Litter |
| S25-L1955 | 5 | M4-GATE | Pending | [L1955](MASTER_SPEC.md#L1955) MILESTONE 5 â€” Staff and Maintenance / Implement / Vomit | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Vomit |
| S25-L1956 | 5 | M4-GATE | Pending | [L1956](MASTER_SPEC.md#L1956) MILESTONE 5 â€” Staff and Maintenance / Implement / Trash bins | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Trash bins |
| S25-L1957 | 5 | M4-GATE | Pending | [L1957](MASTER_SPEC.md#L1957) MILESTONE 5 â€” Staff and Maintenance / Implement / Ride wear | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Ride wear |
| S25-L1958 | 5 | M4-GATE | Pending | [L1958](MASTER_SPEC.md#L1958) MILESTONE 5 â€” Staff and Maintenance / Implement / Repair tasks | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Repair tasks |
| S25-L1959 | 5 | M4-GATE | Pending | [L1959](MASTER_SPEC.md#L1959) MILESTONE 5 â€” Staff and Maintenance / Implement / Staff salaries | Demonstrate or document MILESTONE 5 â€” Staff and Maintenance / Staff salaries |
| S25-L1961 | 5 | M4-GATE | Pending | [L1961](MASTER_SPEC.md#L1961) MILESTONE 5 â€” Staff and Maintenance / Acceptance: | Verify MILESTONE 5 â€” Staff and Maintenance / Acceptance: |
| S25-L1963 | 5 | M4-GATE | Pending | [L1963](MASTER_SPEC.md#L1963) MILESTONE 5 â€” Staff and Maintenance / Acceptance / Waste is generated and cleaned | Demonstrate MILESTONE 5 â€” Staff and Maintenance / Waste is generated and cleaned |
| S25-L1964 | 5 | M4-GATE | Pending | [L1964](MASTER_SPEC.md#L1964) MILESTONE 5 â€” Staff and Maintenance / Acceptance / Mechanics repair attractions | Demonstrate MILESTONE 5 â€” Staff and Maintenance / Mechanics repair attractions |
| S25-L1965 | 5 | M4-GATE | Pending | [L1965](MASTER_SPEC.md#L1965) MILESTONE 5 â€” Staff and Maintenance / Acceptance / Staff receive tasks | Demonstrate MILESTONE 5 â€” Staff and Maintenance / Staff receive tasks |
| S25-L1966 | 5 | M4-GATE | Pending | [L1966](MASTER_SPEC.md#L1966) MILESTONE 5 â€” Staff and Maintenance / Acceptance / Salaries affect finances | Demonstrate MILESTONE 5 â€” Staff and Maintenance / Salaries affect finances |
| S25-L1967 | 5 | M4-GATE | Pending | [L1967](MASTER_SPEC.md#L1967) MILESTONE 5 â€” Staff and Maintenance / Acceptance / Unsafe attractions stop accepting guests | Demonstrate MILESTONE 5 â€” Staff and Maintenance / Unsafe attractions stop accepting guests |
| S25-L1971 | 6 | M5-GATE | Pending | [L1971](MASTER_SPEC.md#L1971) MILESTONE 6 â€” Shops and Economy / Implement: | Verify MILESTONE 6 â€” Shops and Economy / Implement: |
| S25-L1973 | 6 | M5-GATE | Pending | [L1973](MASTER_SPEC.md#L1973) MILESTONE 6 â€” Shops and Economy / Implement / Food shop | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Food shop |
| S25-L1974 | 6 | M5-GATE | Pending | [L1974](MASTER_SPEC.md#L1974) MILESTONE 6 â€” Shops and Economy / Implement / Drink shop | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Drink shop |
| S25-L1975 | 6 | M5-GATE | Pending | [L1975](MASTER_SPEC.md#L1975) MILESTONE 6 â€” Shops and Economy / Implement / Shop staff | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Shop staff |
| S25-L1976 | 6 | M5-GATE | Pending | [L1976](MASTER_SPEC.md#L1976) MILESTONE 6 â€” Shops and Economy / Implement / Guest purchases | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Guest purchases |
| S25-L1977 | 6 | M5-GATE | Pending | [L1977](MASTER_SPEC.md#L1977) MILESTONE 6 â€” Shops and Economy / Implement / Operating costs | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Operating costs |
| S25-L1978 | 6 | M5-GATE | Pending | [L1978](MASTER_SPEC.md#L1978) MILESTONE 6 â€” Shops and Economy / Implement / Financial ledger | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Financial ledger |
| S25-L1979 | 6 | M5-GATE | Pending | [L1979](MASTER_SPEC.md#L1979) MILESTONE 6 â€” Shops and Economy / Implement / Revenue dashboard | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Revenue dashboard |
| S25-L1980 | 6 | M5-GATE | Pending | [L1980](MASTER_SPEC.md#L1980) MILESTONE 6 â€” Shops and Economy / Implement / Profit calculations | Demonstrate or document MILESTONE 6 â€” Shops and Economy / Profit calculations |
| S25-L1982 | 6 | M5-GATE | Pending | [L1982](MASTER_SPEC.md#L1982) MILESTONE 6 â€” Shops and Economy / Acceptance: | Verify MILESTONE 6 â€” Shops and Economy / Acceptance: |
| S25-L1984 | 6 | M5-GATE | Pending | [L1984](MASTER_SPEC.md#L1984) MILESTONE 6 â€” Shops and Economy / Acceptance / Guest needs influence purchases | Demonstrate MILESTONE 6 â€” Shops and Economy / Guest needs influence purchases |
| S25-L1985 | 6 | M5-GATE | Pending | [L1985](MASTER_SPEC.md#L1985) MILESTONE 6 â€” Shops and Economy / Acceptance / Transactions are consistent | Demonstrate MILESTONE 6 â€” Shops and Economy / Transactions are consistent |
| S25-L1986 | 6 | M5-GATE | Pending | [L1986](MASTER_SPEC.md#L1986) MILESTONE 6 â€” Shops and Economy / Acceptance / Financial reports match recorded transactions | Demonstrate MILESTONE 6 â€” Shops and Economy / Financial reports match recorded transactions |
| S25-L1990 | 7 | M6-GATE | Pending | [L1990](MASTER_SPEC.md#L1990) MILESTONE 7 â€” Campaign and Progression / Implement: | Verify MILESTONE 7 â€” Campaign and Progression / Implement: |
| S25-L1992 | 7 | M6-GATE | Pending | [L1992](MASTER_SPEC.md#L1992) MILESTONE 7 â€” Campaign and Progression / Implement / Alex advisor | Demonstrate or document MILESTONE 7 â€” Campaign and Progression / Alex advisor |
| S25-L1993 | 7 | M6-GATE | Pending | [L1993](MASTER_SPEC.md#L1993) MILESTONE 7 â€” Campaign and Progression / Implement / Intro sequence | Demonstrate or document MILESTONE 7 â€” Campaign and Progression / Intro sequence |
| S25-L1994 | 7 | M6-GATE | Pending | [L1994](MASTER_SPEC.md#L1994) MILESTONE 7 â€” Campaign and Progression / Implement / Tutorial missions | Demonstrate or document MILESTONE 7 â€” Campaign and Progression / Tutorial missions |
| S25-L1995 | 7 | M6-GATE | Pending | [L1995](MASTER_SPEC.md#L1995) MILESTONE 7 â€” Campaign and Progression / Implement / Six campaign chapters | Demonstrate or document MILESTONE 7 â€” Campaign and Progression / Six campaign chapters |
| S25-L1996 | 7 | M6-GATE | Pending | [L1996](MASTER_SPEC.md#L1996) MILESTONE 7 â€” Campaign and Progression / Implement / Unlock system | Demonstrate or document MILESTONE 7 â€” Campaign and Progression / Unlock system |
| S25-L1997 | 7 | M6-GATE | Pending | [L1997](MASTER_SPEC.md#L1997) MILESTONE 7 â€” Campaign and Progression / Implement / Reputation system | Demonstrate or document MILESTONE 7 â€” Campaign and Progression / Reputation system |
| S25-L1998 | 7 | M6-GATE | Pending | [L1998](MASTER_SPEC.md#L1998) MILESTONE 7 â€” Campaign and Progression / Implement / Five-star progression | Demonstrate or document MILESTONE 7 â€” Campaign and Progression / Five-star progression |
| S25-L2000 | 7 | M6-GATE | Pending | [L2000](MASTER_SPEC.md#L2000) MILESTONE 7 â€” Campaign and Progression / Acceptance: | Verify MILESTONE 7 â€” Campaign and Progression / Acceptance: |
| S25-L2002 | 7 | M6-GATE | Pending | [L2002](MASTER_SPEC.md#L2002) MILESTONE 7 â€” Campaign and Progression / Acceptance / Campaign objectives are achievable | Demonstrate MILESTONE 7 â€” Campaign and Progression / Campaign objectives are achievable |
| S25-L2003 | 7 | M6-GATE | Pending | [L2003](MASTER_SPEC.md#L2003) MILESTONE 7 â€” Campaign and Progression / Acceptance / Mission rewards work | Demonstrate MILESTONE 7 â€” Campaign and Progression / Mission rewards work |
| S25-L2004 | 7 | M6-GATE | Pending | [L2004](MASTER_SPEC.md#L2004) MILESTONE 7 â€” Campaign and Progression / Acceptance / Progress survives save/load | Demonstrate MILESTONE 7 â€” Campaign and Progression / Progress survives save/load |
| S25-L2005 | 7 | M6-GATE | Pending | [L2005](MASTER_SPEC.md#L2005) MILESTONE 7 â€” Campaign and Progression / Acceptance / No progression deadlocks | Demonstrate MILESTONE 7 â€” Campaign and Progression / No progression deadlocks |
| S25-L2009 | 8 | M7-GATE | Pending | [L2009](MASTER_SPEC.md#L2009) MILESTONE 8 â€” Visual and Audio Polish / Implement: | Verify MILESTONE 8 â€” Visual and Audio Polish / Implement: |
| S25-L2011 | 8 | M7-GATE | Pending | [L2011](MASTER_SPEC.md#L2011) MILESTONE 8 â€” Visual and Audio Polish / Implement / Stylized environment | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / Stylized environment |
| S25-L2012 | 8 | M7-GATE | Pending | [L2012](MASTER_SPEC.md#L2012) MILESTONE 8 â€” Visual and Audio Polish / Implement / Improved attraction models | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / Improved attraction models |
| S25-L2013 | 8 | M7-GATE | Pending | [L2013](MASTER_SPEC.md#L2013) MILESTONE 8 â€” Visual and Audio Polish / Implement / Character animation | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / Character animation |
| S25-L2014 | 8 | M7-GATE | Pending | [L2014](MASTER_SPEC.md#L2014) MILESTONE 8 â€” Visual and Audio Polish / Implement / Spatial audio | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / Spatial audio |
| S25-L2015 | 8 | M7-GATE | Pending | [L2015](MASTER_SPEC.md#L2015) MILESTONE 8 â€” Visual and Audio Polish / Implement / Visual feedback | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / Visual feedback |
| S25-L2016 | 8 | M7-GATE | Pending | [L2016](MASTER_SPEC.md#L2016) MILESTONE 8 â€” Visual and Audio Polish / Implement / Lighting | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / Lighting |
| S25-L2017 | 8 | M7-GATE | Pending | [L2017](MASTER_SPEC.md#L2017) MILESTONE 8 â€” Visual and Audio Polish / Implement / UI polish | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / UI polish |
| S25-L2018 | 8 | M7-GATE | Pending | [L2018](MASTER_SPEC.md#L2018) MILESTONE 8 â€” Visual and Audio Polish / Implement / Environmental storytelling | Demonstrate or document MILESTONE 8 â€” Visual and Audio Polish / Environmental storytelling |
| S25-L2020 | 8 | M7-GATE | Pending | [L2020](MASTER_SPEC.md#L2020) MILESTONE 8 â€” Visual and Audio Polish / Acceptance: | Verify MILESTONE 8 â€” Visual and Audio Polish / Acceptance: |
| S25-L2022 | 8 | M7-GATE | Pending | [L2022](MASTER_SPEC.md#L2022) MILESTONE 8 â€” Visual and Audio Polish / Acceptance / Cohesive visual style | Demonstrate MILESTONE 8 â€” Visual and Audio Polish / Cohesive visual style |
| S25-L2023 | 8 | M7-GATE | Pending | [L2023](MASTER_SPEC.md#L2023) MILESTONE 8 â€” Visual and Audio Polish / Acceptance / Readable VR UI | Demonstrate MILESTONE 8 â€” Visual and Audio Polish / Readable VR UI |
| S25-L2024 | 8 | M7-GATE | Pending | [L2024](MASTER_SPEC.md#L2024) MILESTONE 8 â€” Visual and Audio Polish / Acceptance / No major animation defects | Demonstrate MILESTONE 8 â€” Visual and Audio Polish / No major animation defects |
| S25-L2025 | 8 | M7-GATE | Pending | [L2025](MASTER_SPEC.md#L2025) MILESTONE 8 â€” Visual and Audio Polish / Acceptance / No missing materials or broken meshes | Demonstrate MILESTONE 8 â€” Visual and Audio Polish / No missing materials or broken meshes |
| S25-L2029 | 9 | M8-GATE | Pending | [L2029](MASTER_SPEC.md#L2029) MILESTONE 9 â€” Quest Optimization / Implement: | Verify MILESTONE 9 â€” Quest Optimization / Implement: |
| S25-L2031 | 9 | M8-GATE | Pending | [L2031](MASTER_SPEC.md#L2031) MILESTONE 9 â€” Quest Optimization / Implement / LODs | Demonstrate or document MILESTONE 9 â€” Quest Optimization / LODs |
| S25-L2032 | 9 | M8-GATE | Pending | [L2032](MASTER_SPEC.md#L2032) MILESTONE 9 â€” Quest Optimization / Implement / Pooling | Demonstrate or document MILESTONE 9 â€” Quest Optimization / Pooling |
| S25-L2033 | 9 | M8-GATE | Pending | [L2033](MASTER_SPEC.md#L2033) MILESTONE 9 â€” Quest Optimization / Implement / Render optimization | Demonstrate or document MILESTONE 9 â€” Quest Optimization / Render optimization |
| S25-L2034 | 9 | M8-GATE | Pending | [L2034](MASTER_SPEC.md#L2034) MILESTONE 9 â€” Quest Optimization / Implement / Simulation throttling | Demonstrate or document MILESTONE 9 â€” Quest Optimization / Simulation throttling |
| S25-L2035 | 9 | M8-GATE | Pending | [L2035](MASTER_SPEC.md#L2035) MILESTONE 9 â€” Quest Optimization / Implement / Memory improvements | Demonstrate or document MILESTONE 9 â€” Quest Optimization / Memory improvements |
| S25-L2036 | 9 | M8-GATE | Pending | [L2036](MASTER_SPEC.md#L2036) MILESTONE 9 â€” Quest Optimization / Implement / Device quality profiles | Demonstrate or document MILESTONE 9 â€” Quest Optimization / Device quality profiles |
| S25-L2038 | 9 | M8-GATE | Pending | [L2038](MASTER_SPEC.md#L2038) MILESTONE 9 â€” Quest Optimization / Acceptance: | Verify MILESTONE 9 â€” Quest Optimization / Acceptance: |
| S25-L2040 | 9 | M8-GATE | Pending | [L2040](MASTER_SPEC.md#L2040) MILESTONE 9 â€” Quest Optimization / Acceptance / Measured performance report | Demonstrate MILESTONE 9 â€” Quest Optimization / Measured performance report |
| S25-L2041 | 9 | M8-GATE | Pending | [L2041](MASTER_SPEC.md#L2041) MILESTONE 9 â€” Quest Optimization / Acceptance / No persistent critical spikes in target scenarios | Demonstrate MILESTONE 9 â€” Quest Optimization / No persistent critical spikes in target scenarios |
| S25-L2042 | 9 | M8-GATE | Pending | [L2042](MASTER_SPEC.md#L2042) MILESTONE 9 â€” Quest Optimization / Acceptance / Stable operation on tested hardware | Demonstrate MILESTONE 9 â€” Quest Optimization / Stable operation on tested hardware |
| S25-L2043 | 9 | M8-GATE | Pending | [L2043](MASTER_SPEC.md#L2043) MILESTONE 9 â€” Quest Optimization / Acceptance / Documented Quest 2 compatibility limitations | Demonstrate MILESTONE 9 â€” Quest Optimization / Documented Quest 2 compatibility limitations |
| S25-L2047 | 10 | M9-GATE | Pending | [L2047](MASTER_SPEC.md#L2047) MILESTONE 10 â€” Release Candidate / Implement: | Verify MILESTONE 10 â€” Release Candidate / Implement: |
| S25-L2049 | 10 | M9-GATE | Pending | [L2049](MASTER_SPEC.md#L2049) MILESTONE 10 â€” Release Candidate / Implement / Main menu | Demonstrate or document MILESTONE 10 â€” Release Candidate / Main menu |
| S25-L2050 | 10 | M9-GATE | Pending | [L2050](MASTER_SPEC.md#L2050) MILESTONE 10 â€” Release Candidate / Implement / New game | Demonstrate or document MILESTONE 10 â€” Release Candidate / New game |
| S25-L2051 | 10 | M9-GATE | Pending | [L2051](MASTER_SPEC.md#L2051) MILESTONE 10 â€” Release Candidate / Implement / Continue | Demonstrate or document MILESTONE 10 â€” Release Candidate / Continue |
| S25-L2052 | 10 | M9-GATE | Pending | [L2052](MASTER_SPEC.md#L2052) MILESTONE 10 â€” Release Candidate / Implement / Settings | Demonstrate or document MILESTONE 10 â€” Release Candidate / Settings |
| S25-L2053 | 10 | M9-GATE | Pending | [L2053](MASTER_SPEC.md#L2053) MILESTONE 10 â€” Release Candidate / Implement / Save slots | Demonstrate or document MILESTONE 10 â€” Release Candidate / Save slots |
| S25-L2054 | 10 | M9-GATE | Pending | [L2054](MASTER_SPEC.md#L2054) MILESTONE 10 â€” Release Candidate / Implement / Tutorial | Demonstrate or document MILESTONE 10 â€” Release Candidate / Tutorial |
| S25-L2055 | 10 | M9-GATE | Pending | [L2055](MASTER_SPEC.md#L2055) MILESTONE 10 â€” Release Candidate / Implement / Error handling | Demonstrate or document MILESTONE 10 â€” Release Candidate / Error handling |
| S25-L2056 | 10 | M9-GATE | Pending | [L2056](MASTER_SPEC.md#L2056) MILESTONE 10 â€” Release Candidate / Implement / Build configuration | Demonstrate or document MILESTONE 10 â€” Release Candidate / Build configuration |
| S25-L2057 | 10 | M9-GATE | Pending | [L2057](MASTER_SPEC.md#L2057) MILESTONE 10 â€” Release Candidate / Implement / Final regression testing | Demonstrate or document MILESTONE 10 â€” Release Candidate / Final regression testing |
| S25-L2059 | 10 | M9-GATE | Pending | [L2059](MASTER_SPEC.md#L2059) MILESTONE 10 â€” Release Candidate / Acceptance: | Verify MILESTONE 10 â€” Release Candidate / Acceptance: |
| S25-L2061 | 10 | M9-GATE | Pending | [L2061](MASTER_SPEC.md#L2061) MILESTONE 10 â€” Release Candidate / Acceptance / Android APK builds successfully | Demonstrate MILESTONE 10 â€” Release Candidate / Android APK builds successfully |
| S25-L2062 | 10 | M9-GATE | Pending | [L2062](MASTER_SPEC.md#L2062) MILESTONE 10 â€” Release Candidate / Acceptance / All core gameplay loops function | Demonstrate MILESTONE 10 â€” Release Candidate / All core gameplay loops function |
| S25-L2063 | 10 | M9-GATE | Pending | [L2063](MASTER_SPEC.md#L2063) MILESTONE 10 â€” Release Candidate / Acceptance / No known critical blockers | Demonstrate MILESTONE 10 â€” Release Candidate / No known critical blockers |
| S25-L2064 | 10 | M9-GATE | Pending | [L2064](MASTER_SPEC.md#L2064) MILESTONE 10 â€” Release Candidate / Acceptance / Save/load works | Demonstrate MILESTONE 10 â€” Release Candidate / Save/load works |
| S25-L2065 | 10 | M9-GATE | Pending | [L2065](MASTER_SPEC.md#L2065) MILESTONE 10 â€” Release Candidate / Acceptance / Test report completed | Demonstrate MILESTONE 10 â€” Release Candidate / Test report completed |

### 26. TESTING STRATEGY

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S26-L2071 | 2 | M1-GATE | Pending | [L2071](MASTER_SPEC.md#L2071) Create automated tests wherever practical. | Verify Create automated tests wherever practical. |
| S26-L2075 | 2 | M1-GATE | Pending | [L2075](MASTER_SPEC.md#L2075) Unit Tests / Test: | Verify Unit Tests / Test: |
| S26-L2077 | 2 | M1-GATE | Pending | [L2077](MASTER_SPEC.md#L2077) Unit Tests / Test / Economy transactions | Record the result for Unit Tests / Economy transactions |
| S26-L2078 | 4 | M3-GATE | Pending | [L2078](MASTER_SPEC.md#L2078) Unit Tests / Test / Ticket payments | Record the result for Unit Tests / Ticket payments |
| S26-L2079 | 5 | M4-GATE | Pending | [L2079](MASTER_SPEC.md#L2079) Unit Tests / Test / Staff salary deductions | Record the result for Unit Tests / Staff salary deductions |
| S26-L2080 | 7 | M6-GATE | Pending | [L2080](MASTER_SPEC.md#L2080) Unit Tests / Test / Reputation calculations | Record the result for Unit Tests / Reputation calculations |
| S26-L2081 | 3 | M2-GATE | Pending | [L2081](MASTER_SPEC.md#L2081) Unit Tests / Test / Guest need calculations | Record the result for Unit Tests / Guest need calculations |
| S26-L2082 | 4 | M3-GATE | Pending | [L2082](MASTER_SPEC.md#L2082) Unit Tests / Test / Attraction state transitions | Record the result for Unit Tests / Attraction state transitions |
| S26-L2083 | 2 | M1-GATE | Pending | [L2083](MASTER_SPEC.md#L2083) Unit Tests / Test / Construction validation | Record the result for Unit Tests / Construction validation |
| S26-L2084 | 2 | M1-GATE | Pending | [L2084](MASTER_SPEC.md#L2084) Unit Tests / Test / Save serialization | Record the result for Unit Tests / Save serialization |
| S26-L2085 | 7 | M6-GATE | Pending | [L2085](MASTER_SPEC.md#L2085) Unit Tests / Test / Mission completion | Record the result for Unit Tests / Mission completion |
| S26-L2089 | 2 | M1-GATE | Pending | [L2089](MASTER_SPEC.md#L2089) Integration Tests / Test: | Verify Integration Tests / Test: |
| S26-L2091 | 4 | M3-GATE | Pending | [L2091](MASTER_SPEC.md#L2091) Integration Tests / Test / Guest enters park and buys ride ticket | Record the result for Integration Tests / Guest enters park and buys ride ticket |
| S26-L2092 | 4 | M3-GATE | Pending | [L2092](MASTER_SPEC.md#L2092) Integration Tests / Test / Guest joins queue and boards attraction | Record the result for Integration Tests / Guest joins queue and boards attraction |
| S26-L2093 | 6 | M5-GATE | Pending | [L2093](MASTER_SPEC.md#L2093) Integration Tests / Test / Guest becomes hungry and buys food | Record the result for Integration Tests / Guest becomes hungry and buys food |
| S26-L2094 | 5 | M4-GATE | Pending | [L2094](MASTER_SPEC.md#L2094) Integration Tests / Test / Litter appears and cleaner removes it | Record the result for Integration Tests / Litter appears and cleaner removes it |
| S26-L2095 | 5 | M4-GATE | Pending | [L2095](MASTER_SPEC.md#L2095) Integration Tests / Test / Attraction condition degrades and mechanic repairs it | Record the result for Integration Tests / Attraction condition degrades and mechanic repairs it |
| S26-L2096 | 2 | M1-GATE | Pending | [L2096](MASTER_SPEC.md#L2096) Integration Tests / Test / Player constructs attraction and funds decrease | Record the result for Integration Tests / Player constructs attraction and funds decrease |
| S26-L2097 | 2 | M1-GATE | Pending | [L2097](MASTER_SPEC.md#L2097) Integration Tests / Test / Save and reload restores park state | Record the result for Integration Tests / Save and reload restores park state |
| S26-L2101 | 1 | M0-GATE | Pending | [L2101](MASTER_SPEC.md#L2101) XR Interaction Tests / Verify: | Verify XR Interaction Tests / Verify: |
| S26-L2103 | 1 | M0-GATE | Pending | [L2103](MASTER_SPEC.md#L2103) XR Interaction Tests / Verify / Controller ray selection | Record the result for XR Interaction Tests / Controller ray selection |
| S26-L2104 | 2 | M1-GATE | Pending | [L2104](MASTER_SPEC.md#L2104) XR Interaction Tests / Verify / Building placement | Record the result for XR Interaction Tests / Building placement |
| S26-L2105 | 1 | M0-GATE | Pending | [L2105](MASTER_SPEC.md#L2105) XR Interaction Tests / Verify / Wrist UI | Record the result for XR Interaction Tests / Wrist UI |
| S26-L2106 | 1 | M0-GATE | Pending | [L2106](MASTER_SPEC.md#L2106) XR Interaction Tests / Verify / Teleportation | Record the result for XR Interaction Tests / Teleportation |
| S26-L2107 | 1 | M0-GATE | Pending | [L2107](MASTER_SPEC.md#L2107) XR Interaction Tests / Verify / Mode switching | Record the result for XR Interaction Tests / Mode switching |
| S26-L2108 | 4 | M3-GATE | Pending | [L2108](MASTER_SPEC.md#L2108) XR Interaction Tests / Verify / Ride boarding | Record the result for XR Interaction Tests / Ride boarding |
| S26-L2109 | 4 | M3-GATE | Pending | [L2109](MASTER_SPEC.md#L2109) XR Interaction Tests / Verify / Ride exiting | Record the result for XR Interaction Tests / Ride exiting |
| S26-L2110 | 4 | M3-GATE | Pending | [L2110](MASTER_SPEC.md#L2110) XR Interaction Tests / Verify / Comfort exit | Record the result for XR Interaction Tests / Comfort exit |
| S26-L2114 | 9 | M8-GATE | Pending | [L2114](MASTER_SPEC.md#L2114) Stress Tests / Create scenarios for: | Verify Stress Tests / Create scenarios for: |
| S26-L2116 | 9 | M8-GATE | Pending | [L2116](MASTER_SPEC.md#L2116) Stress Tests / Create scenarios for / 25 guests | Demonstrate or document Stress Tests / 25 guests |
| S26-L2117 | 9 | M8-GATE | Pending | [L2117](MASTER_SPEC.md#L2117) Stress Tests / Create scenarios for / 50 guests | Demonstrate or document Stress Tests / 50 guests |
| S26-L2118 | 9 | M8-GATE | Pending | [L2118](MASTER_SPEC.md#L2118) Stress Tests / Create scenarios for / 100 guests | Demonstrate or document Stress Tests / 100 guests |
| S26-L2119 | 9 | M8-GATE | Pending | [L2119](MASTER_SPEC.md#L2119) Stress Tests / Create scenarios for / 200 logical guests | Demonstrate or document Stress Tests / 200 logical guests |
| S26-L2121 | 9 | M8-GATE | Pending | [L2121](MASTER_SPEC.md#L2121) Stress Tests / These are test populations, not guaranteed simultaneous fully rendered character targets. | Verify Stress Tests / These are test populations, not guaranteed simultaneous fully rendered character targets. |
| S26-L2123 | 9 | M8-GATE | Pending | [L2123](MASTER_SPEC.md#L2123) Stress Tests / Measure: | Verify Stress Tests / Measure: |
| S26-L2125 | 9 | M8-GATE | Pending | [L2125](MASTER_SPEC.md#L2125) Stress Tests / Measure / CPU frame time | Demonstrate or document Stress Tests / CPU frame time |
| S26-L2126 | 9 | M8-GATE | Pending | [L2126](MASTER_SPEC.md#L2126) Stress Tests / Measure / GPU frame time | Demonstrate or document Stress Tests / GPU frame time |
| S26-L2127 | 9 | M8-GATE | Pending | [L2127](MASTER_SPEC.md#L2127) Stress Tests / Measure / Memory usage | Demonstrate or document Stress Tests / Memory usage |
| S26-L2128 | 9 | M8-GATE | Pending | [L2128](MASTER_SPEC.md#L2128) Stress Tests / Measure / Navigation performance | Demonstrate or document Stress Tests / Navigation performance |
| S26-L2129 | 9 | M8-GATE | Pending | [L2129](MASTER_SPEC.md#L2129) Stress Tests / Measure / Garbage collection | Demonstrate or document Stress Tests / Garbage collection |
| S26-L2130 | 9 | M8-GATE | Pending | [L2130](MASTER_SPEC.md#L2130) Stress Tests / Measure / Draw calls | Demonstrate or document Stress Tests / Draw calls |
| S26-L2131 | 9 | M8-GATE | Pending | [L2131](MASTER_SPEC.md#L2131) Stress Tests / Measure / Simulation tick duration | Demonstrate or document Stress Tests / Simulation tick duration |
| S26-L2135 | 10 | M9-GATE | Pending | [L2135](MASTER_SPEC.md#L2135) Build Verification / Perform: | Verify Build Verification / Perform: |
| S26-L2137 | 10 | M9-GATE | Pending | [L2137](MASTER_SPEC.md#L2137) Build Verification / Perform / C# compile validation. | Record the result for Build Verification / C# compile validation. |
| S26-L2138 | 10 | M9-GATE | Pending | [L2138](MASTER_SPEC.md#L2138) Build Verification / Perform / EditMode tests. | Record the result for Build Verification / EditMode tests. |
| S26-L2139 | 10 | M9-GATE | Pending | [L2139](MASTER_SPEC.md#L2139) Build Verification / Perform / PlayMode tests. | Record the result for Build Verification / PlayMode tests. |
| S26-L2140 | 10 | M9-GATE | Pending | [L2140](MASTER_SPEC.md#L2140) Build Verification / Perform / Android build. | Record the result for Build Verification / Android build. |
| S26-L2141 | 10 | M9-GATE | Pending | [L2141](MASTER_SPEC.md#L2141) Build Verification / Perform / APK installation when a device is available. | Record the result for Build Verification / APK installation when a device is available. |
| S26-L2142 | 10 | M9-GATE | Pending | [L2142](MASTER_SPEC.md#L2142) Build Verification / Perform / Quest runtime verification. | Record the result for Build Verification / Quest runtime verification. |
| S26-L2143 | 10 | M9-GATE | Pending | [L2143](MASTER_SPEC.md#L2143) Build Verification / Perform / Log inspection. | Record the result for Build Verification / Log inspection. |
| S26-L2144 | 10 | M9-GATE | Pending | [L2144](MASTER_SPEC.md#L2144) Build Verification / Perform / Performance profiling. | Record the result for Build Verification / Performance profiling. |
| S26-L2146 | 10 | M9-GATE | Pending | [L2146](MASTER_SPEC.md#L2146) Build Verification / If no Quest headset is connected, report that device verification is pending. | Verify Build Verification / If no Quest headset is connected, report that device verification is pending. |
| S26-L2148 | 10 | M9-GATE | Pending | [L2148](MASTER_SPEC.md#L2148) Build Verification / Never present editor simulation as proof of standalone Quest performance. | Verify Build Verification / Never present editor simulation as proof of standalone Quest performance. |

### 27. VERTICAL SLICE REQUIREMENTS

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S27-L2154 | 6 | M5-GATE | Pending | [L2154](MASTER_SPEC.md#L2154) Before expanding to all campaign chapters, deliver one polished playable scenario. | Verify Before expanding to all campaign chapters, deliver one polished playable scenario. |
| S27-L2158 | 6 | M5-GATE | Pending | [L2158](MASTER_SPEC.md#L2158) Scenario: The Grand Reopening / The player begins in a partially abandoned park. | Verify Scenario: The Grand Reopening / The player begins in a partially abandoned park. |
| S27-L2160 | 6 | M5-GATE | Pending | [L2160](MASTER_SPEC.md#L2160) Scenario: The Grand Reopening / Starting resources: | Verify Scenario: The Grand Reopening / Starting resources: |
| S27-L2162 | 6 | M5-GATE | Pending | [L2162](MASTER_SPEC.md#L2162) Scenario: The Grand Reopening / Starting resources / Limited money | Demonstrate or document Scenario: The Grand Reopening / Limited money |
| S27-L2163 | 6 | M5-GATE | Pending | [L2163](MASTER_SPEC.md#L2163) Scenario: The Grand Reopening / Starting resources / One usable land zone | Demonstrate or document Scenario: The Grand Reopening / One usable land zone |
| S27-L2164 | 6 | M5-GATE | Pending | [L2164](MASTER_SPEC.md#L2164) Scenario: The Grand Reopening / Starting resources / Basic construction tools | Demonstrate or document Scenario: The Grand Reopening / Basic construction tools |
| S27-L2165 | 6 | M5-GATE | Pending | [L2165](MASTER_SPEC.md#L2165) Scenario: The Grand Reopening / Starting resources / A small selection of attractions | Demonstrate or document Scenario: The Grand Reopening / A small selection of attractions |
| S27-L2166 | 6 | M5-GATE | Pending | [L2166](MASTER_SPEC.md#L2166) Scenario: The Grand Reopening / Starting resources / Basic shops and facilities | Demonstrate or document Scenario: The Grand Reopening / Basic shops and facilities |
| S27-L2168 | 6 | M5-GATE | Pending | [L2168](MASTER_SPEC.md#L2168) Scenario: The Grand Reopening / The player must: | Verify Scenario: The Grand Reopening / The player must: |
| S27-L2170 | 6 | M5-GATE | Pending | [L2170](MASTER_SPEC.md#L2170) Scenario: The Grand Reopening / The player must / Explore the park. | Demonstrate or document Scenario: The Grand Reopening / Explore the park. |
| S27-L2171 | 6 | M5-GATE | Pending | [L2171](MASTER_SPEC.md#L2171) Scenario: The Grand Reopening / The player must / Enter Architect Mode. | Demonstrate or document Scenario: The Grand Reopening / Enter Architect Mode. |
| S27-L2172 | 6 | M5-GATE | Pending | [L2172](MASTER_SPEC.md#L2172) Scenario: The Grand Reopening / The player must / Build a path. | Demonstrate or document Scenario: The Grand Reopening / Build a path. |
| S27-L2173 | 6 | M5-GATE | Pending | [L2173](MASTER_SPEC.md#L2173) Scenario: The Grand Reopening / The player must / Place a carousel. | Demonstrate or document Scenario: The Grand Reopening / Place a carousel. |
| S27-L2174 | 6 | M5-GATE | Pending | [L2174](MASTER_SPEC.md#L2174) Scenario: The Grand Reopening / The player must / Place a food stall. | Demonstrate or document Scenario: The Grand Reopening / Place a food stall. |
| S27-L2175 | 6 | M5-GATE | Pending | [L2175](MASTER_SPEC.md#L2175) Scenario: The Grand Reopening / The player must / Install a trash bin. | Demonstrate or document Scenario: The Grand Reopening / Install a trash bin. |
| S27-L2176 | 6 | M5-GATE | Pending | [L2176](MASTER_SPEC.md#L2176) Scenario: The Grand Reopening / The player must / Hire a cleaner. | Demonstrate or document Scenario: The Grand Reopening / Hire a cleaner. |
| S27-L2177 | 6 | M5-GATE | Pending | [L2177](MASTER_SPEC.md#L2177) Scenario: The Grand Reopening / The player must / Open the park. | Demonstrate or document Scenario: The Grand Reopening / Open the park. |
| S27-L2178 | 6 | M5-GATE | Pending | [L2178](MASTER_SPEC.md#L2178) Scenario: The Grand Reopening / The player must / Observe guests entering. | Demonstrate or document Scenario: The Grand Reopening / Observe guests entering. |
| S27-L2179 | 6 | M5-GATE | Pending | [L2179](MASTER_SPEC.md#L2179) Scenario: The Grand Reopening / The player must / Watch guests queue for the carousel. | Demonstrate or document Scenario: The Grand Reopening / Watch guests queue for the carousel. |
| S27-L2180 | 6 | M5-GATE | Pending | [L2180](MASTER_SPEC.md#L2180) Scenario: The Grand Reopening / The player must / Collect ticket revenue. | Demonstrate or document Scenario: The Grand Reopening / Collect ticket revenue. |
| S27-L2181 | 6 | M5-GATE | Pending | [L2181](MASTER_SPEC.md#L2181) Scenario: The Grand Reopening / The player must / Respond to a cleanliness problem. | Demonstrate or document Scenario: The Grand Reopening / Respond to a cleanliness problem. |
| S27-L2182 | 6 | M5-GATE | Pending | [L2182](MASTER_SPEC.md#L2182) Scenario: The Grand Reopening / The player must / Inspect guest demand. | Demonstrate or document Scenario: The Grand Reopening / Inspect guest demand. |
| S27-L2183 | 6 | M5-GATE | Pending | [L2183](MASTER_SPEC.md#L2183) Scenario: The Grand Reopening / The player must / Board the carousel. | Demonstrate or document Scenario: The Grand Reopening / Board the carousel. |
| S27-L2184 | 6 | M5-GATE | Pending | [L2184](MASTER_SPEC.md#L2184) Scenario: The Grand Reopening / The player must / Complete the reopening mission. | Demonstrate or document Scenario: The Grand Reopening / Complete the reopening mission. |
| S27-L2185 | 6 | M5-GATE | Pending | [L2185](MASTER_SPEC.md#L2185) Scenario: The Grand Reopening / The player must / Save the park. | Demonstrate or document Scenario: The Grand Reopening / Save the park. |
| S27-L2186 | 6 | M5-GATE | Pending | [L2186](MASTER_SPEC.md#L2186) Scenario: The Grand Reopening / The player must / Reload and continue. | Demonstrate or document Scenario: The Grand Reopening / Reload and continue. |
| S27-L2188 | 6 | M5-GATE | Pending | [L2188](MASTER_SPEC.md#L2188) Scenario: The Grand Reopening / This scenario must be fully playable. | Verify Scenario: The Grand Reopening / This scenario must be fully playable. |
| S27-L2190 | 6 | M5-GATE | Pending | [L2190](MASTER_SPEC.md#L2190) Scenario: The Grand Reopening / Do not proceed to advanced campaign content until this vertical slice passes its acceptance tests. | Verify Scenario: The Grand Reopening / Do not proceed to advanced campaign content until this vertical slice passes its acceptance tests. |

### 28. QUALITY REQUIREMENTS

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S28-L2196 | 10 | M9-GATE | Pending | [L2196](MASTER_SPEC.md#L2196) The finished game must feel like an integrated product. | Verify The finished game must feel like an integrated product. |
| S28-L2198 | 10 | M9-GATE | Pending | [L2198](MASTER_SPEC.md#L2198) Avoid: | Verify Avoid: |
| S28-L2200 | 10 | M9-GATE | Pending | [L2200](MASTER_SPEC.md#L2200) Avoid / Decorative rides that do not operate | Show the shipped configuration/behavior avoids Decorative rides that do not operate |
| S28-L2201 | 10 | M9-GATE | Pending | [L2201](MASTER_SPEC.md#L2201) Avoid / Fake guest AI | Show the shipped configuration/behavior avoids Fake guest AI |
| S28-L2202 | 10 | M9-GATE | Pending | [L2202](MASTER_SPEC.md#L2202) Avoid / Buttons with no functionality | Show the shipped configuration/behavior avoids Buttons with no functionality |
| S28-L2203 | 10 | M9-GATE | Pending | [L2203](MASTER_SPEC.md#L2203) Avoid / Unconnected economy systems | Show the shipped configuration/behavior avoids Unconnected economy systems |
| S28-L2204 | 10 | M9-GATE | Pending | [L2204](MASTER_SPEC.md#L2204) Avoid / Nonfunctional staff | Show the shipped configuration/behavior avoids Nonfunctional staff |
| S28-L2205 | 10 | M9-GATE | Pending | [L2205](MASTER_SPEC.md#L2205) Avoid / Placeholder interactions presented as completed features | Show the shipped configuration/behavior avoids Placeholder interactions presented as completed features |
| S28-L2206 | 10 | M9-GATE | Pending | [L2206](MASTER_SPEC.md#L2206) Avoid / Missing save persistence | Show the shipped configuration/behavior avoids Missing save persistence |
| S28-L2207 | 10 | M9-GATE | Pending | [L2207](MASTER_SPEC.md#L2207) Avoid / Broken scene references | Show the shipped configuration/behavior avoids Broken scene references |
| S28-L2208 | 10 | M9-GATE | Pending | [L2208](MASTER_SPEC.md#L2208) Avoid / Unnecessary dependencies | Show the shipped configuration/behavior avoids Unnecessary dependencies |
| S28-L2209 | 10 | M9-GATE | Pending | [L2209](MASTER_SPEC.md#L2209) Avoid / Unoptimized asset imports | Show the shipped configuration/behavior avoids Unoptimized asset imports |
| S28-L2210 | 10 | M9-GATE | Pending | [L2210](MASTER_SPEC.md#L2210) Avoid / Unhandled null references | Show the shipped configuration/behavior avoids Unhandled null references |
| S28-L2211 | 10 | M9-GATE | Pending | [L2211](MASTER_SPEC.md#L2211) Avoid / Runtime allocations in large AI loops | Show the shipped configuration/behavior avoids Runtime allocations in large AI loops |
| S28-L2212 | 10 | M9-GATE | Pending | [L2212](MASTER_SPEC.md#L2212) Avoid / Excessive manager singletons | Show the shipped configuration/behavior avoids Excessive manager singletons |
| S28-L2214 | 10 | M9-GATE | Pending | [L2214](MASTER_SPEC.md#L2214) Prioritize: | Verify Prioritize: |
| S28-L2216 | 10 | M9-GATE | Pending | [L2216](MASTER_SPEC.md#L2216) Prioritize / Functional gameplay | Demonstrate or document Functional gameplay |
| S28-L2217 | 10 | M9-GATE | Pending | [L2217](MASTER_SPEC.md#L2217) Prioritize / Immersion | Demonstrate or document Immersion |
| S28-L2218 | 10 | M9-GATE | Pending | [L2218](MASTER_SPEC.md#L2218) Prioritize / Clear feedback | Demonstrate or document Clear feedback |
| S28-L2219 | 10 | M9-GATE | Pending | [L2219](MASTER_SPEC.md#L2219) Prioritize / Comfortable VR interaction | Demonstrate or document Comfortable VR interaction |
| S28-L2220 | 10 | M9-GATE | Pending | [L2220](MASTER_SPEC.md#L2220) Prioritize / Performance | Demonstrate or document Performance |
| S28-L2221 | 10 | M9-GATE | Pending | [L2221](MASTER_SPEC.md#L2221) Prioritize / Maintainability | Demonstrate or document Maintainability |
| S28-L2222 | 10 | M9-GATE | Pending | [L2222](MASTER_SPEC.md#L2222) Prioritize / Reliability | Demonstrate or document Reliability |
| S28-L2223 | 10 | M9-GATE | Pending | [L2223](MASTER_SPEC.md#L2223) Prioritize / Visual consistency | Demonstrate or document Visual consistency |

### 29. REQUIRED DOCUMENTATION

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S29-L2229 | 10 | M9-GATE | Pending | [L2229](MASTER_SPEC.md#L2229) Maintain: | Verify Maintain: |
| S29-L2231 | 10 | M9-GATE | Pending | [L2231](MASTER_SPEC.md#L2231) `README.md` | Verify `README.md` |
| S29-L2233 | 10 | M9-GATE | Pending | [L2233](MASTER_SPEC.md#L2233) Project overview, setup, controls, build instructions, and current status. | Verify Project overview, setup, controls, build instructions, and current status. |
| S29-L2235 | 10 | M9-GATE | Pending | [L2235](MASTER_SPEC.md#L2235) `Documentation/Architecture.md` | Verify `Documentation/Architecture.md` |
| S29-L2237 | 10 | M9-GATE | Pending | [L2237](MASTER_SPEC.md#L2237) System boundaries, dependency graph, event flow, and save design. | Verify System boundaries, dependency graph, event flow, and save design. |
| S29-L2239 | 0 | â€” | Active | [L2239](MASTER_SPEC.md#L2239) `Documentation/AssetAudit.md` | Verify `Documentation/AssetAudit.md` |
| S29-L2241 | 10 | M9-GATE | Pending | [L2241](MASTER_SPEC.md#L2241) Asset reuse and conversion decisions. | Verify Asset reuse and conversion decisions. |
| S29-L2243 | 0 | â€” | Active | [L2243](MASTER_SPEC.md#L2243) `Documentation/MigrationPlan.md` | Verify `Documentation/MigrationPlan.md` |
| S29-L2245 | 10 | M9-GATE | Pending | [L2245](MASTER_SPEC.md#L2245) Existing mobile systems and VR replacements. | Verify Existing mobile systems and VR replacements. |
| S29-L2247 | 10 | M9-GATE | Pending | [L2247](MASTER_SPEC.md#L2247) `Documentation/DevelopmentLog.md` | Verify `Documentation/DevelopmentLog.md` |
| S29-L2249 | 10 | M9-GATE | Pending | [L2249](MASTER_SPEC.md#L2249) Milestone progress and significant decisions. | Verify Milestone progress and significant decisions. |
| S29-L2251 | 10 | M9-GATE | Pending | [L2251](MASTER_SPEC.md#L2251) `Documentation/TestReport.md` | Verify `Documentation/TestReport.md` |
| S29-L2253 | 10 | M9-GATE | Pending | [L2253](MASTER_SPEC.md#L2253) Tests executed, results, and failures. | Verify Tests executed, results, and failures. |
| S29-L2255 | 10 | M9-GATE | Pending | [L2255](MASTER_SPEC.md#L2255) `Documentation/PerformanceReport.md` | Verify `Documentation/PerformanceReport.md` |
| S29-L2257 | 10 | M9-GATE | Pending | [L2257](MASTER_SPEC.md#L2257) Profiling data and device configuration. | Verify Profiling data and device configuration. |
| S29-L2259 | 10 | M9-GATE | Pending | [L2259](MASTER_SPEC.md#L2259) `Documentation/KnownIssues.md` | Verify `Documentation/KnownIssues.md` |
| S29-L2261 | 10 | M9-GATE | Pending | [L2261](MASTER_SPEC.md#L2261) Outstanding issues, severity, and reproduction steps. | Verify Outstanding issues, severity, and reproduction steps. |
| S29-L2263 | 10 | M9-GATE | Pending | [L2263](MASTER_SPEC.md#L2263) `Documentation/QuestBuildGuide.md` | Verify `Documentation/QuestBuildGuide.md` |
| S29-L2265 | 10 | M9-GATE | Pending | [L2265](MASTER_SPEC.md#L2265) Android/Quest build and installation instructions. | Verify Android/Quest build and installation instructions. |

### 30. IMPLEMENTATION REPORTING FORMAT

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S30-L2271 | 0 | â€” | Ongoing | [L2271](MASTER_SPEC.md#L2271) After each milestone, provide: | Verify After each milestone, provide: |
| S30-L2275 | 0 | â€” | Ongoing | [L2275](MASTER_SPEC.md#L2275) Completed / Describe actual implemented systems. | Verify Completed / Describe actual implemented systems. |
| S30-L2279 | 0 | â€” | Ongoing | [L2279](MASTER_SPEC.md#L2279) Files Created or Modified / List important files and locations. | Verify Files Created or Modified / List important files and locations. |
| S30-L2283 | 0 | â€” | Ongoing | [L2283](MASTER_SPEC.md#L2283) Reused Assets / Identify assets reused from the original project. | Verify Reused Assets / Identify assets reused from the original project. |
| S30-L2287 | 0 | â€” | Ongoing | [L2287](MASTER_SPEC.md#L2287) Blender Assets / Identify newly created assets and their source files. | Verify Blender Assets / Identify newly created assets and their source files. |
| S30-L2291 | 0 | â€” | Ongoing | [L2291](MASTER_SPEC.md#L2291) Verification / Describe tests actually executed and results. | Verify Verification / Describe tests actually executed and results. |
| S30-L2295 | 0 | â€” | Ongoing | [L2295](MASTER_SPEC.md#L2295) Performance / Provide measured performance where available. | Verify Performance / Provide measured performance where available. |
| S30-L2299 | 0 | â€” | Ongoing | [L2299](MASTER_SPEC.md#L2299) Known Issues / Identify incomplete or defective functionality. | Verify Known Issues / Identify incomplete or defective functionality. |
| S30-L2303 | 0 | â€” | Ongoing | [L2303](MASTER_SPEC.md#L2303) Next Milestone / State the next implementation priority. | Verify Next Milestone / State the next implementation priority. |
| S30-L2305 | 0 | â€” | Ongoing | [L2305](MASTER_SPEC.md#L2305) Next Milestone / Do not use vague statements such as "everything works" without verification. | Verify Next Milestone / Do not use vague statements such as "everything works" without verification. |

### 31. DEFINITION OF DONE

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S31-L2311 | 10 | M9-GATE | Pending | [L2311](MASTER_SPEC.md#L2311) The initial playable game is considered complete only when: | Verify The initial playable game is considered complete only when: |
| S31-L2313 | 10 | M9-GATE | Pending | [L2313](MASTER_SPEC.md#L2313) The initial playable game is considered complete only when / A new independent Unity VR project exists. | Demonstrate or document A new independent Unity VR project exists. |
| S31-L2314 | 10 | M9-GATE | Pending | [L2314](MASTER_SPEC.md#L2314) The initial playable game is considered complete only when / The original mobile project remains untouched. | Demonstrate or document The original mobile project remains untouched. |
| S31-L2315 | 10 | M9-GATE | Pending | [L2315](MASTER_SPEC.md#L2315) The initial playable game is considered complete only when / Reused assets have been audited. | Demonstrate or document Reused assets have been audited. |
| S31-L2316 | 10 | M9-GATE | Pending | [L2316](MASTER_SPEC.md#L2316) The initial playable game is considered complete only when / Missing essential assets have been created or sourced appropriately. | Demonstrate or document Missing essential assets have been created or sourced appropriately. |
| S31-L2317 | 10 | M9-GATE | Pending | [L2317](MASTER_SPEC.md#L2317) The initial playable game is considered complete only when / VR controllers work. | Demonstrate or document VR controllers work. |
| S31-L2318 | 10 | M9-GATE | Pending | [L2318](MASTER_SPEC.md#L2318) The initial playable game is considered complete only when / Architect Mode works. | Demonstrate or document Architect Mode works. |
| S31-L2319 | 10 | M9-GATE | Pending | [L2319](MASTER_SPEC.md#L2319) The initial playable game is considered complete only when / Visitor Mode works. | Demonstrate or document Visitor Mode works. |
| S31-L2320 | 10 | M9-GATE | Pending | [L2320](MASTER_SPEC.md#L2320) The initial playable game is considered complete only when / The player can build and manage a park. | Demonstrate or document The player can build and manage a park. |
| S31-L2321 | 10 | M9-GATE | Pending | [L2321](MASTER_SPEC.md#L2321) The initial playable game is considered complete only when / Guests navigate and make meaningful decisions. | Demonstrate or document Guests navigate and make meaningful decisions. |
| S31-L2322 | 10 | M9-GATE | Pending | [L2322](MASTER_SPEC.md#L2322) The initial playable game is considered complete only when / Guests pay for attractions. | Demonstrate or document Guests pay for attractions. |
| S31-L2323 | 10 | M9-GATE | Pending | [L2323](MASTER_SPEC.md#L2323) The initial playable game is considered complete only when / Shops generate revenue. | Demonstrate or document Shops generate revenue. |
| S31-L2324 | 10 | M9-GATE | Pending | [L2324](MASTER_SPEC.md#L2324) The initial playable game is considered complete only when / Cleaners remove litter and vomit. | Demonstrate or document Cleaners remove litter and vomit. |
| S31-L2325 | 10 | M9-GATE | Pending | [L2325](MASTER_SPEC.md#L2325) The initial playable game is considered complete only when / Mechanics maintain rides. | Demonstrate or document Mechanics maintain rides. |
| S31-L2326 | 10 | M9-GATE | Pending | [L2326](MASTER_SPEC.md#L2326) The initial playable game is considered complete only when / Staff salaries and operating costs affect finances. | Demonstrate or document Staff salaries and operating costs affect finances. |
| S31-L2327 | 10 | M9-GATE | Pending | [L2327](MASTER_SPEC.md#L2327) The initial playable game is considered complete only when / Three initial attractions function. | Demonstrate or document Three initial attractions function. |
| S31-L2328 | 10 | M9-GATE | Pending | [L2328](MASTER_SPEC.md#L2328) The initial playable game is considered complete only when / The player can personally ride those attractions. | Demonstrate or document The player can personally ride those attractions. |
| S31-L2329 | 10 | M9-GATE | Pending | [L2329](MASTER_SPEC.md#L2329) The initial playable game is considered complete only when / The introductory campaign is playable. | Demonstrate or document The introductory campaign is playable. |
| S31-L2330 | 10 | M9-GATE | Pending | [L2330](MASTER_SPEC.md#L2330) The initial playable game is considered complete only when / Park reputation changes based on performance. | Demonstrate or document Park reputation changes based on performance. |
| S31-L2331 | 10 | M9-GATE | Pending | [L2331](MASTER_SPEC.md#L2331) The initial playable game is considered complete only when / Save/load restores the park. | Demonstrate or document Save/load restores the park. |
| S31-L2332 | 10 | M9-GATE | Pending | [L2332](MASTER_SPEC.md#L2332) The initial playable game is considered complete only when / Automated tests pass. | Demonstrate or document Automated tests pass. |
| S31-L2333 | 10 | M9-GATE | Pending | [L2333](MASTER_SPEC.md#L2333) The initial playable game is considered complete only when / The Android build succeeds. | Demonstrate or document The Android build succeeds. |
| S31-L2334 | 10 | M9-GATE | Pending | [L2334](MASTER_SPEC.md#L2334) The initial playable game is considered complete only when / Quest performance is measured when hardware is available. | Demonstrate or document Quest performance is measured when hardware is available. |
| S31-L2335 | 10 | M9-GATE | Pending | [L2335](MASTER_SPEC.md#L2335) The initial playable game is considered complete only when / Critical bugs are resolved. | Demonstrate or document Critical bugs are resolved. |
| S31-L2336 | 10 | M9-GATE | Pending | [L2336](MASTER_SPEC.md#L2336) The initial playable game is considered complete only when / Documentation is complete. | Demonstrate or document Documentation is complete. |
| S31-L2338 | 10 | M9-GATE | Pending | [L2338](MASTER_SPEC.md#L2338) The larger game roadmap may remain in progress after this initial definition of done, but incomplete features must be clearly identified. | Verify The larger game roadmap may remain in progress after this initial definition of done, but incomplete features must be clearly identified. |

### 32. START EXECUTION NOW

| ID | Milestone | Depends on | Status | Source requirement | Acceptance criteria |
| --- | --- | --- | --- | --- | --- |
| S32-L2344 | 10 | M9-GATE | Pending | [L2344](MASTER_SPEC.md#L2344) Begin with the following actions. | Verify Begin with the following actions. |
| S32-L2346 | 0 | â€” | Active | [L2346](MASTER_SPEC.md#L2346) **Step 1:** Inspect the workspace and installed development tools. | Verify **Step 1:** Inspect the workspace and installed development tools. |
| S32-L2348 | 0 | â€” | Active | [L2348](MASTER_SPEC.md#L2348) **Step 2:** Inspect the existing Unity mobile project and its Assets directory. | Verify **Step 2:** Inspect the existing Unity mobile project and its Assets directory. |
| S32-L2350 | 0 | â€” | Active | [L2350](MASTER_SPEC.md#L2350) **Step 3:** Generate the asset audit and migration plan. | Verify **Step 3:** Generate the asset audit and migration plan. |
| S32-L2352 | 1 | M0-GATE | Pending | [L2352](MASTER_SPEC.md#L2352) **Step 4:** Create the new Unity VR project without modifying the original. | Verify **Step 4:** Create the new Unity VR project without modifying the original. |
| S32-L2354 | 1 | M0-GATE | Pending | [L2354](MASTER_SPEC.md#L2354) **Step 5:** Configure Unity 6, URP, OpenXR, XR Interaction Toolkit, Android, and Meta Quest compatibility. | Verify **Step 5:** Configure Unity 6, URP, OpenXR, XR Interaction Toolkit, Android, and Meta Quest compatibility. |
| S32-L2356 | 1 | M0-GATE | Pending | [L2356](MASTER_SPEC.md#L2356) **Step 6:** Import a small, verified set of reusable assets. | Verify **Step 6:** Import a small, verified set of reusable assets. |
| S32-L2358 | 1 | M0-GATE | Pending | [L2358](MASTER_SPEC.md#L2358) **Step 7:** Create the initial park environment. | Verify **Step 7:** Create the initial park environment. |
| S32-L2360 | 1 | M0-GATE | Pending | [L2360](MASTER_SPEC.md#L2360) **Step 8:** Implement the XR player and both interaction modes. | Verify **Step 8:** Implement the XR player and both interaction modes. |
| S32-L2362 | 3 | M2-GATE | Pending | [L2362](MASTER_SPEC.md#L2362) **Step 9:** Implement the first playable construction and visitor simulation loop. | Verify **Step 9:** Implement the first playable construction and visitor simulation loop. |
| S32-L2364 | 0 | â€” | Active | [L2364](MASTER_SPEC.md#L2364) **Step 10:** Run validation, fix errors, and continue milestone by milestone. | Verify **Step 10:** Run validation, fix errors, and continue milestone by milestone. |
| S32-L2366 | 10 | M9-GATE | Pending | [L2366](MASTER_SPEC.md#L2366) Do not ask for confirmation between ordinary implementation steps. | Verify Do not ask for confirmation between ordinary implementation steps. |
| S32-L2368 | 10 | M9-GATE | Pending | [L2368](MASTER_SPEC.md#L2368) Ask only when an action requires destructive changes, new paid assets, credentials, licensing decisions, or other important user authorization. | Verify Ask only when an action requires destructive changes, new paid assets, credentials, licensing decisions, or other important user authorization. |
| S32-L2370 | 10 | M9-GATE | Pending | [L2370](MASTER_SPEC.md#L2370) Work autonomously within the accessible environment. | Verify Work autonomously within the accessible environment. |
| S32-L2372 | 10 | M9-GATE | Pending | [L2372](MASTER_SPEC.md#L2372) If a task cannot be executed because a tool, license, package, or device is unavailable, document the limitation, continue independent work, and provide the exact steps required to unblock it. | Verify If a task cannot be executed because a tool, license, package, or device is unavailable, document the limitation, continue independent work, and provide the exact steps required to unblock it. |
| S32-L2374 | 10 | M9-GATE | Pending | [L2374](MASTER_SPEC.md#L2374) **Final instruction:** | Verify **Final instruction:** |
| S32-L2376 | 10 | M9-GATE | Pending | [L2376](MASTER_SPEC.md#L2376) Build The Living Park as a real, playable, polished VR amusement park management game. | Verify Build The Living Park as a real, playable, polished VR amusement park management game. |
| S32-L2378 | 10 | M9-GATE | Pending | [L2378](MASTER_SPEC.md#L2378) Do not merely describe how it could be built. | Verify Do not merely describe how it could be built. |
| S32-L2380 | 10 | M9-GATE | Pending | [L2380](MASTER_SPEC.md#L2380) Create the Unity project, integrate reusable assets, generate original Blender assets, write production-quality C#, implement the systems, execute tests, fix defects, and deliver a verifiable standalone Meta Quest build whenever the required environment and hardware are available. | Verify Create the Unity project, integrate reusable assets, generate original Blender assets, write production-quality C#, implement the systems, execute tests, fix defects, and deliver a verifiable standalone Meta Quest build whenever the required environment and hardware are available. |
