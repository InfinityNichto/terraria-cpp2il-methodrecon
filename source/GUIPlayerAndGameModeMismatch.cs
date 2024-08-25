using System;
using Terraria;
using Terraria.Localization;

// Token: 0x02000275 RID: 629
public class GUIPlayerAndGameModeMismatch
{
	// Token: 0x06000E1C RID: 3612 RVA: 0x00043D74 File Offset: 0x00041F74
	public bool CheckMismatch(int playerGameMode, int worldGameMode)
	{
		return "UI.PlayerIsCreativeAndWorldIsNotCreative" != null;
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x00043D9C File Offset: 0x00041F9C
	public void Draw()
	{
		GUIControllerPlayerAndGameModeMistmatch inputController = this._inputController;
		this._inputController.Activate();
		string textValue = Language.GetTextValue("UI.Back");
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			this.Back();
		}
		this.Back();
		string text = this.messageText;
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x00043DE0 File Offset: 0x00041FE0
	private void Back()
	{
		Main.menuMode = int.MinValue;
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x00043DF8 File Offset: 0x00041FF8
	public GUIPlayerAndGameModeMismatch()
	{
	}

	// Token: 0x040019C5 RID: 6597
	public bool WarningDisplayed;

	// Token: 0x040019C6 RID: 6598
	private float statusScale;

	// Token: 0x040019C7 RID: 6599
	private float backScale;

	// Token: 0x040019C8 RID: 6600
	private string messageText;

	// Token: 0x040019C9 RID: 6601
	private GUIControllerPlayerAndGameModeMistmatch _inputController;
}
