using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013C RID: 316
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriFightingEdgeArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x000214FC File Offset: 0x0001F6FC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Fighting Edge Arcade Stick";
			this.deviceNotes = "Hori Fighting Edge Arcade Stick on Mac";
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00021528 File Offset: 0x0001F728
		public HoriFightingEdgeArcadeStickMacNativeProfile()
		{
		}
	}
}
