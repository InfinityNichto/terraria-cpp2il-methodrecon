using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000650 RID: 1616
	public class EntitySource_ItemUse_WithAmmo : EntitySource_ItemUse
	{
		// Token: 0x060036EE RID: 14062 RVA: 0x00220CE8 File Offset: 0x0021EEE8
		public EntitySource_ItemUse_WithAmmo(Entity entity, Item item, int ammoItemIdUsed)
		{
			this.Entity = entity;
			this.Item = item;
			this.AmmoItemIdUsed = ammoItemIdUsed;
		}

		// Token: 0x040077FF RID: 30719
		public readonly int AmmoItemIdUsed;
	}
}
