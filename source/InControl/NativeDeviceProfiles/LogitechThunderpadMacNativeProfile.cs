using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015A RID: 346
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechThunderpadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000741 RID: 1857 RVA: 0x00021C7C File Offset: 0x0001FE7C
		public override void Define()
		{
			this.deviceName = "Logitech Thunderpad";
			this.deviceNotes = "Logitech Thunderpad on Mac";
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00021CA0 File Offset: 0x0001FEA0
		public LogitechThunderpadMacNativeProfile()
		{
		}
	}
}
