using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000155 RID: 341
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechDriveFXRacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x00021B3C File Offset: 0x0001FD3C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech DriveFX Racing Wheel";
			this.deviceNotes = "Logitech DriveFX Racing Wheel on Mac";
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00021B68 File Offset: 0x0001FD68
		public LogitechDriveFXRacingWheelMacNativeProfile()
		{
		}
	}
}
