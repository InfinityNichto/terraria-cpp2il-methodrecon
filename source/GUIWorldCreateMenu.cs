using System;
using Controller;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;

// Token: 0x02000285 RID: 645
public class GUIWorldCreateMenu
{
	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000ECD RID: 3789 RVA: 0x00048D3C File Offset: 0x00046F3C
	private string WorldDescriptionName
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionName");
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00048D54 File Offset: 0x00046F54
	private string WorldDescriptionSizeSmall
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionSizeSmall");
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x06000ECF RID: 3791 RVA: 0x00048D6C File Offset: 0x00046F6C
	private string WorldDescriptionSizeMedium
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionSizeMedium");
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x00048D84 File Offset: 0x00046F84
	private string WorldDescriptionSizeLarge
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionSizeLarge");
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x00048D9C File Offset: 0x00046F9C
	private string WorldDescriptionCreative
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionCreative");
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00048DB4 File Offset: 0x00046FB4
	private string WorldDescriptionNormal
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionNormal");
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00048DCC File Offset: 0x00046FCC
	private string WorldDescriptionExpert
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionExpert");
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00048DE4 File Offset: 0x00046FE4
	private string WorldDescriptionMaster
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionMaster");
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x00048DFC File Offset: 0x00046FFC
	private string WorldDescriptionDefault
	{
		get
		{
			return Language.GetTextValue("UI.WorldDescriptionDefault");
		}
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00048E14 File Offset: 0x00047014
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewEvilRandom");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewEvilCorruption");
		Texture2D texture2D3 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewEvilCrimson");
		Texture2D texture2D4 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewSizeSmall");
		Texture2D texture2D5 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewSizeMedium");
		Texture2D texture2D6 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewSizeLarge");
		Texture2D texture2D7 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewDifficultyNormal1");
		Texture2D texture2D8 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewDifficultyNormal2");
		Texture2D texture2D9 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewDifficultyExpert1");
		Texture2D texture2D10 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewDifficultyExpert2");
		Texture2D texture2D11 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewDifficultyMaster1");
		Texture2D texture2D12 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewDifficultyMaster2");
		Texture2D texture2D13 = content.Load<Texture2D>("Images/UI/WorldCreation/PreviewDifficultyCreative2");
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00048EC8 File Offset: 0x000470C8
	public void Draw()
	{
		GUIWorldCreateController controllerInput = this._controllerInput;
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00048FDC File Offset: 0x000471DC
	private void DrawName()
	{
		SpriteFont spriteFont;
		string text;
		Vector2 vector = spriteFont.MeasureString(text);
		if (this._optionsBlocker != null)
		{
			return;
		}
		int screenWidth = Main.screenWidth;
		int screenHeight = Main.screenHeight;
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x000491BC File Offset: 0x000473BC
	private void DrawSeed()
	{
		string textValue = Language.GetTextValue("UI.WorldCreationSeed");
		SpriteFont spriteFont;
		string text;
		Vector2 vector = spriteFont.MeasureString(text);
		bool flag = this.editingWorldSeed;
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
		bool flag2 = string.IsNullOrEmpty(this.newWorldSeed);
		string textValue2 = Language.GetTextValue("UI.EnterSeed");
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00049460 File Offset: 0x00047660
	private void DrawImage()
	{
		if (17000 == 0)
		{
		}
		int num = this.difficulty;
		if (!true)
		{
		}
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x000494C8 File Offset: 0x000476C8
	private bool IsOverOptions(Vector2 cursorPosition)
	{
		if (!true)
		{
		}
		int menuMode = Main.menuMode;
		if (this.displayDifficultyOptions)
		{
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
			this._controllerInput.DeactivateDifficultyOptions();
		}
		if (this.displayWorldOptions)
		{
			GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
			this._controllerInput.DeactivateWorldOptions();
		}
		if (this.displayEvilTypeOptions)
		{
			GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
			this._controllerInput.DeactivateEvilTypeOptions();
		}
		return true;
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00049530 File Offset: 0x00047730
	private void DrawWorldSize()
	{
		string textValue = Language.GetTextValue("UI.WorldSizeSmall");
		SpriteFont spriteFont;
		Vector2 vector = spriteFont.MeasureString(textValue);
		string textValue2 = Language.GetTextValue("UI.WorldSizeMedium");
		SpriteFont spriteFont2;
		Vector2 vector2 = spriteFont2.MeasureString(textValue2);
		string textValue3 = Language.GetTextValue("UI.WorldSizeLarge");
		SpriteFont spriteFont3;
		Vector2 vector3 = spriteFont3.MeasureString(textValue3);
		bool flag = this.optionOpenClicked;
		if (flag)
		{
			if (!flag)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
		}
		if (this.displayWorldOptions)
		{
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		if (optionsBlocker == null || this.displayWorldOptions)
		{
		}
		if (optionsBlocker == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (optionsBlocker == null)
		{
		}
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		int num = this.worldSize;
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x0004987C File Offset: 0x00047A7C
	private void DrawWorldDifficulty()
	{
		int num = 4;
		this.difPulldownCount = num;
		string textValue = Language.GetTextValue("UI.Normal");
		SpriteFont spriteFont;
		Vector2 vector = spriteFont.MeasureString(textValue);
		string textValue2 = Language.GetTextValue("UI.Expert");
		SpriteFont spriteFont2;
		Vector2 vector2 = spriteFont2.MeasureString(textValue2);
		string textValue3 = Language.GetTextValue("UI.Master");
		SpriteFont spriteFont3;
		Vector2 vector3 = spriteFont3.MeasureString(textValue3);
		string textValue4 = Language.GetTextValue("UI.Creative");
		SpriteFont spriteFont4;
		Vector2 vector4 = spriteFont4.MeasureString(textValue4);
		int num2 = this.difficulty;
		float num3 = this.buttonsDistance;
		int screenHeight = Main.screenHeight;
		float num4 = this.buttonsDistance;
		int screenHeight2 = Main.screenHeight;
		float num5 = this.buttonsDistance;
		int num6 = 32640;
		int num7 = 32768;
		this.difWrapAround = num6;
		bool flag = this.optionOpenClicked;
		if (flag)
		{
			if (!flag)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
		}
		if (this.displayDifficultyOptions)
		{
			if (num7 == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
		}
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		if (optionsBlocker == null || this.displayDifficultyOptions)
		{
		}
		if (optionsBlocker == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (optionsBlocker == null)
		{
		}
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		if (this.difficulty == 0)
		{
			return;
		}
		string textValue5 = Language.GetTextValue("UI.Expert");
		if (this.displayDifficultyOptions)
		{
		}
		string textValue6 = Language.GetTextValue("Mobile.CreateWorldDifficultyTitle");
		SpriteFont spriteFont5;
		Vector2 vector5 = spriteFont5.MeasureString(textValue6);
		SpriteFont spriteFont6;
		Vector2 vector6 = spriteFont6.MeasureString(textValue5);
		long num8 = 0L;
		SpriteFont spriteFont7;
		Vector2 vector7 = spriteFont7.MeasureString(textValue5);
		int stringLength = textValue5._stringLength;
		long num9 = 0L;
		string text = textValue5.Substring((int)num9, (int)num8);
		SpriteFont spriteFont8;
		Vector2 vector8 = spriteFont8.MeasureString(text);
		string text2 = text + "...";
		bool flag2 = this.displayDifficultyOptions;
		bool flag3 = this.displayWorldOptions;
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00049D58 File Offset: 0x00047F58
	private void DrawWorldEvilType()
	{
		int num = 3;
		this.evilPulldownCount = num;
		string textValue = Language.GetTextValue("LegacyMisc.103");
		SpriteFont spriteFont;
		Vector2 vector = spriteFont.MeasureString(textValue);
		string textValue2 = Language.GetTextValue("LegacyMisc.101");
		SpriteFont spriteFont2;
		Vector2 vector2 = spriteFont2.MeasureString(textValue2);
		string textValue3 = Language.GetTextValue("LegacyMisc.102");
		SpriteFont spriteFont3;
		Vector2 vector3 = spriteFont3.MeasureString(textValue3);
		float num2 = this.buttonsDistance;
		int screenHeight = Main.screenHeight;
		float num3 = this.buttonsDistance;
		int screenHeight2 = Main.screenHeight;
		float num4 = this.buttonsDistance;
		int num5 = 32640;
		int num6 = 32768;
		this.evilWrapAround = num5;
		bool flag = this.optionOpenClicked;
		if (flag)
		{
			if (!flag)
			{
			}
			bool mouseLeftRelease = Main.mouseLeftRelease;
		}
		if (this.displayEvilTypeOptions)
		{
			if (num6 == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight3 = Main.screenHeight;
		}
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		if (optionsBlocker == null || this.displayEvilTypeOptions)
		{
		}
		if (optionsBlocker == null)
		{
		}
		bool mouseLeft = Main.mouseLeft;
		if (optionsBlocker == null)
		{
		}
		bool mouseLeftRelease2 = Main.mouseLeftRelease;
		if (this.evilType == 0)
		{
			return;
		}
		string textValue4 = Language.GetTextValue("LegacyMisc.102");
		if (this.displayEvilTypeOptions)
		{
		}
		string textValue5 = Language.GetTextValue("UI.WorldCreationEvil");
		SpriteFont spriteFont4;
		Vector2 vector4 = spriteFont4.MeasureString(textValue5);
		SpriteFont spriteFont5;
		Vector2 vector5 = spriteFont5.MeasureString(textValue4);
		long num7 = 0L;
		SpriteFont spriteFont6;
		Vector2 vector6 = spriteFont6.MeasureString(textValue4);
		int stringLength = textValue4._stringLength;
		long num8 = 0L;
		string text = textValue4.Substring((int)num8, (int)num7);
		SpriteFont spriteFont7;
		Vector2 vector7 = spriteFont7.MeasureString(text);
		string text2 = text + "...";
		bool flag2 = this.displayWorldOptions;
		bool flag3 = this.displayEvilTypeOptions;
		if (flag2)
		{
			return;
		}
		bool flag4 = this.displayDifficultyOptions;
		GUITransactionButton.InputState inputState;
		GUIWorldCreateController controllerInput;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num9 = 1;
			bool flag5 = this.displayEvilTypeOptions;
			this.optionOpenClicked = num9 != 0;
			if (flag5)
			{
				GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
				this._controllerInput.DeactivateEvilTypeOptions();
				return;
			}
			if (!flag3)
			{
				controllerInput = this._controllerInput;
				int num10 = 2;
				controllerInput.selectedItem = num10;
			}
			int num11 = 1;
			this.displayEvilTypeOptions = num11 != 0;
			GUIWorldCreateController controllerInput2 = this._controllerInput;
			int num12 = this.evilType;
			int num13 = this.evilWrapAround;
			GUIInputRegionExclusive guiinputRegionExclusive;
			this._optionsBlocker = guiinputRegionExclusive;
			controllerInput2.ActivateEvilTypeOptions(num12, num13);
		}
		if (controllerInput == null)
		{
		}
		if (this.displayEvilTypeOptions)
		{
			int num14 = this.evilWrapAround;
			float num15 = this.buttonsDistance;
			float pulldownShiftEvil = this._pulldownShiftEvil;
			int num16 = this.evilWrapAround;
			float num17 = this.buttonsDistance;
			float pulldownShiftEvil2 = this._pulldownShiftEvil;
			float pulldownShiftEvil3 = this._pulldownShiftEvil;
			int worldIndex = controllerInput.worldIndex;
			int num18 = this.evilPulldownCount;
			float num19 = this.buttonsDistance;
			int num20 = this.evilWrapAround;
			float pulldownShiftEvil4 = this._pulldownShiftEvil;
			int num21 = this.evilPulldownCount;
			float num22 = this.buttonsDistance;
			float pulldownShiftEvil5 = this._pulldownShiftEvil;
			int worldIndex2 = controllerInput.worldIndex;
			controllerInput.worldIndex = worldIndex2;
			string textValue6 = Language.GetTextValue("LegacyMisc.103");
			int num23 = this.evilType;
			GUITransactionButton.InputState inputState2;
			if (inputState2 == GUITransactionButton.InputState.Clicked && !this.optionOpenClicked)
			{
				this.evilType = controllerInput;
				string textValue7 = Language.GetTextValue("UI.WorldDescriptionEvilRandom");
				this.description = textValue7;
				GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
				this._controllerInput.DeactivateEvilTypeOptions();
			}
			string textValue8 = Language.GetTextValue("LegacyMisc.101");
			int num24 = this.evilType;
			GUITransactionButton.InputState inputState3;
			if (inputState3 == GUITransactionButton.InputState.Clicked && !this.optionOpenClicked)
			{
				string textValue9 = Language.GetTextValue("UI.WorldDescriptionEvilCorrupt");
				this.description = textValue9;
				GUIInputRegionExclusive optionsBlocker4 = this._optionsBlocker;
				this._controllerInput.DeactivateEvilTypeOptions();
			}
			string textValue10 = Language.GetTextValue("LegacyMisc.102");
			int num25 = this.evilType;
			GUITransactionButton.InputState inputState4;
			if (inputState4 == GUITransactionButton.InputState.Clicked && !this.optionOpenClicked)
			{
				string textValue11 = Language.GetTextValue("UI.WorldDescriptionEvilCrimson");
				this.description = textValue11;
				int num26 = 1;
				this.evilType = num26;
				GUIInputRegionExclusive optionsBlocker5 = this._optionsBlocker;
				this._controllerInput.DeactivateEvilTypeOptions();
			}
			GUIInputRegionExclusive optionsBlocker6 = this._optionsBlocker;
			if (optionsBlocker6 != null)
			{
				int num27 = 1;
				optionsBlocker6.Active = num27 != 0;
				bool mouseLeft2 = Main.mouseLeft;
				bool mouseLeftRelease3 = Main.mouseLeftRelease;
				GUIInputRegionExclusive optionsBlocker7 = this._optionsBlocker;
				this._controllerInput.DeactivateEvilTypeOptions();
			}
		}
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x0004A158 File Offset: 0x00048358
	private void DrawDescription()
	{
		bool flag = string.IsNullOrEmpty(this.description);
		string text;
		this.description = text;
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x0004A180 File Offset: 0x00048380
	private void EnterName()
	{
		Main.clrInput();
		GUIWorldCreateController controllerInput = this._controllerInput;
		GUIInputRegionExclusive guiinputRegionExclusive;
		this._optionsBlocker = guiinputRegionExclusive;
		controllerInput.ActivateName();
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x0004A1A8 File Offset: 0x000483A8
	private void CloseNameEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		this._controllerInput.DeactivateName();
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0004A1D4 File Offset: 0x000483D4
	private void EnterSeed()
	{
		this.editingWorldSeed = true;
		if (!true)
		{
		}
		Main.clrInput();
		string text = this.newWorldSeed;
		this._worldSeed = text;
		GUIWorldCreateController controllerInput = this._controllerInput;
		GUIInputRegionExclusive guiinputRegionExclusive;
		this._optionsBlocker = guiinputRegionExclusive;
		controllerInput.ActivateSeed();
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0004A218 File Offset: 0x00048418
	private void CloseSeedEdit()
	{
		if (!true)
		{
		}
		Main.CloseKeyboard();
		GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
		this._controllerInput.DeactivateSeed();
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x0004A244 File Offset: 0x00048444
	public void GenerateSeed()
	{
		if (!true)
		{
		}
		int num;
		string text = num.ToString();
		this.newWorldSeed = text;
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x0004A264 File Offset: 0x00048464
	public void GenerateName()
	{
		LocalizedText localizedText;
		string <Value>k__BackingField = localizedText.<Value>k__BackingField;
		LocalizedText localizedText2;
		string <Value>k__BackingField2 = localizedText2.<Value>k__BackingField;
		LocalizedText localizedText3;
		string <Value>k__BackingField3 = localizedText3.<Value>k__BackingField;
		int num;
		if (num != 0)
		{
			return;
		}
		string textValue = Language.GetTextValue("SpecialWorldName.TheConstant");
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0004A29C File Offset: 0x0004849C
	private void ProcessSpecialSeeds(string processedSeed)
	{
		int num = 1;
		if (num == 0)
		{
		}
		bool flag = processedSeed.ToLower() == "no traps";
		bool flag2 = processedSeed.ToLower() == "notraps";
		if (num == 0)
		{
		}
		bool flag3 = processedSeed.ToLower() == "not the bees";
		bool flag4 = processedSeed.ToLower() == "not the bees!";
		bool flag5 = processedSeed.ToLower() == "notthebees";
		if (num == 0)
		{
		}
		bool flag6 = processedSeed.ToLower() == "for the worthy";
		bool flag7 = processedSeed.ToLower() == "fortheworthy";
		if (num == 0)
		{
		}
		bool flag8 = processedSeed.ToLower() == "don't dig up";
		bool flag9 = processedSeed.ToLower() == "dont dig up";
		bool flag10 = processedSeed.ToLower() == "dontdigup";
		if (num == 0)
		{
		}
		bool flag11 = processedSeed.ToLower() == "celebrationmk10";
		if (num == 0)
		{
		}
		bool flag12 = processedSeed.ToLower() == "constant";
		bool flag13 = processedSeed.ToLower() == "theconstant";
		bool flag14 = processedSeed.ToLower() == "the constant";
		bool flag15 = processedSeed.ToLower() == "eye4aneye";
		bool flag16 = processedSeed.ToLower() == "eyeforaneye";
		if (num == 0)
		{
		}
		bool flag17 = processedSeed.ToLower() == "get fixed boi";
		bool flag18 = processedSeed.ToLower() == "getfixedboi";
		if (num == 0)
		{
		}
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0004A420 File Offset: 0x00048620
	public void CreateWorld()
	{
		if (!true)
		{
		}
		Main.menuMode = 7;
		Main.clrInput();
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x0004A4E4 File Offset: 0x000486E4
	public void CreateWorldCheck()
	{
		int num = this.worldSize;
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x0004A508 File Offset: 0x00048708
	private void DrawMainButtons()
	{
		bool mouseLeft = Main.mouseLeft;
		bool mouseLeftRelease = Main.mouseLeftRelease;
		string textValue = Language.GetTextValue("UI.Create");
		if (!this.displayWorldOptions && this.displayDifficultyOptions)
		{
			return;
		}
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
		}
		string textValue2 = Language.GetTextValue("UI.Back");
		GUITransactionButton.InputState inputState2;
		if (inputState2 != GUITransactionButton.InputState.Clicked)
		{
		}
		if (this.displayDifficultyOptions)
		{
			GUIInputRegionExclusive optionsBlocker = this._optionsBlocker;
			this._controllerInput.DeactivateDifficultyOptions();
			return;
		}
		if (this.displayWorldOptions)
		{
			GUIInputRegionExclusive optionsBlocker2 = this._optionsBlocker;
			this._controllerInput.DeactivateWorldOptions();
			return;
		}
		if (this.displayEvilTypeOptions)
		{
			GUIInputRegionExclusive optionsBlocker3 = this._optionsBlocker;
			this._controllerInput.DeactivateEvilTypeOptions();
			return;
		}
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x0004A5BC File Offset: 0x000487BC
	private void DrawRandomiseButtons()
	{
		bool anyControllerConnected = ControllerActionManager.AnyControllerConnected;
		string textValue = Language.GetTextValue("Mobile.Randomize");
		int selectedItem = this._controllerInput.selectedItem;
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int selectedItem2 = this._controllerInput.selectedItem;
			int selectedItem3 = this._controllerInput.selectedItem;
			this.GenerateSeed();
		}
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
		}
		GUITransactionButton.InputState inputState3;
		if (inputState3 != GUITransactionButton.InputState.Clicked)
		{
			return;
		}
		this.GenerateSeed();
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x0004A628 File Offset: 0x00048828
	private void Back()
	{
		if (!true)
		{
		}
		Main.menuMode = 6;
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x0004A640 File Offset: 0x00048840
	private void ProcessNewWorldSeed()
	{
		string text = this.newWorldSeed.Trim();
		int num = 46;
		this.newWorldSeed = text;
		string[] array;
		bool flag = int.TryParse(array, num);
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x0004A69C File Offset: 0x0004889C
	public GUIWorldCreateMenu()
	{
	}

	// Token: 0x04001ADB RID: 6875
	private bool editingWorldSeed;

	// Token: 0x04001ADC RID: 6876
	private string newWorldSeed;

	// Token: 0x04001ADD RID: 6877
	public int worldSize;

	// Token: 0x04001ADE RID: 6878
	public int evilType;

	// Token: 0x04001ADF RID: 6879
	public int difficulty;

	// Token: 0x04001AE0 RID: 6880
	private float createButtonScale;

	// Token: 0x04001AE1 RID: 6881
	private float backButtonScale;

	// Token: 0x04001AE2 RID: 6882
	private float smallButtonScale;

	// Token: 0x04001AE3 RID: 6883
	private float mediumButtonScale;

	// Token: 0x04001AE4 RID: 6884
	private float largeButtonScale;

	// Token: 0x04001AE5 RID: 6885
	private float evilRandomButtonScale;

	// Token: 0x04001AE6 RID: 6886
	private float evilCorruptionButtonScale;

	// Token: 0x04001AE7 RID: 6887
	private float evilCrimsonButtonScale;

	// Token: 0x04001AE8 RID: 6888
	private float generateNameScale;

	// Token: 0x04001AE9 RID: 6889
	private float generateSeedScale;

	// Token: 0x04001AEA RID: 6890
	private float randomiseButtonScale;

	// Token: 0x04001AEB RID: 6891
	private float normalButtonScale;

	// Token: 0x04001AEC RID: 6892
	private float expertButtonScale;

	// Token: 0x04001AED RID: 6893
	private static Texture2D previewEvilRandom;

	// Token: 0x04001AEE RID: 6894
	private static Texture2D previewEvilCorruption;

	// Token: 0x04001AEF RID: 6895
	private static Texture2D previewEvilCrimson;

	// Token: 0x04001AF0 RID: 6896
	private static Texture2D previewSizeSmall;

	// Token: 0x04001AF1 RID: 6897
	private static Texture2D previewSizeMedium;

	// Token: 0x04001AF2 RID: 6898
	private static Texture2D previewSizeLarge;

	// Token: 0x04001AF3 RID: 6899
	private static Texture2D previewDifficultyNormalBackground;

	// Token: 0x04001AF4 RID: 6900
	private static Texture2D previewDifficultyNormalBunny;

	// Token: 0x04001AF5 RID: 6901
	private static Texture2D previewDifficultyMasterBackground;

	// Token: 0x04001AF6 RID: 6902
	private static Texture2D previewDifficultyMasterBunny;

	// Token: 0x04001AF7 RID: 6903
	private static Texture2D previewDifficultyExpertBackground;

	// Token: 0x04001AF8 RID: 6904
	private static Texture2D previewDifficultyExpertBunny;

	// Token: 0x04001AF9 RID: 6905
	private static Texture2D previewDifficultyJourneyBunny;

	// Token: 0x04001AFA RID: 6906
	public string description;

	// Token: 0x04001AFB RID: 6907
	private string _worldName = "";

	// Token: 0x04001AFC RID: 6908
	private string _worldSeed = "";

	// Token: 0x04001AFD RID: 6909
	private GUIWorldCreateController _controllerInput;

	// Token: 0x04001AFE RID: 6910
	private float NameScale;

	// Token: 0x04001AFF RID: 6911
	private float SeedScale;

	// Token: 0x04001B00 RID: 6912
	private float WorldScale;

	// Token: 0x04001B01 RID: 6913
	public bool displayWorldOptions;

	// Token: 0x04001B02 RID: 6914
	public bool displayDifficultyOptions;

	// Token: 0x04001B03 RID: 6915
	public bool displayEvilTypeOptions;

	// Token: 0x04001B04 RID: 6916
	private GUIInputRegionExclusive _optionsBlocker;

	// Token: 0x04001B05 RID: 6917
	private bool optionOpenClicked;

	// Token: 0x04001B06 RID: 6918
	public float _pulldownShift;

	// Token: 0x04001B07 RID: 6919
	public float _pulldownShiftDif;

	// Token: 0x04001B08 RID: 6920
	public float _pulldownShiftEvil;

	// Token: 0x04001B09 RID: 6921
	public int difWrapAround;

	// Token: 0x04001B0A RID: 6922
	public int evilWrapAround;

	// Token: 0x04001B0B RID: 6923
	public float buttonsDistance;

	// Token: 0x04001B0C RID: 6924
	public int difPulldownCount;

	// Token: 0x04001B0D RID: 6925
	public int evilPulldownCount;

	// Token: 0x04001B0E RID: 6926
	private float DifficultyScale;

	// Token: 0x04001B0F RID: 6927
	private float EvilTypeScale;
}
