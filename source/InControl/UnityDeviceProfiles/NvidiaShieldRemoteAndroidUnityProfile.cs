using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000AB RID: 171
	[Preserve]
	[UnityInputDeviceProfile]
	public class NvidiaShieldRemoteAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005DD RID: 1501 RVA: 0x00015B3C File Offset: 0x00013D3C
		public override void Define()
		{
			base.Define();
			this.deviceName = "NVIDIA Shield Remote";
			this.deviceNotes = "NVIDIA Shield Remote on Android";
			if ("Android" == null || "Android" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlMapping inputControlMapping = InputDeviceProfile.DPadLeftMapping(4);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.DPadRightMapping(4);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						InputControlMapping inputControlMapping3 = InputDeviceProfile.DPadUpMapping(5);
						if (inputControlMapping3 == null || inputControlMapping3 != null)
						{
							InputControlMapping inputControlMapping4 = InputDeviceProfile.DPadDownMapping(5);
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

		// Token: 0x060005DE RID: 1502 RVA: 0x00015BC0 File Offset: 0x00013DC0
		public NvidiaShieldRemoteAndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
