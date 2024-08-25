using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200064E RID: 1614
	public class EntitySource_ItemUse : IEntitySource
	{
		// Token: 0x060036EC RID: 14060 RVA: 0x00220CA0 File Offset: 0x0021EEA0
		public EntitySource_ItemUse(Entity entity, Item item)
		{
			this.Entity = entity;
			this.Item = item;
		}

		// Token: 0x040077FB RID: 30715
		public readonly Entity Entity;

		// Token: 0x040077FC RID: 30716
		public readonly Item Item;
	}
}
