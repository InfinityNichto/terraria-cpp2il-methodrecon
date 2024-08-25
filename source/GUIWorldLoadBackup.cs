using System;
using Terraria;
using Terraria.Utilities;

// Token: 0x02000287 RID: 647
public class GUIWorldLoadBackup
{
	// Token: 0x06000EF0 RID: 3824 RVA: 0x0004A7B0 File Offset: 0x000489B0
	public void Open()
	{
		if (!true)
		{
		}
		Main.menuMode = 200;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0004A7CC File Offset: 0x000489CC
	public void Draw()
	{
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			GUITransactionButton.InputState inputState2;
			if (inputState2 == GUITransactionButton.InputState.Clicked)
			{
				Main.menuMode = 6;
			}
			return;
		}
		string text = Main.worldPathName + ".bak";
		string worldPathName = Main.worldPathName;
		long num = 0L;
		string text2 = worldPathName + ".bak";
		string worldPathName2 = Main.worldPathName;
		int num2 = 1;
		FileUtilities.Move(text2, worldPathName2, num != 0L, num2 != 0);
		if (text2 != null)
		{
			return;
		}
		Main.menuMode = 10;
		WorldGen.playWorld();
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0004A858 File Offset: 0x00048A58
	public GUIWorldLoadBackup()
	{
	}

	// Token: 0x04001B13 RID: 6931
	private float statusScale;

	// Token: 0x04001B14 RID: 6932
	private float descriptionScale;

	// Token: 0x04001B15 RID: 6933
	private float loadScale;

	// Token: 0x04001B16 RID: 6934
	private float backScale;
}
