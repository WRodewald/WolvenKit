using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetReference : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}
	}
}
