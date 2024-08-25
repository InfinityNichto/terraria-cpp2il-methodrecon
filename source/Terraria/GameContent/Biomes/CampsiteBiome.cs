using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008E1 RID: 2273
	public class CampsiteBiome : MicroBiome
	{
		// Token: 0x060045C7 RID: 17863 RVA: 0x00255C70 File Offset: 0x00253E70
		public override bool Place(Point origin, StructureMap structures)
		{
			UnifiedRandom random = GenBase._random;
			int num = 6;
			int num2 = 10;
			int num3 = random.Next(num, num2);
			UnifiedRandom random2 = GenBase._random;
			int num4 = 1;
			int num5 = 5;
			int num6 = random2.Next(num4, num5);
			UnifiedRandom genRand = WorldGen.genRand;
			int num7 = 4;
			int num8 = genRand.Next(num7);
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num9 = 4;
			int num10 = genRand2.Next(num9);
			long num11 = 0L;
			GenAction genAction;
			if (genAction == null || genAction != null)
			{
				int num12 = GenBase._random.Next();
				int num13 = GenBase._random.Next();
				int num14 = 26215;
				int num17;
				if (num14 != 0)
				{
					UnifiedRandom random3 = GenBase._random;
					int num15 = 1;
					int num16 = 4;
					num17 = random3.Next(num15, num16);
					UnifiedRandom random4 = GenBase._random;
					int num18 = 1;
					int num19 = 3;
					int num20 = random4.Next(num18, num19);
					if (num14 == 0)
					{
					}
					int num21 = 332;
					int num22 = 1;
					long num23 = 0L;
					long num24 = 0L;
					bool flag2 = WorldGen.PlaceTile(0, 0, num21, num22 != 0, num23 != 0L, (int)num11, (int)num24);
				}
				int num25 = GenBase._random.Next();
				int num26 = 26215;
				if (num26 != 0)
				{
					if (num26 == 0)
					{
					}
					int num27 = 186;
					long num28 = 0L;
					long num29 = 0L;
					long num30 = 0L;
					bool flag3 = WorldGen.PlaceTile(0, 0, num27, num28 != 0L, num29 != 0L, (int)num11, (int)num30);
				}
				int num31 = GenBase._random.Next();
				int num32 = 26215;
				if (num32 != 0)
				{
					if (num32 == 0)
					{
					}
					int num33 = 215;
					int num34 = 1;
					long num35 = 0L;
					long num36 = 0L;
					bool flag4 = WorldGen.PlaceTile(num17, 0, num33, num34 != 0, num35 != 0L, (int)num11, (int)num36);
					Tile tile3;
					bool flag5 = tile3.active();
					if (!true)
					{
					}
					Tile tile4;
					ushort type2 = tile4.type;
					if (!true)
					{
					}
					Tile tile5;
					short frameY = tile5.frameY;
					if (!true)
					{
					}
					Tile tile6;
					short frameY2 = tile6.frameY;
					if (!true)
					{
					}
					Tile tile7;
					short frameY3 = tile7.frameY;
					if (!true)
					{
					}
					Tile tile8;
					short frameY4 = tile8.frameY;
					if (!true)
					{
					}
					Tile tile9;
					short frameY5 = tile9.frameY;
					if (!true)
					{
					}
					Tile tile10;
					short frameY6 = tile10.frameY;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00255EF4 File Offset: 0x002540F4
		public CampsiteBiome()
		{
		}
	}
}
