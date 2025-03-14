using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeTableCallbackRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("callBackID")] 
		public CUInt32 CallBackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
