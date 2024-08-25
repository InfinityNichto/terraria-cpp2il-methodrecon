using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000666 RID: 1638
	public class EntitySource_OnHit_ByItemSourceID : AEntitySource_OnHit
	{
		// Token: 0x06003704 RID: 14084 RVA: 0x00220F30 File Offset: 0x0021F130
		public EntitySource_OnHit_ByItemSourceID(Entity entityStriking, Entity entityStruck, int itemSourceId)
		{
			this.EntityStriking = entityStriking;
			this.EntityStruck = entityStruck;
			this.SourceId = itemSourceId;
		}

		// Token: 0x04007810 RID: 30736
		public readonly int SourceId;
	}
}
