using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;

namespace LivingPark.XR
{
    public sealed class ParkFoundation : MonoBehaviour
    {
        private readonly InputActionMap controls = new InputActionMap("Park");
        private XROrigin origin;
        private ParkTeleportProvider teleport;
        private ParkSnapTurnProvider snapTurn;
        private Transform park;
        private Transform tableAnchor;
        private Transform miniature;
        private ParkBlockout blockout;
        private ParkConstruction construction;
        private XRRayInteractor rightRay;
        private InputAction catalogAction, toolAction, rotateAction;
        private Material aimMaterial;
        private GameObject rig;
        private InputAction modeAction, postureAction, panAction, scaleAction, turnAction, enterAction;
        private Vector3 visitorDestination = new Vector3(0f, 0f, -7f);
        private Vector3 tablePan;
        private float tableScale = 0.085f;
        private float tableYaw;
        private bool architect;
        private bool seated;
        private bool hasSelection;
        private GameObject selectionMarker;

        private void Awake()
        {
            var manager = Child(transform, "Interaction Manager").gameObject.AddComponent<XRInteractionManager>();
            aimMaterial = new Material(Shader.Find("Universal Render Pipeline/Unlit"));
            rig = new GameObject("XR Origin");
            rig.SetActive(false);
            rig.transform.position = visitorDestination;
            origin = rig.AddComponent<XROrigin>();
            var offset = Child(rig.transform, "Camera Floor Offset");
            var head = Child(offset, "Tracked Head");
            head.localPosition = Vector3.up * 1.65f;
            head.gameObject.tag = "MainCamera";
            head.gameObject.AddComponent<AudioListener>();
            var camera = head.gameObject.AddComponent<Camera>();
            camera.nearClipPlane = 0.045f;
            camera.farClipPlane = 120f;
            camera.backgroundColor = new Color(0.56f, 0.72f, 0.79f);
            camera.clearFlags = CameraClearFlags.SolidColor;
            origin.Origin = rig;
            origin.Camera = camera;
            origin.CameraFloorOffsetObject = offset.gameObject;
            origin.CameraYOffset = 1.65f;
            origin.RequestedTrackingOriginMode = XROrigin.TrackingOriginMode.Floor;
            Track(head, "<XRHMD>");
            Controller(offset, manager, "LeftHand");
            rightRay = Controller(offset, manager, "RightHand");

            rig.AddComponent<XRBodyTransformer>().xrOrigin = origin;
            var mediator = rig.AddComponent<LocomotionMediator>();
            teleport = rig.AddComponent<ParkTeleportProvider>();
            teleport.mediator = mediator;
            snapTurn = rig.AddComponent<ParkSnapTurnProvider>();
            snapTurn.mediator = mediator;
            snapTurn.turnAmount = 30f;
            snapTurn.debounceTime = 0f;
            turnAction = Action("Turn", InputActionType.Value, "<XRController>{RightHand}/primary2DAxis");
            snapTurn.rightHandTurnInput.inputSourceMode = XRInputValueReader<Vector2>.InputSourceMode.InputAction;
            snapTurn.rightHandTurnInput.inputAction = turnAction;
            panAction = Action("Pan", InputActionType.Value, "<XRController>{LeftHand}/primary2DAxis");
            modeAction = Action("Mode", InputActionType.Button, "<XRController>{LeftHand}/primaryButton", "<Keyboard>/tab");
            postureAction = Action("Posture", InputActionType.Button, "<XRController>{LeftHand}/secondaryButton", "<Keyboard>/c");
            scaleAction = Action("Scale", InputActionType.Button, "<XRController>{RightHand}/secondaryButton", "<Keyboard>/equals");
            enterAction = Action("Enter Park", InputActionType.Button, "<XRController>{RightHand}/primaryButton", "<Keyboard>/enter");
            catalogAction = Action("Construction catalog", InputActionType.Button, "<XRController>{RightHand}/primary2DAxisClick", "<Keyboard>/b");
            toolAction = Action("Construction tool", InputActionType.Button, "<XRController>{LeftHand}/primary2DAxisClick", "<Keyboard>/v");
            rotateAction = Action("Rotate placement", InputActionType.Button, "<XRController>{RightHand}/gripPressed", "<Keyboard>/r");
            BuildPark(manager);
            rig.SetActive(true);
        }

        private void OnEnable() => controls.Enable();
        private void OnDisable() => controls.Disable();
        private void OnDestroy()
        {
            controls.Dispose();
            construction?.Dispose();
            blockout?.Dispose();
            Destroy(aimMaterial);
            Destroy(rig);
        }

        private void Update()
        {
            if (postureAction.WasPressedThisFrame())
            {
                seated = !seated;
                origin.RequestedTrackingOriginMode = seated
                    ? XROrigin.TrackingOriginMode.Device
                    : XROrigin.TrackingOriginMode.Floor;
            }

            if (modeAction.WasPressedThisFrame())
                SetArchitect(!architect);
            else if (architect && hasSelection && enterAction.WasPressedThisFrame())
                SetArchitect(false);

            if (!architect)
                return;

            if (scaleAction.WasPressedThisFrame())
                tableScale = tableScale >= 0.105f ? 0.065f : tableScale + 0.02f;

            var pan = panAction.ReadValue<Vector2>();
            var view = origin.Camera.transform;
            Vector3 right = Vector3.ProjectOnPlane(view.right, Vector3.up).normalized;
            Vector3 forward = Vector3.Cross(right, Vector3.up);
            tablePan = Vector3.ClampMagnitude(tablePan + (right * pan.x + forward * pan.y) * (Time.deltaTime * 0.5f), 0.65f);
            tableYaw += turnAction.ReadValue<Vector2>().x * 55f * Time.deltaTime;
            miniature.localPosition = tablePan;
            miniature.localRotation = Quaternion.Euler(0f, tableYaw, 0f);
            miniature.localScale = Vector3.one * tableScale;
            if (catalogAction.WasPressedThisFrame())
                construction.Next();
            if (toolAction.WasPressedThisFrame())
                construction.NextMode();
            if (rotateAction.WasPressedThisFrame())
                construction.Rotate();
            construction.UpdatePreview(rightRay);
        }

        private void BuildPark(XRInteractionManager manager)
        {
            blockout = new ParkBlockout();
            park = Child(transform, "Visitor Park");
            tableAnchor = Child(transform, "Table Anchor");
            miniature = Child(tableAnchor, "Architect Park");
            miniature.localScale = Vector3.one * tableScale;
            var floor = blockout.Build(park);
            var area = floor.gameObject.AddComponent<ParkTeleportArea>();
            area.interactionManager = manager;
            area.teleportationProvider = teleport;
            area.teleportTrigger = BaseTeleportationInteractable.TeleportTrigger.OnSelectEntered;
            area.CanStand = world => CanLand(ParkSpace.ToParkPoint(park, world));
            area.teleporting.AddListener(args =>
                visitorDestination = ParkSpace.ToParkPoint(park, args.teleportRequest.destinationPosition));
            var tableFloor = blockout.Build(miniature);
            construction = new ParkConstruction(park, miniature, origin.Camera.transform, (x, z) => blockout.CanBuild(x, z));
            var selector = tableFloor.gameObject.AddComponent<XRSimpleInteractable>();
            selector.interactionManager = manager;
            selector.selectEntered.AddListener(args =>
            {
                if (args.interactorObject is XRRayInteractor ray && ray.TryGetCurrent3DRaycastHit(out var hit))
                {
                    var point = ParkSpace.ToParkPoint(miniature, hit.point);
                    if (ray == rightRay)
                        construction.Select(point);
                    else
                        SelectDestination(point);
                }
            });
            selectionMarker = blockout.Marker(miniature);
            selectionMarker.SetActive(false);
            tableAnchor.gameObject.SetActive(false);

            var sun = Child(transform, "Sun").gameObject.AddComponent<Light>();
            sun.type = LightType.Directional;
            sun.intensity = 1.2f;
            sun.transform.rotation = Quaternion.Euler(47f, -28f, 0f);
            RenderSettings.ambientLight = new Color(0.58f, 0.61f, 0.66f);
        }

        private void SelectDestination(Vector3 point)
        {
            if (!CanLand(point))
                return;

            hasSelection = true;
            visitorDestination = point;
            selectionMarker.transform.localPosition = point + Vector3.up * 0.12f;
            selectionMarker.SetActive(true);
        }

        private bool CanLand(Vector3 point) => blockout.CanStand(point) && construction.CanLand(point);

        private void SetArchitect(bool enabled)
        {
            if (architect == enabled || teleport.IsBusy || snapTurn.isLocomotionActive)
                return;

            if (enabled)
            {
                Vector3 forward = Vector3.ProjectOnPlane(origin.Camera.transform.forward, Vector3.up).normalized;
                if (forward.sqrMagnitude < 0.1f)
                    forward = origin.transform.forward;
                tableAnchor.position = origin.Camera.transform.position + forward * 1.65f - Vector3.up * 0.67f;
                selectionMarker.SetActive(false);
                hasSelection = false;
            }
            else
            {
                var destination = CanLand(visitorDestination) ? visitorDestination : new Vector3(0f, 0f, -8f);
                origin.transform.position = ParkSpace.FeetAt(park.TransformPoint(destination), origin.Camera.transform.position, origin.transform.position);
            }

            architect = enabled;
            construction.SetActive(enabled);
            park.gameObject.SetActive(!enabled);
            tableAnchor.gameObject.SetActive(enabled);
            snapTurn.enabled = !enabled;
        }

        private XRRayInteractor Controller(Transform parent, XRInteractionManager manager, string hand)
        {
            var controller = Child(parent, hand);
            var device = "<XRController>{" + hand + "}";
            Track(controller, device, "devicePosition", "deviceRotation");
            var ray = controller.gameObject.AddComponent<XRRayInteractor>();
            ray.interactionManager = manager;
            ray.enableUIInteraction = false;
            ray.selectActionTrigger = XRBaseInputInteractor.InputTriggerType.StateChange;
            ray.maxRaycastDistance = 16f;
            ray.hitClosestOnly = true;
            ray.selectInput.inputSourceMode = XRInputButtonReader.InputSourceMode.InputAction;
            ray.selectInput.inputActionPerformed = Action(hand + " Select", InputActionType.Button, device + "/triggerPressed");
            ray.selectInput.inputActionValue = ray.selectInput.inputActionPerformed;
            var line = controller.gameObject.AddComponent<LineRenderer>();
            line.sharedMaterial = aimMaterial;
            var visual = controller.gameObject.AddComponent<XRInteractorLineVisual>();
            var tracked = Action(hand + " Tracked", InputActionType.Button, device + "/isTracked");
            ray.enabled = false;
            visual.enabled = false;
            tracked.wantsInitialStateCheck = true;
            tracked.performed += _ =>
            {
                ray.enabled = true;
                visual.enabled = true;
            };
            tracked.canceled += _ =>
            {
                visual.enabled = false;
                ray.enabled = false;
            };
            return ray;
        }

        private void Track(Transform target, string device, string position = "centerEyePosition", string rotation = "centerEyeRotation")
        {
            var driver = target.gameObject.AddComponent<TrackedPoseDriver>();
            driver.positionInput = new InputActionProperty(Action(target.name + " Position", InputActionType.PassThrough, device + "/" + position));
            driver.rotationInput = new InputActionProperty(Action(target.name + " Rotation", InputActionType.PassThrough, device + "/" + rotation));
            driver.trackingStateInput = new InputActionProperty(Action(target.name + " Tracking", InputActionType.PassThrough, device + "/trackingState"));
        }

        private InputAction Action(string name, InputActionType type, string binding, string alternate = null)
        {
            var action = controls.AddAction(name, type, binding);
            if (alternate != null)
                action.AddBinding(alternate);
            return action;
        }

        private static Transform Child(Transform parent, string name)
        {
            var child = new GameObject(name).transform;
            child.SetParent(parent, false);
            return child;
        }
    }
}
