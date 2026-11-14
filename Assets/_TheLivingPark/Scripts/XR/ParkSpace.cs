using UnityEngine;

namespace LivingPark.XR
{
    // One coordinate space serves both the visitor park and its tabletop projection.
    public static class ParkSpace
    {
        public static Vector3 ToParkPoint(Transform view, Vector3 worldPoint)
        {
            var point = view.InverseTransformPoint(worldPoint);
            return new Vector3(point.x, 0f, point.z);
        }

        public static bool IsInside(Vector3 point)
        {
            return Mathf.Abs(point.x) < 11.5f && Mathf.Abs(point.z) < 9.5f;
        }

        public static Vector3 FeetAt(Vector3 ground, Vector3 camera, Vector3 origin)
        {
            return ground - Vector3.ProjectOnPlane(camera - origin, Vector3.up);
        }
    }
}
