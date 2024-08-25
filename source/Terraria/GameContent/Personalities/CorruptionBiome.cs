using System;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200083B RID: 2107
	public class CorruptionBiome : AShoppingBiome
	{
		// Token: 0x06004306 RID: 17158 RVA: 0x0024D044 File Offset: 0x0024B244
		public CorruptionBiome()
		{
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x0024D058 File Offset: 0x0024B258
		public override bool IsInBiome(Player player)
		{
			return player.ZoneCorrupt;
		}
	}
}
