using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015C RID: 348
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzBeatPadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00021CF8 File Offset: 0x0001FEF8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Beat Pad";
			this.deviceNotes = "Mad Catz Beat Pad on Mac";
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00021D24 File Offset: 0x0001FF24
		public MadCatzBeatPadMacNativeProfile()
		{
		}
	}
}
