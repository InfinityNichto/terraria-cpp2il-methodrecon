using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200018E RID: 398
	[Preserve]
	[NativeInputDeviceProfile]
	public class POWERAFUS1ONTournamentControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007A9 RID: 1961 RVA: 0x00022D40 File Offset: 0x00020F40
		public override void Define()
		{
			base.Define();
			this.deviceName = "POWER A FUS1ON Tournament Controller";
			this.deviceNotes = "POWER A FUS1ON Tournament Controller";
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00022D6C File Offset: 0x00020F6C
		public POWERAFUS1ONTournamentControllerMacNativeProfile()
		{
		}
	}
}
