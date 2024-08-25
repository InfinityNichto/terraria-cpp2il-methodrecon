using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000108 RID: 264
public static class GUIDPad
{
	// Token: 0x060006B6 RID: 1718 RVA: 0x00016054 File Offset: 0x00014254
	public static void Draw(DPad_Layout layout, Texture2D arrow)
	{
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 centreLocation = layout.CentreLocation;
		float x = layout.CentreLocation.X;
		float y = layout.CentreLocation.Y;
		if (!true)
		{
		}
		int width = arrow.Width;
		int height = arrow.Height;
		float scale = layout.Scale;
		if (!true)
		{
		}
		if (!true)
		{
		}
		float x2 = layout.RightOffset.X;
		float y2 = layout.RightOffset.Y;
		Color color = layout.Color;
		float scale2 = layout.Scale;
		float x3 = layout.BottomOffset.X;
		float y3 = layout.BottomOffset.Y;
		Color color2 = layout.Color;
		float scale3 = layout.Scale;
		float x4 = layout.LeftOffset.X;
		float y4 = layout.LeftOffset.Y;
		Color color3 = layout.Color;
		float scale4 = layout.Scale;
		float x5 = layout.TopOffset.X;
		float y5 = layout.TopOffset.Y;
		Color color4 = layout.Color;
		float scale5 = layout.Scale;
		float x6 = layout.PickSize.X;
		float y6 = layout.PickSize.Y;
		float x7 = layout.PickSize.X;
		float y7 = layout.PickSize.Y;
		float x8 = layout.DeadZone.X;
		float y8 = layout.DeadZone.Y;
		float x9 = layout.PickSize.X;
		float y9 = layout.PickSize.Y;
		float x10 = layout.DeadZone.X;
		float y10 = layout.DeadZone.Y;
		float x11 = layout.PickSize.X;
		float y11 = layout.PickSize.Y;
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x0001621C File Offset: 0x0001441C
	public static bool IsCursorOver(Vector2 position, DPad_Layout layout, [Out] bool left, [Out] bool right, [Out] bool up, [Out] bool down)
	{
		if (!true)
		{
		}
		position.X = (float)1;
		return true;
	}
}
