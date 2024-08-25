using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000111 RID: 273
public static class GUIPanel
{
	// Token: 0x060006DD RID: 1757 RVA: 0x00017138 File Offset: 0x00015338
	public static bool IsCursorOver(Vector2 cursorUIPosition, Panel_Layout layout)
	{
		if (!true)
		{
		}
		if (true)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}
		if (!true)
		{
		}
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00017164 File Offset: 0x00015364
	public static bool RegisterPickingRegion(Panel_Layout layout)
	{
		if (!true)
		{
		}
		if (true)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}
		if (!true)
		{
		}
		bool flag;
		return flag;
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x0001718C File Offset: 0x0001538C
	public static Rectangle Region(Panel_Layout layout)
	{
		if (!true)
		{
		}
		if (true)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}
		if (!true)
		{
			return;
		}
	}

	// Token: 0x060006E0 RID: 1760 RVA: 0x000171B0 File Offset: 0x000153B0
	public static void Draw(Panel_Layout layout, bool cursorOver = false, [Optional] Color? overloadBacking, [Optional] Color? overloadBorder, [Optional] Color? overloadHighlight)
	{
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 location = layout.Location;
		float x = layout.Location.X;
		float y = layout.Location.Y;
		if (!true)
		{
		}
		bool anchorForSize = layout.AnchorForSize;
		if (anchorForSize)
		{
			ControlAnchor.ControlId sizeAnchorControl = layout.SizeAnchorControl;
			Vector2 sizeLocation = layout.SizeLocation;
			float x2 = layout.SizeLocation.X;
			float y2 = layout.SizeLocation.Y;
			if (!anchorForSize)
			{
			}
			if (!anchorForSize)
			{
			}
			return;
		}
		float x3 = layout.Size.X;
		float y3 = layout.Size.Y;
		if (!anchorForSize)
		{
		}
		Texture2D texture = layout.Backing.Texture;
		Texture_Layout border = layout.Border;
		Texture2D texture2 = border.Texture;
		if (texture != null)
		{
			return;
		}
		if (texture2 != null)
		{
			if (border != null)
			{
				return;
			}
			Color borderColor = layout.BorderColor;
		}
		if (layout.CursorHighlight.Texture != null)
		{
			if (border != null)
			{
				return;
			}
			Color highlightColor = layout.HighlightColor;
		}
	}

	// Token: 0x060006E1 RID: 1761 RVA: 0x000172A4 File Offset: 0x000154A4
	public static void DrawAtPosition(Panel_Layout layout, Vector2 position, Vector2 size, bool cursorOver = false)
	{
		Texture2D texture = layout.Backing.Texture;
		Texture2D texture2 = layout.Border.Texture;
		if (texture != null)
		{
			Color backingColor = layout.BackingColor;
		}
		if (texture2 != null)
		{
			Color borderColor = layout.BorderColor;
		}
		if (layout.CursorHighlight.Texture != null)
		{
			Color highlightColor = layout.HighlightColor;
		}
	}

	// Token: 0x060006E2 RID: 1762 RVA: 0x000172F4 File Offset: 0x000154F4
	public static void DrawHorizontalFill(Panel_Layout layout, Rectangle backgroundFillRegion, float fillScale)
	{
		Texture2D texture2D;
		if (texture2D != null)
		{
			if (32640 == 0)
			{
			}
			if (32768 == 0)
			{
			}
			Vector2 vector = backgroundFillRegion.TopLeft();
			Vector2 vector2 = backgroundFillRegion.Size();
			SpriteBatchItem.DisabledClipping();
		}
		Texture2D texture2D2;
		if (texture2D2 != null)
		{
			Vector2 vector3 = backgroundFillRegion.TopLeft();
			Vector2 vector4 = backgroundFillRegion.Size();
		}
	}

	// Token: 0x060006E3 RID: 1763 RVA: 0x0001733C File Offset: 0x0001553C
	public static void DrawBacking(Vector2 position, Vector2 size, Texture2D texture, Color color, [Optional] Rectangle? sourceFrame)
	{
		if (position != null)
		{
			return;
		}
	}

	// Token: 0x04000566 RID: 1382
	public static bool forceRescale;

	// Token: 0x04000567 RID: 1383
	public static bool scaleEdges;
}
