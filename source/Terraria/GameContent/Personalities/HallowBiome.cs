using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000838 RID: 2104
	public class HallowBiome : AShoppingBiome
	{
		// Token: 0x06004300 RID: 17152 RVA: 0x0024CFA8 File Offset: 0x0024B1A8
		public HallowBiome()
		{
			this.<NameKey>k__BackingField = "Hallow";
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x0024CFC8 File Offset: 0x0024B1C8
		public override bool IsInBiome(Player player)
		{
			return player.ZoneHallow;
		}
	}
}
