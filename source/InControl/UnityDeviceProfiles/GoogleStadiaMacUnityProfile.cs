using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000CD RID: 205
	[Preserve]
	[UnityInputDeviceProfile]
	public class GoogleStadiaMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x0001922C File Offset: 0x0001742C
		public override void Define()
		{
			base.Define();
			this.deviceName = "Google Stadia Controller";
			this.deviceNotes = "Google Stadia Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				if ("Capture" == null)
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
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource26 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource27 = InputDeviceProfile.Analog(5);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00019350 File Offset: 0x00017550
		public GoogleStadiaMacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
