using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestRemoveTransition : redEvent
	{
		[Ordinal(0)] 
		[RED("removeTransitionFrom")] 
		public CInt32 RemoveTransitionFrom
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
