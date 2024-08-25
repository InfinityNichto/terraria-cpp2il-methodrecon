using System;
using System.Text;
using Terraria;
using UnityEngine;

// Token: 0x02000266 RID: 614
public class GUIMainMenu
{
	// Token: 0x06000DB9 RID: 3513 RVA: 0x00041C34 File Offset: 0x0003FE34
	public void Draw()
	{
		int num = 1;
		if (num == 0)
		{
		}
		if (num == 0)
		{
		}
		Main.mouseLeft = false;
		Main.mouseLeftRelease = true;
		if (num == 0)
		{
		}
		GUIContollerTransactionButtonList controllerListTrial = this._controllerListTrial;
		if (controllerListTrial != null)
		{
			Main.Quitting = false;
			Main.ClearVisualPostProcessEffects();
			long num2 = 0L;
			StringBuilder stringBuilder;
			stringBuilder.AppendInt((int)num2);
			bool isEditor = Application.isEditor;
			return;
		}
		if ((controllerListTrial == null || controllerListTrial != null) && (controllerListTrial == null || controllerListTrial != null) && (controllerListTrial == null || controllerListTrial != null))
		{
			return;
		}
		throw new ArrayTypeMismatchException();
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00041E5C File Offset: 0x0004005C
	public void OpenPurchaseGame()
	{
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00041E7C File Offset: 0x0004007C
	public void SelectMultiplayer()
	{
		if (!true)
		{
		}
		Liquid.ReInit();
		bool hasMultiplayerPermissions = DrPlatform.User.HasMultiplayerPermissions;
		int num = 1;
		Main.ClearPendingPlayerSelectCallbacks();
		Main.LoadPlayers();
		Main.menuMode = 1;
		if (num == 0)
		{
			return;
		}
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00041EF4 File Offset: 0x000400F4
	public GUIMainMenu()
	{
	}

	// Token: 0x0400195C RID: 6492
	private float scale0;

	// Token: 0x0400195D RID: 6493
	private float scale1;

	// Token: 0x0400195E RID: 6494
	private float scale2;

	// Token: 0x0400195F RID: 6495
	private float scale3;

	// Token: 0x04001960 RID: 6496
	private float scale4;

	// Token: 0x04001961 RID: 6497
	private float scale5;

	// Token: 0x04001962 RID: 6498
	private GUIContollerTransactionButtonList _controllerList;

	// Token: 0x04001963 RID: 6499
	private GUIContollerTransactionButtonList _controllerListTrial;
}
