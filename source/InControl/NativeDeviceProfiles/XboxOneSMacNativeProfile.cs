﻿using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C0 RID: 448
	[Preserve]
	[NativeInputDeviceProfile]
	public class XboxOneSMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600080D RID: 2061 RVA: 0x00024910 File Offset: 0x00022B10
		public override void Define()
		{
			base.Define();
			this.deviceName = "Microsoft Xbox One S Controller";
			this.deviceNotes = "Microsoft Xbox One S Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(10);
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

		// Token: 0x0600080E RID: 2062 RVA: 0x00024A84 File Offset: 0x00022C84
		public XboxOneSMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
