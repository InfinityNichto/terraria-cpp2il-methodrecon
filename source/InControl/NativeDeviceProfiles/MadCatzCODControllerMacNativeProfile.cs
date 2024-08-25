using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200015E RID: 350
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzCODControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x00021D78 File Offset: 0x0001FF78
		public override void Define()
		{
			base.Define();
			this.deviceNotes = "Mad Catz COD Controller on Mac";
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00021D98 File Offset: 0x0001FF98
		public MadCatzCODControllerMacNativeProfile()
		{
		}
	}
}
