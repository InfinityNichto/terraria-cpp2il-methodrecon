using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000129 RID: 297
	[Preserve]
	[NativeInputDeviceProfile]
	public class BrookNeoGeoConverterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006DF RID: 1759 RVA: 0x00021040 File Offset: 0x0001F240
		public override void Define()
		{
			base.Define();
			this.deviceName = "Brook NeoGeo Converter";
			this.deviceNotes = "Brook NeoGeo Converter on Mac";
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0002106C File Offset: 0x0001F26C
		public BrookNeoGeoConverterMacNativeProfile()
		{
		}
	}
}
