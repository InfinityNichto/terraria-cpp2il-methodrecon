using System;
using Terraria;

// Token: 0x02000288 RID: 648
public class GUIWorldNameMenu
{
	// Token: 0x06000EF3 RID: 3827 RVA: 0x0004A86C File Offset: 0x00048A6C
	public void Draw()
	{
		bool flag = this.editingWorldName;
		if (flag)
		{
			string text;
			bool flag2 = text != "";
			string text2;
			bool flag3 = text2 == " ";
			if (!flag)
			{
			}
			if (!flag)
			{
			}
			if (!flag)
			{
			}
			Main.menuMode = 16;
		}
		if (flag)
		{
			return;
		}
	}

	// Token: 0x06000EF4 RID: 3828 RVA: 0x0004A8CC File Offset: 0x00048ACC
	public GUIWorldNameMenu()
	{
	}

	// Token: 0x04001B17 RID: 6935
	private float NewScale = (float)16256;

	// Token: 0x04001B18 RID: 6936
	public bool editingWorldName;

	// Token: 0x04001B19 RID: 6937
	public bool editWorldNameForCreate;
}
