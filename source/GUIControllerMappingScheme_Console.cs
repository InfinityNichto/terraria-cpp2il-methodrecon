using System;
using Controller;

// Token: 0x02000082 RID: 130
public class GUIControllerMappingScheme_Console : GUIControllerMappingScheme
{
	// Token: 0x0600030E RID: 782 RVA: 0x0000A28C File Offset: 0x0000848C
	public GUIControllerMappingScheme_Console()
		: base(GUIControllerMappings.MappingType.Console)
	{
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0000A2A0 File Offset: 0x000084A0
	protected override void InitialiseWorldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings4 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings5 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings6 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings7 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings8 = normal.ButtonBindings;
		ControllerActionAxis[] axisBindings = normal.AxisBindings;
		ControllerActionAxis[] axisBindings2 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings3 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings4 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings5 = normal.AxisBindings;
		ControllerActionAxis[] axisBindings6 = normal.AxisBindings;
		ControllerActionButton[] axisButtonBindings = left.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings2 = left.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings3 = left.AxisButtonBindings;
		ControllerActionButton[] axisButtonBindings4 = right.AxisButtonBindings;
		if (axisButtonBindings3 == null || axisButtonBindings3 != null)
		{
			ControllerActionButton[] axisButtonBindings5 = right.AxisButtonBindings;
			if (axisButtonBindings3 == null || axisButtonBindings3 != null)
			{
				bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Stadia);
				bool flag2 = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.iOS);
				ControllerActionButton[] axisButtonBindings6 = right.AxisButtonBindings;
				if (normal == null || normal != null)
				{
					ControllerActionButton[] axisButtonBindings7 = right.AxisButtonBindings;
					if (normal == null || normal != null)
					{
						return;
					}
				}
			}
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000310 RID: 784 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected override void InitialiseWorldSharedMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x06000311 RID: 785 RVA: 0x0000A3E0 File Offset: 0x000085E0
	protected override void InitialiseWorldInteractMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x06000312 RID: 786 RVA: 0x0000A3FC File Offset: 0x000085FC
	protected override void InitialiseWorldInteractFallbackMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x0000A420 File Offset: 0x00008620
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

	// Token: 0x06000314 RID: 788 RVA: 0x0000A478 File Offset: 0x00008678
	protected override void InitialiseInventoryMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings3 = right.ButtonBindings;
		if (buttonBindings2 == null || buttonBindings2 != null)
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000A4A8 File Offset: 0x000086A8
	protected override void InitialiseEquipmentMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = normal.ButtonBindings;
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0000A4CC File Offset: 0x000086CC
	protected override void InitialisePVPMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0000A4DC File Offset: 0x000086DC
	protected override void InitialiseItemHeldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
		ControllerActionButton[] buttonBindings2 = left.ButtonBindings;
		if (buttonBindings == null || buttonBindings != null)
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0000A504 File Offset: 0x00008704
	protected override void InitialiseChestInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Stadia);
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0000A52C File Offset: 0x0000872C
	protected override void InitialiseChestMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Stadia);
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x0000A554 File Offset: 0x00008754
	protected override void InitialiseShopInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		bool flag = DrPlatform.IsCurrentPlatform(DrPlatform.DrPlatformType.Stadia);
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x0000A57C File Offset: 0x0000877C
	protected override void InitialiseShopMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x0000A598 File Offset: 0x00008798
	protected override void InitialiseCraftingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x0000A5B4 File Offset: 0x000087B4
	protected override void InitialiseReforgeMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600031E RID: 798 RVA: 0x0000A5D0 File Offset: 0x000087D0
	protected override void InitialiseHousingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
		ControllerActionButton[] buttonBindings = normal.ButtonBindings;
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0000A5EC File Offset: 0x000087EC
	protected override void InitialiseChatMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}
}
