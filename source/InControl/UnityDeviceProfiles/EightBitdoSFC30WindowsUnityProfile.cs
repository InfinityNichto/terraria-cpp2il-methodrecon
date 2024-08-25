using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000FB RID: 251
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoSFC30WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x0001D454 File Offset: 0x0001B654
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SFC30 Controller";
			this.deviceNotes = "8Bitdo SFC30 Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource9 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource10 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(1);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
		public EightBitdoSFC30WindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
