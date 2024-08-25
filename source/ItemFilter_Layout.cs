using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001E2 RID: 482
public class ItemFilter_Layout : PageControllerLayoutDefinition<ItemFilter_Layout>
{
	// Token: 0x06000C48 RID: 3144 RVA: 0x0003D30C File Offset: 0x0003B50C
	public ItemFilter_Layout()
	{
		if (17274 == 0)
		{
		}
		this.SearchValidTextColor = 17274;
		this.SearchInvalidTextColor = 17274;
		base..ctor();
	}

	// Token: 0x0400113F RID: 4415
	public Panel_Layout Backing;

	// Token: 0x04001140 RID: 4416
	public Panel_Layout Backing_Horizontal;

	// Token: 0x04001141 RID: 4417
	public ItemGrid_Layout ItemFilters;

	// Token: 0x04001142 RID: 4418
	public float ItemFilterScale;

	// Token: 0x04001143 RID: 4419
	public TransactionButton_Layout ControllerButtonCollapsed;

	// Token: 0x04001144 RID: 4420
	public TransactionButton_Layout ControllerButtonExpanded;

	// Token: 0x04001145 RID: 4421
	public TransactionButton_Layout ButtonCollapsed;

	// Token: 0x04001146 RID: 4422
	public TransactionButton_Layout ButtonExpanded;

	// Token: 0x04001147 RID: 4423
	public TransactionButton_Layout ButtonCollapsed_Horizontal;

	// Token: 0x04001148 RID: 4424
	public TransactionButton_Layout ButtonExpanded_Horizontal;

	// Token: 0x04001149 RID: 4425
	public TransactionButton_Layout Everything;

	// Token: 0x0400114A RID: 4426
	public TransactionButton_Layout Weapon;

	// Token: 0x0400114B RID: 4427
	public TransactionButton_Layout Armor;

	// Token: 0x0400114C RID: 4428
	public TransactionButton_Layout Vanity;

	// Token: 0x0400114D RID: 4429
	public TransactionButton_Layout BuildingBlock;

	// Token: 0x0400114E RID: 4430
	public TransactionButton_Layout Furniture;

	// Token: 0x0400114F RID: 4431
	public TransactionButton_Layout Accessories;

	// Token: 0x04001150 RID: 4432
	public TransactionButton_Layout Equipment;

	// Token: 0x04001151 RID: 4433
	public TransactionButton_Layout Consumables;

	// Token: 0x04001152 RID: 4434
	public TransactionButton_Layout Tools;

	// Token: 0x04001153 RID: 4435
	public TransactionButton_Layout Materials;

	// Token: 0x04001154 RID: 4436
	public TransactionButton_Layout GameplayItems;

	// Token: 0x04001155 RID: 4437
	public TransactionButton_Layout Everything_Horizontal;

	// Token: 0x04001156 RID: 4438
	public TransactionButton_Layout Weapon_Horizontal;

	// Token: 0x04001157 RID: 4439
	public TransactionButton_Layout Armor_Horizontal;

	// Token: 0x04001158 RID: 4440
	public TransactionButton_Layout Vanity_Horizontal;

	// Token: 0x04001159 RID: 4441
	public TransactionButton_Layout BuildingBlock_Horizontal;

	// Token: 0x0400115A RID: 4442
	public TransactionButton_Layout Furniture_Horizontal;

	// Token: 0x0400115B RID: 4443
	public TransactionButton_Layout Accessories_Horizontal;

	// Token: 0x0400115C RID: 4444
	public TransactionButton_Layout Equipment_Horizontal;

	// Token: 0x0400115D RID: 4445
	public TransactionButton_Layout Consumables_Horizontal;

	// Token: 0x0400115E RID: 4446
	public TransactionButton_Layout Tools_Horizontal;

	// Token: 0x0400115F RID: 4447
	public TransactionButton_Layout Materials_Horizontal;

	// Token: 0x04001160 RID: 4448
	public TransactionButton_Layout GameplayItems_Horizontal;

	// Token: 0x04001161 RID: 4449
	public Panel_Layout SearchSeperator;

	// Token: 0x04001162 RID: 4450
	public TransactionButton_Layout BeginSearch;

	// Token: 0x04001163 RID: 4451
	public TransactionButton_Layout BeginSearch_Horizontal;

	// Token: 0x04001164 RID: 4452
	public float TextWrapSize = (float)17274;

	// Token: 0x04001165 RID: 4453
	public String_Layout SearchText;

	// Token: 0x04001166 RID: 4454
	public String_Layout SearchTextTouch;

	// Token: 0x04001167 RID: 4455
	public Color SearchValidTextColor;

	// Token: 0x04001168 RID: 4456
	public Color SearchInvalidTextColor;

	// Token: 0x04001169 RID: 4457
	public TransactionButton_Layout Duplication;

	// Token: 0x0400116A RID: 4458
	public TransactionButton_Layout DuplicationController;

	// Token: 0x0400116B RID: 4459
	public TransactionButton_Layout Crafting;

	// Token: 0x0400116C RID: 4460
	public TransactionButton_Layout CraftingController;

	// Token: 0x0400116D RID: 4461
	public TransactionButton_Layout Duplication_Horizontal;

	// Token: 0x0400116E RID: 4462
	public TransactionButton_Layout Crafting_Horizontal;
}
