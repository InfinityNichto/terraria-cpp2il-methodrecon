using System;
using Terraria;

// Token: 0x0200026D RID: 621
public class GUIMultiplayerMenu
{
	// Token: 0x06000DFE RID: 3582 RVA: 0x00043578 File Offset: 0x00041778
	public void Draw()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		Main.LoadPlayers();
		Main.menuMode = 1;
		bool mouseLeft2 = Main.mouseLeft;
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		Main.LoadPlayers();
		Main.menuMode = 1;
		bool mouseLeft3 = Main.mouseLeft;
		bool mouseLeftRelease3 = Main.mouseLeftRelease;
		Main.menuMode = 0;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x000435F0 File Offset: 0x000417F0
	public GUIMultiplayerMenu()
	{
	}

	// Token: 0x040019AB RID: 6571
	private float scale0;

	// Token: 0x040019AC RID: 6572
	private float scale1;

	// Token: 0x040019AD RID: 6573
	private float scale2;
}
