using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000171 RID: 369
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSF4FightStickSEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x0002222C File Offset: 0x0002042C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz SF4 Fight Stick SE";
			this.deviceNotes = "Mad Catz SF4 Fight Stick SE on Mac";
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00022258 File Offset: 0x00020458
		public MadCatzSF4FightStickSEMacNativeProfile()
		{
		}
	}
}
