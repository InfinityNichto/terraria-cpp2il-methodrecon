using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000144 RID: 324
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRealArcadeProEXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x000216FC File Offset: 0x0001F8FC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Real Arcade Pro EX";
			this.deviceNotes = "Hori Real Arcade Pro EX on Mac";
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00021728 File Offset: 0x0001F928
		public HoriRealArcadeProEXMacNativeProfile()
		{
		}
	}
}
