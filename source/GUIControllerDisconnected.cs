using System;
using Controller;
using Microsoft.Xna.Framework;
using Terraria;
using UnityEngine;

// Token: 0x0200012E RID: 302
public class GUIControllerDisconnected
{
	// Token: 0x060007E1 RID: 2017 RVA: 0x0001F1AC File Offset: 0x0001D3AC
	private bool IsOverOptions(Microsoft.Xna.Framework.Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0001F1BC File Offset: 0x0001D3BC
	public void Draw()
	{
		int num = 1;
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		if (num == 0)
		{
		}
		bool keyboardIsActive = Main.KeyboardIsActive;
		if (num == 0)
		{
		}
		if (num != 0)
		{
		}
		bool isEditor = Application.isEditor;
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x0001F238 File Offset: 0x0001D438
	private void DisplayNpadConnectionPromptAndReassignNpads()
	{
		if (!true)
		{
		}
		Debug.LogError("Showing");
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x0001F254 File Offset: 0x0001D454
	public GUIControllerDisconnected()
	{
	}

	// Token: 0x04000677 RID: 1655
	private float statusScale;

	// Token: 0x04000678 RID: 1656
	private float loadScale;

	// Token: 0x04000679 RID: 1657
	private float backScale;

	// Token: 0x0400067A RID: 1658
	private float titleScale;

	// Token: 0x0400067B RID: 1659
	private float buttonScale = (float)16256;

	// Token: 0x0400067C RID: 1660
	private bool wasDown;

	// Token: 0x0400067D RID: 1661
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x0400067E RID: 1662
	private static bool showingReassign;
}
