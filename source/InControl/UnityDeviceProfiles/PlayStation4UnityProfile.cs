using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E5 RID: 229
	[Preserve]
	[UnityInputDeviceProfile]
	public class PlayStation4UnityProfile : InputDeviceProfile
	{
		// Token: 0x06000657 RID: 1623 RVA: 0x0001B634 File Offset: 0x00019834
		public override void Define()
		{
			base.Define();
			this.deviceName = "DUALSHOCK®4 wireless controller";
			this.deviceNotes = "DUALSHOCK®4 wireless controller on PlayStation®4 system";
			if (("PS4" == null || "PS4" != null) && ("ORBIS" == null || "ORBIS" != null))
			{
				if ("cross button" == null)
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
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(7);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(2);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0001B74C File Offset: 0x0001994C
		public PlayStation4UnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
