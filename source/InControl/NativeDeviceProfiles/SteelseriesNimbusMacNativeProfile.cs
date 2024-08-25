using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001BD RID: 445
	[Preserve]
	[NativeInputDeviceProfile]
	public class SteelseriesNimbusMacNativeProfile : InputDeviceProfile
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x00024544 File Offset: 0x00022744
		public override void Define()
		{
			base.Define();
			this.deviceName = "Steelseries Nimbus Controller";
			this.deviceNotes = "Steelseries Nimbus Controller on Mac";
			if ("OS X" == null || "OS X" != null)
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
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource10 = InputDeviceProfile.Analog(0);
				InputControlSource inputControlSource11 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource12 = InputDeviceProfile.Analog(1);
				InputControlSource inputControlSource13 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource14 = InputDeviceProfile.Analog(2);
				InputControlSource inputControlSource15 = InputDeviceProfile.Analog(3);
				if (InputDeviceProfile.Analog(3) != null)
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002460C File Offset: 0x0002280C
		public SteelseriesNimbusMacNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
