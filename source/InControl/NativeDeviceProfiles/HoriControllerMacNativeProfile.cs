using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000136 RID: 310
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x0002137C File Offset: 0x0001F57C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Controller";
			this.deviceNotes = "Hori Controller on Mac";
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000213A8 File Offset: 0x0001F5A8
		public HoriControllerMacNativeProfile()
		{
		}
	}
}
