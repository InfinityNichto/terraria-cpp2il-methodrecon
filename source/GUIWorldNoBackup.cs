using System;
using Terraria;

// Token: 0x02000289 RID: 649
public class GUIWorldNoBackup
{
	// Token: 0x06000EF5 RID: 3829 RVA: 0x0004A8EC File Offset: 0x00048AEC
	public void Open()
	{
		if (!true)
		{
		}
		Main.menuMode = 201;
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x0004A908 File Offset: 0x00048B08
	public void Draw()
	{
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			Main.menuMode = 6;
		}
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x0004A924 File Offset: 0x00048B24
	public GUIWorldNoBackup()
	{
	}

	// Token: 0x04001B1A RID: 6938
	private float statusScale;

	// Token: 0x04001B1B RID: 6939
	private float descriptionScale;

	// Token: 0x04001B1C RID: 6940
	private float backScale = (float)16256;
}
