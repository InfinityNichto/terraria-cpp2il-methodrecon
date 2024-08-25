using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001E7 RID: 487
	[Preserve]
	[NativeInputDeviceProfile]
	public class XInputWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x00027568 File Offset: 0x00025768
		public override void Define()
		{
			base.Define();
			this.deviceName = "XInput Controller";
			this.deviceNotes = "XInput Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				OptionalInputDeviceDriverType optionalInputDeviceDriverType = InputDeviceDriverType.XInput;
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				if (InputDeviceProfile.Button(9) != null)
				{
					InputControlSource inputControlSource10 = InputDeviceProfile.Button(6);
					InputControlSource inputControlSource11 = InputDeviceProfile.Button(7);
					InputControlSource inputControlSource12 = InputDeviceProfile.Button(5);
					InputControlSource inputControlSource13 = InputDeviceProfile.Button(4);
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
										InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(2);
										if (inputControlMapping6 == null || inputControlMapping6 != null)
										{
											InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping2(3);
											if (inputControlMapping7 == null || inputControlMapping7 != null)
											{
												InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping2(3);
												if (inputControlMapping8 == null || inputControlMapping8 != null)
												{
													InputControlSource inputControlSource14 = InputDeviceProfile.Analog(4);
													InputControlSource inputControlSource15 = InputDeviceProfile.Analog(5);
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

		// Token: 0x0600085C RID: 2140 RVA: 0x000276C4 File Offset: 0x000258C4
		public XInputWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
