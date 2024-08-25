using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000651 RID: 1617
	public class EntitySource_Mount : IEntitySource
	{
		// Token: 0x060036EF RID: 14063 RVA: 0x00220D10 File Offset: 0x0021EF10
		public EntitySource_Mount(Entity entity, int mountId)
		{
			this.Entity = entity;
			this.MountId = mountId;
		}

		// Token: 0x04007800 RID: 30720
		public readonly Entity Entity;

		// Token: 0x04007801 RID: 30721
		public readonly int MountId;
	}
}
