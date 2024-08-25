using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013A RID: 314
	[Preserve]
	[NativeInputDeviceProfile]
	public class HORIFightingCommanderControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000701 RID: 1793 RVA: 0x0002147C File Offset: 0x0001F67C
		public override void Define()
		{
			base.Define();
			this.deviceName = "HORI Fighting Commander Controller";
			this.deviceNotes = "HORI Fighting Commander Controller on Mac";
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000214A8 File Offset: 0x0001F6A8
		public HORIFightingCommanderControllerMacNativeProfile()
		{
		}
	}
}
