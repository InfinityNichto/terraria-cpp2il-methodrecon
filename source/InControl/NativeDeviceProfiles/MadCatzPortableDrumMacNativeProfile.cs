using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200016D RID: 365
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzPortableDrumMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x0002212C File Offset: 0x0002032C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Portable Drum";
			this.deviceNotes = "Mad Catz Portable Drum on Mac";
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00022158 File Offset: 0x00020358
		public MadCatzPortableDrumMacNativeProfile()
		{
		}
	}
}
