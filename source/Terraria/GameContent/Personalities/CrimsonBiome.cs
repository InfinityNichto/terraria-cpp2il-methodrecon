using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200083C RID: 2108
	public class CrimsonBiome : AShoppingBiome
	{
		// Token: 0x06004308 RID: 17160 RVA: 0x0024D06C File Offset: 0x0024B26C
		public CrimsonBiome()
		{
			this.<NameKey>k__BackingField = "Crimson";
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x0024D08C File Offset: 0x0024B28C
		public override bool IsInBiome(Player player)
		{
			return player.ZoneCrimson;
		}
	}
}
