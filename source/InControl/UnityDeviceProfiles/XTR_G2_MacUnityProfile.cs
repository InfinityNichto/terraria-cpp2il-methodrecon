using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E0 RID: 224
	[UnityInputDeviceProfile]
	[Preserve]
	public class XTR_G2_MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600064D RID: 1613 RVA: 0x0001AF14 File Offset: 0x00019114
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

		// Token: 0x0600064E RID: 1614 RVA: 0x0001AF58 File Offset: 0x00019158
		public XTR_G2_MacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
