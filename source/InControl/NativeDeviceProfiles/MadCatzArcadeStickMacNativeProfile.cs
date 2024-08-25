using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015B RID: 347
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x00021CB8 File Offset: 0x0001FEB8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Arcade Stick";
			this.deviceNotes = "Mad Catz Arcade Stick on Mac";
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00021CE4 File Offset: 0x0001FEE4
		public MadCatzArcadeStickMacNativeProfile()
		{
		}
	}
}
