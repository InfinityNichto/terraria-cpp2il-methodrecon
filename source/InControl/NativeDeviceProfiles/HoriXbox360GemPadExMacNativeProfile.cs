using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014D RID: 333
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriXbox360GemPadExMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x00021930 File Offset: 0x0001FB30
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Xbox 360 Gem Pad Ex";
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00021950 File Offset: 0x0001FB50
		public HoriXbox360GemPadExMacNativeProfile()
		{
		}
	}
}
