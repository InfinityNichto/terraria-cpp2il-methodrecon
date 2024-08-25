using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A6 RID: 422
	[NativeInputDeviceProfile]
	[Preserve]
	public class ThrustMasterFerrari430RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007D9 RID: 2009 RVA: 0x00023334 File Offset: 0x00021534
		public override void Define()
		{
			base.Define();
			this.deviceName = "ThrustMaster Ferrari 430 Racing Wheel";
			this.deviceNotes = "ThrustMaster Ferrari 430 Racing Wheel on Mac";
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00023360 File Offset: 0x00021560
		public ThrustMasterFerrari430RacingWheelMacNativeProfile()
		{
		}
	}
}
