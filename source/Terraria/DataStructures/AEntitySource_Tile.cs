using System;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x02000652 RID: 1618
	public abstract class AEntitySource_Tile : IEntitySource
	{
		// Token: 0x060036F0 RID: 14064 RVA: 0x00220D34 File Offset: 0x0021EF34
		public AEntitySource_Tile(int tileCoordsX, int tileCoordsY)
		{
		}

		// Token: 0x04007802 RID: 30722
		public readonly Point TileCoords;
	}
}
