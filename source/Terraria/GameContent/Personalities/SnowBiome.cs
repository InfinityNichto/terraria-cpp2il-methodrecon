using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x02000834 RID: 2100
	public class SnowBiome : AShoppingBiome
	{
		// Token: 0x060042F8 RID: 17144 RVA: 0x0024CED8 File Offset: 0x0024B0D8
		public SnowBiome()
		{
			this.<NameKey>k__BackingField = "Snow";
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x0024CEF8 File Offset: 0x0024B0F8
		public override bool IsInBiome(Player player)
		{
			return player.ZoneSnow;
		}
	}
}
