using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Cylinder : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("positionAndRadius")] 
		public Vector4 PositionAndRadius
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("normalAndHeight")] 
		public Vector4 NormalAndHeight
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Cylinder()
		{
			PositionAndRadius = new();
			NormalAndHeight = new();
		}
	}
}
