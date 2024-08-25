using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000196 RID: 406
	[NativeInputDeviceProfile]
	[Preserve]
	public class RazerAtroxArcadeStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x00022F34 File Offset: 0x00021134
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Atrox Arcade Stick";
			this.deviceNotes = "Razer Atrox Arcade Stick on Mac";
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00022F60 File Offset: 0x00021160
		public RazerAtroxArcadeStickMacNativeProfile()
		{
		}
	}
}
