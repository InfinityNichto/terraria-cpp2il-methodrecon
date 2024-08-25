using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B5 RID: 437
	[NativeInputDeviceProfile]
	[Preserve]
	public class GoogleStadiaMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x00023A3C File Offset: 0x00021C3C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Google Stadia Controller";
			this.deviceNotes = "Google Stadia Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("Capture" == null)
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
				InputControlSource inputControlSource19 = InputDeviceProfile.Button(18);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource26 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource27 = InputDeviceProfile.Analog(3);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00023B64 File Offset: 0x00021D64
		public GoogleStadiaMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
