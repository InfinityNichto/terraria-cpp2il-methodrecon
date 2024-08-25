using System;
using System.Runtime.InteropServices;
using Terraria.DataStructures;
using Terraria.Enums;

namespace Terraria.Modules
{
	// Token: 0x0200054B RID: 1355
	public class TileObjectBaseModule
	{
		// Token: 0x060032EE RID: 13038 RVA: 0x001FE050 File Offset: 0x001FC250
		public TileObjectBaseModule([Optional] TileObjectBaseModule copyFrom)
		{
			int[] array;
			if (copyFrom != null)
			{
				int num = copyFrom.width;
				this.width = num;
				Point16 point = copyFrom.origin;
				this.origin = point;
				bool flag = copyFrom.flattenAnchors;
				this.flattenAnchors = flag;
				array = copyFrom.specificRandomStyles;
				if (array != null)
				{
					int[] array2 = copyFrom.specificRandomStyles;
					return;
				}
			}
			else if (array == null)
			{
			}
		}

		// Token: 0x04003BE5 RID: 15333
		public int width;

		// Token: 0x04003BE6 RID: 15334
		public int height;

		// Token: 0x04003BE7 RID: 15335
		public Point16 origin;

		// Token: 0x04003BE8 RID: 15336
		public TileObjectDirection direction;

		// Token: 0x04003BE9 RID: 15337
		public int randomRange;

		// Token: 0x04003BEA RID: 15338
		public bool flattenAnchors;

		// Token: 0x04003BEB RID: 15339
		public int[] specificRandomStyles;
	}
}
