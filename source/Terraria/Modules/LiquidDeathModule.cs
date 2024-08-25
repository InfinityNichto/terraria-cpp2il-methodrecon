using System;
using System.Runtime.InteropServices;

namespace Terraria.Modules
{
	// Token: 0x02000548 RID: 1352
	public class LiquidDeathModule
	{
		// Token: 0x060032EB RID: 13035 RVA: 0x001FDF9C File Offset: 0x001FC19C
		public LiquidDeathModule([Optional] LiquidDeathModule copyFrom)
		{
			if (copyFrom != null)
			{
				bool flag = copyFrom.water;
				bool flag2 = copyFrom.lava;
				return;
			}
			long num = 0L;
			long num2 = 0L;
			this.water = num != 0L;
			this.lava = num2 != 0L;
		}

		// Token: 0x04003BE0 RID: 15328
		public bool water;

		// Token: 0x04003BE1 RID: 15329
		public bool lava;
	}
}
