using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000076 RID: 118
	[UnityInputDeviceProfile]
	[Preserve]
	public class AmazonFireTVRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000573 RID: 1395 RVA: 0x00010E58 File Offset: 0x0000F058
		public override void Define()
		{
			base.Define();
			this.deviceName = "Amazon Fire TV Remote";
			this.deviceNotes = "Amazon Fire TV Remote on Amazon Fire TV";
			if ("Amazon AFT" == null || "Amazon AFT" != null)
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

		// Token: 0x06000574 RID: 1396 RVA: 0x00010EDC File Offset: 0x0000F0DC
		public AmazonFireTVRemoteUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
