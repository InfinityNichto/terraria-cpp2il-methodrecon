using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008D3 RID: 2259
	public class ActionVines : GenAction
	{
		// Token: 0x06004599 RID: 17817 RVA: 0x00255058 File Offset: 0x00253258
		public ActionVines(int minLength = 6, int maxLength = 10, int vineId = 52)
		{
			this._minLength = minLength;
			this._vineId = maxLength;
			this._vineId = vineId;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00255080 File Offset: 0x00253280
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			UnifiedRandom random = GenBase._random;
			int minLength = this._minLength;
			int vineId = this._vineId;
			int num = random.Next(minLength, x);
			Tile tile;
			bool flag = tile.active();
			int vineId2 = this._vineId;
			return base.UnitApply(origin, x, y, args);
		}

		// Token: 0x04008203 RID: 33283
		private int _minLength;

		// Token: 0x04008204 RID: 33284
		private int _maxLength;

		// Token: 0x04008205 RID: 33285
		private int _vineId;
	}
}
