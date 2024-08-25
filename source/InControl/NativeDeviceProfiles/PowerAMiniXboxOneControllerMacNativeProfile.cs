using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000191 RID: 401
	[NativeInputDeviceProfile]
	[Preserve]
	public class PowerAMiniXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x00022E00 File Offset: 0x00021000
		public override void Define()
		{
			base.Define();
			this.deviceName = "Power A Mini Xbox One Controller";
			this.deviceNotes = "Power A Mini Xbox One Controller on Mac";
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00022E2C File Offset: 0x0002102C
		public PowerAMiniXboxOneControllerMacNativeProfile()
		{
		}
	}
}
