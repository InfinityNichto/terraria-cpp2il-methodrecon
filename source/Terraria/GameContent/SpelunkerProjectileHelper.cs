using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x020007F1 RID: 2033
	public class SpelunkerProjectileHelper
	{
		// Token: 0x06004169 RID: 16745 RVA: 0x00247920 File Offset: 0x00245B20
		public void OnPreUpdateAllProjectiles()
		{
			if (!true)
			{
			}
			int frameCounter = this._frameCounter;
			this._frameCounter = frameCounter;
			HashSet<Point> tilesChecked = this._tilesChecked;
			HashSet<Vector2> positionsChecked = this._positionsChecked;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x0024794C File Offset: 0x00245B4C
		public void AddSpotToCheck(Vector2 spot)
		{
			HashSet<Vector2> positionsChecked = this._positionsChecked;
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x00247964 File Offset: 0x00245B64
		private void CheckSpot(Vector2 Center)
		{
			int num = 32640;
			Rectangle clampBox = this._clampBox;
			if (num == 0)
			{
			}
			Rectangle clampBox2 = this._clampBox;
			int y = this._clampBox.Y;
			int y2 = this._clampBox.Y;
			Tile tile;
			bool flag = tile.active();
			HashSet<Point> tilesChecked = this._tilesChecked;
			int num2;
			if (num2 == 0)
			{
				Dust dust;
				float x = dust.velocity.X;
				float y3 = dust.velocity.Y;
				int num3 = 1;
				dust.noLight = num3 != 0;
			}
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x002479EC File Offset: 0x00245BEC
		public SpelunkerProjectileHelper()
		{
		}

		// Token: 0x04007F03 RID: 32515
		private HashSet<Vector2> _positionsChecked;

		// Token: 0x04007F04 RID: 32516
		private HashSet<Point> _tilesChecked;

		// Token: 0x04007F05 RID: 32517
		private Rectangle _clampBox;

		// Token: 0x04007F06 RID: 32518
		private int _frameCounter;
	}
}
