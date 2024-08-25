using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013E RID: 318
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriFightingStickMiniMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x0002157C File Offset: 0x0001F77C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Fighting Stick Mini";
			this.deviceNotes = "Hori Fighting Stick Mini on Mac";
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000215A8 File Offset: 0x0001F7A8
		public HoriFightingStickMiniMacNativeProfile()
		{
		}
	}
}
