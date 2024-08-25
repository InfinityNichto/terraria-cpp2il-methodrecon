using System;
using Terraria;
using UnityEngine;

// Token: 0x0200027C RID: 636
public class GUIQuitConfirm
{
	// Token: 0x06000E66 RID: 3686 RVA: 0x000466E8 File Offset: 0x000448E8
	public void Open()
	{
		if (!true)
		{
		}
		Main.menuMode = 202;
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00046704 File Offset: 0x00044904
	public void Draw()
	{
		GUIControllerModalResponse controller = this._controller;
		this._controller.Activate();
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			Application.Quit();
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00046738 File Offset: 0x00044938
	private void Back()
	{
		if (!true)
		{
		}
		Main.menuMode = 0;
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00046750 File Offset: 0x00044950
	public GUIQuitConfirm()
	{
	}

	// Token: 0x04001A49 RID: 6729
	private float statusScale;

	// Token: 0x04001A4A RID: 6730
	private float loadScale;

	// Token: 0x04001A4B RID: 6731
	private float backScale;

	// Token: 0x04001A4C RID: 6732
	private float titleScale;

	// Token: 0x04001A4D RID: 6733
	private GUIControllerModalResponse _controller;
}
