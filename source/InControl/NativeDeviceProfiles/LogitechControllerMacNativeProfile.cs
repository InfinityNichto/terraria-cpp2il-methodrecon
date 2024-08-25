using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000154 RID: 340
	[NativeInputDeviceProfile]
	[Preserve]
	public class LogitechControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000735 RID: 1845 RVA: 0x00021AE4 File Offset: 0x0001FCE4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech Controller";
			this.deviceNotes = "Logitech Controller on Mac";
			this.deviceNotes = "Logitech Controller on Mac";
			OptionalUInt16 optionalUInt;
			this.deviceClass = optionalUInt;
			this.matchers = this;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00021B28 File Offset: 0x0001FD28
		public LogitechControllerMacNativeProfile()
		{
		}
	}
}
