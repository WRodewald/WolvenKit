using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModePlayerEntityComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("usedWeaponItemId")] 
		public gameItemID UsedWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(6)] 
		[RED("currentWeaponInSlot")] 
		public gameItemID CurrentWeaponInSlot
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(7)] 
		[RED("availableItemTypesList")] 
		public CArray<CEnum<gamedataItemType>> AvailableItemTypesList
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
		}

		[Ordinal(8)] 
		[RED("availableItemsList")] 
		public CArray<CWeakHandle<gameItemData>> AvailableItemsList
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemData>>>(value);
		}

		[Ordinal(9)] 
		[RED("swapMeeleWeaponItemId")] 
		public gameItemID SwapMeeleWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(10)] 
		[RED("swapHangunWeaponItemId")] 
		public gameItemID SwapHangunWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(11)] 
		[RED("swapRifleWeaponItemId")] 
		public gameItemID SwapRifleWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(12)] 
		[RED("swapShootgunWeaponItemId")] 
		public gameItemID SwapShootgunWeaponItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(13)] 
		[RED("fakePuppet")] 
		public CWeakHandle<gamePuppet> FakePuppet
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}

		[Ordinal(14)] 
		[RED("playerPuppet")] 
		public CWeakHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(15)] 
		[RED("TS")] 
		public CHandle<gameTransactionSystem> TS
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(16)] 
		[RED("loadingItems")] 
		public CArray<gameItemID> LoadingItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(17)] 
		[RED("itemsLoadingTimeout")] 
		public CFloat ItemsLoadingTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("muzzleEffectEnabled")] 
		public CBool MuzzleEffectEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PhotoModePlayerEntityComponent()
		{
			UsedWeaponItemId = new();
			CurrentWeaponInSlot = new();
			AvailableItemTypesList = new();
			AvailableItemsList = new();
			SwapMeeleWeaponItemId = new();
			SwapHangunWeaponItemId = new();
			SwapRifleWeaponItemId = new();
			SwapShootgunWeaponItemId = new();
			LoadingItems = new();
		}
	}
}
