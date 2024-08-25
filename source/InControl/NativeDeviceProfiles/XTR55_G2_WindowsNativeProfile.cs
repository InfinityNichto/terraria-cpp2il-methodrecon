using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001E8 RID: 488
	[NativeInputDeviceProfile]
	[Preserve]
	public class XTR55_G2_WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600085D RID: 2141 RVA: 0x000276DC File Offset: 0x000258DC
		public override void Define()
		{
			base.Define();
			this.deviceName = "SAILI Simulator XTR5.5 G2 FMS Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "SAILI Simulator XTR5.5 G2 FMS Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00027720 File Offset: 0x00025920
		public XTR55_G2_WindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
