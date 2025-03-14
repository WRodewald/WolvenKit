using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpawnOriginData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("playerPosition")] 
		public Vector4 PlayerPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public SpawnOriginData()
		{
			Position = new();
			Direction = new();
			PlayerPosition = new();
		}
	}
}
