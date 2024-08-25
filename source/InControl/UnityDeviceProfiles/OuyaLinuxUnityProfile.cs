using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000C1 RID: 193
	[Preserve]
	[UnityInputDeviceProfile]
	public class OuyaLinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600060F RID: 1551 RVA: 0x00018190 File Offset: 0x00016390
		public override void Define()
		{
			base.Define();
			this.deviceName = "OUYA Controller";
			this.deviceClass.value__ = (int)4E-45f;
			this.deviceNotes = "OUYA Controller on Linux";
			if ("Linux" == null || "Linux" != null)
			{
				base.LowerDeadZone = 4E-45f;
				if ("O" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(9);
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
								InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickLeftMapping(3);
								if (inputControlMapping5 == null || inputControlMapping5 != null)
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(3);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(4);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(4);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlSource inputControlSource13 = InputDeviceProfile.Analog(2);
												InputControlSource inputControlSource14 = InputDeviceProfile.Analog(5);
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

		// Token: 0x06000610 RID: 1552 RVA: 0x000182F0 File Offset: 0x000164F0
		public OuyaLinuxUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
