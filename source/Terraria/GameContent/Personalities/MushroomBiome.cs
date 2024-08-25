using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000839 RID: 2105
	public class MushroomBiome : AShoppingBiome
	{
		// Token: 0x06004302 RID: 17154 RVA: 0x0024CFDC File Offset: 0x0024B1DC
		public MushroomBiome()
		{
			this.<NameKey>k__BackingField = "Mushroom";
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x0024CFFC File Offset: 0x0024B1FC
		public override bool IsInBiome(Player player)
		{
			return player.ZoneGlowshroom;
		}
	}
}
