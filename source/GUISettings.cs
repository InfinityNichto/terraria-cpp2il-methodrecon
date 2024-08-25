using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;

// Token: 0x02000170 RID: 368
public class GUISettings
{
	// Token: 0x06000A71 RID: 2673 RVA: 0x00032514 File Offset: 0x00030714
	public static void LoadContent(ContentManager content)
	{
		Texture2D texture2D = content.Load<Texture2D>("Images/UI/PageIcons/Settings");
		Texture2D texture2D2 = content.Load<Texture2D>("Images/UI/PageIcons/SettingsSelected");
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x0003253C File Offset: 0x0003073C
	public void ShutdownUI()
	{
		if (this.Visible)
		{
			return;
		}
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00032558 File Offset: 0x00030758
	public bool Draw()
	{
		int num = 1;
		bool visible = this.Visible;
		if (num == 0)
		{
		}
		bool gameMenu = Main.gameMenu;
		if (!this.Visible)
		{
			return gameMenu;
		}
		bool flag;
		while (!flag)
		{
		}
		int num2 = 1;
		bool visible2 = this.Visible;
		this.Visible = num2 != 0;
		if (visible2)
		{
			bool flag2 = Main.SaveSettings();
			return Main.inFancyUI;
		}
		if ("Mobile.TooltipWiringKM" == null)
		{
		}
		bool flag3 = InterfaceStyles_Layout.Active.AnyOpen();
		if ("Mobile.TooltipWiringKM" == null)
		{
		}
		int gameMode = Main.GameMode;
		if ("Mobile.TooltipWiringKM" == null)
		{
		}
		InterfaceProfile_Layout active = InterfaceStyles_Layout.Active;
		Settings_Layout instance = Settings_Layout.Instance;
		bool visible3 = this.Visible;
		TransactionButton_Layout jmsettingsButton = instance.JMSettingsButton;
		string textValue = Language.GetTextValue("Mobile.JourneySettingsMenu");
		GUITransactionButton.InputState inputState;
		if (inputState == GUITransactionButton.InputState.Clicked)
		{
			int num3 = 1;
			this.Visible = num3 != 0;
			SoundEffectInstance soundEffectInstance;
			soundEffectInstance._effect = num3;
		}
		InterfaceProfile_Layout active2 = InterfaceStyles_Layout.Active;
		Settings_Layout instance2 = Settings_Layout.Instance;
		bool visible4 = this.Visible;
		TransactionButton_Layout bestiaryButton = instance2.BestiaryButton;
		string textValue2 = Language.GetTextValue("Mobile.Bestiary");
		int num4 = 1;
		GUITransactionButton.InputState inputState2;
		if (inputState2 == GUITransactionButton.InputState.Clicked)
		{
			this.Visible = num4 != 0;
			Main.mouseLeft = false;
			Main.mouseLeftRelease = true;
		}
		InterfaceProfile_Layout active3 = InterfaceStyles_Layout.Active;
		Settings_Layout instance3 = Settings_Layout.Instance;
		bool visible5 = this.Visible;
		TransactionButton_Layout mapButton = instance3.MapButton;
		if (!visible5)
		{
		}
		GUITransactionButton.InputState inputState3;
		if (inputState3 == GUITransactionButton.InputState.Clicked)
		{
			InterfaceProfile_Layout active4 = InterfaceStyles_Layout.Active;
			long num5 = 0L;
			active4.Close(num5 != 0L);
			Main.playerInventory = false;
			int myPlayer = Main.myPlayer;
			Main.npcChatCornerItem = 0;
			Main.mapFullscreen = true;
			Main.resetMapFull = true;
		}
		InterfaceProfile_Layout active5 = InterfaceStyles_Layout.Active;
		Settings_Layout instance4 = Settings_Layout.Instance;
		bool visible6 = this.Visible;
		TransactionButton_Layout housingMenuButton = instance4.HousingMenuButton;
		if (!visible6)
		{
		}
		GUITransactionButton.InputState inputState4;
		if (inputState4 == GUITransactionButton.InputState.Clicked)
		{
			InterfaceProfile_Layout active6 = InterfaceStyles_Layout.Active;
			long num6 = 0L;
			active6.Close(num6 != 0L);
		}
		InterfaceProfile_Layout active7 = InterfaceStyles_Layout.Active;
		Settings_Layout instance5 = Settings_Layout.Instance;
		bool visible7 = this.Visible;
		TransactionButton_Layout emotesButton = instance5.EmotesButton;
		string textValue3 = Language.GetTextValue("Mobile.ToggleEmotes");
		GUITransactionButton.InputState inputState5;
		if (inputState5 == GUITransactionButton.InputState.Clicked)
		{
		}
		InterfaceProfile_Layout active8 = InterfaceStyles_Layout.Active;
		Settings_Layout instance6 = Settings_Layout.Instance;
		bool visible8 = this.Visible;
		TransactionButton_Layout chatButton = instance6.ChatButton;
		if (!visible8)
		{
		}
		GUITransactionButton.InputState inputState6;
		if (inputState6 == GUITransactionButton.InputState.Clicked)
		{
		}
		InterfaceProfile_Layout active9 = InterfaceStyles_Layout.Active;
		bool visible9 = this.Visible;
		if (visible9)
		{
			bool flag4;
			return flag4;
		}
		if (!visible9)
		{
		}
		int num7 = 3;
		bool flag5 = InterfaceStyles_Layout.Active.AnyOpen();
		List<GUIPageIconGrouping> leftGroupings = InterfaceStyles_Layout.Active.LeftGroupings;
		InterfaceProfile_Layout active10 = InterfaceStyles_Layout.Active;
		Settings_Layout instance7 = Settings_Layout.Instance;
		bool visible10 = this.Visible;
		TransactionButton_Layout jmsettingsButton2 = instance7.JMSettingsButton;
		string textValue4 = Language.GetTextValue("Mobile.JourneySettingsMenu");
		GUITransactionButton.InputState inputState7;
		if (inputState7 == GUITransactionButton.InputState.Clicked)
		{
			this.Visible = num7 != 0;
			SoundEffectInstance soundEffectInstance2;
			soundEffectInstance2._effect = num7;
		}
		bool flag6 = InterfaceStyles_Layout.Active.AnyOpen();
		List<GUIPageIconGrouping> leftGroupings2 = InterfaceStyles_Layout.Active.LeftGroupings;
		InterfaceProfile_Layout active11 = InterfaceStyles_Layout.Active;
		Settings_Layout instance8 = Settings_Layout.Instance;
		bool visible11 = this.Visible;
		TransactionButton_Layout bestiaryButton2 = instance8.BestiaryButton;
		string textValue5 = Language.GetTextValue("Mobile.Bestiary");
		int num8 = 1;
		GUITransactionButton.InputState inputState8;
		if (inputState8 == GUITransactionButton.InputState.Clicked)
		{
			this.Visible = num8 != 0;
			Main.mouseLeft = false;
			Main.mouseLeftRelease = true;
		}
		return XNAUnityRunner.TouchInputKeyboardLocked;
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x000329AC File Offset: 0x00030BAC
	public GUISettings()
	{
	}

	// Token: 0x04000A58 RID: 2648
	public bool Visible;

	// Token: 0x04000A59 RID: 2649
	public bool KeySwitch;

	// Token: 0x04000A5A RID: 2650
	public bool KeyRelease = true;

	// Token: 0x04000A5B RID: 2651
	public static Texture2D _settingsTexture;

	// Token: 0x04000A5C RID: 2652
	private static Texture2D _settingsSelectedTexture;

	// Token: 0x04000A5D RID: 2653
	private float settingsButtonScale = (float)16256;
}
