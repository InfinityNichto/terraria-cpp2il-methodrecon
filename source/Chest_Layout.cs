using System;
using Cpp2IlInjected;

// Token: 0x0200019B RID: 411
public class Chest_Layout : PageControllerLayoutDefinition<Chest_Layout>
{
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000021DB File Offset: 0x000003DB
	public ItemGrid_Layout DisplayChestGrid
	{
		get
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0003967C File Offset: 0x0003787C
	public Chest_Layout()
	{
	}

	// Token: 0x04000CD5 RID: 3285
	public String_Layout Title;

	// Token: 0x04000CD6 RID: 3286
	public String_Layout TitleController;

	// Token: 0x04000CD7 RID: 3287
	public String_Layout TitleTouch;

	// Token: 0x04000CD8 RID: 3288
	public float ItemScale;

	// Token: 0x04000CD9 RID: 3289
	public float ItemHighlightScale;

	// Token: 0x04000CDA RID: 3290
	public ItemGrid_Layout ChestGrid;

	// Token: 0x04000CDB RID: 3291
	public ItemGrid_Layout HorizontalChestGrid;

	// Token: 0x04000CDC RID: 3292
	public PopoutMenu_Layout Menu;

	// Token: 0x04000CDD RID: 3293
	public TransactionButton_Layout ChestRename;

	// Token: 0x04000CDE RID: 3294
	public TransactionButton_Layout ChestRename_Horizontal;

	// Token: 0x04000CDF RID: 3295
	public TransactionButton_Layout ChestRestock;

	// Token: 0x04000CE0 RID: 3296
	public TransactionButton_Layout ChestRestock_Horizontal;

	// Token: 0x04000CE1 RID: 3297
	public TransactionButton_Layout ChestQuickStack;

	// Token: 0x04000CE2 RID: 3298
	public TransactionButton_Layout ChestDepositAll;

	// Token: 0x04000CE3 RID: 3299
	public TransactionButton_Layout ChestDepositAll_Horizontal;

	// Token: 0x04000CE4 RID: 3300
	public TransactionButton_Layout ChestLootAll;

	// Token: 0x04000CE5 RID: 3301
	public TransactionButton_Layout ChestLootAll_Horizontal;

	// Token: 0x04000CE6 RID: 3302
	public TransactionButton_Layout LootButton;

	// Token: 0x04000CE7 RID: 3303
	public TransactionButton_Layout Favorite;
}
