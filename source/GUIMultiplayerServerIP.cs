using System;
using Terraria;

// Token: 0x0200026E RID: 622
public class GUIMultiplayerServerIP
{
	// Token: 0x06000E00 RID: 3584 RVA: 0x00043604 File Offset: 0x00041804
	public void Draw()
	{
		bool flag = this.editingServerIP;
		if (flag)
		{
			string text = this.editGetIP;
			string text2;
			this.editGetIP = text2;
			if (!flag)
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.editGetIP);
				return;
			}
			Main.CloseKeyboard();
			Main.menuMode = 449;
		}
		if (flag)
		{
			return;
		}
		string text3 = this.editGetIP;
		if (!flag)
		{
		}
		if (!flag)
		{
		}
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00043670 File Offset: 0x00041870
	public GUIMultiplayerServerIP()
	{
	}

	// Token: 0x040019AE RID: 6574
	public bool editingServerIP;

	// Token: 0x040019AF RID: 6575
	public string editGetIP;
}
