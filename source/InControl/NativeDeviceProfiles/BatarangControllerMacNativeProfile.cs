using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000126 RID: 294
	[Preserve]
	[NativeInputDeviceProfile]
	public class BatarangControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x00020F80 File Offset: 0x0001F180
		public override void Define()
		{
			base.Define();
			this.deviceName = "Batarang Controller";
			this.deviceNotes = "Batarang Controller on Mac";
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00020FAC File Offset: 0x0001F1AC
		public BatarangControllerMacNativeProfile()
		{
		}
	}
}
