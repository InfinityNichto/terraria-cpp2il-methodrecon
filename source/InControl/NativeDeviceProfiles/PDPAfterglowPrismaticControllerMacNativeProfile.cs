using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000183 RID: 387
	[NativeInputDeviceProfile]
	[Preserve]
	public class PDPAfterglowPrismaticControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000793 RID: 1939 RVA: 0x00022914 File Offset: 0x00020B14
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Afterglow Prismatic Controller";
			this.deviceNotes = "PDP Afterglow Prismatic Controller on Mac";
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00022940 File Offset: 0x00020B40
		public PDPAfterglowPrismaticControllerMacNativeProfile()
		{
		}
	}
}
