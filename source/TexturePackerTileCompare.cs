using System;
using UnityEngine;

// Token: 0x020002EB RID: 747
public static class TexturePackerTileCompare
{
	// Token: 0x06001153 RID: 4435 RVA: 0x00055CA8 File Offset: 0x00053EA8
	public static TexturePackerTileCompare.CompareResult Compare(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
		return TexturePackerTileCompare.CompareResult.Same;
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00055CBC File Offset: 0x00053EBC
	private static bool CompareIdentical(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00055CD0 File Offset: 0x00053ED0
	private static bool CompareXFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00055CE4 File Offset: 0x00053EE4
	private static bool CompareYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00055CF8 File Offset: 0x00053EF8
	private static bool CompareXYFlip(int tileWidth, int tileHeight, Color32[] src1, Color32[] src2)
	{
	}

	// Token: 0x020002EC RID: 748
	public enum CompareResult
	{
		// Token: 0x04002123 RID: 8483
		NoMatch,
		// Token: 0x04002124 RID: 8484
		Same,
		// Token: 0x04002125 RID: 8485
		XFlip,
		// Token: 0x04002126 RID: 8486
		YFlip,
		// Token: 0x04002127 RID: 8487
		XYFlip
	}
}
