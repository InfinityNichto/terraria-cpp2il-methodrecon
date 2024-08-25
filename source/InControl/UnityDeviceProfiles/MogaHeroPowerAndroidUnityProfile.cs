﻿using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000A3 RID: 163
	[Preserve]
	[UnityInputDeviceProfile]
	public class MogaHeroPowerAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005CD RID: 1485 RVA: 0x00014FD4 File Offset: 0x000131D4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Moga Hero Power";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "Moga Hero Power on Android";
			if ("Android" == null || "Android" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(9);
				InputControlMapping inputControlMapping = InputDeviceProfile.LeftTriggerMapping(12);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.RightTriggerMapping(11);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						InputControlMapping inputControlMapping3 = InputDeviceProfile.LeftStickLeftMapping(0);
						if (inputControlMapping3 == null || inputControlMapping3 != null)
						{
							InputControlMapping inputControlMapping4 = InputDeviceProfile.LeftStickRightMapping(0);
							if (inputControlMapping4 == null || inputControlMapping4 != null)
							{
								InputControlMapping inputControlMapping5 = InputDeviceProfile.LeftStickUpMapping(1);
								if (inputControlMapping5 == null || inputControlMapping5 != null)
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.LeftStickDownMapping(1);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickLeftMapping(2);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickRightMapping(2);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlMapping inputControlMapping9 = InputDeviceProfile.RightStickUpMapping(3);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.RightStickDownMapping(3);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
														InputControlMapping inputControlMapping11 = InputDeviceProfile.DPadLeftMapping(4);
														if (inputControlMapping11 == null || inputControlMapping11 != null)
														{
															InputControlMapping inputControlMapping12 = InputDeviceProfile.DPadRightMapping(4);
															if (inputControlMapping12 == null || inputControlMapping12 != null)
															{
																InputControlMapping inputControlMapping13 = InputDeviceProfile.DPadUpMapping(5);
																if (inputControlMapping13 == null || inputControlMapping13 != null)
																{
																	InputControlMapping inputControlMapping14 = InputDeviceProfile.DPadDownMapping(5);
																	if (inputControlMapping14 == null || inputControlMapping14 != null)
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
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00015164 File Offset: 0x00013364
		public MogaHeroPowerAndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
