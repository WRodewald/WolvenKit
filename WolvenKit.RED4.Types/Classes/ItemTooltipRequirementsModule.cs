using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipRequirementsModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("levelRequirementsWrapper")] 
		public inkWidgetReference LevelRequirementsWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("strenghtOrReflexWrapper")] 
		public inkWidgetReference StrenghtOrReflexWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("smartlinkGunWrapper")] 
		public inkWidgetReference SmartlinkGunWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("anyAttributeWrapper")] 
		public inkWidgetReference AnyAttributeWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("levelRequirementsText")] 
		public inkTextWidgetReference LevelRequirementsText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("strenghtOrReflexText")] 
		public inkTextWidgetReference StrenghtOrReflexText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("anyAttributeText")] 
		public inkTextWidgetReference AnyAttributeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipRequirementsModule()
		{
			LevelRequirementsWrapper = new();
			StrenghtOrReflexWrapper = new();
			SmartlinkGunWrapper = new();
			AnyAttributeWrapper = new();
			LevelRequirementsText = new();
			StrenghtOrReflexText = new();
			AnyAttributeText = new();
		}
	}
}
