using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerObjectAnimated : gameContainerObjectBase
	{
		[Ordinal(51)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameContainerObjectAnimated()
		{
			AnimFeatureName = "ContainerAnim";
		}
	}
}
