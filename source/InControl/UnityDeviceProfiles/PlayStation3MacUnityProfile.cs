﻿using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000D5 RID: 213
	[Preserve]
	[UnityInputDeviceProfile]
	public class PlayStation3MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000637 RID: 1591 RVA: 0x00019E5C File Offset: 0x0001805C
		public override void Define()
		{
			base.Define();
			this.deviceName = "PlayStation 3 Controller";
			this.deviceNotes = "PlayStation 3 Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("Cross" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource16 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource17 = InputDeviceProfile.Button(16);
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

		// Token: 0x06000638 RID: 1592 RVA: 0x00019FB8 File Offset: 0x000181B8
		public PlayStation3MacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
