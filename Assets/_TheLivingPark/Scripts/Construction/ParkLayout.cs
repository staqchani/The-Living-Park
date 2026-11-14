using System;
using System.Collections.Generic;

namespace LivingPark.Construction
{
    public sealed class BuildDefinition
    {
        public readonly string Id, Category;
        public readonly int Width, Depth;
        public readonly long Cost;
        public readonly bool Path;

        public BuildDefinition(string id, string category, int width, int depth, long cost, bool path = false)
        {
            Id = id;
            Category = category;
            Width = width;
            Depth = depth;
            Cost = cost;
            Path = path;
        }
    }

    [Serializable]
    public sealed class BuildRecord
    {
        public string id, definition;
        public int x, z, rotation;
    }

    [Serializable]
    public sealed class ParkSnapshot
    {
        public int version;
        public long funds;
        public BuildRecord[] pieces;
    }

    public sealed class ParkLayout
    {
        private static readonly (int x, int z)[] Directions = { (1, 0), (-1, 0), (0, 1), (0, -1) };
        private static readonly (int x, int z) Entrance = (0, -8);
        private readonly Dictionary<string, BuildDefinition> catalog = new Dictionary<string, BuildDefinition>();
        private readonly Dictionary<string, BuildRecord> pieces = new Dictionary<string, BuildRecord>();
        private readonly Dictionary<(int, int), BuildRecord> occupied = new Dictionary<(int, int), BuildRecord>();
        private readonly Func<int, int, bool> suitable;
        private readonly HashSet<string> unlocked;
        public long Funds { get; private set; }
        public event Action Changed;

        public ParkLayout(IEnumerable<BuildDefinition> definitions, IEnumerable<string> available, long funds, Func<int, int, bool> suitable)
        {
            foreach (var definition in definitions)
                catalog.Add(definition.Id, definition);
            unlocked = new HashSet<string>(available);
            Funds = funds;
            this.suitable = suitable;
        }

        public BuildRecord At(int x, int z) => occupied.TryGetValue((x, z), out var piece) ? Copy(piece) : null;

        public string Validate(BuildDefinition definition, int x, int z, int rotation, string moving = null)
        {
            if (!catalog.TryGetValue(definition.Id, out var registered) || !ReferenceEquals(definition, registered) || !unlocked.Contains(definition.Id))
                return "Locked item";
            if (moving != null && (!pieces.TryGetValue(moving, out var original) || original.definition != definition.Id))
                return "Unknown structure";
            if (moving == null && Funds < definition.Cost)
                return "Insufficient funds";
            if (x < -11 || x > 10 || z < -9 || z > 8 || rotation < 0 || rotation > 3)
                return "Outside the park";

            var candidate = new BuildRecord { id = moving, definition = definition.Id, x = x, z = z, rotation = rotation };
            foreach (var cell in Cells(candidate))
            {
                if (cell.x < -11 || cell.x > 10 || cell.z < -9 || cell.z > 8 || !suitable(cell.x, cell.z))
                    return "Unsuitable ground or clearance";
                if (cell == Entrance || (occupied.TryGetValue(cell, out var other) && other.id != moving))
                    return "Occupied";
            }

            return IsConnected(moving, candidate) ? null : "Connect to the entrance path";
        }

        public string Place(BuildDefinition definition, int x, int z, int rotation, string moving = null)
        {
            var error = Validate(definition, x, z, rotation, moving);
            if (error != null)
                return error;
            if (moving != null)
                RemoveRecord(pieces[moving]);
            else
                Funds -= definition.Cost;

            AddRecord(new BuildRecord { id = moving ?? Guid.NewGuid().ToString("N"), definition = definition.Id, x = x, z = z, rotation = rotation });
            Changed?.Invoke();
            return null;
        }

        public string Remove(string id)
        {
            if (!pieces.TryGetValue(id, out var piece))
                return "Unknown structure";
            if (!IsConnected(id, null))
                return "Removal would disconnect the park";
            RemoveRecord(piece);
            Changed?.Invoke();
            return null;
        }

        public ParkSnapshot Snapshot()
        {
            var records = new BuildRecord[pieces.Count];
            int index = 0;
            foreach (var piece in pieces.Values)
                records[index++] = Copy(piece);
            return new ParkSnapshot { version = 1, funds = Funds, pieces = records };
        }

        public bool Restore(ParkSnapshot snapshot)
        {
            if (snapshot == null || snapshot.version != 1 || snapshot.funds < 0 || snapshot.pieces == null || snapshot.pieces.Length > 396)
                return false;

            var staged = new ParkLayout(catalog.Values, unlocked, snapshot.funds, suitable);
            foreach (var piece in snapshot.pieces)
            {
                if (piece == null || !Guid.TryParseExact(piece.id, "N", out _) || staged.pieces.ContainsKey(piece.id) ||
                    piece.definition == null || !catalog.ContainsKey(piece.definition) || !unlocked.Contains(piece.definition) ||
                    piece.rotation < 0 || piece.rotation > 3 || piece.x < -11 || piece.x > 10 || piece.z < -9 || piece.z > 8)
                    return false;
                foreach (var cell in staged.Cells(piece))
                    if (cell == Entrance || cell.x > 10 || cell.z > 8 || !suitable(cell.x, cell.z) || staged.occupied.ContainsKey(cell))
                        return false;
                staged.AddRecord(Copy(piece));
            }
            if (!staged.IsConnected(null, null))
                return false;

            pieces.Clear();
            occupied.Clear();
            foreach (var piece in staged.pieces.Values)
                AddRecord(piece);
            Funds = staged.Funds;
            Changed?.Invoke();
            return true;
        }

        private bool IsConnected(string ignored, BuildRecord proposed)
        {
            var paths = new HashSet<(int, int)> { Entrance };
            var buildings = new List<BuildRecord>();
            foreach (var piece in pieces.Values)
                if (ignored == null || piece.id != ignored)
                    Collect(piece);
            if (proposed != null)
                Collect(proposed);
            var reachable = new HashSet<(int, int)> { Entrance };
            var pending = new Queue<(int x, int z)>();
            pending.Enqueue(Entrance);
            while (pending.Count != 0)
            {
                var cell = pending.Dequeue();
                foreach (var direction in Directions)
                {
                    var next = (cell.x + direction.x, cell.z + direction.z);
                    if (paths.Contains(next) && reachable.Add(next))
                        pending.Enqueue(next);
                }
            }
            if (reachable.Count != paths.Count)
                return false;
            foreach (var building in buildings)
                if (!reachable.Contains(AccessCell(building)))
                    return false;
            return true;

            void Collect(BuildRecord piece)
            {
                if (catalog[piece.definition].Path)
                    paths.UnionWith(Cells(piece));
                else
                    buildings.Add(piece);
            }
        }

        private (int, int) AccessCell(BuildRecord piece)
        {
            var definition = catalog[piece.definition];
            switch (piece.rotation)
            {
                case 0: return (piece.x, piece.z - 1);
                case 1: return (piece.x - 1, piece.z);
                case 2: return (piece.x, piece.z + definition.Depth);
                default: return (piece.x + definition.Depth, piece.z);
            }
        }

        private IEnumerable<(int x, int z)> Cells(BuildRecord piece)
        {
            var definition = catalog[piece.definition];
            bool sideways = piece.rotation % 2 != 0;
            int width = sideways ? definition.Depth : definition.Width;
            int depth = sideways ? definition.Width : definition.Depth;
            for (int x = piece.x; x < piece.x + width; x++)
                for (int z = piece.z; z < piece.z + depth; z++)
                    yield return (x, z);
        }

        private void AddRecord(BuildRecord piece)
        {
            pieces.Add(piece.id, piece);
            foreach (var cell in Cells(piece))
                occupied.Add(cell, piece);
        }

        private void RemoveRecord(BuildRecord piece)
        {
            pieces.Remove(piece.id);
            foreach (var cell in Cells(piece))
                occupied.Remove(cell);
        }

        private static BuildRecord Copy(BuildRecord piece) => new BuildRecord
        {
            id = piece.id, definition = piece.definition, x = piece.x, z = piece.z, rotation = piece.rotation
        };
    }
}
