using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000653 RID: 1619
	public class EntitySource_TileInteraction : AEntitySource_Tile
	{
		// Token: 0x060036F1 RID: 14065 RVA: 0x00220D48 File Offset: 0x0021EF48
		public EntitySource_TileInteraction(Entity entity, int tileCoordsX, int tileCoordsY)
		{
			this.Entity = entity;
		}

		// Token: 0x04007803 RID: 30723
		public readonly Entity Entity;
	}
}
