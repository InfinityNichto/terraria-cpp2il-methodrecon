using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000152 RID: 338
	[NativeInputDeviceProfile]
	[Preserve]
	public class KonamiDancePadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x00021A64 File Offset: 0x0001FC64
		public override void Define()
		{
			base.Define();
			this.deviceName = "Konami Dance Pad";
			this.deviceNotes = "Konami Dance Pad on Mac";
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00021A90 File Offset: 0x0001FC90
		public KonamiDancePadMacNativeProfile()
		{
		}
	}
}
