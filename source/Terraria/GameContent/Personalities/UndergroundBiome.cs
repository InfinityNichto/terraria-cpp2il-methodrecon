using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000837 RID: 2103
	public class UndergroundBiome : AShoppingBiome
	{
		// Token: 0x060042FE RID: 17150 RVA: 0x0024CF74 File Offset: 0x0024B174
		public UndergroundBiome()
		{
			this.<NameKey>k__BackingField = "NormalUnderground";
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x0024CF94 File Offset: 0x0024B194
		public override bool IsInBiome(Player player)
		{
			return player.ShoppingZone_BelowSurface;
		}
	}
}
