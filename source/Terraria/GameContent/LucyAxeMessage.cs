using System;
using Microsoft.Xna.Framework;
using Terraria.GameContent.UI;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent
{
	// Token: 0x020007E1 RID: 2017
	public static class LucyAxeMessage
	{
		// Token: 0x060040F4 RID: 16628 RVA: 0x00244264 File Offset: 0x00242464
		private static string GetCategoryName(LucyAxeMessage.MessageSource source)
		{
			return "LucyTheAxe_Storage";
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00244280 File Offset: 0x00242480
		public static void Initialize()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x00244294 File Offset: 0x00242494
		private static void Hooks_OnEnterWorld(Player player)
		{
			if (!true)
			{
			}
			Player localPlayer = Main.LocalPlayer;
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x002442B4 File Offset: 0x002424B4
		public static void UpdateMessageCooldowns()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x002442D0 File Offset: 0x002424D0
		public static void TryPlayingIdleMessage()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Vector2 top = Main.LocalPlayer.Top;
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x002442F4 File Offset: 0x002424F4
		private static void ItemSlot_OnItemTransferred(ItemSlot.ItemTransferInfo info)
		{
			if (5095 == 0)
			{
			}
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x00244328 File Offset: 0x00242528
		private static void GiveIdleMessageCooldown()
		{
			if (!true)
			{
			}
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0024433C File Offset: 0x0024253C
		public static void PutMessageTypeOnCooldown(LucyAxeMessage.MessageSource source, int timeInFrames)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x0024434C File Offset: 0x0024254C
		private static bool CountsAsStorage(int itemSlotContext)
		{
			return true;
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x0024435C File Offset: 0x0024255C
		public static void TryCreatingMessageWithCooldown(LucyAxeMessage.MessageSource messageSource, Vector2 position, Vector2 velocity, int cooldownTimeInTicks)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00244380 File Offset: 0x00242580
		public static void Create(LucyAxeMessage.MessageSource source, Vector2 position, Vector2 velocity)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			LucyAxeMessage.GiveIdleMessageCooldown();
			LucyAxeMessage.SpawnEmoteBubble();
			if (42179736 == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (42179736 == 0)
			{
			}
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x002443BC File Offset: 0x002425BC
		private static void SpawnEmoteBubble()
		{
			if (!true)
			{
			}
			EmoteBubble.MakeLocalPlayerEmote(149);
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x002443D8 File Offset: 0x002425D8
		public static void CreateFromNet(LucyAxeMessage.MessageSource source, byte variation, Vector2 position, Vector2 velocity)
		{
			if (!true)
			{
			}
			LucyAxeMessage.SpawnPopupText(source, (int)variation, position, velocity);
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x002443F4 File Offset: 0x002425F4
		private static void PlaySound(LucyAxeMessage.MessageSource source, Vector2 position)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00244404 File Offset: 0x00242604
		private static void SpawnPopupText(LucyAxeMessage.MessageSource source, int variationUnwrapped, Vector2 position, Vector2 velocity)
		{
			if (!true)
			{
			}
			string textForVariation = LucyAxeMessage.GetTextForVariation(source, variationUnwrapped);
			if (!true)
			{
			}
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00244420 File Offset: 0x00242620
		private static string GetTextForVariation(LucyAxeMessage.MessageSource source, int variationUnwrapped)
		{
			if (!true)
			{
			}
			LocalizedText localizedText;
			return localizedText.<Value>k__BackingField;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00244438 File Offset: 0x00242638
		// Note: this type is marked as 'beforefieldinit'.
		static LucyAxeMessage()
		{
		}

		// Token: 0x04007EB0 RID: 32432
		private static byte _variation;

		// Token: 0x04007EB1 RID: 32433
		private static int[] _messageCooldownsByType;

		// Token: 0x020007E2 RID: 2018
		public enum MessageSource
		{
			// Token: 0x04007EB3 RID: 32435
			Idle,
			// Token: 0x04007EB4 RID: 32436
			Storage,
			// Token: 0x04007EB5 RID: 32437
			ThrownAway,
			// Token: 0x04007EB6 RID: 32438
			PickedUp,
			// Token: 0x04007EB7 RID: 32439
			ChoppedTree,
			// Token: 0x04007EB8 RID: 32440
			ChoppedGemTree,
			// Token: 0x04007EB9 RID: 32441
			ChoppedCactus,
			// Token: 0x04007EBA RID: 32442
			Count
		}
	}
}
