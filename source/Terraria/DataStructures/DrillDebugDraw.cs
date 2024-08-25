using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000622 RID: 1570
	public struct DrillDebugDraw
	{
		// Token: 0x060035E7 RID: 13799 RVA: 0x00211E08 File Offset: 0x00210008
		public DrillDebugDraw(Vector2 p, Color c)
		{
			this.color = p;
		}

		// Token: 0x040076BE RID: 30398
		public Vector2 point;

		// Token: 0x040076BF RID: 30399
		public Color color;
	}
}
