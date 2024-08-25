using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001BA RID: 442
	[NativeInputDeviceProfile]
	[Preserve]
	public class PlayStation3MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x00024104 File Offset: 0x00022304
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
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(16);
				InputControlSource inputControlSource16 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource17 = InputDeviceProfile.Button(9);
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

		// Token: 0x06000802 RID: 2050 RVA: 0x00024260 File Offset: 0x00022460
		public PlayStation3MacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
