using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000148 RID: 328
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriRealArcadeProIVMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600071D RID: 1821 RVA: 0x000217F8 File Offset: 0x0001F9F8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Real Arcade Pro IV";
			this.deviceNotes = "Hori Real Arcade Pro IV on Mac";
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00021824 File Offset: 0x0001FA24
		public HoriRealArcadeProIVMacNativeProfile()
		{
		}
	}
}
