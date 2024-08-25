using System;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004D8 RID: 1240
	public struct GenShapeActionPair
	{
		// Token: 0x0600303D RID: 12349 RVA: 0x001F5E00 File Offset: 0x001F4000
		public GenShapeActionPair(GenShape shape, GenAction action)
		{
			this.Shape = shape;
			this.Action = action;
		}

		// Token: 0x040039D7 RID: 14807
		public readonly GenShape Shape;

		// Token: 0x040039D8 RID: 14808
		public readonly GenAction Action;
	}
}
