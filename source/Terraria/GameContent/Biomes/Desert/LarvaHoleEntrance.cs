using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.Desert
{
	// Token: 0x02000906 RID: 2310
	public static class LarvaHoleEntrance
	{
		// Token: 0x06004676 RID: 18038 RVA: 0x0025993C File Offset: 0x00257B3C
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
			int num5 = 13;
			int num6 = 16;
			int num7 = genRand2.Next(num5, num6);
			SurfaceMap <Surface>k__BackingField = description.<Surface>k__BackingField;
			short[] heights = <Surface>k__BackingField._heights;
			int x = <Surface>k__BackingField.X;
			Rectangle <Desert>k__BackingField = description.<Desert>k__BackingField;
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x002599AC File Offset: 0x00257BAC
		private static void PlaceAt(DesertDescription description, Point position, int holeRadius)
		{
			GenAction genAction;
			if (genAction == null || genAction != null)
			{
				int y = description.<Desert>k__BackingField.Y;
				int y2 = description.<Hive>k__BackingField.Y;
				UnifiedRandom genRand = WorldGen.genRand;
				int y3 = description.<Desert>k__BackingField.Y;
				int y4 = description.<Hive>k__BackingField.Y;
				return;
			}
			throw new ArrayTypeMismatchException();
		}
	}
}
