using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008D7 RID: 2263
	public class ShapeBranch : GenShape
	{
		// Token: 0x060045A4 RID: 17828 RVA: 0x002551F8 File Offset: 0x002533F8
		public ShapeBranch()
		{
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x0025520C File Offset: 0x0025340C
		public ShapeBranch(Point offset)
		{
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00255220 File Offset: 0x00253420
		public ShapeBranch(double angle, double distance)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x00255238 File Offset: 0x00253438
		private bool PerformSegment(Point origin, GenAction action, Point start, Point end, int size)
		{
			if (!true)
			{
			}
			int num = Math.Max(1, size);
			bool flag;
			return flag;
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x000021DB File Offset: 0x000003DB
		public override bool Perform(Point origin, GenAction action)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00255254 File Offset: 0x00253454
		public ShapeBranch OutputEndpoints(List<Point> endpoints)
		{
			this._endPoints = endpoints;
			return this;
		}

		// Token: 0x0400820B RID: 33291
		private Point _offset;

		// Token: 0x0400820C RID: 33292
		private List<Point> _endPoints;

		// Token: 0x020008D8 RID: 2264
		[CompilerGenerated]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x060045AA RID: 17834 RVA: 0x0025526C File Offset: 0x0025346C
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x060045AB RID: 17835 RVA: 0x00255280 File Offset: 0x00253480
			internal bool <PerformSegment>b__0(int tileX, int tileY)
			{
				ShapeBranch shapeBranch = this.<>4__this;
				GenAction genAction = this.action;
				Point point = this.origin;
				if (!true)
				{
				}
				return true;
			}

			// Token: 0x0400820D RID: 33293
			public ShapeBranch <>4__this;

			// Token: 0x0400820E RID: 33294
			public GenAction action;

			// Token: 0x0400820F RID: 33295
			public Point origin;

			// Token: 0x04008210 RID: 33296
			public Utils.TileActionAttempt <>9__0;
		}
	}
}
