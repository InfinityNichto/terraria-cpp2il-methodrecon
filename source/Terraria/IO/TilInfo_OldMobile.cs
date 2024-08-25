using System;
using System.IO;
using Cpp2IlInjected;
using UnityEngine;

namespace Terraria.IO
{
	// Token: 0x02000574 RID: 1396
	public class TilInfo_OldMobile
	{
		// Token: 0x060033E4 RID: 13284 RVA: 0x00200F04 File Offset: 0x001FF104
		private void PatchFrameY(int release, int type, short frameY)
		{
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000021DB File Offset: 0x000003DB
		private byte ConverTileColor(byte input)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00200F14 File Offset: 0x001FF114
		public bool Load(BinaryReader reader, int release)
		{
			int num = 32768;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			ushort num2;
			if (num2 != 0)
			{
			}
			if (num2 != 0)
			{
			}
			if (num == 0)
			{
			}
			Debug.LogWarning("Invalid RLE count protecting against overrun");
			return "Invalid RLE count protecting against overrun" != null;
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00200F94 File Offset: 0x001FF194
		private void CleanItemsStoredInTiles()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00200FD4 File Offset: 0x001FF1D4
		private void FixChairFrame(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameY = tile.frameY;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00200FF0 File Offset: 0x001FF1F0
		private void CheckWeaponsRack(int i, int j)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			int num = 18;
			Tile tile3;
			tile3.SetFrameX((short)num);
			int num2 = 18;
			Tile tile4;
			tile4.SetFrameY((short)num2);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x0020102C File Offset: 0x001FF22C
		public bool ItemFitsWeaponRack(Item i)
		{
			int fishingPole = i.fishingPole;
			int netID = i.netID;
			int damage = i.damage;
			if (true && i.useStyle != 0)
			{
				int stack = i.stack;
				return;
			}
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x00201064 File Offset: 0x001FF264
		public void PlaceWeapon(int x, int y, Item item)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			if (num == 0)
			{
			}
			Tile tile3;
			short frameY = tile3.frameY;
			if (num == 0)
			{
			}
			Tile tile4;
			short frameY2 = tile4.frameY;
			if (num == 0)
			{
			}
			Tile tile5;
			short frameY3 = tile5.frameY;
			if (num == 0)
			{
			}
			Tile tile6;
			short frameX = tile6.frameX;
			if (36409 == 0)
			{
			}
			Tile tile7;
			short frameX2 = tile7.frameX;
			int netID = item.netID;
			Tile tile8;
			tile8.SetFrameX((short)x);
			byte prefix = item.prefix;
			Tile tile9;
			tile9.SetFrameX((short)x);
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x002010F0 File Offset: 0x001FF2F0
		private void CheckMannequin(int i, int j)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			int num2 = 34079;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag = ItemConversion_OldMobile.ModifyBodySlot((int)tile2.frameY);
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00201198 File Offset: 0x001FF398
		public TilInfo_OldMobile()
		{
		}
	}
}
