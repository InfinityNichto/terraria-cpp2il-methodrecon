using System;
using Terraria;
using UnityEngine;

// Token: 0x02000262 RID: 610
public class GUILowDiskSpacePopup
{
	// Token: 0x06000DAE RID: 3502 RVA: 0x000419E8 File Offset: 0x0003FBE8
	private long DiskSpace()
	{
		string savePath = Main.SavePath;
		if (savePath == null || savePath != null)
		{
			string text;
			Debug.Log("Disk Space:" + text);
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x00041A28 File Offset: 0x0003FC28
	public void CheckDiskSpace(Action continueAction)
	{
		long num = this.DiskSpace();
		this.WarningDisplayed = true;
		this.ContinueCallback = continueAction;
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x00041A60 File Offset: 0x0003FC60
	public void Draw()
	{
		if (!true)
		{
		}
		bool disableWarnings = this.DisableWarnings;
		GUITransactionButton.InputState inputState;
		IntPtr invoke_impl;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			Action continueCallback = this.ContinueCallback;
			invoke_impl = continueCallback.invoke_impl;
			IntPtr method_code = continueCallback.method_code;
			IntPtr method = continueCallback.method;
		}
		if (invoke_impl == 0)
		{
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x00041AAC File Offset: 0x0003FCAC
	public GUILowDiskSpacePopup()
	{
	}

	// Token: 0x04001946 RID: 6470
	public bool DisableWarnings;

	// Token: 0x04001947 RID: 6471
	public bool WarningDisplayed;

	// Token: 0x04001948 RID: 6472
	private Action ContinueCallback;

	// Token: 0x04001949 RID: 6473
	private float scale0;

	// Token: 0x0400194A RID: 6474
	private float scale1;

	// Token: 0x0400194B RID: 6475
	private float scale2;
}
