using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

namespace LivingPark.XR
{
    internal sealed class ParkTeleportProvider : TeleportationProvider
    {
        public bool IsBusy => validRequest || isLocomotionActive;
    }
}
