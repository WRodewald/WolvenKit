using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerPuppetPS : ScriptedPuppetPS
	{
		[Ordinal(26)] 
		[RED("keybindigs")] 
		public KeyBindings Keybindigs
		{
			get => GetPropertyValue<KeyBindings>();
			set => SetPropertyValue<KeyBindings>(value);
		}

		[Ordinal(27)] 
		[RED("availablePrograms")] 
		public CArray<gameuiMinigameProgramData> AvailablePrograms
		{
			get => GetPropertyValue<CArray<gameuiMinigameProgramData>>();
			set => SetPropertyValue<CArray<gameuiMinigameProgramData>>(value);
		}

		[Ordinal(28)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("combatExitTimestamp")] 
		public CFloat CombatExitTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("minigameBB")] 
		public CWeakHandle<gameIBlackboard> MinigameBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public PlayerPuppetPS()
		{
			Keybindigs = new();
			AvailablePrograms = new();
		}
	}
}
