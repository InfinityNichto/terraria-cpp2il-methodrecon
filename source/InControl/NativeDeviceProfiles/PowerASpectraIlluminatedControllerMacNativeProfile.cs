using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000192 RID: 402
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerASpectraIlluminatedControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x00022E40 File Offset: 0x00021040
		public override void Define()
		{
			base.Define();
			this.deviceName = "PowerA Spectra Illuminated Controller";
			this.deviceNotes = "PowerA Spectra Illuminated Controller on Mac";
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00022E6C File Offset: 0x0002106C
		public PowerASpectraIlluminatedControllerMacNativeProfile()
		{
		}
	}
}
