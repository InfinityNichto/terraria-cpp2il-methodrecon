using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000147 RID: 327
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProHayabusaMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x000217B8 File Offset: 0x0001F9B8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Real Arcade Pro Hayabusa";
			this.deviceNotes = "Hori Real Arcade Pro Hayabusa on Mac";
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000217E4 File Offset: 0x0001F9E4
		public HoriRealArcadeProHayabusaMacNativeProfile()
		{
		}
	}
}
