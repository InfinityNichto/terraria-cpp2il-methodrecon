using System;
using Terraria.DataStructures;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x02000877 RID: 2167
	public static class CommonCode
	{
		// Token: 0x060043E5 RID: 17381 RVA: 0x0024EA04 File Offset: 0x0024CC04
		public static void DropItemFromNPC(NPC npc, int itemId, int stack, bool scattered = false)
		{
			float x = npc.position.X;
			float y = npc.position.Y;
			int width = npc.width;
			bool wet = npc.wet;
			if (32640 == 0)
			{
			}
			int width2 = npc.width;
			float y2 = npc.position.Y;
			int height = npc.height;
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x0024EA7C File Offset: 0x0024CC7C
		public static void DropItemLocalPerClientAndSetNPCMoneyTo0(NPC npc, int itemId, int stack, bool interactionRequired = true)
		{
			if (5456 == 0)
			{
			}
			bool netHost = Main.NetHost;
			IEntitySource itemSource_Loot = npc.GetItemSource_Loot();
			float x = npc.position.X;
			float y = npc.position.Y;
			int width = npc.width;
			bool wet = npc.wet;
			int num = 32640;
			if (num == 0)
			{
			}
			int num2 = 54000;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				if (num2 == 0)
				{
				}
				if (num != 0)
				{
					if (npc.playerInteraction == null)
					{
					}
					int myPlayer = Main.myPlayer;
					return;
				}
			}
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x0024EB94 File Offset: 0x0024CD94
		public static void DropItemForEachInteractingPlayerOnThePlayer(NPC npc, int itemId, UnifiedRandom rng, int chanceNumerator, int chanceDenominator, int stack = 1, bool interactionRequired = true)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
			if (interactionRequired && num != 0)
			{
				bool[] playerInteraction = npc.playerInteraction;
				int num2 = rng.Next(chanceDenominator);
				IEntitySource itemSource_Loot = npc.GetItemSource_Loot();
				int num3;
				CommonCode.ModifyItemDropFromNPC(npc, num3);
			}
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x0024EC08 File Offset: 0x0024CE08
		public static void ModifyItemDropFromNPC(NPC npc, int itemIndex)
		{
			if (!true)
			{
			}
			int type = npc.type;
			int netID = npc.netID;
			if (netID == 0)
			{
			}
			if (netID != 0)
			{
				int type2 = npc.type;
				return;
			}
		}
	}
}
