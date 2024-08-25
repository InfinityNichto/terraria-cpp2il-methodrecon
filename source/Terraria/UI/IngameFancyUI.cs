using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Localization;

namespace Terraria.UI
{
	// Token: 0x020006D8 RID: 1752
	public class IngameFancyUI
	{
		// Token: 0x06003ADD RID: 15069 RVA: 0x00233084 File Offset: 0x00231284
		public static void CoverNextFrame()
		{
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x00233094 File Offset: 0x00231294
		public static bool CanCover()
		{
			return true;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x002330A4 File Offset: 0x002312A4
		public static void OpenAchievements()
		{
			Main.playerInventory = false;
			Main.editChest = false;
			Main.npcChatText = "";
			Main.mapFullscreen = false;
			IngameFancyUI.ClearChat();
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x002330D4 File Offset: 0x002312D4
		public static void OpenAchievementsAndGoto(Achievement achievement)
		{
			IngameFancyUI.OpenAchievements();
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x002330E8 File Offset: 0x002312E8
		private static void ClearChat()
		{
			if (!true)
			{
			}
			Main.ClosePlayerChat();
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00233100 File Offset: 0x00231300
		public static void OpenKeybinds()
		{
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00233110 File Offset: 0x00231310
		public static void OpenUIState(UIState uiState)
		{
			Main.playerInventory = false;
			Main.editChest = false;
			Main.npcChatText = "";
			Main.inFancyUI = true;
			IngameFancyUI.ClearChat();
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x00233140 File Offset: 0x00231340
		public static bool CanShowVirtualKeyboard(int context)
		{
			if (!true)
			{
			}
			return UIVirtualKeyboard.CanDisplay(-1073741824);
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x0023315C File Offset: 0x0023135C
		public static void OpenVirtualKeyboard(int keyboardContext)
		{
			IngameFancyUI.ClearChat();
			Main.editSign = true;
			string textValue = Language.GetTextValue("UI.EnterMessage");
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00233240 File Offset: 0x00231440
		public static void Close()
		{
			if (!true)
			{
			}
			Main.inFancyUI = false;
			bool gameMenu = Main.gameMenu;
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x0023328C File Offset: 0x0023148C
		public static bool Draw(SpriteBatch spriteBatch, GameTime gameTime)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
			}
			bool gameMenu = Main.gameMenu;
			int myPlayer = Main.myPlayer;
			int keyboardContext = UIVirtualKeyboard.KeyboardContext;
			bool inFancyUI = Main.inFancyUI;
			Vector2 vector = Main.DrawThickCursor(false);
			int keyboardContext2 = UIVirtualKeyboard.KeyboardContext;
			bool inFancyUI2 = Main.inFancyUI;
			int screenWidth = Main.screenWidth;
			return PlayerInput.UsingGamepad;
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x00233300 File Offset: 0x00231500
		public static void MouseOver()
		{
			if (!true)
			{
			}
			bool inFancyUI = Main.inFancyUI;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x00233320 File Offset: 0x00231520
		public IngameFancyUI()
		{
		}

		// Token: 0x04007ACB RID: 31435
		private static bool CoverForOneUIFrame;

		// Token: 0x020006D9 RID: 1753
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003AEA RID: 15082 RVA: 0x00233334 File Offset: 0x00231534
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06003AEB RID: 15083 RVA: 0x00233344 File Offset: 0x00231544
			public <>c()
			{
			}

			// Token: 0x06003AEC RID: 15084 RVA: 0x00233358 File Offset: 0x00231558
			internal void <OpenVirtualKeyboard>b__9_0(string s)
			{
				if (!true)
				{
				}
				Main.SubmitSignText();
				IngameFancyUI.Close();
			}

			// Token: 0x06003AED RID: 15085 RVA: 0x00233374 File Offset: 0x00231574
			internal void <OpenVirtualKeyboard>b__9_1()
			{
				if (!true)
				{
				}
				Main.InputTextSignCancel();
				IngameFancyUI.Close();
			}

			// Token: 0x06003AEE RID: 15086 RVA: 0x00233390 File Offset: 0x00231590
			internal void <OpenVirtualKeyboard>b__9_2(string s)
			{
				if (!true)
				{
				}
				int myPlayer = Main.myPlayer;
				IngameFancyUI.Close();
			}

			// Token: 0x06003AEF RID: 15087 RVA: 0x002333B0 File Offset: 0x002315B0
			internal void <OpenVirtualKeyboard>b__9_3()
			{
				if (!true)
				{
				}
				ChestUI.RenameChestCancel();
				IngameFancyUI.Close();
			}

			// Token: 0x04007ACC RID: 31436
			public static readonly IngameFancyUI.<>c <>9;

			// Token: 0x04007ACD RID: 31437
			public static UIVirtualKeyboard.KeyboardSubmitEvent <>9__9_0;

			// Token: 0x04007ACE RID: 31438
			public static Action <>9__9_1;

			// Token: 0x04007ACF RID: 31439
			public static UIVirtualKeyboard.KeyboardSubmitEvent <>9__9_2;

			// Token: 0x04007AD0 RID: 31440
			public static Action <>9__9_3;
		}
	}
}
