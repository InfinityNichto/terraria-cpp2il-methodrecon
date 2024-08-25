using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B3 RID: 435
	[NativeInputDeviceProfile]
	[Preserve]
	public class EightBitdoSFC30MacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x000238C4 File Offset: 0x00021AC4
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

		// Token: 0x060007F4 RID: 2036 RVA: 0x0002396C File Offset: 0x00021B6C
		public EightBitdoSFC30MacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
