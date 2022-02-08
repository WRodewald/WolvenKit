
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectComponentBinding : entISourceBinding
	{

		public gameEffectComponentBinding()
		{
			Enabled = true;
			EnableMask = new() { HardTags = new() { Tags = new() }, SoftTags = new() { Tags = new() }, ExcludedTags = new() { Tags = new() { "NoBinding" } } };
		}
	}
}
