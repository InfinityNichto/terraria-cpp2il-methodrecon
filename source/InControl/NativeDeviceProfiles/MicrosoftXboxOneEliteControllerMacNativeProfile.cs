using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017D RID: 381
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftXboxOneEliteControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06000787 RID: 1927 RVA: 0x00022668 File Offset: 0x00020868
		public override void Define()
		{
			base.Define();
			this.deviceName = "Microsoft Xbox One Elite Controller";
			this.deviceNotes = "Microsoft Xbox One Elite Controller on Mac";
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00022694 File Offset: 0x00020894
		public MicrosoftXboxOneEliteControllerMacNativeProfile()
		{
		}
	}
}
