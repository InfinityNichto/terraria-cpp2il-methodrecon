using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000137 RID: 311
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriDOA4ArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x000213BC File Offset: 0x0001F5BC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori DOA4 Arcade Stick";
			this.deviceNotes = "Hori DOA4 Arcade Stick on Mac";
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000213E8 File Offset: 0x0001F5E8
		public HoriDOA4ArcadeStickMacNativeProfile()
		{
		}
	}
}
