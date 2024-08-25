using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001CF RID: 463
	[Preserve]
	[NativeInputDeviceProfile]
	public class GameCubeWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600082B RID: 2091 RVA: 0x000259C8 File Offset: 0x00023BC8
		public override void Define()
		{
			base.Define();
			this.deviceName = "GameCube Controller";
			this.deviceNotes = "GameCube Controller on Windows";
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
				InputControlSource inputControlSource9 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource10 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(7);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(7);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(6);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00025AB0 File Offset: 0x00023CB0
		public GameCubeWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
