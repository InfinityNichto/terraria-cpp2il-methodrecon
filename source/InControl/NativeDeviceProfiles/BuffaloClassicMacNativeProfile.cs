using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001B0 RID: 432
	[Preserve]
	[NativeInputDeviceProfile]
	public class BuffaloClassicMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x060007ED RID: 2029 RVA: 0x000235A8 File Offset: 0x000217A8
		public override void Define()
		{
			base.Define();
			this.deviceName = "iBuffalo Classic Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "iBuffalo Classic Controller on Mac";
			if ("OS X" == null || "OS X" != null)
			{
				OptionalUInt32 optionalUInt = (uint)256;
				if ("B" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource10 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(1);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00023660 File Offset: 0x00021860
		public BuffaloClassicMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
