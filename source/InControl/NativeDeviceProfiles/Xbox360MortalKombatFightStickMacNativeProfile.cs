using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AE RID: 430
	[Preserve]
	[NativeInputDeviceProfile]
	public class Xbox360MortalKombatFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007E9 RID: 2025 RVA: 0x00023534 File Offset: 0x00021734
		public override void Define()
		{
			base.Define();
			this.deviceNotes = "Xbox 360 Mortal Kombat Fight Stick on Mac";
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00023554 File Offset: 0x00021754
		public Xbox360MortalKombatFightStickMacNativeProfile()
		{
		}
	}
}
