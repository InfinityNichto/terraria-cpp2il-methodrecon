using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019B RID: 411
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerWildcatControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x00023074 File Offset: 0x00021274
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Wildcat Controller";
			this.deviceNotes = "Razer Wildcat Controller on Mac";
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000230A0 File Offset: 0x000212A0
		public RazerWildcatControllerMacNativeProfile()
		{
		}
	}
}
