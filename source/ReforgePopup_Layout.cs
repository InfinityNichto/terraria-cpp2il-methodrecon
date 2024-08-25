using System;
using Microsoft.Xna.Framework;

// Token: 0x02000233 RID: 563
public class ReforgePopup_Layout : LayoutDefinition
{
	// Token: 0x06000D01 RID: 3329 RVA: 0x0003E990 File Offset: 0x0003CB90
	private void Awake()
	{
	}

	// Token: 0x06000D02 RID: 3330 RVA: 0x0003E9A0 File Offset: 0x0003CBA0
	public ReforgePopup_Layout()
	{
		if (16928 == 0)
		{
		}
		base..ctor();
	}

	// Token: 0x040016E8 RID: 5864
	public static ReforgePopup_Layout Instance;

	// Token: 0x040016E9 RID: 5865
	public int BackingTextPadding;

	// Token: 0x040016EA RID: 5866
	public int BackingTextPaddingController;

	// Token: 0x040016EB RID: 5867
	public int MinTextHeight;

	// Token: 0x040016EC RID: 5868
	public int TextBackingOffset;

	// Token: 0x040016ED RID: 5869
	public int MaxWidthLastLineAddition = 150;

	// Token: 0x040016EE RID: 5870
	public Panel_Layout Backing;

	// Token: 0x040016EF RID: 5871
	public String_Layout Text;

	// Token: 0x040016F0 RID: 5872
	public Panel_Layout TextBacking;

	// Token: 0x040016F1 RID: 5873
	public Panel_Layout MenuDivider;

	// Token: 0x040016F2 RID: 5874
	public TransactionButton_Layout Close;

	// Token: 0x040016F3 RID: 5875
	public TransactionButton_Layout Reforge;

	// Token: 0x040016F4 RID: 5876
	public Panel_Layout SavingsBacking;

	// Token: 0x040016F5 RID: 5877
	public String_Layout Savings;

	// Token: 0x040016F6 RID: 5878
	public String_Layout SavingsTitle;

	// Token: 0x040016F7 RID: 5879
	public Vector2 Savings1IconOffset = 17008;

	// Token: 0x040016F8 RID: 5880
	public Vector2 Savings2IconOffset = 16968;

	// Token: 0x040016F9 RID: 5881
	public Vector2 Savings3IconOffset = 16968;

	// Token: 0x040016FA RID: 5882
	public Vector2 Savings4IconOffset = 16928;

	// Token: 0x040016FB RID: 5883
	public String_Layout ReforgeCost;

	// Token: 0x040016FC RID: 5884
	public String_Layout ReforgeCostController;

	// Token: 0x040016FD RID: 5885
	public String_Layout ReforgeItemName;

	// Token: 0x040016FE RID: 5886
	public Panel_Layout ReforgeItemNameDivider;

	// Token: 0x040016FF RID: 5887
	public Panel_Layout ReforgeItem;

	// Token: 0x04001700 RID: 5888
	public Panel_Layout ReforgeItemBacking;
}
