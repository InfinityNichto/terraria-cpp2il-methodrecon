using System;
using System.Runtime.InteropServices;

namespace Terraria.Modules
{
	// Token: 0x0200054D RID: 1357
	public class TileObjectDrawModule
	{
		// Token: 0x060032F0 RID: 13040 RVA: 0x001FE144 File Offset: 0x001FC344
		public TileObjectDrawModule([Optional] TileObjectDrawModule copyFrom)
		{
			int num;
			if (copyFrom != null)
			{
				num = copyFrom.xOffset;
				bool flag = copyFrom.flipHorizontal;
				bool flag2 = copyFrom.flipVertical;
				int num2 = copyFrom.stepDown;
				return;
			}
			long num3 = 0L;
			long num4 = 0L;
			long num5 = 0L;
			this.xOffset = num;
			this.flipHorizontal = num3 != 0L;
			this.flipVertical = num4 != 0L;
			this.stepDown = (int)num5;
		}

		// Token: 0x04003BF4 RID: 15348
		public int xOffset;

		// Token: 0x04003BF5 RID: 15349
		public int yOffset;

		// Token: 0x04003BF6 RID: 15350
		public bool flipHorizontal;

		// Token: 0x04003BF7 RID: 15351
		public bool flipVertical;

		// Token: 0x04003BF8 RID: 15352
		public int stepDown;
	}
}
