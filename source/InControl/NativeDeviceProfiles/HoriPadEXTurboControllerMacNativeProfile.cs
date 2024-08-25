using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000141 RID: 321
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriPadEXTurboControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600070F RID: 1807 RVA: 0x0002163C File Offset: 0x0001F83C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Pad EX Turbo Controller";
			this.deviceNotes = "Hori Pad EX Turbo Controller on Mac";
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00021668 File Offset: 0x0001F868
		public HoriPadEXTurboControllerMacNativeProfile()
		{
		}
	}
}
