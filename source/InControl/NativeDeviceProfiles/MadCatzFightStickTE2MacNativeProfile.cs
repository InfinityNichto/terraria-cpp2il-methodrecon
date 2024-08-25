using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000162 RID: 354
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFightStickTE2MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x00021E6C File Offset: 0x0002006C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Fight Stick TE2";
			this.deviceNotes = "Mad Catz Fight Stick TE2 on Mac";
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00021E98 File Offset: 0x00020098
		public MadCatzFightStickTE2MacNativeProfile()
		{
		}
	}
}
