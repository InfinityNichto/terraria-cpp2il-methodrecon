using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.Localization;
using UnityEngine;

namespace Terraria
{
	// Token: 0x02000400 RID: 1024
	public class NetMessage
	{
		// Token: 0x060020CB RID: 8395 RVA: 0x000CFFB0 File Offset: 0x000CE1B0
		public static bool TrySendData(int msgType, int remoteClient = -1, int ignoreClient = -1, [Optional] NetworkText text, int number = 0, float number2 = 0f, float number3 = 0f, float number4 = 0f, int number5 = 0, int number6 = 0, int number7 = 0)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x000CFFC8 File Offset: 0x000CE1C8
		public static void SendData(int msgType, int remoteClient = -1, int ignoreClient = -1, [Optional] NetworkText text, int number = 0, float number2 = 0f, float number3 = 0f, float number4 = 0f, int number5 = 0, int number6 = 0, int number7 = 0)
		{
			int num = 1;
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
					if (num == 0)
					{
					}
					int num2 = 145;
					if (text != null || num2 == 0)
					{
					}
					bool netHost = Main.NetHost;
					return;
				}
			}
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000D1500 File Offset: 0x000CF700
		private static void WriteAccessoryVisibility(BinaryWriter writer, bool[] hideVisibleAccessory)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000D1510 File Offset: 0x000CF710
		public static void CompressTileBlock(int xStart, int yStart, short width, short height, Stream stream)
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x000D1544 File Offset: 0x000CF744
		public static bool DoesPlayerSlotCountAsAHost(int plr)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000D1558 File Offset: 0x000CF758
		public static void CompressTileBlock_Inner(BinaryWriter writer, int xStart, int yStart, int width, int height)
		{
			if (!true)
			{
			}
			Tile tile;
			ushort type = tile.type;
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000D16B0 File Offset: 0x000CF8B0
		public static void DecompressTileBlock(Stream stream)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x000D16E0 File Offset: 0x000CF8E0
		public static void DecompressTileBlock_Inner(BinaryReader reader, int xStart, int yStart, int width, int height)
		{
			if (!true)
			{
			}
			if (false)
			{
				return;
			}
			Tile tile;
			tile.ClearEverything();
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000D177C File Offset: 0x000CF97C
		public static void BootPlayer(int plr, NetworkText msg)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x000D178C File Offset: 0x000CF98C
		public static void SendObjectPlacement(int whoAmi, int x, int y, int type, int style, int alternative, int random, int direction)
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000D17A4 File Offset: 0x000CF9A4
		public static void SendTemporaryAnimation(int whoAmi, int animationType, int tileType, int xCoord, int yCoord)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000D17B4 File Offset: 0x000CF9B4
		public static void SendPlayerHurt(int playerTargetIndex, PlayerDeathReason reason, int damage, int direction, bool critical, bool pvp, int hitContext, int remoteClient = -1, int ignoreClient = -1)
		{
			if (!true)
			{
			}
			BitsByte bitsByte = 0;
			long num = 0L;
			bitsByte[(int)num] = damage != 0;
			bitsByte[1] = damage != 0;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000D17E0 File Offset: 0x000CF9E0
		public static void SendPlayerDeath(int playerTargetIndex, PlayerDeathReason reason, int damage, int direction, bool pvp, int remoteClient = -1, int ignoreClient = -1)
		{
			if (!true)
			{
			}
			BitsByte bitsByte = 0;
			long num = 0L;
			bitsByte[(int)num] = damage != 0;
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000D1804 File Offset: 0x000CFA04
		public static void PlayNetSound(NetMessage.NetSoundInfo info, int remoteClient = -1, int ignoreClient = -1)
		{
			if (info.volume == null)
			{
			}
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000D181C File Offset: 0x000CFA1C
		public static void SendCoinLossRevengeMarker(CoinLossRevengeSystem.RevengeMarker marker, int remoteClient = -1, int ignoreClient = -1)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000D182C File Offset: 0x000CFA2C
		public static void SendTileSquare(int whoAmi, int tileX, int tileY, int xSize, int ySize, TileChangeType changeType = TileChangeType.None)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			WorldGen.RangeFrame(tileX, tileY, xSize, ySize);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000D184C File Offset: 0x000CFA4C
		public static void SendTileSquare(int whoAmi, int tileX, int tileY, int centeredSquareSize, TileChangeType changeType = TileChangeType.None)
		{
			if (!true)
			{
			}
			NetMessage.SendTileSquare(whoAmi, tileX, tileY, centeredSquareSize, centeredSquareSize, changeType);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x000D1868 File Offset: 0x000CFA68
		public static void SendTileSquare(int whoAmi, int tileX, int tileY, TileChangeType changeType = TileChangeType.None)
		{
			if (!true)
			{
			}
			NetMessage.SendTileSquare(whoAmi, tileX, tileY, 1, 1, changeType);
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000D1884 File Offset: 0x000CFA84
		public static void SendTravelShop(int remoteClient)
		{
			if (!true)
			{
			}
			bool netHost = Main.NetHost;
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000D189C File Offset: 0x000CFA9C
		public static void SendAnglerQuest(int remoteClient)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netHost = Main.NetHost;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x000D18C8 File Offset: 0x000CFAC8
		public static void SendSection(int whoAmi, int sectionX, int sectionY)
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x000D196C File Offset: 0x000CFB6C
		public static void greetPlayer(int plr)
		{
			if (!true)
			{
			}
			NetworkText networkText;
			if ((networkText == null || networkText != null) && (networkText == null || networkText != null))
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000D19E4 File Offset: 0x000CFBE4
		public static void sendWater(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool netClient = Main.NetClient;
			if (num == 0)
			{
			}
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x000D1A28 File Offset: 0x000CFC28
		public static void SyncDisconnectedPlayer(int plr)
		{
			if (!true)
			{
			}
			NetMessage.EnsureLocalPlayerIsPresent();
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x000D1A40 File Offset: 0x000CFC40
		public static void SyncConnectedPlayer(int plr)
		{
			int num = 1;
			if (num == 0)
			{
			}
			long num2 = 0L;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				NetMessage.SyncOnePlayer((int)num2, plr, plr);
			}
			NetMessage.SendNPCHousesAndTravelShop(plr);
			NetMessage.SendAnglerQuest(plr);
			CreditsRollEvent.SendCreditsRollRemainingTimeToPlayer(plr);
			NetMessage.EnsureLocalPlayerIsPresent();
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000D1A7C File Offset: 0x000CFC7C
		private static void SendNPCHousesAndTravelShop(int plr)
		{
			if (!true)
			{
			}
			int num = NPC.TypeToDefaultHeadIndex(0);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x000D1AA4 File Offset: 0x000CFCA4
		public static void EnsureLocalPlayerIsPresent()
		{
			int num = 1;
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
				if (num == 0)
				{
					if (num == 0)
					{
					}
					if (num != 0)
					{
						return;
					}
				}
				if (num == 0)
				{
				}
				Debug.Log("Local player left. Autoshutdown starting.");
				Main.menuMode = 10;
				return;
			}
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x000D1AE0 File Offset: 0x000CFCE0
		private static void SyncOnePlayer(int plr, int toWho, int fromWho)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000D1BC8 File Offset: 0x000CFDC8
		private static void SyncOnePlayer_ItemArray(int plr, int toWho, int fromWho, Item[] arr, int slot)
		{
			long entityId = arr.entityId;
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000D1BE0 File Offset: 0x000CFDE0
		public NetMessage()
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000D1BF4 File Offset: 0x000CFDF4
		// Note: this type is marked as 'beforefieldinit'.
		static NetMessage()
		{
		}

		// Token: 0x04002CF1 RID: 11505
		public static MessageBuffer[] buffer;

		// Token: 0x04002CF2 RID: 11506
		private static byte[] writeBuffer;

		// Token: 0x04002CF3 RID: 11507
		private static BinaryWriter streamWriter;

		// Token: 0x04002CF4 RID: 11508
		private static short[] chestList;

		// Token: 0x04002CF5 RID: 11509
		private static short[] signList;

		// Token: 0x04002CF6 RID: 11510
		private static short[] entityList;

		// Token: 0x04002CF7 RID: 11511
		private static byte[] bytes;

		// Token: 0x04002CF8 RID: 11512
		private static PlayerDeathReason _currentPlayerDeathReason;

		// Token: 0x04002CF9 RID: 11513
		private static NetMessage.NetSoundInfo _currentNetSoundInfo;

		// Token: 0x04002CFA RID: 11514
		private static CoinLossRevengeSystem.RevengeMarker _currentRevengeMarker;

		// Token: 0x02000401 RID: 1025
		public struct NetSoundInfo
		{
			// Token: 0x060020EA RID: 8426 RVA: 0x000D1C04 File Offset: 0x000CFE04
			public NetSoundInfo(Microsoft.Xna.Framework.Vector2 position, ushort soundIndex, int style = -1, float volume = -1f, float pitchOffset = -1f)
			{
				this.soundIndex = position;
				this.style = (int)soundIndex;
			}

			// Token: 0x060020EB RID: 8427 RVA: 0x000D1C20 File Offset: 0x000CFE20
			public void WriteSelfTo(BinaryWriter writer)
			{
				Microsoft.Xna.Framework.Vector2 vector = this.position;
				if (!true)
				{
				}
				ushort num = this.soundIndex;
				int num2 = this.style;
				float num3 = this.volume;
				float num4 = this.pitchOffset;
			}

			// Token: 0x04002CFB RID: 11515
			public Microsoft.Xna.Framework.Vector2 position;

			// Token: 0x04002CFC RID: 11516
			public ushort soundIndex;

			// Token: 0x04002CFD RID: 11517
			public int style;

			// Token: 0x04002CFE RID: 11518
			public float volume;

			// Token: 0x04002CFF RID: 11519
			public float pitchOffset;
		}
	}
}
