using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000142 RID: 322
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriPadUltimateMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000711 RID: 1809 RVA: 0x0002167C File Offset: 0x0001F87C
		public override void Define()
		{
			base.Define();
			this.deviceName = "HoriPad Ultimate";
			this.deviceNotes = "HoriPad Ultimate on Mac";
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000216A8 File Offset: 0x0001F8A8
		public HoriPadUltimateMacNativeProfile()
		{
		}
	}
}
