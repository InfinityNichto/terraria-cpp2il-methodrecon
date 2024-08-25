using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019A RID: 410
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerStrikeControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C1 RID: 1985 RVA: 0x00023034 File Offset: 0x00021234
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Strike Controller";
			this.deviceNotes = "Razer Strike Controller on Mac";
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00023060 File Offset: 0x00021260
		public RazerStrikeControllerMacNativeProfile()
		{
		}
	}
}
