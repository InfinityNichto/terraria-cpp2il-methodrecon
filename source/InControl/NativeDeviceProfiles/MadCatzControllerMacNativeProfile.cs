using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015F RID: 351
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x00021DAC File Offset: 0x0001FFAC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Controller";
			this.deviceNotes = "Mad Catz Controller on Mac";
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00021DD8 File Offset: 0x0001FFD8
		public MadCatzControllerMacNativeProfile()
		{
		}
	}
}
