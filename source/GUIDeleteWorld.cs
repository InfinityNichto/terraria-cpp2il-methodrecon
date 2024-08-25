using System;
using Terraria;

// Token: 0x0200025B RID: 603
public class GUIDeleteWorld
{
	// Token: 0x06000D75 RID: 3445 RVA: 0x000402C0 File Offset: 0x0003E4C0
	public void Draw()
	{
		if (!true)
		{
		}
		GUIControllerModalResponse controller = this._controller;
		this._controller.Activate();
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x000402F0 File Offset: 0x0003E4F0
	private void Delete()
	{
		if (!true)
		{
		}
		Main.EraseWorld(int.MinValue);
		Main.menuMode = 6;
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00040314 File Offset: 0x0003E514
	private void Back()
	{
		if (!true)
		{
		}
		Main.menuMode = 6;
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x0004032C File Offset: 0x0003E52C
	public GUIDeleteWorld()
	{
	}

	// Token: 0x040018E6 RID: 6374
	private float scale0;

	// Token: 0x040018E7 RID: 6375
	private float scale1;

	// Token: 0x040018E8 RID: 6376
	private float scale2;

	// Token: 0x040018E9 RID: 6377
	private float titleScale = (float)16256;

	// Token: 0x040018EA RID: 6378
	private GUIControllerModalResponse _controller;
}
