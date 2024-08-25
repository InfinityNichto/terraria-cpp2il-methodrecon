using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000142 RID: 322
public class GUIEvents
{
	// Token: 0x060008AC RID: 2220 RVA: 0x00024098 File Offset: 0x00022298
	public void DrawInvasionInfo(Color panel, string title, string waveProgressString, Texture2D icon, float progressScale)
	{
		Events_Layout instance = Events_Layout.Instance;
		Color color = instance.Backing.BackingColor * progressScale;
		TransactionButton_Layout invasionIcon = instance.InvasionIcon;
		int num = 1;
		Color color2 = instance.InvasionTitle.Color;
		if (num == 0)
		{
		}
		float num2;
		Color color3 = color2 * num2;
		String_Layout progress = instance.Progress;
		string text2;
		string text = text2 + "%";
		String_Layout progress2 = instance.Progress;
		Color color4 = progress2.Color;
		if (progress2 == null)
		{
		}
		Color color5 = color4 * num2;
		if ("1" == null)
		{
		}
		String_Layout waves = instance.Waves;
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0002414C File Offset: 0x0002234C
	private void DrawProgressBar(float progress)
	{
		Events_Layout instance = Events_Layout.Instance;
		Color color = instance.BarBacking.BackingColor * progress;
		Color color2 = instance.BarBacking.BorderColor * progress;
		Rectangle rectangle = GUIPanel.Region(instance.BarBacking);
		Panel_Layout barFill = instance.BarFill;
		Color backingColor = barFill.BackingColor;
		Color highlightColor = barFill.HighlightColor;
		Color color3 = backingColor * progress;
		barFill.BackingColor = color3;
		Panel_Layout barFill2 = instance.BarFill;
		Color color4 = barFill2.BorderColor * progress;
		barFill2.BorderColor = color4;
		GUIPanel.DrawHorizontalFill(instance.BarFill, rectangle, progress);
		instance.BarFill.BackingColor = backingColor;
		instance.BarFill.BorderColor = highlightColor;
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00024208 File Offset: 0x00022408
	private void DrawInfiniteProgressBar()
	{
		Events_Layout instance = Events_Layout.Instance;
		Color backingColor = instance.InfiniteBarBacking.BackingColor;
		if (!true)
		{
		}
		Color borderColor = instance.InfiniteBarBacking.BorderColor;
		Rectangle rectangle = GUIPanel.Region(instance.InfiniteBarBacking);
		Panel_Layout infiniteBarFill = instance.InfiniteBarFill;
		Color backingColor2 = infiniteBarFill.BackingColor;
		Color highlightColor = infiniteBarFill.HighlightColor;
		Color color;
		infiniteBarFill.BackingColor = color;
		Panel_Layout infiniteBarFill2 = instance.InfiniteBarFill;
		Color borderColor2 = infiniteBarFill2.BorderColor;
		Color color2;
		infiniteBarFill2.BorderColor = color2;
		Panel_Layout infiniteBarFill3 = instance.InfiniteBarFill;
		instance.InfiniteBarFill.BackingColor = backingColor2;
		instance.InfiniteBarFill.BorderColor = highlightColor;
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x000242A8 File Offset: 0x000224A8
	public GUIEvents()
	{
	}

	// Token: 0x0400077A RID: 1914
	private float testProgress;
}
