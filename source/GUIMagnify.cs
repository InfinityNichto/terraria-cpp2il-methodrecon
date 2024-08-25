using System;
using Terraria;

// Token: 0x02000154 RID: 340
public class GUIMagnify
{
	// Token: 0x0600094E RID: 2382 RVA: 0x00028AC4 File Offset: 0x00026CC4
	public void Draw()
	{
		bool enableMagnify = this.EnableMagnify;
		if (enableMagnify)
		{
			if (!enableMagnify)
			{
			}
			bool gameMenu = Main.gameMenu;
			if (!enableMagnify)
			{
			}
			bool mapFullscreen = Main.mapFullscreen;
			int myPlayer = Main.myPlayer;
		}
		if (false)
		{
		}
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00028BB0 File Offset: 0x00026DB0
	public GUIMagnify()
	{
	}

	// Token: 0x040008F7 RID: 2295
	public bool EnableMagnify = true;
}
