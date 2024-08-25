using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A9 RID: 425
	[NativeInputDeviceProfile]
	[Preserve]
	public class ThrustmasterGPXControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007DF RID: 2015 RVA: 0x000233F4 File Offset: 0x000215F4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Thrustmaster GPX Controller";
			this.deviceNotes = "Thrustmaster GPX Controller on Mac";
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00023420 File Offset: 0x00021620
		public ThrustmasterGPXControllerMacNativeProfile()
		{
		}
	}
}
