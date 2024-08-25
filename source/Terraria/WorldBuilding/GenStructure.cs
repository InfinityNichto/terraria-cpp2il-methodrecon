using System;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004E2 RID: 1250
	public abstract class GenStructure : GenBase
	{
		// Token: 0x06003056 RID: 12374
		public abstract bool Place(Point origin, StructureMap structures);

		// Token: 0x06003057 RID: 12375 RVA: 0x001F612C File Offset: 0x001F432C
		protected GenStructure()
		{
		}
	}
}
