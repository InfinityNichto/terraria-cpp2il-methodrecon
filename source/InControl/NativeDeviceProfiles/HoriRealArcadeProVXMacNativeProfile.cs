using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014B RID: 331
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriRealArcadeProVXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000723 RID: 1827 RVA: 0x000218B8 File Offset: 0x0001FAB8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Real Arcade Pro VX";
			this.deviceNotes = "Hori Real Arcade Pro VX on Mac";
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000218E4 File Offset: 0x0001FAE4
		public HoriRealArcadeProVXMacNativeProfile()
		{
		}
	}
}
