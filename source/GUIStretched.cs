using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000119 RID: 281
public static class GUIStretched
{
	// Token: 0x0600070D RID: 1805 RVA: 0x000189C8 File Offset: 0x00016BC8
	public static void Draw(Stretched_Layout layout, [Optional] Rectangle? region, [Optional] Color? overloadedColour)
	{
		float size = layout.Size;
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 location = layout.Location;
		float x = layout.Location.X;
		float y = layout.Location.Y;
		if (!true)
		{
		}
		if (layout.Vertical)
		{
			return;
		}
		Texture2D texture = layout.Backing.Texture;
		int width = texture.Width;
		int height = texture.Height;
		float scale = layout.Scale;
	}
}
