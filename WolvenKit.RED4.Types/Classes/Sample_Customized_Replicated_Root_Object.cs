using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Customized_Replicated_Root_Object : Sample_Replicated_Root_Object
	{
		[Ordinal(1)] 
		[RED("bool2")] 
		public CBool Bool2
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
