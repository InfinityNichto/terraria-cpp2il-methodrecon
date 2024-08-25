using System;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004C8 RID: 1224
	public abstract class GenModShape : GenShape
	{
		// Token: 0x0600301B RID: 12315 RVA: 0x001F5948 File Offset: 0x001F3B48
		public GenModShape(ShapeData data)
		{
			this._data = data;
		}

		// Token: 0x040039C4 RID: 14788
		protected ShapeData _data;
	}
}
