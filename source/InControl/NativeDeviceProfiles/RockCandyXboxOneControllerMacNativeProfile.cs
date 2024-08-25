using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001A4 RID: 420
	[Preserve]
	[NativeInputDeviceProfile]
	public class RockCandyXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x000232B4 File Offset: 0x000214B4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Rock Candy Xbox One Controller";
			this.deviceNotes = "Rock Candy Xbox One Controller on Mac";
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000232E0 File Offset: 0x000214E0
		public RockCandyXboxOneControllerMacNativeProfile()
		{
		}
	}
}
