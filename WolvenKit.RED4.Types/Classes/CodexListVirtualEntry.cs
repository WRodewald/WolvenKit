using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexListVirtualEntry : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("newWrapper")] 
		public inkWidgetReference NewWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("entryData")] 
		public CHandle<CodexEntryData> EntryData
		{
			get => GetPropertyValue<CHandle<CodexEntryData>>();
			set => SetPropertyValue<CHandle<CodexEntryData>>(value);
		}

		[Ordinal(19)] 
		[RED("nestedListData")] 
		public CHandle<VirutalNestedListData> NestedListData
		{
			get => GetPropertyValue<CHandle<VirutalNestedListData>>();
			set => SetPropertyValue<CHandle<VirutalNestedListData>>(value);
		}

		[Ordinal(20)] 
		[RED("activeItemSync")] 
		public CWeakHandle<CodexListSyncData> ActiveItemSync
		{
			get => GetPropertyValue<CWeakHandle<CodexListSyncData>>();
			set => SetPropertyValue<CWeakHandle<CodexListSyncData>>(value);
		}

		[Ordinal(21)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CodexListVirtualEntry()
		{
			Title = new();
			Icon = new();
			NewWrapper = new();
		}
	}
}
