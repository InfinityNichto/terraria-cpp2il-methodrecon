using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000091 RID: 145
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoSFC30AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005A9 RID: 1449 RVA: 0x00013528 File Offset: 0x00011728
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SFC30 Controller";
			this.deviceNotes = "8Bitdo SFC30 Controller on Android";
			if ("Android" == null || "Android" != null)
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
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource9 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource10 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(1);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000135CC File Offset: 0x000117CC
		public EightBitdoSFC30AndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
