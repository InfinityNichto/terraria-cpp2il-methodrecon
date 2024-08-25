using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AB RID: 427
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustmasterTXGIPMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007E3 RID: 2019 RVA: 0x00023474 File Offset: 0x00021674
		public override void Define()
		{
			base.Define();
			this.deviceName = "Thrustmaster TX GIP";
			this.deviceNotes = "Thrustmaster TX GIP on Mac";
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000234A0 File Offset: 0x000216A0
		public ThrustmasterTXGIPMacNativeProfile()
		{
		}
	}
}
