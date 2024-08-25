using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000181 RID: 385
	[Preserve]
	[NativeInputDeviceProfile]
	public class NaconGC100XFControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600078F RID: 1935 RVA: 0x00022768 File Offset: 0x00020968
		public override void Define()
		{
			base.Define();
			this.deviceName = "Nacon GC-100XF Controller";
			this.deviceNotes = "Nacon GC-100XF Controller on Mac";
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00022794 File Offset: 0x00020994
		public NaconGC100XFControllerMacNativeProfile()
		{
		}
	}
}
