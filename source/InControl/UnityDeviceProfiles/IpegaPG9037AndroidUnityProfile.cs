using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200009F RID: 159
	[Preserve]
	[UnityInputDeviceProfile]
	public class IpegaPG9037AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x0001497C File Offset: 0x00012B7C
		public override void Define()
		{
			base.Define();
			this.deviceName = "IPEGA PG-9037";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "IPEGA PG-9037 on Android";
			if ("Android" == null || "Android" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00014AF8 File Offset: 0x00012CF8
		public IpegaPG9037AndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
