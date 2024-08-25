using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019E RID: 414
	[NativeInputDeviceProfile]
	[Preserve]
	public class RedOctaneGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x00023134 File Offset: 0x00021334
		public override void Define()
		{
			base.Define();
			this.deviceName = "RedOctane Guitar";
			this.deviceNotes = "RedOctane Guitar on Mac";
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00023160 File Offset: 0x00021360
		public RedOctaneGuitarMacNativeProfile()
		{
		}
	}
}
