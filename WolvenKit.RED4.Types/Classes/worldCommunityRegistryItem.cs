using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCommunityRegistryItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entriesInitialState")] 
		public CArray<worldCommunityEntryInitialState> EntriesInitialState
		{
			get => GetPropertyValue<CArray<worldCommunityEntryInitialState>>();
			set => SetPropertyValue<CArray<worldCommunityEntryInitialState>>(value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public CHandle<communityCommunityTemplateData> Template
		{
			get => GetPropertyValue<CHandle<communityCommunityTemplateData>>();
			set => SetPropertyValue<CHandle<communityCommunityTemplateData>>(value);
		}

		[Ordinal(2)] 
		[RED("communityId")] 
		public gameCommunityID CommunityId
		{
			get => GetPropertyValue<gameCommunityID>();
			set => SetPropertyValue<gameCommunityID>(value);
		}

		[Ordinal(3)] 
		[RED("communityIsBackground")] 
		public CBool CommunityIsBackground
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldCommunityRegistryItem()
		{
			EntriesInitialState = new();
			CommunityId = new() { EntityId = new() };
		}
	}
}
