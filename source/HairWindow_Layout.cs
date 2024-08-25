using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001D5 RID: 469
public class HairWindow_Layout : LayoutDefinition
{
	// Token: 0x06000C0D RID: 3085 RVA: 0x0003BD7C File Offset: 0x00039F7C
	private void Awake()
	{
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x0003BD8C File Offset: 0x00039F8C
	public HairWindow_Layout()
	{
		if (16928 == 0)
		{
		}
		this.DisabledBackingColor = 16928;
		base..ctor();
	}

	// Token: 0x040010BE RID: 4286
	public static HairWindow_Layout Instance;

	// Token: 0x040010BF RID: 4287
	public Panel_Layout Backing;

	// Token: 0x040010C0 RID: 4288
	public StringButton_Layout Title;

	// Token: 0x040010C1 RID: 4289
	public DraggableItemGrid_Layout HairGrid;

	// Token: 0x040010C2 RID: 4290
	public Panel_Layout CharacterBacking;

	// Token: 0x040010C3 RID: 4291
	public Panel_Layout CharacterPosition;

	// Token: 0x040010C4 RID: 4292
	public bool SlidersExclusive;

	// Token: 0x040010C5 RID: 4293
	public Panel_Layout MenuDivider;

	// Token: 0x040010C6 RID: 4294
	public Panel_Layout MenuDivider2;

	// Token: 0x040010C7 RID: 4295
	public Texture_Layout SlidersIcon;

	// Token: 0x040010C8 RID: 4296
	public TransactionButton_Layout ColourButton;

	// Token: 0x040010C9 RID: 4297
	public TransactionButton_Layout HairStyleButton;

	// Token: 0x040010CA RID: 4298
	public Panel_Layout SlidersBacking;

	// Token: 0x040010CB RID: 4299
	public TransactionButton_Layout LightnessBacking;

	// Token: 0x040010CC RID: 4300
	public Slider_Layout Lightness;

	// Token: 0x040010CD RID: 4301
	public TransactionButton_Layout SaturationBacking;

	// Token: 0x040010CE RID: 4302
	public Slider_Layout Saturation;

	// Token: 0x040010CF RID: 4303
	public TransactionButton_Layout HueBacking;

	// Token: 0x040010D0 RID: 4304
	public Slider_Layout Hue;

	// Token: 0x040010D1 RID: 4305
	public TransactionButton_Layout ColourValue;

	// Token: 0x040010D2 RID: 4306
	public float HairScale;

	// Token: 0x040010D3 RID: 4307
	public float HairHighlightScale;

	// Token: 0x040010D4 RID: 4308
	public Panel_Layout SavingsBacking;

	// Token: 0x040010D5 RID: 4309
	public String_Layout Savings;

	// Token: 0x040010D6 RID: 4310
	public String_Layout Cost;

	// Token: 0x040010D7 RID: 4311
	public String_Layout ControllerCost;

	// Token: 0x040010D8 RID: 4312
	public String_Layout SavingsTitle;

	// Token: 0x040010D9 RID: 4313
	public Vector2 Savings1IconOffset = 17008;

	// Token: 0x040010DA RID: 4314
	public Vector2 Savings2IconOffset = 16968;

	// Token: 0x040010DB RID: 4315
	public Vector2 Savings3IconOffset = 16968;

	// Token: 0x040010DC RID: 4316
	public Vector2 Savings4IconOffset = 16928;

	// Token: 0x040010DD RID: 4317
	public TransactionButton_Layout Close;

	// Token: 0x040010DE RID: 4318
	public TransactionButton_Layout ActionButton;

	// Token: 0x040010DF RID: 4319
	public bool DrawEmptySlots = true;

	// Token: 0x040010E0 RID: 4320
	public Texture_Layout DisabledBacking;

	// Token: 0x040010E1 RID: 4321
	public Color DisabledBackingColor;

	// Token: 0x040010E2 RID: 4322
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x040010E3 RID: 4323
	public Color DisabledBackingIconColor;
}
