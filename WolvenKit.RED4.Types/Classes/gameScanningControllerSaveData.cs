using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameScanningControllerSaveData : ISerializable
	{
		[Ordinal(0)] 
		[RED("taggedObjectIDs")] 
		public CArray<entEntityID> TaggedObjectIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public gameScanningControllerSaveData()
		{
			TaggedObjectIDs = new();
		}
	}
}
