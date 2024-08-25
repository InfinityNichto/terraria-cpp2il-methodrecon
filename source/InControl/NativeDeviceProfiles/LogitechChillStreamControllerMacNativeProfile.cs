using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000153 RID: 339
	[NativeInputDeviceProfile]
	[Preserve]
	public class LogitechChillStreamControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech Chill Stream Controller";
			this.deviceNotes = "Logitech Chill Stream Controller on Mac";
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00021AD0 File Offset: 0x0001FCD0
		public LogitechChillStreamControllerMacNativeProfile()
		{
		}
	}
}
