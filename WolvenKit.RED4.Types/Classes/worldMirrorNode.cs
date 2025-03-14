using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldMirrorNode : worldMeshNode
	{
		[Ordinal(15)] 
		[RED("cullingBoxExtents")] 
		public Vector3 CullingBoxExtents
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(16)] 
		[RED("cullingBoxOffset")] 
		public Vector3 CullingBoxOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public worldMirrorNode()
		{
			CullingBoxExtents = new() { X = 20.000000F, Y = 20.000000F, Z = 20.000000F };
			CullingBoxOffset = new();
		}
	}
}
