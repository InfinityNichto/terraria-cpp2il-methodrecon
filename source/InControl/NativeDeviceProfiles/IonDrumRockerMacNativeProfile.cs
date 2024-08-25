using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000150 RID: 336
	[NativeInputDeviceProfile]
	[Preserve]
	public class IonDrumRockerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x000219E4 File Offset: 0x0001FBE4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Ion Drum Rocker";
			this.deviceNotes = "Ion Drum Rocker on Mac";
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00021A10 File Offset: 0x0001FC10
		public IonDrumRockerMacNativeProfile()
		{
		}
	}
}
