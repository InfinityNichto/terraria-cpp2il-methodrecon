using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000185 RID: 389
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPMarvelControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000797 RID: 1943 RVA: 0x00022994 File Offset: 0x00020B94
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Marvel Controller";
			this.deviceNotes = "PDP Marvel Controller on Mac";
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x000229C0 File Offset: 0x00020BC0
		public PDPMarvelControllerMacNativeProfile()
		{
		}
	}
}
