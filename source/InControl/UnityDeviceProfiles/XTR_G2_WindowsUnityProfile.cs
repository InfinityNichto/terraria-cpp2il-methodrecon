using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000122 RID: 290
	[Preserve]
	[UnityInputDeviceProfile]
	public class XTR_G2_WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x00020E64 File Offset: 0x0001F064
		public override void Define()
		{
			base.Define();
			this.deviceName = "KMODEL Simulator XTR G2 FMS Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "KMODEL Simulator XTR G2 FMS Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00020EA8 File Offset: 0x0001F0A8
		public XTR_G2_WindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
