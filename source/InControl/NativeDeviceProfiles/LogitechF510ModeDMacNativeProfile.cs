﻿using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B7 RID: 439
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF510ModeDMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007FB RID: 2043 RVA: 0x00023CE8 File Offset: 0x00021EE8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech F510 Controller";
			this.deviceNotes = "Logitech F510 Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource16 = InputDeviceProfile.Button(9);
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

		// Token: 0x060007FC RID: 2044 RVA: 0x00023E3C File Offset: 0x0002203C
		public LogitechF510ModeDMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
