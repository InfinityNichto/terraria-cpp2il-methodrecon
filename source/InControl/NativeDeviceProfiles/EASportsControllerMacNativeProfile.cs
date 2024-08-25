using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012C RID: 300
	[NativeInputDeviceProfile]
	[Preserve]
	public class EASportsControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x00021100 File Offset: 0x0001F300
		public override void Define()
		{
			base.Define();
			this.deviceName = "EA Sports Controller";
			this.deviceNotes = "EA Sports Controller on Mac";
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0002112C File Offset: 0x0001F32C
		public EASportsControllerMacNativeProfile()
		{
		}
	}
}
