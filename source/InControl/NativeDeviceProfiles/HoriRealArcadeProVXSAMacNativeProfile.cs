using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014C RID: 332
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriRealArcadeProVXSAMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000725 RID: 1829 RVA: 0x000218F8 File Offset: 0x0001FAF8
		public override void Define()
		{
			this.deviceName = "Hori Real Arcade Pro VX SA";
			this.deviceNotes = "Hori Real Arcade Pro VX SA on Mac";
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0002191C File Offset: 0x0001FB1C
		public HoriRealArcadeProVXSAMacNativeProfile()
		{
		}
	}
}
