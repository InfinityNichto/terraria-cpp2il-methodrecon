using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001CE RID: 462
public class CraftGuide_Layout : PageControllerLayoutDefinition<CraftGuide_Layout>
{
	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0003BB48 File Offset: 0x00039D48
	public DraggableItemGrid_Layout DisplayGrid
	{
		get
		{
			DraggableItemGrid_Layout draggableItemGrid_Layout;
			return draggableItemGrid_Layout;
		}
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0003BB58 File Offset: 0x00039D58
	public CraftGuide_Layout()
	{
		if (16192 == 0)
		{
		}
		this.DisabledBackingColor = 16192;
		base..ctor();
	}

	// Token: 0x04000FFE RID: 4094
	public String_Layout Title;

	// Token: 0x04000FFF RID: 4095
	public float CraftItemScale;

	// Token: 0x04001000 RID: 4096
	public float CraftItemHighlightScale;

	// Token: 0x04001001 RID: 4097
	public DraggableItemGrid_Layout CraftItemGrid;

	// Token: 0x04001002 RID: 4098
	public DraggableItemGrid_Layout CraftItemGridCollapsed;

	// Token: 0x04001003 RID: 4099
	public DraggableItemGrid_Layout HorizontalCraftItemGrid;

	// Token: 0x04001004 RID: 4100
	public DraggableItemGrid_Layout HorizontalCraftItemGridCollapsed;

	// Token: 0x04001005 RID: 4101
	public Button_Layout SelectedCraftItem;

	// Token: 0x04001006 RID: 4102
	public float MaterialItemScale = (float)16192;

	// Token: 0x04001007 RID: 4103
	public ItemGrid_Layout MaterialsGrid;

	// Token: 0x04001008 RID: 4104
	public ItemGrid_Layout MaterialsGridController;

	// Token: 0x04001009 RID: 4105
	public String_Layout CraftItemName;

	// Token: 0x0400100A RID: 4106
	public String_Layout CraftItemName2;

	// Token: 0x0400100B RID: 4107
	public String_Layout CraftItemNameController;

	// Token: 0x0400100C RID: 4108
	public String_Layout CraftItemName2Controller;

	// Token: 0x0400100D RID: 4109
	public String_Layout MaterialsTitle;

	// Token: 0x0400100E RID: 4110
	public String_Layout RequiredObjects;

	// Token: 0x0400100F RID: 4111
	public String_Layout Required1;

	// Token: 0x04001010 RID: 4112
	public String_Layout Required2;

	// Token: 0x04001011 RID: 4113
	public String_Layout RequiredObjectsController;

	// Token: 0x04001012 RID: 4114
	public String_Layout Required1Controller;

	// Token: 0x04001013 RID: 4115
	public String_Layout Required2Controller;

	// Token: 0x04001014 RID: 4116
	public bool ReverseScroll;

	// Token: 0x04001015 RID: 4117
	public bool DrawEmptySlots = true;

	// Token: 0x04001016 RID: 4118
	public Texture_Layout DisabledBacking;

	// Token: 0x04001017 RID: 4119
	public Color DisabledBackingColor;

	// Token: 0x04001018 RID: 4120
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04001019 RID: 4121
	public Color DisabledBackingIconColor;

	// Token: 0x0400101A RID: 4122
	public TransactionButton_Layout GuideButton;
}
