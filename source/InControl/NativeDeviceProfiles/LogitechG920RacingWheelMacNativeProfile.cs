using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000159 RID: 345
	[NativeInputDeviceProfile]
	[Preserve]
	public class LogitechG920RacingWheelMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x00021C3C File Offset: 0x0001FE3C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech G920 Racing Wheel";
			this.deviceNotes = "Logitech G920 Racing Wheel on Mac";
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00021C68 File Offset: 0x0001FE68
		public LogitechG920RacingWheelMacNativeProfile()
		{
		}
	}
}
