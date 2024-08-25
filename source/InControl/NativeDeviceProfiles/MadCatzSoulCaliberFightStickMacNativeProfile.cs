using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000173 RID: 371
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzSoulCaliberFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x000222A0 File Offset: 0x000204A0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Soul Caliber Fight Stick";
			this.deviceNotes = "Mad Catz Soul Caliber Fight Stick on Mac";
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000222CC File Offset: 0x000204CC
		public MadCatzSoulCaliberFightStickMacNativeProfile()
		{
		}
	}
}
