using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000164 RID: 356
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFPSProMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000755 RID: 1877 RVA: 0x00021EEC File Offset: 0x000200EC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz FPS Pro";
			this.deviceNotes = "Mad Catz FPS Pro on Mac";
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00021F18 File Offset: 0x00020118
		public MadCatzFPSProMacNativeProfile()
		{
		}
	}
}
