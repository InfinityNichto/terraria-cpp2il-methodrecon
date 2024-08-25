using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000CB RID: 203
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoSNES30MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000623 RID: 1571 RVA: 0x00018F48 File Offset: 0x00017148
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SNES30 Controller";
			this.deviceNotes = "8Bitdo SNES30 Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(int.MinValue);
				if (-2147483648 == 0 || -2147483648 != 0)
				{
					InputControlSource inputControlSource5 = InputDeviceProfile.Button(6);
					if (-2147483648 == 0 || -2147483648 != 0)
					{
						InputControlSource inputControlSource6 = InputDeviceProfile.Button(7);
						if (-2147483648 == 0 || -2147483648 != 0)
						{
							InputControlSource inputControlSource7 = InputDeviceProfile.Button(10);
							if (-2147483648 == 0 || -2147483648 != 0)
							{
								InputControlSource inputControlSource8 = InputDeviceProfile.Button(11);
								if (-2147483648 == 0 || -2147483648 != 0)
								{
									InputControlSource inputControlSource9 = InputDeviceProfile.Analog(0);
									if (-2147483648 == 0 || -2147483648 != 0)
									{
										InputControlSource inputControlSource10 = InputDeviceProfile.Analog(0);
										if (-2147483648 == 0 || -2147483648 != 0)
										{
											InputControlSource inputControlSource11 = InputDeviceProfile.Analog(1);
											if (-2147483648 == 0 || -2147483648 != 0)
											{
												InputControlSource inputControlSource12 = InputDeviceProfile.Analog(1);
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
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001907C File Offset: 0x0001727C
		public EightBitdoSNES30MacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
