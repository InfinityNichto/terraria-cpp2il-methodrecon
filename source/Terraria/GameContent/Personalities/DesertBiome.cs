using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000835 RID: 2101
	public class DesertBiome : AShoppingBiome
	{
		// Token: 0x060042FA RID: 17146 RVA: 0x0024CF0C File Offset: 0x0024B10C
		public DesertBiome()
		{
			this.<NameKey>k__BackingField = "Desert";
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x0024CF2C File Offset: 0x0024B12C
		public override bool IsInBiome(Player player)
		{
			return player.ZoneDesert;
		}
	}
}
