using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000115 RID: 277
	[Preserve]
	[UnityInputDeviceProfile]
	public class PlayStation3WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060006B7 RID: 1719 RVA: 0x0001FB74 File Offset: 0x0001DD74
		public override void Define()
		{
			base.Define();
			this.deviceName = "PlayStation 3 Controller";
			this.deviceNotes = "PlayStation 3 Controller on Windows (via MotioninJoy Gamepad Tool)";
			if ("Windows" == null || "Windows" != null)
			{
				if ("Cross" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(12);
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
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(5);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(5);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlMapping inputControlMapping9 = InputDeviceProfile.DPadLeftMapping(8);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.DPadRightMapping(8);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
														InputControlMapping inputControlMapping11 = InputDeviceProfile.DPadUpMapping2(9);
														if (inputControlMapping11 == null || inputControlMapping11 != null)
														{
															InputControlMapping inputControlMapping12 = InputDeviceProfile.DPadDownMapping2(9);
															if (inputControlMapping12 == null || inputControlMapping12 != null)
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
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		public PlayStation3WindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
