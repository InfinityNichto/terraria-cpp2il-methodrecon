using System;
using Terraria;

// Token: 0x0200025A RID: 602
public class GUIDeletePlayer
{
	// Token: 0x06000D71 RID: 3441 RVA: 0x00040228 File Offset: 0x0003E428
	public void Draw()
	{
		if (!true)
		{
		}
		GUIControllerModalResponse controller = this._controller;
		this._controller.Activate();
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00040264 File Offset: 0x0003E464
	private void Delete()
	{
		if (!true)
		{
		}
		Main.ErasePlayer(int.MinValue);
		Main.menuMode = 1;
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00040288 File Offset: 0x0003E488
	private void Back()
	{
		if (!true)
		{
		}
		Main.menuMode = 1;
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x000402A0 File Offset: 0x0003E4A0
	public GUIDeletePlayer()
	{
	}

	// Token: 0x040018E1 RID: 6369
	private float scale0;

	// Token: 0x040018E2 RID: 6370
	private float scale1;

	// Token: 0x040018E3 RID: 6371
	private float scale2;

	// Token: 0x040018E4 RID: 6372
	private float titleScale = (float)16256;

	// Token: 0x040018E5 RID: 6373
	private GUIControllerModalResponse _controller;
}
