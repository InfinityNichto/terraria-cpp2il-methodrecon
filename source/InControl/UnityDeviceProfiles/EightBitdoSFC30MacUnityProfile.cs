using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000CA RID: 202
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoSFC30MacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000621 RID: 1569 RVA: 0x00018E8C File Offset: 0x0001708C
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SFC30 Controller";
			this.deviceNotes = "8Bitdo SFC30 Controller on Mac";
			if ("OS X" == null || "OS X" != null)
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

		// Token: 0x06000622 RID: 1570 RVA: 0x00018F30 File Offset: 0x00017130
		public EightBitdoSFC30MacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
