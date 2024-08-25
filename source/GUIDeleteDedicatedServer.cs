using System;
using Terraria;
using Terraria.Localization;

// Token: 0x02000259 RID: 601
public class GUIDeleteDedicatedServer
{
	// Token: 0x06000D6D RID: 3437 RVA: 0x000401B4 File Offset: 0x0003E3B4
	public void Draw()
	{
		if (!true)
		{
		}
		if (!true)
		{
		}
		long num = 0L;
		string textValue = Language.GetTextValue("Mobile.RemoveServerList", num);
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x000401E4 File Offset: 0x0003E3E4
	private void Delete()
	{
		Main.menuMode = 446;
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x000401FC File Offset: 0x0003E3FC
	private void Back()
	{
		Main.menuMode = 446;
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x00040214 File Offset: 0x0003E414
	public GUIDeleteDedicatedServer()
	{
	}

	// Token: 0x040018DE RID: 6366
	private float scale0;

	// Token: 0x040018DF RID: 6367
	private float scale1;

	// Token: 0x040018E0 RID: 6368
	private float scale2;
}
