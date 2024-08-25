using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013B RID: 315
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightingCommanderMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x000214BC File Offset: 0x0001F6BC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Fighting Commander";
			this.deviceNotes = "Hori Fighting Commander on Mac";
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000214E8 File Offset: 0x0001F6E8
		public HoriFightingCommanderMacNativeProfile()
		{
		}
	}
}
