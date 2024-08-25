using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C1 RID: 449
	[Preserve]
	[NativeInputDeviceProfile]
	public class XTR55_G2_MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600080F RID: 2063 RVA: 0x00024A9C File Offset: 0x00022C9C
		public override void Define()
		{
			base.Define();
			this.deviceName = "SAILI Simulator XTR5.5 G2 FMS Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "SAILI Simulator XTR5.5 G2 FMS Controller on OS X";
			if ("OS X" == null || "OS X" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00024AE0 File Offset: 0x00022CE0
		public XTR55_G2_MacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
