using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000127 RID: 295
	[Preserve]
	[NativeInputDeviceProfile]
	public class BETAOPControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x00020FC0 File Offset: 0x0001F1C0
		public override void Define()
		{
			base.Define();
			this.deviceName = "BETAOP Controller";
			this.deviceNotes = "BETAOP Controller on Mac";
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00020FEC File Offset: 0x0001F1EC
		public BETAOPControllerMacNativeProfile()
		{
		}
	}
}
