using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000A8 RID: 168
	[Preserve]
	[UnityInputDeviceProfile]
	public class NintendoSwitchProAndroidProfile : InputDeviceProfile
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x000156F8 File Offset: 0x000138F8
		public override void Define()
		{
			base.Define();
			this.deviceName = "Nintendo Switch Pro Controller";
			this.deviceNotes = "Nintendo Switch Pro Controller on Android";
			if (("Android" == null || "Android" != null) && ("Amazon AFT" == null || "Amazon AFT" != null))
			{
				if ("B" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(5);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00015810 File Offset: 0x00013A10
		public NintendoSwitchProAndroidProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
