using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000F9 RID: 249
	[Preserve]
	[UnityInputDeviceProfile]
	public class BuffaloClassicWindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x0001D1A0 File Offset: 0x0001B3A0
		public override void Define()
		{
			base.Define();
			this.deviceName = "Buffalo Class Gamepad";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "Buffalo Class Gamepad on Windows";
			if ("Windows" == null || "Windows" != null)
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
				InputControlMapping inputControlMapping = InputDeviceProfile.DPadLeftMapping(0);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.DPadRightMapping(0);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						InputControlMapping inputControlMapping3 = InputDeviceProfile.DPadUpMapping(1);
						if (inputControlMapping3 == null || inputControlMapping3 != null)
						{
							InputControlMapping inputControlMapping4 = InputDeviceProfile.DPadDownMapping(1);
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

		// Token: 0x06000680 RID: 1664 RVA: 0x0001D26C File Offset: 0x0001B46C
		public BuffaloClassicWindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
