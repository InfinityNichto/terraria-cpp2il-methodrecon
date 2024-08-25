using System;
using Terraria;

// Token: 0x02000270 RID: 624
public class GUIMultiplayerServerPort
{
	// Token: 0x06000E04 RID: 3588 RVA: 0x00043714 File Offset: 0x00041914
	public void Draw()
	{
		bool flag = this.editingServerPort;
		int num;
		if (flag)
		{
			string text = this.editGetIP;
			string text2;
			this.editGetIP = text2;
			if (!flag)
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.editGetIP);
				bool flag3 = this.editGetIP != "";
				if ("" == null)
				{
				}
				num = 65534;
				while ("" != null)
				{
				}
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
		if ("" == null)
		{
		}
		string text4 = text3 + "";
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x000437C4 File Offset: 0x000419C4
	public GUIMultiplayerServerPort()
	{
	}

	// Token: 0x040019B1 RID: 6577
	private bool editingServerPort;

	// Token: 0x040019B2 RID: 6578
	private string editGetIP;
}
