using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200016C RID: 364
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzNeoFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x000220EC File Offset: 0x000202EC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Neo Fight Stick";
			this.deviceNotes = "Mad Catz Neo Fight Stick on Mac";
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00022118 File Offset: 0x00020318
		public MadCatzNeoFightStickMacNativeProfile()
		{
		}
	}
}
