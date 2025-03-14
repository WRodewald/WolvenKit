using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestroyWeakspotEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("weakspotIndex")] 
		public CInt32 WeakspotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
