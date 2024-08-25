using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000198 RID: 408
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerOnzaTEControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x00022FB4 File Offset: 0x000211B4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Onza TE Controller";
			this.deviceNotes = "Razer Onza TE Controller on Mac";
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00022FE0 File Offset: 0x000211E0
		public RazerOnzaTEControllerMacNativeProfile()
		{
		}
	}
}
