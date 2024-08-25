using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B2 RID: 434
	[NativeInputDeviceProfile]
	[Preserve]
	public class EightBitdoNES30ProUSBMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007F1 RID: 2033 RVA: 0x000237A0 File Offset: 0x000219A0
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
				if (InputDeviceProfile.Button(15) != null)
				{
					InputControlSource inputControlSource13 = InputDeviceProfile.Button(16);
					InputControlSource inputControlSource14 = InputDeviceProfile.Button(17);
					InputControlSource inputControlSource15 = InputDeviceProfile.Button(18);
					InputControlSource inputControlSource16 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource17 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource18 = InputDeviceProfile.Analog(1);
					InputControlSource inputControlSource19 = InputDeviceProfile.Analog(1);
					InputControlSource inputControlSource20 = InputDeviceProfile.Analog(2);
					InputControlSource inputControlSource21 = InputDeviceProfile.Analog(2);
					InputControlSource inputControlSource22 = InputDeviceProfile.Analog(3);
					InputControlSource inputControlSource23 = InputDeviceProfile.Analog(3);
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000238B0 File Offset: 0x00021AB0
		public EightBitdoNES30ProUSBMacNativeProfile()
		{
		}
	}
}
