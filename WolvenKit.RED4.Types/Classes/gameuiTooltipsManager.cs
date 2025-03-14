using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTooltipsManager : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("tooltipsContainer")] 
		public inkWidgetReference TooltipsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("flipX")] 
		public CBool FlipX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("flipY")] 
		public CBool FlipY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("rootMargin")] 
		public inkMargin RootMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(5)] 
		[RED("screenMargin")] 
		public inkMargin ScreenMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(6)] 
		[RED("TooltipRequesters")] 
		public CArray<inkWidgetReference> TooltipRequesters
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(7)] 
		[RED("GenericTooltipsNames")] 
		public CArray<CName> GenericTooltipsNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(8)] 
		[RED("TooltipLibrariesReferences")] 
		public CArray<TooltipWidgetReference> TooltipLibrariesReferences
		{
			get => GetPropertyValue<CArray<TooltipWidgetReference>>();
			set => SetPropertyValue<CArray<TooltipWidgetReference>>(value);
		}

		[Ordinal(9)] 
		[RED("TooltipLibrariesStyledReferences")] 
		public CArray<TooltipWidgetStyledReference> TooltipLibrariesStyledReferences
		{
			get => GetPropertyValue<CArray<TooltipWidgetStyledReference>>();
			set => SetPropertyValue<CArray<TooltipWidgetStyledReference>>(value);
		}

		[Ordinal(10)] 
		[RED("TooltipsLibrary")] 
		public redResourceReferenceScriptToken TooltipsLibrary
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(11)] 
		[RED("MenuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(12)] 
		[RED("HudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(13)] 
		[RED("IndexedTooltips")] 
		public CArray<CWeakHandle<AGenericTooltipController>> IndexedTooltips
		{
			get => GetPropertyValue<CArray<CWeakHandle<AGenericTooltipController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<AGenericTooltipController>>>(value);
		}

		[Ordinal(14)] 
		[RED("NamedTooltips")] 
		public CArray<CHandle<NamedTooltipController>> NamedTooltips
		{
			get => GetPropertyValue<CArray<CHandle<NamedTooltipController>>>();
			set => SetPropertyValue<CArray<CHandle<NamedTooltipController>>>(value);
		}

		[Ordinal(15)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiTooltipsManager()
		{
			TooltipsContainer = new();
			FlipX = true;
			FlipY = true;
			RootMargin = new();
			ScreenMargin = new() { Right = 10.000000F, Bottom = 125.000000F };
			TooltipRequesters = new();
			GenericTooltipsNames = new();
			TooltipLibrariesReferences = new();
			TooltipLibrariesStyledReferences = new();
			TooltipsLibrary = new();
			MenuTooltipStylePath = new();
			HudTooltipStylePath = new();
			IndexedTooltips = new();
			NamedTooltips = new();
		}
	}
}
