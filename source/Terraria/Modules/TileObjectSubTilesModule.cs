using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Terraria.ObjectData;

namespace Terraria.Modules
{
	// Token: 0x0200054F RID: 1359
	public class TileObjectSubTilesModule
	{
		// Token: 0x060032F2 RID: 13042 RVA: 0x001FE1F0 File Offset: 0x001FC3F0
		public TileObjectSubTilesModule([Optional] TileObjectSubTilesModule copyFrom, [Optional] List<TileObjectData> newData)
		{
			if (copyFrom != null)
			{
				List<TileObjectData> list = copyFrom.data;
				if (list != null)
				{
					int size = list._size;
					List<TileObjectData> list2 = copyFrom.data;
					return;
				}
			}
		}

		// Token: 0x04003C00 RID: 15360
		public List<TileObjectData> data;
	}
}
