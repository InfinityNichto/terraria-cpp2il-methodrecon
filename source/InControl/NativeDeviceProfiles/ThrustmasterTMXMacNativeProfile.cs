using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001AA RID: 426
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustmasterTMXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x00023434 File Offset: 0x00021634
		public override void Define()
		{
			base.Define();
			this.deviceName = "Thrustmaster TMX";
			this.deviceNotes = "Thrustmaster TMX on Mac";
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00023460 File Offset: 0x00021660
		public ThrustmasterTMXMacNativeProfile()
		{
		}
	}
}
