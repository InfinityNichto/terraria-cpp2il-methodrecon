using System;
using Microsoft.Xna.Framework;

// Token: 0x020001AF RID: 431
[Serializable]
public class DraggableItemGrid_Layout : ItemGrid_Layout
{
	// Token: 0x06000BBB RID: 3003 RVA: 0x0003A824 File Offset: 0x00038A24
	public DraggableItemGrid_Layout()
	{
	}

	// Token: 0x04000E28 RID: 3624
	public float MomentumScale;

	// Token: 0x04000E29 RID: 3625
	public float MomentumDampen;

	// Token: 0x04000E2A RID: 3626
	public float MomentumExtraDampenOutOfBounds;

	// Token: 0x04000E2B RID: 3627
	public float OutOfBoundsOffsetLerpScale;

	// Token: 0x04000E2C RID: 3628
	public int AlphaFalloff = 10;

	// Token: 0x04000E2D RID: 3629
	public bool DragHorizontal = true;

	// Token: 0x04000E2E RID: 3630
	public float DragThreshold = (float)16672;

	// Token: 0x04000E2F RID: 3631
	public bool EnableDragUnderLimit;

	// Token: 0x04000E30 RID: 3632
	public Vector2 MaxDragRegion;

	// Token: 0x04000E31 RID: 3633
	public bool ExplicitDragRegionSize;

	// Token: 0x04000E32 RID: 3634
	public ControlAnchor.ControlId DragRegionEndAnchorControl;

	// Token: 0x04000E33 RID: 3635
	public LayoutCalculator.AnchorType DragRegionEndItemAnchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x04000E34 RID: 3636
	public Vector2 DragRegionEndItemLocation;

	// Token: 0x04000E35 RID: 3637
	public int DragRegionTopOffset;

	// Token: 0x04000E36 RID: 3638
	public int DragRegionBottomOffset;
}
