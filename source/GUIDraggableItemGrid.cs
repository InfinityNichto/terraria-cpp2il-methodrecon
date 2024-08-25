using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using UnityEngine;

// Token: 0x02000109 RID: 265
public static class GUIDraggableItemGrid
{
	// Token: 0x060006B8 RID: 1720 RVA: 0x00016248 File Offset: 0x00014448
	private static void SetSizeClippedDrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		GUIDraggableItemGrid.ClippedDrawItemHandler(gridLayout, itemIndex, position, scale);
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00016268 File Offset: 0x00014468
	private static void ClippedDrawItemHandler(ItemGrid_Layout gridLayout, int itemIndex, Microsoft.Xna.Framework.Vector2 position, float scale)
	{
		if (!true)
		{
		}
		float x = gridLayout.PickingBorder.X;
		float y = gridLayout.PickingBorder.Y;
		float x2 = gridLayout.PickingOffset.X;
		float y2 = gridLayout.PickingOffset.Y;
		int num = 32640;
		int num2 = 32768;
		int value = num.m_value;
		if (num2 == 0)
		{
		}
		if (num == 0)
		{
		}
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x000162F4 File Offset: 0x000144F4
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, float scrollOffset, float momentum, int draggingState, Microsoft.Xna.Framework.Vector2 dragPosition, [Optional] Microsoft.Xna.Framework.Graphics.Texture2D overloadBackingTexture, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		if (!true)
		{
		}
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x0001630C File Offset: 0x0001450C
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, float scrollOffset, float momentum, int draggingState, Microsoft.Xna.Framework.Vector2 dragPosition, Microsoft.Xna.Framework.Vector2 itemSize, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
		IntPtr invoke_impl = scaleHandler.invoke_impl;
		IntPtr method_code = scaleHandler.method_code;
		IntPtr method = scaleHandler.method;
		if (invoke_impl == 0)
		{
		}
		if (!gridLayout.ExplicitDragRegionSize)
		{
			int itemCount2 = gridLayout.ItemCount;
			int itemCount3;
			if (itemCount3 == 0)
			{
			}
			if (itemCount3 == 0)
			{
			}
			Rectangle rectangle;
			itemCount3.m_value = rectangle;
			float y = gridLayout.MaxDragRegion.Y;
			if (itemCount3 == 0)
			{
				float y2 = gridLayout.MaxDragRegion.Y;
			}
			float x = gridLayout.MaxDragRegion.X;
			if (itemCount3 == 0)
			{
				float x2 = gridLayout.MaxDragRegion.X;
			}
			bool dragHorizontal = gridLayout.DragHorizontal;
			while (!dragHorizontal)
			{
			}
			if (!dragHorizontal)
			{
			}
			int alphaFalloff = gridLayout.AlphaFalloff;
			if (gridLayout.FirstItemAnchor == (LayoutCalculator.AnchorType)0)
			{
			}
			int alphaFalloff2 = gridLayout.AlphaFalloff;
			return;
		}
		ControlAnchor.ControlId firstAnchorControl = gridLayout.FirstAnchorControl;
		Microsoft.Xna.Framework.Vector2 firstItemLocation = gridLayout.FirstItemLocation;
		float x3 = gridLayout.FirstItemLocation.X;
		float y3 = gridLayout.FirstItemLocation.Y;
		float x4 = gridLayout.DragRegionEndItemLocation.X;
		float y4 = gridLayout.DragRegionEndItemLocation.Y;
		ControlAnchor.ControlId dragRegionEndAnchorControl = gridLayout.DragRegionEndAnchorControl;
		Microsoft.Xna.Framework.Vector2 dragRegionEndItemLocation = gridLayout.DragRegionEndItemLocation;
		if (gridLayout.DragHorizontal)
		{
			if (gridLayout.Horizontal)
			{
				int itemCount3 = gridLayout.ItemCount;
				Microsoft.Xna.Framework.Vector2 pickingBorder = gridLayout.PickingBorder;
				return;
			}
			int itemLineCount = gridLayout.ItemLineCount;
			int itemCount4 = gridLayout.ItemCount;
			return;
		}
		else
		{
			int itemLineCount2 = gridLayout.ItemLineCount;
			int itemCount5 = gridLayout.ItemCount;
			bool explicitDragRegionSize = gridLayout.ExplicitDragRegionSize;
			if (!explicitDragRegionSize)
			{
				int itemCount6 = gridLayout.ItemCount;
				return;
			}
			if (explicitDragRegionSize)
			{
				return;
			}
			int itemLineCount3 = gridLayout.ItemLineCount;
			bool dragHorizontal2 = gridLayout.DragHorizontal;
			float y5 = gridLayout.ExtraElementSpacing.Y;
			if (itemLineCount3 == 0)
			{
			}
			if (dragHorizontal2)
			{
				int alphaFalloff3 = gridLayout.AlphaFalloff;
				int alphaFalloff4 = gridLayout.AlphaFalloff;
				return;
			}
			int alphaFalloff5 = gridLayout.AlphaFalloff;
			int alphaFalloff6 = gridLayout.AlphaFalloff;
			if (gridLayout.ExplicitDragRegionSize)
			{
				bool dragHorizontal3 = gridLayout.DragHorizontal;
				if (!dragHorizontal3)
				{
					if (!dragHorizontal3)
					{
					}
					int dragRegionTopOffset = gridLayout.DragRegionTopOffset;
					int dragRegionTopOffset2 = gridLayout.DragRegionTopOffset;
					int dragRegionBottomOffset = gridLayout.DragRegionBottomOffset;
				}
			}
			float momentumDampen = gridLayout.MomentumDampen;
			float mouseScrollDelta = XNAUnityRunner.GetMouseScrollDelta(false);
			return;
		}
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00016698 File Offset: 0x00014898
	public static void Draw(DraggableItemGrid_Layout gridLayout, GUIItemGrid.GetItemScaleHandler scaleHandler, GUIItemGrid.CursorOver cursorOverHandler, GUIItemGrid.DrawItemHandler drawhandler, int itemCount, float scrollOffset, float momentum, int draggingState, Microsoft.Xna.Framework.Vector2 dragPosition, GUIItemGrid.GetItemSizeHandler itemSizeHandler, bool drawMissingItems = false, bool allowMouseScroll = false, bool disableDragScroll = false)
	{
		IntPtr invoke_impl = scaleHandler.invoke_impl;
		IntPtr method_code = scaleHandler.method_code;
		IntPtr method = scaleHandler.method;
		if (gridLayout.ExplicitDragRegionSize)
		{
			ControlAnchor.ControlId firstAnchorControl = gridLayout.FirstAnchorControl;
			Microsoft.Xna.Framework.Vector2 firstItemLocation = gridLayout.FirstItemLocation;
			float x = gridLayout.FirstItemLocation.X;
			float y = gridLayout.FirstItemLocation.Y;
			float x2 = gridLayout.DragRegionEndItemLocation.X;
			float y2 = gridLayout.DragRegionEndItemLocation.Y;
			ControlAnchor.ControlId dragRegionEndAnchorControl = gridLayout.DragRegionEndAnchorControl;
			Microsoft.Xna.Framework.Vector2 dragRegionEndItemLocation = gridLayout.DragRegionEndItemLocation;
			return;
		}
		Debug.LogError("Not supported!!");
		bool dragHorizontal = gridLayout.DragHorizontal;
		if (dragHorizontal)
		{
			if (!dragHorizontal)
			{
			}
			Debug.LogError("Not supported!!");
			return;
		}
		bool explicitDragRegionSize = gridLayout.ExplicitDragRegionSize;
		while (!explicitDragRegionSize)
		{
		}
		if (!explicitDragRegionSize)
		{
		}
		float y3 = gridLayout.ExtraElementSpacing.Y;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00016998 File Offset: 0x00014B98
	// Note: this type is marked as 'beforefieldinit'.
	static GUIDraggableItemGrid()
	{
	}

	// Token: 0x04000555 RID: 1365
	public static Rectangle dragRegion;

	// Token: 0x04000556 RID: 1366
	public static Rectangle fullRegion;

	// Token: 0x04000557 RID: 1367
	private static Microsoft.Xna.Framework.Vector2 drawOffset;

	// Token: 0x04000558 RID: 1368
	private static float itemWidth;

	// Token: 0x04000559 RID: 1369
	private static float itemHeight;

	// Token: 0x0400055A RID: 1370
	private static float orgScrollOffset;

	// Token: 0x0400055B RID: 1371
	private static GUIItemGrid.CursorOver _overHandler;

	// Token: 0x0400055C RID: 1372
	private static GUIItemGrid.DrawItemHandler _drawhandler;

	// Token: 0x0400055D RID: 1373
	private static GUIItemGrid.GetItemSizeHandler _sizehandler;

	// Token: 0x0400055E RID: 1374
	private static GUIItemGrid.DrawItemHandler SetSizeClippedDrawItem;

	// Token: 0x0400055F RID: 1375
	private static GUIItemGrid.DrawItemHandler ClippedDrawItem;

	// Token: 0x0200010A RID: 266
	public sealed class DrawItemClippedHandler : MulticastDelegate
	{
		// Token: 0x060006BE RID: 1726 RVA: 0x000169AC File Offset: 0x00014BAC
		public DrawItemClippedHandler(object @object, IntPtr method)
		{
			this.method_ptr = method;
			this.m_target = @object;
			this.method = method;
			this.method_code = this;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00016A0C File Offset: 0x00014C0C
		public void Invoke(ItemGrid_Layout gridLayout, int itemIndex, Microsoft.Xna.Framework.Vector2 position, float scale, Rectangle inner, Rectangle outer)
		{
			IntPtr method_code = this.method_code;
			IntPtr invoke_impl = this.invoke_impl;
			IntPtr method = this.method;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000021DB File Offset: 0x000003DB
		public IAsyncResult BeginInvoke(ItemGrid_Layout gridLayout, int itemIndex, Microsoft.Xna.Framework.Vector2 position, float scale, Rectangle inner, Rectangle outer, AsyncCallback callback, object @object)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00016A30 File Offset: 0x00014C30
		public void EndInvoke(IAsyncResult result)
		{
		}
	}
}
