using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200014F RID: 335
	[Preserve]
	[NativeInputDeviceProfile]
	public class InjusticeFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x000219A4 File Offset: 0x0001FBA4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Injustice Fight Stick";
			this.deviceNotes = "Injustice Fight Stick on Mac";
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000219D0 File Offset: 0x0001FBD0
		public InjusticeFightStickMacNativeProfile()
		{
		}
	}
}
