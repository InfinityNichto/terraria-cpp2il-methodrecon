using System;
using System.IO;

namespace Terraria.IO
{
	// Token: 0x02000571 RID: 1393
	public static class Player_OldMobile
	{
		// Token: 0x060033D8 RID: 13272 RVA: 0x00200C74 File Offset: 0x001FEE74
		public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
		{
			if (!true)
			{
			}
			long num = 0L;
			int num2 = 2;
			if (num == 0L)
			{
				long num3 = 0L;
				if (num2 == 0)
				{
				}
				if (num3 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00200CB8 File Offset: 0x001FEEB8
		private static void DecryptPlayerData(long offset, long encryptedSize)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00200CCC File Offset: 0x001FEECC
		private static bool IsValidBuff(int buffType)
		{
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x00200CDC File Offset: 0x001FEEDC
		private static void GivePlayerCoins(Player player, int value)
		{
			Item[] inventory = player.inventory;
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x00200D54 File Offset: 0x001FEF54
		private static bool LoadOld(BinaryReader reader, int release, Player player)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00200DDC File Offset: 0x001FEFDC
		private static bool Load(BinaryReader reader, Player player)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00200E5C File Offset: 0x001FF05C
		// Note: this type is marked as 'beforefieldinit'.
		static Player_OldMobile()
		{
		}

		// Token: 0x04003E1B RID: 15899
		private const int VERSION_1 = 1;

		// Token: 0x04003E1C RID: 15900
		private const int VERSION_2 = 2;

		// Token: 0x04003E1D RID: 15901
		private const int VERSION_3 = 3;

		// Token: 0x04003E1E RID: 15902
		private const int VERSION_4 = 4;

		// Token: 0x04003E1F RID: 15903
		private const int VERSION_7 = 7;

		// Token: 0x04003E20 RID: 15904
		private const int VERSION_9 = 9;

		// Token: 0x04003E21 RID: 15905
		private const int VERSION_10 = 10;

		// Token: 0x04003E22 RID: 15906
		private const int VERSION_11 = 11;

		// Token: 0x04003E23 RID: 15907
		private const int VERSION_12 = 12;

		// Token: 0x04003E24 RID: 15908
		private const int VERSION_13 = 13;

		// Token: 0x04003E25 RID: 15909
		private const int VERSION_14 = 14;

		// Token: 0x04003E26 RID: 15910
		private const int VERSION_15 = 15;

		// Token: 0x04003E27 RID: 15911
		private const int VERSION_16 = 16;

		// Token: 0x04003E28 RID: 15912
		private const int VERSION_17 = 17;

		// Token: 0x04003E29 RID: 15913
		private const int VERSION_18 = 18;

		// Token: 0x04003E2A RID: 15914
		private const int VERSION_19 = 19;

		// Token: 0x04003E2B RID: 15915
		private const int VERSION_20 = 20;

		// Token: 0x04003E2C RID: 15916
		private const int VERSION_21 = 21;

		// Token: 0x04003E2D RID: 15917
		private const int VERSION_22 = 22;

		// Token: 0x04003E2E RID: 15918
		private const int VERSION_23 = 23;

		// Token: 0x04003E2F RID: 15919
		private const int VERSION_24 = 24;

		// Token: 0x04003E30 RID: 15920
		private const int VERSION_CURRENT = 24;

		// Token: 0x04003E31 RID: 15921
		private const int PLAYER_DATA_VERSION = 24;

		// Token: 0x04003E32 RID: 15922
		private static BlowFish playerDecrypter;

		// Token: 0x04003E33 RID: 15923
		private static byte[] inputData;
	}
}
