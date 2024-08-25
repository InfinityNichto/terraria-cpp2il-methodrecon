using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019F RID: 415
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockBandDrumsMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x00023174 File Offset: 0x00021374
		public override void Define()
		{
			base.Define();
			this.deviceName = "Rock Band Drums";
			this.deviceNotes = "Rock Band Drums on Mac";
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000231A0 File Offset: 0x000213A0
		public RockBandDrumsMacNativeProfile()
		{
		}
	}
}
