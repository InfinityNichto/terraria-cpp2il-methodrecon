using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000156 RID: 342
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF310ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x00021B7C File Offset: 0x0001FD7C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech F310 Controller";
			this.deviceNotes = "Logitech F310 Controller on Mac";
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00021BA8 File Offset: 0x0001FDA8
		public LogitechF310ControllerMacNativeProfile()
		{
		}
	}
}
