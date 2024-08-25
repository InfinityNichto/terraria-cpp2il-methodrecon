using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000131 RID: 305
	[NativeInputDeviceProfile]
	[Preserve]
	public class HarmonixDrumKitMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x0002123C File Offset: 0x0001F43C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Harmonix Drum Kit";
			this.deviceNotes = "Harmonix Drum Kit on Mac";
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00021268 File Offset: 0x0001F468
		public HarmonixDrumKitMacNativeProfile()
		{
		}
	}
}
