using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200016F RID: 367
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSaitekAV8R02MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x000221AC File Offset: 0x000203AC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Saitek AV8R02";
			this.deviceNotes = "Mad Catz Saitek AV8R02 on Mac";
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000221D8 File Offset: 0x000203D8
		public MadCatzSaitekAV8R02MacNativeProfile()
		{
		}
	}
}
