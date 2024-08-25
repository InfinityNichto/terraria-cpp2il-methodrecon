using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000139 RID: 313
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriEX2ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006FF RID: 1791 RVA: 0x0002143C File Offset: 0x0001F63C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori EX2 Controller";
			this.deviceNotes = "Hori EX2 Controller on Mac";
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00021468 File Offset: 0x0001F668
		public HoriEX2ControllerMacNativeProfile()
		{
		}
	}
}
