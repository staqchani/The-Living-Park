using System;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using LivingPark.Construction;

namespace LivingPark.XR
{
    internal sealed class ParkConstruction : IDisposable
    {
        private static readonly BuildDefinition[] Catalog =
        {
            new BuildDefinition("Standard path", "Paths", 1, 1, 500, true),
            new BuildDefinition("Wide path", "Paths", 2, 1, 900, true),
            new BuildDefinition("Queue path", "Paths", 1, 1, 650, true),
            new BuildDefinition("Carousel", "Attractions", 3, 3, 42000),
            new BuildDefinition("Snack kiosk", "Shops", 2, 2, 12000),
            new BuildDefinition("Restrooms", "Facilities", 2, 2, 9500),
            new BuildDefinition("Planter", "Decorations", 1, 1, 1600),
            new BuildDefinition("Service cabinet", "Utilities", 1, 1, 2500),
            new BuildDefinition("Staff office", "Staff Buildings", 2, 2, 10000),
            new BuildDefinition("Garden", "Landscaping", 2, 1, 3300),
            new BuildDefinition("Pavilion", "Themed Structures", 2, 2, 12500)
        };

        private readonly ParkLayout layout;
        private readonly Transform miniature, head;
        private readonly GameObject ghost;
        private readonly Material valid, invalid, path, building;
        private readonly TextMesh label;
        private readonly Transform fullPieces, tablePieces;
        private readonly string savePath;
        private int item, rotation;
        private bool active, saveProtected;
        private enum EditMode { Build, Delete, Relocate }
        private EditMode mode;
        private string pendingDelete, moving;
        private string status = "";
        private BuildDefinition Item => Catalog[item];

        public ParkConstruction(Transform full, Transform miniature, Transform head, Func<int, int, bool> suitable)
        {
            this.miniature = miniature;
            this.head = head;
            var ids = Array.ConvertAll(Catalog, definition => definition.Id);
            layout = new ParkLayout(Catalog, ids, 125000, suitable);
            fullPieces = Group(full, "Park construction");
            tablePieces = Group(miniature, "Construction miniature");
            valid = Paint(new Color(0.15f, 0.9f, 0.7f));
            invalid = Paint(new Color(1f, 0.28f, 0.2f));
            path = Paint(new Color(0.83f, 0.72f, 0.50f));
            building = Paint(new Color(0.27f, 0.48f, 0.66f));
            ghost = Cube(miniature, "Placement preview", valid);
            label = Group(miniature.parent, "Construction instructions").gameObject.AddComponent<TextMesh>();
            label.transform.localPosition = new Vector3(0f, 0.22f, 0f);
            label.anchor = TextAnchor.MiddleCenter;
            label.alignment = TextAlignment.Center;
            label.characterSize = 0.024f;
            label.fontSize = 48;
            savePath = Path.Combine(Application.persistentDataPath, "park-layout.json");
            layout.Changed += Refresh;
            Load();
            SetActive(false);
        }

        public bool CanLand(Vector3 point)
        {
            var record = layout.At(Cell(point.x), Cell(point.z));
            return record == null || Definition(record.definition).Path;
        }

        public void SetActive(bool enabled)
        {
            active = enabled;
            pendingDelete = moving = null;
            mode = EditMode.Build;
            label.gameObject.SetActive(enabled);
            ghost.SetActive(false);
        }

        public void Next()
        {
            if (active && mode == EditMode.Build)
                item = (item + 1) % Catalog.Length;
        }

        public void Rotate()
        {
            if (active)
                rotation = (rotation + 1) % 4;
        }

        public void NextMode()
        {
            if (!active)
                return;
            mode = (EditMode)(((int)mode + 1) % 3);
            pendingDelete = moving = null;
            status = "";
        }

        public void UpdatePreview(XRRayInteractor ray)
        {
            if (!active)
                return;
            label.transform.rotation = Quaternion.LookRotation(label.transform.position - head.position, Vector3.up);

            bool aiming = TryAim(ray, out int x, out int z);
            bool placing = mode == EditMode.Build || moving != null;
            ghost.SetActive(aiming && placing);
            string error = null;
            if (aiming && placing)
            {
                Position(ghost, Item, x, z, rotation, 0.09f);
                error = layout.Validate(Item, x, z, rotation, moving);
                ghost.GetComponent<Renderer>().sharedMaterial = error == null ? valid : invalid;
            }

            label.text = $"Funds {layout.Funds / 100m:0.00}\n" +
                (placing ? $"{Item.Category} / {Item.Id}   {(moving == null ? Item.Cost / 100m : 0):0.00}" :
                    mode == EditMode.Delete ? "Delete / select a structure twice" : "Relocate / select a structure") +
                $"\n{error ?? status}\nRight trigger: build/select  |  Right grip: rotate\nRight stick click: catalog  |  Left stick click: tool";
        }

        public void Select(Vector3 point)
        {
            if (!active)
                return;
            int x = Cell(point.x), z = Cell(point.z);
            var existing = layout.At(x, z);
            if (mode == EditMode.Delete)
            {
                if (existing == null)
                {
                    pendingDelete = null;
                    status = "Aim at a structure";
                }
                else if (pendingDelete != existing.id)
                {
                    pendingDelete = existing.id;
                    status = "Select again to delete";
                }
                else
                {
                    status = layout.Remove(existing.id) ?? Save("Removed");
                    pendingDelete = null;
                }
                return;
            }
            if (mode == EditMode.Relocate && moving == null)
            {
                if (existing == null)
                {
                    status = "Aim at a structure";
                    return;
                }
                moving = existing.id;
                item = Array.FindIndex(Catalog, definition => definition.Id == existing.definition);
                rotation = existing.rotation;
                status = "Choose a new location";
                return;
            }

            var error = layout.Place(Item, x, z, rotation, moving);
            status = error ?? Save("Placed");
            if (error == null)
                moving = null;
        }

        private bool TryAim(XRRayInteractor ray, out int x, out int z)
        {
            x = z = 0;
            if (ray == null || !ray.isActiveAndEnabled || !ray.TryGetCurrent3DRaycastHit(out var hit) ||
                !hit.collider.transform.IsChildOf(miniature))
                return false;
            var point = miniature.InverseTransformPoint(hit.point);
            x = Cell(point.x);
            z = Cell(point.z);
            return true;
        }

        private void Refresh()
        {
            Clear(fullPieces);
            Clear(tablePieces);
            foreach (var record in layout.Snapshot().pieces)
            {
                var definition = Definition(record.definition);
                Draw(fullPieces, record, definition);
                Draw(tablePieces, record, definition);
            }
        }

        private void Draw(Transform parent, BuildRecord record, BuildDefinition definition)
        {
            var cube = Cube(parent, definition.Id, definition.Path ? path : building);
            Position(cube, definition, record.x, record.z, record.rotation, 0.02f);
        }

        private static void Position(GameObject cube, BuildDefinition definition, int x, int z, int rotation, float lift)
        {
            bool sideways = (rotation & 1) != 0;
            int width = sideways ? definition.Depth : definition.Width;
            int depth = sideways ? definition.Width : definition.Depth;
            float height = definition.Path ? 0.06f : 1.4f;
            cube.transform.localPosition = new Vector3(x + (width - 1) / 2f, height / 2f + lift, z + (depth - 1) / 2f);
            cube.transform.localRotation = Quaternion.Euler(0, rotation * 90, 0);
            cube.transform.localScale = new Vector3(definition.Width - 0.035f, height, definition.Depth - 0.035f);
        }

        private void Load()
        {
            foreach (var candidate in new[] { savePath, savePath + ".bak" })
            {
                try
                {
                    if (!File.Exists(candidate))
                        continue;
                    var snapshot = JsonUtility.FromJson<ParkSnapshot>(File.ReadAllText(candidate));
                    if (snapshot != null && snapshot.version > 1)
                    {
                        saveProtected = true;
                        status = "Save belongs to a newer version";
                        return;
                    }
                    if (layout.Restore(snapshot))
                        return;
                }
                catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException || exception is ArgumentException)
                {
                    Debug.LogWarning($"Park save could not be loaded: {exception.Message}");
                }
            }
        }

        private string Save(string success)
        {
            if (saveProtected)
                return success + " / newer save protected";
            string temporary = savePath + ".tmp";
            try
            {
                File.WriteAllText(temporary, JsonUtility.ToJson(layout.Snapshot()));
                if (File.Exists(savePath))
                    File.Replace(temporary, savePath, savePath + ".bak");
                else
                    File.Move(temporary, savePath);
                return success;
            }
            catch (Exception exception) when (exception is IOException || exception is UnauthorizedAccessException)
            {
                Debug.LogWarning($"Park save could not be written: {exception.Message}");
                return success + " / save failed";
            }
        }

        public void Dispose()
        {
            foreach (var material in new[] { valid, invalid, path, building })
                UnityEngine.Object.Destroy(material);
        }

        private static BuildDefinition Definition(string id) => Array.Find(Catalog, item => item.Id == id);
        private static int Cell(float position) => Mathf.FloorToInt(position + 0.5f);

        private static void Clear(Transform parent)
        {
            foreach (Transform child in parent)
            {
                child.gameObject.SetActive(false);
                UnityEngine.Object.Destroy(child.gameObject);
            }
        }

        private static Transform Group(Transform parent, string name)
        {
            var child = new GameObject(name).transform;
            child.SetParent(parent, false);
            return child;
        }

        private static Material Paint(Color color) => new Material(Shader.Find("Universal Render Pipeline/Unlit")) { color = color };

        private static GameObject Cube(Transform parent, string name, Material material)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.name = name;
            cube.transform.SetParent(parent, false);
            cube.GetComponent<Collider>().enabled = false;
            cube.GetComponent<Renderer>().sharedMaterial = material;
            return cube;
        }
    }
}
