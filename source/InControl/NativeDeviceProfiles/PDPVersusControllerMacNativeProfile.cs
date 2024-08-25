using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000189 RID: 393
	[NativeInputDeviceProfile]
	[Preserve]
	public class PDPVersusControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x00022A8C File Offset: 0x00020C8C
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Versus Controller";
			this.deviceNotes = "PDP Versus Controller on Mac";
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00022AB8 File Offset: 0x00020CB8
		public PDPVersusControllerMacNativeProfile()
		{
		}
	}
}
