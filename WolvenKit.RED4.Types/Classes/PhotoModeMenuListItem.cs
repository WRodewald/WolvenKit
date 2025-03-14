using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeMenuListItem : inkListItemController
	{
		[Ordinal(16)] 
		[RED("ScrollBarRef")] 
		public inkWidgetReference ScrollBarRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("CounterLabelRef")] 
		public inkTextWidgetReference CounterLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("TextLabelRef")] 
		public inkTextWidgetReference TextLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("OptionSelectorRef")] 
		public inkWidgetReference OptionSelectorRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("LeftArrow")] 
		public inkWidgetReference LeftArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("RightArrow")] 
		public inkWidgetReference RightArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("LeftButton")] 
		public inkWidgetReference LeftButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("RightButton")] 
		public inkWidgetReference RightButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("OptionLabelRef")] 
		public inkTextWidgetReference OptionLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("SelectedWidgetRef")] 
		public inkWidgetReference SelectedWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("TextRootWidgetRef")] 
		public inkWidgetReference TextRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("SliderRootWidgetRef")] 
		public inkWidgetReference SliderRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("OptionSelectorRootWidgetRef")] 
		public inkWidgetReference OptionSelectorRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("HoldButtonRootWidgetRef")] 
		public inkWidgetReference HoldButtonRootWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("ScrollBarLineRef")] 
		public inkWidgetReference ScrollBarLineRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("ScrollBarHandleRef")] 
		public inkWidgetReference ScrollBarHandleRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("ScrollSlidingAreaRef")] 
		public inkWidgetReference ScrollSlidingAreaRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("HoldProgressRef")] 
		public inkWidgetReference HoldProgressRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("GridRoot")] 
		public inkWidgetReference GridRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("GridTopRow")] 
		public inkWidgetReference GridTopRow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("GridBottomRow")] 
		public inkWidgetReference GridBottomRow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("ScrollBar")] 
		public CWeakHandle<inkSliderController> ScrollBar
		{
			get => GetPropertyValue<CWeakHandle<inkSliderController>>();
			set => SetPropertyValue<CWeakHandle<inkSliderController>>(value);
		}

		[Ordinal(38)] 
		[RED("OptionSelector")] 
		public CWeakHandle<inkSelectorController> OptionSelector
		{
			get => GetPropertyValue<CWeakHandle<inkSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSelectorController>>(value);
		}

		[Ordinal(39)] 
		[RED("OptionSelectorValues")] 
		public CArray<gameuiPhotoModeOptionSelectorData> OptionSelectorValues
		{
			get => GetPropertyValue<CArray<gameuiPhotoModeOptionSelectorData>>();
			set => SetPropertyValue<CArray<gameuiPhotoModeOptionSelectorData>>(value);
		}

		[Ordinal(40)] 
		[RED("GridSelector")] 
		public CWeakHandle<PhotoModeGridList> GridSelector
		{
			get => GetPropertyValue<CWeakHandle<PhotoModeGridList>>();
			set => SetPropertyValue<CWeakHandle<PhotoModeGridList>>(value);
		}

		[Ordinal(41)] 
		[RED("SliderValue")] 
		public CFloat SliderValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("StepValue")] 
		public CFloat StepValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("SliderShowPercents")] 
		public CBool SliderShowPercents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(44)] 
		[RED("photoModeController")] 
		public CWeakHandle<gameuiPhotoModeMenuController> PhotoModeController
		{
			get => GetPropertyValue<CWeakHandle<gameuiPhotoModeMenuController>>();
			set => SetPropertyValue<CWeakHandle<gameuiPhotoModeMenuController>>(value);
		}

		[Ordinal(45)] 
		[RED("holdBgInitMargin")] 
		public inkMargin HoldBgInitMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(46)] 
		[RED("allowHold")] 
		public CBool AllowHold
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("inputDirection")] 
		public CInt32 InputDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(48)] 
		[RED("inputStepTime")] 
		public CFloat InputStepTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(49)] 
		[RED("inputHoldTime")] 
		public CFloat InputHoldTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(50)] 
		[RED("arrowClickedTime")] 
		public CFloat ArrowClickedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("isSelected")] 
		public CBool IsSelected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(52)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(53)] 
		[RED("RightArrowInitOpacity")] 
		public CFloat RightArrowInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("LeftArrowInitOpacity")] 
		public CFloat LeftArrowInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("ScrollBarHandleInitOpacity")] 
		public CFloat ScrollBarHandleInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("ScrollBarLineInitOpacity")] 
		public CFloat ScrollBarLineInitOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PhotoModeMenuListItem()
		{
			ScrollBarRef = new();
			CounterLabelRef = new();
			TextLabelRef = new();
			OptionSelectorRef = new();
			LeftArrow = new();
			RightArrow = new();
			LeftButton = new();
			RightButton = new();
			OptionLabelRef = new();
			SelectedWidgetRef = new();
			TextRootWidgetRef = new();
			SliderRootWidgetRef = new();
			OptionSelectorRootWidgetRef = new();
			HoldButtonRootWidgetRef = new();
			ScrollBarLineRef = new();
			ScrollBarHandleRef = new();
			ScrollSlidingAreaRef = new();
			HoldProgressRef = new();
			GridRoot = new();
			GridTopRow = new();
			GridBottomRow = new();
			OptionSelectorValues = new();
			HoldBgInitMargin = new();
		}
	}
}
