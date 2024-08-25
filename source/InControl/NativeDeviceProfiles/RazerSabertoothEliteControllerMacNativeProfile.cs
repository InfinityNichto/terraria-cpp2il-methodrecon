using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000199 RID: 409
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerSabertoothEliteControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x00022FF4 File Offset: 0x000211F4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Sabertooth Elite Controller";
			this.deviceNotes = "Razer Sabertooth Elite Controller on Mac";
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00023020 File Offset: 0x00021220
		public RazerSabertoothEliteControllerMacNativeProfile()
		{
		}
	}
}
