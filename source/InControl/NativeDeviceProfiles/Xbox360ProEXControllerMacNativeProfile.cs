using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AF RID: 431
	[Preserve]
	[NativeInputDeviceProfile]
	public class Xbox360ProEXControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x00023568 File Offset: 0x00021768
		public override void Define()
		{
			base.Define();
			this.deviceName = "Xbox 360 Pro EX Controller";
			this.deviceNotes = "Xbox 360 Pro EX Controller on Mac";
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00023594 File Offset: 0x00021794
		public Xbox360ProEXControllerMacNativeProfile()
		{
		}
	}
}
