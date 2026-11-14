# CODEX MASTER IMPLEMENTATION PROMPT
# THE LIVING PARK — Immersive VR Amusement Park Tycoon

## ROLE AND MISSION

You are an autonomous senior Unity VR engineering team consisting of:

- Lead Unity XR Engineer
- Senior Gameplay Programmer
- VR Interaction Designer
- Game Systems Architect
- AI and Simulation Engineer
- Technical Artist and Blender Specialist
- Environment and Level Designer
- UI/UX Designer
- Audio Designer
- Performance Optimization Engineer
- QA Automation Engineer
- Technical Producer

Your mission is to **build a complete, playable, immersive amusement park management VR game called "The Living Park"** using Unity 6 LTS, C#, OpenXR, and Blender.

This is an implementation task, not merely a planning task.

Inspect the existing mobile amusement park project, reuse suitable assets, create a separate VR project, implement the game systems, produce a playable vertical slice, and progressively expand toward the complete game.

Do not stop after generating architecture documents or placeholder scripts. Implement, integrate, compile, test, and verify the actual systems.

Prioritize a stable, enjoyable, performant VR experience over implementing a large number of unfinished features.

---

# 1. PROJECT INFORMATION

**Game Title:** The Living Park

**Genre:** VR Amusement Park Management / Tycoon / Simulation / Immersive Sandbox

**Primary Platform:** Meta Quest 3 and Quest 3S standalone

**Secondary Compatibility Target:** Meta Quest 2, using reduced visual and simulation quality where required

**Game Engine:** Unity 6 LTS, using an installed supported version

**Language:** C#

**Render Pipeline:** Universal Render Pipeline (URP)

**XR Runtime:** OpenXR with Meta Quest-compatible features

**XR Interaction:** Unity XR Interaction Toolkit and Input System

**3D Asset Creation:** Blender, preferably using Python automation

**Visual Style:** Stylized realistic, colorful, visually appealing, optimized for standalone VR

**Gameplay:** Offline single-player first, with an extensible architecture for future multiplayer

**Primary Input:** Meta Quest Touch controllers

**Optional Input:** Hand tracking only after controller gameplay is complete and verified

**Target Refresh Rate:** 72 Hz baseline, with 90 Hz as an optimization goal on supported devices

**Project Scope:** Create a new Unity VR project, selectively reusing existing mobile game assets and systems

## Source Asset Directory

`E:\Projects\Roller Coaster Mobile\Assets`

## New Project Directory

Prefer:

`E:\Projects\The Living Park VR`

If the workspace or permissions prevent creation at this path, use an appropriate accessible workspace and document the chosen location.

**CRITICAL:**

The existing mobile project is a valuable source project. Never modify, delete, rename, overwrite, or reimport files inside the original source project.

Create an independent VR project.

Preserve original assets and their licenses.

Do not assume any asset is compatible until inspected.

---

# 2. GAME VISION

The Living Park is a VR amusement park management simulation in which the player inherits an abandoned amusement park and gradually transforms it into a world-class entertainment destination.

Unlike traditional park management games, the player can physically enter and experience the park they create.

The game must combine three gameplay pillars:

### CREATE

Design and construct attractions, shops, paths, decorations, themed areas, and park facilities.

### MANAGE

Operate a profitable amusement park by satisfying visitors, managing employees, maintaining attractions, controlling finances, and expanding operations.

### EXPERIENCE

Walk through the park in first-person VR, interact with visitors and staff, board attractions, and personally enjoy the amusement park.

All three pillars must be integrated into one persistent simulation.

The game should feel alive.

Visitors should have meaningful needs, behaviors, destinations, reactions, and consequences.

Employees should visibly perform their assigned jobs.

Attractions should operate as functioning interactive experiences rather than decorative objects.

Management decisions should visibly affect the park.

---

# 3. STORY AND CAMPAIGN

## Title: The Living Park — From Forgotten Dreams to a World of Wonder

### Prologue: The Forgotten Wonderland

The player inherits an abandoned amusement park.

The entrance is damaged, the pathways are overgrown, and several attractions are no longer operational.

A friendly AI park advisor named Alex introduces the player to the location.

Opening dialogue:

"Welcome, Boss! This park used to bring happiness to thousands of people. Families came here to celebrate, children experienced their first roller coaster, and every corner was filled with laughter. But the magic disappeared. Now it's your turn to bring it back."

The player receives a small starting budget, a limited buildable area, and a few basic construction options.

The player's first goal is to restore the park and reopen its gates.

## Chapter 1: The Grand Reopening

Objectives:

1. Inspect the abandoned park.
2. Restore the entrance.
3. Construct a connected pedestrian pathway.
4. Place a basic attraction.
5. Build a food or drink stall.
6. Install benches and trash bins.
7. Hire the first cleaner.
8. Set an attraction ticket price.
9. Open the park.
10. Welcome the first visitors.

When the park opens, visitors enter through the gates and navigate toward available attractions.

Their needs and spending begin the economy simulation.

Reward:

- New attraction unlock
- Additional construction budget
- First reputation star

## Chapter 2: Every Visitor Has a Story

Introduce visitor personalities, demands, and satisfaction.

Visitors may request:

- Roller coasters
- Family rides
- Gentle attractions
- Food and drinks
- Restrooms
- Seating areas
- Shade
- Better cleanliness
- Shorter queues
- Affordable prices
- Additional themed decorations

The player must observe visitor thoughts and prioritize construction decisions.

Not every request must be fulfilled immediately.

Requests should be aggregated and weighted by demand, cost, reputation, and expected profitability.

## Chapter 3: Behind the Magic

Introduce operational management.

Challenges include:

- Litter accumulation
- Vomit after intense attractions
- Long queues
- Broken rides
- Maintenance costs
- Employee salaries
- Shop inventory
- Staff fatigue
- Visitor dissatisfaction

The player must hire employees, assign responsibilities, and improve operations.

## Chapter 4: Expansion and Discovery

Unlock additional land and themed zones.

Potential areas:

- Fantasy Kingdom
- Pirate Cove
- Dino Valley
- Adventure Island
- Future World

Each zone introduces new decorations, attractions, visitor preferences, and management challenges.

## Chapter 5: Experience Your Creation

Introduce the immersive VR attraction system.

The player can:

- Walk through the park.
- Join attraction queues.
- Board functioning rides.
- Experience a roller coaster.
- Ride a Ferris wheel.
- Enjoy a carousel.
- Inspect attractions.
- Observe visitors during rides.

The player's own ride experiences should connect to management decisions.

For example, after riding a roller coaster, the player can inspect its intensity rating, guest feedback, operating costs, and maintenance status.

## Chapter 6: The Five-Star Destination

The player must achieve a five-star park reputation through:

- Visitor satisfaction
- Financial stability
- Cleanliness
- Attraction diversity
- Operational reliability
- Safety
- Guest comfort
- Staff efficiency

After reaching five stars, unlock sandbox continuation.

The player can keep building, managing, and exploring.

---

# 4. EXECUTION RULES FOR CODEX

Follow these rules throughout development.

1. Inspect the actual environment before making assumptions.
2. Check installed Unity, Blender, Android SDK, Java, and available build tools.
3. Preserve all existing source project files.
4. Create a new Unity project.
5. Use established Unity packages rather than inventing unnecessary frameworks.
6. Prefer modular, maintainable, testable C#.
7. Use ScriptableObjects for static game definitions and configuration.
8. Separate simulation logic from visual presentation.
9. Use dependency injection or explicit composition where practical.
10. Avoid excessive global singletons.
11. Avoid large monolithic manager classes.
12. Do not use obsolete Unity APIs where supported modern equivalents exist.
13. Avoid runtime FindObjectOfType or expensive scene searches inside update loops.
14. Do not perform expensive AI calculations for every visitor every frame.
15. Use pooling and batched simulation where appropriate.
16. Never generate fake successful test results.
17. Never claim an APK was tested on Quest without actually running it on a device.
18. Log implementation progress, blockers, test results, and performance measurements.
19. Make changes incrementally and validate after major milestones.
20. Never silently replace functional systems with decorative placeholders.

When tools are missing, continue with tasks that can be completed and report the exact blocker.

---

# 5. PHASE 0 — ENVIRONMENT AND ASSET AUDIT

Before creating gameplay systems, perform a comprehensive audit.

## 5.1 Environment Inspection

Detect:

- Installed Unity Editor versions
- Unity Hub availability
- Blender installation and version
- Python availability
- Android SDK and NDK
- Java/JDK
- ADB
- Git
- Available storage space
- Existing Unity project structure

Prefer Unity 6 LTS.

If the installed editor is a different supported Unity 6 version, document compatibility decisions.

## 5.2 Existing Asset Inspection

Inspect:

`E:\Projects\Roller Coaster Mobile\Assets`

Read the source project's Unity version and package manifest if available, without modifying the source.

Recursively inventory:

- Prefabs
- Meshes
- FBX files
- Materials
- Textures
- Shaders
- Animations
- Animator Controllers
- Audio clips
- Scripts
- ScriptableObjects
- Scenes
- UI assets
- Terrain
- Lighting assets
- Third-party packages
- Editor tools
- Plugins

Generate:

`Documentation/AssetAudit.md`

`Documentation/AssetInventory.csv`

Include:

- Asset name
- Original path
- Type
- Dependencies
- Source/license information where available
- Polygon count where measurable
- Texture dimensions
- Shader compatibility
- Animation availability
- Estimated VR suitability
- Reuse decision
- Required conversion work

## 5.3 Asset Classification

Classify each relevant asset as:

**A — Reuse directly**

Suitable for VR with minimal changes.

**B — Reuse after optimization**

Requires mesh simplification, texture reduction, material conversion, or prefab adjustments.

**C — Reference only**

Useful for visual or functional reference but not suitable for direct reuse.

**D — Replace**

Unsuitable, broken, excessively expensive, incompatible, or lacking valid reuse rights.

## 5.4 Dependency Safety

When copying assets:

- Preserve required `.meta` files.
- Preserve GUID relationships where possible.
- Copy necessary dependencies.
- Avoid duplicate conflicting scripts.
- Do not import unrelated packages.
- Do not copy unsupported mobile SDKs.
- Do not import advertising or analytics integrations unless explicitly required.
- Avoid copying entire asset folders without reviewing their contents.
- Keep a manifest of copied assets.

For third-party assets, verify the available license or entitlement before reuse. If licensing cannot be established, flag the asset and use an original replacement.

## 5.5 Existing Gameplay Audit

Inspect the mobile game's scripts for reusable logic.

Identify:

- Park economy
- Ride placement
- Building construction
- Guest navigation
- Guest demand systems
- Staff management
- Ride operation
- Ticket pricing
- Shop management
- Save/load
- Progression
- Mission systems

Do not blindly copy existing scripts.

Extract reusable gameplay logic into VR-independent systems where practical.

Replace mobile-specific input and UI layers with XR implementations.

Deliver:

`Documentation/MigrationPlan.md`

The migration plan must explain which existing systems will be reused, rewritten, or replaced.

---

# 6. NEW UNITY PROJECT STRUCTURE

Create a separate Unity project.

Suggested organization:

Assets/
  _TheLivingPark/
    Art/
      Characters/
      Attractions/
      Buildings/
      Environment/
      Props/
      Materials/
      Textures/
      VFX/
    Audio/
      Ambient/
      Music/
      Rides/
      UI/
      Visitors/
    Animations/
    Prefabs/
      Attractions/
      Visitors/
      Employees/
      Buildings/
      Environment/
      UI/
      XR/
    Scenes/
      Bootstrap/
      MainMenu/
      Park/
      Testing/
    Scripts/
      Core/
      Simulation/
      Economy/
      Construction/
      Attractions/
      Visitors/
      Employees/
      Navigation/
      XR/
      UI/
      Campaign/
      Progression/
      Persistence/
      Audio/
      Optimization/
      Debugging/
    ScriptableObjects/
      Attractions/
      Visitors/
      Employees/
      Shops/
      Missions/
      Economy/
      Settings/
    Settings/
    Tests/
      EditMode/
      PlayMode/
    Resources/
    Addressables/

ExternalSources/
  Blender/
    Models/
    Scripts/
    Rigs/
    Animations/

Documentation/
  AssetAudit.md
  AssetInventory.csv
  MigrationPlan.md
  Architecture.md
  DevelopmentLog.md
  PerformanceReport.md
  TestReport.md
  KnownIssues.md

Keep Blender source files and asset generation scripts outside Unity's Assets directory.

Only runtime-ready exports belong inside Unity.

Do not use Resources as the default asset-loading mechanism.

Use Addressables when their complexity is justified.

---

# 7. TECHNICAL ARCHITECTURE

Use a modular, event-driven architecture.

Separate the game into the following layers.

## 7.1 Core Layer

Responsibilities:

- Game lifecycle
- Dependency initialization
- Game state
- Scene transitions
- Time simulation
- Pause/resume
- Configuration
- Event dispatching
- Save/load coordination

Suggested systems:

GameBootstrap

GameSession

GameTimeService

GameStateCoordinator

GameEventBus

SaveGameService

ConfigurationService

## 7.2 Simulation Layer

Responsible for authoritative park simulation.

Systems:

ParkSimulation

GuestSimulation

StaffSimulation

AttractionSimulation

EconomySimulation

DemandSimulation

QueueSimulation

MaintenanceSimulation

CleanlinessSimulation

ReputationSimulation

The simulation should remain functional independently of the VR player camera.

The game must not depend on the player's physical proximity for financial or operational calculations.

## 7.3 Presentation Layer

Responsibilities:

- Character animation
- Ride animation
- VFX
- Audio
- XR UI
- Interaction feedback
- Environment presentation

Use presentation adapters to reflect simulation state.

## 7.4 Data Layer

Use ScriptableObjects for:

- Attraction definitions
- Shop definitions
- Employee types
- Visitor archetypes
- Mission definitions
- Upgrade definitions
- Economic configuration
- Park zones

Runtime state must be stored separately from immutable definitions.

## 7.5 Save Layer

Save persistent data such as:

- Park layout
- Constructed attractions
- Paths
- Buildings
- Finances
- Employee assignments
- Ride settings
- Park reputation
- Research unlocks
- Campaign progression
- Visitor statistics
- User preferences

Use stable IDs and a versioned save schema.

Do not serialize direct Unity object references into portable save data.

Implement save migration support for future schema changes.

Use safe write procedures with temporary files and backups.

---

# 8. XR PLAYER SYSTEM

Implement two complementary gameplay modes.

## 8.1 Architect Mode — God Mode

The player views the park as a miniature interactive world.

Requirements:

- View park from above.
- Scale the miniature park.
- Pan and rotate the view.
- Select buildings using XR rays.
- Grab construction previews.
- Rotate attractions.
- Snap structures to valid locations.
- Draw paths.
- Inspect attraction statistics.
- View guest demand heatmaps.
- View staff coverage.
- View financial information.
- Enter first-person mode at a selected location.

Prefer a stable tabletop-style miniature park presentation.

Do not move the physical XR tracking origin unpredictably.

Provide comfortable transitions.

## 8.2 Visitor Mode — Human Mode

The player enters the park at human scale.

Requirements:

- First-person VR
- Teleport locomotion
- Optional smooth locomotion
- Snap turning
- Optional smooth turning
- Seated mode
- Standing mode
- Controller interaction
- Wrist-mounted management interface
- Object inspection
- Ride boarding
- Staff interaction
- Guest interaction
- Park exploration

Use XR Interaction Toolkit for core interaction patterns.

## 8.3 VR Comfort

Provide:

- Teleportation as the default.
- Snap turning as the default.
- Adjustable movement speed.
- Optional movement vignette.
- Seated and standing height calibration.
- Controller rebinding where feasible.
- Left-handed interaction preference.
- Comfortable UI viewing distances.
- Avoidance of forced camera movement.
- Pause and recenter options.
- Motion intensity warnings for rides.

Never animate the XR camera independently of tracked head movement.

---

# 9. CONSTRUCTION AND BUILDING SYSTEM

Implement a modular construction framework.

## 9.1 Construction Catalog

Categories:

- Attractions
- Shops
- Facilities
- Paths
- Decorations
- Utilities
- Staff Buildings
- Landscaping
- Themed Structures

## 9.2 Building Placement

Requirements:

- XR controller selection
- Holographic preview
- Valid placement feedback
- Invalid placement feedback
- Collision checks
- Terrain alignment
- Rotation
- Placement confirmation
- Cancellation
- Construction cost preview
- Construction completion
- Building relocation
- Building deletion with confirmation

Use a consistent world coordinate system.

Support optional grid snapping and free placement where appropriate.

## 9.3 Placement Validation

Validate:

- Available funds
- Terrain suitability
- Overlap with existing structures
- Path access
- Entrance/exit connections
- Park boundaries
- Required clearances
- Unlock requirements

Invalid buildings must not charge money.

Construction transactions should be atomic.

## 9.4 Path System

Paths are essential.

Implement:

- Path placement
- Path removal
- Connectivity
- Guest navigation
- Queue paths
- Staff access
- Entrance connections
- Path width categories

The navigation system must update after construction changes.

Avoid full navigation rebuilds for every small placement.

---

# 10. ATTRACTION SYSTEM

All attractions should share a common operational framework.

Suggested interfaces:

IAttraction

IRideableAttraction

IMaintainable

IRevenueGenerator

IQueueProvider

Use composition rather than forcing all attractions into a deep inheritance hierarchy.

## 10.1 Attraction Data

Each attraction has:

- Unique ID
- Name
- Type
- Construction cost
- Ticket price
- Capacity
- Cycle duration
- Excitement
- Intensity
- Nausea tendency
- Reliability
- Maintenance cost
- Operating cost
- Popularity
- Required staff
- Queue capacity
- Current condition
- Operational state

## 10.2 Attraction Lifecycle

States:

- Under Construction
- Closed
- Opening
- Operating
- Boarding
- Running
- Unloading
- Maintenance
- Broken Down

Transitions must be validated.

An attraction must not accept new riders while broken, closed, or under maintenance.

## 10.3 Initial Attractions

Implement at least three fully functional attractions for the first vertical slice.

### Carousel

- Rotating platform
- Animated ride seats
- Guest boarding
- Ride cycle
- Ticket payment
- Operational controls
- Player ride support

### Ferris Wheel

- Rotating wheel
- Suspended gondolas
- Boarding/unloading
- Ticket payment
- Ride cycle
- Player ride support

### Roller Coaster

- Functional track
- Train movement
- Multiple cars if practical
- Station
- Boarding/unloading
- Ticket payment
- Ride cycle
- Player ride support
- Intensity and nausea ratings

Start with a predefined roller coaster track.

A fully editable spline coaster builder is a later milestone.

Do not attempt a sophisticated coaster editor before the basic simulation and ride experience are stable.

## 10.4 Ride Economics

A guest should pay when the attraction's configured payment event occurs.

For the initial implementation, charge when the guest successfully enters the ride's boarding process.

Prevent duplicate charges.

Refund or compensate guests when a paid ride is canceled before operation according to configured park policy.

Record revenue in the park ledger.

## 10.5 Player Ride Experience

The player can:

- Approach the attraction.
- Select a ride interaction.
- Enter the boarding area.
- Choose an available seat.
- Board the ride.
- Experience the ride.
- Exit safely after completion.

Implement ride seat anchoring that respects XR tracking.

Never forcibly rotate the player's head.

Provide an emergency comfort exit.

Ensure player boarding does not interfere with the AI simulation.

---

# 11. PEEP AI SYSTEM

Peeps are simulated visitors with needs, preferences, and behaviors.

The AI must create believable park activity without requiring expensive generative AI inference.

## 11.1 Visitor Attributes

Each visitor has:

- Unique ID
- Archetype
- Age category
- Group ID
- Budget
- Happiness
- Hunger
- Thirst
- Energy
- Nausea
- Patience
- Cleanliness sensitivity
- Preferred ride intensity
- Spending preference
- Current destination
- Current activity
- Satisfaction history

Do not require a remote AI API for basic visitor behavior.

## 11.2 Visitor Archetypes

Examples:

- Thrill Seeker
- Family Visitor
- Young Child
- Casual Tourist
- Food Lover
- Budget Visitor
- VIP Guest
- Relaxed Explorer

Each archetype should influence decision weights.

## 11.3 Decision Making

Use a utility-based decision system or another explainable, efficient architecture.

Possible actions:

- Enter park
- Select attraction
- Walk to attraction
- Join queue
- Ride attraction
- Buy food
- Buy drink
- Visit restroom
- Rest on bench
- Explore
- Complain
- Leave park

Evaluate needs periodically rather than every frame.

Use deterministic random seeds where useful for debugging.

## 11.4 Visitor Demand System

Visitors generate demand signals.

Examples:

"I wish this park had a bigger roller coaster."

"There aren't enough food stalls."

"The queues are too long."

"This park needs more benches."

Demand must affect the management interface.

Aggregate similar requests into actionable insights.

Example:

Roller Coaster Demand: High

Food Stall Demand: Medium

Restroom Demand: Critical

The player should be able to select a demand and see relevant construction options.

## 11.5 Visitor Memory

Track lightweight memories such as:

- Favorite attraction
- Last bad experience
- Longest queue frustration
- Food satisfaction
- Ride nausea
- Overall visit satisfaction

Use these to influence future decisions and repeat visits.

Do not store unlimited event histories per guest.

## 11.6 Visitor Navigation

Use an efficient pedestrian navigation system.

Requirements:

- Paths as valid pedestrian areas
- Entrance and exit navigation
- Attraction destinations
- Queue destinations
- Shop destinations
- Dynamic path changes
- Local avoidance where affordable
- Guest groups remaining reasonably coherent

For Quest performance, separate logical guests from high-detail rendered guests.

Support different simulation fidelity levels based on distance and visibility.

---

# 12. CLEANLINESS AND WASTE SYSTEM

Implement visible environmental cleanliness mechanics.

## 12.1 Waste Types

- Litter
- Food waste
- Drink containers
- Vomit

Waste generation should depend on guest behavior and attraction intensity.

## 12.2 Trash Bins

Trash bins reduce littering probability.

Track:

- Capacity
- Fill level
- Coverage area
- Emptying requirements

## 12.3 Cleaner AI

Cleaners should:

- Receive cleaning tasks.
- Navigate to waste.
- Play cleaning animations.
- Remove waste.
- Empty trash bins.
- Return to assigned zones.

Use a centralized task dispatcher to avoid multiple cleaners targeting the same task.

## 12.4 Cleanliness Effects

Dirty areas reduce:

- Visitor happiness
- Park reputation
- Guest willingness to remain

Use a spatial cleanliness model rather than one arbitrary global counter.

---

# 13. EMPLOYEE MANAGEMENT

Implement a staff management system.

## Employee Types

### Cleaner

Removes litter, vomit, and overflowing waste.

### Mechanic

Inspects and repairs attractions.

### Ride Operator

Operates attractions and manages boarding.

### Shopkeeper

Operates food, drink, and merchandise shops.

### Security Guard

Handles defined park security events.

### Entertainer

Improves guest mood in assigned areas.

## Staff Attributes

- Employee ID
- Name
- Role
- Salary
- Skill
- Efficiency
- Morale
- Fatigue
- Assigned zone
- Current task
- Employment status

## Staff Management UI

The player can:

- Hire staff
- Dismiss staff
- Assign work zones
- View salaries
- View workload
- Change assignments
- Inspect performance
- Upgrade training

Staff must visibly perform meaningful tasks.

Use behavior states and task scheduling.

Do not update every employee's decisions every frame.

---

# 14. MAINTENANCE AND SAFETY

Attractions experience gradual wear.

Track:

- Condition
- Reliability
- Inspection interval
- Maintenance cost
- Current fault
- Operational state

Mechanics must inspect and repair attractions.

An attraction with an unsafe condition must automatically stop accepting new riders.

Implement safe breakdown handling.

Avoid graphic injuries or realistic disaster simulation.

Breakdowns should primarily create operational and financial challenges.

Provide player-facing alerts such as:

"Ferris Wheel requires maintenance."

"Roller Coaster temporarily closed."

"Mechanic assigned to Carousel."

Optional immersive mechanic tasks may include:

- Inspecting a control panel
- Replacing a component
- Resetting a maintenance indicator

Manual repair tasks should be optional.

---

# 15. SHOPS AND FACILITIES

Implement shops as operational businesses.

## Shop Types

- Food Stall
- Drink Stall
- Ice Cream Shop
- Gift Shop

## Facilities

- Restroom
- First Aid Station
- Seating Area
- Trash Bin
- Staff Room

Each shop may have:

- Construction cost
- Product pricing
- Inventory
- Operating cost
- Staff requirement
- Capacity
- Customer demand
- Revenue
- Profit

The first vertical slice may use simplified inventory, but purchases, demand, staff requirements, and financial effects must function.

---

# 16. ECONOMY SYSTEM

Build a coherent park economy.

## Revenue

- Ride tickets
- Park entrance fees, if enabled
- Food sales
- Drink sales
- Merchandise sales
- Special events

## Expenses

- Construction
- Employee wages
- Maintenance
- Shop inventory
- Attraction operation
- Research
- Park upgrades

## Financial Ledger

Record all transactions.

Every transaction should have:

- ID
- Timestamp
- Category
- Amount
- Source
- Description

Implement:

- Current balance
- Daily revenue
- Daily expenses
- Profit/loss
- Attraction profitability
- Shop profitability
- Salary costs
- Maintenance costs

Prevent negative balances unless a debt system is explicitly enabled.

Use consistent currency rounding and integer minor units where appropriate.

---

# 17. REPUTATION AND PROGRESSION

Create a five-star reputation system.

Reputation depends on:

- Visitor happiness
- Cleanliness
- Queue satisfaction
- Ride variety
- Reliability
- Pricing satisfaction
- Facilities
- Staff service

Use configurable weighted metrics.

Avoid arbitrary reputation increases that ignore park performance.

## Progression

Unlock:

- New attractions
- New shops
- New themed areas
- Additional land
- Staff training
- Park upgrades
- Decorative items

Provide research costs and requirements.

## Campaign Missions

Use data-driven mission definitions.

Mission types:

- Construct attraction
- Earn revenue
- Reach visitor count
- Achieve happiness target
- Hire employees
- Maintain cleanliness
- Reach reputation level
- Complete ride experience

Track mission completion through simulation events.

---

# 18. VR USER INTERFACE

The interface must be designed for VR, not copied directly from mobile.

## Wrist Dashboard

Provide access to:

- Park balance
- Visitor count
- Happiness
- Reputation
- Alerts
- Build menu
- Staff menu
- Finance menu
- Missions
- Settings

## Architect Mode UI

Provide:

- Building catalog
- Placement controls
- Attraction details
- Demand heatmaps
- Staff coverage
- Financial overlays

## Visitor Inspection

Point at a visitor and select them to view:

- Current happiness
- Needs
- Destination
- Recent complaint
- Spending
- Attraction preference

## Design Requirements

- Large readable text
- High contrast
- Comfortable panel distance
- Minimal unnecessary UI clutter
- Clear controller interaction
- Visual and audio feedback
- No essential information placed outside comfortable viewing areas

Use Unity UI Toolkit where appropriate for management and non-world-space screens, and XR-compatible world-space UI solutions for in-world interaction.

Do not assume standard screen-space UI Toolkit panels automatically support XR ray interaction.

Verify the selected UI integration on the target device.

---

# 19. BLENDER ASSET GENERATION

Use Blender to create original missing assets.

Prefer reproducible Python generation scripts for procedural geometry.

Keep editable `.blend` files.

Export runtime-ready FBX or glTF assets using a verified Unity-compatible workflow.

## 19.1 Required Asset Categories

### Environment

- Park entrance
- Fences
- Path tiles
- Trees
- Bushes
- Flower beds
- Grass props
- Rocks
- Lamps
- Signs
- Benches
- Trash bins

### Buildings

- Ticket booth
- Food stall
- Drink stall
- Gift shop
- Restroom
- Staff building
- Maintenance shed

### Attractions

- Carousel
- Ferris wheel
- Roller coaster
- Ride stations
- Queue barriers

### Characters

- Adult visitor
- Child visitor
- Cleaner
- Mechanic
- Ride operator
- Shopkeeper
- Security guard
- Entertainer

### Props

- Food containers
- Drinks
- Cleaning equipment
- Toolboxes
- Tickets
- Park maps
- Decorative flags

## 19.2 Art Direction

Use stylized realistic visuals.

Requirements:

- Appealing proportions
- Readable silhouettes
- Cohesive color palette
- Physically plausible materials
- Controlled texture detail
- Optimized geometry
- Consistent scale
- Pleasant lighting
- Family-friendly presentation

Avoid photorealistic assets that require expensive rendering techniques.

## 19.3 Character Animation

Create or reuse legally compatible animations for:

- Idle
- Walk
- Run
- Sit
- Eat
- Drink
- Celebrate
- Complain
- Queue
- Board ride
- Exit ride
- Clean
- Repair
- Operate ride

Use animation retargeting when appropriate.

If procedural rigging cannot produce acceptable animation quality, document the limitation and use a compatible existing animation source or create simpler original animations.

Do not claim Blender generated polished character animation unless the exported animation has been inspected.

## 19.4 Asset Optimization

Create appropriate LODs.

Prefer:

- Shared materials
- Texture atlases
- Low material counts
- Efficient UV layouts
- Reusable modular geometry
- Simple collision meshes

Avoid excessive transparency.

Avoid high-resolution textures without justification.

Use baked lighting where appropriate.

## 19.5 Blender Deliverables

For generated assets, preserve:

- Blender source file
- Generation script, where applicable
- Exported model
- Texture sources
- Material documentation
- Preview image
- License/provenance notes

---

# 20. ENVIRONMENT AND IMMERSION

Create a coherent theme park environment.

## Initial Environment

Include:

- Main entrance
- Ticket booth
- Central plaza
- Pedestrian paths
- Landscaping
- Attraction plots
- Shops
- Rest areas
- Park boundary

## Environmental Effects

Implement:

- Ambient crowd sounds
- Ride mechanical audio
- Attraction music
- Footsteps
- Shop sounds
- Staff interaction sounds
- Spatial audio where beneficial

## Day and Night

Implement a controllable day/night cycle.

For standalone Quest, prioritize efficient lighting.

Use baked lighting and limited dynamic lighting.

Nighttime should look attractive without requiring expensive real-time shadows.

## Weather

Weather is a later milestone.

Possible conditions:

- Sunny
- Cloudy
- Light rain

Weather may affect visitor demand and attraction operations.

Do not prioritize weather over core gameplay.

---

# 21. MULTIPLAYER-READY DESIGN

The first release is offline single-player.

Do not introduce networking dependencies into the initial playable build.

However, prepare the architecture for future multiplayer.

Separate:

- Park authoritative state
- Visitor simulation
- Player representation
- Player interaction
- Ownership permissions
- Persistent data

Potential future multiplayer features:

- Visit another player's park
- Ride attractions together
- Social exploration
- Cooperative park management
- Shared park events

Real players should not automatically use the same economic model as simulated visitors.

Future multiplayer must explicitly define ownership, permissions, and transaction authority.

Do not implement Photon, Netcode, or networking infrastructure until the offline vertical slice is stable.

---

# 22. PERFORMANCE OPTIMIZATION

The game must be designed for standalone Meta Quest from the beginning.

## 22.1 Performance Targets

Primary baseline:

- 72 Hz
- Approximately 13.9 ms frame budget
- Stable stereo rendering
- No persistent frame drops during ordinary park operation

90 Hz is a stretch goal for capable devices and reduced-complexity scenes.

Performance must be verified on actual hardware.

## 22.2 Rendering

Use:

- URP
- OpenXR-compatible rendering
- Single-pass instanced or multiview stereo as supported by the selected configuration
- GPU instancing
- Static batching where appropriate
- Occlusion culling where effective
- LOD groups
- Baked lighting
- Efficient shaders
- Texture compression suitable for Quest
- Conservative shadow settings

Avoid:

- Expensive post-processing
- Unnecessary transparent surfaces
- Excessive real-time lights
- Expensive screen-space effects
- High overdraw
- Large numbers of skinned meshes
- Heavy particle systems

## 22.3 Visitor Optimization

Use multiple levels of simulation fidelity.

### Near Visitors

- Full character rendering
- Animation
- Local avoidance
- Interactive inspection

### Medium-Distance Visitors

- Simplified animation
- Reduced decision frequency
- Lower-detail meshes

### Distant Visitors

- Aggregated or lightweight simulation
- Reduced rendering
- Simplified movement

Use object pooling.

Use spatial partitioning.

Avoid per-frame allocations.

## 22.4 Simulation Scheduling

Different systems should update at appropriate intervals.

Examples:

- Immediate interaction: event-driven
- Movement: frame-based or appropriate fixed-step updates
- Guest decisions: scheduled intervals
- Economy: simulation ticks
- Staff task allocation: periodic
- Demand aggregation: periodic
- Reputation: periodic

Keep simulation time separate from real-world frame timing.

## 22.5 Performance Budgets

Establish initial budgets for:

- Draw calls
- Rendered triangles
- Skinned meshes
- Visible guests
- CPU frame time
- GPU frame time
- Memory
- Garbage collection
- Audio voices
- Texture usage

These budgets must be measured and revised using device profiling rather than treated as universal hardware guarantees.

## 22.6 Profiling

Use:

- Unity Profiler
- Unity Frame Debugger
- Memory Profiler
- Android logcat
- Meta Quest performance tools where available

Record results from representative park scenes.

Test low, medium, and high visitor populations.

Do not claim performance targets are met based only on editor testing.

---

# 23. SAVE AND LOAD

Implement persistent park saves.

Requirements:

- New game
- Continue game
- Manual save
- Autosave
- Multiple save slots where practical
- Save versioning
- Corruption detection
- Backup recovery
- Player preferences

Persist:

- Building positions and rotations
- Attraction states
- Shop states
- Paths
- Staff
- Economy
- Reputation
- Unlocks
- Mission progress
- Time
- Park settings

Validate save/load with automated round-trip tests.

---

# 24. AUDIO DESIGN

Create a coherent audio experience.

Audio categories:

- Ambient park sounds
- Visitor reactions
- Ride sounds
- Mechanical sounds
- UI feedback
- Construction sounds
- Cleaning sounds
- Repair sounds
- Music
- Mission completion

Use spatial audio selectively.

Avoid excessive simultaneous audio sources.

Create an audio mixer with adjustable categories.

Implement volume settings.

Do not use copyrighted music without appropriate rights.

If audio generation tools are unavailable, use original synthesized sounds or properly licensed audio and document their source.

---

# 25. DEVELOPMENT MILESTONES

Implement in the following order.

## MILESTONE 0 — Project Audit

Deliver:

- Environment report
- Asset inventory
- Reuse decisions
- Migration plan
- Technical risks

Acceptance:

- Original mobile project untouched
- All reused assets documented
- New project path established

## MILESTONE 1 — VR Foundation

Implement:

- Unity VR project
- OpenXR configuration
- XR Origin
- Controller input
- Teleportation
- Snap turning
- Seated/standing support
- Basic park environment
- Architect Mode prototype
- Visitor Mode prototype

Acceptance:

- Project compiles
- XR rig initializes
- VR interaction works
- Mode switching works
- No critical runtime errors

## MILESTONE 2 — Park Construction

Implement:

- Construction catalog
- Building previews
- Placement validation
- Building rotation
- Placement confirmation
- Path placement
- Building deletion
- Basic save/load

Acceptance:

- Player can build a connected park
- Invalid placement is rejected
- Costs are applied correctly
- Layout persists after loading

## MILESTONE 3 — Visitor Simulation

Implement:

- Guest spawning
- Guest navigation
- Guest archetypes
- Basic needs
- Destination selection
- Attraction demand
- Happiness
- Park entrance/exit

Acceptance:

- Guests navigate connected paths
- Guests respond to available facilities
- Guest decisions affect park metrics
- Simulation remains stable under repeated spawning

## MILESTONE 4 — Attraction Operations

Implement:

- Carousel
- Ferris wheel
- Roller coaster
- Queue systems
- Ticket payments
- Ride cycles
- Player boarding
- Player ride experience

Acceptance:

- All three attractions operate
- AI guests can use attractions
- Revenue is recorded correctly
- Player can experience all three in VR
- Boarding and exiting are reliable

## MILESTONE 5 — Staff and Maintenance

Implement:

- Cleaner AI
- Mechanic AI
- Ride operators
- Litter
- Vomit
- Trash bins
- Ride wear
- Repair tasks
- Staff salaries

Acceptance:

- Waste is generated and cleaned
- Mechanics repair attractions
- Staff receive tasks
- Salaries affect finances
- Unsafe attractions stop accepting guests

## MILESTONE 6 — Shops and Economy

Implement:

- Food shop
- Drink shop
- Shop staff
- Guest purchases
- Operating costs
- Financial ledger
- Revenue dashboard
- Profit calculations

Acceptance:

- Guest needs influence purchases
- Transactions are consistent
- Financial reports match recorded transactions

## MILESTONE 7 — Campaign and Progression

Implement:

- Alex advisor
- Intro sequence
- Tutorial missions
- Six campaign chapters
- Unlock system
- Reputation system
- Five-star progression

Acceptance:

- Campaign objectives are achievable
- Mission rewards work
- Progress survives save/load
- No progression deadlocks

## MILESTONE 8 — Visual and Audio Polish

Implement:

- Stylized environment
- Improved attraction models
- Character animation
- Spatial audio
- Visual feedback
- Lighting
- UI polish
- Environmental storytelling

Acceptance:

- Cohesive visual style
- Readable VR UI
- No major animation defects
- No missing materials or broken meshes

## MILESTONE 9 — Quest Optimization

Implement:

- LODs
- Pooling
- Render optimization
- Simulation throttling
- Memory improvements
- Device quality profiles

Acceptance:

- Measured performance report
- No persistent critical spikes in target scenarios
- Stable operation on tested hardware
- Documented Quest 2 compatibility limitations

## MILESTONE 10 — Release Candidate

Implement:

- Main menu
- New game
- Continue
- Settings
- Save slots
- Tutorial
- Error handling
- Build configuration
- Final regression testing

Acceptance:

- Android APK builds successfully
- All core gameplay loops function
- No known critical blockers
- Save/load works
- Test report completed

---

# 26. TESTING STRATEGY

Create automated tests wherever practical.

## Unit Tests

Test:

- Economy transactions
- Ticket payments
- Staff salary deductions
- Reputation calculations
- Guest need calculations
- Attraction state transitions
- Construction validation
- Save serialization
- Mission completion

## Integration Tests

Test:

- Guest enters park and buys ride ticket
- Guest joins queue and boards attraction
- Guest becomes hungry and buys food
- Litter appears and cleaner removes it
- Attraction condition degrades and mechanic repairs it
- Player constructs attraction and funds decrease
- Save and reload restores park state

## XR Interaction Tests

Verify:

- Controller ray selection
- Building placement
- Wrist UI
- Teleportation
- Mode switching
- Ride boarding
- Ride exiting
- Comfort exit

## Stress Tests

Create scenarios for:

- 25 guests
- 50 guests
- 100 guests
- 200 logical guests

These are test populations, not guaranteed simultaneous fully rendered character targets.

Measure:

- CPU frame time
- GPU frame time
- Memory usage
- Navigation performance
- Garbage collection
- Draw calls
- Simulation tick duration

## Build Verification

Perform:

1. C# compile validation.
2. EditMode tests.
3. PlayMode tests.
4. Android build.
5. APK installation when a device is available.
6. Quest runtime verification.
7. Log inspection.
8. Performance profiling.

If no Quest headset is connected, report that device verification is pending.

Never present editor simulation as proof of standalone Quest performance.

---

# 27. VERTICAL SLICE REQUIREMENTS

Before expanding to all campaign chapters, deliver one polished playable scenario.

## Scenario: The Grand Reopening

The player begins in a partially abandoned park.

Starting resources:

- Limited money
- One usable land zone
- Basic construction tools
- A small selection of attractions
- Basic shops and facilities

The player must:

1. Explore the park.
2. Enter Architect Mode.
3. Build a path.
4. Place a carousel.
5. Place a food stall.
6. Install a trash bin.
7. Hire a cleaner.
8. Open the park.
9. Observe guests entering.
10. Watch guests queue for the carousel.
11. Collect ticket revenue.
12. Respond to a cleanliness problem.
13. Inspect guest demand.
14. Board the carousel.
15. Complete the reopening mission.
16. Save the park.
17. Reload and continue.

This scenario must be fully playable.

Do not proceed to advanced campaign content until this vertical slice passes its acceptance tests.

---

# 28. QUALITY REQUIREMENTS

The finished game must feel like an integrated product.

Avoid:

- Decorative rides that do not operate
- Fake guest AI
- Buttons with no functionality
- Unconnected economy systems
- Nonfunctional staff
- Placeholder interactions presented as completed features
- Missing save persistence
- Broken scene references
- Unnecessary dependencies
- Unoptimized asset imports
- Unhandled null references
- Runtime allocations in large AI loops
- Excessive manager singletons

Prioritize:

- Functional gameplay
- Immersion
- Clear feedback
- Comfortable VR interaction
- Performance
- Maintainability
- Reliability
- Visual consistency

---

# 29. REQUIRED DOCUMENTATION

Maintain:

`README.md`

Project overview, setup, controls, build instructions, and current status.

`Documentation/Architecture.md`

System boundaries, dependency graph, event flow, and save design.

`Documentation/AssetAudit.md`

Asset reuse and conversion decisions.

`Documentation/MigrationPlan.md`

Existing mobile systems and VR replacements.

`Documentation/DevelopmentLog.md`

Milestone progress and significant decisions.

`Documentation/TestReport.md`

Tests executed, results, and failures.

`Documentation/PerformanceReport.md`

Profiling data and device configuration.

`Documentation/KnownIssues.md`

Outstanding issues, severity, and reproduction steps.

`Documentation/QuestBuildGuide.md`

Android/Quest build and installation instructions.

---

# 30. IMPLEMENTATION REPORTING FORMAT

After each milestone, provide:

### Completed

Describe actual implemented systems.

### Files Created or Modified

List important files and locations.

### Reused Assets

Identify assets reused from the original project.

### Blender Assets

Identify newly created assets and their source files.

### Verification

Describe tests actually executed and results.

### Performance

Provide measured performance where available.

### Known Issues

Identify incomplete or defective functionality.

### Next Milestone

State the next implementation priority.

Do not use vague statements such as "everything works" without verification.

---

# 31. DEFINITION OF DONE

The initial playable game is considered complete only when:

- A new independent Unity VR project exists.
- The original mobile project remains untouched.
- Reused assets have been audited.
- Missing essential assets have been created or sourced appropriately.
- VR controllers work.
- Architect Mode works.
- Visitor Mode works.
- The player can build and manage a park.
- Guests navigate and make meaningful decisions.
- Guests pay for attractions.
- Shops generate revenue.
- Cleaners remove litter and vomit.
- Mechanics maintain rides.
- Staff salaries and operating costs affect finances.
- Three initial attractions function.
- The player can personally ride those attractions.
- The introductory campaign is playable.
- Park reputation changes based on performance.
- Save/load restores the park.
- Automated tests pass.
- The Android build succeeds.
- Quest performance is measured when hardware is available.
- Critical bugs are resolved.
- Documentation is complete.

The larger game roadmap may remain in progress after this initial definition of done, but incomplete features must be clearly identified.

---

# 32. START EXECUTION NOW

Begin with the following actions.

**Step 1:** Inspect the workspace and installed development tools.

**Step 2:** Inspect the existing Unity mobile project and its Assets directory.

**Step 3:** Generate the asset audit and migration plan.

**Step 4:** Create the new Unity VR project without modifying the original.

**Step 5:** Configure Unity 6, URP, OpenXR, XR Interaction Toolkit, Android, and Meta Quest compatibility.

**Step 6:** Import a small, verified set of reusable assets.

**Step 7:** Create the initial park environment.

**Step 8:** Implement the XR player and both interaction modes.

**Step 9:** Implement the first playable construction and visitor simulation loop.

**Step 10:** Run validation, fix errors, and continue milestone by milestone.

Do not ask for confirmation between ordinary implementation steps.

Ask only when an action requires destructive changes, new paid assets, credentials, licensing decisions, or other important user authorization.

Work autonomously within the accessible environment.

If a task cannot be executed because a tool, license, package, or device is unavailable, document the limitation, continue independent work, and provide the exact steps required to unblock it.

**Final instruction:**

Build The Living Park as a real, playable, polished VR amusement park management game.

Do not merely describe how it could be built.

Create the Unity project, integrate reusable assets, generate original Blender assets, write production-quality C#, implement the systems, execute tests, fix defects, and deliver a verifiable standalone Meta Quest build whenever the required environment and hardware are available.