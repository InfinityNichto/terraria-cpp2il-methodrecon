using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A7 RID: 423
	[NativeInputDeviceProfile]
	[Preserve]
	public class ThrustmasterFerrari458RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x00023374 File Offset: 0x00021574
		public override void Define()
		{
			base.Define();
			this.deviceName = "Thrustmaster Ferrari 458 Racing Wheel";
			this.deviceNotes = "Thrustmaster Ferrari 458 Racing Wheel on Mac";
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000233A0 File Offset: 0x000215A0
		public ThrustmasterFerrari458RacingWheelMacNativeProfile()
		{
		}
	}
}
