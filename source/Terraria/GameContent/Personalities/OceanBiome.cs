using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000832 RID: 2098
	public class OceanBiome : AShoppingBiome
	{
		// Token: 0x060042F4 RID: 17140 RVA: 0x0024CE70 File Offset: 0x0024B070
		public OceanBiome()
		{
			this.<NameKey>k__BackingField = "Ocean";
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x0024CE90 File Offset: 0x0024B090
		public override bool IsInBiome(Player player)
		{
			return player.ZoneBeach;
		}
	}
}
