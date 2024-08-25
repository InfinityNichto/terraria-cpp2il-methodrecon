using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A0 RID: 416
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockBandGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007CD RID: 1997 RVA: 0x000231B4 File Offset: 0x000213B4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Rock Band Guitar";
			this.deviceNotes = "Rock Band Guitar on Mac";
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x000231E0 File Offset: 0x000213E0
		public RockBandGuitarMacNativeProfile()
		{
		}
	}
}
