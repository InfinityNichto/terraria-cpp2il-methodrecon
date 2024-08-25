using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000125 RID: 293
	[Preserve]
	[NativeInputDeviceProfile]
	public class AtPlayControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00020F40 File Offset: 0x0001F140
		public override void Define()
		{
			base.Define();
			this.deviceName = "At Play Controller";
			this.deviceNotes = "At Play Controller on Mac";
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00020F6C File Offset: 0x0001F16C
		public AtPlayControllerMacNativeProfile()
		{
		}
	}
}
