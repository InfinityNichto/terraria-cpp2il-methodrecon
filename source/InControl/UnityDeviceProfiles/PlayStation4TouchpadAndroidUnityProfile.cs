using System;
using Cpp2IlInjected;
using UnityEngine;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x020000AF RID: 175
	[Preserve]
	[UnityInputDeviceProfile]
	public class PlayStation4TouchpadAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x000025E1 File Offset: 0x000007E1
		private static int getSDKInt()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000162F8 File Offset: 0x000144F8
		public override void Define()
		{
			base.Define();
			this.deviceName = "PlayStation 4 Controller";
			this.deviceNotes = "PlayStation 4 Controller on Android";
			if (("Android" == null || "Android" != null) && ("Amazon AFT" == null || "Amazon AFT" != null))
			{
				string text = PlayStation4TouchpadAndroidUnityProfile.getSDKInt().ToString();
				Debug.Log("SDK" + text);
				int sdkint = PlayStation4TouchpadAndroidUnityProfile.getSDKInt();
				if ("Cross" == null)
				{
				}
				InputControlSource inputControlSource = InputDeviceProfile.Button(1);
				InputControlSource inputControlSource2 = InputDeviceProfile.Button(13);
				InputControlSource inputControlSource3 = InputDeviceProfile.Button(0);
				InputControlSource inputControlSource4 = InputDeviceProfile.Button(2);
				InputControlSource inputControlSource5 = InputDeviceProfile.Button(3);
				InputControlSource inputControlSource6 = InputDeviceProfile.Button(14);
				InputControlSource inputControlSource7 = InputDeviceProfile.Button(6);
				InputControlSource inputControlSource8 = InputDeviceProfile.Button(7);
				InputControlSource inputControlSource9 = InputDeviceProfile.Button(11);
				InputControlSource inputControlSource10 = InputDeviceProfile.Button(10);
				InputControlSource inputControlSource11 = InputDeviceProfile.Button(8);
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
								InputControlMapping inputControlMapping5 = InputDeviceProfile.RightStickLeftMapping(13);
								if (inputControlMapping5 == null || inputControlMapping5 != null)
								{
									InputControlMapping inputControlMapping6 = InputDeviceProfile.RightStickRightMapping(13);
									if (inputControlMapping6 == null || inputControlMapping6 != null)
									{
										InputControlMapping inputControlMapping7 = InputDeviceProfile.RightStickUpMapping(14);
										if (inputControlMapping7 == null || inputControlMapping7 != null)
										{
											InputControlMapping inputControlMapping8 = InputDeviceProfile.RightStickDownMapping(14);
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
																InputControlSource inputControlSource12 = InputDeviceProfile.Analog(2);
																InputControlSource inputControlSource13 = InputDeviceProfile.Analog(3);
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

		// Token: 0x060005E8 RID: 1512 RVA: 0x000166D4 File Offset: 0x000148D4
		public PlayStation4TouchpadAndroidUnityProfile()
		{
			if (!true)
			{
			}
			base..ctor();
		}
	}
}
