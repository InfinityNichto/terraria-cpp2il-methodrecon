using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001E1 RID: 481
	[NativeInputDeviceProfile]
	[Preserve]
	public class XboxOneEliteWindows10AENativeProfile : InputDeviceProfile
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x00026DFC File Offset: 0x00024FFC
		public override void Define()
		{
			if (("Windows" == null || "Windows" != null) && ("Windows 7" == null || "Windows 7" != null) && ("Windows 8" == null || "Windows 8" != null))
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
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(6);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00026F14 File Offset: 0x00025114
		public XboxOneEliteWindows10AENativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
