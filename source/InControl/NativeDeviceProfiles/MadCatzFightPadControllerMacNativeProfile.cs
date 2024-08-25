using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000160 RID: 352
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzFightPadControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x00021DEC File Offset: 0x0001FFEC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz FightPad Controller";
			this.deviceNotes = "Mad Catz FightPad Controller on Mac";
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00021E18 File Offset: 0x00020018
		public MadCatzFightPadControllerMacNativeProfile()
		{
		}
	}
}
