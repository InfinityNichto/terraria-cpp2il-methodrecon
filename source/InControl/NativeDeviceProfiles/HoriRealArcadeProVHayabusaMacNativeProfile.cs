using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000149 RID: 329
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriRealArcadeProVHayabusaMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600071F RID: 1823 RVA: 0x00021838 File Offset: 0x0001FA38
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Real Arcade Pro V Hayabusa";
			this.deviceNotes = "Hori Real Arcade Pro V Hayabusa on Mac";
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00021864 File Offset: 0x0001FA64
		public HoriRealArcadeProVHayabusaMacNativeProfile()
		{
		}
	}
}
