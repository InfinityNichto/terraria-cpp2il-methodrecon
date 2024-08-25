using System;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008D2 RID: 2258
	public class ActionStalagtite : GenAction
	{
		// Token: 0x06004597 RID: 17815 RVA: 0x0025501C File Offset: 0x0025321C
		public override bool Apply(Point origin, int x, int y, params object[] args)
		{
			if (!true)
			{
			}
			long num = 0L;
			WorldGen.PlaceTight(x, y, num != 0L);
			return base.UnitApply(origin, x, y, args);
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00255044 File Offset: 0x00253244
		public ActionStalagtite()
		{
		}
	}
}
