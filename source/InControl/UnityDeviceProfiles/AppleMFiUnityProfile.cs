using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E1 RID: 225
	[UnityInputDeviceProfile]
	[Preserve]
	public class AppleMFiUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x0001AF70 File Offset: 0x00019170
		public override void Define()
		{
			base.Define();
			this.deviceName = "Apple MFi Controller";
			this.deviceClass.value__ = (int)4E-45f;
			this.deviceNotes = "Apple MFi Controller on iOS";
			if (("iPhone" == null || "iPhone" != null) && ("iPad" == null || "iPad" != null))
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
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(int.MinValue);
				if (-2147483648 == 0 || -2147483648 != 0)
				{
					InputControlSource inputControlSource7 = InputDeviceProfile.Button(7);
					if (-2147483648 == 0 || -2147483648 != 0)
					{
						InputControlSource inputControlSource8 = InputDeviceProfile.Button(5);
						if (-2147483648 == 0 || -2147483648 != 0)
						{
							InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
							if (-2147483648 == 0 || -2147483648 != 0)
							{
								InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
								if (-2147483648 == 0 || -2147483648 != 0)
								{
									InputControlSource inputControlSource11 = InputDeviceProfile.Button(0);
									if (-2147483648 == 0 || -2147483648 != 0)
									{
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
																		if (-2147483648 == 0 || -2147483648 != 0)
																		{
																			InputControlSource inputControlSource13 = InputDeviceProfile.Analog(11);
																			if (-2147483648 == 0 || -2147483648 != 0)
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
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0001B16C File Offset: 0x0001936C
		public AppleMFiUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
