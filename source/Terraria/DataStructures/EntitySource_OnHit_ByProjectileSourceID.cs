using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000665 RID: 1637
	public class EntitySource_OnHit_ByProjectileSourceID : AEntitySource_OnHit
	{
		// Token: 0x06003703 RID: 14083 RVA: 0x00220F08 File Offset: 0x0021F108
		public EntitySource_OnHit_ByProjectileSourceID(Entity entityStriking, Entity entityStruck, int projectileSourceId)
		{
			this.EntityStriking = entityStriking;
			this.EntityStruck = entityStruck;
			this.SourceId = projectileSourceId;
		}

		// Token: 0x0400780F RID: 30735
		public readonly int SourceId;
	}
}
