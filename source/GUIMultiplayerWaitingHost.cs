using System;
using Terraria;
using Terraria.Localization;

// Token: 0x02000272 RID: 626
public class GUIMultiplayerWaitingHost
{
	// Token: 0x06000E08 RID: 3592 RVA: 0x00043890 File Offset: 0x00041A90
	public void Draw()
	{
		string textValue = Language.GetTextValue("Mobile.WaitingForHostToStart");
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked && this != null)
		{
			return;
		}
		Main.menuMode = 0;
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x000438BC File Offset: 0x00041ABC
	private void JoinServer()
	{
		if (!true)
		{
		}
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x000438DC File Offset: 0x00041ADC
	public GUIMultiplayerWaitingHost()
	{
	}

	// Token: 0x040019B5 RID: 6581
	private float scale0;

	// Token: 0x040019B6 RID: 6582
	private float scale1;

	// Token: 0x040019B7 RID: 6583
	private float scale2;

	// Token: 0x040019B8 RID: 6584
	private DateTime updateTime;
}
