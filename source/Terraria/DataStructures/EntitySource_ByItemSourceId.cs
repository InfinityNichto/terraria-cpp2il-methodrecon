using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000659 RID: 1625
	public class EntitySource_ByItemSourceId : IEntitySource
	{
		// Token: 0x060036F7 RID: 14071 RVA: 0x00220DD8 File Offset: 0x0021EFD8
		public EntitySource_ByItemSourceId(Entity entity, int itemSourceId)
		{
			this.Entity = entity;
			this.SourceId = itemSourceId;
		}

		// Token: 0x04007806 RID: 30726
		public readonly Entity Entity;

		// Token: 0x04007807 RID: 30727
		public readonly int SourceId;
	}
}
