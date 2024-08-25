using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000235 RID: 565
public class ResearchPage_Layout : PageControllerLayoutDefinition<ResearchPage_Layout>
{
	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0003EA5C File Offset: 0x0003CC5C
	public DraggableItemGrid_Layout DisplayItemGrid
	{
		get
		{
			DraggableItemGrid_Layout draggableItemGrid_Layout;
			return draggableItemGrid_Layout;
		}
	}

	// Token: 0x06000D06 RID: 3334 RVA: 0x0003EA6C File Offset: 0x0003CC6C
	public ResearchPage_Layout()
	{
		if (!true)
		{
		}
		this.DisabledBackingColor = 1;
		base..ctor();
	}

	// Token: 0x04001718 RID: 5912
	public String_Layout Title;

	// Token: 0x04001719 RID: 5913
	public float ItemScale;

	// Token: 0x0400171A RID: 5914
	public float ItemHighlightScale;

	// Token: 0x0400171B RID: 5915
	public bool DrawEmptySlots = true;

	// Token: 0x0400171C RID: 5916
	public Texture_Layout DisabledBacking;

	// Token: 0x0400171D RID: 5917
	public Color DisabledBackingColor;

	// Token: 0x0400171E RID: 5918
	public Texture_Layout DisabledBackingIcon;

	// Token: 0x0400171F RID: 5919
	public Color DisabledBackingIconColor;

	// Token: 0x04001720 RID: 5920
	public DraggableItemGrid_Layout ResearchItemGrid;

	// Token: 0x04001721 RID: 5921
	public DraggableItemGrid_Layout ResearchItemGridCollapsed;

	// Token: 0x04001722 RID: 5922
	public DraggableItemGrid_Layout ResearchItemGrid_Horizontal;

	// Token: 0x04001723 RID: 5923
	public DraggableItemGrid_Layout ResearchItemGridCollapsed_Horizontal;

	// Token: 0x04001724 RID: 5924
	public TransactionButton_Layout ResearchButton;
}
