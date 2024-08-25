using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000DF RID: 223
	[UnityInputDeviceProfile]
	[Preserve]
	public class XTR55_G2_MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x0001AEB8 File Offset: 0x000190B8
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

		// Token: 0x0600064C RID: 1612 RVA: 0x0001AEFC File Offset: 0x000190FC
		public XTR55_G2_MacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
