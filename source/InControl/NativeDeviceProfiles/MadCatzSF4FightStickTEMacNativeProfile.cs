using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000172 RID: 370
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzSF4FightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000771 RID: 1905 RVA: 0x0002226C File Offset: 0x0002046C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz SF4 Fight Stick TE";
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0002228C File Offset: 0x0002048C
		public MadCatzSF4FightStickTEMacNativeProfile()
		{
		}
	}
}
