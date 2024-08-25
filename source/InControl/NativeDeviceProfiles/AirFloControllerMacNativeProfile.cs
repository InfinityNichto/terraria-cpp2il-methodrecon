using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000123 RID: 291
	[Preserve]
	[NativeInputDeviceProfile]
	public class AirFloControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006D3 RID: 1747 RVA: 0x00020EC0 File Offset: 0x0001F0C0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Air Flo Controller";
			this.deviceNotes = "Air Flo Controller on Mac";
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00020EEC File Offset: 0x0001F0EC
		public AirFloControllerMacNativeProfile()
		{
		}
	}
}
