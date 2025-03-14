using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingMachineInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("ActionsPanel")] 
		public inkHorizontalPanelWidgetReference ActionsPanel
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("noMoneyPanel")] 
		public inkCompoundWidgetReference NoMoneyPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("soldOutPanel")] 
		public inkCompoundWidgetReference SoldOutPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("state")] 
		public CEnum<PaymentStatus> State
		{
			get => GetPropertyValue<CEnum<PaymentStatus>>();
			set => SetPropertyValue<CEnum<PaymentStatus>>(value);
		}

		[Ordinal(21)] 
		[RED("soldOut")] 
		public CBool SoldOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("onUpdateStatusListener")] 
		public CHandle<redCallbackObject> OnUpdateStatusListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("onSoldOutListener")] 
		public CHandle<redCallbackObject> OnSoldOutListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public VendingMachineInkGameController()
		{
			ActionsPanel = new();
			PriceText = new();
			NoMoneyPanel = new();
			SoldOutPanel = new();
		}
	}
}
