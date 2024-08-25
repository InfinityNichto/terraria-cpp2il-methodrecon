using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A2 RID: 418
	[NativeInputDeviceProfile]
	[Preserve]
	public class RockCandyPS3ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x00023234 File Offset: 0x00021434
		public override void Define()
		{
			base.Define();
			this.deviceName = "Rock Candy PS3 Controller";
			this.deviceNotes = "Rock Candy PS3 Controller on Mac";
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00023260 File Offset: 0x00021460
		public RockCandyPS3ControllerMacNativeProfile()
		{
		}
	}
}
