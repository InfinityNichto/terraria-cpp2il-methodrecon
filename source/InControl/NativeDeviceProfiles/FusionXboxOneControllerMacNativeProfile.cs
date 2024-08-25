using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012E RID: 302
	[NativeInputDeviceProfile]
	[Preserve]
	public class FusionXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060006E9 RID: 1769 RVA: 0x00021180 File Offset: 0x0001F380
		public override void Define()
		{
			base.Define();
			this.deviceName = "Fusion Xbox One Controller";
			this.deviceNotes = "Fusion Xbox One Controller on Mac";
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000211AC File Offset: 0x0001F3AC
		public FusionXboxOneControllerMacNativeProfile()
		{
		}
	}
}
