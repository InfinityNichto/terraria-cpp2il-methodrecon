using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200011E RID: 286
	[Preserve]
	[UnityInputDeviceProfile]
	public class XboxOneWindows10UnityProfile : InputDeviceProfile
	{
		// Token: 0x060006C9 RID: 1737 RVA: 0x0002097C File Offset: 0x0001EB7C
		public override void Define()
		{
			base.Define();
			this.deviceName = "XBox One Controller";
			this.deviceNotes = "XBox One Controller on Windows";
			if (("Windows" == null || "Windows" != null) && ("Windows 7" == null || "Windows 7" != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		public XboxOneWindows10UnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
