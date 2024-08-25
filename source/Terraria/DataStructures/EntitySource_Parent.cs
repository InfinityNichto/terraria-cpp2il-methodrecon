using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200064C RID: 1612
	public class EntitySource_Parent : IEntitySource
	{
		// Token: 0x060036EA RID: 14058 RVA: 0x00220C60 File Offset: 0x0021EE60
		public EntitySource_Parent(Entity entity)
		{
			this.Entity = entity;
		}

		// Token: 0x040077F7 RID: 30711
		public readonly Entity Entity;
	}
}
