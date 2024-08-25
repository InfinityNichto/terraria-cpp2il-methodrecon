using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000133 RID: 307
	[Preserve]
	[NativeInputDeviceProfile]
	public class HarmonixKeyboardMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x000212BC File Offset: 0x0001F4BC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Harmonix Keyboard";
			this.deviceNotes = "Harmonix Keyboard on Mac";
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000212E8 File Offset: 0x0001F4E8
		public HarmonixKeyboardMacNativeProfile()
		{
		}
	}
}
