using System;

// Token: 0x0200019C RID: 412
public class ClothesWindow_Layout : LayoutDefinition
{
	// Token: 0x06000B65 RID: 2917 RVA: 0x00039690 File Offset: 0x00037890
	private void Awake()
	{
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x000396A0 File Offset: 0x000378A0
	public ClothesWindow_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000CE8 RID: 3304
	public static ClothesWindow_Layout Instance;

	// Token: 0x04000CE9 RID: 3305
	public StringButton_Layout Title;

	// Token: 0x04000CEA RID: 3306
	public Panel_Layout MenuDivider;

	// Token: 0x04000CEB RID: 3307
	public Panel_Layout MenuDivider2;

	// Token: 0x04000CEC RID: 3308
	public Panel_Layout Backing;

	// Token: 0x04000CED RID: 3309
	public Panel_Layout CharacterPosition;

	// Token: 0x04000CEE RID: 3310
	public Panel_Layout ChangePreviewPosition;

	// Token: 0x04000CEF RID: 3311
	public String_Layout BuyButton;

	// Token: 0x04000CF0 RID: 3312
	public String_Layout CancelButton;

	// Token: 0x04000CF1 RID: 3313
	public String_Layout Savings;

	// Token: 0x04000CF2 RID: 3314
	public TransactionButton_Layout Shirt;

	// Token: 0x04000CF3 RID: 3315
	public TransactionButton_Layout Undershirt;

	// Token: 0x04000CF4 RID: 3316
	public TransactionButton_Layout Pants;

	// Token: 0x04000CF5 RID: 3317
	public TransactionButton_Layout Shoes;

	// Token: 0x04000CF6 RID: 3318
	public TransactionButton_Layout Eyes;

	// Token: 0x04000CF7 RID: 3319
	public TransactionButton_Layout Skin;

	// Token: 0x04000CF8 RID: 3320
	public TransactionButton_Layout Style;

	// Token: 0x04000CF9 RID: 3321
	public TransactionButton_Layout ChangeButton;

	// Token: 0x04000CFA RID: 3322
	public TransactionButton_Layout Close;

	// Token: 0x04000CFB RID: 3323
	public ItemGrid_Layout StylesGrid;

	// Token: 0x04000CFC RID: 3324
	public Panel_Layout StyleBacking;

	// Token: 0x04000CFD RID: 3325
	public Panel_Layout SelectedStyleBacking;

	// Token: 0x04000CFE RID: 3326
	public TransactionButton_Layout LightnessBacking;

	// Token: 0x04000CFF RID: 3327
	public Slider_Layout Lightness;

	// Token: 0x04000D00 RID: 3328
	public TransactionButton_Layout SaturationBacking;

	// Token: 0x04000D01 RID: 3329
	public Slider_Layout Saturation;

	// Token: 0x04000D02 RID: 3330
	public TransactionButton_Layout HueBacking;

	// Token: 0x04000D03 RID: 3331
	public Slider_Layout Hue;

	// Token: 0x04000D04 RID: 3332
	public TransactionButton_Layout ColourValue;
}
