using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015D RID: 349
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzBrawlStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000747 RID: 1863 RVA: 0x00021D38 File Offset: 0x0001FF38
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Brawl Stick";
			this.deviceNotes = "Mad Catz Brawl Stick on Mac";
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00021D64 File Offset: 0x0001FF64
		public MadCatzBrawlStickMacNativeProfile()
		{
		}
	}
}
