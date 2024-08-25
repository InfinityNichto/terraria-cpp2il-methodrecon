using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000C8 RID: 200
	[Preserve]
	[UnityInputDeviceProfile]
	public class BuffaloClassicMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x00018C7C File Offset: 0x00016E7C
		public override void Define()
		{
			base.Define();
			this.deviceName = "iBuffalo Classic Controller";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "iBuffalo Classic Controller on Mac";
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

		// Token: 0x0600061E RID: 1566 RVA: 0x00018D48 File Offset: 0x00016F48
		public BuffaloClassicMacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
