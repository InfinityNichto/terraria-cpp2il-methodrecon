using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000130 RID: 304
	[Preserve]
	[NativeInputDeviceProfile]
	public class GuitarHeroControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x00021200 File Offset: 0x0001F400
		public override void Define()
		{
			base.Define();
			this.deviceName = 1;
			this.deviceNotes = "Guitar Hero Controller on Mac";
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00021228 File Offset: 0x0001F428
		public GuitarHeroControllerMacNativeProfile()
		{
		}
	}
}
