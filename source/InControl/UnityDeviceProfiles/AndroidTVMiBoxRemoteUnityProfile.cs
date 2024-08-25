using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000082 RID: 130
	[UnityInputDeviceProfile]
	[Preserve]
	public class AndroidTVMiBoxRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00011EF8 File Offset: 0x000100F8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Xiaomi Remote";
			this.deviceClass = InputDeviceClass.Remote;
			this.deviceNotes = "Xiaomi Remote on Android TV";
			if ("Android" == null || "Android" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlMapping inputControlMapping = InputDeviceProfile.DPadLeftMapping(4);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.DPadRightMapping(4);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						InputControlMapping inputControlMapping3 = InputDeviceProfile.DPadUpMapping(5);
						if (inputControlMapping3 == null || inputControlMapping3 != null)
						{
							InputControlMapping inputControlMapping4 = InputDeviceProfile.DPadDownMapping(5);
							if (inputControlMapping4 == null || inputControlMapping4 != null)
							{
								return;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00011F84 File Offset: 0x00010184
		public AndroidTVMiBoxRemoteUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
