using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018F RID: 399
	[NativeInputDeviceProfile]
	[Preserve]
	public class PowerAMiniControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x00022D80 File Offset: 0x00020F80
		public override void Define()
		{
			base.Define();
			this.deviceName = "PowerA Mini Controller";
			this.deviceNotes = "PowerA Mini Controller on Mac";
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00022DAC File Offset: 0x00020FAC
		public PowerAMiniControllerMacNativeProfile()
		{
		}
	}
}
