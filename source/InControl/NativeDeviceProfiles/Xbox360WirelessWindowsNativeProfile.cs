using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001E0 RID: 480
	[Preserve]
	[NativeInputDeviceProfile]
	public class Xbox360WirelessWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x00026CDC File Offset: 0x00024EDC
		public override void Define()
		{
			base.Define();
			this.deviceName = "Xbox 360 Wireless Controller";
			this.deviceNotes = "Xbox 360 Wireless Controller on Windows";
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
				if (InputDeviceProfile.Analog(2) != null)
				{
					InputControlSource inputControlSource15 = InputDeviceProfile.Analog(2);
					InputControlSource inputControlSource16 = InputDeviceProfile.Analog(3);
					InputControlSource inputControlSource17 = InputDeviceProfile.Analog(3);
					InputControlSource inputControlSource18 = InputDeviceProfile.Analog(4);
					InputControlSource inputControlSource19 = InputDeviceProfile.Analog(4);
					InputControlSource inputControlSource20 = InputDeviceProfile.Analog(5);
					InputControlSource inputControlSource21 = InputDeviceProfile.Analog(5);
					InputControlSource inputControlSource22 = InputDeviceProfile.Analog(6);
					InputControlSource inputControlSource23 = InputDeviceProfile.Analog(6);
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00026DE4 File Offset: 0x00024FE4
		public Xbox360WirelessWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
