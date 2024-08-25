using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200013F RID: 319
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriFightingStickVXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x000215BC File Offset: 0x0001F7BC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Fighting Stick VX";
			this.deviceNotes = "Hori Fighting Stick VX on Mac";
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000215E8 File Offset: 0x0001F7E8
		public HoriFightingStickVXMacNativeProfile()
		{
		}
	}
}
