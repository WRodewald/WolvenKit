using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PatrolSpotAction : TweakAIActionSmartComposite
	{
		[Ordinal(38)] 
		[RED("patrolAction")] 
		public CHandle<AIArgumentMapping> PatrolAction
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
