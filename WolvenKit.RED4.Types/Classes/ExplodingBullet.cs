using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplodingBullet : BaseBullet
	{
		[Ordinal(56)] 
		[RED("explosionTime")] 
		public CFloat ExplosionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(57)] 
		[RED("effectReference")] 
		public gameEffectRef EffectReference
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(58)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("initialPosition")] 
		public Vector4 InitialPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(60)] 
		[RED("trailStarted")] 
		public CBool TrailStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(62)] 
		[RED("attack_record")] 
		public CHandle<gamedataAttack_Record> Attack_record
		{
			get => GetPropertyValue<CHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CHandle<gamedataAttack_Record>>(value);
		}

		[Ordinal(63)] 
		[RED("attackID")] 
		public TweakDBID AttackID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(64)] 
		[RED("colliderBox")] 
		public Vector4 ColliderBox
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(65)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(66)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(67)] 
		[RED("explodeAfterRangeTravelled")] 
		public CBool ExplodeAfterRangeTravelled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(68)] 
		[RED("attack")] 
		public CHandle<gameIAttack> Attack
		{
			get => GetPropertyValue<CHandle<gameIAttack>>();
			set => SetPropertyValue<CHandle<gameIAttack>>(value);
		}

		[Ordinal(69)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get => GetPropertyValue<CHandle<BulletCollisionEvaluator>>();
			set => SetPropertyValue<CHandle<BulletCollisionEvaluator>>(value);
		}

		public ExplodingBullet()
		{
			EffectReference = new();
			InitialPosition = new();
			ColliderBox = new();
			Rotation = new() { R = 1.000000F };
			ExplodeAfterRangeTravelled = true;
		}
	}
}
