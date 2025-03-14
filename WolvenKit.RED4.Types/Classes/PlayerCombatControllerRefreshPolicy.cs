using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatControllerRefreshPolicy : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("crouchActive")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> CrouchActive
		{
			get => GetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(1)] 
		[RED("crouchTimerPassed")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> CrouchTimerPassed
		{
			get => GetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(2)] 
		[RED("squadInCombat")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> SquadInCombat
		{
			get => GetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(3)] 
		[RED("usingJhonnyReplacer")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> UsingJhonnyReplacer
		{
			get => GetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>(value);
		}

		[Ordinal(4)] 
		[RED("usingQuickHack")] 
		public CEnum<PlayerCombatControllerRefreshPolicyEnum> UsingQuickHack
		{
			get => GetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>();
			set => SetPropertyValue<CEnum<PlayerCombatControllerRefreshPolicyEnum>>(value);
		}
	}
}
