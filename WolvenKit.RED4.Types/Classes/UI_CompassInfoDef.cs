using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_CompassInfoDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("NorthOffset")] 
		public gamebbScriptID_Float NorthOffset
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(1)] 
		[RED("SouthOffset")] 
		public gamebbScriptID_Float SouthOffset
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(2)] 
		[RED("EastOffset")] 
		public gamebbScriptID_Float EastOffset
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(3)] 
		[RED("WestOffset")] 
		public gamebbScriptID_Float WestOffset
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(4)] 
		[RED("Pins")] 
		public gamebbScriptID_Variant Pins
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public UI_CompassInfoDef()
		{
			NorthOffset = new();
			SouthOffset = new();
			EastOffset = new();
			WestOffset = new();
			Pins = new();
		}
	}
}
