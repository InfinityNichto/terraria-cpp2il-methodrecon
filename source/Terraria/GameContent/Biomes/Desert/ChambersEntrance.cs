using System;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x020008FE RID: 2302
	public static class ChambersEntrance
	{
		// Token: 0x06004654 RID: 18004 RVA: 0x00259048 File Offset: 0x00257248
		public static void Place(DesertDescription description)
		{
			int x = description.<Desert>k__BackingField.X;
			long num = 0L;
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 41;
			int num3 = genRand.Next((int)num, num2);
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			int x2 = <Surface>k__BackingField.X;
			short[] heights = <Surface>k__BackingField._heights;
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00259098 File Offset: 0x00257298
		private static void PlaceAt(DesertDescription description, Point position)
		{
			GenAction genAction;
			if (genAction == null || genAction != null)
			{
				UnifiedRandom genRand = WorldGen.genRand;
				int y = description.<Hive>k__BackingField.Y;
				int num = 2;
				int num2 = genRand.Next(num);
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x020008FF RID: 2303
		private struct PathConnection
		{
			// Token: 0x06004656 RID: 18006 RVA: 0x002591F0 File Offset: 0x002573F0
			public PathConnection(Point position, int direction)
			{
			}

			// Token: 0x04008272 RID: 33394
			public readonly Vector2D Position;

			// Token: 0x04008273 RID: 33395
			public readonly double Direction;
		}
	}
}
