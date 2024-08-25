using System;
using Controller;

// Token: 0x02000083 RID: 131
public class GUIControllerMappingScheme_Default : GUIControllerMappingScheme
{
	// Token: 0x06000320 RID: 800 RVA: 0x0000A5FC File Offset: 0x000087FC
	public GUIControllerMappingScheme_Default()
	{
	}

	// Token: 0x06000321 RID: 801 RVA: 0x0000A60C File Offset: 0x0000880C
	protected override void InitialiseWorldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings4 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings5 = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings3 = normal.AxisButtonBindings;
		ControllerActionAxis[] axisBindings = normal.AxisBindings;
		ControllerActionAxis[] axisBindings2 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings3 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings4 = normal.AxisBindings;
		ControllerActionButton[] axisButtonBindings4 = left.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings5 = left.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings6 = left.AxisButtonBindings;
		ControllerActionButton[] buttonBindings6 = right.ButtonBindings;
		if (axisButtonBindings6 == null || axisButtonBindings6 != null)
		{
			buttonBindings6.LinkedAction = axisButtonBindings6;
			ControllerActionButton[] buttonBindings7 = right.ButtonBindings;
			if (axisButtonBindings6 == null || axisButtonBindings6 != null)
			{
				buttonBindings7._entries = axisButtonBindings6;
				ControllerActionButton[] buttonBindings8 = right.ButtonBindings;
				if (axisButtonBindings6 == null || axisButtonBindings6 != null)
				{
					ControllerActionButton[] axisButtonBindings7 = right.AxisButtonBindings;
					if (axisButtonBindings6 == null || axisButtonBindings6 != null)
					{
						bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Stadia);
						bool flag2 = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.iOS);
						ControllerActionButton[] axisButtonBindings8 = right.AxisButtonBindings;
						if (axisButtonBindings6 == null)
						{
							return;
						}
						if (axisButtonBindings6 != null)
						{
							ControllerActionButton[] axisButtonBindings9 = right.AxisButtonBindings;
							bool flag3;
							if (!flag3 || flag3)
							{
								ControllerActionButton[] axisButtonBindings10 = right.AxisButtonBindings;
								if (!flag3 || flag3)
								{
									return;
								}
							}
						}
					}
				}
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000322 RID: 802 RVA: 0x0000A740 File Offset: 0x00008940
	protected override void InitialiseWorldSharedMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x06000323 RID: 803 RVA: 0x0000A750 File Offset: 0x00008950
	protected override void InitialiseWorldInteractMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x06000324 RID: 804 RVA: 0x0000A76C File Offset: 0x0000896C
	protected override void InitialiseWorldInteractFallbackMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x0000A794 File Offset: 0x00008994
	protected override void InitialiseBaseUIMappingsMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings4 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings5 = normal.ButtonBindings;
		ControllerActionAxis[] axisBindings = normal.AxisBindings;
		ControllerActionAxis[] axisBindings2 = normal.AxisBindings;
	}

	// Token: 0x06000326 RID: 806 RVA: 0x0000A7DC File Offset: 0x000089DC
	protected override void InitialiseInventoryMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x0000A80C File Offset: 0x00008A0C
	protected override void InitialiseEquipmentMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0000A830 File Offset: 0x00008A30
	protected override void InitialisePVPMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0000A840 File Offset: 0x00008A40
	protected override void InitialiseItemHeldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0000A868 File Offset: 0x00008A68
	protected override void InitialiseChestInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0000A884 File Offset: 0x00008A84
	protected override void InitialiseChestMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x0000A8A0 File Offset: 0x00008AA0
	protected override void InitialiseShopInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x0000A8BC File Offset: 0x00008ABC
	protected override void InitialiseShopMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600032E RID: 814 RVA: 0x0000A8D8 File Offset: 0x00008AD8
	protected override void InitialiseCraftingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x0000A8F4 File Offset: 0x00008AF4
	protected override void InitialiseReforgeMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x0000A910 File Offset: 0x00008B10
	protected override void InitialiseHousingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x06000331 RID: 817 RVA: 0x0000A92C File Offset: 0x00008B2C
	protected override void InitialiseChatMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}
}
