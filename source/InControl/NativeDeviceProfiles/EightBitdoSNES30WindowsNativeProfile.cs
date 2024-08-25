using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001CD RID: 461
	[Preserve]
	[NativeInputDeviceProfile]
	public class EightBitdoSNES30WindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000827 RID: 2087 RVA: 0x000257B8 File Offset: 0x000239B8
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SNES30 Controller";
			this.deviceNotes = "8Bitdo SNES30 Controller on Windows";
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

		// Token: 0x06000828 RID: 2088 RVA: 0x00025860 File Offset: 0x00023A60
		public EightBitdoSNES30WindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
