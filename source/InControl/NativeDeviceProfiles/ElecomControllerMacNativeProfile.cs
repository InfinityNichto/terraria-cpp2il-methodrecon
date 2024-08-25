using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012D RID: 301
	[Preserve]
	[NativeInputDeviceProfile]
	public class ElecomControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006E7 RID: 1767 RVA: 0x00021140 File Offset: 0x0001F340
		public override void Define()
		{
			base.Define();
			this.deviceName = "Elecom Controller";
			this.deviceNotes = "Elecom Controller on Mac";
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0002116C File Offset: 0x0001F36C
		public ElecomControllerMacNativeProfile()
		{
		}
	}
}
