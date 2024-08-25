using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000836 RID: 2102
	public class JungleBiome : AShoppingBiome
	{
		// Token: 0x060042FC RID: 17148 RVA: 0x0024CF40 File Offset: 0x0024B140
		public JungleBiome()
		{
			this.<NameKey>k__BackingField = "Jungle";
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x0024CF60 File Offset: 0x0024B160
		public override bool IsInBiome(Player player)
		{
			return player.ZoneJungle;
		}
	}
}
