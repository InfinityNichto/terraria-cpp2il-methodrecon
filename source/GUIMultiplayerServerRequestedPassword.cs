using System;
using Terraria;

// Token: 0x02000271 RID: 625
public class GUIMultiplayerServerRequestedPassword
{
	// Token: 0x06000E06 RID: 3590 RVA: 0x000437D8 File Offset: 0x000419D8
	public void Draw()
	{
		bool flag = this.editingServerPassword;
		if (flag)
		{
			string text = this.editGetIP;
			string text2;
			this.editGetIP = text2;
			DrPlatform.DrPlatformType currentPlatform;
			if (flag)
			{
				Main.CloseKeyboard();
				currentPlatform = DrPlatform.CurrentPlatform;
				if (!flag)
				{
				}
				return;
			}
			while (currentPlatform != DrPlatform.DrPlatformType.None)
			{
			}
			string text3 = this.editGetIP;
			return;
		}
		else
		{
			if (flag)
			{
				return;
			}
			string text4 = this.editGetIP;
			bool hidePassword = Main.HidePassword;
			int stringLength = this.editGetIP._stringLength;
			if (this.editGetIP._stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
			}
			if (stringLength == 0)
			{
			}
			return;
		}
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x0004387C File Offset: 0x00041A7C
	public GUIMultiplayerServerRequestedPassword()
	{
	}

	// Token: 0x040019B3 RID: 6579
	public bool editingServerPassword;

	// Token: 0x040019B4 RID: 6580
	public string editGetIP;
}
