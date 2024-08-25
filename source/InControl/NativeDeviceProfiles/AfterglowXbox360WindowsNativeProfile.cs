using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C7 RID: 455
	[Preserve]
	[NativeInputDeviceProfile]
	public class AfterglowXbox360WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600081B RID: 2075 RVA: 0x000251D0 File Offset: 0x000233D0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Afterglow Xbox 360 Controller";
			this.deviceNotes = "Afterglow Xbox 360 Controller on Windows";
			if ("Windows" == null || "Windows" != null)
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
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(6);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000252D0 File Offset: 0x000234D0
		public AfterglowXbox360WindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
