using System;
using System.Runtime.InteropServices;

namespace Terraria.Modules
{
	// Token: 0x0200054E RID: 1358
	public class TileObjectStyleModule
	{
		// Token: 0x060032F1 RID: 13041 RVA: 0x001FE1A0 File Offset: 0x001FC3A0
		public TileObjectStyleModule([Optional] TileObjectStyleModule copyFrom)
		{
			if (copyFrom != null)
			{
				int num = copyFrom.style;
				this.style = num;
				bool flag = copyFrom.horizontal;
				this.horizontal = flag;
				int num2 = copyFrom.styleWrapLimit;
				this.styleWrapLimit = num2;
				int num3 = copyFrom.styleLineSkip;
				this.styleLineSkip = num3;
				return;
			}
		}

		// Token: 0x04003BF9 RID: 15353
		public int style;

		// Token: 0x04003BFA RID: 15354
		public bool horizontal;

		// Token: 0x04003BFB RID: 15355
		public int styleWrapLimit;

		// Token: 0x04003BFC RID: 15356
		public int styleMultiplier;

		// Token: 0x04003BFD RID: 15357
		public int styleLineSkip;

		// Token: 0x04003BFE RID: 15358
		public int? styleWrapLimitVisualOverride;

		// Token: 0x04003BFF RID: 15359
		public int? styleLineSkipVisualoverride;
	}
}
