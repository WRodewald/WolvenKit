using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SurveillanceCamera : SensorDevice
	{
		[Ordinal(192)] 
		[RED("virtualCam")] 
		public CHandle<entVirtualCameraComponent> VirtualCam
		{
			get => GetPropertyValue<CHandle<entVirtualCameraComponent>>();
			set => SetPropertyValue<CHandle<entVirtualCameraComponent>>(value);
		}

		[Ordinal(193)] 
		[RED("cameraHead")] 
		public CHandle<entIComponent> CameraHead
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(194)] 
		[RED("cameraHeadPhysics")] 
		public CHandle<entIComponent> CameraHeadPhysics
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(195)] 
		[RED("verticalDecal1")] 
		public CHandle<entIComponent> VerticalDecal1
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(196)] 
		[RED("verticalDecal2")] 
		public CHandle<entIComponent> VerticalDecal2
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(197)] 
		[RED("meshDestrSupport")] 
		public CBool MeshDestrSupport
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(198)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(199)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(200)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(201)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(202)] 
		[RED("rotateLeft")] 
		public CBool RotateLeft
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(203)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(204)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(205)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(206)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get => GetPropertyValue<CHandle<entLookAtAddEvent>>();
			set => SetPropertyValue<CHandle<entLookAtAddEvent>>(value);
		}

		[Ordinal(207)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(208)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SurveillanceCamera()
		{
			ControllerTypeName = "SurveillanceCameraController";
			IdleSound = "dev_surveillance_camera_rotating";
			IdleSoundStop = "dev_surveillance_camera_rotating_stop";
			SoundDetectionLoop = "dev_surveillance_camera_detection_loop_start";
			SoundDetectionLoopStop = "dev_surveillance_camera_detection_loop_stop";
			ShouldRotate = true;
			CanDetectIntruders = true;
			TargetPosition = new();
		}
	}
}
