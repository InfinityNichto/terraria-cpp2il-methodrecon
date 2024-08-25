using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000140 RID: 320
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x000215FC File Offset: 0x0001F7FC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Fight Stick";
			this.deviceNotes = "Hori Fight Stick on Mac";
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00021628 File Offset: 0x0001F828
		public HoriFightStickMacNativeProfile()
		{
		}
	}
}
