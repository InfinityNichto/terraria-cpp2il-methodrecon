using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000177 RID: 375
	[NativeInputDeviceProfile]
	[Preserve]
	public class MayflashMagicNSMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x000223A0 File Offset: 0x000205A0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Mayflash Magic-NS";
			this.deviceNotes = "Mayflash Magic-NS on Mac";
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000223CC File Offset: 0x000205CC
		public MayflashMagicNSMacNativeProfile()
		{
		}
	}
}
