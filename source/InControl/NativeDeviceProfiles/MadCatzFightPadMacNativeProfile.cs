using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000161 RID: 353
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzFightPadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x00021E2C File Offset: 0x0002002C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz FightPad";
			this.deviceNotes = "Mad Catz FightPad on Mac";
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00021E58 File Offset: 0x00020058
		public MadCatzFightPadMacNativeProfile()
		{
		}
	}
}
