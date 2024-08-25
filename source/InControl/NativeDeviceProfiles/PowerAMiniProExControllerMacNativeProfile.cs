using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000190 RID: 400
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerAMiniProExControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007AD RID: 1965 RVA: 0x00022DC0 File Offset: 0x00020FC0
		public override void Define()
		{
			base.Define();
			this.deviceName = "PowerA Mini Pro Ex Controller";
			this.deviceNotes = "PowerA Mini Pro Ex Controller on Mac";
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00022DEC File Offset: 0x00020FEC
		public PowerAMiniProExControllerMacNativeProfile()
		{
		}
	}
}
