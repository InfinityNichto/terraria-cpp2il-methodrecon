using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017F RID: 383
	[Preserve]
	[NativeInputDeviceProfile]
	public class MLGControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600078B RID: 1931 RVA: 0x000226E8 File Offset: 0x000208E8
		public override void Define()
		{
			base.Define();
			this.deviceName = "MLG Controller";
			this.deviceNotes = "MLG Controller on Mac";
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00022714 File Offset: 0x00020914
		public MLGControllerMacNativeProfile()
		{
		}
	}
}
