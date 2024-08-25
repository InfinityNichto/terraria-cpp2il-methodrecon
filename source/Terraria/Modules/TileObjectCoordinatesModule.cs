using System;
using System.Runtime.InteropServices;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x0200054C RID: 1356
	public class TileObjectCoordinatesModule
	{
		// Token: 0x060032EF RID: 13039 RVA: 0x001FE0AC File Offset: 0x001FC2AC
		public TileObjectCoordinatesModule([Optional] TileObjectCoordinatesModule copyFrom, [Optional] int[] drawHeight)
		{
			int[] array;
			if (copyFrom != null)
			{
				int num = copyFrom.width;
				this.width = num;
				int num2 = copyFrom.padding;
				this.padding = num2;
				Point16 point = copyFrom.paddingFix;
				this.paddingFix = point;
				int num3 = copyFrom.drawStyleOffset;
				this.drawStyleOffset = num3;
				int num4 = copyFrom.styleWidth;
				this.styleWidth = num4;
				bool flag = copyFrom.calculated;
				this.calculated = flag;
				if (drawHeight == null)
				{
					array = copyFrom.heights;
					if (array != null)
					{
						int[] array2 = copyFrom.heights;
						return;
					}
					return;
				}
			}
			else if (array == null)
			{
			}
			this.heights = drawHeight;
		}

		// Token: 0x04003BEC RID: 15340
		public int width;

		// Token: 0x04003BED RID: 15341
		public int[] heights;

		// Token: 0x04003BEE RID: 15342
		public int padding;

		// Token: 0x04003BEF RID: 15343
		public Point16 paddingFix;

		// Token: 0x04003BF0 RID: 15344
		public int styleWidth;

		// Token: 0x04003BF1 RID: 15345
		public int styleHeight;

		// Token: 0x04003BF2 RID: 15346
		public bool calculated;

		// Token: 0x04003BF3 RID: 15347
		public int drawStyleOffset;
	}
}
