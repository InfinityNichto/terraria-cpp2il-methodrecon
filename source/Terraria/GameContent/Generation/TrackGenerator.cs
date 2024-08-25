using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation
{
	// Token: 0x020008DC RID: 2268
	public class TrackGenerator
	{
		// Token: 0x060045B4 RID: 17844 RVA: 0x00255534 File Offset: 0x00253734
		public bool Place(Point origin, int minLength, int maxLength)
		{
			if (!true)
			{
			}
			this.CreateTrackStart(origin);
			bool flag = this.FindPath(minLength, maxLength);
			this.PlacePath();
			return true;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00255560 File Offset: 0x00253760
		private void PlacePath()
		{
			int length = this._length;
			int length2 = this._length;
			long num = 0L;
			if (length2 == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num2 = 7;
			if (genRand.Next(num2) != 0)
			{
				int num3 = this.playerHeight;
				return;
			}
			if (length2 == 0)
			{
			}
			UnifiedRandom genRand2 = WorldGen.genRand;
			int num4 = 5;
			int num5 = 9;
			int num6 = genRand2.Next(num4, num5);
			this.playerHeight = num6;
			if (length2 == 0)
			{
			}
			TrackGenerator.TrackHistory[] history = this._history;
			Tile tile;
			ushort wall = tile.wall;
			if (history == null)
			{
			}
			TrackGenerator.TrackHistory[] history2 = this._history;
			Tile tile2;
			ushort wall2 = tile2.wall;
			if (history == null)
			{
			}
			Tile tile3;
			ushort wall3 = tile3.wall;
			if (history == null)
			{
			}
			TrackGenerator.TrackHistory[] history3 = this._history;
			long num7 = 0L;
			Tile tile4;
			ushort type = tile4.type;
			TrackGenerator.TrackHistory[] history4 = this._history;
			if (history3 == null)
			{
			}
			int num8 = 1;
			long num9 = 0L;
			long num10 = 0L;
			long num11 = 0L;
			WorldGen.KillTile(0, (int)num7, num9 != 0L, num10 != 0L, num8 != 0);
			int num12 = this.playerHeight;
			long num13 = 0L;
			if (num12 == 0)
			{
			}
			UnifiedRandom genRand3 = WorldGen.genRand;
			int num14 = 7;
			int num15;
			if (genRand3.Next(num14) == 0)
			{
				if (num12 == 0)
				{
				}
				UnifiedRandom genRand4 = WorldGen.genRand;
				num15 = 5;
				int num16 = 9;
				int num17 = genRand4.Next(num15, num16);
				this.playerHeight = num17;
			}
			TrackGenerator.TrackHistory[] history5 = this._history;
			int num18 = 1;
			long num19 = 0L;
			Tile.SmoothSlope(0, num15, num18 != 0, num19 != 0L);
			int num20 = this.playerHeight;
			int num21 = 1;
			Tile.SmoothSlope(0, num15, num21 != 0, num19 != 0L);
			Tile tile5;
			bool flag = tile5.wire();
			TrackGenerator.TrackHistory[] history6;
			if (num20 != 0 && num13 != 0L)
			{
				history6 = this._history;
				if (history6 == null)
				{
				}
				Tile tile6;
				tile6.ClearEverything();
				if (history6 == null)
				{
				}
				int num22 = 314;
				int num23 = 1;
				int num24 = 1;
				long num25 = 0L;
				bool flag2 = WorldGen.PlaceTile(0, (int)num, num22, num25 != 0L, num23 != 0, (int)num11, num24);
				return;
			}
			if (history6 == null)
			{
			}
			int num26 = 314;
			Tile tile7;
			tile7.ResetToType((ushort)num26);
			Tile tile8;
			tile8.wire(false);
			if (num13 != 0L)
			{
				TrackGenerator.TrackHistory[] history7 = this._history;
				int length3 = this._length;
				int num27 = this.playerHeight;
				int num28 = 1;
				WorldUtils.TileFrame(0, (int)num, num28 != 0);
				int num29 = this.playerHeight;
			}
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00255770 File Offset: 0x00253970
		private void CreateTrackStart(Point origin)
		{
			if (!true)
			{
			}
			int num = 1;
			TrackGenerator.TrackHistory[] history = this._history;
			this.playerHeight = num;
			TrackGenerator.TrackHistory[] history2 = this._history;
			int num2 = 1;
			int xDirection = this._xDirection;
			history2.Slope = (TrackGenerator.TrackSlope)num2;
			history2.X = (short)xDirection;
			TrackGenerator.TrackHistory[] history3 = this._history;
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x002557C0 File Offset: 0x002539C0
		private bool FindPath(int minLength, int maxLength)
		{
			/*
An exception occurred when decompiling this method (060045B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Generation.TrackGenerator::FindPath(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0053:
	stloc:int32(var_9_5B, call:int32(Math::Min, ldloc:int32(maxLength), ldloc:int32(var_5_31)))
	stfld:int32(TrackGenerator::_length, ldloc:TrackGenerator(this), ldloc:int32(var_9_5B))
	call:void(TrackGenerator::SmoothTrack, ldloc:TrackGenerator(this))
	stloc:int32(var_11_74, ldfld:int32(TrackGenerator::_length, ldloc:TrackGenerator(this)))
	stloc:int64(var_12_77, ldc.i4:int64(0))
	stloc:TrackPlacementState(var_13_83, call:TrackPlacementState(TrackGenerator::GetHistorySegmentPlacementState, ldloc:TrackGenerator(this), ldloc:int64[exp:int32](var_12_77), ldloc:int32(var_11_74)))
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

		// Token: 0x060045B8 RID: 17848 RVA: 0x00255854 File Offset: 0x00253A54
		private TrackGenerator.TrackPlacementState CreateTunnel()
		{
			int length = this._length;
			TrackGenerator.TrackHistory[] history = this._history;
			int num = 2;
			int xDirection = this._xDirection;
			if (length == 0)
			{
			}
			while (num == 0)
			{
			}
			TrackGenerator.TrackPlacementState trackPlacementState;
			return trackPlacementState;
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x002558F0 File Offset: 0x00253AF0
		private void AppendToHistory(TrackGenerator.TrackSlope slope, TrackGenerator.TrackMode mode = TrackGenerator.TrackMode.Normal)
		{
			TrackGenerator.TrackHistory[] history = this._history;
			int xDirection = this._xDirection;
			TrackGenerator.TrackHistory[] history2 = this._history;
			this._length = history;
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0025591C File Offset: 0x00253B1C
		private TrackGenerator.TrackPlacementState TryRewriteHistoryToAvoidTiles()
		{
			int length = this._length;
			TrackGenerator.TrackHistory[] rewriteHistory = this._rewriteHistory;
			long num = 0L;
			TrackGenerator.TrackHistory[] history = this._history;
			TrackGenerator.TrackHistory[] rewriteHistory2 = this._rewriteHistory;
			rewriteHistory2.X = history;
			int length2 = this._length;
			TrackGenerator.TrackHistory[] history2 = this._history;
			if (this.GetHistorySegmentPlacementState(43134976, (int)num) == TrackGenerator.TrackPlacementState.Available)
			{
				return;
			}
			TrackGenerator.TrackHistory[] history3 = this._history;
			int length3 = this._length;
			history3.X = rewriteHistory2;
			TrackGenerator.TrackPlacementState historySegmentPlacementState = this.GetHistorySegmentPlacementState(43134976, (int)num);
			if (historySegmentPlacementState != TrackGenerator.TrackPlacementState.Available)
			{
				int length4 = this._length;
				return historySegmentPlacementState;
			}
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00255A2C File Offset: 0x00253C2C
		private void RewriteSlopeDirection(int index, TrackGenerator.TrackSlope slope)
		{
			TrackGenerator.TrackHistory[] history = this._history;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00255A44 File Offset: 0x00253C44
		private TrackGenerator.TrackPlacementState GetHistorySegmentPlacementState(int startIndex, int length)
		{
			TrackGenerator.TrackHistory[] history = this._history;
			return TrackGenerator.CalculateStateForLocation(43134976, startIndex);
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00255A74 File Offset: 0x00253C74
		private void SmoothTrack()
		{
			int length = this._length;
			if (!false)
			{
			}
			int num = Math.Min(0, 43134976);
			TrackGenerator.TrackHistory[] history = this._history;
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00255AA8 File Offset: 0x00253CA8
		private static bool CanSlopesTouch(TrackGenerator.TrackSlope leftSlope, TrackGenerator.TrackSlope rightSlope)
		{
			return true;
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00255AB8 File Offset: 0x00253CB8
		private static bool FindSuitableOrigin(Point origin)
		{
			/*
An exception occurred when decompiling this method (060045BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Generation.TrackGenerator::FindSuitableOrigin(Microsoft.Xna.Framework.Point)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:TrackPlacementState(var_3_21, call:TrackPlacementState(TrackGenerator::CalculateStateForLocation, ldc.i4:int32(0), ldc.i4:int32(43134976)))
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

		// Token: 0x060045C0 RID: 17856 RVA: 0x00255AE8 File Offset: 0x00253CE8
		private static TrackGenerator.TrackPlacementState CalculateStateForLocation(int x, int y)
		{
			/*
An exception occurred when decompiling this method (060045C0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Generation.TrackGenerator/TrackPlacementState Terraria.GameContent.Generation.TrackGenerator::CalculateStateForLocation(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:int64(var_4_1E, ldc.i4:int64(0))
	stloc:bool(var_5_29, call:bool(WorldGen::SolidTile, ldc.i4:int32(0), ldloc:int32(x), ldloc:int64[exp:bool](var_4_1E)))
	stloc:int32(var_7_2F, ldc.i4:int32(2))
	stloc:int32(var_8_36, ldc.i4:int32(314))
	stloc:int32(var_9_3A, ldc.i4:int32(30))
	stloc:bool(var_10_48, call:bool(WorldGen::IsTileNearby, ldloc:int32(var_7_2F), ldloc:int32(x), ldloc:int32(var_8_36), ldloc:int32(var_9_3A)))
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

		// Token: 0x060045C1 RID: 17857 RVA: 0x00255B40 File Offset: 0x00253D40
		private static bool IsMinecartTrack(int x, int y)
		{
			/*
An exception occurred when decompiling this method (060045C1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Generation.TrackGenerator::IsMinecartTrack(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:uint16(var_4_15, callgetter:uint16(Tile::get_type, ldloc:Tile[exp:valuetype Terraria.Tile&](var_3)))
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

		// Token: 0x060045C2 RID: 17858 RVA: 0x00255B68 File Offset: 0x00253D68
		private static bool IsLocationInvalid(int x, int y)
		{
			if (!true)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
			if (!true)
			{
			}
			long num = 32752L;
			int num2 = 32768;
			if (num == 0L)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
			bool flag = WorldGen.oceanDepths(0, x);
			int num3 = 1;
			if (num3 == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (num3 == 0)
			{
			}
			if (num == 0L)
			{
			}
			while (num == 0L)
			{
			}
			return false;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00255C10 File Offset: 0x00253E10
		[Conditional("ENABLE_DEBUG")]
		[Conditional("UNITY_EDITOR")]
		private void DrawPause()
		{
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00255C20 File Offset: 0x00253E20
		public TrackGenerator()
		{
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00255C3C File Offset: 0x00253E3C
		// Note: this type is marked as 'beforefieldinit'.
		static TrackGenerator()
		{
		}

		// Token: 0x0400821A RID: 33306
		private static readonly ushort[] InvalidWalls;

		// Token: 0x0400821B RID: 33307
		private static readonly ushort[] InvalidTiles;

		// Token: 0x0400821C RID: 33308
		private readonly TrackGenerator.TrackHistory[] _history;

		// Token: 0x0400821D RID: 33309
		private readonly TrackGenerator.TrackHistory[] _rewriteHistory;

		// Token: 0x0400821E RID: 33310
		private int _xDirection;

		// Token: 0x0400821F RID: 33311
		private int _length;

		// Token: 0x04008220 RID: 33312
		private int playerHeight = 6;

		// Token: 0x020008DD RID: 2269
		private enum TrackPlacementState
		{
			// Token: 0x04008222 RID: 33314
			Available,
			// Token: 0x04008223 RID: 33315
			Obstructed,
			// Token: 0x04008224 RID: 33316
			Invalid
		}

		// Token: 0x020008DE RID: 2270
		private enum TrackSlope : sbyte
		{
			// Token: 0x04008226 RID: 33318
			Up = -1,
			// Token: 0x04008227 RID: 33319
			Straight,
			// Token: 0x04008228 RID: 33320
			Down
		}

		// Token: 0x020008DF RID: 2271
		private enum TrackMode : byte
		{
			// Token: 0x0400822A RID: 33322
			Normal,
			// Token: 0x0400822B RID: 33323
			Tunnel
		}

		// Token: 0x020008E0 RID: 2272
		[DebuggerDisplay("X = {X}, Y = {Y}, Slope = {Slope}")]
		private struct TrackHistory
		{
			// Token: 0x060045C6 RID: 17862 RVA: 0x00255C4C File Offset: 0x00253E4C
			public TrackHistory(int x, int y, TrackGenerator.TrackSlope slope)
			{
				this.X = (short)x;
				this.Y = (short)y;
				this.Slope = slope;
			}

			// Token: 0x0400822C RID: 33324
			public short X;

			// Token: 0x0400822D RID: 33325
			public short Y;

			// Token: 0x0400822E RID: 33326
			public TrackGenerator.TrackSlope Slope;

			// Token: 0x0400822F RID: 33327
			public TrackGenerator.TrackMode Mode;
		}
	}
}
