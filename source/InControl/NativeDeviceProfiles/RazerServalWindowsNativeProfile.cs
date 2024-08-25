using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001DD RID: 477
	[NativeInputDeviceProfile]
	[Preserve]
	public class RazerServalWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x0002697C File Offset: 0x00024B7C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Razer Serval Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "Razer Serval Controller on Windows";
			if ("Windows" != null)
			{
				if ("A" == null)
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
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(7);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(7);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00026A84 File Offset: 0x00024C84
		public RazerServalWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
