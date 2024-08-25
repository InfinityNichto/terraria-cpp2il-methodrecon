using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000146 RID: 326
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriRealArcadeProEXSEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000719 RID: 1817 RVA: 0x0002177C File Offset: 0x0001F97C
		public override void Define()
		{
			base.Define();
			this.deviceName = 1;
			this.deviceNotes = "Hori Real Arcade Pro EX SE on Mac";
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000217A4 File Offset: 0x0001F9A4
		public HoriRealArcadeProEXSEMacNativeProfile()
		{
		}
	}
}
