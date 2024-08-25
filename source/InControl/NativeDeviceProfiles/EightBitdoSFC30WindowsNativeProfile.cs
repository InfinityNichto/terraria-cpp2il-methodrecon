using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001CC RID: 460
	[NativeInputDeviceProfile]
	[Preserve]
	public class EightBitdoSFC30WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x00025704 File Offset: 0x00023904
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SFC30 Controller";
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
				InputControlSource inputControlSource9 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource10 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(3);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(3);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000257A0 File Offset: 0x000239A0
		public EightBitdoSFC30WindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
