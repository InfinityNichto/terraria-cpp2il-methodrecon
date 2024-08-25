using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B9 RID: 441
	[NativeInputDeviceProfile]
	[Preserve]
	public class NintendoSwitchProMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007FF RID: 2047 RVA: 0x00023FC8 File Offset: 0x000221C8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Nintendo Switch Pro Controller";
			this.deviceNotes = "Nintendo Switch Pro Controller";
			if ("OS X" == null || "OS X" != null)
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
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(16);
				InputControlSource inputControlSource16 = InputDeviceProfile.Button(17);
				InputControlSource inputControlSource17 = InputDeviceProfile.Button(18);
				InputControlSource inputControlSource18 = InputDeviceProfile.Button(19);
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

		// Token: 0x06000800 RID: 2048 RVA: 0x000240EC File Offset: 0x000222EC
		public NintendoSwitchProMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
