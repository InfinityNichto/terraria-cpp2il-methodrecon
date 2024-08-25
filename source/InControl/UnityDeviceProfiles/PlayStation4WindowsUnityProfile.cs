using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000116 RID: 278
	[Preserve]
	[UnityInputDeviceProfile]
	public class PlayStation4WindowsUnityProfile : InputDeviceProfile
	{
		// Token: 0x060006B9 RID: 1721 RVA: 0x0001FD10 File Offset: 0x0001DF10
		public override void Define()
		{
			base.Define();
			this.deviceName = "PlayStation 4 Controller";
			this.deviceNotes = "PlayStation 4 Controller on Windows";
			if ("Windows" == null || "Windows" != null)
			{
				if ("Cross" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(12);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(13);
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
							if (inputControlMapping4 == null || inputControlMapping4 != null)
							{
								InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickLeftMapping(2);
								if (inputControlMapping5 == null || inputControlMapping5 != null)
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(2);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(5);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(5);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlMapping inputControlMapping9 = InputDeviceProfile.DPadLeftMapping(6);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.DPadRightMapping(6);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
														InputControlMapping inputControlMapping11 = InputDeviceProfile.DPadUpMapping2(7);
														if (inputControlMapping11 == null || inputControlMapping11 != null)
														{
															InputControlMapping inputControlMapping12 = InputDeviceProfile.DPadDownMapping2(7);
															if (inputControlMapping12 == null || inputControlMapping12 != null)
															{
																InputControlSource inputControlSource13 = InputDeviceProfile.Analog(3);
																InputControlSource inputControlSource14 = InputDeviceProfile.Analog(4);
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

		// Token: 0x060006BA RID: 1722 RVA: 0x0001FE9C File Offset: 0x0001E09C
		public PlayStation4WindowsUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
