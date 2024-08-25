using System;
using Microsoft.Xna.Framework;

// Token: 0x02000197 RID: 407
public class CachedGridLayoutSettings
{
	// Token: 0x06000B5D RID: 2909 RVA: 0x00039444 File Offset: 0x00037644
	public bool Dirty(ItemGrid_Layout layout)
	{
		if (!true)
		{
		}
		bool horizontal = layout.Horizontal;
		bool horizontal2 = this.Horizontal;
		ItemGrid_Layout.ReorderStyle reorder = layout.Reorder;
		ItemGrid_Layout.ReorderStyle reorder2 = this.Reorder;
		int itemCount = layout.ItemCount;
		int itemCount2 = this.ItemCount;
		int itemLineCount = layout.ItemLineCount;
		int itemLineCount2 = this.ItemLineCount;
		float x = layout.PickingBorder.X;
		float y = layout.PickingBorder.Y;
		float x2 = this.PickingBorder.X;
		float y2 = this.PickingBorder.Y;
		if (itemLineCount2 == 0)
		{
		}
		float x3 = layout.PickingOffset.X;
		float y3 = layout.PickingOffset.Y;
		float x4 = this.PickingOffset.X;
		float y4 = this.PickingOffset.Y;
		float x5 = layout.ExtraElementSpacing.X;
		float y5 = layout.ExtraElementSpacing.Y;
		float x6 = this.ExtraElementSpacing.X;
		float y6 = this.ExtraElementSpacing.Y;
		ControlAnchor.ControlId firstAnchorControl = layout.FirstAnchorControl;
		ControlAnchor.ControlId firstAnchorControl2 = this.FirstAnchorControl;
		LayoutCalculator.AnchorType firstItemAnchor = layout.FirstItemAnchor;
		LayoutCalculator.AnchorType firstItemAnchor2 = this.FirstItemAnchor;
		float x7 = layout.FirstItemLocation.X;
		float y7 = layout.FirstItemLocation.Y;
		float x8 = this.FirstItemLocation.X;
		float y8 = this.FirstItemLocation.Y;
		if (firstItemAnchor == (LayoutCalculator.AnchorType)0)
		{
		}
		int screenWidth = this.ScreenWidth;
		int screenHeight = this.ScreenHeight;
		bool flag;
		return flag;
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x000395A8 File Offset: 0x000377A8
	public void Cache(ItemGrid_Layout layout)
	{
		bool horizontal = layout.Horizontal;
		this.Horizontal = horizontal;
		int itemLineCount = layout.ItemLineCount;
		this.ItemLineCount = itemLineCount;
		Vector2 pickingBorder = layout.PickingBorder;
		this.PickingBorder = pickingBorder;
		Vector2 pickingOffset = layout.PickingOffset;
		this.PickingOffset = pickingOffset;
		Vector2 extraElementSpacing = layout.ExtraElementSpacing;
		this.ExtraElementSpacing = extraElementSpacing;
		ControlAnchor.ControlId firstAnchorControl = layout.FirstAnchorControl;
		this.FirstAnchorControl = firstAnchorControl;
		Vector2 firstItemLocation = layout.FirstItemLocation;
		this.FirstItemLocation = firstItemLocation;
		if (firstItemLocation == null)
		{
		}
	}

	// Token: 0x06000B5F RID: 2911 RVA: 0x00039624 File Offset: 0x00037824
	public CachedGridLayoutSettings()
	{
	}

	// Token: 0x04000CB6 RID: 3254
	public bool Horizontal;

	// Token: 0x04000CB7 RID: 3255
	public ItemGrid_Layout.ReorderStyle Reorder;

	// Token: 0x04000CB8 RID: 3256
	public int ItemCount;

	// Token: 0x04000CB9 RID: 3257
	public int ItemLineCount;

	// Token: 0x04000CBA RID: 3258
	public Vector2 PickingBorder;

	// Token: 0x04000CBB RID: 3259
	public Vector2 PickingOffset;

	// Token: 0x04000CBC RID: 3260
	public Vector2 ExtraElementSpacing;

	// Token: 0x04000CBD RID: 3261
	public ControlAnchor.ControlId FirstAnchorControl;

	// Token: 0x04000CBE RID: 3262
	public LayoutCalculator.AnchorType FirstItemAnchor = LayoutCalculator.AnchorType.TopLeft;

	// Token: 0x04000CBF RID: 3263
	public Vector2 FirstItemLocation;

	// Token: 0x04000CC0 RID: 3264
	public int ScreenWidth;

	// Token: 0x04000CC1 RID: 3265
	public int ScreenHeight;
}
