using System;
using System.Globalization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics;
using Terraria.IO;
using Terraria.Localization;

// Token: 0x02000268 RID: 616
public class GUIMultiplayerHost
{
	// Token: 0x06000DC3 RID: 3523 RVA: 0x00041FC8 File Offset: 0x000401C8
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00041FD8 File Offset: 0x000401D8
	public void Draw()
	{
		if (!true)
		{
		}
		Rectangle selectedItemRegion = this.SelectedItemRegion;
		int width = this.SelectedItemRegion.Width;
		ControlAnchor.SetGridItemRegion(selectedItemRegion);
		GUIControllerMultiplayerHost controllerInput = this._controllerInput;
		this.DrawMaxPlayers();
		this.DrawMainButtons();
		this.DrawOpenInviteOnly();
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x00042028 File Offset: 0x00040228
	private void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		string textValue = Language.GetTextValue("UI.Play");
		bool flag = this.editingServerPassword;
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00042088 File Offset: 0x00040288
	private void Back()
	{
		Main.menuMode = int.MinValue;
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x000420A0 File Offset: 0x000402A0
	private void DrawMaxPlayers()
	{
		bool wasDragging = this.dragState.wasDragging;
		if (!wasDragging)
		{
			if (!wasDragging)
			{
			}
			int num = 2;
			int num2 = 8;
			float num3 = GUISlider.CalculateValue(int.MinValue, num, num2);
		}
		int selectionIndex = this._controllerInput.selectionIndex;
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00042184 File Offset: 0x00040384
	public string GetDefaultIPAddress()
	{
		return "127.0.0.1";
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00042198 File Offset: 0x00040398
	public void HostServer()
	{
		int num = 1;
		int num2 = 1;
		if (num == 0)
		{
		}
		if (num2 != 0)
		{
			return;
		}
		if (num2 == 0)
		{
			PlatformUser currentUser = PlatformUser.CurrentUser;
		}
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x000421F0 File Offset: 0x000403F0
	private void DrawOpenInviteOnly()
	{
		string textValue = Language.GetTextValue("Mobile.OpenInviteOnlyTitle");
		GUITransactionButton.InputState inputState;
		GUIControllerMultiplayerHost controllerInput;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num = 1;
			bool inviteOnly = this.InviteOnly;
			this.InviteOnly = inviteOnly;
			controllerInput = this._controllerInput;
			controllerInput.selectionIndex = num;
		}
		if (this.InviteOnly)
		{
			string textValue2 = Language.GetTextValue("Mobile.ToggleSettingOff");
			if (controllerInput == null)
			{
			}
			return;
		}
		string textValue3 = Language.GetTextValue("Mobile.ToggleSettingOn");
		if (controllerInput == null)
		{
		}
		string textValue4 = Language.GetTextValue("Mobile.ToggleSettingOff");
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00042268 File Offset: 0x00040468
	private void DrawPassword()
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (num == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		SpriteFont spriteFont;
		string text;
		Vector2 vector = spriteFont.MeasureString(text);
		bool flag = this.editingServerPassword;
		if (this._optionsBlocker != null)
		{
			if (flag)
			{
				return;
			}
		}
		else if (flag)
		{
			if (!flag)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			return;
		}
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00042430 File Offset: 0x00040630
	private void CloseServerPasswordEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		this._controllerInput.DeactivateServerPassword();
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x0004245C File Offset: 0x0004065C
	private void EnterServerPassword()
	{
		if (!true)
		{
		}
		Main.clrInput();
		this.editingServerPassword = true;
		if (!true)
		{
		}
		this._password = 1;
		GUIControllerMultiplayerHost controllerInput = this._controllerInput;
		GUIInputRegionExclusive guiinputRegionExclusive;
		this._optionsBlocker = guiinputRegionExclusive;
		controllerInput.ActivateServerPassword();
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00042498 File Offset: 0x00040698
	private Texture2D GetIcon(WorldFileData worldData)
	{
		bool isHardMode = worldData.IsHardMode;
		if (!worldData.HasCorruption)
		{
		}
		string text;
		return TextureManager.Load(text);
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x000424BC File Offset: 0x000406BC
	private void DrawWorld(WorldFileData worldData)
	{
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x000424D0 File Offset: 0x000406D0
	private void WorldDraw()
	{
		int num = 32;
		int num2 = 24;
		if (num == 0)
		{
		}
		string text;
		if (text == null)
		{
		}
		string text2;
		string textValue = Language.GetTextValue("UI.WorldSizeFormat", text2);
		if (num2 == 0)
		{
		}
		DateTimeFormatInfo currentInfo = DateTimeFormatInfo.CurrentInfo;
		string text3;
		string textValue2 = Language.GetTextValue("UI.WorldCreatedFormat", text3);
		if ("UI.WorldCreatedFormat" == null)
		{
		}
		if (num2 == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		Main.LoadWorlds();
		Main.menuMode = 6;
		if (num2 == 0)
		{
			return;
		}
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00042554 File Offset: 0x00040754
	public GUIMultiplayerHost()
	{
	}

	// Token: 0x04001966 RID: 6502
	private float joinButtonScale;

	// Token: 0x04001967 RID: 6503
	private float backButtonScale;

	// Token: 0x04001968 RID: 6504
	private float TitleScale = (float)16256;

	// Token: 0x04001969 RID: 6505
	private string _password = "";

	// Token: 0x0400196A RID: 6506
	public bool editingServerPassword;

	// Token: 0x0400196B RID: 6507
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x0400196C RID: 6508
	private Rectangle SelectedItemRegion;

	// Token: 0x0400196D RID: 6509
	private GUIControllerMultiplayerHost _controllerInput;

	// Token: 0x0400196E RID: 6510
	public const int MaxLocalMPPlayers = 8;

	// Token: 0x0400196F RID: 6511
	private GUISlider.DragState dragState;

	// Token: 0x04001970 RID: 6512
	private float maxPlayerScale = (float)16256;

	// Token: 0x04001971 RID: 6513
	public bool InviteOnly;

	// Token: 0x04001972 RID: 6514
	private float InviteToggleScale;
}
