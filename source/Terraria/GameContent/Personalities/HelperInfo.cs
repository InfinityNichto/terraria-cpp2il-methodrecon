using System;
using System.Collections.Generic;

namespace Terraria.GameContent.Personalities
{
	// Token: 0x0200083F RID: 2111
	public struct HelperInfo
	{
		// Token: 0x04008136 RID: 33078
		public Player player;

		// Token: 0x04008137 RID: 33079
		public NPC npc;

		// Token: 0x04008138 RID: 33080
		public List<NPC> NearbyNPCs;

		// Token: 0x04008139 RID: 33081
		public bool[] nearbyNPCsByType;
	}
}
