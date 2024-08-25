using System;
using System.Runtime.InteropServices;

// Token: 0x020001E7 RID: 487
[Serializable]
public class KeyboardMappingsCategories_Layout
{
	// Token: 0x06000C4E RID: 3150 RVA: 0x0003D3BC File Offset: 0x0003B5BC
	public void GetCategorySetup(string id, [Out] KeyboardMappingsCategories_Layout.Category category, [Out] int sortOrder, int axisIndex = 0)
	{
		category.value__ = 1;
		uint num = <PrivateImplementationDetails>.ComputeStringHash(id);
		bool flag = id == "KeyboardAutoFire";
		KeyboardMappingsCategories_Layout.Setting autoFire = this.MappingSettings.AutoFire;
	}

	// Token: 0x06000C4F RID: 3151 RVA: 0x0003D868 File Offset: 0x0003BA68
	public KeyboardMappingsCategories_Layout()
	{
	}

	// Token: 0x04001193 RID: 4499
	public Panel_Layout Backing;

	// Token: 0x04001194 RID: 4500
	public TransactionButton_Layout GeneralSettings;

	// Token: 0x04001195 RID: 4501
	public TransactionButton_Layout Exploration;

	// Token: 0x04001196 RID: 4502
	public TransactionButton_Layout Fighting;

	// Token: 0x04001197 RID: 4503
	public TransactionButton_Layout Miscellaneous;

	// Token: 0x04001198 RID: 4504
	public TransactionButton_Layout UI;

	// Token: 0x04001199 RID: 4505
	public TransactionButton_Layout Chest;

	// Token: 0x0400119A RID: 4506
	public TransactionButton_Layout Equipment;

	// Token: 0x0400119B RID: 4507
	public TransactionButton_Layout Multiplayer;

	// Token: 0x0400119C RID: 4508
	public TransactionButton_Layout ShopCraft;

	// Token: 0x0400119D RID: 4509
	public TransactionButton_Layout Map;

	// Token: 0x0400119E RID: 4510
	public TransactionButton_Layout LB;

	// Token: 0x0400119F RID: 4511
	public TransactionButton_Layout RB;

	// Token: 0x040011A0 RID: 4512
	public KeyboardMappingsCategories_Layout.MappingCategories MappingSettings;

	// Token: 0x020001E8 RID: 488
	public enum Category
	{
		// Token: 0x040011A2 RID: 4514
		GeneralSettings,
		// Token: 0x040011A3 RID: 4515
		Exploration,
		// Token: 0x040011A4 RID: 4516
		Fighting,
		// Token: 0x040011A5 RID: 4517
		Miscellaneous,
		// Token: 0x040011A6 RID: 4518
		UI,
		// Token: 0x040011A7 RID: 4519
		Chest,
		// Token: 0x040011A8 RID: 4520
		Equipment,
		// Token: 0x040011A9 RID: 4521
		Multiplayer,
		// Token: 0x040011AA RID: 4522
		ShopCraft,
		// Token: 0x040011AB RID: 4523
		Map
	}

	// Token: 0x020001E9 RID: 489
	[Serializable]
	public class Setting
	{
		// Token: 0x06000C50 RID: 3152 RVA: 0x0003D87C File Offset: 0x0003BA7C
		public Setting()
		{
		}

		// Token: 0x040011AC RID: 4524
		public KeyboardMappingsCategories_Layout.Category Category = KeyboardMappingsCategories_Layout.Category.Exploration;

		// Token: 0x040011AD RID: 4525
		public int SortOrder;
	}

	// Token: 0x020001EA RID: 490
	[Serializable]
	public class MappingCategories
	{
		// Token: 0x06000C51 RID: 3153 RVA: 0x0003D898 File Offset: 0x0003BA98
		public MappingCategories()
		{
		}

		// Token: 0x040011AE RID: 4526
		public KeyboardMappingsCategories_Layout.Setting Up;

		// Token: 0x040011AF RID: 4527
		public KeyboardMappingsCategories_Layout.Setting Left;

		// Token: 0x040011B0 RID: 4528
		public KeyboardMappingsCategories_Layout.Setting Down;

		// Token: 0x040011B1 RID: 4529
		public KeyboardMappingsCategories_Layout.Setting Right;

		// Token: 0x040011B2 RID: 4530
		public KeyboardMappingsCategories_Layout.Setting GrappleFire;

		// Token: 0x040011B3 RID: 4531
		public KeyboardMappingsCategories_Layout.Setting Jump;

		// Token: 0x040011B4 RID: 4532
		public KeyboardMappingsCategories_Layout.Setting Fire;

		// Token: 0x040011B5 RID: 4533
		public KeyboardMappingsCategories_Layout.Setting Interact;

		// Token: 0x040011B6 RID: 4534
		public KeyboardMappingsCategories_Layout.Setting TargetLockOn;

		// Token: 0x040011B7 RID: 4535
		public KeyboardMappingsCategories_Layout.Setting InventoryToggle;

		// Token: 0x040011B8 RID: 4536
		public KeyboardMappingsCategories_Layout.Setting AutoSelect;

		// Token: 0x040011B9 RID: 4537
		public KeyboardMappingsCategories_Layout.Setting SmartCursor;

		// Token: 0x040011BA RID: 4538
		public KeyboardMappingsCategories_Layout.Setting AutoFire;

		// Token: 0x040011BB RID: 4539
		public KeyboardMappingsCategories_Layout.Setting HotbarNext;

		// Token: 0x040011BC RID: 4540
		public KeyboardMappingsCategories_Layout.Setting HotbarPrevious;

		// Token: 0x040011BD RID: 4541
		public KeyboardMappingsCategories_Layout.Setting ZoomIn;

		// Token: 0x040011BE RID: 4542
		public KeyboardMappingsCategories_Layout.Setting ZoomOut;

		// Token: 0x040011BF RID: 4543
		public KeyboardMappingsCategories_Layout.Setting MapZoomIn;

		// Token: 0x040011C0 RID: 4544
		public KeyboardMappingsCategories_Layout.Setting MapZoomOut;

		// Token: 0x040011C1 RID: 4545
		public KeyboardMappingsCategories_Layout.Setting MapZoomDefault;

		// Token: 0x040011C2 RID: 4546
		public KeyboardMappingsCategories_Layout.Setting QuickMount;

		// Token: 0x040011C3 RID: 4547
		public KeyboardMappingsCategories_Layout.Setting QuickHeal;

		// Token: 0x040011C4 RID: 4548
		public KeyboardMappingsCategories_Layout.Setting QuickBuff;

		// Token: 0x040011C5 RID: 4549
		public KeyboardMappingsCategories_Layout.Setting QuickMana;

		// Token: 0x040011C6 RID: 4550
		public KeyboardMappingsCategories_Layout.Setting MapToggle;

		// Token: 0x040011C7 RID: 4551
		public KeyboardMappingsCategories_Layout.Setting MiniMapToggle;

		// Token: 0x040011C8 RID: 4552
		public KeyboardMappingsCategories_Layout.Setting ChatToggle;

		// Token: 0x040011C9 RID: 4553
		public KeyboardMappingsCategories_Layout.Setting Settings;

		// Token: 0x040011CA RID: 4554
		public KeyboardMappingsCategories_Layout.Setting Hotbar1;

		// Token: 0x040011CB RID: 4555
		public KeyboardMappingsCategories_Layout.Setting Hotbar2;

		// Token: 0x040011CC RID: 4556
		public KeyboardMappingsCategories_Layout.Setting Hotbar3;

		// Token: 0x040011CD RID: 4557
		public KeyboardMappingsCategories_Layout.Setting Hotbar4;

		// Token: 0x040011CE RID: 4558
		public KeyboardMappingsCategories_Layout.Setting Hotbar5;

		// Token: 0x040011CF RID: 4559
		public KeyboardMappingsCategories_Layout.Setting Hotbar6;

		// Token: 0x040011D0 RID: 4560
		public KeyboardMappingsCategories_Layout.Setting Hotbar7;

		// Token: 0x040011D1 RID: 4561
		public KeyboardMappingsCategories_Layout.Setting Hotbar8;

		// Token: 0x040011D2 RID: 4562
		public KeyboardMappingsCategories_Layout.Setting Hotbar9;

		// Token: 0x040011D3 RID: 4563
		public KeyboardMappingsCategories_Layout.Setting Hotbar10;

		// Token: 0x040011D4 RID: 4564
		public KeyboardMappingsCategories_Layout.Setting Loadout1;

		// Token: 0x040011D5 RID: 4565
		public KeyboardMappingsCategories_Layout.Setting Loadout2;

		// Token: 0x040011D6 RID: 4566
		public KeyboardMappingsCategories_Layout.Setting Loadout3;

		// Token: 0x040011D7 RID: 4567
		public KeyboardMappingsCategories_Layout.Setting LoadoutCycle;

		// Token: 0x040011D8 RID: 4568
		public KeyboardMappingsCategories_Layout.Setting LeftPageCycle;

		// Token: 0x040011D9 RID: 4569
		public KeyboardMappingsCategories_Layout.Setting RightPageCycle;
	}
}
