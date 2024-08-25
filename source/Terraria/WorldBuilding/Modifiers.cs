using System;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.WorldBuilding
{
	// Token: 0x020004B1 RID: 1201
	public static class Modifiers
	{
		// Token: 0x020004B2 RID: 1202
		public class ShapeScale : GenAction
		{
			// Token: 0x06002FE9 RID: 12265 RVA: 0x001F501C File Offset: 0x001F321C
			public ShapeScale(int scale)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._scale = scale;
			}

			// Token: 0x06002FEA RID: 12266 RVA: 0x001F5040 File Offset: 0x001F3240
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (this._scale == 0)
				{
				}
				int scale = this._scale;
				bool flag;
				return flag;
			}

			// Token: 0x040039A0 RID: 14752
			private int _scale;
		}

		// Token: 0x020004B3 RID: 1203
		public class Expand : GenAction
		{
			// Token: 0x06002FEB RID: 12267 RVA: 0x001F5068 File Offset: 0x001F3268
			public Expand(int expansion)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._xExpansion = expansion;
			}

			// Token: 0x06002FEC RID: 12268 RVA: 0x001F508C File Offset: 0x001F328C
			public Expand(int xExpansion, int yExpansion)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._xExpansion = xExpansion;
			}

			// Token: 0x06002FED RID: 12269 RVA: 0x001F50B0 File Offset: 0x001F32B0
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int xExpansion = this._xExpansion;
				int yExpansion = this._yExpansion;
				bool flag = base.UnitApply(origin, x, y, args);
				int yExpansion2 = this._yExpansion;
				int xExpansion2 = this._xExpansion;
				return flag;
			}

			// Token: 0x040039A1 RID: 14753
			private int _xExpansion;

			// Token: 0x040039A2 RID: 14754
			private int _yExpansion;
		}

		// Token: 0x020004B4 RID: 1204
		public class RadialDither : GenAction
		{
			// Token: 0x06002FEE RID: 12270 RVA: 0x001F50E8 File Offset: 0x001F32E8
			public RadialDither(double innerRadius, double outerRadius)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._innerRadius = innerRadius;
			}

			// Token: 0x06002FEF RID: 12271 RVA: 0x001F510C File Offset: 0x001F330C
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				double innerRadius = this._innerRadius;
				if (!true)
				{
				}
				double num2;
				double num = Math.Max(num2, num2);
				int num3 = GenBase._random.InternalSample();
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039A3 RID: 14755
			private double _innerRadius;

			// Token: 0x040039A4 RID: 14756
			private double _outerRadius;
		}

		// Token: 0x020004B5 RID: 1205
		public class Blotches : GenAction
		{
			// Token: 0x06002FF0 RID: 12272 RVA: 0x001F5160 File Offset: 0x001F3360
			public Blotches(int scale = 2, double chance = 0.3)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._chance = chance;
			}

			// Token: 0x06002FF1 RID: 12273 RVA: 0x001F5184 File Offset: 0x001F3384
			public Blotches(int xScale, int yScale, double chance = 0.3)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._minX = xScale;
				this._maxX = yScale;
				this._maxX = xScale;
				this._chance = chance;
			}

			// Token: 0x06002FF2 RID: 12274 RVA: 0x001F51BC File Offset: 0x001F33BC
			public Blotches(int leftScale, int upScale, int rightScale, int downScale, double chance = 0.3)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._minX = leftScale;
				this._maxX = upScale;
				this._maxX = rightScale;
				this._chance = chance;
			}

			// Token: 0x06002FF3 RID: 12275 RVA: 0x001F51F4 File Offset: 0x001F33F4
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int num = GenBase._random.InternalSample();
				int num2 = GenBase._random.InternalSample();
				double chance = this._chance;
				UnifiedRandom random = GenBase._random;
				int minX = this._minX;
				UnifiedRandom random2 = GenBase._random;
				int maxX = this._maxX;
				long num3 = 0L;
				int num4 = random2.Next((int)num3, maxX);
				UnifiedRandom random3 = GenBase._random;
				int minY = this._minY;
				int num5 = 1;
				int num6 = random3.Next((int)num3, num5);
				UnifiedRandom random4 = GenBase._random;
				int maxY = this._maxY;
				long num7 = 0L;
				int num8 = random4.Next((int)num7, maxY);
				return base.UnitApply(origin, maxY, y, args);
			}

			// Token: 0x040039A5 RID: 14757
			private int _minX;

			// Token: 0x040039A6 RID: 14758
			private int _minY;

			// Token: 0x040039A7 RID: 14759
			private int _maxX;

			// Token: 0x040039A8 RID: 14760
			private int _maxY;

			// Token: 0x040039A9 RID: 14761
			private double _chance;
		}

		// Token: 0x020004B6 RID: 1206
		public class InShape : GenAction
		{
			// Token: 0x06002FF4 RID: 12276 RVA: 0x001F52A4 File Offset: 0x001F34A4
			public InShape(ShapeData shapeData)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._shapeData = shapeData;
			}

			// Token: 0x06002FF5 RID: 12277 RVA: 0x001F52C8 File Offset: 0x001F34C8
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				ShapeData shapeData = this._shapeData;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039AA RID: 14762
			private readonly ShapeData _shapeData;
		}

		// Token: 0x020004B7 RID: 1207
		public class NotInShape : GenAction
		{
			// Token: 0x06002FF6 RID: 12278 RVA: 0x001F52F4 File Offset: 0x001F34F4
			public NotInShape(ShapeData shapeData)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._shapeData = shapeData;
			}

			// Token: 0x06002FF7 RID: 12279 RVA: 0x001F5318 File Offset: 0x001F3518
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				ShapeData shapeData = this._shapeData;
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				bool flag;
				return flag;
			}

			// Token: 0x040039AB RID: 14763
			private readonly ShapeData _shapeData;
		}

		// Token: 0x020004B8 RID: 1208
		public class Conditions : GenAction
		{
			// Token: 0x06002FF8 RID: 12280 RVA: 0x001F5340 File Offset: 0x001F3540
			public Conditions(params GenCondition[] conditions)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._conditions = conditions;
			}

			// Token: 0x06002FF9 RID: 12281 RVA: 0x001F5364 File Offset: 0x001F3564
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int height = this._conditions._height;
				GenCondition[] conditions = this._conditions;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039AC RID: 14764
			private readonly GenCondition[] _conditions;
		}

		// Token: 0x020004B9 RID: 1209
		public class OnlyWalls : GenAction
		{
			// Token: 0x06002FFA RID: 12282 RVA: 0x001F53A0 File Offset: 0x001F35A0
			public OnlyWalls(params ushort[] types)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._types = types;
			}

			// Token: 0x06002FFB RID: 12283 RVA: 0x001F53C4 File Offset: 0x001F35C4
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				ushort[] types = this._types;
				Tile tile;
				ushort wall = tile.wall;
				ushort[] types2 = this._types;
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039AD RID: 14765
			private ushort[] _types;
		}

		// Token: 0x020004BA RID: 1210
		public class OnlyTiles : GenAction
		{
			// Token: 0x06002FFC RID: 12284 RVA: 0x001F53FC File Offset: 0x001F35FC
			public OnlyTiles(params ushort[] types)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._types = types;
			}

			// Token: 0x06002FFD RID: 12285 RVA: 0x001F5420 File Offset: 0x001F3620
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				ushort[] types = this._types;
				Tile tile2;
				ushort type = tile2.type;
				ushort[] types2 = this._types;
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039AE RID: 14766
			private ushort[] _types;
		}

		// Token: 0x020004BB RID: 1211
		public class IsTouching : GenAction
		{
			// Token: 0x06002FFE RID: 12286 RVA: 0x001F5464 File Offset: 0x001F3664
			public IsTouching(bool useDiagonals, params ushort[] tileIds)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._tileIds = tileIds;
			}

			// Token: 0x06002FFF RID: 12287 RVA: 0x001F5488 File Offset: 0x001F3688
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool useDiagonals = this._useDiagonals;
				if (8 == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				ushort[] tileIds = this._tileIds;
				ushort[] tileIds2 = this._tileIds;
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06003000 RID: 12288 RVA: 0x001F54D4 File Offset: 0x001F36D4
			// Note: this type is marked as 'beforefieldinit'.
			static IsTouching()
			{
			}

			// Token: 0x040039AF RID: 14767
			private static readonly int[] DIRECTIONS;

			// Token: 0x040039B0 RID: 14768
			private bool _useDiagonals;

			// Token: 0x040039B1 RID: 14769
			private ushort[] _tileIds;
		}

		// Token: 0x020004BC RID: 1212
		public class NotTouching : GenAction
		{
			// Token: 0x06003001 RID: 12289 RVA: 0x001F54E4 File Offset: 0x001F36E4
			public NotTouching(bool useDiagonals, params ushort[] tileIds)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._tileIds = tileIds;
			}

			// Token: 0x06003002 RID: 12290 RVA: 0x001F5508 File Offset: 0x001F3708
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool useDiagonals = this._useDiagonals;
				if (8 == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				ushort[] tileIds = this._tileIds;
				ushort[] tileIds2 = this._tileIds;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06003003 RID: 12291 RVA: 0x001F5558 File Offset: 0x001F3758
			// Note: this type is marked as 'beforefieldinit'.
			static NotTouching()
			{
			}

			// Token: 0x040039B2 RID: 14770
			private static readonly int[] DIRECTIONS;

			// Token: 0x040039B3 RID: 14771
			private bool _useDiagonals;

			// Token: 0x040039B4 RID: 14772
			private ushort[] _tileIds;
		}

		// Token: 0x020004BD RID: 1213
		public class IsTouchingAir : GenAction
		{
			// Token: 0x06003004 RID: 12292 RVA: 0x001F5568 File Offset: 0x001F3768
			public IsTouchingAir(bool useDiagonals = false)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06003005 RID: 12293 RVA: 0x001F5584 File Offset: 0x001F3784
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool useDiagonals = this._useDiagonals;
				if (8 == 0)
				{
				}
				Tile tile;
				bool flag = tile.active();
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return flag;
			}

			// Token: 0x06003006 RID: 12294 RVA: 0x001F55C0 File Offset: 0x001F37C0
			// Note: this type is marked as 'beforefieldinit'.
			static IsTouchingAir()
			{
			}

			// Token: 0x040039B5 RID: 14773
			private static readonly int[] DIRECTIONS;

			// Token: 0x040039B6 RID: 14774
			private bool _useDiagonals;
		}

		// Token: 0x020004BE RID: 1214
		public class SkipTiles : GenAction
		{
			// Token: 0x06003007 RID: 12295 RVA: 0x001F55D0 File Offset: 0x001F37D0
			public SkipTiles(params ushort[] types)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._types = types;
			}

			// Token: 0x06003008 RID: 12296 RVA: 0x001F55F4 File Offset: 0x001F37F4
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				ushort[] types = this._types;
				Tile tile2;
				ushort type = tile2.type;
				ushort[] types2 = this._types;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039B7 RID: 14775
			private ushort[] _types;
		}

		// Token: 0x020004BF RID: 1215
		public class HasLiquid : GenAction
		{
			// Token: 0x06003009 RID: 12297 RVA: 0x001F5640 File Offset: 0x001F3840
			public HasLiquid(int liquidLevel = -1, int liquidType = -1)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._liquidType = liquidType;
			}

			// Token: 0x0600300A RID: 12298 RVA: 0x001F5664 File Offset: 0x001F3864
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				int liquidType = this._liquidType;
				Tile tile;
				byte b = tile.liquidType();
				int liquidLevel = this._liquidLevel;
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039B8 RID: 14776
			private int _liquidType;

			// Token: 0x040039B9 RID: 14777
			private int _liquidLevel;
		}

		// Token: 0x020004C0 RID: 1216
		public class SkipWalls : GenAction
		{
			// Token: 0x0600300B RID: 12299 RVA: 0x001F56AC File Offset: 0x001F38AC
			public SkipWalls(params ushort[] types)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._types = types;
			}

			// Token: 0x0600300C RID: 12300 RVA: 0x001F56D0 File Offset: 0x001F38D0
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				ushort[] types = this._types;
				Tile tile;
				ushort wall = tile.wall;
				ushort[] types2 = this._types;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039BA RID: 14778
			private ushort[] _types;
		}

		// Token: 0x020004C1 RID: 1217
		public class IsEmpty : GenAction
		{
			// Token: 0x0600300D RID: 12301 RVA: 0x001F5710 File Offset: 0x001F3910
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return flag;
			}

			// Token: 0x0600300E RID: 12302 RVA: 0x001F573C File Offset: 0x001F393C
			public IsEmpty()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}
		}

		// Token: 0x020004C2 RID: 1218
		public class IsSolid : GenAction
		{
			// Token: 0x0600300F RID: 12303 RVA: 0x001F5758 File Offset: 0x001F3958
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				bool flag2 = WorldGen.SolidOrSlopedTile(x, y);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06003010 RID: 12304 RVA: 0x001F5790 File Offset: 0x001F3990
			public IsSolid()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}
		}

		// Token: 0x020004C3 RID: 1219
		public class IsNotSolid : GenAction
		{
			// Token: 0x06003011 RID: 12305 RVA: 0x001F57AC File Offset: 0x001F39AC
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				bool flag2 = WorldGen.SolidOrSlopedTile(x, y);
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return flag2;
			}

			// Token: 0x06003012 RID: 12306 RVA: 0x001F57E0 File Offset: 0x001F39E0
			public IsNotSolid()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}
		}

		// Token: 0x020004C4 RID: 1220
		public class RectangleMask : GenAction
		{
			// Token: 0x06003013 RID: 12307 RVA: 0x001F57FC File Offset: 0x001F39FC
			public RectangleMask(int xMin, int xMax, int yMin, int yMax)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._xMin = xMin;
				this._xMax = yMin;
				this._xMax = xMax;
			}

			// Token: 0x06003014 RID: 12308 RVA: 0x001F582C File Offset: 0x001F3A2C
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int xMin = this._xMin;
				int xMax = this._xMax;
				int yMin = this._yMin;
				int yMax = this._yMax;
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039BB RID: 14779
			private int _xMin;

			// Token: 0x040039BC RID: 14780
			private int _yMin;

			// Token: 0x040039BD RID: 14781
			private int _xMax;

			// Token: 0x040039BE RID: 14782
			private int _yMax;
		}

		// Token: 0x020004C5 RID: 1221
		public class Offset : GenAction
		{
			// Token: 0x06003015 RID: 12309 RVA: 0x001F5868 File Offset: 0x001F3A68
			public Offset(int x, int y)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._xOffset = x;
			}

			// Token: 0x06003016 RID: 12310 RVA: 0x001F588C File Offset: 0x001F3A8C
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int xOffset = this._xOffset;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039BF RID: 14783
			private int _xOffset;

			// Token: 0x040039C0 RID: 14784
			private int _yOffset;
		}

		// Token: 0x020004C6 RID: 1222
		public class Dither : GenAction
		{
			// Token: 0x06003017 RID: 12311 RVA: 0x001F58AC File Offset: 0x001F3AAC
			public Dither(double failureChance = 0.5)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._failureChance = failureChance;
			}

			// Token: 0x06003018 RID: 12312 RVA: 0x001F58D0 File Offset: 0x001F3AD0
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int num = GenBase._random.InternalSample();
				double failureChance = this._failureChance;
				bool returnFalseOnFailure = this._returnFalseOnFailure;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039C1 RID: 14785
			private double _failureChance;
		}

		// Token: 0x020004C7 RID: 1223
		public class Flip : GenAction
		{
			// Token: 0x06003019 RID: 12313 RVA: 0x001F5904 File Offset: 0x001F3B04
			public Flip(bool flipX, bool flipY)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x0600301A RID: 12314 RVA: 0x001F5920 File Offset: 0x001F3B20
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool flipX = this._flipX;
				bool flipY = this._flipY;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x040039C2 RID: 14786
			private bool _flipX;

			// Token: 0x040039C3 RID: 14787
			private bool _flipY;
		}
	}
}
