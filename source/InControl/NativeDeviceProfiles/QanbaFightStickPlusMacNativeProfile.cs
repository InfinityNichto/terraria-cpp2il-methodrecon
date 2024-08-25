using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000195 RID: 405
	[Preserve]
	[NativeInputDeviceProfile]
	public class QanbaFightStickPlusMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00022EF4 File Offset: 0x000210F4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Qanba Fight Stick Plus";
			this.deviceNotes = "Qanba Fight Stick Plus on Mac";
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00022F20 File Offset: 0x00021120
		public QanbaFightStickPlusMacNativeProfile()
		{
		}
	}
}
