using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryWeaponItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(13)] 
		[RED("scopeRootContainer")] 
		public inkCompoundWidgetReference ScopeRootContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("magazineRootContainer")] 
		public inkCompoundWidgetReference MagazineRootContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("silencerRootContainer")] 
		public inkCompoundWidgetReference SilencerRootContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("scopeContainer")] 
		public inkCompoundWidgetReference ScopeContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("magazineContainer")] 
		public inkCompoundWidgetReference MagazineContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("silencerContainer")] 
		public inkCompoundWidgetReference SilencerContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("attachmentsLabel")] 
		public inkTextWidgetReference AttachmentsLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("attachmentsContainer")] 
		public inkWidgetReference AttachmentsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("softwareModsLabel")] 
		public inkTextWidgetReference SoftwareModsLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("softwareModsPush")] 
		public inkWidgetReference SoftwareModsPush
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("softwareModsContainer")] 
		public inkWidgetReference SoftwareModsContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public InventoryWeaponItemChooser()
		{
			ScopeRootContainer = new();
			MagazineRootContainer = new();
			SilencerRootContainer = new();
			ScopeContainer = new();
			MagazineContainer = new();
			SilencerContainer = new();
			AttachmentsLabel = new();
			AttachmentsContainer = new();
			SoftwareModsLabel = new();
			SoftwareModsPush = new();
			SoftwareModsContainer = new();
		}
	}
}
