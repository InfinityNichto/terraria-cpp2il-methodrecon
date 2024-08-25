using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C5 RID: 453
	[NativeInputDeviceProfile]
	[Preserve]
	public class DualShock4MFiNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x00024E0C File Offset: 0x0002300C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Sony DualShock 4 Controller";
			this.deviceNotes = "Sony DualShock 4 Controller on iOS / tvOS";
			if (("iOS" == null || "iOS" != null) && ("tvOS" == null || "tvOS" != null) && ("iPhone" == null || "iPhone" != null) && ("iPad" == null || "iPad" != null) && ("AppleTV" == null || "AppleTV" != null) && ("OS X" == null || "OS X" != null))
			{
				OptionalUInt32 optionalUInt = 0U;
				if ("Cross" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(int.MinValue);
				if (-2147483648 == 0 || -2147483648 != 0)
				{
					InputControlSource inputControlSource14 = InputDeviceProfile.Button(13);
					if (-2147483648 == 0 || -2147483648 != 0)
					{
						InputControlMapping inputControlMapping = InputDeviceProfile.LeftStickLeftMapping(0);
						if (inputControlMapping == null || inputControlMapping != null)
						{
							InputControlMapping inputControlMapping2 = InputDeviceProfile.LeftStickRightMapping(0);
							if (inputControlMapping2 == null || inputControlMapping2 != null)
							{
								InputControlMapping inputControlMapping3 = InputDeviceProfile.LeftStickUpMapping2(1);
								if (inputControlMapping3 == null || inputControlMapping3 != null)
								{
									InputControlMapping inputControlMapping4 = InputDeviceProfile.LeftStickDownMapping2(1);
									if (inputControlMapping4 == null || inputControlMapping4 != null)
									{
										InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickLeftMapping(2);
										if (inputControlMapping5 == null || inputControlMapping5 != null)
										{
											if (InputDeviceProfile.RightStickRightMapping(2) != null)
											{
											}
											InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickUpMapping2(3);
											if (inputControlMapping6 == null || inputControlMapping6 != null)
											{
												InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickDownMapping2(3);
												if (inputControlMapping7 == null || inputControlMapping7 != null)
												{
													InputControlSource inputControlSource15 = InputDeviceProfile.Analog(4);
													if (-2147483648 == 0 || -2147483648 != 0)
													{
														InputControlSource inputControlSource16 = InputDeviceProfile.Analog(5);
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

		// Token: 0x06000818 RID: 2072 RVA: 0x00024FF8 File Offset: 0x000231F8
		public DualShock4MFiNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
