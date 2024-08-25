using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000CC RID: 204
	[Preserve]
	[UnityInputDeviceProfile]
	public class ExecutionerXMacUnityProfile : InputDeviceProfile
	{
		// Token: 0x06000625 RID: 1573 RVA: 0x00019094 File Offset: 0x00017294
		public override void Define()
		{
			base.Define();
			this.deviceClass = InputDeviceClass.Controller;
			this.deviceName = "Executioner X Controller";
			this.deviceNotes = "Executioner X Controller";
			if ("OS X" == null || "OS X" != null)
			{
				if ("3" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(8);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(4);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(5);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(9);
				InputControlSource inputControlSource12 = InputDeviceProfile.Button(10);
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
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(3);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(3);
											if (inputControlMapping8 == null || inputControlMapping8 != null)
											{
												InputControlMapping inputControlMapping9 = InputDeviceProfile.DPadLeftMapping(6);
												if (inputControlMapping9 == null || inputControlMapping9 != null)
												{
													InputControlMapping inputControlMapping10 = InputDeviceProfile.DPadRightMapping(6);
													if (inputControlMapping10 == null || inputControlMapping10 != null)
													{
														InputControlMapping inputControlMapping11 = InputDeviceProfile.DPadUpMapping(7);
														if (inputControlMapping11 == null || inputControlMapping11 != null)
														{
															InputControlMapping inputControlMapping12 = InputDeviceProfile.DPadDownMapping(7);
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

		// Token: 0x06000626 RID: 1574 RVA: 0x00019214 File Offset: 0x00017414
		public ExecutionerXMacUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
