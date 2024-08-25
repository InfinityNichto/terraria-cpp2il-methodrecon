using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200007E RID: 126
	[Preserve]
	[UnityInputDeviceProfile]
	public class NykoPlayPadProAmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x00011900 File Offset: 0x0000FB00
		public override void Define()
		{
			base.Define();
			this.deviceName = "Nyko PlayPad Pro";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "Nyko PlayPad Pro on Amazon Fire TV";
			if ("Amazon AFT" == null || "Amazon AFT" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
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
												InputControlSource inputControlSource10 = InputDeviceProfile.Analog(12);
												InputControlSource inputControlSource11 = InputDeviceProfile.Analog(11);
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

		// Token: 0x06000584 RID: 1412 RVA: 0x00011A30 File Offset: 0x0000FC30
		public NykoPlayPadProAmazonUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
