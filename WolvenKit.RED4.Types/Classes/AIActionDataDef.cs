using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIActionDataDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("ownerMeleeAttackBlockedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackBlockedCount
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("ownerMeleeAttackParriedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackParriedCount
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("ownerMeleeAttackDodgedCount")] 
		public gamebbScriptID_Int32 OwnerMeleeAttackDodgedCount
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("ownerLastAttackTimeStamp")] 
		public gamebbScriptID_Float OwnerLastAttackTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("ownerLastAttackName")] 
		public gamebbScriptID_CName OwnerLastAttackName
		{
			get => GetPropertyValue<gamebbScriptID_CName>();
			set => SetPropertyValue<gamebbScriptID_CName>(value);
		}

		[Ordinal(5)] 
		[RED("ownerCurrentAnimVariationSet")] 
		public gamebbScriptID_Bool OwnerCurrentAnimVariationSet
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("ownerLastAnimVariation")] 
		public gamebbScriptID_Int32 OwnerLastAnimVariation
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("ownerItemsToEquip")] 
		public gamebbScriptID_Variant OwnerItemsToEquip
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(8)] 
		[RED("ownerItemsUnequipped")] 
		public gamebbScriptID_Variant OwnerItemsUnequipped
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(9)] 
		[RED("ownerItemsForceUnequipped")] 
		public gamebbScriptID_Variant OwnerItemsForceUnequipped
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("ownerLastEquippedItems")] 
		public gamebbScriptID_Variant OwnerLastEquippedItems
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(11)] 
		[RED("ownerLastUnequipTimestamp")] 
		public gamebbScriptID_Float OwnerLastUnequipTimestamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(12)] 
		[RED("ownerEquipItemTime")] 
		public gamebbScriptID_Float OwnerEquipItemTime
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(13)] 
		[RED("ownerEquipDuration")] 
		public gamebbScriptID_Float OwnerEquipDuration
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(14)] 
		[RED("dropItemOnUnequip")] 
		public gamebbScriptID_Bool DropItemOnUnequip
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(15)] 
		[RED("archetypeEffectorsApplied")] 
		public gamebbScriptID_Bool ArchetypeEffectorsApplied
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(16)] 
		[RED("ownerTimeDilation")] 
		public gamebbScriptID_Float OwnerTimeDilation
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(17)] 
		[RED("operationHasBeenProcessed")] 
		public gamebbScriptID_Bool OperationHasBeenProcessed
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(18)] 
		[RED("weaponTrailInitialised")] 
		public gamebbScriptID_Bool WeaponTrailInitialised
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(19)] 
		[RED("weaponTrailAborted")] 
		public gamebbScriptID_Bool WeaponTrailAborted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(20)] 
		[RED("netrunner")] 
		public gamebbScriptID_Variant Netrunner
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(21)] 
		[RED("netrunnerProxy")] 
		public gamebbScriptID_Variant NetrunnerProxy
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(22)] 
		[RED("netrunnerTarget")] 
		public gamebbScriptID_Variant NetrunnerTarget
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public AIActionDataDef()
		{
			OwnerMeleeAttackBlockedCount = new();
			OwnerMeleeAttackParriedCount = new();
			OwnerMeleeAttackDodgedCount = new();
			OwnerLastAttackTimeStamp = new();
			OwnerLastAttackName = new();
			OwnerCurrentAnimVariationSet = new();
			OwnerLastAnimVariation = new();
			OwnerItemsToEquip = new();
			OwnerItemsUnequipped = new();
			OwnerItemsForceUnequipped = new();
			OwnerLastEquippedItems = new();
			OwnerLastUnequipTimestamp = new();
			OwnerEquipItemTime = new();
			OwnerEquipDuration = new();
			DropItemOnUnequip = new();
			ArchetypeEffectorsApplied = new();
			OwnerTimeDilation = new();
			OperationHasBeenProcessed = new();
			WeaponTrailInitialised = new();
			WeaponTrailAborted = new();
			Netrunner = new();
			NetrunnerProxy = new();
			NetrunnerTarget = new();
		}
	}
}
