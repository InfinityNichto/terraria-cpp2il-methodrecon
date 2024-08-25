using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000165 RID: 357
	[NativeInputDeviceProfile]
	[Preserve]
	public class MadCatzGhostReconFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x00021F2C File Offset: 0x0002012C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mad Catz Ghost Recon Fighting Stick";
			this.deviceNotes = "Mad Catz Ghost Recon Fighting Stick on Mac";
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00021F58 File Offset: 0x00020158
		public MadCatzGhostReconFightingStickMacNativeProfile()
		{
		}
	}
}
