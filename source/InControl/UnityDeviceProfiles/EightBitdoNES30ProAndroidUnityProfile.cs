using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x0200008F RID: 143
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoNES30ProAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005A5 RID: 1445 RVA: 0x00013240 File Offset: 0x00011440
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo NES30 Pro Controller";
			this.deviceNotes = "8Bitdo NES30 Pro Controller on Android";
			if ("Android" == null || "Android" != null)
			{
				if ("A" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(7);
				InputControlMapping inputControlMapping = InputDeviceProfile.LeftStickLeftMapping(0);
				if (inputControlMapping == null || inputControlMapping != null)
				{
					InputControlMapping inputControlMapping2 = InputDeviceProfile.LeftStickRightMapping(0);
					if (inputControlMapping2 == null || inputControlMapping2 != null)
					{
						if (InputDeviceProfile.LeftStickUpMapping(1) != null)
						{
						}
						InputControlMapping inputControlMapping3 = InputDeviceProfile.LeftStickDownMapping(1);
						if (inputControlMapping3 == null || inputControlMapping3 != null)
						{
							InputControlMapping inputControlMapping4 = InputDeviceProfile.RightStickLeftMapping(2);
							if (inputControlMapping4 == null || inputControlMapping4 != null)
							{
								InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickRightMapping(2);
								if (inputControlMapping5 == null || inputControlMapping5 != null)
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickUpMapping(3);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickDownMapping(3);
										if ((inputControlMapping7 == null || inputControlMapping7 != null) && InputDeviceProfile.DPadLeftMapping(4) != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.DPadRightMapping(4);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlMapping inputControlMapping9 = InputDeviceProfile.DPadUpMapping(5);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.DPadDownMapping(5);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
														return;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00013394 File Offset: 0x00011594
		public EightBitdoNES30ProAndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
