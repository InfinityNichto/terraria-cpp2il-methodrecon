using System;

// Token: 0x020001CD RID: 461
public class CraftGuidePopup_Layout : LayoutDefinition
{
	// Token: 0x06000BF7 RID: 3063 RVA: 0x0003BB20 File Offset: 0x00039D20
	private void Awake()
	{
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x0003BB30 File Offset: 0x00039D30
	public CraftGuidePopup_Layout()
	{
		if (!true)
		{
		}
		base..ctor();
	}

	// Token: 0x04000FE3 RID: 4067
	public static CraftGuidePopup_Layout Instance;

	// Token: 0x04000FE4 RID: 4068
	public Panel_Layout Backing;

	// Token: 0x04000FE5 RID: 4069
	public Panel_Layout GridBacking;

	// Token: 0x04000FE6 RID: 4070
	public DraggableItemGrid_Layout CraftItems;

	// Token: 0x04000FE7 RID: 4071
	public float CraftItemScale;

	// Token: 0x04000FE8 RID: 4072
	public Panel_Layout MenuDivider;

	// Token: 0x04000FE9 RID: 4073
	public Panel_Layout MenuDivider2;

	// Token: 0x04000FEA RID: 4074
	public String_Layout ItemName;

	// Token: 0x04000FEB RID: 4075
	public Panel_Layout ItemNameDivider;

	// Token: 0x04000FEC RID: 4076
	public Panel_Layout Item;

	// Token: 0x04000FED RID: 4077
	public Panel_Layout ItemBacking;

	// Token: 0x04000FEE RID: 4078
	public TransactionButton_Layout Close;

	// Token: 0x04000FEF RID: 4079
	public TransactionButton_Layout Back;

	// Token: 0x04000FF0 RID: 4080
	public DraggableItemGrid_Layout MaterialsGrid;

	// Token: 0x04000FF1 RID: 4081
	public float MaterialItemScale;

	// Token: 0x04000FF2 RID: 4082
	public String_Layout RequiredObjects;

	// Token: 0x04000FF3 RID: 4083
	public String_Layout Required1;

	// Token: 0x04000FF4 RID: 4084
	public String_Layout Required2;

	// Token: 0x04000FF5 RID: 4085
	public String_Layout Text;

	// Token: 0x04000FF6 RID: 4086
	public Panel_Layout TextBacking;

	// Token: 0x04000FF7 RID: 4087
	public int MinTextHeight;

	// Token: 0x04000FF8 RID: 4088
	public int TextBackingOffset;

	// Token: 0x04000FF9 RID: 4089
	public int BackingTextPadding;

	// Token: 0x04000FFA RID: 4090
	public int BackingTextPaddingController;

	// Token: 0x04000FFB RID: 4091
	public int ExtraMaterialLineOffset;

	// Token: 0x04000FFC RID: 4092
	public int ControllerMaterialLineOffset;

	// Token: 0x04000FFD RID: 4093
	public int CraftItemOffset;
}
