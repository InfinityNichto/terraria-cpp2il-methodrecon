using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A5 RID: 421
	[Preserve]
	[NativeInputDeviceProfile]
	public class SaitekXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x000232F4 File Offset: 0x000214F4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Saitek Xbox 360 Controller";
			this.deviceNotes = "Saitek Xbox 360 Controller on Mac";
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00023320 File Offset: 0x00021520
		public SaitekXbox360ControllerMacNativeProfile()
		{
		}
	}
}
