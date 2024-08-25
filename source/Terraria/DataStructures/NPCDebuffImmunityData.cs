using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000638 RID: 1592
	public class NPCDebuffImmunityData
	{
		// Token: 0x06003637 RID: 13879 RVA: 0x00212644 File Offset: 0x00210844
		public void ApplyToNPC(NPC npc)
		{
			bool immuneToAllBuffsThatAreNotWhips;
			if (!this.ImmuneToWhips)
			{
				immuneToAllBuffsThatAreNotWhips = this.ImmuneToAllBuffsThatAreNotWhips;
				if (!immuneToAllBuffsThatAreNotWhips)
				{
					goto IL_0032;
				}
			}
			if (!immuneToAllBuffsThatAreNotWhips)
			{
			}
			if (immuneToAllBuffsThatAreNotWhips)
			{
				bool immuneToWhips = this.ImmuneToWhips;
				return;
			}
			bool immuneToAllBuffsThatAreNotWhips2 = this.ImmuneToAllBuffsThatAreNotWhips;
			bool[] buffImmune = npc.buffImmune;
			IL_0032:
			if (this.SpecificallyImmuneTo != null)
			{
				bool[] buffImmune2 = npc.buffImmune;
			}
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00212698 File Offset: 0x00210898
		public NPCDebuffImmunityData()
		{
		}

		// Token: 0x040076F8 RID: 30456
		public bool ImmuneToWhips;

		// Token: 0x040076F9 RID: 30457
		public bool ImmuneToAllBuffsThatAreNotWhips;

		// Token: 0x040076FA RID: 30458
		public int[] SpecificallyImmuneTo;
	}
}
