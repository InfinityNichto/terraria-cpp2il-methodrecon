using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Events
{
	// Token: 0x02000A4E RID: 2638
	public class CultistRitual
	{
		// Token: 0x06004DAF RID: 19887 RVA: 0x00273FF4 File Offset: 0x002721F4
		public static void UpdateTime()
		{
			if (!true)
			{
			}
			bool netClientOnly = Main.NetClientOnly;
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00274028 File Offset: 0x00272228
		public static void CultistSlain()
		{
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00274038 File Offset: 0x00272238
		public static void TabletDestroyed()
		{
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00274048 File Offset: 0x00272248
		public static void TrySpawning(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool flag = WorldGen.PlayerLOS(0, y);
			if (num == 0)
			{
			}
			bool flag2 = WorldGen.PlayerLOS(0, y);
			bool flag3 = CultistRitual.CheckRitual(x, y);
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00274078 File Offset: 0x00272278
		private static bool CheckRitual(int x, int y)
		{
			bool flag = NPC.AnyNPCs(437);
			bool flag2;
			return flag2;
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00274094 File Offset: 0x00272294
		public static bool CheckFloor(Vector2 Center, [Out] Point[] spawnPoints)
		{
			int num = 4;
			long num2 = 0L;
			bool flag = WorldGen.SolidTile(0, num, num2 != 0L);
			if (!false)
			{
			}
			long num3 = 0L;
			Tile tileSafely = Framing.GetTileSafely(0, num);
			long num4 = 0L;
			ushort type = tileSafely.type;
			bool flag5;
			if (false)
			{
				if (!false)
				{
				}
				bool flag2 = Collision.SolidTiles(42168472, (int)num4, (int)num3, 0);
				if (!false)
				{
				}
				bool flag3 = Collision.SolidTiles(42168472, (int)num4, (int)num3, 0);
				if (!false)
				{
				}
				bool flag4 = Collision.SolidTiles(42168472, (int)num4, (int)num3, 0);
				if (!false)
				{
				}
				flag5 = Collision.SolidTiles(42168472, (int)num4, (int)num3, 0);
			}
			return flag5;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00274124 File Offset: 0x00272324
		public CultistRitual()
		{
		}

		// Token: 0x040086A2 RID: 34466
		public static int delay;

		// Token: 0x040086A3 RID: 34467
		public static int recheck;

		// Token: 0x040086A4 RID: 34468
		public const int delayStart = 86400;

		// Token: 0x040086A5 RID: 34469
		public const int respawnDelay = 43200;

		// Token: 0x040086A6 RID: 34470
		private const int timePerCultist = 3600;

		// Token: 0x040086A7 RID: 34471
		private const int recheckStart = 600;
	}
}
