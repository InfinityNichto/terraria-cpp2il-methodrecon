using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AD RID: 429
	[Preserve]
	[NativeInputDeviceProfile]
	public class TSZPelicanControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007E7 RID: 2023 RVA: 0x000234F4 File Offset: 0x000216F4
		public override void Define()
		{
			base.Define();
			this.deviceName = "TSZ Pelican Controller";
			this.deviceNotes = "TSZ Pelican Controller on Mac";
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00023520 File Offset: 0x00021720
		public TSZPelicanControllerMacNativeProfile()
		{
		}
	}
}
