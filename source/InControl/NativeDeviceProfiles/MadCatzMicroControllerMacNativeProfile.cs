using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200016A RID: 362
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzMicroControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000761 RID: 1889 RVA: 0x0002206C File Offset: 0x0002026C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Micro Controller";
			this.deviceNotes = "Mad Catz Micro Controller on Mac";
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00022098 File Offset: 0x00020298
		public MadCatzMicroControllerMacNativeProfile()
		{
		}
	}
}
