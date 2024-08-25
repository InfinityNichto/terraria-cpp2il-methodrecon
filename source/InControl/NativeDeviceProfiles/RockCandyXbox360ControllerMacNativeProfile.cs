using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A3 RID: 419
	[NativeInputDeviceProfile]
	[Preserve]
	public class RockCandyXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00023274 File Offset: 0x00021474
		public override void Define()
		{
			base.Define();
			this.deviceName = "Rock Candy Xbox 360 Controller";
			this.deviceNotes = "Rock Candy Xbox 360 Controller on Mac";
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000232A0 File Offset: 0x000214A0
		public RockCandyXbox360ControllerMacNativeProfile()
		{
		}
	}
}
