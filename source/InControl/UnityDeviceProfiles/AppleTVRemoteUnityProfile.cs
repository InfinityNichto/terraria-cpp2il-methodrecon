using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000B7 RID: 183
	[Preserve]
	[UnityInputDeviceProfile]
	public class AppleTVRemoteUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x00017220 File Offset: 0x00015420
		public override void Define()
		{
			base.Define();
			this.deviceName = "Apple TV Remote";
			this.deviceClass.value__ = (int)6E-45f;
			this.deviceNotes = "Apple TV Remote on tvOS";
			if ("AppleTV" == null || "AppleTV" != null)
			{
				base.LowerDeadZone = 6E-45f;
				base.UpperDeadZone = 6E-45f;
				if ("TouchPad Click" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(0);
				InputControlMapping inputControlMapping = InputDeviceProfile.LeftStickLeftMapping(0);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.LeftStickRightMapping(0);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						InputControlMapping inputControlMapping3 = InputDeviceProfile.LeftStickUpMapping(1);
						if (inputControlMapping3 == null || inputControlMapping3 != null)
						{
							InputControlMapping inputControlMapping4 = InputDeviceProfile.LeftStickDownMapping(1);
							if (inputControlMapping4 == null || inputControlMapping4 != null)
							{
								InputControlSource inputControlSource4 = InputDeviceProfile.Analog(0);
								InputControlSource inputControlSource5 = InputDeviceProfile.Analog(1);
								InputControlSource inputControlSource6 = InputDeviceProfile.Analog(15);
								InputControlSource inputControlSource7 = InputDeviceProfile.Analog(16);
								InputControlSource inputControlSource8 = InputDeviceProfile.Analog(17);
								InputControlSource inputControlSource9 = InputDeviceProfile.Analog(18);
								InputControlSource inputControlSource10 = InputDeviceProfile.Analog(19);
								return;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00017324 File Offset: 0x00015524
		public AppleTVRemoteUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
