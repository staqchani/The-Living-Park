# Mobile asset audit

Source: E:\Projects\Roller Coaster Mobile\Assets. This was a read-only, recursive filesystem inspection. No Unity source project import, launch, copy or conversion was performed.

[AssetInventory.csv](AssetInventory.csv) lists 11,653 assets plus associated direct references where available. The scan observed 26,007 files including 14,354 metadata GUIDs, with zero duplicates in that index. Source asset path, file length and modification timestamp snapshots matched before and after inventory generation (SHA-256 1ea4a35e278d734be27daa77bc2d35c73614a5d2d5f70ce2e96e41ad6d678def).

| Inventory | Count |
| --- | ---: |
| Prefabs | 1,523 |
| Mesh/model files | 1,330 |
| Materials / shaders | 2,312 / 74 |
| Textures / dimensions measured | 4,169 / 4,004 |
| Animation and controller files | 380 |
| Audio files | 7 |
| Scripts | 635 |
| ScriptableObject candidates | 457 |
| Scenes / terrain / lighting | 74 / 140 / 19 |
| UI / package or config / plugin files | 30 / 18 / 4 |
| Assets containing direct serialized GUID references | 4,941 |
| OBJ meshes with face counts | 12 |
| Conditional reuse candidates | 120 |

Some UI art is counted under textures or prefabs. Some third-party packages and editor tools span many ordinary asset rows. Project package assertions are in the [environment report](EnvironmentReport.md). Remaining serialized data includes binary or ambiguous .asset files.

## Reuse decisions

| Class | Decision |
| --- | --- |
| A | No direct reuse approved. |
| B | 120 name/path-selected prefab candidates require entitlement, dependency closure, an isolated import, art-only extraction where needed and measured XR validation. |
| C | Reference-only assets, including mobile scenes and gameplay source. Use the CSV to trace candidate dependencies and the migration plan for system decisions. |
| D | Exclude identified SDK and plugin entries from the VR baseline. Where the spec requires equivalent behavior, implement it independently. Replace unlicensed candidates with original assets. |

Review the carousel and Ferris wheel prefabs under zFinalAssets/Attraction Thing/Rides (TeaCup, FarrisWheel, SkyWheel), coaster models under Attraction Thing/Coaster, and the food stall, paths and trash bins under Attraction Thing. The tea-cup prefab is a visual reference candidate; the required carousel has distinct functional and presentation criteria. The FuzzyString notice was identified in BuildReport editor tools. It supplies no provenance for candidate park art.

Inspect selected prefabs with materials, models, mesh cost, animation and shader variants during an isolated import. The CSV resolves direct GUID text references into source paths. Unresolved GUID text can represent engine, packages, or missing assets. Binary, runtime and transitive dependencies require further validation. OBJ counts are faces, while FBX triangle counts, embedded animation and extra texture formats still require import or format-specific measurement. No asset has been certified for standalone VR.

Before copying, confirm entitlement and reference closure, preserve required .meta files, strip legacy component dependencies in the VR project, and document source, destination, rights and changed assets in the import manifest.
