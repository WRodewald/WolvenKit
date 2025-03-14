using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPlayFPPControlAnimEvent : scnPlayAnimEvent
	{
		[Ordinal(15)] 
		[RED("gameplayAnimName")] 
		public CHandle<scnAnimName> GameplayAnimName
		{
			get => GetPropertyValue<CHandle<scnAnimName>>();
			set => SetPropertyValue<CHandle<scnAnimName>>(value);
		}

		[Ordinal(16)] 
		[RED("FPPControlActive")] 
		public CBool FPPControlActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("blendOverride")] 
		public CEnum<scnfppBlendOverride> BlendOverride
		{
			get => GetPropertyValue<CEnum<scnfppBlendOverride>>();
			set => SetPropertyValue<CEnum<scnfppBlendOverride>>(value);
		}

		[Ordinal(18)] 
		[RED("cameraUseTrajectorySpace")] 
		public CBool CameraUseTrajectorySpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("cameraBlendInDuration")] 
		public CFloat CameraBlendInDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("cameraBlendOutDuration")] 
		public CFloat CameraBlendOutDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("stayInScene")] 
		public CBool StayInScene
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("idleIsMountedWorkspot")] 
		public CBool IdleIsMountedWorkspot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("cameraParallaxWeight")] 
		public CFloat CameraParallaxWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("cameraParallaxSpace")] 
		public CEnum<scnfppParallaxSpace> CameraParallaxSpace
		{
			get => GetPropertyValue<CEnum<scnfppParallaxSpace>>();
			set => SetPropertyValue<CEnum<scnfppParallaxSpace>>(value);
		}

		[Ordinal(25)] 
		[RED("vehicleProceduralCameraWeight")] 
		public CFloat VehicleProceduralCameraWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("yawLimitLeft")] 
		public CFloat YawLimitLeft
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("yawLimitRight")] 
		public CFloat YawLimitRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("pitchLimitTop")] 
		public CFloat PitchLimitTop
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("pitchLimitBottom")] 
		public CFloat PitchLimitBottom
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("genderSpecificParams")] 
		public CArray<scnfppGenderSpecificParams> GenderSpecificParams
		{
			get => GetPropertyValue<CArray<scnfppGenderSpecificParams>>();
			set => SetPropertyValue<CArray<scnfppGenderSpecificParams>>(value);
		}

		public scnPlayFPPControlAnimEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Duration = 1000;
			AnimData = new() { Basic = new() { Stretch = 1.000000F, BlendInCurve = Enums.scnEasingType.SinusoidalEaseInOut, BlendOutCurve = Enums.scnEasingType.SinusoidalEaseInOut }, Weight = 1.000000F };
			Performer = new() { Id = 4294967040 };
			NeckWeight = 1.000000F;
			UpperFaceBlendAdditive = true;
			LowerFaceBlendAdditive = true;
			EyesBlendAdditive = true;
			FPPControlActive = true;
			CameraUseTrajectorySpace = true;
			CameraBlendInDuration = 0.500000F;
			CameraBlendOutDuration = 0.500000F;
			GenderSpecificParams = new();
		}
	}
}
