using System;

namespace Terraria.DataStructures
{
	// Token: 0x02000654 RID: 1620
	public class EntitySource_OverfullChest : AEntitySource_Tile
	{
		// Token: 0x060036F2 RID: 14066 RVA: 0x00220D64 File Offset: 0x0021EF64
		public EntitySource_OverfullChest(int tileCoordsX, int tileCoordsY, Chest chest)
		{
			this.Chest = chest;
		}

		// Token: 0x04007804 RID: 30724
		public readonly Chest Chest;
	}
}
