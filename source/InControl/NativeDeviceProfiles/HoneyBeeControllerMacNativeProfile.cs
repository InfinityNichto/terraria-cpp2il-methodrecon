using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000134 RID: 308
	[NativeInputDeviceProfile]
	[Preserve]
	public class HoneyBeeControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x000212FC File Offset: 0x0001F4FC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Honey Bee Controller";
			this.deviceNotes = "Honey Bee Controller on Mac";
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00021328 File Offset: 0x0001F528
		public HoneyBeeControllerMacNativeProfile()
		{
		}
	}
}
