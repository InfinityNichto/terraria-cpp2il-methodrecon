using System;

namespace Terraria
{
	// Token: 0x020003F1 RID: 1009
	public class LiquidBuffer
	{
		// Token: 0x06001BB8 RID: 7096 RVA: 0x000A9B48 File Offset: 0x000A7D48
		public static void AddBuffer(int x, int y)
		{
			Tile tile;
			bool flag = tile.checkingLiquid();
			int num = 1;
			Tile tile2;
			tile2.checkingLiquid(num != 0);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x000A9B70 File Offset: 0x000A7D70
		public static void DelBuffer(int l)
		{
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x000A9B80 File Offset: 0x000A7D80
		public LiquidBuffer()
		{
		}

		// Token: 0x040028E6 RID: 10470
		public static int numLiquidBuffer;

		// Token: 0x040028E7 RID: 10471
		public int x;

		// Token: 0x040028E8 RID: 10472
		public int y;
	}
}
