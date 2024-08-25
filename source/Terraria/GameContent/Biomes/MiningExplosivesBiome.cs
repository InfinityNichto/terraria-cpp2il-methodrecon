using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008F8 RID: 2296
	public class MiningExplosivesBiome : MicroBiome
	{
		// Token: 0x06004643 RID: 17987 RVA: 0x00258408 File Offset: 0x00256608
		public override bool Place(Point origin, StructureMap structures)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (num == 0)
			{
			}
			Tile tile2;
			ushort wall2 = tile2.wall;
			UnifiedRandom random = GenBase._random;
			int num2 = 166;
			if (7 == 0)
			{
			}
			double num3 = GenBase._random.NextDouble();
			long num4 = 0L;
			UnifiedRandom random2 = GenBase._random;
			int num5 = 4;
			int num6 = random2.Next(num5);
			if (!true)
			{
			}
			long num7 = 0L;
			Tile tile3;
			tile3.slope((byte)num7);
			long num8 = 0L;
			tile3.halfBrick(num8 != 0L);
			if (num2 == 0)
			{
			}
			long num9 = 0L;
			int num10 = 1;
			bool flag;
			WorldUtils.TileFrame(flag ? 1 : 0, (int)num9, num10 != 0);
			int num11 = 411;
			int num12 = 1;
			int num13 = 1;
			long num14 = 0L;
			bool flag3;
			bool flag2 = WorldGen.PlaceTile(flag3 ? 1 : 0, int.MinValue, num11, num12 != 0, num13 != 0, (int)num4, (int)num14);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x00258524 File Offset: 0x00256724
		public MiningExplosivesBiome()
		{
		}
	}
}
