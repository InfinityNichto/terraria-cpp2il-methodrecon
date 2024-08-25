using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000B8 RID: 184
	[Preserve]
	[UnityInputDeviceProfile]
	public class AppleTVWirelessControllerUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005F9 RID: 1529 RVA: 0x0001733C File Offset: 0x0001553C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Apple TV Controller";
			this.deviceClass.value__ = (int)4E-45f;
			this.deviceNotes = "Apple TV Controller on tvOS";
			if ("AppleTV" == null || "AppleTV" != null)
			{
				base.LowerDeadZone = 4E-45f;
				base.UpperDeadZone = 4E-45f;
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(0);
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
								InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickLeftMapping(2);
								if (inputControlMapping5 == null || inputControlMapping5 != null)
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(2);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(3);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(3);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlSource inputControlSource12 = InputDeviceProfile.Analog(10);
												InputControlSource inputControlSource13 = InputDeviceProfile.Analog(11);
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000174A0 File Offset: 0x000156A0
		public AppleTVWirelessControllerUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
