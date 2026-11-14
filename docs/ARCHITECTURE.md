# Proposed architecture

The independent Unity project will live at this workspace root. The first release targets offline standalone Quest 3 and Quest 3S, with reduced-quality Quest 2 compatibility to be evaluated. Unity 6 LTS, URP, OpenXR, XR Interaction Toolkit and Input System form the proposed runtime stack. Resolve and verify package compatibility during Milestone 1. See the [master specification](MASTER_SPEC.md) for requirements and the [migration plan](../Documentation/MigrationPlan.md) for mobile source decisions.

## System boundaries

| Layer | Responsibilities | Dependencies |
| --- | --- | --- |
| Domain | Stable IDs, simulation state, command/result contracts, ledger, path connectivity, ride/queue rules, visitor needs and task assignment | C# domain types |
| Application | Game session, tick scheduler, command handlers, definition registry, mission/reputation processing, snapshot coordination | Domain and adapter interfaces |
| Unity adapters | ScriptableObject definitions, scene composition, navigation/motion integration, file storage, real-time input clock | Application contracts and Unity packages |
| Presentation | XR modes and locomotion, ride seats, world UI, audio, animation, VFX, pooled views | Application commands, events and read models |
| Tests | Deterministic domain fixtures, integrated park scenarios, XR interaction and device protocols | Relevant production layer |

Composition occurs at bootstrap. XR and desktop test input submit the same application commands. Validation covers unlocks, park bounds, occupancy, connectivity and funds before construction changes the authoritative layout and ledger. Successful changes invalidate affected graph regions and publish events to views and mission consumers. Use the path network for logical routes and local steering or a Unity navigation adapter for nearby movement. Measure rebuild costs before committing to an adapter.

Use scheduled, budgeted ticks for guest decisions, jobs, demand and reputation. Guest intent selects a reachable destination and competes for queue and seat capacity. Ride boarding reserves a slot and records an idempotent payment; cancellation follows park refund policy. Staff tasks have exclusive claims. Shop purchases connect guest needs, inventory, staffing and ledger entries. A completed transaction publishes one event to finance and mission projections.

Architect Mode displays a transformed miniature from the same park state. Visitor Mode uses the full-size park. A controlled transition resolves a valid destination and preserves headset tracking. Ride anchors move relative to the tracked XR origin while the player retains head control. Apply comfort settings and verify emergency exit independently of ride completion.

Versioned snapshots capture stable definition IDs, layout, finances, guest statistics, staff, operations, progression, clock and settings. Save to a temporary file, validate, promote with backup recovery and migrate older schemas. Rebuild runtime indexes and views from snapshots. Reject unsupported future schemas without overwriting them.

## Integration gates

Build XR composition first, then atomic construction and save foundations. Add guests on the validated path network, rides and queues on guest destinations, staff and maintenance on operational state, and shop transactions on the shared ledger. Verify all three rides and the Grand Reopening scenario before advanced campaign content. Add art/audio and profile representative Quest scenes before release. Use separate adapter and logical-state tests wherever the runtime permits.

Networking is a future roadmap item. Keep command authority, player identity and simulation visitor budgets distinct, with offline authority local to the session.
