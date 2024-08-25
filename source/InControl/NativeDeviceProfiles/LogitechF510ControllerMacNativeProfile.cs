using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000157 RID: 343
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF510ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x00021BBC File Offset: 0x0001FDBC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech F510 Controller";
			this.deviceNotes = "Logitech F510 Controller on Mac";
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00021BE8 File Offset: 0x0001FDE8
		public LogitechF510ControllerMacNativeProfile()
		{
		}
	}
}
