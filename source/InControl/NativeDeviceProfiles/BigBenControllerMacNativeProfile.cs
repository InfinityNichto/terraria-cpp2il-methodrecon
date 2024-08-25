using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000128 RID: 296
	[Preserve]
	[NativeInputDeviceProfile]
	public class BigBenControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006DD RID: 1757 RVA: 0x00021000 File Offset: 0x0001F200
		public override void Define()
		{
			base.Define();
			this.deviceName = "Big Ben Controller";
			this.deviceNotes = "Big Ben Controller on Mac";
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0002102C File Offset: 0x0001F22C
		public BigBenControllerMacNativeProfile()
		{
		}
	}
}
