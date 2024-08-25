using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000188 RID: 392
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPTronControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x00022A54 File Offset: 0x00020C54
		public override void Define()
		{
			this.deviceName = "PDP Tron Controller";
			this.deviceNotes = "PDP Tron Controller on Mac";
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00022A78 File Offset: 0x00020C78
		public PDPTronControllerMacNativeProfile()
		{
		}
	}
}
