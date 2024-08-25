using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000180 RID: 384
	[Preserve]
	[NativeInputDeviceProfile]
	public class MVCTEStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x00022728 File Offset: 0x00020928
		public override void Define()
		{
			base.Define();
			this.deviceName = "MVC TE Stick";
			this.deviceNotes = "MVC TE Stick on Mac";
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00022754 File Offset: 0x00020954
		public MVCTEStickMacNativeProfile()
		{
		}
	}
}
