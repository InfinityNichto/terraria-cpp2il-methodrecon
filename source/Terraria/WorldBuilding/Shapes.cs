using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004DA RID: 1242
	public static class Shapes
	{
		// Token: 0x020004DB RID: 1243
		public class Circle : GenShape
		{
			// Token: 0x06003043 RID: 12355 RVA: 0x001F5E6C File Offset: 0x001F406C
			public Circle(int radius)
			{
				this._verticalRadius = radius;
			}

			// Token: 0x06003044 RID: 12356 RVA: 0x001F5E88 File Offset: 0x001F4088
			public Circle(int horizontalRadius, int verticalRadius)
			{
				this._verticalRadius = verticalRadius;
			}

			// Token: 0x06003045 RID: 12357 RVA: 0x001F5EA4 File Offset: 0x001F40A4
			public void SetRadius(int radius)
			{
				this._verticalRadius = radius;
			}

			// Token: 0x06003046 RID: 12358 RVA: 0x001F5EB8 File Offset: 0x001F40B8
			public override bool Perform(Point origin, GenAction action)
			{
				int verticalRadius = this._verticalRadius;
				int horizontalRadius = this._horizontalRadius;
				if (verticalRadius == 0)
				{
				}
				if (verticalRadius == 0)
				{
				}
				if (!this._quitOnFail)
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x040039DB RID: 14811
			private int _verticalRadius;

			// Token: 0x040039DC RID: 14812
			private int _horizontalRadius;
		}

		// Token: 0x020004DC RID: 1244
		public class HalfCircle : GenShape
		{
			// Token: 0x06003047 RID: 12359 RVA: 0x001F5EFC File Offset: 0x001F40FC
			public HalfCircle(int radius)
			{
				this._radius = radius;
			}

			// Token: 0x06003048 RID: 12360 RVA: 0x001F5F18 File Offset: 0x001F4118
			public override bool Perform(Point origin, GenAction action)
			{
				int radius = this._radius;
				if (!this._quitOnFail)
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x040039DD RID: 14813
			private int _radius;
		}

		// Token: 0x020004DD RID: 1245
		public class Slime : GenShape
		{
			// Token: 0x06003049 RID: 12361 RVA: 0x001F5F44 File Offset: 0x001F4144
			public Slime(int radius)
			{
				this._radius = radius;
			}

			// Token: 0x0600304A RID: 12362 RVA: 0x001F5F60 File Offset: 0x001F4160
			public Slime(int radius, double xScale, double yScale)
			{
				this._radius = radius;
				this._xScale = xScale;
			}

			// Token: 0x0600304B RID: 12363 RVA: 0x001F5F84 File Offset: 0x001F4184
			public override bool Perform(Point origin, GenAction action)
			{
				int radius = this._radius;
				double yScale = this._yScale;
				int radius2 = this._radius;
				double xScale = this._xScale;
				if (!this._quitOnFail)
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x040039DE RID: 14814
			private int _radius;

			// Token: 0x040039DF RID: 14815
			private double _xScale;

			// Token: 0x040039E0 RID: 14816
			private double _yScale;
		}

		// Token: 0x020004DE RID: 1246
		public class Rectangle : GenShape
		{
			// Token: 0x0600304C RID: 12364 RVA: 0x001F6000 File Offset: 0x001F4200
			public Rectangle(Microsoft.Xna.Framework.Rectangle area)
			{
			}

			// Token: 0x0600304D RID: 12365 RVA: 0x001F6014 File Offset: 0x001F4214
			public Rectangle(int width, int height)
			{
			}

			// Token: 0x0600304E RID: 12366 RVA: 0x001F602C File Offset: 0x001F422C
			public void SetArea(Microsoft.Xna.Framework.Rectangle area)
			{
			}

			// Token: 0x0600304F RID: 12367 RVA: 0x001F603C File Offset: 0x001F423C
			public override bool Perform(Point origin, GenAction action)
			{
				Microsoft.Xna.Framework.Rectangle area = this._area;
				if (this._area.Y == 0)
				{
				}
				if (!this._quitOnFail)
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x040039E1 RID: 14817
			private Microsoft.Xna.Framework.Rectangle _area;
		}

		// Token: 0x020004DF RID: 1247
		public class Tail : GenShape
		{
			// Token: 0x06003050 RID: 12368 RVA: 0x001F606C File Offset: 0x001F426C
			public Tail(double width, Vector2D endOffset)
			{
				this._width = width;
				if (!true)
				{
				}
				this._endOffset.X = width;
			}

			// Token: 0x06003051 RID: 12369 RVA: 0x001F6098 File Offset: 0x001F4298
			public override bool Perform(Point origin, GenAction action)
			{
				double x = this._endOffset.X;
				if (!true)
				{
				}
				double width = this._width;
				if (!true)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x040039E2 RID: 14818
			private double _width;

			// Token: 0x040039E3 RID: 14819
			private Vector2D _endOffset;

			// Token: 0x020004E0 RID: 1248
			[CompilerGenerated]
			private sealed class <>c__DisplayClass3_0
			{
				// Token: 0x06003052 RID: 12370 RVA: 0x00003BB6 File Offset: 0x00001DB6
				public <>c__DisplayClass3_0()
				{
				}

				// Token: 0x06003053 RID: 12371 RVA: 0x001F60C4 File Offset: 0x001F42C4
				internal bool <Perform>b__0(int x, int y)
				{
					return default(bool);
				}

				// Token: 0x040039E4 RID: 14820
				public Shapes.Tail <>4__this;

				// Token: 0x040039E5 RID: 14821
				public GenAction action;

				// Token: 0x040039E6 RID: 14822
				public Point origin;
			}
		}

		// Token: 0x020004E1 RID: 1249
		public class Mound : GenShape
		{
			// Token: 0x06003054 RID: 12372 RVA: 0x001F60DC File Offset: 0x001F42DC
			public Mound(int halfWidth, int height)
			{
				this._halfWidth = halfWidth;
			}

			// Token: 0x06003055 RID: 12373 RVA: 0x001F60F8 File Offset: 0x001F42F8
			public override bool Perform(Point origin, GenAction action)
			{
				int halfWidth = this._halfWidth;
				int height = this._height;
				if (!this._quitOnFail)
				{
					int halfWidth2 = this._halfWidth;
					bool flag;
					return flag;
				}
			}

			// Token: 0x040039E7 RID: 14823
			private int _halfWidth;

			// Token: 0x040039E8 RID: 14824
			private int _height;
		}
	}
}
