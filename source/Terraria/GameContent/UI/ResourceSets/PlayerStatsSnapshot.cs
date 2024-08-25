using System;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x02000A87 RID: 2695
	public struct PlayerStatsSnapshot
	{
		// Token: 0x06004FA6 RID: 20390 RVA: 0x0027AF94 File Offset: 0x00279194
		public PlayerStatsSnapshot(Player player)
		{
			int statLife = player.statLife;
			this.Life = statLife;
			int statMana = player.statMana;
			this.Mana = statMana;
			int statLifeMax = player.statLifeMax2;
			this.LifeMax = statLifeMax;
			int statManaMax = player.statManaMax2;
			this.ManaMax = statManaMax;
		}

		// Token: 0x04008889 RID: 34953
		public int Life;

		// Token: 0x0400888A RID: 34954
		public int LifeMax;

		// Token: 0x0400888B RID: 34955
		public int LifeFruitCount;

		// Token: 0x0400888C RID: 34956
		public float LifePerSegment;

		// Token: 0x0400888D RID: 34957
		public int Mana;

		// Token: 0x0400888E RID: 34958
		public int ManaMax;

		// Token: 0x0400888F RID: 34959
		public float ManaPerSegment;
	}
}
