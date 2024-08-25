using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000113 RID: 275
public static class GUIProgressBar
{
	// Token: 0x060006E7 RID: 1767 RVA: 0x0001749C File Offset: 0x0001569C
	public static void Draw(ProgressBar_Layout layout, float value)
	{
		ControlAnchor.ControlId anchorControl = layout.AnchorControl;
		Vector2 location = layout.Location;
		float x = layout.Location.X;
		float y = layout.Location.Y;
		if (!true)
		{
		}
		float x2 = layout.FillingLocation.X;
		float y2 = layout.FillingLocation.Y;
		float backingScale = layout.BackingScale;
		if (!true)
		{
		}
		float x3 = layout.FillingSize.X;
		float y3 = layout.FillingSize.Y;
		float backingScale2 = layout.BackingScale;
		Texture2D texture = layout.Backing.Texture;
		int width = texture.Width;
		int height = texture.Height;
		float backingScale3 = layout.BackingScale;
		Color fillingColor = layout.FillingColor;
		if (32768 == 0)
		{
		}
		Color fillingColorEmpty = layout.FillingColorEmpty;
		int width2 = texture.Width;
		int arraySize = texture.ArraySize;
		float backingScale4 = layout.BackingScale;
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x0001758C File Offset: 0x0001578C
	private static void DrawFilling2(SpriteBatch spritebatch, Vector2 topLeft, int height, int completedWidth, int totalWidth, Color filled, Color separator, Color empty)
	{
		if (!true)
		{
		}
	}
}
