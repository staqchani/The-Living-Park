using UnityEngine;

namespace LivingPark.XR
{
    public sealed class StickSnapGate
    {
        private bool latched;

        public float Filter(Vector2 stick)
        {
            if (stick.sqrMagnitude < 0.25f * 0.25f)
                latched = false;

            if (latched || Mathf.Abs(stick.x) < 0.65f || Mathf.Abs(stick.x) <= Mathf.Abs(stick.y))
                return 0f;

            latched = true;
            return Mathf.Sign(stick.x);
        }
    }
}
