using System;
using System.Runtime.InteropServices;

// Token: 0x020001A1 RID: 417
[Serializable]
public class ControllerMappingsCategories_Layout
{
	// Token: 0x06000B6D RID: 2925 RVA: 0x00039730 File Offset: 0x00037930
	public void GetCategorySetup(GUISettingID id, [Out] ControllerMappingsCategories_Layout.Category category, [Out] int sortOrder)
	{
		int num = 1;
		category.value__ = num;
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x0003978C File Offset: 0x0003798C
	public void GetCategorySetup(string actionId, [Out] ControllerMappingsCategories_Layout.Category category, [Out] int sortOrder)
	{
		category.value__ = 1;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(actionId);
		bool flag = actionId == "HotbarAxis";
		ControllerMappingsCategories_Layout.Setting hotbarAxis = this.MappingSettings.HotbarAxis;
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x0003A208 File Offset: 0x00038408
	public ControllerMappingsCategories_Layout()
	{
	}

	// Token: 0x04000D27 RID: 3367
	public Panel_Layout Backing;

	// Token: 0x04000D28 RID: 3368
	public TransactionButton_Layout GeneralSettings;

	// Token: 0x04000D29 RID: 3369
	public TransactionButton_Layout Exploration;

	// Token: 0x04000D2A RID: 3370
	public TransactionButton_Layout Fighting;

	// Token: 0x04000D2B RID: 3371
	public TransactionButton_Layout Miscellaneous;

	// Token: 0x04000D2C RID: 3372
	public TransactionButton_Layout UI;

	// Token: 0x04000D2D RID: 3373
	public TransactionButton_Layout Chest;

	// Token: 0x04000D2E RID: 3374
	public TransactionButton_Layout Equipment;

	// Token: 0x04000D2F RID: 3375
	public TransactionButton_Layout Multiplayer;

	// Token: 0x04000D30 RID: 3376
	public TransactionButton_Layout ShopCraft;

	// Token: 0x04000D31 RID: 3377
	public TransactionButton_Layout Map;

	// Token: 0x04000D32 RID: 3378
	public TransactionButton_Layout LB;

	// Token: 0x04000D33 RID: 3379
	public TransactionButton_Layout RB;

	// Token: 0x04000D34 RID: 3380
	public ControllerMappingsCategories_Layout.MappingCategories MappingSettings;

	// Token: 0x020001A2 RID: 418
	public enum Category
	{
		// Token: 0x04000D36 RID: 3382
		GeneralSettings,
		// Token: 0x04000D37 RID: 3383
		Exploration,
		// Token: 0x04000D38 RID: 3384
		Fighting,
		// Token: 0x04000D39 RID: 3385
		Miscellaneous,
		// Token: 0x04000D3A RID: 3386
		UI,
		// Token: 0x04000D3B RID: 3387
		Chest,
		// Token: 0x04000D3C RID: 3388
		Equipment,
		// Token: 0x04000D3D RID: 3389
		Multiplayer,
		// Token: 0x04000D3E RID: 3390
		ShopCraft,
		// Token: 0x04000D3F RID: 3391
		Map
	}

	// Token: 0x020001A3 RID: 419
	[Serializable]
	public class Setting
	{
		// Token: 0x06000B70 RID: 2928 RVA: 0x0003A21C File Offset: 0x0003841C
		public Setting()
		{
		}

		// Token: 0x04000D40 RID: 3392
		public ControllerMappingsCategories_Layout.Category Category = ControllerMappingsCategories_Layout.Category.Exploration;

		// Token: 0x04000D41 RID: 3393
		public int SortOrder;
	}

	// Token: 0x020001A4 RID: 420
	[Serializable]
	public class MappingCategories
	{
		// Token: 0x06000B71 RID: 2929 RVA: 0x0003A238 File Offset: 0x00038438
		public MappingCategories()
		{
		}

		// Token: 0x04000D42 RID: 3394
		public ControllerMappingsCategories_Layout.Setting Controls;

		// Token: 0x04000D43 RID: 3395
		public ControllerMappingsCategories_Layout.Setting ControllerAimAndUseMode;

		// Token: 0x04000D44 RID: 3396
		public ControllerMappingsCategories_Layout.Setting ControllerAimSensitivity;

		// Token: 0x04000D45 RID: 3397
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementDelay;

		// Token: 0x04000D46 RID: 3398
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementRepeatDelay;

		// Token: 0x04000D47 RID: 3399
		public ControllerMappingsCategories_Layout.Setting ControllerSmartCursorMode;

		// Token: 0x04000D48 RID: 3400
		public ControllerMappingsCategories_Layout.Setting ControllerSwapShoulderButtons;

		// Token: 0x04000D49 RID: 3401
		public ControllerMappingsCategories_Layout.Setting ControllerShowControlsBanner;

		// Token: 0x04000D4A RID: 3402
		public ControllerMappingsCategories_Layout.Setting MovementAxis;

		// Token: 0x04000D4B RID: 3403
		public ControllerMappingsCategories_Layout.Setting MovementAxisAlt;

		// Token: 0x04000D4C RID: 3404
		public ControllerMappingsCategories_Layout.Setting FireAxis;

		// Token: 0x04000D4D RID: 3405
		public ControllerMappingsCategories_Layout.Setting FireAxisAlt;

		// Token: 0x04000D4E RID: 3406
		public ControllerMappingsCategories_Layout.Setting GrappleAxis;

		// Token: 0x04000D4F RID: 3407
		public ControllerMappingsCategories_Layout.Setting GridSnapAxis;

		// Token: 0x04000D50 RID: 3408
		public ControllerMappingsCategories_Layout.Setting HotbarAxis;

		// Token: 0x04000D51 RID: 3409
		public ControllerMappingsCategories_Layout.Setting GrappleFire;

		// Token: 0x04000D52 RID: 3410
		public ControllerMappingsCategories_Layout.Setting Jump;

		// Token: 0x04000D53 RID: 3411
		public ControllerMappingsCategories_Layout.Setting Fire;

		// Token: 0x04000D54 RID: 3412
		public ControllerMappingsCategories_Layout.Setting FireAlt;

		// Token: 0x04000D55 RID: 3413
		public ControllerMappingsCategories_Layout.Setting Interact;

		// Token: 0x04000D56 RID: 3414
		public ControllerMappingsCategories_Layout.Setting TargetLockOn;

		// Token: 0x04000D57 RID: 3415
		public ControllerMappingsCategories_Layout.Setting InventoryToggle;

		// Token: 0x04000D58 RID: 3416
		public ControllerMappingsCategories_Layout.Setting WorldFocusToggle;

		// Token: 0x04000D59 RID: 3417
		public ControllerMappingsCategories_Layout.Setting AutoSelect;

		// Token: 0x04000D5A RID: 3418
		public ControllerMappingsCategories_Layout.Setting SmartCursor;

		// Token: 0x04000D5B RID: 3419
		public ControllerMappingsCategories_Layout.Setting AutoFire;

		// Token: 0x04000D5C RID: 3420
		public ControllerMappingsCategories_Layout.Setting HotbarNext;

		// Token: 0x04000D5D RID: 3421
		public ControllerMappingsCategories_Layout.Setting HotbarPrevious;

		// Token: 0x04000D5E RID: 3422
		public ControllerMappingsCategories_Layout.Setting BuffNext;

		// Token: 0x04000D5F RID: 3423
		public ControllerMappingsCategories_Layout.Setting BuffPrevious;

		// Token: 0x04000D60 RID: 3424
		public ControllerMappingsCategories_Layout.Setting BuffRemove;

		// Token: 0x04000D61 RID: 3425
		public ControllerMappingsCategories_Layout.Setting ZoomIn;

		// Token: 0x04000D62 RID: 3426
		public ControllerMappingsCategories_Layout.Setting ZoomOut;

		// Token: 0x04000D63 RID: 3427
		public ControllerMappingsCategories_Layout.Setting MapZoomIn;

		// Token: 0x04000D64 RID: 3428
		public ControllerMappingsCategories_Layout.Setting MapZoomOut;

		// Token: 0x04000D65 RID: 3429
		public ControllerMappingsCategories_Layout.Setting MapZoomDefault;

		// Token: 0x04000D66 RID: 3430
		public ControllerMappingsCategories_Layout.Setting QuickHeal;

		// Token: 0x04000D67 RID: 3431
		public ControllerMappingsCategories_Layout.Setting QuickMana;

		// Token: 0x04000D68 RID: 3432
		public ControllerMappingsCategories_Layout.Setting QuickBuff;

		// Token: 0x04000D69 RID: 3433
		public ControllerMappingsCategories_Layout.Setting QuickMount;

		// Token: 0x04000D6A RID: 3434
		public ControllerMappingsCategories_Layout.Setting MapToggle;

		// Token: 0x04000D6B RID: 3435
		public ControllerMappingsCategories_Layout.Setting MiniMapToggle;

		// Token: 0x04000D6C RID: 3436
		public ControllerMappingsCategories_Layout.Setting ChatToggle;

		// Token: 0x04000D6D RID: 3437
		public ControllerMappingsCategories_Layout.Setting WiringOptions;

		// Token: 0x04000D6E RID: 3438
		public ControllerMappingsCategories_Layout.Setting ToggleEmotes;

		// Token: 0x04000D6F RID: 3439
		public ControllerMappingsCategories_Layout.Setting InventoryNavigation;

		// Token: 0x04000D70 RID: 3440
		public ControllerMappingsCategories_Layout.Setting InventoryNavigationAlt;

		// Token: 0x04000D71 RID: 3441
		public ControllerMappingsCategories_Layout.Setting LeftPageCycle;

		// Token: 0x04000D72 RID: 3442
		public ControllerMappingsCategories_Layout.Setting RightPageCycle;

		// Token: 0x04000D73 RID: 3443
		public ControllerMappingsCategories_Layout.Setting ThrowItem;

		// Token: 0x04000D74 RID: 3444
		public ControllerMappingsCategories_Layout.Setting TrashItem;

		// Token: 0x04000D75 RID: 3445
		public ControllerMappingsCategories_Layout.Setting DepositHeldItem;

		// Token: 0x04000D76 RID: 3446
		public ControllerMappingsCategories_Layout.Setting FavouriteItem;

		// Token: 0x04000D77 RID: 3447
		public ControllerMappingsCategories_Layout.Setting SplitItem;

		// Token: 0x04000D78 RID: 3448
		public ControllerMappingsCategories_Layout.Setting ResearchItem;

		// Token: 0x04000D79 RID: 3449
		public ControllerMappingsCategories_Layout.Setting ShowHideItem;

		// Token: 0x04000D7A RID: 3450
		public ControllerMappingsCategories_Layout.Setting Sort;

		// Token: 0x04000D7B RID: 3451
		public ControllerMappingsCategories_Layout.Setting BuilderTools;

		// Token: 0x04000D7C RID: 3452
		public ControllerMappingsCategories_Layout.Setting ChestQuickStack;

		// Token: 0x04000D7D RID: 3453
		public ControllerMappingsCategories_Layout.Setting ChestLootAll;

		// Token: 0x04000D7E RID: 3454
		public ControllerMappingsCategories_Layout.Setting ChestDepositAll;

		// Token: 0x04000D7F RID: 3455
		public ControllerMappingsCategories_Layout.Setting ChestRestock;

		// Token: 0x04000D80 RID: 3456
		public ControllerMappingsCategories_Layout.Setting ChestRename;

		// Token: 0x04000D81 RID: 3457
		public ControllerMappingsCategories_Layout.Setting ChestLoot;

		// Token: 0x04000D82 RID: 3458
		public ControllerMappingsCategories_Layout.Setting ChestDeposit;

		// Token: 0x04000D83 RID: 3459
		public ControllerMappingsCategories_Layout.Setting ChestSort;

		// Token: 0x04000D84 RID: 3460
		public ControllerMappingsCategories_Layout.Setting EquipmentEquip;

		// Token: 0x04000D85 RID: 3461
		public ControllerMappingsCategories_Layout.Setting EquipmentUnequip;

		// Token: 0x04000D86 RID: 3462
		public ControllerMappingsCategories_Layout.Setting ShopSell;

		// Token: 0x04000D87 RID: 3463
		public ControllerMappingsCategories_Layout.Setting ShopBuy;

		// Token: 0x04000D88 RID: 3464
		public ControllerMappingsCategories_Layout.Setting MaterialPrevious;

		// Token: 0x04000D89 RID: 3465
		public ControllerMappingsCategories_Layout.Setting MaterialNext;

		// Token: 0x04000D8A RID: 3466
		public ControllerMappingsCategories_Layout.Setting PVPEnableToggle;

		// Token: 0x04000D8B RID: 3467
		public ControllerMappingsCategories_Layout.Setting PVPTeleport;

		// Token: 0x04000D8C RID: 3468
		public ControllerMappingsCategories_Layout.Setting PVPSwitchTeam;

		// Token: 0x04000D8D RID: 3469
		public ControllerMappingsCategories_Layout.Setting BestiaryFilters;

		// Token: 0x04000D8E RID: 3470
		public ControllerMappingsCategories_Layout.Setting BestiaryFilterSearch;

		// Token: 0x04000D8F RID: 3471
		public ControllerMappingsCategories_Layout.Setting BestiarySortOrder;

		// Token: 0x04000D90 RID: 3472
		public ControllerMappingsCategories_Layout.Setting BestiaryDrops;

		// Token: 0x04000D91 RID: 3473
		public ControllerMappingsCategories_Layout.Setting PickupPlaceItem;

		// Token: 0x04000D92 RID: 3474
		public ControllerMappingsCategories_Layout.Setting InventoryClose;

		// Token: 0x04000D93 RID: 3475
		public ControllerMappingsCategories_Layout.Setting ReforgeItem;

		// Token: 0x04000D94 RID: 3476
		public ControllerMappingsCategories_Layout.Setting CraftItem;

		// Token: 0x04000D95 RID: 3477
		public ControllerMappingsCategories_Layout.Setting FilterItems;

		// Token: 0x04000D96 RID: 3478
		public ControllerMappingsCategories_Layout.Setting InfoAccessories;

		// Token: 0x04000D97 RID: 3479
		public ControllerMappingsCategories_Layout.Setting FilterItemsSearch;

		// Token: 0x04000D98 RID: 3480
		public ControllerMappingsCategories_Layout.Setting ToggleCraftDuplicate;

		// Token: 0x04000D99 RID: 3481
		public ControllerMappingsCategories_Layout.Setting HousingQuery;

		// Token: 0x04000D9A RID: 3482
		public ControllerMappingsCategories_Layout.Setting TakeOne;

		// Token: 0x04000D9B RID: 3483
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar1;

		// Token: 0x04000D9C RID: 3484
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar2;

		// Token: 0x04000D9D RID: 3485
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar3;

		// Token: 0x04000D9E RID: 3486
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar4;

		// Token: 0x04000D9F RID: 3487
		public ControllerMappingsCategories_Layout.Setting Hotbar1;

		// Token: 0x04000DA0 RID: 3488
		public ControllerMappingsCategories_Layout.Setting Hotbar2;

		// Token: 0x04000DA1 RID: 3489
		public ControllerMappingsCategories_Layout.Setting Hotbar3;

		// Token: 0x04000DA2 RID: 3490
		public ControllerMappingsCategories_Layout.Setting Hotbar4;

		// Token: 0x04000DA3 RID: 3491
		public ControllerMappingsCategories_Layout.Setting Hotbar5;

		// Token: 0x04000DA4 RID: 3492
		public ControllerMappingsCategories_Layout.Setting Hotbar6;

		// Token: 0x04000DA5 RID: 3493
		public ControllerMappingsCategories_Layout.Setting Hotbar7;

		// Token: 0x04000DA6 RID: 3494
		public ControllerMappingsCategories_Layout.Setting Hotbar8;

		// Token: 0x04000DA7 RID: 3495
		public ControllerMappingsCategories_Layout.Setting Hotbar9;

		// Token: 0x04000DA8 RID: 3496
		public ControllerMappingsCategories_Layout.Setting Hotbar10;

		// Token: 0x04000DA9 RID: 3497
		public ControllerMappingsCategories_Layout.Setting Loadout1;

		// Token: 0x04000DAA RID: 3498
		public ControllerMappingsCategories_Layout.Setting Loadout2;

		// Token: 0x04000DAB RID: 3499
		public ControllerMappingsCategories_Layout.Setting Loadout3;

		// Token: 0x04000DAC RID: 3500
		public ControllerMappingsCategories_Layout.Setting LoadoutCycle;
	}
}
