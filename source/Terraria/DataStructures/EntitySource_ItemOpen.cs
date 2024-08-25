using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200064F RID: 1615
	public class EntitySource_ItemOpen : IEntitySource
	{
		// Token: 0x060036ED RID: 14061 RVA: 0x00220CC4 File Offset: 0x0021EEC4
		public EntitySource_ItemOpen(Entity entity, int itemType)
		{
			this.Entity = entity;
			this.ItemType = itemType;
		}

		// Token: 0x040077FD RID: 30717
		public readonly Entity Entity;

		// Token: 0x040077FE RID: 30718
		public readonly int ItemType;
	}
}
