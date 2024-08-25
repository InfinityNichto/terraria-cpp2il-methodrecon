using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013D RID: 317
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightingStickEX2MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x0002153C File Offset: 0x0001F73C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Fighting Stick EX2";
			this.deviceNotes = "Hori Fighting Stick EX2 on Mac";
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00021568 File Offset: 0x0001F768
		public HoriFightingStickEX2MacNativeProfile()
		{
		}
	}
}
