using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000079 RID: 121
	[Preserve]
	[UnityInputDeviceProfile]
	public class BuffaloClassicAmazonUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x00011208 File Offset: 0x0000F408
		public override void Define()
		{
			base.Define();
			this.deviceName = "Buffalo Class Gamepad";
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceNotes = "Buffalo Class Gamepad on Amazon Fire TV";
			if ("Amazon AFT" == null || "Amazon AFT" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(15);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(16);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(17);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(18);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(19);
				InputControlMapping inputControlMapping = InputDeviceProfile.DPadLeftMapping(0);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.DPadRightMapping(0);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						InputControlMapping inputControlMapping3 = InputDeviceProfile.DPadUpMapping(1);
						if ((inputControlMapping3 == null || inputControlMapping3 != null) && (InputDeviceProfile.DPadDownMapping(1) == null || inputControlMapping3 != null))
						{
							return;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000112BC File Offset: 0x0000F4BC
		public BuffaloClassicAmazonUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
