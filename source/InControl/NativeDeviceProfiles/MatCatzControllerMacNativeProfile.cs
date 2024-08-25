using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000176 RID: 374
	[Preserve]
	[NativeInputDeviceProfile]
	public class MatCatzControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x00022360 File Offset: 0x00020560
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mat Catz Controller";
			this.deviceNotes = "Mat Catz Controller on Mac";
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0002238C File Offset: 0x0002058C
		public MatCatzControllerMacNativeProfile()
		{
		}
	}
}
