using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x0200080B RID: 2059
	public struct VoidLensHelper
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x00248CB0 File Offset: 0x00246EB0
		public VoidLensHelper(Projectile proj)
		{
			Vector2 center = proj.Center;
			float opacity = proj.Opacity;
			int frame = proj.frame;
			this._frameNumber = frame;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00248CDC File Offset: 0x00246EDC
		public VoidLensHelper(Vector2 worldPosition, float opacity)
		{
			if (!true)
			{
				Vector2 position = this._position;
			}
			int num = 16928;
			this._frameNumber = num;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00248D00 File Offset: 0x00246F00
		public void Update()
		{
			Vector2 position = this._position;
			if (!true)
			{
			}
			this.SpawnVoidLensDust();
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x00248D20 File Offset: 0x00246F20
		public void SpawnVoidLensDust()
		{
			if (!true)
			{
			}
			int num;
			if (num == 0)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				int num2;
				if (num2 != 0)
				{
					Vector2 position = this._position;
					Dust dust;
					dust.noGravity = true;
					dust.noLightEmittence = true;
					Vector2 position2 = this._position;
					return;
				}
				Vector2 position3 = this._position;
				Dust dust2;
				dust2.noGravity = true;
				dust2.noLightEmittence = true;
				Vector2 position4 = this._position;
				dust2.fadeIn = (float)16128;
				float x = dust2.velocity.X;
				float y = dust2.velocity.Y;
				float x2 = dust2.position.X;
				float y2 = dust2.position.Y;
				float x3 = dust2.velocity.X;
				float y3 = dust2.velocity.Y;
				dust2.position.X = x;
				dust2.position.Y = y;
				dust2.velocity.X = x;
				dust2.velocity.Y = y;
			}
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x000021DB File Offset: 0x000003DB
		public void DrawToDrawData(List<DrawData> drawDataList, int selectionMode)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040080A4 RID: 32932
		private readonly Vector2 _position;

		// Token: 0x040080A5 RID: 32933
		private readonly float _opacity;

		// Token: 0x040080A6 RID: 32934
		private readonly int _frameNumber;
	}
}
