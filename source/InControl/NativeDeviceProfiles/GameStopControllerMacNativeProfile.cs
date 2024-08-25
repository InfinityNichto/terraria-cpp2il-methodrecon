using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200012F RID: 303
	[Preserve]
	[NativeInputDeviceProfile]
	public class GameStopControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x000211C0 File Offset: 0x0001F3C0
		public override void Define()
		{
			base.Define();
			this.deviceName = "GameStop Controller";
			this.deviceNotes = "GameStop Controller on Mac";
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000211EC File Offset: 0x0001F3EC
		public GameStopControllerMacNativeProfile()
		{
		}
	}
}
