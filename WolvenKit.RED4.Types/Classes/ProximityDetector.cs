using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProximityDetector : Device
	{
		[Ordinal(87)] 
		[RED("scanningAreaName")] 
		public CName ScanningAreaName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(88)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(89)] 
		[RED("scanningArea")] 
		public CHandle<gameStaticTriggerAreaComponent> ScanningArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(90)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(91)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(92)] 
		[RED("notifiactionType")] 
		public CEnum<ESecurityNotificationType> NotifiactionType
		{
			get => GetPropertyValue<CEnum<ESecurityNotificationType>>();
			set => SetPropertyValue<CEnum<ESecurityNotificationType>>(value);
		}

		public ProximityDetector()
		{
			ControllerTypeName = "ScriptableDC";
			ScreenDefinition = new();
			IsUIdirty = true;
			UpdateID = new();
			DelayedUpdateDeviceStateID = new();
			LastPingSourceID = new();
			NetworkGridBeamFX = new();
			PersonalLinkFailsafeID = new();
			NetworkGridBeamOffset = new();
			AreaEffectsData = new();
			AreaEffectsInFocusMode = new();
			DebugOptions = new() { LayerIDs = new() };
		}
	}
}
