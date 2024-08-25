using System;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008ED RID: 2285
	public class EnchantedSwordBiome : MicroBiome
	{
		// Token: 0x06004608 RID: 17928 RVA: 0x00256ADC File Offset: 0x00254CDC
		public override bool Place(Point origin, StructureMap structures)
		{
			GenCondition genCondition2;
			GenCondition genCondition = genCondition2.Not();
			if (genCondition == null || genCondition != null)
			{
				UnifiedRandom random = GenBase._random;
				double num = random.NextDouble();
				GenAction genAction;
				GenAction genAction2;
				if ((genAction == null || genAction != null) && (genAction2 == null || genAction2 != null))
				{
					long num2 = 0L;
					double num3 = GenBase._random.NextDouble();
					GenAction genAction3;
					GenAction genAction4;
					if ((genAction3 == null || genAction3 != null) && (genAction4 == null || genAction4 != null))
					{
						UnifiedRandom random2 = GenBase._random;
						long num4 = 0L;
						double num5 = random2.NextDouble();
						int num6 = 187;
						int num7 = 1;
						int num8 = 17;
						long num9 = 0L;
						bool flag = WorldGen.PlaceTile(0, (int)num4, num6, num7 != 0, num9 != 0L, (int)num2, num8);
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00256C50 File Offset: 0x00254E50
		public EnchantedSwordBiome()
		{
		}

		// Token: 0x04008259 RID: 33369
		[JsonProperty("ChanceOfEntrance")]
		private double _chanceOfEntrance;

		// Token: 0x0400825A RID: 33370
		[JsonProperty("ChanceOfRealSword")]
		private double _chanceOfRealSword;
	}
}
