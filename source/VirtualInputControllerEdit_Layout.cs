using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200021F RID: 543
public class VirtualInputControllerEdit_Layout : LayoutDefinition
{
	// Token: 0x06000CD2 RID: 3282 RVA: 0x0003E4A8 File Offset: 0x0003C6A8
	private void Awake()
	{
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0003E4B8 File Offset: 0x0003C6B8
	public VirtualInputControllerEdit_Layout()
	{
		if (!true)
		{
		}
		this.LeftControlRegionDraggingBackingColor = 1;
		this.LeftControlRegionDraggingBorderColor = 1;
		this.RightControlRegionDraggingBackingColor = 1;
		this.RightControlRegionDraggingBorderColor = 1;
		this.LeftInterfaceRegionDraggingBackingColor = 1;
		this.LeftInterfaceRegionDraggingBorderColor = 1;
		this.RightInterfaceRegionDraggingBackingColor = 1;
		this.RightInterfaceRegionDraggingBorderColor = 1;
		this.DisabledPageBackingColor = 1;
		this.DisabledPageIconColor = 1;
		this.DisabledHotbarColor = 1;
		this.DisabledInventoryColor = 1;
		this.DisabledTrashColor = 1;
		this.DisabledTrashIconColor = 1;
		this.DisabledChestColor = 1;
		this.DisabledPageTitleColor = 1;
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x040014C9 RID: 5321
	public static VirtualInputControllerEdit_Layout Instance;

	// Token: 0x040014CA RID: 5322
	public float ControllerDragSpeed;

	// Token: 0x040014CB RID: 5323
	public TransactionButton_Layout Finish;

	// Token: 0x040014CC RID: 5324
	public TransactionButton_Layout ResetDefaults;

	// Token: 0x040014CD RID: 5325
	public TransactionButton_Layout CancelChanges;

	// Token: 0x040014CE RID: 5326
	public ItemGrid_Layout ControlSelection;

	// Token: 0x040014CF RID: 5327
	public Panel_Layout AllowedLeftRegion;

	// Token: 0x040014D0 RID: 5328
	public Panel_Layout AllowedRightRegion;

	// Token: 0x040014D1 RID: 5329
	public Panel_Layout LeftControlRegion;

	// Token: 0x040014D2 RID: 5330
	public Color LeftControlRegionDraggingBackingColor;

	// Token: 0x040014D3 RID: 5331
	public Color LeftControlRegionDraggingBorderColor;

	// Token: 0x040014D4 RID: 5332
	public Panel_Layout RightControlRegion;

	// Token: 0x040014D5 RID: 5333
	public Color RightControlRegionDraggingBackingColor;

	// Token: 0x040014D6 RID: 5334
	public Color RightControlRegionDraggingBorderColor;

	// Token: 0x040014D7 RID: 5335
	public Panel_Layout AllowedInterfaceLeftRegion;

	// Token: 0x040014D8 RID: 5336
	public Panel_Layout AllowedInterfaceRightRegion;

	// Token: 0x040014D9 RID: 5337
	public Panel_Layout AllowedInterfaceLeftRegionSmall;

	// Token: 0x040014DA RID: 5338
	public Panel_Layout AllowedInterfaceRightRegionSmall;

	// Token: 0x040014DB RID: 5339
	public Panel_Layout LeftInterfaceRegion;

	// Token: 0x040014DC RID: 5340
	public Panel_Layout RightInterfaceRegion;

	// Token: 0x040014DD RID: 5341
	public Color LeftInterfaceRegionDraggingBackingColor;

	// Token: 0x040014DE RID: 5342
	public Color LeftInterfaceRegionDraggingBorderColor;

	// Token: 0x040014DF RID: 5343
	public Color RightInterfaceRegionDraggingBackingColor;

	// Token: 0x040014E0 RID: 5344
	public Color RightInterfaceRegionDraggingBorderColor;

	// Token: 0x040014E1 RID: 5345
	public Color DisabledPageBackingColor;

	// Token: 0x040014E2 RID: 5346
	public Color DisabledPageIconColor;

	// Token: 0x040014E3 RID: 5347
	public Color DisabledHotbarColor;

	// Token: 0x040014E4 RID: 5348
	public Color DisabledInventoryColor;

	// Token: 0x040014E5 RID: 5349
	public Color DisabledTrashColor;

	// Token: 0x040014E6 RID: 5350
	public Color DisabledTrashIconColor;

	// Token: 0x040014E7 RID: 5351
	public Color DisabledChestColor;

	// Token: 0x040014E8 RID: 5352
	public Color DisabledPageTitleColor;

	// Token: 0x040014E9 RID: 5353
	public Panel_Layout ScreenBacking;

	// Token: 0x040014EA RID: 5354
	public Panel_Layout ControlsBacking;

	// Token: 0x040014EB RID: 5355
	public ItemGrid_Layout ControlsGrid;

	// Token: 0x040014EC RID: 5356
	public float ControlsItemScale;

	// Token: 0x040014ED RID: 5357
	public Vector2 ControlsGridAxisOffset;

	// Token: 0x040014EE RID: 5358
	public Vector2 ControlsGridButtonOffset;

	// Token: 0x040014EF RID: 5359
	public TransactionButton_Layout Mappings;

	// Token: 0x040014F0 RID: 5360
	public TransactionButton_Layout Controls;

	// Token: 0x040014F1 RID: 5361
	public FadeString_Layout FadeLabel;

	// Token: 0x040014F2 RID: 5362
	public VirtualInputControllerEdit_Layout.SlotPriority ControlPriority;

	// Token: 0x040014F3 RID: 5363
	public VirtualInputControllerEdit_Layout.ControlsWidgets EditControlWidgets;

	// Token: 0x02000220 RID: 544
	[Serializable]
	public class SlotPriority
	{
		// Token: 0x06000CD4 RID: 3284 RVA: 0x0003E544 File Offset: 0x0003C744
		public int Priority(VirtualControlsHardwareConfigurationMapping_Layout.ContolType type)
		{
			return this.AutoFire;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0003E55C File Offset: 0x0003C75C
		public SlotPriority()
		{
		}

		// Token: 0x040014F4 RID: 5364
		public int AutoFire;

		// Token: 0x040014F5 RID: 5365
		public int SmartCursor;

		// Token: 0x040014F6 RID: 5366
		public int CombatTargetting;

		// Token: 0x040014F7 RID: 5367
		public int Jump;

		// Token: 0x040014F8 RID: 5368
		public int Heal;

		// Token: 0x040014F9 RID: 5369
		public int Mana;

		// Token: 0x040014FA RID: 5370
		public int Buff;

		// Token: 0x040014FB RID: 5371
		public int Mount;

		// Token: 0x040014FC RID: 5372
		public int Interact;

		// Token: 0x040014FD RID: 5373
		public int Fire;

		// Token: 0x040014FE RID: 5374
		public int GrappleAxis;

		// Token: 0x040014FF RID: 5375
		public int AutoSelect;

		// Token: 0x04001500 RID: 5376
		public int ZoomIn;

		// Token: 0x04001501 RID: 5377
		public int ZoomOut;

		// Token: 0x04001502 RID: 5378
		public int Move;

		// Token: 0x04001503 RID: 5379
		public int Aim;

		// Token: 0x04001504 RID: 5380
		public int GrappleFire;

		// Token: 0x04001505 RID: 5381
		public int ProfileSwitch;

		// Token: 0x04001506 RID: 5382
		public int Unbound;

		// Token: 0x04001507 RID: 5383
		public int InventoryToggle;

		// Token: 0x04001508 RID: 5384
		public int Settings;

		// Token: 0x04001509 RID: 5385
		public int Loadout1;

		// Token: 0x0400150A RID: 5386
		public int Loadout2;

		// Token: 0x0400150B RID: 5387
		public int Loadout3;

		// Token: 0x0400150C RID: 5388
		public int LoadoutCycle;
	}

	// Token: 0x02000221 RID: 545
	[Serializable]
	public class ControlsWidgets
	{
		// Token: 0x06000CD6 RID: 3286 RVA: 0x0003E570 File Offset: 0x0003C770
		public ControlsWidgets()
		{
		}

		// Token: 0x0400150D RID: 5389
		public Panel_Layout OptionsGreyout;

		// Token: 0x0400150E RID: 5390
		public TransactionButton_Layout ProfileValue;

		// Token: 0x0400150F RID: 5391
		public String_Layout ProfileTitle;

		// Token: 0x04001510 RID: 5392
		public TransactionButton_Layout ProfileRename;

		// Token: 0x04001511 RID: 5393
		public Panel_Layout ProfileOptionsBacking;

		// Token: 0x04001512 RID: 5394
		public TransactionButton_Layout Profile1;

		// Token: 0x04001513 RID: 5395
		public TransactionButton_Layout Profile2;

		// Token: 0x04001514 RID: 5396
		public TransactionButton_Layout Profile3;

		// Token: 0x04001515 RID: 5397
		public TransactionButton_Layout Profile4;

		// Token: 0x04001516 RID: 5398
		public TransactionButton_Layout HardwareValue;

		// Token: 0x04001517 RID: 5399
		public String_Layout HardwareTitle;

		// Token: 0x04001518 RID: 5400
		public Panel_Layout HardwareOptionsBacking;

		// Token: 0x04001519 RID: 5401
		public TransactionButton_Layout Hardware1;

		// Token: 0x0400151A RID: 5402
		public TransactionButton_Layout Hardware2;

		// Token: 0x0400151B RID: 5403
		public TransactionButton_Layout Hardware3;

		// Token: 0x0400151C RID: 5404
		public TransactionButton_Layout Hardware4;

		// Token: 0x0400151D RID: 5405
		public TransactionButton_Layout StyleValue;

		// Token: 0x0400151E RID: 5406
		public String_Layout StyleTitle;

		// Token: 0x0400151F RID: 5407
		public Panel_Layout StyleOptionsBacking2;

		// Token: 0x04001520 RID: 5408
		public Panel_Layout StyleOptionsBacking3;

		// Token: 0x04001521 RID: 5409
		public TransactionButton_Layout Style1;

		// Token: 0x04001522 RID: 5410
		public TransactionButton_Layout Style2;

		// Token: 0x04001523 RID: 5411
		public TransactionButton_Layout Style3;

		// Token: 0x04001524 RID: 5412
		public Panel_Layout PageOptionsBacking;

		// Token: 0x04001525 RID: 5413
		public TransactionButton_Layout PageOptionValue;

		// Token: 0x04001526 RID: 5414
		public TransactionButton_Layout BottomControls;

		// Token: 0x04001527 RID: 5415
		public TransactionButton_Layout SideControls;

		// Token: 0x04001528 RID: 5416
		public TransactionButton_Layout Undo;

		// Token: 0x04001529 RID: 5417
		public TransactionButton_Layout Redo;
	}
}
