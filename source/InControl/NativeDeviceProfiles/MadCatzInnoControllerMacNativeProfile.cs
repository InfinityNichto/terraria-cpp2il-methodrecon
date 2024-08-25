using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000166 RID: 358
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzInnoControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00021F6C File Offset: 0x0002016C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Inno Controller";
			this.deviceNotes = "Mad Catz Inno Controller on Mac";
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00021F98 File Offset: 0x00020198
		public MadCatzInnoControllerMacNativeProfile()
		{
		}
	}
}
