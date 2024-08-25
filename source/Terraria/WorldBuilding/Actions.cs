using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200048C RID: 1164
	public static class Actions
	{
		// Token: 0x06002F8F RID: 12175 RVA: 0x001F435C File Offset: 0x001F255C
		public static GenAction Chain(params GenAction[] actions)
		{
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x000021DB File Offset: 0x000003DB
		public static GenAction Continue(GenAction action)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0200048D RID: 1165
		public class ContinueWrapper : GenAction
		{
			// Token: 0x06002F91 RID: 12177 RVA: 0x001F436C File Offset: 0x001F256C
			public ContinueWrapper(GenAction action)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._action = action;
			}

			// Token: 0x06002F92 RID: 12178 RVA: 0x001F4390 File Offset: 0x001F2590
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				GenAction action = this._action;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003976 RID: 14710
			private GenAction _action;
		}

		// Token: 0x0200048E RID: 1166
		public class Count : GenAction
		{
			// Token: 0x06002F93 RID: 12179 RVA: 0x001F43B0 File Offset: 0x001F25B0
			public Count(Ref<int> count)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._count = count;
			}

			// Token: 0x06002F94 RID: 12180 RVA: 0x001F43D4 File Offset: 0x001F25D4
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				Ref<int> count = this._count;
				!0 value = count.Value;
				count.Value = value;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003977 RID: 14711
			private Ref<int> _count;
		}

		// Token: 0x0200048F RID: 1167
		public class Scanner : GenAction
		{
			// Token: 0x06002F95 RID: 12181 RVA: 0x001F4404 File Offset: 0x001F2604
			public Scanner(Ref<int> count)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._count = count;
			}

			// Token: 0x06002F96 RID: 12182 RVA: 0x001F4428 File Offset: 0x001F2628
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				Ref<int> count = this._count;
				!0 value = count.Value;
				count.Value = value;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003978 RID: 14712
			private Ref<int> _count;
		}

		// Token: 0x02000490 RID: 1168
		public class TileScanner : GenAction
		{
			// Token: 0x06002F97 RID: 12183 RVA: 0x001F4458 File Offset: 0x001F2658
			public TileScanner(params ushort[] tiles)
			{
				int num = 1;
				this._returnFalseOnFailure = num != 0;
				base..ctor();
				this._tileIds = tiles;
				ushort[] tileIds = this._tileIds;
				ushort[] tileIds2 = this._tileIds;
				Dictionary<ushort, int> tileCounts = this._tileCounts;
			}

			// Token: 0x06002F98 RID: 12184 RVA: 0x001F4490 File Offset: 0x001F2690
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				bool flag = tile.active();
				Dictionary<ushort, int> tileCounts = this._tileCounts;
				Dictionary<ushort, int> tileCounts2 = this._tileCounts;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06002F99 RID: 12185 RVA: 0x001F44C4 File Offset: 0x001F26C4
			public Actions.TileScanner Output(Dictionary<ushort, int> resultsOutput)
			{
				ushort[] tileIds = this._tileIds;
				this._tileCounts = resultsOutput;
				ushort[] tileIds2 = this._tileIds;
				Dictionary<ushort, int> tileCounts = this._tileCounts;
				ushort[] tileIds3 = this._tileIds;
				Dictionary<ushort, int> tileCounts2 = this._tileCounts;
				return this;
			}

			// Token: 0x06002F9A RID: 12186 RVA: 0x001F4500 File Offset: 0x001F2700
			public Dictionary<ushort, int> GetResults()
			{
				return this._tileCounts;
			}

			// Token: 0x06002F9B RID: 12187 RVA: 0x001F4514 File Offset: 0x001F2714
			public int GetCount(ushort tileId)
			{
				/*
An exception occurred when decompiling this method (06002F9B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.WorldBuilding.Actions/TileScanner::GetCount(System.UInt16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<uint16, int32>(var_0_06, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<uint16, int32>(TileScanner::_tileCounts, ldloc:TileScanner(this)))
	stloc:class [mscorlib]System.Collections.Generic.Dictionary`2<uint16, int32>(var_1_0D, ldfld:class [mscorlib]System.Collections.Generic.Dictionary`2<uint16, int32>(TileScanner::_tileCounts, ldloc:TileScanner(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}

			// Token: 0x04003979 RID: 14713
			private ushort[] _tileIds;

			// Token: 0x0400397A RID: 14714
			private Dictionary<ushort, int> _tileCounts;
		}

		// Token: 0x02000491 RID: 1169
		public class Blank : GenAction
		{
			// Token: 0x06002F9C RID: 12188 RVA: 0x001F4530 File Offset: 0x001F2730
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06002F9D RID: 12189 RVA: 0x001F4548 File Offset: 0x001F2748
			public Blank()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}
		}

		// Token: 0x02000492 RID: 1170
		public class Custom : GenAction
		{
			// Token: 0x06002F9E RID: 12190 RVA: 0x001F4564 File Offset: 0x001F2764
			public Custom(GenBase.CustomPerUnitAction perUnit)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._perUnit = perUnit;
			}

			// Token: 0x06002F9F RID: 12191 RVA: 0x001F4588 File Offset: 0x001F2788
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				GenBase.CustomPerUnitAction perUnit = this._perUnit;
				IntPtr invoke_impl = perUnit.invoke_impl;
				IntPtr method_code = perUnit.method_code;
				IntPtr method = perUnit.method;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400397B RID: 14715
			private GenBase.CustomPerUnitAction _perUnit;
		}

		// Token: 0x02000493 RID: 1171
		public class ClearMetadata : GenAction
		{
			// Token: 0x06002FA0 RID: 12192 RVA: 0x001F45BC File Offset: 0x001F27BC
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				tile.ClearMetadata();
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06002FA1 RID: 12193 RVA: 0x001F45E0 File Offset: 0x001F27E0
			public ClearMetadata()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}
		}

		// Token: 0x02000494 RID: 1172
		public class Clear : GenAction
		{
			// Token: 0x06002FA2 RID: 12194 RVA: 0x001F45FC File Offset: 0x001F27FC
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				tile.ClearEverything();
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06002FA3 RID: 12195 RVA: 0x001F4620 File Offset: 0x001F2820
			public Clear()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}
		}

		// Token: 0x02000495 RID: 1173
		public class ClearTile : GenAction
		{
			// Token: 0x06002FA4 RID: 12196 RVA: 0x001F463C File Offset: 0x001F283C
			public ClearTile(bool frameNeighbors = false)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06002FA5 RID: 12197 RVA: 0x001F4658 File Offset: 0x001F2858
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool frameNeighbors = this._frameNeighbors;
				WorldUtils.ClearTile(x, y, frameNeighbors);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400397C RID: 14716
			private bool _frameNeighbors;
		}

		// Token: 0x02000496 RID: 1174
		public class ClearWall : GenAction
		{
			// Token: 0x06002FA6 RID: 12198 RVA: 0x001F4680 File Offset: 0x001F2880
			public ClearWall(bool frameNeighbors = false)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06002FA7 RID: 12199 RVA: 0x001F469C File Offset: 0x001F289C
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool frameNeighbors = this._frameNeighbors;
				WorldUtils.ClearWall(x, y, frameNeighbors);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400397D RID: 14717
			private bool _frameNeighbors;
		}

		// Token: 0x02000497 RID: 1175
		public class HalfBlock : GenAction
		{
			// Token: 0x06002FA8 RID: 12200 RVA: 0x001F46C4 File Offset: 0x001F28C4
			public HalfBlock(bool value = true)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x001F46E0 File Offset: 0x001F28E0
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				bool value = this._value;
				Tile tile;
				tile.halfBrick(value);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400397E RID: 14718
			private bool _value;
		}

		// Token: 0x02000498 RID: 1176
		public class SetTile : GenAction
		{
			// Token: 0x06002FAA RID: 12202 RVA: 0x001F470C File Offset: 0x001F290C
			public SetTile(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._type = type;
			}

			// Token: 0x06002FAB RID: 12203 RVA: 0x001F4730 File Offset: 0x001F2930
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				ushort type = this._type;
				Tile tile;
				tile.type = type;
				tile.active(true);
				if (this._doFraming)
				{
					bool doNeighborFraming = this._doNeighborFraming;
					WorldUtils.TileFrame(x, y, doNeighborFraming);
				}
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400397F RID: 14719
			private ushort _type;

			// Token: 0x04003980 RID: 14720
			private bool _doFraming;

			// Token: 0x04003981 RID: 14721
			private bool _doNeighborFraming;
		}

		// Token: 0x02000499 RID: 1177
		public class SetTileKeepWall : GenAction
		{
			// Token: 0x06002FAC RID: 12204 RVA: 0x001F4778 File Offset: 0x001F2978
			public SetTileKeepWall(ushort type, bool setSelfFrames = false, bool setNeighborFrames = true)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._type = type;
			}

			// Token: 0x06002FAD RID: 12205 RVA: 0x001F479C File Offset: 0x001F299C
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				Tile tile;
				ushort wall = tile.wall;
				ushort type = this._type;
				if (this._doFraming)
				{
					bool doNeighborFraming = this._doNeighborFraming;
					WorldUtils.TileFrame(x, y, doNeighborFraming);
				}
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003982 RID: 14722
			private ushort _type;

			// Token: 0x04003983 RID: 14723
			private bool _doFraming;

			// Token: 0x04003984 RID: 14724
			private bool _doNeighborFraming;
		}

		// Token: 0x0200049A RID: 1178
		public class DebugDraw : GenAction
		{
			// Token: 0x06002FAE RID: 12206 RVA: 0x001F47E0 File Offset: 0x001F29E0
			public DebugDraw(SpriteBatch spriteBatch, [Optional] Color color)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._spriteBatch = spriteBatch;
			}

			// Token: 0x06002FAF RID: 12207 RVA: 0x001F4804 File Offset: 0x001F2A04
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int num = 1;
				SpriteBatch spriteBatch = this._spriteBatch;
				if (num == 0)
				{
				}
				Vector2 screenPosition = Main.screenPosition;
				Vector2 screenPosition2 = Main.screenPosition;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003985 RID: 14725
			private Color _color;

			// Token: 0x04003986 RID: 14726
			private SpriteBatch _spriteBatch;
		}

		// Token: 0x0200049B RID: 1179
		public class SetSlope : GenAction
		{
			// Token: 0x06002FB0 RID: 12208 RVA: 0x001F483C File Offset: 0x001F2A3C
			public SetSlope(int slope)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._slope = slope;
			}

			// Token: 0x06002FB1 RID: 12209 RVA: 0x001F4860 File Offset: 0x001F2A60
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int slope = this._slope;
				if (!true)
				{
				}
				long num = 0L;
				bool flag = WorldGen.SlopeTile(x, y, slope, num != 0L);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003987 RID: 14727
			private int _slope;
		}

		// Token: 0x0200049C RID: 1180
		public class SetHalfTile : GenAction
		{
			// Token: 0x06002FB2 RID: 12210 RVA: 0x001F4890 File Offset: 0x001F2A90
			public SetHalfTile(bool halfTile)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06002FB3 RID: 12211 RVA: 0x001F48AC File Offset: 0x001F2AAC
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				bool halfTile = this._halfTile;
				Tile tile;
				tile.halfBrick(halfTile);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003988 RID: 14728
			private bool _halfTile;
		}

		// Token: 0x0200049D RID: 1181
		public class SetTileAndWallRainbowPaint : GenAction
		{
			// Token: 0x06002FB4 RID: 12212 RVA: 0x001F48D8 File Offset: 0x001F2AD8
			public SetTileAndWallRainbowPaint()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x001F48F4 File Offset: 0x001F2AF4
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				byte paintIDForPosition = this.GetPaintIDForPosition(x, y);
				if (!true)
				{
				}
				Tile tile;
				tile.color(paintIDForPosition);
				if (!true)
				{
				}
				Tile tile2;
				tile2.wallColor(paintIDForPosition);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06002FB6 RID: 12214 RVA: 0x001F492C File Offset: 0x001F2B2C
			private byte GetPaintIDForPosition(int x, int y)
			{
				/*
An exception occurred when decompiling this method (06002FB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Terraria.WorldBuilding.Actions/SetTileAndWallRainbowPaint::GetPaintIDForPosition(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_0D, call:int32(Math::Max, ldc.i4:int32(1), ldloc:int32(y)))
	stloc:int32(var_2_16, call:int32(Math::Min, ldc.i4:int32(12), ldloc:int32(var_1_0D)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x0200049E RID: 1182
		public class PlaceTile : GenAction
		{
			// Token: 0x06002FB7 RID: 12215 RVA: 0x001F4950 File Offset: 0x001F2B50
			public PlaceTile(ushort type, int style = 0)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._type = type;
				this._style = style;
			}

			// Token: 0x06002FB8 RID: 12216 RVA: 0x001F4978 File Offset: 0x001F2B78
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				ushort type = this._type;
				int style = this._style;
				if (!true)
				{
				}
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003989 RID: 14729
			private ushort _type;

			// Token: 0x0400398A RID: 14730
			private int _style;
		}

		// Token: 0x0200049F RID: 1183
		public class RemoveWall : GenAction
		{
			// Token: 0x06002FB9 RID: 12217 RVA: 0x001F49A4 File Offset: 0x001F2BA4
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				long num = 0L;
				Tile tile;
				tile.wall = (ushort)num;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x06002FBA RID: 12218 RVA: 0x001F49C8 File Offset: 0x001F2BC8
			public RemoveWall()
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}
		}

		// Token: 0x020004A0 RID: 1184
		public class PlaceWall : GenAction
		{
			// Token: 0x06002FBB RID: 12219 RVA: 0x001F49E4 File Offset: 0x001F2BE4
			public PlaceWall(ushort type, bool neighbors = true)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._type = type;
			}

			// Token: 0x06002FBC RID: 12220 RVA: 0x001F4A08 File Offset: 0x001F2C08
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				int num = 1;
				if (num == 0)
				{
				}
				ushort type = this._type;
				Tile tile;
				tile.wall = type;
				if (num == 0)
				{
				}
				int num2 = 1;
				WorldGen.SquareWallFrame(x, y, num2 != 0);
				bool neighbors = this._neighbors;
				if (neighbors)
				{
					if (!neighbors)
					{
					}
					int num3 = 1;
					WorldGen.SquareWallFrame(0, y, num3 != 0);
					int num4 = 1;
					WorldGen.SquareWallFrame(0, y, num4 != 0);
					int num5 = 1;
					WorldGen.SquareWallFrame(x, y, num5 != 0);
					int num6 = 1;
					WorldGen.SquareWallFrame(x, y, num6 != 0);
				}
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400398B RID: 14731
			private ushort _type;

			// Token: 0x0400398C RID: 14732
			private bool _neighbors;
		}

		// Token: 0x020004A1 RID: 1185
		public class SetLiquid : GenAction
		{
			// Token: 0x06002FBD RID: 12221 RVA: 0x001F4A80 File Offset: 0x001F2C80
			public SetLiquid(int type = 0, byte value = 255)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._value = value;
				this._type = type;
			}

			// Token: 0x06002FBE RID: 12222 RVA: 0x001F4AA8 File Offset: 0x001F2CA8
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				int type = this._type;
				Tile tile;
				tile.liquidType(type);
				byte value = this._value;
				tile.liquid = value;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400398D RID: 14733
			private int _type;

			// Token: 0x0400398E RID: 14734
			private byte _value;
		}

		// Token: 0x020004A2 RID: 1186
		public class SwapSolidTile : GenAction
		{
			// Token: 0x06002FBF RID: 12223 RVA: 0x001F4AE0 File Offset: 0x001F2CE0
			public SwapSolidTile(ushort type)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
				this._type = type;
			}

			// Token: 0x06002FC0 RID: 12224 RVA: 0x001F4B04 File Offset: 0x001F2D04
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				if (!true)
				{
				}
				ushort type = this._type;
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x0400398F RID: 14735
			private ushort _type;
		}

		// Token: 0x020004A3 RID: 1187
		public class SetFrames : GenAction
		{
			// Token: 0x06002FC1 RID: 12225 RVA: 0x001F4B34 File Offset: 0x001F2D34
			public SetFrames(bool frameNeighbors = false)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06002FC2 RID: 12226 RVA: 0x001F4B50 File Offset: 0x001F2D50
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool frameNeighbors = this._frameNeighbors;
				WorldUtils.TileFrame(x, y, frameNeighbors);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003990 RID: 14736
			private bool _frameNeighbors;
		}

		// Token: 0x020004A4 RID: 1188
		public class Smooth : GenAction
		{
			// Token: 0x06002FC3 RID: 12227 RVA: 0x001F4B78 File Offset: 0x001F2D78
			public Smooth(bool applyToNeighbors = false)
			{
				this._returnFalseOnFailure = true;
				base..ctor();
			}

			// Token: 0x06002FC4 RID: 12228 RVA: 0x001F4B94 File Offset: 0x001F2D94
			public override bool Apply(Point origin, int x, int y, params object[] args)
			{
				bool applyToNeighbors = this._applyToNeighbors;
				if (!true)
				{
				}
				long num = 0L;
				Tile.SmoothSlope(x, y, x != 0, num != 0L);
				return base.UnitApply(origin, x, y, args);
			}

			// Token: 0x04003991 RID: 14737
			private bool _applyToNeighbors;
		}
	}
}
