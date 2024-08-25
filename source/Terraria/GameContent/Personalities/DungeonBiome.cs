using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200083A RID: 2106
	public class DungeonBiome : AShoppingBiome
	{
		// Token: 0x06004304 RID: 17156 RVA: 0x0024D010 File Offset: 0x0024B210
		public DungeonBiome()
		{
			this.<NameKey>k__BackingField = "Dungeon";
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x0024D030 File Offset: 0x0024B230
		public override bool IsInBiome(Player player)
		{
			return player.ZoneDungeon;
		}
	}
}
