using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStreamingTestCheckpoint_NodeType : questIWorldDataManagerNodeType
	{
		[Ordinal(0)] 
		[RED("checkpointType")] 
		public CEnum<worldStreamingTestCheckpointType> CheckpointType
		{
			get => GetPropertyValue<CEnum<worldStreamingTestCheckpointType>>();
			set => SetPropertyValue<CEnum<worldStreamingTestCheckpointType>>(value);
		}
	}
}
