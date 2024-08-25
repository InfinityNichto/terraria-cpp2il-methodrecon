using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000158 RID: 344
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF710ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600073D RID: 1853 RVA: 0x00021BFC File Offset: 0x0001FDFC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech F710 Controller";
			this.deviceNotes = "Logitech F710 Controller on Mac";
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00021C28 File Offset: 0x0001FE28
		public LogitechF710ControllerMacNativeProfile()
		{
		}
	}
}
