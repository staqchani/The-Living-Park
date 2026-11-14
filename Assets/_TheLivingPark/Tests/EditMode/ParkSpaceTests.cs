using NUnit.Framework;
using UnityEngine;

namespace LivingPark.XR.Tests
{
    public sealed class ParkSpaceTests
    {
        [Test]
        public void MiniatureSelectionRecoversParkCoordinates()
        {
            var tabletop = new GameObject("Tabletop");
            try
            {
                tabletop.transform.SetPositionAndRotation(new Vector3(3, 1, -4), Quaternion.Euler(0, 57, 0));
                tabletop.transform.localScale = Vector3.one * 0.085f;
                var parkPoint = new Vector3(4, 0, -2);
                var hit = tabletop.transform.TransformPoint(parkPoint);
                Assert.That(Vector3.Distance(ParkSpace.ToParkPoint(tabletop.transform, hit), parkPoint), Is.LessThan(0.001f));
            }
            finally
            {
                Object.DestroyImmediate(tabletop);
            }
        }

        [Test]
        public void DestinationPreservesTrackingHeightAndCentersThePlayer()
        {
            var currentOrigin = new Vector3(2, 0, -3);
            var camera = currentOrigin + new Vector3(0.25f, 1.63f, -0.5f);
            var destination = new Vector3(7, 0, 6);
            var movedOrigin = ParkSpace.FeetAt(destination, camera, currentOrigin);
            Assert.That(movedOrigin, Is.EqualTo(new Vector3(6.75f, 0f, 6.5f)));
        }

        [Test]
        public void SnapTurnRequiresNeutralBetweenTurns()
        {
            var gate = new StickSnapGate();
            Assert.That(gate.Filter(new Vector2(1f, 0f)), Is.EqualTo(1f));
            Assert.That(gate.Filter(new Vector2(1f, 0f)), Is.Zero);
            Assert.That(gate.Filter(new Vector2(-1f, 0f)), Is.Zero);
            Assert.That(gate.Filter(new Vector2(0.2f, 0.7f)), Is.Zero);
            Assert.That(gate.Filter(new Vector2(-1f, 0f)), Is.Zero);
            Assert.That(gate.Filter(Vector2.zero), Is.Zero);
            Assert.That(gate.Filter(new Vector2(-1f, 0f)), Is.EqualTo(-1f));
        }

        [Test]
        public void SnapTurnIgnoresSmallAndVerticalInputs()
        {
            var gate = new StickSnapGate();
            Assert.That(gate.Filter(new Vector2(0.5f, 0f)), Is.Zero);
            Assert.That(gate.Filter(new Vector2(0.7f, 0.8f)), Is.Zero);
            Assert.That(gate.Filter(new Vector2(0.8f, 0.7f)), Is.EqualTo(1f));
        }

        [TestCase(0f, -7f, true)]
        [TestCase(11.5f, 0f, false)]
        [TestCase(0f, -9.5f, false)]
        public void LandingBoundsRejectEdges(float x, float z, bool valid)
        {
            Assert.That(ParkSpace.IsInside(new Vector3(x, 0f, z)), Is.EqualTo(valid));
        }
    }
}
