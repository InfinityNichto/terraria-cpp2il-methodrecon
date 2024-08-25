using System;
using Microsoft.Xna.Framework;

// Token: 0x020001F9 RID: 505
public class InterfaceEdit_Layout : LayoutDefinition
{
	// Token: 0x06000C92 RID: 3218 RVA: 0x0003DECC File Offset: 0x0003C0CC
	private void Awake()
	{
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x0003DEDC File Offset: 0x0003C0DC
	public InterfaceEdit_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001252 RID: 4690
	public static InterfaceEdit_Layout Instance;

	// Token: 0x04001253 RID: 4691
	public StringButton_Layout Title;

	// Token: 0x04001254 RID: 4692
	public Panel_Layout MenuDivider;

	// Token: 0x04001255 RID: 4693
	public Panel_Layout MenuDivider2;

	// Token: 0x04001256 RID: 4694
	public Panel_Layout MenuDivider3;

	// Token: 0x04001257 RID: 4695
	public Panel_Layout MenuBacking;

	// Token: 0x04001258 RID: 4696
	public Panel_Layout MenuBackingWithOptions;

	// Token: 0x04001259 RID: 4697
	public Panel_Layout SafeRegionMenuBacking;

	// Token: 0x0400125A RID: 4698
	public TransactionButton_Layout SafeRegionFinish;

	// Token: 0x0400125B RID: 4699
	public TransactionButton_Layout SafeRegionResetDefaults;

	// Token: 0x0400125C RID: 4700
	public TransactionButton_Layout SafeRegionCancelChanges;

	// Token: 0x0400125D RID: 4701
	public TransactionButton_Layout Finish;

	// Token: 0x0400125E RID: 4702
	public TransactionButton_Layout ResetDefaults;

	// Token: 0x0400125F RID: 4703
	public TransactionButton_Layout CancelChanges;

	// Token: 0x04001260 RID: 4704
	public TransactionButton_Layout InterfacePosition;

	// Token: 0x04001261 RID: 4705
	public TransactionButton_Layout SafeRegion;

	// Token: 0x04001262 RID: 4706
	public TransactionButton_Layout EditControls;

	// Token: 0x04001263 RID: 4707
	public Vector2 InventoryPageSize;

	// Token: 0x04001264 RID: 4708
	public Vector2 InventoryPageSize_Console;

	// Token: 0x04001265 RID: 4709
	public Vector2 GeneralPageSize;

	// Token: 0x04001266 RID: 4710
	public Vector2 GeneralPageSize_Console;

	// Token: 0x04001267 RID: 4711
	public Vector2 GeneralPageSizeCollapsed;

	// Token: 0x04001268 RID: 4712
	public Vector2 GeneralPageSizeCollapsed_Console;

	// Token: 0x04001269 RID: 4713
	public TransactionButton_Layout ProfileValue;

	// Token: 0x0400126A RID: 4714
	public TransactionButton_Layout ProfileRename;

	// Token: 0x0400126B RID: 4715
	public String_Layout ProfileRenameTitle;

	// Token: 0x0400126C RID: 4716
	public Panel_Layout OptionsGreyout;

	// Token: 0x0400126D RID: 4717
	public Panel_Layout ProfileOptionsBacking;

	// Token: 0x0400126E RID: 4718
	public float ProfileOptionsExtraPadding;

	// Token: 0x0400126F RID: 4719
	public TransactionButton_Layout Profile1;

	// Token: 0x04001270 RID: 4720
	public TransactionButton_Layout Profile2;

	// Token: 0x04001271 RID: 4721
	public TransactionButton_Layout Profile3;

	// Token: 0x04001272 RID: 4722
	public TransactionButton_Layout Profile4;

	// Token: 0x04001273 RID: 4723
	public TransactionButton_Layout TemplateProfileValue;

	// Token: 0x04001274 RID: 4724
	public String_Layout TemplateProfileTitle;

	// Token: 0x04001275 RID: 4725
	public Panel_Layout TemplateProfileOptionsBacking;

	// Token: 0x04001276 RID: 4726
	public float TemplateProfileExtraPadding;

	// Token: 0x04001277 RID: 4727
	public TransactionButton_Layout TemplateProfile1;

	// Token: 0x04001278 RID: 4728
	public TransactionButton_Layout TemplateProfile2;

	// Token: 0x04001279 RID: 4729
	public TransactionButton_Layout TemplateProfile3;

	// Token: 0x0400127A RID: 4730
	public TransactionButton_Layout TemplateProfile4;

	// Token: 0x0400127B RID: 4731
	public TransactionButton_Layout TemplateProfile5;

	// Token: 0x0400127C RID: 4732
	public TransactionButton_Layout EditGroups;

	// Token: 0x0400127D RID: 4733
	public TransactionButton_Layout EditGroupsButton;

	// Token: 0x0400127E RID: 4734
	public Slider_Layout UIScale;

	// Token: 0x0400127F RID: 4735
	public TransactionButton_Layout UIScaleLabel;

	// Token: 0x04001280 RID: 4736
	public TransactionButton_Layout ExitEditGroup;

	// Token: 0x04001281 RID: 4737
	public TransactionButton_Layout AddGroup;

	// Token: 0x04001282 RID: 4738
	public TransactionButton_Layout AddGroupCaption;

	// Token: 0x04001283 RID: 4739
	public TransactionButton_Layout DeleteGroup;

	// Token: 0x04001284 RID: 4740
	public TransactionButton_Layout ConfigureGroup;

	// Token: 0x04001285 RID: 4741
	public Vector2 ToggleBackingTLOffset;

	// Token: 0x04001286 RID: 4742
	public Vector2 ToggleBackingBROffset;

	// Token: 0x04001287 RID: 4743
	public Panel_Layout ToggleBacking;

	// Token: 0x04001288 RID: 4744
	public float ToggleScale;

	// Token: 0x04001289 RID: 4745
	public ItemGrid_Layout ToggleOptions;

	// Token: 0x0400128A RID: 4746
	public TransactionButton_Layout ToggleEntry;

	// Token: 0x0400128B RID: 4747
	public String_Layout ScreenSize;

	// Token: 0x0400128C RID: 4748
	public String_Layout GroupSize;

	// Token: 0x0400128D RID: 4749
	public DraggableItemGrid_Layout PageGrid;

	// Token: 0x0400128E RID: 4750
	public Panel_Layout PageEntryBacking;

	// Token: 0x0400128F RID: 4751
	public Panel_Layout PageEntrySelectedBacking;

	// Token: 0x04001290 RID: 4752
	public ItemGrid_Layout PageGridLeft;

	// Token: 0x04001291 RID: 4753
	public ItemGrid_Layout PageGridRight;

	// Token: 0x04001292 RID: 4754
	public String_Layout PageEmptyLeft;

	// Token: 0x04001293 RID: 4755
	public String_Layout PageEmptyRight;

	// Token: 0x04001294 RID: 4756
	public TransactionButton_Layout PageIconEntry;
}
