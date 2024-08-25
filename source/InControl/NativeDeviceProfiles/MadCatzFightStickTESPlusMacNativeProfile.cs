using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000163 RID: 355
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFightStickTESPlusMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000753 RID: 1875 RVA: 0x00021EAC File Offset: 0x000200AC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Fight Stick TES Plus";
			this.deviceNotes = "Mad Catz Fight Stick TES Plus on Mac";
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00021ED8 File Offset: 0x000200D8
		public MadCatzFightStickTESPlusMacNativeProfile()
		{
		}
	}
}
