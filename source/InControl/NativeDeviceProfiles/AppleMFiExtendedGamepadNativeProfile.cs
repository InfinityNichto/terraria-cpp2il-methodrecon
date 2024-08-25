using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C3 RID: 451
	[NativeInputDeviceProfile]
	[Preserve]
	public class AppleMFiExtendedGamepadNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000813 RID: 2067 RVA: 0x00024B54 File Offset: 0x00022D54
		public override void Define()
		{
			base.Define();
			this.deviceName = "{NAME} MFi Controller";
			this.deviceNotes = "MFi Controller on iOS / tvOS";
			if (("iOS" == null || "iOS" != null) && ("tvOS" == null || "tvOS" != null) && ("iPhone" == null || "iPhone" != null) && ("iPad" == null || "iPad" != null) && ("AppleTV" == null || "AppleTV" != null) && ("OS X" == null || "OS X" != null))
			{
				OptionalUInt16 optionalUInt = 0;
				OptionalUInt32 optionalUInt2 = 0U;
				if ("A" == null)
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
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(13);
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
										if ((inputControlMapping7 == null || inputControlMapping7 != null) && InputDeviceProfile.RightStickDownMapping2(3) != null)
										{
											InputControlSource inputControlSource15 = InputDeviceProfile.Analog(4);
											if (InputDeviceProfile.Analog(5) != null)
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

		// Token: 0x06000814 RID: 2068 RVA: 0x00024D00 File Offset: 0x00022F00
		public AppleMFiExtendedGamepadNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
