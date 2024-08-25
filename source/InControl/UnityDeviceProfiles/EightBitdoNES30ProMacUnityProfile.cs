using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000C9 RID: 201
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoNES30ProMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x00018D60 File Offset: 0x00016F60
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo NES30 Pro Controller";
			this.deviceNotes = "8Bitdo NES30 Pro Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				this.matchers = "OS X";
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(14);
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

		// Token: 0x06000620 RID: 1568 RVA: 0x00018E74 File Offset: 0x00017074
		public EightBitdoNES30ProMacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
