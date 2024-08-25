using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200016B RID: 363
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzMLGFightStickTEMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000763 RID: 1891 RVA: 0x000220AC File Offset: 0x000202AC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz MLG Fight Stick TE";
			this.deviceNotes = "Mad Catz MLG Fight Stick TE on Mac";
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000220D8 File Offset: 0x000202D8
		public MadCatzMLGFightStickTEMacNativeProfile()
		{
		}
	}
}
