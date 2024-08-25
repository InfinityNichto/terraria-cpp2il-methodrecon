using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000A7 RID: 167
	[Preserve]
	[UnityInputDeviceProfile]
	public class NexusPlayerRemoteAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x00015654 File Offset: 0x00013854
		public override void Define()
		{
			base.Define();
			this.deviceClass = InputDeviceClass.Remote;
			this.deviceName = "Nexus Player Remote";
			this.deviceNotes = "Nexus Player Remote";
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

		// Token: 0x060005D6 RID: 1494 RVA: 0x000156E0 File Offset: 0x000138E0
		public NexusPlayerRemoteAndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
