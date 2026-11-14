using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

namespace LivingPark.XR
{
    internal sealed class ParkTeleportArea : TeleportationArea
    {
        public System.Predicate<Vector3> CanStand { private get; set; }

        protected override bool GenerateTeleportRequest(
            IXRInteractor interactor, RaycastHit hit, ref TeleportRequest request)
        {
            return base.GenerateTeleportRequest(interactor, hit, ref request) &&
                CanStand != null && CanStand(request.destinationPosition);
        }
    }
}
