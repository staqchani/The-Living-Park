using System;
using UnityEngine;

namespace LivingPark.XR
{
    internal sealed class ParkBlockout : IDisposable
    {
        private readonly Material grass = Paint(0.26f, 0.43f, 0.29f);
        private readonly Material paving = Paint(0.73f, 0.62f, 0.45f);
        private readonly Material roof = Paint(0.67f, 0.20f, 0.13f);
        private readonly Material timber = Paint(0.31f, 0.21f, 0.14f);
        private readonly Material leaves = Paint(0.18f, 0.34f, 0.27f);
        private readonly Material marker = Paint(1f, 0.78f, 0.15f);

        public bool CanStand(Vector3 point)
        {
            if (!ParkSpace.IsInside(point))
                return false;

            float x = Mathf.Abs(point.x);
            if (Mathf.Abs(x - 5.5f) < 1.55f && Mathf.Abs(point.z - 4.5f) < 1.4f)
                return false;
            if (Mathf.Abs(x - 2.3f) < 0.65f && Mathf.Abs(point.z + 8.5f) < 0.65f)
                return false;
            if (Mathf.Abs(x - 9f) < 0.6f)
                for (int row = 0; row < 4; row++)
                    if (Mathf.Abs(point.z - (-6f + 4f * row)) < 0.6f)
                        return false;

            return true;
        }

        public bool CanBuild(int x, int z)
        {
            float side = Mathf.Abs(x);
            if (Mathf.Abs(side - 5.5f) < 2.15f && Mathf.Abs(z - 4.5f) < 2f)
                return false;
            if (Mathf.Abs(side - 2.3f) < 1f && Mathf.Abs(z + 8.5f) < 1f)
                return false;
            if (Mathf.Abs(side - 9f) < 1.5f)
                for (int row = 0; row < 4; row++)
                    if (Mathf.Abs(z - (-6 + 4 * row)) < 1.5f)
                        return false;
            return true;
        }

        public Collider Build(Transform parent)
        {
            var ground = Box(parent, "Walkable park ground", new Vector3(0, -0.2f, 0), new Vector3(24, 0.4f, 20), grass);
            Box(parent, "Promenade", new Vector3(0, -0.01f, 0), new Vector3(4, 0.02f, 19), paving, false);
            Box(parent, "Plaza", new Vector3(0, -0.008f, 2), new Vector3(14, 0.016f, 4), paving, false);
            for (int side = -1; side <= 1; side += 2)
            {
                Box(parent, "Gate post", new Vector3(side * 2.3f, 1.5f, -8.5f), new Vector3(0.55f, 3, 0.55f), timber);
                Box(parent, "Kiosk", new Vector3(side * 5.5f, 1f, 4.5f), new Vector3(2.4f, 2, 2.1f), timber);
                Box(parent, "Kiosk awning", new Vector3(side * 5.5f, 2.18f, 4.5f), new Vector3(3, 0.35f, 2.7f), roof);
                for (int row = 0; row < 4; row++)
                {
                    float z = -6 + 4 * row;
                    Box(parent, "Tree trunk", new Vector3(side * 9, 1, z), new Vector3(0.35f, 2, 0.35f), timber);
                    Box(parent, "Tree crown", new Vector3(side * 9, 2.3f, z), new Vector3(1.7f, 1.8f, 1.7f), leaves);
                }
            }
            Box(parent, "Entrance arch", new Vector3(0, 3.15f, -8.5f), new Vector3(5.2f, 0.45f, 0.65f), roof);
            return ground.GetComponent<Collider>();
        }

        public GameObject Marker(Transform parent) =>
            Box(parent, "Selected visitor destination", new Vector3(0, 0.12f, 0), new Vector3(0.55f, 0.24f, 0.55f), marker, false);

        public void Dispose()
        {
            foreach (var material in new[] { grass, paving, roof, timber, leaves, marker })
                UnityEngine.Object.Destroy(material);
        }

        private static Material Paint(float red, float green, float blue) =>
            new Material(Shader.Find("Universal Render Pipeline/Lit")) { color = new Color(red, green, blue) };

        private static GameObject Box(Transform parent, string name, Vector3 position, Vector3 scale, Material material, bool solid = true)
        {
            var box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.name = name;
            box.transform.SetParent(parent, false);
            box.transform.localPosition = position;
            box.transform.localScale = scale;
            box.GetComponent<Renderer>().sharedMaterial = material;
            box.GetComponent<Collider>().enabled = solid;
            return box;
        }
    }
}
