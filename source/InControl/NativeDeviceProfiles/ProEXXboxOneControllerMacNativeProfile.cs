using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000194 RID: 404
	[Preserve]
	[NativeInputDeviceProfile]
	public class ProEXXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x00022EC0 File Offset: 0x000210C0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Pro EX Xbox One Controller";
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00022EE0 File Offset: 0x000210E0
		public ProEXXboxOneControllerMacNativeProfile()
		{
		}
	}
}
