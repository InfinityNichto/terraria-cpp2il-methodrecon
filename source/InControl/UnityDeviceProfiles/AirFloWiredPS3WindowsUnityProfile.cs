using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000F7 RID: 247
	[Preserve]
	[UnityInputDeviceProfile]
	public class AirFloWiredPS3WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Air Flo Wired PS3 Controller";
			this.deviceNotes = "Air Flo Wired PS3 Controller";
			if ("Windows" == null || "Windows" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0001CFE4 File Offset: 0x0001B1E4
		public AirFloWiredPS3WindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
