using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004C9 RID: 1225
	public static class ModShapes
	{
		// Token: 0x020004CA RID: 1226
		public class All : GenModShape
		{
			// Token: 0x0600301C RID: 12316 RVA: 0x001F5964 File Offset: 0x001F3B64
			public All(ShapeData data)
			{
				this._data = data;
			}

			// Token: 0x0600301D RID: 12317 RVA: 0x001F5980 File Offset: 0x001F3B80
			public override bool Perform(Point origin, GenAction action)
			{
				do
				{
					ShapeData data = this._data;
					HashSet<Point16> points = data._points;
					if (data == null)
					{
					}
				}
				while (!this._quitOnFail);
				bool flag;
				return flag;
			}
		}

		// Token: 0x020004CB RID: 1227
		public class OuterOutline : GenModShape
		{
			// Token: 0x0600301E RID: 12318 RVA: 0x001F59C8 File Offset: 0x001F3BC8
			public OuterOutline(ShapeData data, bool useDiagonals = true, bool useInterior = false)
			{
				this._data = data;
			}

			// Token: 0x0600301F RID: 12319 RVA: 0x001F59E4 File Offset: 0x001F3BE4
			public override bool Perform(Point origin, GenAction action)
			{
				ShapeData data = this._data;
				bool useDiagonals = this._useDiagonals;
				HashSet<Point16> points = data._points;
				bool quitOnFail;
				if (this._useInterior)
				{
					quitOnFail = this._quitOnFail;
					if (quitOnFail)
					{
						bool flag;
						return flag;
					}
				}
				ShapeData data2 = this._data;
				if (!quitOnFail)
				{
				}
				bool flag2;
				if (!this._quitOnFail)
				{
					return flag2;
				}
				return flag2;
			}

			// Token: 0x06003020 RID: 12320 RVA: 0x001F5A6C File Offset: 0x001F3C6C
			// Note: this type is marked as 'beforefieldinit'.
			static OuterOutline()
			{
			}

			// Token: 0x040039C5 RID: 14789
			private static readonly int[] POINT_OFFSETS;

			// Token: 0x040039C6 RID: 14790
			private bool _useDiagonals;

			// Token: 0x040039C7 RID: 14791
			private bool _useInterior;
		}

		// Token: 0x020004CC RID: 1228
		public class InnerOutline : GenModShape
		{
			// Token: 0x06003021 RID: 12321 RVA: 0x001F5A7C File Offset: 0x001F3C7C
			public InnerOutline(ShapeData data, bool useDiagonals = true)
			{
				this._data = data;
			}

			// Token: 0x06003022 RID: 12322 RVA: 0x001F5A98 File Offset: 0x001F3C98
			public override bool Perform(Point origin, GenAction action)
			{
				ShapeData data = this._data;
				HashSet<Point16> points = data._points;
				bool useDiagonals = this._useDiagonals;
				ShapeData data2 = this._data;
				if (data == null)
				{
				}
				bool flag;
				return flag;
			}

			// Token: 0x06003023 RID: 12323 RVA: 0x001F5B00 File Offset: 0x001F3D00
			// Note: this type is marked as 'beforefieldinit'.
			static InnerOutline()
			{
			}

			// Token: 0x040039C8 RID: 14792
			private static readonly int[] POINT_OFFSETS;

			// Token: 0x040039C9 RID: 14793
			private bool _useDiagonals;
		}
	}
}
