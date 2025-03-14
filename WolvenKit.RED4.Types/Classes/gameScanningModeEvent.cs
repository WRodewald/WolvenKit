using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningModeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<gameScanningMode> Mode
		{
			get => GetPropertyValue<CEnum<gameScanningMode>>();
			set => SetPropertyValue<CEnum<gameScanningMode>>(value);
		}
	}
}
