using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001BC RID: 444
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerANintendoSwitchMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x0002440C File Offset: 0x0002260C
		public override void Define()
		{
			base.Define();
			this.deviceName = "PowerA Nintendo Switch Controller";
			this.deviceNotes = "PowerA Nintendo Switch Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("Action3" == null)
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
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource16 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource17 = InputDeviceProfile.Button(16);
				InputControlSource inputControlSource18 = InputDeviceProfile.Button(17);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource26 = InputDeviceProfile.Analog(3);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0002452C File Offset: 0x0002272C
		public PowerANintendoSwitchMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
