﻿using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000BF RID: 191
	[Preserve]
	[UnityInputDeviceProfile]
	public class LogitechF710LinuxUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x00017E6C File Offset: 0x0001606C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech F710 Controller";
			this.deviceNotes = "Logitech F710 Controller on Linux";
			if ("Linux" == null || "Linux" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(6);
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
												InputControlSource inputControlSource11 = InputDeviceProfile.Analog(2);
												InputControlSource inputControlSource12 = InputDeviceProfile.Analog(5);
												InputControlMapping inputControlMapping9 = InputDeviceProfile.DPadLeftMapping(6);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.DPadRightMapping(6);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
														InputControlMapping inputControlMapping11 = InputDeviceProfile.DPadUpMapping(7);
														if (inputControlMapping11 == null || inputControlMapping11 != null)
														{
															InputControlMapping inputControlMapping12 = InputDeviceProfile.DPadDownMapping(7);
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

		// Token: 0x0600060C RID: 1548 RVA: 0x00017FE4 File Offset: 0x000161E4
		public LogitechF710LinuxUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
