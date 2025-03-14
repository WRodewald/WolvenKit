using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpTestPlatformController : gameObject
	{
		[Ordinal(40)] 
		[RED("platform")] 
		public NodeRef Platform
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(41)] 
		[RED("pointA")] 
		public NodeRef PointA
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(42)] 
		[RED("pointB")] 
		public NodeRef PointB
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(43)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public cpTestPlatformController()
		{
			Speed = 1.000000F;
		}
	}
}
