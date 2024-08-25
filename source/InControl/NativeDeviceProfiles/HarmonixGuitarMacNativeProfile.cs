using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000132 RID: 306
	[Preserve]
	[NativeInputDeviceProfile]
	public class HarmonixGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F1 RID: 1777 RVA: 0x0002127C File Offset: 0x0001F47C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Harmonix Guitar";
			this.deviceNotes = "Harmonix Guitar on Mac";
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000212A8 File Offset: 0x0001F4A8
		public HarmonixGuitarMacNativeProfile()
		{
		}
	}
}
