using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000664 RID: 1636
	public abstract class AEntitySource_OnHit : IEntitySource
	{
		// Token: 0x06003702 RID: 14082 RVA: 0x00220EE4 File Offset: 0x0021F0E4
		public AEntitySource_OnHit(Entity entityStriking, Entity entityStruck)
		{
			this.EntityStriking = entityStriking;
			this.EntityStruck = entityStruck;
		}

		// Token: 0x0400780D RID: 30733
		public readonly Entity EntityStriking;

		// Token: 0x0400780E RID: 30734
		public readonly Entity EntityStruck;
	}
}
