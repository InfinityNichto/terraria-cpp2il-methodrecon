using System;

namespace Terraria
{
	// Token: 0x0200045F RID: 1119
	public struct TileColorCache
	{
		// Token: 0x06002AB7 RID: 10935 RVA: 0x001B2E9C File Offset: 0x001B109C
		public void ApplyToBlock(Tile tile)
		{
			bool fullBright = this.FullBright;
			bool invisible = this.Invisible;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x001B2EB8 File Offset: 0x001B10B8
		public void ApplyToWall(Tile tile)
		{
			bool fullBright = this.FullBright;
			bool invisible = this.Invisible;
		}

		// Token: 0x0400374F RID: 14159
		public byte Color;

		// Token: 0x04003750 RID: 14160
		public bool FullBright;

		// Token: 0x04003751 RID: 14161
		public bool Invisible;
	}
}
