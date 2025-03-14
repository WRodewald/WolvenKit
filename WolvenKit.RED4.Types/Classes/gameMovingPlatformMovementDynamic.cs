using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMovingPlatformMovementDynamic : gameIMovingPlatformMovementPointToPoint
	{
		[Ordinal(1)] 
		[RED("curveName")] 
		public CName CurveName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameMovingPlatformMovementDynamic()
		{
			InitData = new();
		}
	}
}
