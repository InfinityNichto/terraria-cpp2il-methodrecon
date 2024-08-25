using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014E RID: 334
	[NativeInputDeviceProfile]
	[Preserve]
	public class HyperkinX91MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000729 RID: 1833 RVA: 0x00021964 File Offset: 0x0001FB64
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hyperkin X91";
			this.deviceNotes = "Hyperkin X91 on Mac";
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00021990 File Offset: 0x0001FB90
		public HyperkinX91MacNativeProfile()
		{
		}
	}
}
