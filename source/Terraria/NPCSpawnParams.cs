using System;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x0200044C RID: 1100
	public struct NPCSpawnParams
	{
		// Token: 0x06002966 RID: 10598 RVA: 0x0019B5D4 File Offset: 0x001997D4
		public NPCSpawnParams WithScale(float scaleOverride)
		{
			float? num = this.strengthMultiplierOverride;
			NPCSpawnParams npcspawnParams;
			npcspawnParams.sizeScaleOverride = 1;
			npcspawnParams.strengthMultiplierOverride = num;
			return 1;
		}

		// Token: 0x0400367F RID: 13951
		public float? sizeScaleOverride;

		// Token: 0x04003680 RID: 13952
		public int? playerCountForMultiplayerDifficultyOverride;

		// Token: 0x04003681 RID: 13953
		public GameModeData gameModeData;

		// Token: 0x04003682 RID: 13954
		public float? strengthMultiplierOverride;
	}
}
