using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000167 RID: 359
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzMC2ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600075B RID: 1883 RVA: 0x00021FAC File Offset: 0x000201AC
		public override void Define()
		{
			base.Define();
			this.deviceName = "MadCatz MC2 Controller";
			this.deviceNotes = "MadCatz MC2 Controller on Mac";
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00021FD8 File Offset: 0x000201D8
		public MadCatzMC2ControllerMacNativeProfile()
		{
		}
	}
}
