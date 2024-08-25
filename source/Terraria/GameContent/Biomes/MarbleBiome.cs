using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x020008F4 RID: 2292
	public class MarbleBiome : MicroBiome
	{
		// Token: 0x0600462F RID: 17967 RVA: 0x0025805C File Offset: 0x0025625C
		private void SmoothSlope(int x, int y)
		{
			MarbleBiome.Slab[,] slabs = this._slabs;
			MarbleBiome.Slab[,] slabs2 = this._slabs;
			MarbleBiome.Slab[,] slabs3 = this._slabs;
			MarbleBiome.Slab[,] slabs4 = this._slabs;
			MarbleBiome.Slab[,] slabs5 = this._slabs;
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x002580A4 File Offset: 0x002562A4
		private void PlaceSlab(MarbleBiome.Slab slab, int originX, int originY, int scale)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 180;
			if (num == 0)
			{
			}
			UnifiedRandom genRand = WorldGen.genRand;
			int num3 = 2;
			if (genRand.Next(num3) != 0)
			{
				if (num == 0)
				{
				}
				UnifiedRandom genRand2 = WorldGen.genRand;
				int num4 = 2;
				int num5 = genRand2.Next(num4);
				if (num2 == 0)
				{
				}
				UnifiedRandom genRand3 = WorldGen.genRand;
				int num6 = 2;
				int num7 = genRand3.Next(num6);
				if (!true)
				{
				}
				int num8 = 1;
				ushort num9;
				WorldUtils.TileFrame((int)num9, (int)num9, num8 != 0);
				int num10 = 1;
				WorldGen.SquareWallFrame(0, (int)num9, num10 != 0);
				int num11 = 1;
				long num12 = 0L;
				Tile.SmoothSlope(1073741824, (int)num9, num11 != 0, num12 != 0L);
				long num13 = 0L;
				bool flag = WorldGen.SolidTile(1073741824, 0, num13 != 0L);
				UnifiedRandom random = GenBase._random;
				int num14 = 4;
				if (random.Next(num14) == 0)
				{
					if (1073741824 == 0)
					{
					}
					long num15 = 0L;
					WorldGen.PlaceTight(0, num14, num15 != 0L);
				}
				if (1073741824 == 0)
				{
				}
				long num16 = 0L;
				bool flag2 = WorldGen.SolidTile(0, num14, num16 != 0L);
				UnifiedRandom random2 = GenBase._random;
				int num17 = 4;
				if (random2.Next(num17) == 0)
				{
					if (1073741824 == 0)
					{
					}
					long num18 = 0L;
					WorldGen.PlaceTight(0, 0, num18 != 0L);
				}
			}
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x002581C8 File Offset: 0x002563C8
		private static bool IsGroupSolid(int x, int y, int scale)
		{
			if (!true)
			{
			}
			return WorldGen.SolidOrSlopedTile(43134976, x);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x002581F0 File Offset: 0x002563F0
		public override bool Place(Point origin, StructureMap structures)
		{
			/*
An exception occurred when decompiling this method (06004632)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.MarbleBiome::Place(Microsoft.Xna.Framework.Point,Terraria.WorldBuilding.StructureMap)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00B3:
	stloc:float64(var_30_C3, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(GenBase::get__random)))
	stloc:int64(var_32_C9, ldc.i4:int64(0))
	stloc:int64(var_33_CC, ldc.i4:int64(0))
	call:void(MarbleBiome::SmoothSlope, ldloc:MarbleBiome(this), ldloc:int64[exp:int32](var_32_C9), ldloc:int64[exp:int32](var_33_CC))
	stloc:float64(var_35_E5, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(GenBase::get__random)))
	stloc:float64(var_37_F4, call:float64(UnifiedRandom::NextDouble, callgetter:UnifiedRandom(GenBase::get__random)))
	stloc:UnifiedRandom(var_39_FE, callgetter:UnifiedRandom(GenBase::get__random))
	stloc:int64(var_40_101, ldc.i4:int64(0))
	stloc:float64(var_41_10A, call:float64(UnifiedRandom::NextDouble, ldloc:UnifiedRandom(var_39_FE)))
	stloc:int32(var_46_11E, call:int32(Math::Min, ldloc:int64[exp:int32](var_20_80), ldloc:int64[exp:int32](var_40_101)))
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

		// Token: 0x06004633 RID: 17971 RVA: 0x00258324 File Offset: 0x00256524
		public MarbleBiome()
		{
		}

		// Token: 0x04008263 RID: 33379
		private const int SCALE = 3;

		// Token: 0x04008264 RID: 33380
		private MarbleBiome.Slab[,] _slabs;

		// Token: 0x020008F5 RID: 2293
		private sealed class SlabState : MulticastDelegate
		{
			// Token: 0x06004634 RID: 17972 RVA: 0x00258338 File Offset: 0x00256538
			public SlabState(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06004635 RID: 17973 RVA: 0x0025838C File Offset: 0x0025658C
			public bool Invoke(int x, int y, int scale)
			{
				/*
An exception occurred when decompiling this method (06004635)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Biomes.MarbleBiome/SlabState::Invoke(System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:SlabState[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:SlabState[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:SlabState[exp:Delegate](this)))
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

			// Token: 0x06004636 RID: 17974 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(int x, int y, int scale, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06004637 RID: 17975 RVA: 0x000021DB File Offset: 0x000003DB
			public bool EndInvoke(IAsyncResult result)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x020008F6 RID: 2294
		private static class SlabStates
		{
			// Token: 0x06004638 RID: 17976 RVA: 0x002583B0 File Offset: 0x002565B0
			public static bool Empty(int x, int y, int scale)
			{
			}

			// Token: 0x06004639 RID: 17977 RVA: 0x002583C0 File Offset: 0x002565C0
			public static bool Solid(int x, int y, int scale)
			{
				return true;
			}

			// Token: 0x0600463A RID: 17978 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool HalfBrick(int x, int y, int scale)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600463B RID: 17979 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool BottomRightFilled(int x, int y, int scale)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600463C RID: 17980 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool BottomLeftFilled(int x, int y, int scale)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600463D RID: 17981 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool TopRightFilled(int x, int y, int scale)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600463E RID: 17982 RVA: 0x000021DB File Offset: 0x000003DB
			public static bool TopLeftFilled(int x, int y, int scale)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x020008F7 RID: 2295
		private struct Slab
		{
			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x0600463F RID: 17983 RVA: 0x002583D0 File Offset: 0x002565D0
			public bool IsSolid
			{
				get
				{
					bool flag;
					return flag;
				}
			}

			// Token: 0x06004640 RID: 17984 RVA: 0x002583E0 File Offset: 0x002565E0
			private Slab(MarbleBiome.SlabState state, bool hasWall)
			{
				this.State = state;
			}

			// Token: 0x06004641 RID: 17985 RVA: 0x002583F4 File Offset: 0x002565F4
			public MarbleBiome.Slab WithState(MarbleBiome.SlabState state)
			{
				/*
An exception occurred when decompiling this method (06004641)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Biomes.MarbleBiome/Slab Terraria.GameContent.Biomes.MarbleBiome/Slab::WithState(Terraria.GameContent.Biomes.MarbleBiome/SlabState)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(Slab::HasWall, ldloc:valuetype Terraria.GameContent.Biomes.MarbleBiome/Slab&(this)))
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

			// Token: 0x06004642 RID: 17986 RVA: 0x000021DB File Offset: 0x000003DB
			public static MarbleBiome.Slab Create(MarbleBiome.SlabState state, bool hasWall)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04008265 RID: 33381
			public readonly MarbleBiome.SlabState State;

			// Token: 0x04008266 RID: 33382
			public readonly bool HasWall;
		}
	}
}
