using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x020008FD RID: 2301
	public static class AnthillEntrance
	{
		// Token: 0x06004652 RID: 18002 RVA: 0x00258ED4 File Offset: 0x002570D4
		public static void Place(DesertDescription description)
		{
			int num = 1;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 2;
			int num3 = 4;
			int num4 = genRand.Next(num2, num3);
			if (num == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num5 = 15;
			int num6 = 18;
			int num7 = genRand2.Next(num5, num6);
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			short[] heights = <Surface>k__BackingField._heights;
			int x = <Surface>k__BackingField.X;
			Rectangle <Desert>k__BackingField = description.<Desert>k__BackingField;
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00258F48 File Offset: 0x00257148
		private static void PlaceAt(DesertDescription description, Point position, int holeRadius)
		{
			GenAction genAction;
			if (genAction == null || genAction != null)
			{
				int y = description.<Desert>k__BackingField.Y;
				int y2 = description.<Hive>k__BackingField.Y;
				if (y == 0)
				{
					if (y == 0)
					{
					}
					UnifiedRandom genRand = WorldGen.genRand;
				}
				int y3 = description.<Desert>k__BackingField.Y;
				int y4 = description.<Hive>k__BackingField.Y;
				GenAction genAction2;
				if (genAction2 == null || genAction2 != null)
				{
					return;
				}
			}
			throw new ArrayTypeMismatchException();
		}
	}
}
