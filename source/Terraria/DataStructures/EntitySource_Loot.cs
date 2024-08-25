using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000663 RID: 1635
	public class EntitySource_Loot : IEntitySource
	{
		// Token: 0x06003701 RID: 14081 RVA: 0x00220EC8 File Offset: 0x0021F0C8
		public EntitySource_Loot(Entity entity)
		{
			this.Entity = entity;
		}

		// Token: 0x0400780C RID: 30732
		public readonly Entity Entity;
	}
}
