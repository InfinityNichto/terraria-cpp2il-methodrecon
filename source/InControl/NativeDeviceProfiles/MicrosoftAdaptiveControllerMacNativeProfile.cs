using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000179 RID: 377
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftAdaptiveControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600077F RID: 1919 RVA: 0x00022420 File Offset: 0x00020620
		public override void Define()
		{
			base.Define();
			this.deviceName = "Microsoft Adaptive Controller";
			this.deviceNotes = "Microsoft Adaptive Controller on Mac";
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0002244C File Offset: 0x0002064C
		public MicrosoftAdaptiveControllerMacNativeProfile()
		{
		}
	}
}
