using System;

// Token: 0x02000225 RID: 549
public class WorldSelectMenu_Layout : LayoutDefinition
{
	// Token: 0x06000CDD RID: 3293 RVA: 0x0003E60C File Offset: 0x0003C80C
	private void Awake()
	{
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0003E61C File Offset: 0x0003C81C
	public int PlatformMaxWorlds
	{
		get
		{
			int maxWorlds = this.MaxWorlds;
			DrPlatform.DrPlatformType currentPlatform = DrPlatform.CurrentPlatform;
			int maxWorlds_Stadia = this.MaxWorlds_Stadia;
			DrPlatform.DrPlatformType currentPlatform2 = DrPlatform.CurrentPlatform;
			DrPlatform.DrPlatformType currentPlatform3 = DrPlatform.CurrentPlatform;
			DrPlatform.DrPlatformType currentPlatform4 = DrPlatform.CurrentPlatform;
			return 30;
		}
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x0003E660 File Offset: 0x0003C860
	public WorldSelectMenu_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x0400155D RID: 5469
	public static WorldSelectMenu_Layout Instance;

	// Token: 0x0400155E RID: 5470
	public Panel_Layout Backing;

	// Token: 0x0400155F RID: 5471
	public DraggableItemGrid_Layout WorldGrid;

	// Token: 0x04001560 RID: 5472
	public StringButton_Layout Title;

	// Token: 0x04001561 RID: 5473
	public TransactionButton_Layout New;

	// Token: 0x04001562 RID: 5474
	public TransactionButton_Layout Back;

	// Token: 0x04001563 RID: 5475
	public Panel_Layout MenuDivider;

	// Token: 0x04001564 RID: 5476
	public TransactionButton_Layout Options;

	// Token: 0x04001565 RID: 5477
	public Panel_Layout OptionsGreyout;

	// Token: 0x04001566 RID: 5478
	public Panel_Layout OptionsBacking;

	// Token: 0x04001567 RID: 5479
	public Panel_Layout OptionsWithCloudBacking;

	// Token: 0x04001568 RID: 5480
	public TransactionButton_Layout Play;

	// Token: 0x04001569 RID: 5481
	public TransactionButton_Layout Delete;

	// Token: 0x0400156A RID: 5482
	public TransactionButton_Layout Favorite;

	// Token: 0x0400156B RID: 5483
	public TransactionButton_Layout Rename;

	// Token: 0x0400156C RID: 5484
	public TransactionButton_Layout SeedDisplay;

	// Token: 0x0400156D RID: 5485
	public TransactionButton_Layout Cloud;

	// Token: 0x0400156E RID: 5486
	public SelectWorldFavoriteIcons FavoriteIcons;

	// Token: 0x0400156F RID: 5487
	public SelectWorldFavoriteIcons CloudIcons;

	// Token: 0x04001570 RID: 5488
	public Panel_Layout ItemBacking;

	// Token: 0x04001571 RID: 5489
	public Panel_Layout ItemGreyout;

	// Token: 0x04001572 RID: 5490
	public Panel_Layout ItemSelectedBacking;

	// Token: 0x04001573 RID: 5491
	public Panel_Layout ItemSelectedGreyout;

	// Token: 0x04001574 RID: 5492
	public Button_Layout ItemPlay;

	// Token: 0x04001575 RID: 5493
	public Button_Layout ItemDelete;

	// Token: 0x04001576 RID: 5494
	public Button_Layout ItemFavourite;

	// Token: 0x04001577 RID: 5495
	public Button_Layout ItemRename;

	// Token: 0x04001578 RID: 5496
	public Button_Layout ItemSeedDisplay;

	// Token: 0x04001579 RID: 5497
	public Button_Layout ItemCloud;

	// Token: 0x0400157A RID: 5498
	public Button_Layout ItemDivider;

	// Token: 0x0400157B RID: 5499
	public String_Layout ItemName;

	// Token: 0x0400157C RID: 5500
	public Panel_Layout ItemNameDivider;

	// Token: 0x0400157D RID: 5501
	public Panel_Layout ItemTimeBacking;

	// Token: 0x0400157E RID: 5502
	public String_Layout ItemTime;

	// Token: 0x0400157F RID: 5503
	public Panel_Layout ItemModeBacking;

	// Token: 0x04001580 RID: 5504
	public String_Layout ItemMode;

	// Token: 0x04001581 RID: 5505
	public Panel_Layout ItemSizeBacking;

	// Token: 0x04001582 RID: 5506
	public String_Layout ItemSize;

	// Token: 0x04001583 RID: 5507
	public Panel_Layout ItemSeedBacking;

	// Token: 0x04001584 RID: 5508
	public String_Layout ItemSeed;

	// Token: 0x04001585 RID: 5509
	public Panel_Layout ItemImage;

	// Token: 0x04001586 RID: 5510
	public Panel_Layout CompletedItemImage;

	// Token: 0x04001587 RID: 5511
	public int MaxWorlds;

	// Token: 0x04001588 RID: 5512
	public int MaxWorlds_Stadia;

	// Token: 0x04001589 RID: 5513
	public bool FavouriteVisualScroll = true;

	// Token: 0x0400158A RID: 5514
	public String_Layout SyncInformation;

	// Token: 0x0400158B RID: 5515
	public Button_Layout SyncIcon;

	// Token: 0x0400158C RID: 5516
	public GUIWorldSelectMenu.WorldRenameOption worldRenameOption;
}
