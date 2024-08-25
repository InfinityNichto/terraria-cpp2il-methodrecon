using System;

// Token: 0x02000278 RID: 632
public class GUIPlayerNameMenu
{
	// Token: 0x06000E41 RID: 3649 RVA: 0x00045998 File Offset: 0x00043B98
	public void Draw()
	{
		string text = this.editPlayerName;
		string text2;
		this.editPlayerName = text2;
		int stringLength = text2._stringLength;
		int num = 20;
		long num2 = 0L;
		string text3 = text2.Substring((int)num2, num);
		this.editPlayerName = text3;
		if (stringLength == 0)
		{
		}
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00045A0C File Offset: 0x00043C0C
	public GUIPlayerNameMenu()
	{
	}

	// Token: 0x04001A0C RID: 6668
	private float NewScale = (float)16256;

	// Token: 0x04001A0D RID: 6669
	private string editPlayerName;
}
