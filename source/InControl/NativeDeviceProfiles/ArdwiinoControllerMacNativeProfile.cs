using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000124 RID: 292
	[Preserve]
	[NativeInputDeviceProfile]
	public class ArdwiinoControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x00020F00 File Offset: 0x0001F100
		public override void Define()
		{
			base.Define();
			this.deviceName = "Ardwiino Controller";
			this.deviceNotes = "Ardwiino Controller on Mac";
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00020F2C File Offset: 0x0001F12C
		public ArdwiinoControllerMacNativeProfile()
		{
		}
	}
}
