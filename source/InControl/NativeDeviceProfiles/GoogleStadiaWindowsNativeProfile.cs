using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D0 RID: 464
	[Preserve]
	[NativeInputDeviceProfile]
	public class GoogleStadiaWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600082D RID: 2093 RVA: 0x00025AC8 File Offset: 0x00023CC8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Google Stadia Controller";
			this.deviceNotes = "Google Stadia Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("A" == null)
				{
				}
				if (InputDeviceProfile.Button(0) != null)
				{
					InputControlSource inputControlSource = InputDeviceProfile.Button(1);
					InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
					InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
					InputControlSource inputControlSource4 = InputDeviceProfile.Button(4);
					InputControlSource inputControlSource5 = InputDeviceProfile.Button(5);
					InputControlSource inputControlSource6 = InputDeviceProfile.Button(6);
					InputControlSource inputControlSource7 = InputDeviceProfile.Button(7);
					InputControlSource inputControlSource8 = InputDeviceProfile.Button(8);
					InputControlSource inputControlSource9 = InputDeviceProfile.Button(9);
					InputControlSource inputControlSource10 = InputDeviceProfile.Button(10);
					InputControlSource inputControlSource11 = InputDeviceProfile.Button(11);
					InputControlSource inputControlSource12 = InputDeviceProfile.Button(12);
					InputControlSource inputControlSource13 = InputDeviceProfile.Button(13);
					InputControlSource inputControlSource14 = InputDeviceProfile.Button(14);
					InputControlSource inputControlSource15 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource16 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource17 = InputDeviceProfile.Analog(1);
					InputControlSource inputControlSource18 = InputDeviceProfile.Analog(1);
					InputControlSource inputControlSource19 = InputDeviceProfile.Analog(2);
					InputControlSource inputControlSource20 = InputDeviceProfile.Analog(2);
					InputControlSource inputControlSource21 = InputDeviceProfile.Analog(3);
					InputControlSource inputControlSource22 = InputDeviceProfile.Analog(3);
					if (InputDeviceProfile.Analog(6) != null)
					{
						InputControlSource inputControlSource23 = InputDeviceProfile.Analog(6);
						InputControlSource inputControlSource24 = InputDeviceProfile.Analog(7);
						InputControlSource inputControlSource25 = InputDeviceProfile.Analog(7);
						return;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00025BF0 File Offset: 0x00023DF0
		public GoogleStadiaWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
