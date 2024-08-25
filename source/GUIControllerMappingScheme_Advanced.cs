using System;
using Controller;

// Token: 0x02000081 RID: 129
public class GUIControllerMappingScheme_Advanced : GUIControllerMappingScheme
{
	// Token: 0x060002FC RID: 764 RVA: 0x00009EA4 File Offset: 0x000080A4
	public GUIControllerMappingScheme_Advanced()
		: base(GUIControllerMappings.MappingType.Advanced)
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00009EB8 File Offset: 0x000080B8
	protected override void InitialiseWorldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings4 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings5 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings6 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings7 = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings3 = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings4 = normal.AxisButtonBindings;
		ControllerActionAxis[] axisBindings = normal.AxisBindings;
		ControllerActionAxis[] axisBindings2 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings3 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings4 = normal.AxisBindings;
		ControllerActionButton[] buttonBindings8 = left.ButtonBindings;
		if (axisBindings4 == null || axisBindings4 != null)
		{
			buttonBindings8._entries = axisBindings4;
			ControllerActionButton[] buttonBindings9 = left.ButtonBindings;
			if (axisBindings4 == null || axisBindings4 != null)
			{
				ControllerActionButton[] buttonBindings10 = left.ButtonBindings;
				if (axisBindings4 == null || axisBindings4 != null)
				{
					ControllerActionButton[] axisButtonBindings5 = left.AxisButtonBindings;
					if (axisBindings4 == null || axisBindings4 != null)
					{
						ControllerActionAxis[] axisBindings5 = left.AxisBindings;
						if (axisBindings4 == null || axisBindings4 != null)
						{
							ControllerActionAxis[] axisBindings6 = left.AxisBindings;
							if (axisBindings4 == null || axisBindings4 != null)
							{
								ControllerActionButton[] buttonBindings11 = right.ButtonBindings;
								if (axisBindings6 == null || axisBindings6 != null)
								{
									buttonBindings11._entries = axisBindings6;
									ControllerActionButton[] buttonBindings12 = right.ButtonBindings;
									if (axisBindings6 == null || axisBindings6 != null)
									{
										ControllerActionButton[] buttonBindings13 = right.ButtonBindings;
										if (axisBindings6 == null || axisBindings6 != null)
										{
											ControllerActionButton[] axisButtonBindings6 = right.AxisButtonBindings;
											if (axisBindings6 == null || axisBindings6 != null)
											{
												ControllerActionButton[] axisButtonBindings7 = right.AxisButtonBindings;
												if (axisBindings6 == null || axisBindings6 != null)
												{
													ControllerActionButton[] axisButtonBindings8 = right.AxisButtonBindings;
													if (axisBindings6 == null || axisBindings6 != null)
													{
														ControllerActionButton[] axisButtonBindings9 = right.AxisButtonBindings;
														if (axisBindings6 == null || axisBindings6 != null)
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

	// Token: 0x060002FE RID: 766 RVA: 0x0000A038 File Offset: 0x00008238
	protected override void InitialiseWorldSharedMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0000A048 File Offset: 0x00008248
	protected override void InitialiseWorldInteractMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0000A05C File Offset: 0x0000825C
	protected override void InitialiseWorldInteractFallbackMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x06000301 RID: 769 RVA: 0x0000A078 File Offset: 0x00008278
	protected override void InitialiseBaseUIMappingsMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings4 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings5 = normal.ButtonBindings;
		ControllerActionAxis[] axisBindings = normal.AxisBindings;
		ControllerActionAxis[] axisBindings2 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings3 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings4 = normal.AxisBindings;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x0000A0D0 File Offset: 0x000082D0
	protected override void InitialiseInventoryMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings4 = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
		ControllerActionButton[] buttonBindings5 = right.ButtonBindings;
		if (axisButtonBindings == null || axisButtonBindings != null)
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0000A118 File Offset: 0x00008318
	protected override void InitialiseEquipmentMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0000A13C File Offset: 0x0000833C
	protected override void InitialisePVPMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = normal.AxisButtonBindings;
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0000A160 File Offset: 0x00008360
	protected override void InitialiseItemHeldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0000A188 File Offset: 0x00008388
	protected override void InitialiseChestInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = normal.AxisButtonBindings;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0000A1B0 File Offset: 0x000083B0
	protected override void InitialiseChestMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] axisButtonBindings = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings3 = normal.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings4 = normal.AxisButtonBindings;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0000A1E8 File Offset: 0x000083E8
	protected override void InitialiseShopInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x06000309 RID: 777 RVA: 0x0000A204 File Offset: 0x00008404
	protected override void InitialiseShopMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600030A RID: 778 RVA: 0x0000A220 File Offset: 0x00008420
	protected override void InitialiseCraftingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0000A244 File Offset: 0x00008444
	protected override void InitialiseReforgeMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0000A260 File Offset: 0x00008460
	protected override void InitialiseHousingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600030D RID: 781 RVA: 0x0000A27C File Offset: 0x0000847C
	protected override void InitialiseChatMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}
}
