using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000D6 RID: 214
	[Preserve]
	[UnityInputDeviceProfile]
	public class PlayStation4MacBluetoothUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x00019FD0 File Offset: 0x000181D0
		public override void Define()
		{
			base.Define();
			this.deviceName = "PlayStation 4 Controller";
			this.deviceNotes = "PlayStation 4 Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				string text = "Sony Interactive Entertainment DUALSHOCK" + "®" + "4 USB Wireless Adaptor";
				if ("Cross" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(13);
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
														InputControlMapping inputControlMapping11 = InputDeviceProfile.DPadLeftMapping(10);
														if (inputControlMapping11 == null || inputControlMapping11 != null)
														{
															InputControlMapping inputControlMapping12 = InputDeviceProfile.DPadRightMapping(10);
															if (inputControlMapping12 == null || inputControlMapping12 != null)
															{
																InputControlMapping inputControlMapping13 = InputDeviceProfile.DPadUpMapping(11);
																if (inputControlMapping13 == null || inputControlMapping13 != null)
																{
																	InputControlMapping inputControlMapping14 = InputDeviceProfile.DPadDownMapping(11);
																	if (inputControlMapping14 == null || inputControlMapping14 != null)
																	{
																		InputControlMapping inputControlMapping15 = InputDeviceProfile.DPadLeftMapping(6);
																		if (inputControlMapping15 == null || inputControlMapping15 != null)
																		{
																			InputControlMapping inputControlMapping16 = InputDeviceProfile.DPadRightMapping(6);
																			if (inputControlMapping16 == null || inputControlMapping16 != null)
																			{
																				InputControlMapping inputControlMapping17 = InputDeviceProfile.DPadUpMapping(7);
																				if (inputControlMapping17 == null || inputControlMapping17 != null)
																				{
																					InputControlMapping inputControlMapping18 = InputDeviceProfile.DPadDownMapping(7);
																					if (inputControlMapping18 == null || inputControlMapping18 != null)
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
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001A1D8 File Offset: 0x000183D8
		public PlayStation4MacBluetoothUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
