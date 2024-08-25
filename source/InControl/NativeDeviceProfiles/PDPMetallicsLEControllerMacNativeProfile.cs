using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000186 RID: 390
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPMetallicsLEControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x000229D4 File Offset: 0x00020BD4
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Metallics LE Controller";
			this.deviceNotes = "PDP Metallics LE Controller on Mac";
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00022A00 File Offset: 0x00020C00
		public PDPMetallicsLEControllerMacNativeProfile()
		{
		}
	}
}
