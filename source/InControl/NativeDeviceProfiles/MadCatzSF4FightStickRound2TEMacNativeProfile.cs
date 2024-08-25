using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000170 RID: 368
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzSF4FightStickRound2TEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600076D RID: 1901 RVA: 0x000221EC File Offset: 0x000203EC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz SF4 Fight Stick Round 2 TE";
			this.deviceNotes = "Mad Catz SF4 Fight Stick Round 2 TE on Mac";
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00022218 File Offset: 0x00020418
		public MadCatzSF4FightStickRound2TEMacNativeProfile()
		{
		}
	}
}
