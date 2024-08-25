using System;

namespace Terraria
{
	// Token: 0x0200045B RID: 1115
	public class Sign
	{
		// Token: 0x06002A2D RID: 10797 RVA: 0x001B1E64 File Offset: 0x001B0064
		public static void KillSign(int x, int y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x001B1E78 File Offset: 0x001B0078
		public static int ReadSign(int i, int j, bool CreateIfMissing = true)
		{
			if (!true)
			{
			}
			Tile tile;
			short frameX = tile.frameX;
			Tile tile2;
			short frameY = tile2.frameY;
			Tile tile3;
			ushort type = tile3.type;
			return int.MinValue;
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x001B1EE0 File Offset: 0x001B00E0
		public static void TextSign(int i, string text)
		{
			if (!true)
			{
			}
			Tile tile;
			short sTileHeader = tile.sTileHeader;
			Tile tile2;
			ushort type = tile2.type;
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x001B1F00 File Offset: 0x001B0100
		public override string ToString()
		{
			string text;
			string text2;
			if (("x" == null || "x" != null) && (text == null || text != null) && ("\ty" == null || "\ty" != null) && (text2 == null || text2 != null) && ("\t" == null || "\t" != null))
			{
				string text3 = this.text;
				if (text3 == null || text3 != null)
				{
					string text4;
					return text4;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x001B1F5C File Offset: 0x001B015C
		public Sign()
		{
		}

		// Token: 0x0400372E RID: 14126
		public const int maxSigns = 1000;

		// Token: 0x0400372F RID: 14127
		public int x;

		// Token: 0x04003730 RID: 14128
		public int y;

		// Token: 0x04003731 RID: 14129
		public string text;
	}
}
