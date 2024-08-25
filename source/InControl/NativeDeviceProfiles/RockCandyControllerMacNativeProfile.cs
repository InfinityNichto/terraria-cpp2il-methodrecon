using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A1 RID: 417
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockCandyControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007CF RID: 1999 RVA: 0x000231F4 File Offset: 0x000213F4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Rock Candy Controller";
			this.deviceNotes = "Rock Candy Controller on Mac";
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00023220 File Offset: 0x00021420
		public RockCandyControllerMacNativeProfile()
		{
		}
	}
}
