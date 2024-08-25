using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001CA RID: 458
	[Preserve]
	[NativeInputDeviceProfile]
	public class EightBitdoNES30ProWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000821 RID: 2081 RVA: 0x000254C0 File Offset: 0x000236C0
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo NES30 Pro Controller";
			if ("Windows" == null || "Windows" != null)
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

		// Token: 0x06000822 RID: 2082 RVA: 0x000255C4 File Offset: 0x000237C4
		public EightBitdoNES30ProWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
