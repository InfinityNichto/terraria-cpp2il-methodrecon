using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000169 RID: 361
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzMicroConControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600075F RID: 1887 RVA: 0x0002202C File Offset: 0x0002022C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz MicroCon Controller";
			this.deviceNotes = "Mad Catz MicroCon Controller on Mac";
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00022058 File Offset: 0x00020258
		public MadCatzMicroConControllerMacNativeProfile()
		{
		}
	}
}
