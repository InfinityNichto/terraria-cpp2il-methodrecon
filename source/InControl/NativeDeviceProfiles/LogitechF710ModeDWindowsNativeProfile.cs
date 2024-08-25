using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D6 RID: 470
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechF710ModeDWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000839 RID: 2105 RVA: 0x0002616C File Offset: 0x0002436C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Logitech F710 Mode D Controller";
			this.deviceNotes = "Logitech F710 Mode D Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("X" == null)
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
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(5);
				if (InputDeviceProfile.Analog(5) != null)
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00026274 File Offset: 0x00024474
		public LogitechF710ModeDWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
