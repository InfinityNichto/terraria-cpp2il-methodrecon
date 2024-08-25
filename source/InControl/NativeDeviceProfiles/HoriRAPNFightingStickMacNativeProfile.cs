using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000143 RID: 323
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriRAPNFightingStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06000713 RID: 1811 RVA: 0x000216BC File Offset: 0x0001F8BC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Hori RAP N Fighting Stick";
			this.deviceNotes = "Hori RAP N Fighting Stick on Mac";
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000216E8 File Offset: 0x0001F8E8
		public HoriRAPNFightingStickMacNativeProfile()
		{
		}
	}
}
