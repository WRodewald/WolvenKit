using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleSmartBullet : BaseProjectile
	{
		[Ordinal(51)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(52)] 
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(53)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(55)] 
		[RED("lifetime")] 
		public CFloat Lifetime_480
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(56)] 
		[RED("bendTimeRatio")] 
		public CFloat BendTimeRatio
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(58)] 
		[RED("useParabolicPhase")] 
		public CBool UseParabolicPhase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("parabolicVelocityMin")] 
		public CFloat ParabolicVelocityMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(60)] 
		[RED("parabolicVelocityMax")] 
		public CFloat ParabolicVelocityMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(61)] 
		[RED("parabolicDuration")] 
		public CFloat ParabolicDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(62)] 
		[RED("parabolicGravity")] 
		public Vector4 ParabolicGravity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(63)] 
		[RED("spiralParams")] 
		public CHandle<gameprojectileSpiralParams> SpiralParams
		{
			get => GetPropertyValue<CHandle<gameprojectileSpiralParams>>();
			set => SetPropertyValue<CHandle<gameprojectileSpiralParams>>(value);
		}

		[Ordinal(64)] 
		[RED("useSpiralParams")] 
		public CBool UseSpiralParams
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(67)] 
		[RED("trailName")] 
		public CName TrailName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(68)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(69)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(70)] 
		[RED("parabolicPhaseParams")] 
		public CHandle<gameprojectileParabolicTrajectoryParams> ParabolicPhaseParams
		{
			get => GetPropertyValue<CHandle<gameprojectileParabolicTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileParabolicTrajectoryParams>>(value);
		}

		[Ordinal(71)] 
		[RED("followPhaseParams")] 
		public CHandle<gameprojectileFollowCurveTrajectoryParams> FollowPhaseParams
		{
			get => GetPropertyValue<CHandle<gameprojectileFollowCurveTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileFollowCurveTrajectoryParams>>(value);
		}

		[Ordinal(72)] 
		[RED("linearPhaseParams")] 
		public CHandle<gameprojectileLinearTrajectoryParams> LinearPhaseParams
		{
			get => GetPropertyValue<CHandle<gameprojectileLinearTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileLinearTrajectoryParams>>(value);
		}

		[Ordinal(73)] 
		[RED("targeted")] 
		public CBool Targeted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(74)] 
		[RED("trailStarted")] 
		public CBool TrailStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(75)] 
		[RED("phase")] 
		public CEnum<ESmartBulletPhase> Phase
		{
			get => GetPropertyValue<CEnum<ESmartBulletPhase>>();
			set => SetPropertyValue<CEnum<ESmartBulletPhase>>(value);
		}

		[Ordinal(76)] 
		[RED("timeInPhase")] 
		public CFloat TimeInPhase
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(77)] 
		[RED("randStartVelocity")] 
		public CFloat RandStartVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(78)] 
		[RED("smartGunMissDelay")] 
		public CFloat SmartGunMissDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(79)] 
		[RED("smartGunHitProbability")] 
		public CFloat SmartGunHitProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(80)] 
		[RED("smartGunMissRadius")] 
		public CFloat SmartGunMissRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(81)] 
		[RED("randomWeaponMissChance")] 
		public CFloat RandomWeaponMissChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(82)] 
		[RED("randomTargetMissChance")] 
		public CFloat RandomTargetMissChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(83)] 
		[RED("readyToMiss")] 
		public CBool ReadyToMiss
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(84)] 
		[RED("stopAndDropOnTargetingDisruption")] 
		public CBool StopAndDropOnTargetingDisruption
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(85)] 
		[RED("shouldStopAndDrop")] 
		public CBool ShouldStopAndDrop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(86)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(87)] 
		[RED("ignoredTargetID")] 
		public entEntityID IgnoredTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(88)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(89)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(90)] 
		[RED("startPosition")] 
		public Vector4 StartPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(91)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(92)] 
		[RED("attack")] 
		public CHandle<gameIAttack> Attack
		{
			get => GetPropertyValue<CHandle<gameIAttack>>();
			set => SetPropertyValue<CHandle<gameIAttack>>(value);
		}

		[Ordinal(93)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get => GetPropertyValue<CHandle<BulletCollisionEvaluator>>();
			set => SetPropertyValue<CHandle<BulletCollisionEvaluator>>(value);
		}

		public sampleSmartBullet()
		{
			Effect = new();
			ParabolicGravity = new();
			Alive = true;
			WeaponID = new();
			TargetID = new();
			IgnoredTargetID = new();
			StartPosition = new();
		}
	}
}
