using System;

// Token: 0x02000072 RID: 114
public class ControllerMappingProfile
{
	// Token: 0x06000279 RID: 633 RVA: 0x00006C2C File Offset: 0x00004E2C
	public ControllerMappingProfile()
	{
		GUIControllerMappingStateTable baseInventory = this.BaseInventory;
		this.Inventory.SetChildState(baseInventory);
		GUIControllerMappingStateTable inventory = this.Inventory;
		this.EquipmentInv.SetChildState(inventory);
		GUIControllerMappingStateTable equipment = this.Equipment;
		GUIControllerMappingStateTable baseInventory2 = this.BaseInventory;
		equipment.SetChildState(baseInventory2);
		GUIControllerMappingStateTable pvp = this.PVP;
		GUIControllerMappingStateTable baseInventory3 = this.BaseInventory;
		pvp.SetChildState(baseInventory3);
		GUIControllerMappingStateTable itemHeld = this.ItemHeld;
		GUIControllerMappingStateTable baseInventory4 = this.BaseInventory;
		itemHeld.SetChildState(baseInventory4);
		GUIControllerMappingStateTable chestInv = this.ChestInv;
		GUIControllerMappingStateTable inventory2 = this.Inventory;
		chestInv.SetChildState(inventory2);
		GUIControllerMappingStateTable chest = this.Chest;
		GUIControllerMappingStateTable baseInventory5 = this.BaseInventory;
		chest.SetChildState(baseInventory5);
		GUIControllerMappingStateTable shopInv = this.ShopInv;
		GUIControllerMappingStateTable inventory3 = this.Inventory;
		shopInv.SetChildState(inventory3);
		GUIControllerMappingStateTable shop = this.Shop;
		GUIControllerMappingStateTable baseInventory6 = this.BaseInventory;
		shop.SetChildState(baseInventory6);
		GUIControllerMappingStateTable hair = this.Hair;
		GUIControllerMappingStateTable baseInventory7 = this.BaseInventory;
		hair.SetChildState(baseInventory7);
		GUIControllerMappingStateTable dresser = this.Dresser;
		GUIControllerMappingStateTable baseInventory8 = this.BaseInventory;
		dresser.SetChildState(baseInventory8);
		GUIControllerMappingStateTable npc = this.NPC;
		GUIControllerMappingStateTable baseInventory9 = this.BaseInventory;
		npc.SetChildState(baseInventory9);
		GUIControllerMappingStateTable craftingInv = this.CraftingInv;
		GUIControllerMappingStateTable inventory4 = this.Inventory;
		craftingInv.SetChildState(inventory4);
		GUIControllerMappingStateTable crafting = this.Crafting;
		GUIControllerMappingStateTable baseInventory10 = this.BaseInventory;
		crafting.SetChildState(baseInventory10);
	}

	// Token: 0x04000227 RID: 551
	public GUIControllerMappingStateTable World;

	// Token: 0x04000228 RID: 552
	public GUIControllerMappingStateTable BaseInventory;

	// Token: 0x04000229 RID: 553
	public GUIControllerMappingStateTable Inventory;

	// Token: 0x0400022A RID: 554
	public GUIControllerMappingStateTable EquipmentInv;

	// Token: 0x0400022B RID: 555
	public GUIControllerMappingStateTable Equipment;

	// Token: 0x0400022C RID: 556
	public GUIControllerMappingStateTable PVP;

	// Token: 0x0400022D RID: 557
	public GUIControllerMappingStateTable ItemHeld;

	// Token: 0x0400022E RID: 558
	public GUIControllerMappingStateTable Hair;

	// Token: 0x0400022F RID: 559
	public GUIControllerMappingStateTable Dresser;

	// Token: 0x04000230 RID: 560
	public GUIControllerMappingStateTable NPC;

	// Token: 0x04000231 RID: 561
	public GUIControllerMappingStateTable ChestInv;

	// Token: 0x04000232 RID: 562
	public GUIControllerMappingStateTable Chest;

	// Token: 0x04000233 RID: 563
	public GUIControllerMappingStateTable ShopInv;

	// Token: 0x04000234 RID: 564
	public GUIControllerMappingStateTable Shop;

	// Token: 0x04000235 RID: 565
	public GUIControllerMappingStateTable CraftingInv;

	// Token: 0x04000236 RID: 566
	public GUIControllerMappingStateTable Crafting;
}
