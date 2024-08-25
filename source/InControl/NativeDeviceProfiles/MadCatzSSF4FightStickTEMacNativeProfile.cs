using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000175 RID: 373
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSSF4FightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x00022320 File Offset: 0x00020520
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz SSF4 Fight Stick TE";
			this.deviceNotes = "Mad Catz SSF4 Fight Stick TE on Mac";
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0002234C File Offset: 0x0002054C
		public MadCatzSSF4FightStickTEMacNativeProfile()
		{
		}
	}
}
