using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.UI
{
	// Token: 0x020006DC RID: 1756
	public class ChestUI
	{
		// Token: 0x06003AF7 RID: 15095 RVA: 0x00233488 File Offset: 0x00231688
		public static void UpdateHover(int ID, bool hovering)
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

		// Token: 0x06003AF8 RID: 15096 RVA: 0x002334A4 File Offset: 0x002316A4
		public static void Draw(SpriteBatch spritebatch)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int myPlayer = Main.myPlayer;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				return;
			}
			if (num == 0)
			{
			}
			int mouseX = Main.mouseX;
			int mouseY = Main.mouseY;
			float inventoryScale = Main.inventoryScale;
			float inventoryScale2 = Main.inventoryScale;
			int num2 = 17042;
			if (num2 == 0)
			{
			}
			int myPlayer2 = Main.myPlayer;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x0023351C File Offset: 0x0023171C
		private static void DrawName(SpriteBatch spritebatch)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			bool editChest = Main.editChest;
			string npcChatText = Main.npcChatText;
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x002335EC File Offset: 0x002317EC
		private static void DrawButtons(SpriteBatch spritebatch)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00233604 File Offset: 0x00231804
		private static void DrawButton(SpriteBatch spriteBatch, int ID, int X, int Y)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00233788 File Offset: 0x00231988
		private static void ToggleVacuum()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x002337A4 File Offset: 0x002319A4
		private static void DrawSlots(SpriteBatch spriteBatch)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00233874 File Offset: 0x00231A74
		public static bool CanBeDepositied(int p)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			bool flag;
			return flag;
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x002338D4 File Offset: 0x00231AD4
		public static void Deposit(int p)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x002339D8 File Offset: 0x00231BD8
		public static void LootItem(int j)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			Item item;
			if (item == null || item != null)
			{
				bool netClientOnly = Main.NetClientOnly;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00233A4C File Offset: 0x00231C4C
		public static void LootAll()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			int myPlayer2 = Main.myPlayer;
			Item item;
			if (item == null || item != null)
			{
				bool netClient = Main.NetClient;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00233ADC File Offset: 0x00231CDC
		public static void DepositAll(ContainerTransferContext context)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00233C24 File Offset: 0x00231E24
		public static void QuickStack(ContainerTransferContext context, bool voidStack = false)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00233D24 File Offset: 0x00231F24
		public static void RenameChest()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			bool editChest = Main.editChest;
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00233D9C File Offset: 0x00231F9C
		public static void RenameChestSubmit(Player player)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Main.editChest = false;
			if (num == 0)
			{
			}
			string npcChatText = Main.npcChatText;
			string defaultChestName = Main.defaultChestName;
			bool flag = npcChatText == defaultChestName;
			if (num == 0)
			{
			}
			Main.npcChatText = "";
			if (num == 0)
			{
			}
			string npcChatText2 = Main.npcChatText;
			bool flag2 = "" != npcChatText2;
			if (num == 0)
			{
			}
			string npcChatText3 = Main.npcChatText;
			bool netClient = Main.NetClient;
			int num2 = 1;
			player.editedChestName = num2 != 0;
		}

		// Token: 0x06003B06 RID: 15110 RVA: 0x00233E24 File Offset: 0x00232024
		public static void RenameChestCancel()
		{
			if (!true)
			{
			}
			Main.editChest = false;
			string text;
			Main.blockKey = text;
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00233E40 File Offset: 0x00232040
		public static void Restock()
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x00233EDC File Offset: 0x002320DC
		public static long MoveCoins(Item[] pInv, Item[] cInv, ContainerTransferContext context)
		{
			long entityId = pInv.entityId;
			long num;
			return num;
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x00233FA0 File Offset: 0x002321A0
		public static bool TryPlacingInChest(Item I, bool justCheck, int itemSlotContext)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00234038 File Offset: 0x00232238
		public static void GetContainerUsageInfo([Out] bool sync, [Out] Item[] chestinv)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00234060 File Offset: 0x00232260
		public static bool IsBlockedFromTransferIntoChest(Item item, Item[] container)
		{
			if (true)
			{
				if (!true)
				{
				}
				Item[] item2 = Main.LocalPlayer.bank.item;
				if (item2 != null)
				{
					if (item2 == null)
					{
					}
					Item[] item3 = Main.LocalPlayer.bank4.item;
				}
			}
			return true;
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x002340A4 File Offset: 0x002322A4
		public static bool TryPlacingInPlayer(int slot, bool justCheck)
		{
			if (!true)
			{
			}
			int myPlayer = Main.myPlayer;
			return Main.NetClientOnly;
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x0023412C File Offset: 0x0023232C
		public ChestUI()
		{
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x00234140 File Offset: 0x00232340
		// Note: this type is marked as 'beforefieldinit'.
		static ChestUI()
		{
			if (!true)
			{
			}
		}

		// Token: 0x04007AE0 RID: 31456
		public const float buttonScaleMinimum = 0.75f;

		// Token: 0x04007AE1 RID: 31457
		public const float buttonScaleMaximum = 1f;

		// Token: 0x04007AE2 RID: 31458
		public static float[] ButtonScale;

		// Token: 0x04007AE3 RID: 31459
		public static bool[] ButtonHovered;

		// Token: 0x020006DD RID: 1757
		public class ButtonID
		{
			// Token: 0x06003B0F RID: 15119 RVA: 0x00234150 File Offset: 0x00232350
			public ButtonID()
			{
			}

			// Token: 0x06003B10 RID: 15120 RVA: 0x00234164 File Offset: 0x00232364
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonID()
			{
			}

			// Token: 0x04007AE4 RID: 31460
			public const int LootAll = 0;

			// Token: 0x04007AE5 RID: 31461
			public const int DepositAll = 1;

			// Token: 0x04007AE6 RID: 31462
			public const int QuickStack = 2;

			// Token: 0x04007AE7 RID: 31463
			public const int Restock = 3;

			// Token: 0x04007AE8 RID: 31464
			public const int Sort = 4;

			// Token: 0x04007AE9 RID: 31465
			public const int RenameChest = 5;

			// Token: 0x04007AEA RID: 31466
			public const int RenameChestCancel = 6;

			// Token: 0x04007AEB RID: 31467
			public const int ToggleVacuum = 7;

			// Token: 0x04007AEC RID: 31468
			public static readonly int Count;
		}
	}
}
