using System;
using Terraria;
using Terraria.Localization;

// Token: 0x0200027D RID: 637
public class GUIResetSettings
{
	// Token: 0x06000E6A RID: 3690 RVA: 0x00046764 File Offset: 0x00044964
	public void Draw()
	{
		GUIControllerModalResponse inputController = this._inputController;
		this._inputController.Activate();
		string textValue = Language.GetTextValue("Mobile.ResetSettingsPrompt");
		string textValue2 = Language.GetTextValue("Mobile.Reset");
		GUITransactionButton.InputState inputState;
		int num;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			num = 1;
			Main.menuMode = int.MinValue;
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked && num == 0)
		{
			Main.menuMode = int.MinValue;
		}
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x000467C4 File Offset: 0x000449C4
	public GUIResetSettings()
	{
	}

	// Token: 0x04001A4E RID: 6734
	private float scale0;

	// Token: 0x04001A4F RID: 6735
	private float scale1;

	// Token: 0x04001A50 RID: 6736
	private float scale2;

	// Token: 0x04001A51 RID: 6737
	private float titleScale = (float)16256;

	// Token: 0x04001A52 RID: 6738
	private GUIControllerModalResponse _inputController;
}
