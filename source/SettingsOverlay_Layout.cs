using System;
using Microsoft.Xna.Framework;

// Token: 0x0200021C RID: 540
public class SettingsOverlay_Layout : LayoutDefinition
{
	// Token: 0x06000CCC RID: 3276 RVA: 0x0003E430 File Offset: 0x0003C630
	private void Awake()
	{
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x0003E440 File Offset: 0x0003C640
	public SettingsOverlay_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04001499 RID: 5273
	public static SettingsOverlay_Layout Instance;

	// Token: 0x0400149A RID: 5274
	public StringButton_Layout Title;

	// Token: 0x0400149B RID: 5275
	public StringButton_Layout Titlewide1;

	// Token: 0x0400149C RID: 5276
	public StringButton_Layout Titlewide2;

	// Token: 0x0400149D RID: 5277
	public Panel_Layout Backing;

	// Token: 0x0400149E RID: 5278
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x0400149F RID: 5279
	public Panel_Layout MenuDivider;

	// Token: 0x040014A0 RID: 5280
	public Panel_Layout MenuDivider2;

	// Token: 0x040014A1 RID: 5281
	public TransactionButton_Layout Close;

	// Token: 0x040014A2 RID: 5282
	public TransactionButton_Layout Home;

	// Token: 0x040014A3 RID: 5283
	public TransactionButton_Layout Achievements;

	// Token: 0x040014A4 RID: 5284
	public TransactionButton_Layout ResetSettings;

	// Token: 0x040014A5 RID: 5285
	public String_Layout ServerIPAddress;

	// Token: 0x040014A6 RID: 5286
	public SettingsOverlayOptionCategories_Layout.Category DefaultCategory;

	// Token: 0x040014A7 RID: 5287
	public SettingsOverlayCategories_Layout Categories;

	// Token: 0x040014A8 RID: 5288
	public SettingsOverlayOptionCategories_Layout OptionCategories;

	// Token: 0x040014A9 RID: 5289
	public SettingsOverlayLink_Layout LinkTemplate;

	// Token: 0x040014AA RID: 5290
	public SettingsOverlayListOption_Layout ListOptionTemplate;

	// Token: 0x040014AB RID: 5291
	public SettingsOverlaySlider_Layout SliderTemplate;

	// Token: 0x040014AC RID: 5292
	public SettingsOverlayToggle_Layout ToggleTemplate;

	// Token: 0x040014AD RID: 5293
	public SettingsOverlayToggle_Layout DisabledToggleTemplate;

	// Token: 0x040014AE RID: 5294
	public SettingsOverlayCycle_Layout CycleTemplate;

	// Token: 0x040014AF RID: 5295
	public SettingsOverlayPulldown_Layout PulldownTemplate;

	// Token: 0x040014B0 RID: 5296
	public SettingsOverlayListOption_Layout UIButtonOptionTemplate;

	// Token: 0x040014B1 RID: 5297
	public TransactionButton_Layout PulldownLBOption;

	// Token: 0x040014B2 RID: 5298
	public TransactionButton_Layout PulldownLTOption;

	// Token: 0x040014B3 RID: 5299
	public TransactionButton_Layout PulldownRBOption;

	// Token: 0x040014B4 RID: 5300
	public TransactionButton_Layout PulldownRTOption;

	// Token: 0x040014B5 RID: 5301
	public TransactionButton_Layout PulldownAction1Option;

	// Token: 0x040014B6 RID: 5302
	public TransactionButton_Layout PulldownAction2Option;

	// Token: 0x040014B7 RID: 5303
	public TransactionButton_Layout PulldownAction3Option;

	// Token: 0x040014B8 RID: 5304
	public TransactionButton_Layout PulldownAction4Option;

	// Token: 0x040014B9 RID: 5305
	public Vector2 PulldownMainButtonOffset;

	// Token: 0x040014BA RID: 5306
	public int PulldownButtonLineWidth;

	// Token: 0x040014BB RID: 5307
	public int InGameOffset;
}
