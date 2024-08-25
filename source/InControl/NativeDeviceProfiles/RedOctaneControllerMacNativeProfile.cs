using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019D RID: 413
	[Preserve]
	[NativeInputDeviceProfile]
	public class RedOctaneControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x000230F4 File Offset: 0x000212F4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Red Octane Controller";
			this.deviceNotes = "Red Octane Controller on Mac";
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00023120 File Offset: 0x00021320
		public RedOctaneControllerMacNativeProfile()
		{
		}
	}
}
