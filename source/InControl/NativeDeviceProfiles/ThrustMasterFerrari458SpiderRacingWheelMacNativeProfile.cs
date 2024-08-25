using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A8 RID: 424
	[NativeInputDeviceProfile]
	[Preserve]
	public class ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x000233B4 File Offset: 0x000215B4
		public override void Define()
		{
			base.Define();
			this.deviceName = "ThrustMaster Ferrari 458 Spider Racing Wheel";
			this.deviceNotes = "ThrustMaster Ferrari 458 Spider Racing Wheel on Mac";
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x000233E0 File Offset: 0x000215E0
		public ThrustMasterFerrari458SpiderRacingWheelMacNativeProfile()
		{
		}
	}
}
