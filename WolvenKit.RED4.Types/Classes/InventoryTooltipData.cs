using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("qualityStateName")] 
		public CName QualityStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("additionalDescription")] 
		public CString AdditionalDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(8)] 
		[RED("category")] 
		public CString Category
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("quality")] 
		public CString Quality
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(10)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("buyPrice")] 
		public CFloat BuyPrice
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("unlockProgress")] 
		public CFloat UnlockProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("primaryStats")] 
		public CArray<InventoryTooltipData_StatData> PrimaryStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(15)] 
		[RED("comparedStats")] 
		public CArray<InventoryTooltipData_StatData> ComparedStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(16)] 
		[RED("additionalStats")] 
		public CArray<InventoryTooltipData_StatData> AdditionalStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(17)] 
		[RED("randomDamageTypes")] 
		public CArray<InventoryTooltipData_StatData> RandomDamageTypes
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(18)] 
		[RED("recipeAdditionalStats")] 
		public CArray<InventoryTooltipData_StatData> RecipeAdditionalStats
		{
			get => GetPropertyValue<CArray<InventoryTooltipData_StatData>>();
			set => SetPropertyValue<CArray<InventoryTooltipData_StatData>>(value);
		}

		[Ordinal(19)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataDamageType>>();
			set => SetPropertyValue<CEnum<gamedataDamageType>>(value);
		}

		[Ordinal(20)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("levelRequired")] 
		public CInt32 LevelRequired
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("attachments")] 
		public CArray<CName> Attachments
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(23)] 
		[RED("specialAbilities")] 
		public CArray<gameInventoryItemAbility> SpecialAbilities
		{
			get => GetPropertyValue<CArray<gameInventoryItemAbility>>();
			set => SetPropertyValue<CArray<gameInventoryItemAbility>>(value);
		}

		[Ordinal(24)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(25)] 
		[RED("showCyclingDots")] 
		public CBool ShowCyclingDots
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("numberOfCyclingDots")] 
		public CInt32 NumberOfCyclingDots
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(27)] 
		[RED("selectedCyclingDot")] 
		public CInt32 SelectedCyclingDot
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetPropertyValue<CEnum<gamedataQuality>>();
			set => SetPropertyValue<CEnum<gamedataQuality>>(value);
		}

		[Ordinal(29)] 
		[RED("showIcon")] 
		public CBool ShowIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("randomizedStatQuantity")] 
		public CInt32 RandomizedStatQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(32)] 
		[RED("HasPlayerSmartGunLink")] 
		public CBool HasPlayerSmartGunLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("PlayerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(34)] 
		[RED("PlayerStrenght")] 
		public CInt32 PlayerStrenght
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(35)] 
		[RED("PlayerReflexes")] 
		public CInt32 PlayerReflexes
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(36)] 
		[RED("PlayerStreetCred")] 
		public CInt32 PlayerStreetCred
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(37)] 
		[RED("itemAttachments")] 
		public CArray<InventoryItemAttachments> ItemAttachments
		{
			get => GetPropertyValue<CArray<InventoryItemAttachments>>();
			set => SetPropertyValue<CArray<InventoryItemAttachments>>(value);
		}

		[Ordinal(38)] 
		[RED("inventoryItemData")] 
		public InventoryItemData InventoryItemData
		{
			get => GetPropertyValue<InventoryItemData>();
			set => SetPropertyValue<InventoryItemData>(value);
		}

		[Ordinal(39)] 
		[RED("overrideRarity")] 
		public CBool OverrideRarity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(40)] 
		[RED("quickhackData")] 
		public InventoryTooltipData_QuickhackData QuickhackData
		{
			get => GetPropertyValue<InventoryTooltipData_QuickhackData>();
			set => SetPropertyValue<InventoryTooltipData_QuickhackData>(value);
		}

		[Ordinal(41)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get => GetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>();
			set => SetPropertyValue<CHandle<InventoryTooltiData_GrenadeData>>(value);
		}

		[Ordinal(42)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetPropertyValue<CEnum<InventoryTooltipDisplayContext>>();
			set => SetPropertyValue<CEnum<InventoryTooltipDisplayContext>>(value);
		}

		[Ordinal(43)] 
		[RED("parentItemData")] 
		public CWeakHandle<gameItemData> ParentItemData
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(44)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(45)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetPropertyValue<CHandle<DEBUG_IconErrorInfo>>();
			set => SetPropertyValue<CHandle<DEBUG_IconErrorInfo>>(value);
		}

		public InventoryTooltipData()
		{
			ItemID = new();
			PrimaryStats = new();
			ComparedStats = new();
			AdditionalStats = new();
			RandomDamageTypes = new();
			RecipeAdditionalStats = new();
			Attachments = new();
			SpecialAbilities = new();
			ItemType = Enums.gamedataItemType.Invalid;
			ItemAttachments = new();
			InventoryItemData = new() { Empty = true, ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };
			QuickhackData = new() { AttackEffects = new() };
		}
	}
}
