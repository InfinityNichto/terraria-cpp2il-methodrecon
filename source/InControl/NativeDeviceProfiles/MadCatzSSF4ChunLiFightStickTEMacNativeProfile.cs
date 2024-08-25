using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000174 RID: 372
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSSF4ChunLiFightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000775 RID: 1909 RVA: 0x000222E0 File Offset: 0x000204E0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz SSF4 Chun-Li Fight Stick TE";
			this.deviceNotes = "Mad Catz SSF4 Chun-Li Fight Stick TE on Mac";
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0002230C File Offset: 0x0002050C
		public MadCatzSSF4ChunLiFightStickTEMacNativeProfile()
		{
		}
	}
}
