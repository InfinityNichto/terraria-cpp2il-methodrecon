using System;

namespace Terraria.DataStructures
{
	// Token: 0x0200064D RID: 1613
	public class EntitySource_Buff : IEntitySource
	{
		// Token: 0x060036EB RID: 14059 RVA: 0x00220C7C File Offset: 0x0021EE7C
		public EntitySource_Buff(Entity entity, int buffId, int buffIndex)
		{
			this.Entity = entity;
			this.BuffId = buffId;
		}

		// Token: 0x040077F8 RID: 30712
		public readonly Entity Entity;

		// Token: 0x040077F9 RID: 30713
		public readonly int BuffId;

		// Token: 0x040077FA RID: 30714
		public readonly int BuffIndex;
	}
}
