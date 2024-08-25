using System;
using System.Runtime.InteropServices;
using Terraria.DataStructures;

namespace Terraria.Modules
{
	// Token: 0x02000546 RID: 1350
	public class AnchorDataModule
	{
		// Token: 0x060032E9 RID: 13033 RVA: 0x001FDE90 File Offset: 0x001FC090
		public AnchorDataModule([Optional] AnchorDataModule copyFrom)
		{
			if (copyFrom != null)
			{
				int checkStart = copyFrom.top.checkStart;
				AnchorData anchorData = copyFrom.top;
				this.top.checkStart = checkStart;
				this.top = anchorData;
				int checkStart2 = copyFrom.bottom.checkStart;
				this.bottom.checkStart = checkStart2;
				int checkStart3 = copyFrom.left.checkStart;
				AnchorData anchorData2 = copyFrom.left;
				this.left.checkStart = checkStart3;
				this.left = anchorData2;
				int checkStart4 = copyFrom.right.checkStart;
				this.right.checkStart = checkStart4;
				bool flag = copyFrom.wall;
				return;
			}
			long num = 0L;
			this.wall = num != 0L;
		}

		// Token: 0x04003BD7 RID: 15319
		public AnchorData top;

		// Token: 0x04003BD8 RID: 15320
		public AnchorData bottom;

		// Token: 0x04003BD9 RID: 15321
		public AnchorData left;

		// Token: 0x04003BDA RID: 15322
		public AnchorData right;

		// Token: 0x04003BDB RID: 15323
		public bool wall;
	}
}
