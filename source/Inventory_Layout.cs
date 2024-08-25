using System;
using Microsoft.Xna.Framework;

// Token: 0x020001E0 RID: 480
[Serializable]
public class Inventory_Layout : PageControllerLayoutDefinition<Inventory_Layout>
{
	// Token: 0x06000C46 RID: 3142 RVA: 0x0003D2D8 File Offset: 0x0003B4D8
	public Inventory_Layout()
	{
	}

	// Token: 0x0400112D RID: 4397
	public String_Layout Title;

	// Token: 0x0400112E RID: 4398
	public float ItemScale;

	// Token: 0x0400112F RID: 4399
	public float ItemHighlightScale;

	// Token: 0x04001130 RID: 4400
	public float ScaleSpeed = (float)52429;

	// Token: 0x04001131 RID: 4401
	public ItemGrid_Layout HotbarGrid;

	// Token: 0x04001132 RID: 4402
	public ItemGrid_Layout HorizontalHotbarGrid;

	// Token: 0x04001133 RID: 4403
	public ItemGrid_Layout ItemGrid;

	// Token: 0x04001134 RID: 4404
	public ItemGrid_Layout HorizontalItemGrid;

	// Token: 0x04001135 RID: 4405
	public TransactionButton_Layout Favorite;

	// Token: 0x04001136 RID: 4406
	public FavoriteIcons FavoriteIcons;

	// Token: 0x04001137 RID: 4407
	public Vector2 BindingOffset;

	// Token: 0x04001138 RID: 4408
	public float BindingScale;
}
