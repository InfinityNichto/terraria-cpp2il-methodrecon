using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000121 RID: 289
	[Preserve]
	[UnityInputDeviceProfile]
	public class XTR55_G2_WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x00020E08 File Offset: 0x0001F008
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

		// Token: 0x060006D0 RID: 1744 RVA: 0x00020E4C File Offset: 0x0001F04C
		public XTR55_G2_WindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
