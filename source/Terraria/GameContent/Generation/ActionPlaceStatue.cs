using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008D1 RID: 2257
	public class ActionPlaceStatue : GenAction
	{
		// Token: 0x06004595 RID: 17813 RVA: 0x00254FBC File Offset: 0x002531BC
		public ActionPlaceStatue(int index = -1)
		{
			this._statueIndex = index;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00254FD8 File Offset: 0x002531D8
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			int num = 1;
			int statueIndex = this._statueIndex;
			if (num == 0)
			{
			}
			int statueIndex2 = this._statueIndex;
			UnifiedRandom random = GenBase._random;
			int num2 = 2;
			int num3 = random.Next(num2, x);
			return base.UnitApply(origin, x, y, args);
		}

		// Token: 0x04008202 RID: 33282
		private int _statueIndex;
	}
}
