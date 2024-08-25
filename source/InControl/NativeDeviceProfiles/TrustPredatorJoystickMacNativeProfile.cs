using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AC RID: 428
	[Preserve]
	[NativeInputDeviceProfile]
	public class TrustPredatorJoystickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x000234B4 File Offset: 0x000216B4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Trust Predator Joystick";
			this.deviceNotes = "Trust Predator Joystick on Mac";
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000234E0 File Offset: 0x000216E0
		public TrustPredatorJoystickMacNativeProfile()
		{
		}
	}
}
