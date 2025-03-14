using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingTerminal : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(98)] 
		[RED("canMeshComponent")] 
		public CHandle<entMeshComponent> CanMeshComponent
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetPropertyValue<CArray<CEnum<EVendorMode>>>();
			set => SetPropertyValue<CArray<CEnum<EVendorMode>>>(value);
		}

		public VendingTerminal()
		{
			ControllerTypeName = "VendingTerminalController";
			Position = new();
			VendingBlacklist = new();
		}
	}
}
