using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000F1 RID: 241
	[Preserve]
	[UnityInputDeviceProfile]
	public class XboxOneMacSafariUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600066F RID: 1647 RVA: 0x0001C650 File Offset: 0x0001A850
		public override void Define()
		{
			base.Define();
			this.deviceName = "Xbox One Controller";
			this.deviceNotes = "Xbox One Controller on Mac Safari";
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
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource13 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource14 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource16 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource17 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource18 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource19 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource20 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource21 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource22 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource23 = InputDeviceProfile.Analog(4);
				InputControlSource inputControlSource24 = InputDeviceProfile.Analog(5);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001C758 File Offset: 0x0001A958
		public XboxOneMacSafariUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
