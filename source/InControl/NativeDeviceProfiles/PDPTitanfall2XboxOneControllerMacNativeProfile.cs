using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000187 RID: 391
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPTitanfall2XboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x00022A14 File Offset: 0x00020C14
		public override void Define()
		{
			base.Define();
			this.deviceName = "PDP Titanfall 2 Xbox One Controller";
			this.deviceNotes = "PDP Titanfall 2 Xbox One Controller on Mac";
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00022A40 File Offset: 0x00020C40
		public PDPTitanfall2XboxOneControllerMacNativeProfile()
		{
		}
	}
}
