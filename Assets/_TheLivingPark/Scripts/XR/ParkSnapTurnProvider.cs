using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Turning;

namespace LivingPark.XR
{
    internal sealed class ParkSnapTurnProvider : SnapTurnProvider
    {
        private readonly StickSnapGate stick = new StickSnapGate();

        protected override float GetTurnAmount(Vector2 input) => stick.Filter(input) * turnAmount;
    }
}
