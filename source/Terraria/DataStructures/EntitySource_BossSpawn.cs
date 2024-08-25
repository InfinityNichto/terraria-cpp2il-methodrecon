using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200065F RID: 1631
	public class EntitySource_BossSpawn : IEntitySource
	{
		// Token: 0x060036FD RID: 14077 RVA: 0x00220E60 File Offset: 0x0021F060
		public EntitySource_BossSpawn(Entity entity)
		{
			this.Entity = entity;
		}

		// Token: 0x04007808 RID: 30728
		public readonly Entity Entity;
	}
}
