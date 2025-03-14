using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficLight : Device
	{
		[Ordinal(87)] 
		[RED("lightState")] 
		public CEnum<worldTrafficLightColor> LightState
		{
			get => GetPropertyValue<CEnum<worldTrafficLightColor>>();
			set => SetPropertyValue<CEnum<worldTrafficLightColor>>(value);
		}

		[Ordinal(88)] 
		[RED("trafficLightMesh")] 
		public CHandle<entPhysicalMeshComponent> TrafficLightMesh
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(89)] 
		[RED("destroyedMesh")] 
		public CHandle<entPhysicalMeshComponent> DestroyedMesh
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		public TrafficLight()
		{
			ControllerTypeName = "TrafficLightController";
		}
	}
}
