using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000234 RID: 564
public class Reforge_Layout : PageControllerLayoutDefinition<Reforge_Layout>
{
	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000D03 RID: 3331 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		get
		{
			DraggableItemGrid_Layout draggableItemGrid_Layout;
			return draggableItemGrid_Layout;
		}
	}

	// Token: 0x06000D04 RID: 3332 RVA: 0x0003EA04 File Offset: 0x0003CC04
	public Reforge_Layout()
	{
		if (16928 == 0)
		{
		}
		this.DisabledBackingColor = 16928;
		base..ctor();
	}

	// Token: 0x04001701 RID: 5889
	public String_Layout Guide;

	// Token: 0x04001702 RID: 5890
	public String_Layout Cost;

	// Token: 0x04001703 RID: 5891
	public String_Layout ControllerCost;

	// Token: 0x04001704 RID: 5892
	public Panel_Layout SavingsBacking;

	// Token: 0x04001705 RID: 5893
	public String_Layout Savings;

	// Token: 0x04001706 RID: 5894
	public String_Layout SavingsTitle;

	// Token: 0x04001707 RID: 5895
	public Vector2 Savings1IconOffset = 17008;

	// Token: 0x04001708 RID: 5896
	public Vector2 Savings2IconOffset = 16968;

	// Token: 0x04001709 RID: 5897
	public Vector2 Savings3IconOffset = 16968;

	// Token: 0x0400170A RID: 5898
	public Vector2 Savings4IconOffset = 16928;

	// Token: 0x0400170B RID: 5899
	public String_Layout Title;

	// Token: 0x0400170C RID: 5900
	public float ItemScale;

	// Token: 0x0400170D RID: 5901
	public float ItemHighlightScale;

	// Token: 0x0400170E RID: 5902
	public bool DrawEmptySlots = true;

	// Token: 0x0400170F RID: 5903
	public Texture_Layout DisabledBacking;

	// Token: 0x04001710 RID: 5904
	public Color DisabledBackingColor;

	// Token: 0x04001711 RID: 5905
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x04001712 RID: 5906
	public Color DisabledBackingIconColor;

	// Token: 0x04001713 RID: 5907
	public DraggableItemGrid_Layout HorizontalReforgeItemGrid;

	// Token: 0x04001714 RID: 5908
	public DraggableItemGrid_Layout HorizontalReforgeItemGridCollapsed;

	// Token: 0x04001715 RID: 5909
	public DraggableItemGrid_Layout ReforgeItemGrid;

	// Token: 0x04001716 RID: 5910
	public DraggableItemGrid_Layout ReforgeItemGridCollapsed;

	// Token: 0x04001717 RID: 5911
	public TransactionButton_Layout ReforgeButton;
}
