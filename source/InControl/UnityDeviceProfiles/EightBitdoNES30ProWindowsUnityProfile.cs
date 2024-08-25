using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000FA RID: 250
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoNES30ProWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x0001D284 File Offset: 0x0001B484
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo NES30 Pro Controller";
			this.deviceNotes = "8Bitdo NES30 Pro Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(int.MinValue);
				if (-2147483648 == 0 || -2147483648 != 0)
				{
					InputControlSource inputControlSource15 = InputDeviceProfile.Analog(1);
					if (-2147483648 == 0 || -2147483648 != 0)
					{
						InputControlSource inputControlSource16 = InputDeviceProfile.Analog(1);
						if (-2147483648 == 0 || -2147483648 != 0)
						{
							InputControlSource inputControlSource17 = InputDeviceProfile.Analog(2);
							if (-2147483648 == 0 || -2147483648 != 0)
							{
								InputControlSource inputControlSource18 = InputDeviceProfile.Analog(2);
								if (-2147483648 == 0 || -2147483648 != 0)
								{
									InputControlSource inputControlSource19 = InputDeviceProfile.Analog(3);
									if (-2147483648 == 0 || -2147483648 != 0)
									{
										InputControlSource inputControlSource20 = InputDeviceProfile.Analog(3);
										if (-2147483648 == 0 || -2147483648 != 0)
										{
											InputControlSource inputControlSource21 = InputDeviceProfile.Analog(4);
											if (-2147483648 == 0 || -2147483648 != 0)
											{
												InputControlSource inputControlSource22 = InputDeviceProfile.Analog(4);
												if (-2147483648 == 0 || -2147483648 != 0)
												{
													InputControlSource inputControlSource23 = InputDeviceProfile.Analog(5);
													if (-2147483648 == 0 || -2147483648 != 0)
													{
														InputControlSource inputControlSource24 = InputDeviceProfile.Analog(5);
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
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001D43C File Offset: 0x0001B63C
		public EightBitdoNES30ProWindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
