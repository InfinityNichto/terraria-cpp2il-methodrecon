using System;
using Terraria;
using UnityEngine;

// Token: 0x02000265 RID: 613
public class GUILowMemorySetttings
{
	// Token: 0x06000DB6 RID: 3510 RVA: 0x00041B98 File Offset: 0x0003FD98
	public void CheckMemorySettings(Action continueAction)
	{
		int systemMemorySize = SystemInfo.systemMemorySize;
		bool mapEnabled = Main.mapEnabled;
		bool enabled = ScreenPostProcessor.Enabled;
		this.WarningDisplayed = true;
		this.ContinueCallback = continueAction;
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x00041BE8 File Offset: 0x0003FDE8
	public void Draw()
	{
		if (!true)
		{
		}
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			Action continueCallback = this.ContinueCallback;
			IntPtr invoke_impl = continueCallback.invoke_impl;
			IntPtr method = continueCallback.method;
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00041C20 File Offset: 0x0003FE20
	public GUILowMemorySetttings()
	{
	}

	// Token: 0x04001957 RID: 6487
	public bool WarningDisplayed;

	// Token: 0x04001958 RID: 6488
	private Action ContinueCallback;

	// Token: 0x04001959 RID: 6489
	private float scale0;

	// Token: 0x0400195A RID: 6490
	private float scale1;

	// Token: 0x0400195B RID: 6491
	private float scale2;
}
