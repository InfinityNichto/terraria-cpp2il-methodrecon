using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000833 RID: 2099
	public class ForestBiome : AShoppingBiome
	{
		// Token: 0x060042F6 RID: 17142 RVA: 0x0024CEA4 File Offset: 0x0024B0A4
		public ForestBiome()
		{
			this.<NameKey>k__BackingField = "Forest";
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x0024CEC4 File Offset: 0x0024B0C4
		public override bool IsInBiome(Player player)
		{
			return player.ShoppingZone_Forest;
		}
	}
}
