using System;
using Terraria;

// Token: 0x0200025C RID: 604
public class GUIErrorScreen
{
	// Token: 0x06000D79 RID: 3449 RVA: 0x0004034C File Offset: 0x0003E54C
	public void Draw()
	{
		int num = 1;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (num == 0)
			{
			}
			if (num == 0 || num != 0)
			{
			}
			Main.menuMode = 0;
		}
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00040374 File Offset: 0x0003E574
	public GUIErrorScreen()
	{
	}

	// Token: 0x040018EB RID: 6379
	private float scale0;

	// Token: 0x040018EC RID: 6380
	private float scale1;

	// Token: 0x040018ED RID: 6381
	private float scale2;
}
