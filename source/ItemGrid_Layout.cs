using System;
using Microsoft.Xna.Framework;

// Token: 0x020001B1 RID: 433
[Serializable]
public class ItemGrid_Layout
{
	// Token: 0x06000BBD RID: 3005 RVA: 0x0003A870 File Offset: 0x00038A70
	public ItemGrid_Layout()
	{
	}

	// Token: 0x04000E39 RID: 3641
	public bool Horizontal = true;

	// Token: 0x04000E3A RID: 3642
	public ItemGrid_Layout.ReorderStyle Reorder;

	// Token: 0x04000E3B RID: 3643
	public int ItemCount;

	// Token: 0x04000E3C RID: 3644
	public int ItemLineCount;

	// Token: 0x04000E3D RID: 3645
	public Vector2 PickingBorder = 1;

	// Token: 0x04000E3E RID: 3646
	public Vector2 PickingOffset = 1;

	// Token: 0x04000E3F RID: 3647
	public Vector2 ExtraElementSpacing = 1;

	// Token: 0x04000E40 RID: 3648
	public ControlAnchor.ControlId FirstAnchorControl;

	// Token: 0x04000E41 RID: 3649
	public LayoutCalculator.AnchorType FirstItemAnchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x04000E42 RID: 3650
	public Vector2 FirstItemLocation = 1;

	// Token: 0x04000E43 RID: 3651
	public Vector2 StackCountOffset = 1;

	// Token: 0x04000E44 RID: 3652
	public Vector2 AmmoCountOffset = 1;

	// Token: 0x04000E45 RID: 3653
	public bool CentreAlign;

	// Token: 0x04000E46 RID: 3654
	public bool RightAlign;

	// Token: 0x020001B2 RID: 434
	public enum ReorderStyle
	{
		// Token: 0x04000E48 RID: 3656
		None,
		// Token: 0x04000E49 RID: 3657
		ReverseAllItems,
		// Token: 0x04000E4A RID: 3658
		ReverseLine,
		// Token: 0x04000E4B RID: 3659
		ReverseColumns,
		// Token: 0x04000E4C RID: 3660
		SwapColumns
	}
}
