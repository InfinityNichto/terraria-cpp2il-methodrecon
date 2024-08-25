using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000660 RID: 1632
	public class EntitySource_DropAsItem : IEntitySource
	{
		// Token: 0x060036FE RID: 14078 RVA: 0x00220E7C File Offset: 0x0021F07C
		public EntitySource_DropAsItem(Entity entity)
		{
			this.Entity = entity;
		}

		// Token: 0x04007809 RID: 30729
		public readonly Entity Entity;
	}
}
