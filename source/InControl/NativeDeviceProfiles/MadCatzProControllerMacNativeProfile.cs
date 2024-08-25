using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200016E RID: 366
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzProControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x0002216C File Offset: 0x0002036C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Pro Controller";
			this.deviceNotes = "Mad Catz Pro Controller on Mac";
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00022198 File Offset: 0x00020398
		public MadCatzProControllerMacNativeProfile()
		{
		}
	}
}
