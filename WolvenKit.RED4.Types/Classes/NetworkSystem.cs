using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("networkLinks")] 
		public CArray<SNetworkLinkData> NetworkLinks
		{
			get => GetPropertyValue<CArray<SNetworkLinkData>>();
			set => SetPropertyValue<CArray<SNetworkLinkData>>(value);
		}

		[Ordinal(1)] 
		[RED("networkRevealTargets")] 
		public CArray<entEntityID> NetworkRevealTargets
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(2)] 
		[RED("sessionStarted")] 
		public CBool SessionStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("visionModeChangedCallback")] 
		public CHandle<redCallbackObject> VisionModeChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(4)] 
		[RED("focusModeToggleCallback")] 
		public CHandle<redCallbackObject> FocusModeToggleCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(5)] 
		[RED("playerSpawnCallback")] 
		public CUInt32 PlayerSpawnCallback
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("currentPlayerTargetCallbackID")] 
		public CHandle<redCallbackObject> CurrentPlayerTargetCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(7)] 
		[RED("lastTargetSlaveID")] 
		public entEntityID LastTargetSlaveID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(8)] 
		[RED("lastTargetMasterID")] 
		public entEntityID LastTargetMasterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(9)] 
		[RED("unregisterLinksRequestDelay")] 
		public gameDelayID UnregisterLinksRequestDelay
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(10)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("lastBeamResource")] 
		public gameFxResource LastBeamResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(12)] 
		[RED("pingNetworkEffect")] 
		public CHandle<gameEffectInstance> PingNetworkEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(13)] 
		[RED("pingCachedData")] 
		public CHandle<PingCachedData> PingCachedData
		{
			get => GetPropertyValue<CHandle<PingCachedData>>();
			set => SetPropertyValue<CHandle<PingCachedData>>(value);
		}

		[Ordinal(14)] 
		[RED("lastPingSourceID")] 
		public entEntityID LastPingSourceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(15)] 
		[RED("activePings")] 
		public CArray<CHandle<PingCachedData>> ActivePings
		{
			get => GetPropertyValue<CArray<CHandle<PingCachedData>>>();
			set => SetPropertyValue<CArray<CHandle<PingCachedData>>>(value);
		}

		[Ordinal(16)] 
		[RED("pingedSquads")] 
		public CArray<CName> PingedSquads
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(17)] 
		[RED("pingLinksCounter")] 
		public CInt32 PingLinksCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("networkPresetTBDID")] 
		public TweakDBID NetworkPresetTBDID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(19)] 
		[RED("networkPresetRecord")] 
		public CWeakHandle<gamedataNetworkPingingParameteres_Record> NetworkPresetRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataNetworkPingingParameteres_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataNetworkPingingParameteres_Record>>(value);
		}

		[Ordinal(20)] 
		[RED("backdoors")] 
		public CArray<gamePersistentID> Backdoors
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(21)] 
		[RED("revealedBackdoorsCount")] 
		public CInt32 RevealedBackdoorsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("debugCashedPingFxResource")] 
		public gameFxResource DebugCashedPingFxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(23)] 
		[RED("debugQueryNumber")] 
		public CInt32 DebugQueryNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("activateLinksDelayID")] 
		public gameDelayID ActivateLinksDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(25)] 
		[RED("deactivateLinksDelayID")] 
		public gameDelayID DeactivateLinksDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public NetworkSystem()
		{
			NetworkLinks = new();
			NetworkRevealTargets = new();
			LastTargetSlaveID = new();
			LastTargetMasterID = new();
			UnregisterLinksRequestDelay = new();
			LastBeamResource = new();
			LastPingSourceID = new();
			ActivePings = new();
			PingedSquads = new();
			Backdoors = new();
			DebugCashedPingFxResource = new();
			ActivateLinksDelayID = new();
			DeactivateLinksDelayID = new();
		}
	}
}
