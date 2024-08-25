using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000117 RID: 279
	[UnityInputDeviceProfile]
	[Preserve]
	public class SaitekAviatorWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
		public override void Define()
		{
			base.Define();
			this.deviceName = "Saitek AV8R";
			this.deviceClass = InputDeviceClass.FlightStick;
			this.deviceNotes = "Saitek AV8R on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("X" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(11);
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
								InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickLeftMapping(4);
								if (inputControlMapping5 == null || inputControlMapping5 != null)
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(4);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlSource inputControlSource13 = InputDeviceProfile.Analog(5);
										InputControlSource inputControlSource14 = InputDeviceProfile.Analog(5);
										InputControlSource inputControlSource15 = InputDeviceProfile.Analog(2);
										InputControlSource inputControlSource16 = InputDeviceProfile.Analog(2);
										InputControlSource inputControlSource17 = InputDeviceProfile.Analog(3);
										InputControlSource inputControlSource18 = InputDeviceProfile.Analog(3);
										return;
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		public SaitekAviatorWindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
