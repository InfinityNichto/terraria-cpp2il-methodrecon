using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001E5 RID: 485
	[NativeInputDeviceProfile]
	[Preserve]
	public class XboxOneWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x00027304 File Offset: 0x00025504
		public override void Define()
		{
			base.Define();
			this.deviceName = "Xbox One Controller";
			this.deviceNotes = "Xbox One Controller on Windows";
			if (("Windows 7" == null || "Windows 7" != null) && ("Windows 8" == null || "Windows 8" != null))
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
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(6);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00027420 File Offset: 0x00025620
		public XboxOneWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
