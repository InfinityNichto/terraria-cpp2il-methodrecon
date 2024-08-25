using System;
using System.Runtime.InteropServices;
using Terraria.Enums;

namespace Terraria.Modules
{
	// Token: 0x02000549 RID: 1353
	public class LiquidPlacementModule
	{
		// Token: 0x060032EC RID: 13036 RVA: 0x001FDFD4 File Offset: 0x001FC1D4
		public LiquidPlacementModule([Optional] LiquidPlacementModule copyFrom)
		{
			int value__;
			if (copyFrom != null)
			{
				value__ = copyFrom.water.value__;
				return;
			}
			this.water.value__ = value__;
		}

		// Token: 0x04003BE2 RID: 15330
		public LiquidPlacement water;

		// Token: 0x04003BE3 RID: 15331
		public LiquidPlacement lava;
	}
}
