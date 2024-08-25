using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000101 RID: 257
public static class GUIAnimatedTexture
{
	// Token: 0x060006A1 RID: 1697 RVA: 0x00015614 File Offset: 0x00013814
	public static void Draw(AnimatedTexture_Layout layout, float animationScale)
	{
		int numXFrames = layout.NumXFrames;
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 location = layout.Location;
		float x = layout.Location.X;
		float y = layout.Location.Y;
		if (32640 == 0)
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
		if (layout.Texture.Texture != null)
		{
			Color color = layout.Color;
			int numXFrames2 = layout.NumXFrames;
		}
	}
}
