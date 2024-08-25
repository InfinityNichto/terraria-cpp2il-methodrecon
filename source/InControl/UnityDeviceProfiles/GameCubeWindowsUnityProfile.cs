using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000FF RID: 255
	[UnityInputDeviceProfile]
	[Preserve]
	public class GameCubeWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0001D8A8 File Offset: 0x0001BAA8
		public override void Define()
		{
			base.Define();
			this.deviceName = "GameCube Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "GameCube Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				if (InputDeviceProfile.Button(2) != null)
				{
					InputControlSource inputControlSource2 = InputDeviceProfile.Button(int.MinValue);
					if (-2147483648 == 0 || -2147483648 != 0)
					{
						InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
						if (-2147483648 == 0 || -2147483648 != 0)
						{
							InputControlSource inputControlSource4 = InputDeviceProfile.Button(9);
							if (-2147483648 == 0 || -2147483648 != 0)
							{
								InputControlSource inputControlSource5 = InputDeviceProfile.Button(7);
								if (-2147483648 == 0 || -2147483648 != 0)
								{
									InputControlSource inputControlSource6 = InputDeviceProfile.Button(4);
									if (-2147483648 == 0 || -2147483648 != 0)
									{
										InputControlSource inputControlSource7 = InputDeviceProfile.Button(5);
										if (-2147483648 == 0 || -2147483648 != 0)
										{
											InputControlSource inputControlSource8 = InputDeviceProfile.Button(12);
											if (-2147483648 == 0 || -2147483648 != 0)
											{
												InputControlSource inputControlSource9 = InputDeviceProfile.Button(14);
												if (-2147483648 == 0 || -2147483648 != 0)
												{
													InputControlSource inputControlSource10 = InputDeviceProfile.Button(15);
													if (-2147483648 == 0 || -2147483648 != 0)
													{
														InputControlSource inputControlSource11 = InputDeviceProfile.Button(13);
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
																			InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickLeftMapping(5);
																			if (inputControlMapping5 == null || inputControlMapping5 != null)
																			{
																				InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(5);
																				if (inputControlMapping6 == null || inputControlMapping6 != null)
																				{
																					InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(2);
																					if (inputControlMapping7 == null || inputControlMapping7 != null)
																					{
																						InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(2);
																						if (inputControlMapping8 == null || inputControlMapping8 != null)
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
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001DA90 File Offset: 0x0001BC90
		public GameCubeWindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
