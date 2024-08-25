using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014A RID: 330
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriRealArcadeProVKaiFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000721 RID: 1825 RVA: 0x00021878 File Offset: 0x0001FA78
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Real Arcade Pro V Kai Fighting Stick";
			this.deviceNotes = "Hori Real Arcade Pro V Kai Fighting Stick on Mac";
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000218A4 File Offset: 0x0001FAA4
		public HoriRealArcadeProVKaiFightingStickMacNativeProfile()
		{
		}
	}
}
