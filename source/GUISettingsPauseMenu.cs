using System;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000171 RID: 369
public class GUISettingsPauseMenu
{
	// Token: 0x06000A75 RID: 2677 RVA: 0x000329D4 File Offset: 0x00030BD4
	private void SetupCreavieModeOffset(bool setup)
	{
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x000329E4 File Offset: 0x00030BE4
	public void Draw()
	{
		int gameMode = Main.GameMode;
		Texture2D texture2D;
		int width = texture2D.Width;
		bool flag = this.creativeModeActive;
		if (this._controllerList == null)
		{
			return;
		}
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			Main.mouseLeftRelease = false;
			Main.ingameOptionsWindow = false;
			Recipe.FindRecipes(false);
			bool flag2 = Main.SaveSettings();
			Main.menuMode = 10;
			WorldGen.SaveAndQuit();
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUITransactionButton.InputState inputState3;
		int num;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			bool gameMenu = Main.gameMenu;
			num = 2;
		}
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
			int num2 = 1;
			SoundEffectInstance soundEffectInstance;
			soundEffectInstance._effect = num2;
		}
		GUITransactionButton.InputState inputState6;
		if (inputState6 == GUITransactionButton.InputState.Clicked || num == 0)
		{
		}
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x00032B08 File Offset: 0x00030D08
	public GUISettingsPauseMenu()
	{
	}

	// Token: 0x04000A5E RID: 2654
	public bool Enabled;

	// Token: 0x04000A5F RID: 2655
	private GUIContollerTransactionButtonList _controllerList;

	// Token: 0x04000A60 RID: 2656
	private float settingsScale;

	// Token: 0x04000A61 RID: 2657
	private float HomeButtonScale;

	// Token: 0x04000A62 RID: 2658
	private float AchievementsButtonScale;

	// Token: 0x04000A63 RID: 2659
	private float BestiaryButtonScale;

	// Token: 0x04000A64 RID: 2660
	private float JourneySettingsButtonScale;

	// Token: 0x04000A65 RID: 2661
	private float CloseButtonScale;

	// Token: 0x04000A66 RID: 2662
	private bool creativeModeActive;
}
