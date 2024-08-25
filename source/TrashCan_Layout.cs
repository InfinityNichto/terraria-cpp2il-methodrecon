using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000243 RID: 579
public class TrashCan_Layout : PageControllerLayoutDefinition<TrashCan_Layout>
{
	// Token: 0x06000D2D RID: 3373 RVA: 0x0003F0C8 File Offset: 0x0003D2C8
	public TrashCan_Layout()
	{
	}

	// Token: 0x0400180A RID: 6154
	public float ItemScale = (float)16192;

	// Token: 0x0400180B RID: 6155
	public ItemGrid_Layout TrashGrid;

	// Token: 0x0400180C RID: 6156
	public float ItemHighlightScale = (float)39322;

	// Token: 0x0400180D RID: 6157
	public Color BackingColour = 16192;
}
