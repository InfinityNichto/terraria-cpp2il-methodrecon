﻿using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D7 RID: 471
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF710ModeXWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x0002628C File Offset: 0x0002448C
		public override void Define()
		{
			base.Define();
			this.deviceNotes = "Logitech F710 Mode X Controller on Windows";
			if ("Windows" == null || "Windows" != null)
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
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(6);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00026388 File Offset: 0x00024588
		public LogitechF710ModeXWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
