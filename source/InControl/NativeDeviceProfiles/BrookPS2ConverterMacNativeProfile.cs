using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012A RID: 298
	[Preserve]
	[NativeInputDeviceProfile]
	public class BrookPS2ConverterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x00021080 File Offset: 0x0001F280
		public override void Define()
		{
			base.Define();
			this.deviceName = "Brook PS2 Converter";
			this.deviceNotes = "Brook PS2 Converter on Mac";
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000210AC File Offset: 0x0001F2AC
		public BrookPS2ConverterMacNativeProfile()
		{
		}
	}
}
