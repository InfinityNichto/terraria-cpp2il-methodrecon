using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C6 RID: 454
	[NativeInputDeviceProfile]
	[Preserve]
	public class XboxOneMFiNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000819 RID: 2073 RVA: 0x00025010 File Offset: 0x00023210
		public override void Define()
		{
			base.Define();
			this.deviceName = "Microsoft Xbox One Controller";
			this.deviceNotes = "Microsoft Xbox One Controller on iOS / tvOS";
			if (("Microsoft Xbox One Controller on iOS / tvOS" == null || "Microsoft Xbox One Controller on iOS / tvOS" != null) && ("tvOS" == null || "tvOS" != null) && ("iPhone" == null || "iPhone" != null) && ("iPad" == null || "iPad" != null) && ("AppleTV" == null || "AppleTV" != null) && ("OS X" == null || "OS X" != null))
			{
				OptionalUInt32 optionalUInt = 0U;
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
						InputControlMapping inputControlMapping4;
						if ((inputControlMapping3 == null || inputControlMapping3 != null) && (inputControlMapping4 == null || inputControlMapping4 != null))
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
											InputControlSource inputControlSource15 = InputDeviceProfile.Analog(4);
											InputControlSource inputControlSource16 = InputDeviceProfile.Analog(5);
											return;
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

		// Token: 0x0600081A RID: 2074 RVA: 0x000251B8 File Offset: 0x000233B8
		public XboxOneMFiNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
