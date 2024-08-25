using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C8 RID: 456
	[NativeInputDeviceProfile]
	[Preserve]
	public class AirFloPS3WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x000252E8 File Offset: 0x000234E8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Air Flo PS3 Controller";
			this.deviceNotes = "Air Flo PS3 Controller on Windows";
			if ("Windows" != null)
			{
				if ("Square" == null)
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
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(5);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000253F4 File Offset: 0x000235F4
		public AirFloPS3WindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
