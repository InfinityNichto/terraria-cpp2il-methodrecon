using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000090 RID: 144
	[Preserve]
	[UnityInputDeviceProfile]
	public class EightBitdoSF30ProAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005A7 RID: 1447 RVA: 0x000133AC File Offset: 0x000115AC
		public override void Define()
		{
			base.Define();
			this.deviceName = "8Bitdo SF30 Pro Controller";
			this.deviceNotes = "8Bitdo SF30 Pro Controller on Android";
			if ("Android" == null || "Android" != null)
			{
				if ("A" == null)
				{
				}
				if (InputDeviceProfile.Button(0) != null)
				{
					InputControlSource inputControlSource = InputDeviceProfile.Button(1);
					InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
					InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
					InputControlSource inputControlSource4 = InputDeviceProfile.Button(11);
					InputControlSource inputControlSource5 = InputDeviceProfile.Button(10);
					InputControlSource inputControlSource6 = InputDeviceProfile.Button(4);
					InputControlSource inputControlSource7 = InputDeviceProfile.Button(5);
					InputControlSource inputControlSource8 = InputDeviceProfile.Button(6);
					InputControlSource inputControlSource9 = InputDeviceProfile.Button(7);
					InputControlMapping inputControlMapping = InputDeviceProfile.LeftStickLeftMapping(0);
					if (inputControlMapping == null || inputControlMapping != null)
					{
						InputControlMapping inputControlMapping2 = InputDeviceProfile.LeftStickRightMapping(0);
						if (inputControlMapping2 == null || inputControlMapping2 != null)
						{
							InputControlMapping inputControlMapping3 = InputDeviceProfile.LeftStickUpMapping(1);
							if (inputControlMapping3 == null || inputControlMapping3 != null)
							{
								InputControlMapping inputControlMapping4 = InputDeviceProfile.LeftStickDownMapping(1);
								InputControlMapping inputControlMapping5;
								if ((inputControlMapping4 == null || inputControlMapping4 != null) && (inputControlMapping5 == null || inputControlMapping5 != null))
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(2);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(3);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(3);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlMapping inputControlMapping9 = InputDeviceProfile.DPadLeftMapping(4);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.DPadRightMapping(4);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
														InputControlMapping inputControlMapping11 = InputDeviceProfile.DPadUpMapping(5);
														if (inputControlMapping11 == null || inputControlMapping11 != null)
														{
															InputControlMapping inputControlMapping12 = InputDeviceProfile.DPadDownMapping(5);
															if (inputControlMapping12 == null || inputControlMapping12 != null)
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
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00013510 File Offset: 0x00011710
		public EightBitdoSF30ProAndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
