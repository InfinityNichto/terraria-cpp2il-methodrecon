using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000CF RID: 207
	[UnityInputDeviceProfile]
	[Preserve]
	public class LogitechF310ModeXMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x000194F8 File Offset: 0x000176F8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech F310 Controller";
			this.deviceNotes = "Logitech F310 Controller on Mac (Mode X)";
			if ("OS X" == null || "OS X" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(16);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(17);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(18);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(19);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(15);
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
												InputControlMapping inputControlMapping9 = InputDeviceProfile.LeftTriggerMapping(4);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.RightTriggerMapping(5);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
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
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001966C File Offset: 0x0001786C
		public LogitechF310ModeXMacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
