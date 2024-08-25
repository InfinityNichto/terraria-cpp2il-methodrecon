using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000EE RID: 238
	[Preserve]
	[UnityInputDeviceProfile]
	public class Xbox360MacSafariUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x0001C29C File Offset: 0x0001A49C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Xbox 360 Controller";
			this.deviceNotes = "Xbox 360 Controller on Mac Safari";
			if ("Mac Safari" == null || "Mac Safari" != null)
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
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(5);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		public Xbox360MacSafariUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
