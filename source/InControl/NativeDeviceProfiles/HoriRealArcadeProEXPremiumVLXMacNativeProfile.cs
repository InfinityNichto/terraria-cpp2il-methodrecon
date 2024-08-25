using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000145 RID: 325
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriRealArcadeProEXPremiumVLXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000717 RID: 1815 RVA: 0x0002173C File Offset: 0x0001F93C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Real Arcade Pro EX Premium VLX";
			this.deviceNotes = "Hori Real Arcade Pro EX Premium VLX on Mac";
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00021768 File Offset: 0x0001F968
		public HoriRealArcadeProEXPremiumVLXMacNativeProfile()
		{
		}
	}
}
