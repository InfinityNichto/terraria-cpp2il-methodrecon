using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000151 RID: 337
	[NativeInputDeviceProfile]
	[Preserve]
	public class JoytekXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x00021A24 File Offset: 0x0001FC24
		public override void Define()
		{
			base.Define();
			this.deviceName = "Joytek Xbox 360 Controller";
			this.deviceNotes = "Joytek Xbox 360 Controller on Mac";
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00021A50 File Offset: 0x0001FC50
		public JoytekXbox360ControllerMacNativeProfile()
		{
		}
	}
}
