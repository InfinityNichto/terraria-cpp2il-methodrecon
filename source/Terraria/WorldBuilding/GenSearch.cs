using System;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004D1 RID: 1233
	public abstract class GenSearch : GenBase
	{
		// Token: 0x0600302C RID: 12332 RVA: 0x001F5C04 File Offset: 0x001F3E04
		public GenSearch Conditions(params GenCondition[] conditions)
		{
			this._conditions = conditions;
			return this;
		}

		// Token: 0x0600302D RID: 12333
		public abstract Point Find(Point origin);

		// Token: 0x0600302E RID: 12334 RVA: 0x001F5C1C File Offset: 0x001F3E1C
		protected bool Check(int x, int y)
		{
			GenCondition[] conditions = this._conditions;
			bool requireAll = this._requireAll;
			int height = conditions._height;
			GenCondition[] conditions2 = this._conditions;
			bool requireAll2 = this._requireAll;
			bool flag;
			return flag;
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x001F5C60 File Offset: 0x001F3E60
		public GenSearch RequireAll(bool mode)
		{
			return this;
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x001F5C70 File Offset: 0x001F3E70
		protected GenSearch()
		{
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x001F5C8C File Offset: 0x001F3E8C
		// Note: this type is marked as 'beforefieldinit'.
		static GenSearch()
		{
		}

		// Token: 0x040039CE RID: 14798
		public static Point NOT_FOUND;

		// Token: 0x040039CF RID: 14799
		private bool _requireAll = true;

		// Token: 0x040039D0 RID: 14800
		private GenCondition[] _conditions;
	}
}
