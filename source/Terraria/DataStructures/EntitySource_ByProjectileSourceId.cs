using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000658 RID: 1624
	public class EntitySource_ByProjectileSourceId : IEntitySource
	{
		// Token: 0x060036F6 RID: 14070 RVA: 0x00220DBC File Offset: 0x0021EFBC
		public EntitySource_ByProjectileSourceId(int projectileSourceId)
		{
			this.SourceId = projectileSourceId;
		}

		// Token: 0x04007805 RID: 30725
		public readonly int SourceId;
	}
}
