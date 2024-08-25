using System;
using Terraria.Utilities;

namespace Terraria.GameContent.ItemDropRules
{
	// Token: 0x0200086D RID: 2157
	public struct DropAttemptInfo
	{
		// Token: 0x040081A9 RID: 33193
		public NPC npc;

		// Token: 0x040081AA RID: 33194
		public Player player;

		// Token: 0x040081AB RID: 33195
		public UnifiedRandom rng;

		// Token: 0x040081AC RID: 33196
		public bool IsInSimulation;

		// Token: 0x040081AD RID: 33197
		public bool IsExpertMode;

		// Token: 0x040081AE RID: 33198
		public bool IsMasterMode;
	}
}
