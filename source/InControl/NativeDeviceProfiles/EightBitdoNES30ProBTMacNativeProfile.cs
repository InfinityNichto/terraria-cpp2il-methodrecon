using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B1 RID: 433
	[NativeInputDeviceProfile]
	[Preserve]
	public class EightBitdoNES30ProBTMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x00023678 File Offset: 0x00021878
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo NES30 Pro Controller";
			this.deviceNotes = "8Bitdo NES30 Pro Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(16);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(17);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(18);
				InputControlSource inputControlSource16 = InputDeviceProfile.Button(19);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(3);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00023788 File Offset: 0x00021988
		public EightBitdoNES30ProBTMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
