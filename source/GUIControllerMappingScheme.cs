using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000080 RID: 128
public class GUIControllerMappingScheme
{
	// Token: 0x060002E8 RID: 744 RVA: 0x000021DB File Offset: 0x000003DB
	public static void LoadDefaultSchemes(List<GUIControllerMappingScheme> Schemes)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00009A00 File Offset: 0x00007C00
	public GUIControllerMappingScheme(GUIControllerMappings.MappingType mappingType)
	{
		GUIControllerMappingStateTable baseInventoryMappings = this.BaseInventoryMappings;
		GUIControllerMappingStateTable inventoryMappings = this.InventoryMappings;
		this.SchemeType = mappingType;
		inventoryMappings.SetChildState(baseInventoryMappings);
		GUIControllerMappingStateTable equipmentMappings = this.EquipmentMappings;
		GUIControllerMappingStateTable baseInventoryMappings2 = this.BaseInventoryMappings;
		equipmentMappings.SetChildState(baseInventoryMappings2);
		GUIControllerMappingStateTable pvpmappings = this.PVPMappings;
		GUIControllerMappingStateTable baseInventoryMappings3 = this.BaseInventoryMappings;
		pvpmappings.SetChildState(baseInventoryMappings3);
		GUIControllerMappingStateTable heldMappings = this.HeldMappings;
		GUIControllerMappingStateTable baseInventoryMappings4 = this.BaseInventoryMappings;
		heldMappings.SetChildState(baseInventoryMappings4);
		GUIControllerMappingStateTable chestInvMappings = this.ChestInvMappings;
		GUIControllerMappingStateTable baseInventoryMappings5 = this.BaseInventoryMappings;
		chestInvMappings.SetChildState(baseInventoryMappings5);
		GUIControllerMappingStateTable baseInventoryMappings6 = this.BaseInventoryMappings;
		chestInvMappings.SetChildState(baseInventoryMappings6);
		GUIControllerMappingStateTable shopInvMappings = this.ShopInvMappings;
		GUIControllerMappingStateTable baseInventoryMappings7 = this.BaseInventoryMappings;
		shopInvMappings.SetChildState(baseInventoryMappings7);
		GUIControllerMappingStateTable shopMappings = this.ShopMappings;
		GUIControllerMappingStateTable baseInventoryMappings8 = this.BaseInventoryMappings;
		shopMappings.SetChildState(baseInventoryMappings8);
		GUIControllerMappingStateTable craftingMappings = this.CraftingMappings;
		GUIControllerMappingStateTable baseInventoryMappings9 = this.BaseInventoryMappings;
		craftingMappings.SetChildState(baseInventoryMappings9);
		GUIControllerMappingStateTable reforgeMappings = this.ReforgeMappings;
		GUIControllerMappingStateTable baseInventoryMappings10 = this.BaseInventoryMappings;
		reforgeMappings.SetChildState(baseInventoryMappings10);
		GUIControllerMappingStateTable housingMappings = this.HousingMappings;
		GUIControllerMappingStateTable baseInventoryMappings11 = this.BaseInventoryMappings;
		housingMappings.SetChildState(baseInventoryMappings11);
		GUIControllerMappingStateTable chatMappings = this.ChatMappings;
		GUIControllerMappingStateTable baseInventoryMappings12 = this.BaseInventoryMappings;
		chatMappings.SetChildState(baseInventoryMappings12);
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00009B38 File Offset: 0x00007D38
	public void Initialise()
	{
		GUIControllerMappingStateTable worldMappings = this.WorldMappings;
		GUIControllerMappingState normal = worldMappings.Normal;
		GUIControllerMappingState left = worldMappings.Left;
		GUIControllerMappingState right = worldMappings.Right;
		GUIControllerMappingStateTable worldSharedMappings = this.WorldSharedMappings;
		GUIControllerMappingState normal2 = worldSharedMappings.Normal;
		GUIControllerMappingState left2 = worldSharedMappings.Left;
		GUIControllerMappingState right2 = worldSharedMappings.Right;
		GUIControllerMappingStateTable worldInteractMappings = this.WorldInteractMappings;
		GUIControllerMappingState normal3 = worldInteractMappings.Normal;
		GUIControllerMappingState left3 = worldInteractMappings.Left;
		GUIControllerMappingState right3 = worldInteractMappings.Right;
		GUIControllerMappingStateTable worldInteractFallbackMappings = this.WorldInteractFallbackMappings;
		GUIControllerMappingState normal4 = worldInteractFallbackMappings.Normal;
		GUIControllerMappingState left4 = worldInteractFallbackMappings.Left;
		GUIControllerMappingState right4 = worldInteractFallbackMappings.Right;
		GUIControllerMappingStateTable baseInventoryMappings = this.BaseInventoryMappings;
		GUIControllerMappingState normal5 = baseInventoryMappings.Normal;
		GUIControllerMappingState left5 = baseInventoryMappings.Left;
		GUIControllerMappingState right5 = baseInventoryMappings.Right;
		GUIControllerMappingStateTable inventoryMappings = this.InventoryMappings;
		GUIControllerMappingState normal6 = inventoryMappings.Normal;
		GUIControllerMappingState left6 = inventoryMappings.Left;
		GUIControllerMappingState right6 = inventoryMappings.Right;
		GUIControllerMappingStateTable equipmentMappings = this.EquipmentMappings;
		GUIControllerMappingState normal7 = equipmentMappings.Normal;
		GUIControllerMappingState left7 = equipmentMappings.Left;
		GUIControllerMappingState right7 = equipmentMappings.Right;
		GUIControllerMappingStateTable pvpmappings = this.PVPMappings;
		GUIControllerMappingState normal8 = pvpmappings.Normal;
		GUIControllerMappingState left8 = pvpmappings.Left;
		GUIControllerMappingState right8 = pvpmappings.Right;
		GUIControllerMappingStateTable heldMappings = this.HeldMappings;
		GUIControllerMappingState normal9 = heldMappings.Normal;
		GUIControllerMappingState left9 = heldMappings.Left;
		GUIControllerMappingState right9 = heldMappings.Right;
		GUIControllerMappingStateTable chestInvMappings = this.ChestInvMappings;
		GUIControllerMappingState normal10 = chestInvMappings.Normal;
		GUIControllerMappingState left10 = chestInvMappings.Left;
		GUIControllerMappingState right10 = chestInvMappings.Right;
		GUIControllerMappingStateTable chestMappings = this.ChestMappings;
		GUIControllerMappingState normal11 = chestMappings.Normal;
		GUIControllerMappingState left11 = chestMappings.Left;
		GUIControllerMappingState right11 = chestMappings.Right;
		GUIControllerMappingStateTable shopInvMappings = this.ShopInvMappings;
		GUIControllerMappingState normal12 = shopInvMappings.Normal;
		GUIControllerMappingState left12 = shopInvMappings.Left;
		GUIControllerMappingState right12 = shopInvMappings.Right;
		GUIControllerMappingStateTable shopMappings = this.ShopMappings;
		GUIControllerMappingState normal13 = shopMappings.Normal;
		GUIControllerMappingState left13 = shopMappings.Left;
		GUIControllerMappingState right13 = shopMappings.Right;
		GUIControllerMappingStateTable craftingMappings = this.CraftingMappings;
		GUIControllerMappingState normal14 = craftingMappings.Normal;
		GUIControllerMappingState left14 = craftingMappings.Left;
		GUIControllerMappingState right14 = craftingMappings.Right;
		GUIControllerMappingStateTable reforgeMappings = this.ReforgeMappings;
		GUIControllerMappingState normal15 = reforgeMappings.Normal;
		GUIControllerMappingState left15 = reforgeMappings.Left;
		GUIControllerMappingState right15 = reforgeMappings.Right;
		GUIControllerMappingStateTable housingMappings = this.HousingMappings;
		GUIControllerMappingState normal16 = housingMappings.Normal;
		GUIControllerMappingState left16 = housingMappings.Left;
		GUIControllerMappingState right16 = housingMappings.Right;
		GUIControllerMappingStateTable chatMappings = this.ChatMappings;
		GUIControllerMappingState normal17 = chatMappings.Normal;
		GUIControllerMappingState left17 = chatMappings.Left;
		GUIControllerMappingState right17 = chatMappings.Right;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00009D94 File Offset: 0x00007F94
	protected virtual void InitialiseWorldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00009DA4 File Offset: 0x00007FA4
	protected virtual void InitialiseWorldInteractMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00009DB4 File Offset: 0x00007FB4
	protected virtual void InitialiseWorldSharedMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00009DC4 File Offset: 0x00007FC4
	protected virtual void InitialiseWorldInteractFallbackMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00009DD4 File Offset: 0x00007FD4
	protected virtual void InitialiseBaseUIMappingsMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00009DE4 File Offset: 0x00007FE4
	protected virtual void InitialiseInventoryMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00009DF4 File Offset: 0x00007FF4
	protected virtual void InitialiseEquipmentMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00009E04 File Offset: 0x00008004
	protected virtual void InitialisePVPMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00009E14 File Offset: 0x00008014
	protected virtual void InitialiseItemHeldMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00009E24 File Offset: 0x00008024
	protected virtual void InitialiseChestInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00009E34 File Offset: 0x00008034
	protected virtual void InitialiseChestMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00009E44 File Offset: 0x00008044
	protected virtual void InitialiseShopMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00009E54 File Offset: 0x00008054
	protected virtual void InitialiseShopInvMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00009E64 File Offset: 0x00008064
	protected virtual void InitialiseCraftingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00009E74 File Offset: 0x00008074
	protected virtual void InitialiseReforgeMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00009E84 File Offset: 0x00008084
	protected virtual void InitialiseHousingMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00009E94 File Offset: 0x00008094
	protected virtual void InitialiseChatMappings(GUIControllerMappingState normal, GUIControllerMappingState left, GUIControllerMappingState right)
	{
	}

	// Token: 0x04000327 RID: 807
	public GUIControllerMappingStateTable WorldMappings;

	// Token: 0x04000328 RID: 808
	public GUIControllerMappingStateTable WorldSharedMappings;

	// Token: 0x04000329 RID: 809
	public GUIControllerMappingStateTable WorldInteractMappings;

	// Token: 0x0400032A RID: 810
	public GUIControllerMappingStateTable WorldInteractFallbackMappings;

	// Token: 0x0400032B RID: 811
	public GUIControllerMappingStateTable BaseInventoryMappings;

	// Token: 0x0400032C RID: 812
	public GUIControllerMappingStateTable InventoryMappings;

	// Token: 0x0400032D RID: 813
	public GUIControllerMappingStateTable EquipmentMappings;

	// Token: 0x0400032E RID: 814
	public GUIControllerMappingStateTable PVPMappings;

	// Token: 0x0400032F RID: 815
	public GUIControllerMappingStateTable HeldMappings;

	// Token: 0x04000330 RID: 816
	public GUIControllerMappingStateTable ChestInvMappings;

	// Token: 0x04000331 RID: 817
	public GUIControllerMappingStateTable ChestMappings;

	// Token: 0x04000332 RID: 818
	public GUIControllerMappingStateTable ShopInvMappings;

	// Token: 0x04000333 RID: 819
	public GUIControllerMappingStateTable ShopMappings;

	// Token: 0x04000334 RID: 820
	public GUIControllerMappingStateTable CraftingMappings;

	// Token: 0x04000335 RID: 821
	public GUIControllerMappingStateTable ReforgeMappings;

	// Token: 0x04000336 RID: 822
	public GUIControllerMappingStateTable HousingMappings;

	// Token: 0x04000337 RID: 823
	public GUIControllerMappingStateTable ChatMappings;

	// Token: 0x04000338 RID: 824
	public GUIControllerMappings.MappingType SchemeType;
}
