
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTerrainProxyMeshNode : worldPrefabProxyMeshNode
	{

		public worldTerrainProxyMeshNode()
		{
			AncestorPrefabProxyMeshNodeID = new();
			OwnerPrefabNodeId = new();
		}
	}
}
