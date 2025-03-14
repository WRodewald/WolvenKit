using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_Paperdoll : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("genderSelection")] 
		public CBool GenderSelection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("characterCreation")] 
		public CBool CharacterCreation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("characterCreation_Head")] 
		public CBool CharacterCreation_Head
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("characterCreation_Teeth")] 
		public CBool CharacterCreation_Teeth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("characterCreation_Nails")] 
		public CBool CharacterCreation_Nails
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("characterCreation_Summary")] 
		public CBool CharacterCreation_Summary
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("inventoryScreen")] 
		public CBool InventoryScreen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("inventoryScreen_Weapon")] 
		public CBool InventoryScreen_Weapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("inventoryScreen_Legs")] 
		public CBool InventoryScreen_Legs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("inventoryScreen_Feet")] 
		public CBool InventoryScreen_Feet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("inventoryScreen_Cyberware")] 
		public CBool InventoryScreen_Cyberware
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("inventoryScreen_QuickSlot")] 
		public CBool InventoryScreen_QuickSlot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("inventoryScreen_Consumable")] 
		public CBool InventoryScreen_Consumable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("inventoryScreen_Outfit")] 
		public CBool InventoryScreen_Outfit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("inventoryScreen_Head")] 
		public CBool InventoryScreen_Head
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("inventoryScreen_Face")] 
		public CBool InventoryScreen_Face
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("inventoryScreen_InnerChest")] 
		public CBool InventoryScreen_InnerChest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("inventoryScreen_OuterChest")] 
		public CBool InventoryScreen_OuterChest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
