using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018A RID: 394
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x00022ACC File Offset: 0x00020CCC
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Xbox 360 Controller";
			this.deviceNotes = "PDP Xbox 360 Controller on Mac";
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00022AF8 File Offset: 0x00020CF8
		public PDPXbox360ControllerMacNativeProfile()
		{
		}
	}
}
