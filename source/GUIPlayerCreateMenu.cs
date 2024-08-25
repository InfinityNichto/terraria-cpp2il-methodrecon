using System;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;
using Terraria.Localization;

// Token: 0x02000276 RID: 630
public class GUIPlayerCreateMenu
{
	// Token: 0x06000E20 RID: 3616 RVA: 0x00043E08 File Offset: 0x00042008
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/CharCreation/ClothStyle");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/CharCreation/ClothStyle");
		Texture2D texture2D3 = content.Load<Texture2D>("Images/UI/CharCreation/ColorEye");
		Texture2D texture2D4 = content.Load<Texture2D>("Images/UI/CharCreation/ColorHair");
		Texture2D texture2D5 = content.Load<Texture2D>("Images/UI/CharCreation/ColorPants");
		Texture2D texture2D6 = content.Load<Texture2D>("Images/UI/CharCreation/ColorShirt");
		Texture2D texture2D7 = content.Load<Texture2D>("Images/UI/CharCreation/ColorUndershirt");
		Texture2D texture2D8 = content.Load<Texture2D>("Images/UI/CharCreation/ColorShoes");
		Texture2D texture2D9 = content.Load<Texture2D>("Images/UI/CharCreation/ColorSkin");
		Texture2D texture2D10 = content.Load<Texture2D>("Images/UI/CharCreation/HairStyle");
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00043E94 File Offset: 0x00042094
	public void Draw()
	{
		GUIPlayerCreateController controllerInput = this._controllerInput;
		this._controllerInput.Activate();
		this.DrawCategoryButtons();
		this.DrawMainButtons();
		this.DrawPlayer();
		if (this.CurrentSelection != GUIPlayerCreateMenu.ItemSelection.Info)
		{
			this.DrawHSLSlider();
			return;
		}
		this.DrawInfo();
		if (this.displayOptions)
		{
			this.DrawName();
			this.DrawDifficulty();
			return;
		}
		this.DrawDifficulty();
		this.DrawName();
		string textValue = Language.GetTextValue("Mobile.ControlsSelect");
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00043F14 File Offset: 0x00042114
	private void UpdateAnim(Player player, bool animated)
	{
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x00043F54 File Offset: 0x00042154
	private void DrawPlayer()
	{
		Main.PendingPlayer.PlayerFrame();
		Player pendingPlayer = Main.PendingPlayer;
		Player pendingPlayer2 = Main.PendingPlayer;
		float x = this.CharacterDrawOffset.X;
		float y = this.CharacterDrawOffset.Y;
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00043F9C File Offset: 0x0004219C
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		return true;
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00043FAC File Offset: 0x000421AC
	private void DrawInfo()
	{
		string textValue = Language.GetTextValue("Mobile.Randomize");
		if (this.displayOptions)
		{
			return;
		}
		bool flag = this.editingPlayerName;
		this.RandomisePlayer();
		this._controllerInput.ActivateRandomise();
		string text = this.typeDescription;
		bool flag2 = this.displayOptions;
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00043FF8 File Offset: 0x000421F8
	private void DrawName()
	{
		string text = Language.GetTextValue("Mobile.Name") + " ";
		SpriteFont spriteFont;
		Vector2 vector = spriteFont.MeasureString(text);
		bool flag = this.editingPlayerName;
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
		bool flag2 = string.IsNullOrEmpty(Main.PendingPlayer.name);
		string textValue = Language.GetTextValue("Mobile.NamePlayerEmpty");
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00044298 File Offset: 0x00042498
	private void DrawDifficulty()
	{
		string textValue = Language.GetTextValue("UI.Softcore");
		SpriteFont spriteFont;
		Vector2 vector = spriteFont.MeasureString(textValue);
		string textValue2 = Language.GetTextValue("UI.Mediumcore");
		SpriteFont spriteFont2;
		Vector2 vector2 = spriteFont2.MeasureString(textValue2);
		string textValue3 = Language.GetTextValue("UI.Hardcore");
		SpriteFont spriteFont3;
		Vector2 vector3 = spriteFont3.MeasureString(textValue3);
		string textValue4 = Language.GetTextValue("UI.Creative");
		SpriteFont spriteFont4;
		Vector2 vector4 = spriteFont4.MeasureString(textValue4);
		if (16928 == 0)
		{
		}
		byte difficulty = Main.PendingPlayer.difficulty;
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x000446DC File Offset: 0x000428DC
	private void DrawStylesGrid()
	{
		this.styleOver = 1073741824;
		int num = 5;
		this.StyleOffset = num;
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		string textValue = Language.GetTextValue("Mobile.Randomize");
		int[] array = this.actualStyleOrder;
		Player pendingPlayer = Main.PendingPlayer;
		int[] array2 = this.actualStyleOrder;
		GUIPlayerCreateController controllerInput = this._controllerInput;
		this.styleOver = array2;
		controllerInput.GenderPage.Activate();
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00044760 File Offset: 0x00042960
	private void DrawHairGrid()
	{
		int mouseX = Main.mouseX;
		int mouseY = Main.mouseY;
		string textValue = Language.GetTextValue("Mobile.Randomize");
		if (this.displayOptions)
		{
			return;
		}
		if (!this.editingPlayerName)
		{
		}
		Player pendingPlayer = Main.PendingPlayer;
		this._controllerInput.HairStlyePage.Activate();
		this._controllerInput.ActivateRandomise();
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x000021DB File Offset: 0x000003DB
	public float StyleScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x000447C8 File Offset: 0x000429C8
	public void StyleOver(int index)
	{
		int styleOffset = this.StyleOffset;
		int[] array = this.actualStyleOrder;
		this.styleOver = styleOffset;
		if (styleOffset == 0)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (styleOffset == 0)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (styleOffset == 0)
		{
		}
		Main.mouseLeftRelease = false;
		Player pendingPlayer = Main.PendingPlayer;
		int styleOffset2 = this.StyleOffset;
		int[] array2 = this.actualStyleOrder;
		pendingPlayer.skinVariant = styleOffset2;
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00044840 File Offset: 0x00042A40
	public void StyleDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (!true)
		{
		}
		Player pendingPlayer = Main.PendingPlayer;
		int styleOffset = this.StyleOffset;
		int num = this.styleOver;
		int skinVariant = pendingPlayer.skinVariant;
		Player pendingPlayer2 = Main.PendingPlayer;
		int styleOffset2 = this.StyleOffset;
		int[] array = this.actualStyleOrder;
		int skinVariant2 = pendingPlayer2.skinVariant;
		int styleOffset3 = this.StyleOffset;
		int[] array2 = this.actualStyleOrder;
		int num2 = this.styleOver;
		if (styleOffset3 == 0)
		{
		}
		Player pendingPlayer3 = Main.PendingPlayer;
		int styleOffset4 = this.StyleOffset;
		int[] array3 = this.actualStyleOrder;
		pendingPlayer3.skinVariant = styleOffset4;
		Main.PendingPlayer.PlayerFrame();
		Player pendingPlayer4 = Main.PendingPlayer;
		float x = this.CharacterStyleOffset.X;
		float y = this.CharacterStyleOffset.Y;
		if (array3 == null)
		{
		}
		Main.PendingPlayer.skinVariant = skinVariant;
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x000021DB File Offset: 0x000003DB
	public float HairScale(int index)
	{
		throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00044924 File Offset: 0x00042B24
	public void HairOver(int index)
	{
		this.hairOver = index;
		if (!true)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (!true)
		{
		}
		bool mouseLeftRelease = Main.mouseLeftRelease;
		if (!true)
		{
		}
		Main.mouseLeftRelease = false;
		Player pendingPlayer = Main.PendingPlayer;
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x00044968 File Offset: 0x00042B68
	public void HairDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
		if (!true)
		{
		}
		int hair = Main.PendingPlayer.hair;
		if (hair == 0)
		{
		}
		if (hair == 0)
		{
		}
		if (this.hairOver == 0)
		{
		}
		Color skinColor = Main.PendingPlayer.skinColor;
		Color eyeColor = Main.PendingPlayer.eyeColor;
		Color hairColor = Main.PendingPlayer.hairColor;
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00044A20 File Offset: 0x00042C20
	private void DrawSelectedPlayer(Vector2 position, float scale)
	{
		if (!true)
		{
		}
		Main.PendingPlayer.PlayerFrame();
		Player pendingPlayer = Main.PendingPlayer;
		float x = this.CharacterDrawOffset.X;
		float y = this.CharacterDrawOffset.Y;
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00044A64 File Offset: 0x00042C64
	private void DrawSelectedHighlight(Vector2 position, float scale)
	{
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00044A74 File Offset: 0x00042C74
	private void DrawSelectedHair(Vector2 position, float scale)
	{
		if (!true)
		{
		}
		Main.PendingPlayer.PlayerFrame();
		Player pendingPlayer = Main.PendingPlayer;
		if (pendingPlayer == null)
		{
		}
		int grapCount = pendingPlayer.grapCount;
		int[] grappling = pendingPlayer.grappling;
		Color skinColor = Main.PendingPlayer.skinColor;
		Color eyeColor = Main.PendingPlayer.eyeColor;
		Color hairColor = Main.PendingPlayer.hairColor;
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00044B08 File Offset: 0x00042D08
	public void CreateAndSave()
	{
		if (!true)
		{
		}
		string text = Main.PendingPlayer.name.Trim();
		PlayerFileData playerFileData = PlayerFileData.CreateAndSave(Main.PendingPlayer);
		Main.LoadPlayers();
		Main.menuMode = 1;
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00044B48 File Offset: 0x00042D48
	private void CreatePlayer()
	{
		if (!true)
		{
		}
		bool flag = string.IsNullOrWhiteSpace(Main.PendingPlayer.name);
		this.editingPlayerName = true;
		if (!true)
		{
		}
		string name = Main.PendingPlayer.name;
		this.editPlayerNameForCreate = true;
		this.editPlayerName = name;
		Main.menuMode = 3;
		Main.clrInput();
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00044BA4 File Offset: 0x00042DA4
	private void EnterName()
	{
		this.editingPlayerName = true;
		if (!true)
		{
		}
		Main.clrInput();
		string name = Main.PendingPlayer.name;
		this._playerName = name;
		GUIPlayerCreateController controllerInput = this._controllerInput;
		GUIInputRegionExclusive guiinputRegionExclusive;
		this._optionsBlocker = guiinputRegionExclusive;
		controllerInput.InfoPage.ActivateName();
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00044BF4 File Offset: 0x00042DF4
	private void CloseNameEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		this._controllerInput.InfoPage.DeactivateName();
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00044C24 File Offset: 0x00042E24
	private void CloseOptions()
	{
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		this._controllerInput.InfoPage.DeactivateOptions();
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00044C48 File Offset: 0x00042E48
	private bool DrawMenuButton(ControllerActionButton action, string label, TransactionButton_Layout buttonLayout, float scale, bool disabled)
	{
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00044C58 File Offset: 0x00042E58
	private void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		string textValue = Language.GetTextValue("LegacyMenu.28");
		if (this.displayOptions)
		{
			return;
		}
		bool flag = this.editingPlayerName;
		string textValue2 = Language.GetTextValue("LegacyMenu.5");
		if (this.displayOptions)
		{
			return;
		}
		bool flag2 = this.editingPlayerName;
		if (this.displayOptions)
		{
			this.CloseOptions();
			return;
		}
		if (this.editingPlayerName)
		{
			return;
		}
		this.Back();
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00044CDC File Offset: 0x00042EDC
	private void Back()
	{
		if (!true)
		{
		}
		Main.menuMode = 1;
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00044CF4 File Offset: 0x00042EF4
	private void DrawCategoryButtons()
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
		int num2 = 17096;
		this.TimeSinceItemChange = (float)num2;
		string textValue = Language.GetTextValue("Mobile.ControlsPageNext");
		string textValue2 = Language.GetTextValue("Mobile.ControlsPagePrevious");
		GUIPlayerCreateMenu.ItemSelection currentSelection = this.CurrentSelection;
		this.CurrentSelection = currentSelection;
		if (currentSelection == GUIPlayerCreateMenu.ItemSelection.Info)
		{
		}
		if (this.displayOptions)
		{
			this.CloseOptions();
		}
		if (this.editingPlayerName)
		{
			this.CloseNameEdit();
		}
		this._controllerInput.Activate();
		GUIPlayerCreateMenu.ItemSelection currentSelection2 = this.CurrentSelection;
		this.CurrentSelection = currentSelection2;
		if (currentSelection2 == GUIPlayerCreateMenu.ItemSelection.Info)
		{
		}
		this._controllerInput.Activate();
		string textValue3 = Language.GetTextValue("LegacyMenu.33");
		Color shirtColor = Main.PendingPlayer.shirtColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection3 = this.CurrentSelection;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num3 = 6;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num3;
			if (num3 == 0)
			{
			}
		}
		string textValue4 = Language.GetTextValue("LegacyMenu.34");
		Color underShirtColor = Main.PendingPlayer.underShirtColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection4 = this.CurrentSelection;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			int num4 = 7;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num4;
			if (num4 == 0)
			{
			}
		}
		string textValue5 = Language.GetTextValue("LegacyMenu.35");
		Color pantsColor = Main.PendingPlayer.pantsColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection5 = this.CurrentSelection;
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			int num5 = 8;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num5;
			if (num5 == 0)
			{
			}
		}
		string textValue6 = Language.GetTextValue("LegacyMenu.36");
		Color shoeColor = Main.PendingPlayer.shoeColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection6 = this.CurrentSelection;
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
			int num6 = 9;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num6;
			if (num6 == 0)
			{
			}
		}
		string textValue7 = Language.GetTextValue("LegacyMenu.18");
		Color hairColor = Main.PendingPlayer.hairColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection7 = this.CurrentSelection;
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
			GUIPlayerCreateController controllerInput = this._controllerInput;
			int num7 = 4;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num7;
			controllerInput.HairStlyePage.Activate();
			if (controllerInput == null)
			{
			}
		}
		string textValue8 = Language.GetTextValue("LegacyMenu.18");
		GUIPlayerCreateMenu.ItemSelection currentSelection8 = this.CurrentSelection;
		GUITransactionButton.InputState inputState6;
		if (inputState6 == GUITransactionButton.InputState.Clicked)
		{
			if (currentSelection8 == GUIPlayerCreateMenu.ItemSelection.Info)
			{
			}
		}
		if (currentSelection8 == GUIPlayerCreateMenu.ItemSelection.Info)
		{
		}
		int hair = Main.PendingPlayer.hair;
		string textValue9 = Language.GetTextValue("LegacyMenu.18");
		Color hairColor2 = Main.PendingPlayer.hairColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection9 = this.CurrentSelection;
		GUITransactionButton.InputState inputState7;
		if (inputState7 == GUITransactionButton.InputState.Clicked)
		{
			int num8 = 5;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num8;
		}
		string textValue10 = Language.GetTextValue("LegacyMenu.19");
		Color skinColor = Main.PendingPlayer.skinColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection10 = this.CurrentSelection;
		GUITransactionButton.InputState inputState8;
		if (inputState8 == GUITransactionButton.InputState.Clicked)
		{
			int num9 = 2;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num9;
		}
		string textValue11 = Language.GetTextValue("LegacyMenu.20");
		Color eyeColor = Main.PendingPlayer.eyeColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection11 = this.CurrentSelection;
		GUITransactionButton.InputState inputState9;
		if (inputState9 == GUITransactionButton.InputState.Clicked)
		{
			int num10 = 3;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num10;
		}
		bool male = Main.PendingPlayer.Male;
		string textValue12 = Language.GetTextValue("Mobile.PlayerCreateGender");
		Color skinColor2 = Main.PendingPlayer.skinColor;
		GUIPlayerCreateMenu.ItemSelection currentSelection12 = this.CurrentSelection;
		GUITransactionButton.InputState inputState10;
		if (inputState10 == GUITransactionButton.InputState.Clicked)
		{
			int num11 = 1;
			this.CurrentSelection = (GUIPlayerCreateMenu.ItemSelection)num11;
		}
		GUIPlayerCreateMenu.ItemSelection currentSelection13 = this.CurrentSelection;
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00045090 File Offset: 0x00043290
	public void Setup()
	{
		if ("" == null)
		{
		}
		Player pendingPlayer = Main.PendingPlayer;
		this.RandomisePlayer();
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x000450B4 File Offset: 0x000432B4
	public void RandomisePlayer()
	{
		if (!true)
		{
		}
		Player pendingPlayer = Main.PendingPlayer;
		Player pendingPlayer2 = Main.PendingPlayer;
		Color color = Main.randColor();
		pendingPlayer2.eyeColor = color;
		byte r = Main.PendingPlayer.eyeColor.R;
		byte g = Main.PendingPlayer.eyeColor.G;
		byte b = Main.PendingPlayer.eyeColor.B;
		Player pendingPlayer3 = Main.PendingPlayer;
		Color color2 = Main.randColor();
		pendingPlayer3.hairColor = color2;
		Player pendingPlayer4 = Main.PendingPlayer;
		Color color3 = Main.randColor();
		pendingPlayer4.pantsColor = color3;
		Player pendingPlayer5 = Main.PendingPlayer;
		Color color4 = Main.randColor();
		pendingPlayer5.shirtColor = color4;
		Player pendingPlayer6 = Main.PendingPlayer;
		Color color5 = Main.randColor();
		pendingPlayer6.shoeColor = color5;
		Player pendingPlayer7 = Main.PendingPlayer;
		Color color6 = Main.randColor();
		pendingPlayer7.skinColor = color6;
		Player pendingPlayer8 = Main.PendingPlayer;
		Player pendingPlayer9 = Main.PendingPlayer;
		Player pendingPlayer10 = Main.PendingPlayer;
		Player pendingPlayer11 = Main.PendingPlayer;
		Color color7 = Main.randColor();
		pendingPlayer11.underShirtColor = color7;
		int[] array = this.actualStyleOrder;
		Player pendingPlayer12 = Main.PendingPlayer;
		int[] array2 = this.actualStyleOrder;
		this.styleOver = array2;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00045240 File Offset: 0x00043440
	private void DrawHSLSlider()
	{
		float num = this.femaleButtonScale;
		GUIPlayerCreateMenu.ItemSelection currentSelection = this.CurrentSelection;
		if (currentSelection != GUIPlayerCreateMenu.ItemSelection.Info)
		{
			return;
		}
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x000456D4 File Offset: 0x000438D4
	private void SetupStartingItems()
	{
		if (!true)
		{
		}
		byte difficulty = Main.PendingPlayer.difficulty;
		Vector2 position = Main.PendingPlayer.inventory.position;
		Vector2 position2 = Main.PendingPlayer.inventory.position;
		Vector2 velocity = Main.PendingPlayer.inventory.velocity;
		Vector2 velocity2 = Main.PendingPlayer.inventory.velocity;
		Vector2 oldPosition = Main.PendingPlayer.inventory.oldPosition;
		Vector2 oldPosition2 = Main.PendingPlayer.inventory.oldPosition;
		Vector2 oldVelocity = Main.PendingPlayer.inventory.oldVelocity;
		Vector2 oldVelocity2 = Main.PendingPlayer.inventory.oldVelocity;
		int oldDirection = Main.PendingPlayer.inventory.oldDirection;
		int oldDirection2 = Main.PendingPlayer.inventory.oldDirection;
		int width = Main.PendingPlayer.inventory.width;
		Item[] inventory = Main.PendingPlayer.inventory;
		int width2 = inventory.width;
		bool wet = Main.PendingPlayer.inventory.wet;
		Item[] inventory2 = Main.PendingPlayer.inventory;
		bool wet2 = inventory2.wet;
		string nameOverride = Main.PendingPlayer.inventory._nameOverride;
		bool questItem = Main.PendingPlayer.inventory.questItem;
		Vector2 oldVelocity3 = Main.PendingPlayer.armor.oldVelocity;
		Item[] armor = Main.PendingPlayer.armor;
		Vector2 oldVelocity4 = armor.oldVelocity;
		bool flag = Main.PendingPlayer.name == "Wolf Pet";
		if (armor == null)
		{
		}
		bool flag2 = Main.PendingPlayer.name == "Wolfpet";
		if (armor == null)
		{
		}
		Item[] miscEquips = Main.PendingPlayer.miscEquips;
		Vector2 oldVelocity5 = miscEquips.oldVelocity;
		if (miscEquips == null)
		{
		}
		Player pendingPlayer = Main.PendingPlayer;
		long num = 0L;
		pendingPlayer.AddBuff(216, 3600, true, num != 0L);
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x0004596C File Offset: 0x00043B6C
	public GUIPlayerCreateMenu()
	{
	}

	// Token: 0x040019CA RID: 6602
	public static Texture2D _maleTexture;

	// Token: 0x040019CB RID: 6603
	public static Texture2D _femaleTexture;

	// Token: 0x040019CC RID: 6604
	public bool editingPlayerName;

	// Token: 0x040019CD RID: 6605
	public bool editPlayerNameForCreate;

	// Token: 0x040019CE RID: 6606
	public static Texture2D _eyeTexture;

	// Token: 0x040019CF RID: 6607
	public static Texture2D _hairTexture;

	// Token: 0x040019D0 RID: 6608
	public static Texture2D _HairStyleTexture;

	// Token: 0x040019D1 RID: 6609
	public static Texture2D _pantsTexture;

	// Token: 0x040019D2 RID: 6610
	public static Texture2D _shirtTexture;

	// Token: 0x040019D3 RID: 6611
	public static Texture2D _shoesTexture;

	// Token: 0x040019D4 RID: 6612
	public static Texture2D _skinTexture;

	// Token: 0x040019D5 RID: 6613
	public static Texture2D _undershirtTexture;

	// Token: 0x040019D6 RID: 6614
	public GUIPlayerCreateMenu.ItemSelection CurrentSelection;

	// Token: 0x040019D7 RID: 6615
	private float shirtButtonScale;

	// Token: 0x040019D8 RID: 6616
	private float underShirtButtonScale;

	// Token: 0x040019D9 RID: 6617
	private float pantsButtonScale;

	// Token: 0x040019DA RID: 6618
	private float shoesButtonScale;

	// Token: 0x040019DB RID: 6619
	private float hairButtonScale;

	// Token: 0x040019DC RID: 6620
	private float changeHairButtonScale;

	// Token: 0x040019DD RID: 6621
	private float infoButtonScale;

	// Token: 0x040019DE RID: 6622
	private float eyesButtonScale;

	// Token: 0x040019DF RID: 6623
	private float skinButtonScale;

	// Token: 0x040019E0 RID: 6624
	private float genderButtonScale;

	// Token: 0x040019E1 RID: 6625
	private float createButtonScale;

	// Token: 0x040019E2 RID: 6626
	private float randomButtonScale;

	// Token: 0x040019E3 RID: 6627
	private float backButtonScale;

	// Token: 0x040019E4 RID: 6628
	private float maleButtonScale;

	// Token: 0x040019E5 RID: 6629
	private float femaleButtonScale;

	// Token: 0x040019E6 RID: 6630
	private float randomiseButtonScale;

	// Token: 0x040019E7 RID: 6631
	public float hairScrollOffset;

	// Token: 0x040019E8 RID: 6632
	private float hairScrollMomentum;

	// Token: 0x040019E9 RID: 6633
	private int hairScrollDragging;

	// Token: 0x040019EA RID: 6634
	private Vector2 hairDragOffset;

	// Token: 0x040019EB RID: 6635
	private int hairOver;

	// Token: 0x040019EC RID: 6636
	private string _playerName = "";

	// Token: 0x040019ED RID: 6637
	private string editPlayerName;

	// Token: 0x040019EE RID: 6638
	private int[] actualStyleOrder;

	// Token: 0x040019EF RID: 6639
	private GUIPlayerCreateController _controllerInput;

	// Token: 0x040019F0 RID: 6640
	private float NameScale;

	// Token: 0x040019F1 RID: 6641
	private float DifficultyScale;

	// Token: 0x040019F2 RID: 6642
	private float TypeScale;

	// Token: 0x040019F3 RID: 6643
	private float TitleScale = (float)16256;

	// Token: 0x040019F4 RID: 6644
	public bool displayOptions;

	// Token: 0x040019F5 RID: 6645
	private string typeDescription;

	// Token: 0x040019F6 RID: 6646
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x040019F7 RID: 6647
	private bool optionOpenClicked;

	// Token: 0x040019F8 RID: 6648
	public float _pulldownShift;

	// Token: 0x040019F9 RID: 6649
	private int StyleOffset;

	// Token: 0x040019FA RID: 6650
	private Vector2 CharacterStyleOffset;

	// Token: 0x040019FB RID: 6651
	private int styleOver;

	// Token: 0x040019FC RID: 6652
	private Vector2 CharacterDrawOffset;

	// Token: 0x040019FD RID: 6653
	private float TimeSinceItemChange;

	// Token: 0x040019FE RID: 6654
	private GUISlider.DragState hueDragState;

	// Token: 0x040019FF RID: 6655
	private GUISlider.DragState satDragState;

	// Token: 0x04001A00 RID: 6656
	private GUISlider.DragState lightDragState;

	// Token: 0x02000277 RID: 631
	public enum ItemSelection
	{
		// Token: 0x04001A02 RID: 6658
		Info,
		// Token: 0x04001A03 RID: 6659
		Gender,
		// Token: 0x04001A04 RID: 6660
		Skin,
		// Token: 0x04001A05 RID: 6661
		Eyes,
		// Token: 0x04001A06 RID: 6662
		ChangeHair,
		// Token: 0x04001A07 RID: 6663
		Hair,
		// Token: 0x04001A08 RID: 6664
		Shirt,
		// Token: 0x04001A09 RID: 6665
		Undershirt,
		// Token: 0x04001A0A RID: 6666
		Pants,
		// Token: 0x04001A0B RID: 6667
		Shoes
	}
}
