using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200017E RID: 382
	[Preserve]
	[NativeInputDeviceProfile]
	public class MKKlassikFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000789 RID: 1929 RVA: 0x000226A8 File Offset: 0x000208A8
		public override void Define()
		{
			base.Define();
			this.deviceName = "MK Klassik Fight Stick";
			this.deviceNotes = "MK Klassik Fight Stick on Mac";
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000226D4 File Offset: 0x000208D4
		public MKKlassikFightStickMacNativeProfile()
		{
		}
	}
}
