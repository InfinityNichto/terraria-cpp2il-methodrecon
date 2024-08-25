using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000135 RID: 309
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoriBlueSoloControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x0002133C File Offset: 0x0001F53C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori Blue Solo Controller ";
			this.deviceNotes = "Hori Blue Solo Controller\ton Mac";
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00021368 File Offset: 0x0001F568
		public HoriBlueSoloControllerMacNativeProfile()
		{
		}
	}
}
