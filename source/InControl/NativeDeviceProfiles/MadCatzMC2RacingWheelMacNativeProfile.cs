using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000168 RID: 360
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzMC2RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x00021FEC File Offset: 0x000201EC
		public override void Define()
		{
			base.Define();
			this.deviceName = "MadCatz MC2 Racing Wheel";
			this.deviceNotes = "MadCatz MC2 Racing Wheel on Mac";
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00022018 File Offset: 0x00020218
		public MadCatzMC2RacingWheelMacNativeProfile()
		{
		}
	}
}
