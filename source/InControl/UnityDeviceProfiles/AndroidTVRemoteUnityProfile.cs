using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000083 RID: 131
	[UnityInputDeviceProfile]
	[Preserve]
	public class AndroidTVRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00011F9C File Offset: 0x0001019C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Android TV Remote";
			this.deviceClass = InputDeviceClass.Remote;
			this.deviceNotes = "Android TV Remote on Android TV";
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

		// Token: 0x0600058E RID: 1422 RVA: 0x00012028 File Offset: 0x00010228
		public AndroidTVRemoteUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
