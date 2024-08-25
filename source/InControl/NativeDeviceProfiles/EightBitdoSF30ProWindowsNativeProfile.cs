using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001CB RID: 459
	[NativeInputDeviceProfile]
	[Preserve]
	public class EightBitdoSF30ProWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000823 RID: 2083 RVA: 0x000255DC File Offset: 0x000237DC
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SF30 Pro Controller";
			this.deviceNotes = "8Bitdo SF30 Pro Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				if (InputDeviceProfile.Button(1) != null && InputDeviceProfile.Button(3) != null)
				{
					InputControlSource inputControlSource2 = InputDeviceProfile.Button(4);
					InputControlSource inputControlSource3 = InputDeviceProfile.Button(6);
					InputControlSource inputControlSource4 = InputDeviceProfile.Button(7);
					InputControlSource inputControlSource5 = InputDeviceProfile.Button(8);
					InputControlSource inputControlSource6 = InputDeviceProfile.Button(9);
					InputControlSource inputControlSource7 = InputDeviceProfile.Button(10);
					InputControlSource inputControlSource8 = InputDeviceProfile.Button(11);
					InputControlSource inputControlSource9 = InputDeviceProfile.Button(13);
					InputControlSource inputControlSource10 = InputDeviceProfile.Button(14);
					InputControlSource inputControlSource11 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource12 = InputDeviceProfile.Analog(0);
					InputControlSource inputControlSource13 = InputDeviceProfile.Analog(1);
					InputControlSource inputControlSource14 = InputDeviceProfile.Analog(1);
					InputControlSource inputControlSource15 = InputDeviceProfile.Analog(2);
					InputControlSource inputControlSource16 = InputDeviceProfile.Analog(2);
					InputControlSource inputControlSource17 = InputDeviceProfile.Analog(3);
					InputControlSource inputControlSource18 = InputDeviceProfile.Analog(3);
					InputControlSource inputControlSource19 = InputDeviceProfile.Analog(6);
					InputControlSource inputControlSource20 = InputDeviceProfile.Analog(6);
					InputControlSource inputControlSource21 = InputDeviceProfile.Analog(7);
					InputControlSource inputControlSource22 = InputDeviceProfile.Analog(7);
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000256EC File Offset: 0x000238EC
		public EightBitdoSF30ProWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
