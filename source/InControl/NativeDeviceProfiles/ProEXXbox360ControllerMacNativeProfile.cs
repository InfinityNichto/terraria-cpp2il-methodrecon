using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000193 RID: 403
	[NativeInputDeviceProfile]
	[Preserve]
	public class ProEXXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007B3 RID: 1971 RVA: 0x00022E80 File Offset: 0x00021080
		public override void Define()
		{
			base.Define();
			this.deviceName = "Pro EX Xbox 360 Controller";
			this.deviceNotes = "Pro EX Xbox 360 Controller on Mac";
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00022EAC File Offset: 0x000210AC
		public ProEXXbox360ControllerMacNativeProfile()
		{
		}
	}
}
