using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001E9 RID: 489
	[Preserve]
	[NativeInputDeviceProfile]
	public class XTR_G2_WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x00027738 File Offset: 0x00025938
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

		// Token: 0x06000860 RID: 2144 RVA: 0x0002777C File Offset: 0x0002597C
		public XTR_G2_WindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
