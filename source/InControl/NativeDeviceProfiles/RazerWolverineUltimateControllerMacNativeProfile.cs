using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200019C RID: 412
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerWolverineUltimateControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x000230B4 File Offset: 0x000212B4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Wolverine Ultimate Controller";
			this.deviceNotes = "Razer Wolverine Ultimate Controller on Mac";
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000230E0 File Offset: 0x000212E0
		public RazerWolverineUltimateControllerMacNativeProfile()
		{
		}
	}
}
