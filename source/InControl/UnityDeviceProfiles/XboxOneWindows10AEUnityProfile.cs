using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200011D RID: 285
	[Preserve]
	[UnityInputDeviceProfile]
	public class XboxOneWindows10AEUnityProfile : InputDeviceProfile
	{
		// Token: 0x060006C7 RID: 1735 RVA: 0x00020828 File Offset: 0x0001EA28
		public override void Define()
		{
			base.Define();
			this.deviceName = "XBox One Controller";
			this.deviceNotes = "XBox One Controller on Windows";
			if (("Windows" == null || "Windows" != null) && ("Windows 7" == null || "Windows 7" != null) && ("Windows 8" == null || "Windows 8" != null))
			{
				this.minSystemBuildNumber = 14393;
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
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(10);
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
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(8);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(9);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00020964 File Offset: 0x0001EB64
		public XboxOneWindows10AEUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
