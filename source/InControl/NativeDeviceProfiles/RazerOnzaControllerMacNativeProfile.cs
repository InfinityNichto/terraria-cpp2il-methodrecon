using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000197 RID: 407
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerOnzaControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00022F74 File Offset: 0x00021174
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Onza Controller";
			this.deviceNotes = "Razer Onza Controller on Mac";
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00022FA0 File Offset: 0x000211A0
		public RazerOnzaControllerMacNativeProfile()
		{
		}
	}
}
