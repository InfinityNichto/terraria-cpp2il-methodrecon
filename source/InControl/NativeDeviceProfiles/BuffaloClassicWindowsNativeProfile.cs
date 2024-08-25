using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001C9 RID: 457
	[NativeInputDeviceProfile]
	[Preserve]
	public class BuffaloClassicWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x0002540C File Offset: 0x0002360C
		public override void Define()
		{
			this.deviceName = "iBuffalo Classic Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "iBuffalo Classic Controller on Windows";
			if ("Windows" != null)
			{
			}
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
			InputControlSource inputControlSource9 = InputDeviceProfile.Analog(0);
			InputControlSource inputControlSource10 = InputDeviceProfile.Analog(0);
			InputControlSource inputControlSource11 = InputDeviceProfile.Analog(1);
			InputControlSource inputControlSource12 = InputDeviceProfile.Analog(1);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000254A8 File Offset: 0x000236A8
		public BuffaloClassicWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
