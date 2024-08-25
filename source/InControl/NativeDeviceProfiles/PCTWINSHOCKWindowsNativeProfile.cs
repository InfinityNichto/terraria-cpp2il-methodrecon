using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001DB RID: 475
	[NativeInputDeviceProfile]
	[Preserve]
	public class PCTWINSHOCKWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x00026724 File Offset: 0x00024924
		public override void Define()
		{
			base.Define();
			this.deviceName = "PC TWIN SHOCK";
			this.deviceNotes = "PC TWIN SHOCK on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("4" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(4);
				if (InputDeviceProfile.Button(5) != null)
				{
					InputControlSource inputControlSource8 = InputDeviceProfile.Button(8);
					InputControlSource inputControlSource9 = InputDeviceProfile.Button(9);
					InputControlSource inputControlSource10 = InputDeviceProfile.Button(10);
					InputControlSource inputControlSource11 = InputDeviceProfile.Button(11);
					InputControlSource inputControlSource12 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource13 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource14 = InputDeviceProfile.Analog(1);
					InputControlSource inputControlSource15 = InputDeviceProfile.Analog(1);
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

		// Token: 0x06000844 RID: 2116 RVA: 0x00026830 File Offset: 0x00024A30
		public PCTWINSHOCKWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
