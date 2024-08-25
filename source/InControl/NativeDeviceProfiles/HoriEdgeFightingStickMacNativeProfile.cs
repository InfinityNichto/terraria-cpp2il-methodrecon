using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000138 RID: 312
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriEdgeFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x000213FC File Offset: 0x0001F5FC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Edge Fighting Stick";
			this.deviceNotes = "Hori Edge Fighting Stick on Mac";
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00021428 File Offset: 0x0001F628
		public HoriEdgeFightingStickMacNativeProfile()
		{
		}
	}
}
