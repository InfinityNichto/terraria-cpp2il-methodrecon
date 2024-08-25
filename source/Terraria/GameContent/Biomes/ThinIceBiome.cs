using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008FC RID: 2300
	public class ThinIceBiome : MicroBiome
	{
		// Token: 0x06004650 RID: 18000 RVA: 0x00258E30 File Offset: 0x00257030
		public override bool Place(Point origin, StructureMap structures)
		{
			UnifiedRandom random = GenBase._random;
			int num = 10;
			int num2 = 15;
			int num3 = random.Next(num, num2);
			UnifiedRandom random2 = GenBase._random;
			int num4 = 5;
			int num5 = random2.Next(num, num4);
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x00258EC0 File Offset: 0x002570C0
		public ThinIceBiome()
		{
		}
	}
}
