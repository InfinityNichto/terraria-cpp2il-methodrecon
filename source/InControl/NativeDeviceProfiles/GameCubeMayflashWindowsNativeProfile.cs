using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001CE RID: 462
	[Preserve]
	[NativeInputDeviceProfile]
	public class GameCubeMayflashWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000829 RID: 2089 RVA: 0x00025878 File Offset: 0x00023A78
		public override void Define()
		{
			base.Define();
			this.deviceName = "GameCube Controller";
			this.deviceClass.value__ = (int)4E-45f;
			this.deviceNotes = "GameCube Controller on Windows via MAYFLASH adapter";
			base.UpperDeadZone = 4E-45f;
			if ("Windows" == null || "Windows" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(7);
				InputControlSource inputControlSource26 = InputDeviceProfile.Analog(7);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000259B0 File Offset: 0x00023BB0
		public GameCubeMayflashWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
