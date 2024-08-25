using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000E9 RID: 233
	[Preserve]
	[UnityInputDeviceProfile]
	public class NintendoSwitchProMacChromeUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600065F RID: 1631 RVA: 0x0001BC70 File Offset: 0x00019E70
		public override void Define()
		{
			base.Define();
			this.deviceName = "Nintendo Switch Pro Controller";
			this.deviceNotes = "Nintendo Switch Pro Controller on Mac Chrome";
			if ("Mac Chrome" == null || "Mac Chrome" != null)
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
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(5);
				InputControlSource inputControlSource25 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource26 = InputDeviceProfile.Analog(6);
				InputControlSource inputControlSource27 = InputDeviceProfile.Analog(8);
				InputControlSource inputControlSource28 = InputDeviceProfile.Analog(9);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0001BD9C File Offset: 0x00019F9C
		public NintendoSwitchProMacChromeUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
