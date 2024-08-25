using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012B RID: 299
	[Preserve]
	[NativeInputDeviceProfile]
	public class DragonRiseArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x000210C0 File Offset: 0x0001F2C0
		public override void Define()
		{
			base.Define();
			this.deviceName = "DragonRise Arcade Stick";
			this.deviceNotes = "DragonRise Arcade Stick on Mac";
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000210EC File Offset: 0x0001F2EC
		public DragonRiseArcadeStickMacNativeProfile()
		{
		}
	}
}
