using System;
using UnityEngine;

// Token: 0x0200029C RID: 668
public class GUISaveSynchronisation_Status
{
	// Token: 0x06000FB0 RID: 4016 RVA: 0x0004E8C0 File Offset: 0x0004CAC0
	public static void DrawStatus(string status)
	{
		GUITransactionButton.InputState inputState;
		if (inputState != GUITransactionButton.InputState.Clicked)
		{
			bool keyUp = KeyboardInput.GetKeyUp(KeyCode.Escape);
		}
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0004E8D8 File Offset: 0x0004CAD8
	public GUISaveSynchronisation_Status()
	{
	}
}
