using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000093 RID: 147
	[UnityInputDeviceProfile]
	[Preserve]
	public class EightBitdoSNES30AndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00013764 File Offset: 0x00011964
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SNES30 Controller";
			this.deviceNotes = "8Bitdo SNES30 Controller on Android";
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

		// Token: 0x060005AE RID: 1454 RVA: 0x00013808 File Offset: 0x00011A08
		public EightBitdoSNES30AndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
