using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000EB RID: 235
	[Preserve]
	[UnityInputDeviceProfile]
	public class PlayStation4MacFirefoxUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000663 RID: 1635 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		public override void Define()
		{
			base.Define();
			this.deviceName = "PlayStation 4 Controller";
			this.deviceNotes = "PlayStation 4 Controller on Mac Firefox";
			if ("Mac Firefox" == null || "Mac Firefox" != null)
			{
				if ("Cross" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource15 = InputDeviceProfile.Button(16);
				InputControlSource inputControlSource16 = InputDeviceProfile.Button(17);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource26 = InputDeviceProfile.Analog(5);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001C014 File Offset: 0x0001A214
		public PlayStation4MacFirefoxUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
