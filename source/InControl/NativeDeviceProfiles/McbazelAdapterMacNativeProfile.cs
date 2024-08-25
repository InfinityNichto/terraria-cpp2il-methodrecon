using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000178 RID: 376
	[Preserve]
	[NativeInputDeviceProfile]
	public class McbazelAdapterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x000223E0 File Offset: 0x000205E0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mcbazel Adapter";
			this.deviceNotes = "Mcbazel Adapter on Mac";
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0002240C File Offset: 0x0002060C
		public McbazelAdapterMacNativeProfile()
		{
		}
	}
}
