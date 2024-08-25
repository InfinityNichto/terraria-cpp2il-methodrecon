using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

// Token: 0x02000269 RID: 617
public class GUIMultiplayerJoin
{
	// Token: 0x06000DD2 RID: 3538 RVA: 0x0004258C File Offset: 0x0004078C
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x0004259C File Offset: 0x0004079C
	public void Draw()
	{
		if (!true)
		{
		}
		GUIControllerMultiplayerJoin controllerInput = this._controllerInput;
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x000425DC File Offset: 0x000407DC
	private void DrawServerIP()
	{
		SpriteFont spriteFont;
		string text;
		Vector2 vector = spriteFont.MeasureString(text);
		bool flag = this.editingServerIP;
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

	// Token: 0x06000DD5 RID: 3541 RVA: 0x000427B4 File Offset: 0x000409B4
	private void EnterServerIP()
	{
		if (!true)
		{
		}
		Main.clrInput();
		int num = 1;
		this.editingServerIP = num != 0;
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x000427EC File Offset: 0x000409EC
	private void CloseServerIPEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		this._controllerInput.DeactivateServerIP();
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00042818 File Offset: 0x00040A18
	private void DrawServerPort()
	{
		SpriteFont spriteFont;
		string text;
		Vector2 vector = spriteFont.MeasureString(text);
		bool flag = this.editingServerPort;
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

	// Token: 0x06000DD8 RID: 3544 RVA: 0x000429FC File Offset: 0x00040BFC
	private void EnterServerPort()
	{
		if (!true)
		{
		}
		Main.clrInput();
		this.editingServerPort = true;
		GUIControllerMultiplayerJoin controllerInput = this._controllerInput;
		GUIInputRegionExclusive guiinputRegionExclusive;
		this._optionsBlocker = guiinputRegionExclusive;
		controllerInput.ActivateServerPort();
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00042A30 File Offset: 0x00040C30
	private void CloseServerPortEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		this._controllerInput.DeactivateServerPort();
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00042A5C File Offset: 0x00040C5C
	private int ParsePort(string port)
	{
		int num = int.Parse(port);
		return 7777;
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00042A80 File Offset: 0x00040C80
	private void DrawMainButtons()
	{
		bool flag = this.editingServerIP;
		bool flag2;
		if (!flag)
		{
			flag2 = this.editingServerPort;
			if (flag2 || !flag2)
			{
			}
		}
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			if (!flag2)
			{
			}
			if (!flag)
			{
			}
			PlatformUser currentUser = PlatformUser.CurrentUser;
			Main.menuMode = 10;
			Netplay.StartTcpClient(false);
		}
		if (!flag)
		{
		}
		if (!this.editingServerIP)
		{
			bool flag3 = this.editingServerPort;
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 != GUITransactionButton.InputState.Clicked)
		{
		}
		if (!this.editingServerIP)
		{
			bool flag4 = this.editingServerPort;
			if (!flag4)
			{
				return;
			}
		}
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00042B00 File Offset: 0x00040D00
	private void Back()
	{
		Main.menuMode = 446;
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00042B18 File Offset: 0x00040D18
	public GUIMultiplayerJoin()
	{
	}

	// Token: 0x04001973 RID: 6515
	private float joinButtonScale;

	// Token: 0x04001974 RID: 6516
	private float backButtonScale;

	// Token: 0x04001975 RID: 6517
	private float TitleScale = (float)16256;

	// Token: 0x04001976 RID: 6518
	private Rectangle SelectedItemRegion;

	// Token: 0x04001977 RID: 6519
	private GUIControllerMultiplayerJoin _controllerInput;

	// Token: 0x04001978 RID: 6520
	private string _serverIP = "";

	// Token: 0x04001979 RID: 6521
	private string _serverPort = "";

	// Token: 0x0400197A RID: 6522
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x0400197B RID: 6523
	public bool editingServerIP;

	// Token: 0x0400197C RID: 6524
	public bool editingServerPort;

	// Token: 0x0400197D RID: 6525
	private const int defaultPort = 7777;
}
