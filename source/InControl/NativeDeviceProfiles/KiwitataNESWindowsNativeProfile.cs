using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020001D1 RID: 465
	[Preserve]
	[NativeInputDeviceProfile]
	public class KiwitataNESWindowsNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x00025C08 File Offset: 0x00023E08
		public override void Define()
		{
			base.Define();
			this.deviceName = "Kiwitata NES Controller";
			this.deviceNotes = "Kiwitata NES on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(9);
				InputControlMapping inputControlMapping = InputDeviceProfile.DPadLeftMapping(1);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.DPadRightMapping(1);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						InputControlMapping inputControlMapping3 = InputDeviceProfile.DPadUpMapping(0);
						if (inputControlMapping3 == null || inputControlMapping3 != null)
						{
							InputControlMapping inputControlMapping4 = InputDeviceProfile.DPadDownMapping(0);
							if (inputControlMapping4 == null || inputControlMapping4 != null)
							{
								return;
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00025CE0 File Offset: 0x00023EE0
		public KiwitataNESWindowsNativeProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
