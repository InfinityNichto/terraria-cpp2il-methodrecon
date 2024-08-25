using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x0200054A RID: 1354
	public class TileObjectAlternatesModule
	{
		// Token: 0x060032ED RID: 13037 RVA: 0x001FE004 File Offset: 0x001FC204
		public TileObjectAlternatesModule([Optional] TileObjectAlternatesModule copyFrom)
		{
			if (copyFrom != null)
			{
				List<TileObjectData> list = copyFrom.data;
				if (list != null)
				{
					int size = list._size;
					int size2 = copyFrom.data._size;
					return;
				}
			}
		}

		// Token: 0x04003BE4 RID: 15332
		public List<TileObjectData> data;
	}
}
