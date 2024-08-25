using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C2 RID: 450
	[Preserve]
	[NativeInputDeviceProfile]
	public class XTR_G2_MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x00024AF8 File Offset: 0x00022CF8
		public override void Define()
		{
			base.Define();
			this.deviceName = "KMODEL Simulator XTR G2 FMS Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "KMODEL Simulator XTR G2 FMS Controller on OS X";
			if ("OS X" == null || "OS X" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00024B3C File Offset: 0x00022D3C
		public XTR_G2_MacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
