using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D8 RID: 472
	[Preserve]
	[NativeInputDeviceProfile]
	public class NintendoSwitchProWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x000263A0 File Offset: 0x000245A0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Nintendo Switch Pro Controller";
			this.deviceClass.value__ = (int)4E-45f;
			this.deviceNotes = "Nintendo Switch Pro Controller on Windows";
			base.UpperDeadZone = 4E-45f;
			if ("Windows" == null || "Windows" != null)
			{
				if ("B" == null)
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
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource26 = InputDeviceProfile.Analog(5);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000264D8 File Offset: 0x000246D8
		public NintendoSwitchProWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
