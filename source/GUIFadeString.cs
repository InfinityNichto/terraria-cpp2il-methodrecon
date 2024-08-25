using System;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200010B RID: 267
public static class GUIFadeString
{
	// Token: 0x060006C2 RID: 1730 RVA: 0x00016A40 File Offset: 0x00014C40
	public static void Draw(String_Layout layout, string text, float timeVisible, float fadeDelay = -1f, float fadeTime = -1f)
	{
		Color color = layout.Color * timeVisible;
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00016A5C File Offset: 0x00014C5C
	public static void Draw(String_Layout layout, StringBuilder value, float timeVisible, float fadeDelay = -1f, float fadeTime = -1f)
	{
		Color color = layout.Color * timeVisible;
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00016A78 File Offset: 0x00014C78
	public static void Draw(FadeString_Layout layout, StringBuilder value, float timeVisible)
	{
		float fadeDelay = layout.FadeDelay;
		float fadeTime = layout.FadeTime;
		Color color = layout.Color * timeVisible;
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00016AA4 File Offset: 0x00014CA4
	public static void Draw(FadeString_Layout layout, string text, float timeVisible)
	{
		float fadeDelay = layout.FadeDelay;
		float fadeTime = layout.FadeTime;
		Color color = layout.Color * timeVisible;
	}
}
