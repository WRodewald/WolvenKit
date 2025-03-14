using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlideEvents : CrouchEvents
	{
		[Ordinal(3)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("addDecelerationModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AddDecelerationModifier
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}
	}
}
