using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017C RID: 380
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x00022628 File Offset: 0x00020828
		public override void Define()
		{
			base.Define();
			this.deviceName = "Microsoft Xbox One Controller";
			this.deviceNotes = "Microsoft Xbox One Controller on Mac";
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00022654 File Offset: 0x00020854
		public MicrosoftXboxOneControllerMacNativeProfile()
		{
		}
	}
}
