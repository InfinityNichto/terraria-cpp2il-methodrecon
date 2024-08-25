using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018D RID: 397
	[NativeInputDeviceProfile]
	[Preserve]
	public class PowerAAirflowControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007A7 RID: 1959 RVA: 0x00022D00 File Offset: 0x00020F00
		public override void Define()
		{
			base.Define();
			this.deviceName = "PowerA Airflow Controller";
			this.deviceNotes = "PowerA Airflow Controller on Mac";
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00022D2C File Offset: 0x00020F2C
		public PowerAAirflowControllerMacNativeProfile()
		{
		}
	}
}
