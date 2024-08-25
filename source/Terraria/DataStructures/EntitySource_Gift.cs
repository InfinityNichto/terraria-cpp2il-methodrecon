using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000662 RID: 1634
	public class EntitySource_Gift : IEntitySource
	{
		// Token: 0x06003700 RID: 14080 RVA: 0x00220EAC File Offset: 0x0021F0AC
		public EntitySource_Gift(Entity entity)
		{
			this.Entity = entity;
		}

		// Token: 0x0400780B RID: 30731
		public readonly Entity Entity;
	}
}
