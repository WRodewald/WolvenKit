using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerWeaponDetailed : ScannerWeaponBasic
	{
		[Ordinal(1)] 
		[RED("damage")] 
		public CName Damage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
