using System;
using Terraria;

// Token: 0x0200026F RID: 623
public class GUIMultiplayerServerPassword
{
	// Token: 0x06000E02 RID: 3586 RVA: 0x00043684 File Offset: 0x00041884
	public void Draw()
	{
		int menuMode = Main.menuMode;
		if (43139072 != 0)
		{
			Main.CloseKeyboard();
			Main.menuMode = 448;
			return;
		}
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00043700 File Offset: 0x00041900
	public GUIMultiplayerServerPassword()
	{
	}

	// Token: 0x040019B0 RID: 6576
	private string editGetIP;
}
