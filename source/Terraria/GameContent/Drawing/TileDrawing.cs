using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.Graphics.Light;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x020009E8 RID: 2536
	public class TileDrawing
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06004ACE RID: 19150 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004ACF RID: 19151 RVA: 0x00268274 File Offset: 0x00266474
		private int[] _specialsCount
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x00268284 File Offset: 0x00266484
		private Point[][] _specialPositions
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x00268294 File Offset: 0x00266494
		private void AddSpecialPoint(int x, int y, TileDrawing.TileCounterType type)
		{
			int num = Interlocked.Increment(this._specialsCount);
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x002682B0 File Offset: 0x002664B0
		private Dictionary<Point, int> _displayDollTileEntityPositions
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._displayDollTileEntityPositions;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x002682C8 File Offset: 0x002664C8
		private Dictionary<Point, int> _hatRackTileEntityPositions
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._hatRackTileEntityPositions;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x002682E0 File Offset: 0x002664E0
		private Dictionary<Point, int> _trainingDummyTileEntityPositions
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._trainingDummyTileEntityPositions;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06004AD6 RID: 19158 RVA: 0x002682F8 File Offset: 0x002664F8
		private Dictionary<Point, int> _itemFrameTileEntityPositions
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._itemFrameTileEntityPositions;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06004AD7 RID: 19159 RVA: 0x00268310 File Offset: 0x00266510
		private Dictionary<Point, int> _foodPlatterTileEntityPositions
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._foodPlatterTileEntityPositions;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06004AD8 RID: 19160 RVA: 0x00268328 File Offset: 0x00266528
		private Dictionary<Point, int> _weaponRackTileEntityPositions
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._weaponRackTileEntityPositions;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06004AD9 RID: 19161 RVA: 0x00268340 File Offset: 0x00266540
		private Dictionary<Point, int> _chestPositions
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._chestPositions;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06004ADA RID: 19162 RVA: 0x00268358 File Offset: 0x00266558
		private UnifiedRandom _rand
		{
			get
			{
				ThreadLocal<TileDrawInfo> threadLocal;
				return threadLocal.Value._rand;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06004ADB RID: 19163 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004ADC RID: 19164 RVA: 0x00268370 File Offset: 0x00266570
		private WindGrid _windGrid
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06004ADD RID: 19165 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004ADE RID: 19166 RVA: 0x00268380 File Offset: 0x00266580
		private bool _shouldShowInvisibleBlocks
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06004ADF RID: 19167 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004AE0 RID: 19168 RVA: 0x00268390 File Offset: 0x00266590
		private bool _shouldShowInvisibleBlocks_LastFrame
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06004AE1 RID: 19169 RVA: 0x002683A0 File Offset: 0x002665A0
		private bool[] _tileSolid
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004AE1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean[] Terraria.GameContent.Drawing.TileDrawing::get__tileSolid()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x002683B0 File Offset: 0x002665B0
		private bool[] _tileSolidTop
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004AE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean[] Terraria.GameContent.Drawing.TileDrawing::get__tileSolidTop()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x002683C0 File Offset: 0x002665C0
		private Dust[] _dust
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004AE3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Dust[] Terraria.GameContent.Drawing.TileDrawing::get__dust()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x002683D0 File Offset: 0x002665D0
		private Gore[] _gore
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004AE4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Gore[] Terraria.GameContent.Drawing.TileDrawing::get__gore()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x002683E0 File Offset: 0x002665E0
		public TileDrawing(TilePaintSystemV2 paintSystem)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 34464;
			this._leafFrequency = num2;
			this.cacheSpecialDrawTree = num;
			if (num == 0)
			{
			}
			this._threadManager = num;
			this._martianGlow = num;
			this._meteorGlow = num;
			this._lavaMossGlow = num;
			this._kryptonMossGlow = num;
			this._xenonMossGlow = num;
			this._argonMossGlow = num;
			this._violetMossGlow = num;
			if (num2 == 0)
			{
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			base..ctor();
			this._paintSystem = paintSystem;
			Point[][] specialPositions = this._specialPositions;
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00268514 File Offset: 0x00266714
		public void PreparePaintForTilesOnScreen()
		{
			if (!true)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x0026855C File Offset: 0x0026675C
		public void PrepareForAreaDrawing(int firstTileX, int lastTileX, int firstTileY, int lastTileY, bool prepareLazily)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 1;
			int num3 = 1;
			WorldGen.TileFrame(1073741824, firstTileY, num2 != 0, num3 != 0);
			int num4 = 1;
			Framing.WallFrame(1073741824, firstTileY, num4 != 0);
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x00268590 File Offset: 0x00266790
		public void Update()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (num == 0)
			{
			}
			if (!true)
			{
			}
			this.UpdateLeafFrequency();
			WindGrid windGrid;
			windGrid.Update();
			bool flag = Main.ShouldShowInvisibleWalls();
			Main.sectionManager.SetAllFramedSectionsAsNeedingRefresh();
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x002685E0 File Offset: 0x002667E0
		public void PreDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
		{
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x00268600 File Offset: 0x00266800
		public void PostDrawTiles(bool solidLayer, bool forRenderTargets, bool intoRenderTargets)
		{
			if (!true)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			this.DrawMultiTileVines();
			this.DrawMultiTileGrass();
			this.DrawVoidLenses();
			this.DrawTeleportationPylons();
			this.DrawMasterTrophies();
			this.DrawGrass();
			this.DrawAnyDirectionalGrass();
			this.DrawTrees();
			this.DrawVines();
			this.DrawReverseVines();
			this.DrawEntities_HatRacks();
			this.DrawEntities_DisplayDolls();
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06004AEB RID: 19179 RVA: 0x000021DB File Offset: 0x000003DB
		// (set) Token: 0x06004AEC RID: 19180 RVA: 0x00268668 File Offset: 0x00266868
		public ThreadLocal<TileDrawInfo> _currentTileDrawInfo
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00268678 File Offset: 0x00266878
		private int DrawTilesThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			if (!true)
			{
			}
			SpriteBatch spriteBatch = this._threadManager.DrawThreads.spriteBatch;
			Matrix transform = Main.Transform;
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.RenderThreadInstance[] drawThreads = threadManager.DrawThreads;
			SpriteBatch spriteBatch2 = drawThreads.spriteBatch2;
			Matrix transform2 = Main.Transform;
			if (drawThreads == null)
			{
			}
			if (this._threadManager.DrawThreads == null)
			{
				return;
			}
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x002686D8 File Offset: 0x002668D8
		private void ProcessBatchFinished(int index)
		{
			TileDrawing tileDrawing = this._threadManager.DrawThreads.tileDrawing;
			double treeWindCounter = tileDrawing._treeWindCounter;
			double treeWindCounter2 = tileDrawing._treeWindCounter;
			double grassWindCounter = tileDrawing._grassWindCounter;
			double grassWindCounter2 = tileDrawing._grassWindCounter;
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06004AEF RID: 19183 RVA: 0x00268714 File Offset: 0x00266914
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004AEF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ThreadedRenderManager/BatchProcessCallback Terraria.GameContent.Drawing.TileDrawing::get_ProcessBatchFinishedCallback()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:BatchProcessCallback[exp:bool](TileDrawing::_processBatchFinishedCallback, ldloc:TileDrawing(this)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
			}
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x00268728 File Offset: 0x00266928
		private void MergeDictionary(Dictionary<Point, int> dest, Dictionary<Point, int> src)
		{
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0026874C File Offset: 0x0026694C
		private void WaitDrawThreads(int numThreads)
		{
			if (!true)
			{
			}
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.BatchProcessCallback processBatchFinishedCallback = this.ProcessBatchFinishedCallback;
			threadManager.WaitAndProcess(processBatchFinishedCallback, numThreads);
			ThreadedRenderManager.RenderThreadInstance[] drawThreads = this._threadManager.DrawThreads;
			TileDrawing tileDrawing = drawThreads.tileDrawing;
			Dictionary<Point, int> displayDollTileEntityPositions = this._displayDollTileEntityPositions;
			VertexColors liquidBehindTileColors = tileDrawing.LiquidBehindTileColors2;
			Color bottomLeftColor = tileDrawing.LiquidBehindTileColors2.BottomLeftColor;
			List<DrawData> voidLensData = tileDrawing._voidLensData;
			if (drawThreads == null)
			{
			}
			Matrix transform = Main.Transform;
			Matrix transform2 = Main.Transform;
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x002687C8 File Offset: 0x002669C8
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void DrawTiles(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY, bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			if (!true)
			{
			}
			ThreadLocal<TileDrawInfo> threadLocal;
			TileDrawInfo value = threadLocal.Value;
			if (!true)
			{
			}
			if (!true)
			{
			}
			LightMap lightMap;
			Vector3[] colors = lightMap._colors;
			if (colors != null)
			{
				return;
			}
			if (colors == null)
			{
			}
			value.tileTypeFrameY = colors;
			value.lightColors = colors;
			value.lightMinX = colors;
			int num;
			value.lightMaxX = num;
			int num2;
			value.lightMaxY = num2;
			int <Height>k__BackingField = lightMap.<Height>k__BackingField;
			value.lightMapHeight = <Height>k__BackingField;
			if (<Height>k__BackingField == 0)
			{
			}
			if (!true)
			{
			}
			int lightMaxY = value.lightMaxY;
			int lightMinY = value.lightMinY;
			int lightMapHeight = value.lightMapHeight;
			if (255 == 0)
			{
			}
			int num3 = 1;
			if (num3 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			bool settingsEnabled_TilesSwayInWind = Main.SettingsEnabled_TilesSwayInWind;
			bool notRetro = Lighting.NotRetro;
			SpriteBatch spriteBatch = value.spriteBatch;
			SpriteBatch spriteBatch2 = value.spriteBatch2;
			int num4 = 1;
			if (num4 == 0)
			{
			}
			if (num4 == 0)
			{
			}
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x002694E0 File Offset: 0x002676E0
		public void DrawLiquidBehindTiles(int waterStyleOverride = -1)
		{
			if (!true)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			int num = 1;
			if (num == 0)
			{
			}
			int value = num.m_value;
			if (num == 0)
			{
			}
			ThreadLocal<TileDrawInfo> threadLocal;
			TileDrawInfo value2 = threadLocal.Value;
			LightMap lightMap;
			Vector3[] colors = lightMap._colors;
			if (colors != null)
			{
			}
			value2.lightColors = colors;
			value2.lightMinX = colors;
			int num2;
			value2.lightMaxX = num2;
			int num3;
			value2.lightMaxY = num3;
			int <Height>k__BackingField = lightMap.<Height>k__BackingField;
			value2.lightMapHeight = <Height>k__BackingField;
			if (<Height>k__BackingField == 0)
			{
			}
			if (!true)
			{
			}
			int num4 = 17279;
			value2.tileIndex = num4;
			value2.tilePalIndex = (uint)num4;
			value2.typeCache = (ushort)num4;
			ushort typeCache = value2.typeCache;
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x00269590 File Offset: 0x00267790
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void Draw(bool solidLayer, bool forRenderTargets, bool intoRenderTargets, int waterStyleOverride = -1)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x002696F0 File Offset: 0x002678F0
		private void CrawlToTopOfVineAndAddSpecialPoint(int j, int i)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00269704 File Offset: 0x00267904
		private void CrawlToBottomOfReverseVineAndAddSpecialPoint(int j, int i)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x00269718 File Offset: 0x00267918
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public Texture2D GetTileDrawTexture(TileDrawInfo drawInfo, int worldWidth, [Out] EffectPass pass)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			return 0;
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00269748 File Offset: 0x00267948
		private bool IsVisible(Tile tile)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x0026975C File Offset: 0x0026795C
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public Texture2D GetTileDrawTexture(TileDrawInfo drawInfo, int tileX, int tileY, [Out] EffectPass pass)
		{
			int num = 1;
			ushort typeCache = drawInfo.typeCache;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			return 0;
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x002697A8 File Offset: 0x002679A8
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public Texture2D GetTileDrawTexture(int tileX, int tileY, ushort tileType, short frameX, short frameY, byte tileColor, [Out] EffectPass pass)
		{
			/*
An exception occurred when decompiling this method (06004AFA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D Terraria.GameContent.Drawing.TileDrawing::GetTileDrawTexture(System.Int32,System.Int32,System.UInt16,System.Int16,System.Int16,System.Byte,Microsoft.Xna.Framework.Graphics.EffectPass)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_0_0C, call:int32(TileDrawing::GetTreeBiome, ldloc:int32(tileX), ldloc:int32(tileY), ldloc:int32(tileY), ldloc:uint16[exp:int32](tileType)))
	stloc:int32(var_1_15, call:int32(TileDrawing::GetPalmTreeBiome, ldloc:TileDrawing(this), ldloc:int32(tileX), ldloc:int32(tileY)))
	stloc:int64(var_4_1D, ldc.i4:int64(0))
	stloc:int32(var_5_21, ldc.i4:int32(83))
	stloc:EffectPass(var_6_33, call:EffectPass(TilePaintSystemV2::GetTileEffect, ldfld:TilePaintSystemV2(TileDrawing::_paintSystem, ldloc:TileDrawing(this)), ldloc:int32(var_5_21), ldloc:int64[exp:int32](var_4_1D), ldloc:uint16[exp:int32](tileType)))
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

		// Token: 0x06004AFB RID: 19195 RVA: 0x002697EC File Offset: 0x002679EC
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, [Out] EffectPass pass)
		{
			/*
An exception occurred when decompiling this method (06004AFB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D Terraria.GameContent.Drawing.TileDrawing::GetTileDrawTexture(Terraria.Tile,System.Int32,System.Int32,Microsoft.Xna.Framework.Graphics.EffectPass)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_5_0C, call:int32(TileDrawing::GetTreeBiome, ldloc:int32(tileX), ldloc:int32(tileY), ldloc:int32(tileX), ldloc:int32(tileY)))
	stloc:int32(var_6_16, call:int32(TileDrawing::GetPalmTreeBiome, ldloc:TileDrawing(this), ldloc:int32(tileX), ldloc:int32(tileY)))
	stloc:int32(var_10_1D, ldc.i4:int32(84))
	stloc:int64(var_11_20, ldc.i4:int64(0))
	stloc:EffectPass(var_13_32, call:EffectPass(TilePaintSystemV2::GetTileEffect, ldfld:TilePaintSystemV2(TileDrawing::_paintSystem, ldloc:TileDrawing(this)), ldloc:int32(var_10_1D), ldloc:int64[exp:int32](var_11_20), ldloc:int32(tileY)))
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

		// Token: 0x06004AFC RID: 19196 RVA: 0x0026982C File Offset: 0x00267A2C
		private Texture2D GetTileDrawTexture(Tile tile, int tileX, int tileY, int paintOverride, [Out] EffectPass pass)
		{
			/*
An exception occurred when decompiling this method (06004AFC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D Terraria.GameContent.Drawing.TileDrawing::GetTileDrawTexture(Terraria.Tile,System.Int32,System.Int32,System.Int32,Microsoft.Xna.Framework.Graphics.EffectPass)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:int32(var_5_0C, call:int32(TileDrawing::GetTreeBiome, ldloc:int32(tileX), ldloc:int32(tileY), ldloc:int32(tileX), ldloc:int32(tileY)))
	stloc:int32(var_6_16, call:int32(TileDrawing::GetPalmTreeBiome, ldloc:TileDrawing(this), ldloc:int32(tileX), ldloc:int32(tileY)))
	stloc:int32(var_10_1D, ldc.i4:int32(84))
	stloc:int64(var_11_20, ldc.i4:int64(0))
	stloc:EffectPass(var_12_33, call:EffectPass(TilePaintSystemV2::GetTileEffect, ldfld:TilePaintSystemV2(TileDrawing::_paintSystem, ldloc:TileDrawing(this)), ldloc:int32(var_10_1D), ldloc:int64[exp:int32](var_11_20), ldloc:int32(paintOverride)))
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

		// Token: 0x06004AFD RID: 19197 RVA: 0x00269870 File Offset: 0x00267A70
		private int GetPalmTreeBiome(TileDrawInfo drawInfo, int worldWidth)
		{
			/*
An exception occurred when decompiling this method (06004AFD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Drawing.TileDrawing::GetPalmTreeBiome(Terraria.DataStructures.TileDrawInfo,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0027:
	brtrue(IL_0000, ldfld:int32[exp:bool](Rectangle::Width, ldfld:Rectangle[exp:valuetype Microsoft.Xna.Framework.Rectangle&](TileDrawInfo::glowSourceRect, ldloc:TileDrawInfo(drawInfo))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x002698B0 File Offset: 0x00267AB0
		private int GetPalmTreeBiome(int tileX, int tileY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			if (num == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
			int num2;
			return num2;
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x002698D8 File Offset: 0x00267AD8
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private unsafe int GetTreeBiome(TileDrawInfo drawInfo, int worldWidth)
		{
			int tileIndex = drawInfo.tileIndex;
			ushort typeCache = drawInfo.typeCache;
			short tileFrameX = drawInfo.tileFrameX;
			uint* tileLookup = drawInfo.tileLookup;
			short* tileTypeSHeader = drawInfo.tileTypeSHeader;
			ushort* tileTypeData = drawInfo.tileTypeData;
			if (typeCache == 0)
			{
			}
			return 4;
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x00269920 File Offset: 0x00267B20
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private static int GetTreeBiome(int tileX, int tileY, int tileFrameX, int tileFrameY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num == 0)
			{
			}
			Tile tile2;
			bool flag = tile2.active();
			if (num == 0)
			{
			}
			Tile tile3;
			ushort type2 = tile3.type;
			if (num == 0)
			{
			}
			return TileDrawing.GetTreeVariant(0, tileX);
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x00269968 File Offset: 0x00267B68
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public static int GetTreeVariant(int x, int y)
		{
			if (!true)
			{
			}
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			return 4;
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x00269998 File Offset: 0x00267B98
		private TileDrawing.TileFlameData GetTileFlameData(int tileX, int tileY, int type, int tileFrameY)
		{
			/*
An exception occurred when decompiling this method (06004B02)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.GameContent.Drawing.TileDrawing/TileFlameData Terraria.GameContent.Drawing.TileDrawing::GetTileFlameData(System.Int32,System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0045:
	stloc:int16(var_8_4C, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_7)))
	stloc:int16(var_14_64, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_13)))
	stloc:int16(var_16_6D, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_15)))
	stloc:int16(var_18_76, callgetter:int16(Tile::get_frameY, ldloc:Tile[exp:valuetype Terraria.Tile&](var_17)))
	stloc:int64(var_38_C2, ldc.i4:int64(0))
	stloc:int32(var_63_11F, ldc.i4:int32(7))
	stfld:Texture2D(TileFlameData::flameTexture, ldloc:TileFlameData[exp:valuetype Terraria.GameContent.Drawing.TileDrawing/TileFlameData&](var_0), ldloc:int32[exp:Texture2D](type))
	stfld:int32(TileFlameData::flameCount, ldloc:TileFlameData[exp:valuetype Terraria.GameContent.Drawing.TileDrawing/TileFlameData&](var_0), ldloc:int32(var_63_11F))
	stfld:int32(TileFlameData::flameRangeXMin, ldloc:TileFlameData[exp:valuetype Terraria.GameContent.Drawing.TileDrawing/TileFlameData&](var_0), ldloc:int64[exp:int32](var_38_C2))
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

		// Token: 0x06004B03 RID: 19203 RVA: 0x00269B38 File Offset: 0x00267D38
		private void DrawSingleTile_Flames(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			if (!true)
			{
			}
			if (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
			if (32640 == 0)
			{
			}
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0026AB88 File Offset: 0x00268D88
		private int GetPalmTreeVariant(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004B04)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Drawing.TileDrawing::GetPalmTreeVariant(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0067:
	stloc:bool(var_18_6D, call:bool(WorldGen::IsPalmOasisTree, ldloc:int32(x)))
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

		// Token: 0x06004B05 RID: 19205 RVA: 0x0026AC04 File Offset: 0x00268E04
		private void DrawXmasTree(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			if (true)
			{
				return;
			}
			Tile tile;
			short frameX = tile.frameX;
			long num = 0L;
			Tile tile2;
			short frameY = tile2.frameY;
			Color color = Lighting.GetColor(1073741824, (int)num);
			if (frameY != 0)
			{
			}
			int num2 = 66;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 == 0)
			{
			}
			int num3 = 66;
			if (num3 == 0)
			{
			}
			int value2 = num3.m_value;
			if (num3 == 0)
			{
			}
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x0026ACFC File Offset: 0x00268EFC
		private void DrawTile_MinecartTrack(Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (32640 == 0)
			{
			}
			int num2 = 32640;
			if (num2 == 0)
			{
			}
			Rectangle sourceRect = Minecart.GetSourceRect(int.MinValue, 0);
			int num3 = 36;
			long num4 = 0L;
			Rectangle sourceRect2 = Minecart.GetSourceRect(num3, (int)num4);
			int num5 = 36;
			long num6 = 0L;
			Rectangle sourceRect3 = Minecart.GetSourceRect(num5, (int)num6);
			if (num2 == 0)
			{
			}
			bool flag = Minecart.DrawRightDecoration(int.MinValue);
			int num7 = 37;
			long num8 = 0L;
			Rectangle sourceRect4 = Minecart.GetSourceRect(num7, (int)num8);
			bool flag2 = Minecart.DrawBumper(int.MinValue);
			int num9 = 39;
			long num10 = 0L;
			Rectangle sourceRect5 = Minecart.GetSourceRect(num9, (int)num10);
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x0026ADEC File Offset: 0x00268FEC
		private void DrawTile_LiquidBehindTile(bool solidLayer, bool inFrontOfPlayers, int waterStyleOverride, Vector2 screenPosition, Vector2 screenOffset, int tileX, int tileY, TileDrawInfo drawData)
		{
			if (solidLayer)
			{
				return;
			}
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x0026AFB4 File Offset: 0x002691B4
		private void CacheSpecialDraws(int tileX, int tileY, ushort typeCache, short tileFrameX, short tileFrameY)
		{
			if (this.cacheSpecialDrawTree != null)
			{
			}
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x0026B024 File Offset: 0x00269224
		private static Color GetFinalLight(TileDrawInfo tileDrawInfo, ushort typeCache, Color tileLight)
		{
			/*
An exception occurred when decompiling this method (06004B09)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Drawing.TileDrawing::GetFinalLight(Terraria.DataStructures.TileDrawInfo,System.UInt16,Microsoft.Xna.Framework.Graphics.Color)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8*(var_0_06, ldfld:uint8*(TileDrawInfo::tileTypeBHeader3, ldloc:TileDrawInfo(tileDrawInfo)))
	stloc:uint32(var_1_0D, ldfld:uint32(TileDrawInfo::tilePalIndex, ldloc:TileDrawInfo(tileDrawInfo)))
	stloc:int16(var_2_14, ldfld:int16(TileDrawInfo::tileSHeader, ldloc:TileDrawInfo(tileDrawInfo)))
	stloc:int16(var_3_1B, ldfld:int16(TileDrawInfo::tileFrameX, ldloc:TileDrawInfo(tileDrawInfo)))
	stloc:bool(var_4_23, call:bool(TileDrawing::ShouldTileShine, ldloc:uint16(typeCache), ldloc:int16(var_3_1B)))
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

		// Token: 0x06004B0A RID: 19210 RVA: 0x0026B058 File Offset: 0x00269258
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private static bool ShouldTileShine(ushort type, short frameX)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x0026B078 File Offset: 0x00269278
		private static bool IsTileDangerous(Player localPlayer, short sTileHeader, ushort typeCache, short tileFrameX)
		{
			/*
An exception occurred when decompiling this method (06004B0B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Drawing.TileDrawing::IsTileDangerous(Terraria.Player,System.Int16,System.UInt16,System.Int16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0010:
	brtrue(IL_0000, ldloc:int64[exp:bool](var_1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x0026B09C File Offset: 0x0026929C
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		private bool IsTileDrawLayerSolid(ushort typeCache)
		{
			/*
An exception occurred when decompiling this method (06004B0C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.GameContent.Drawing.TileDrawing::IsTileDrawLayerSolid(System.UInt16)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x0026B0B0 File Offset: 0x002692B0
		private void GetTileOutlineInfo(int x, int y, ushort typeCache, Color tileLight, Texture2D highlightTexture, Color highlightColor)
		{
			if (!true)
			{
			}
			bool flag = Main.InSmartCursorHighlightArea(int.MinValue, y, y != 0);
			byte r = tileLight.R;
			byte b = tileLight.B;
			if (r == 0)
			{
			}
			Color color;
			highlightColor.A = color;
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x0026B0E8 File Offset: 0x002692E8
		private void DrawPartialLiquid(SpriteBatch spriteBatch, bool behindBlocks, TileDrawInfo tileCache, Vector2 position, Rectangle liquidSize, int liquidType, VertexColors colors)
		{
			int num = 1;
			spriteBatch.BatchDefferedHeadInsert = num != 0;
			short tileSHeader = tileCache.tileSHeader;
			if (tileSHeader != 0)
			{
				return;
			}
			ushort typeCache = tileCache.typeCache;
			if (tileSHeader != 0)
			{
				return;
			}
			if (tileSHeader == 0)
			{
			}
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x0026B11C File Offset: 0x0026931C
		private bool InAPlaceWithWind(int x, int y, int width, int height)
		{
			if (!true)
			{
			}
			return WorldGen.InAPlaceWithWind(x, x, y, height);
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x0026B138 File Offset: 0x00269338
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private void GetTileDrawData(int x, int y, TileDrawInfo tileCache, ushort typeCache, short tileFrameX, short tileFrameY, [Out] int tileWidth, [Out] int tileHeight, [Out] int tileTop, [Out] int halfBrickHeight, [Out] int addFrX, [Out] int addFrY, [Out] SpriteEffects tileSpriteEffect, [Out] Texture2D glowTexture, [Out] Rectangle glowSourceRect, [Out] Color glowColor)
		{
			int num = 16;
			tileWidth.m_value = num;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x0026B8B4 File Offset: 0x00269AB4
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private void GetTileDrawData(int x, int y, bool halfBrick, ushort typeCache, short tileFrameX, short tileFrameY, [Out] int tileWidth, [Out] int tileHeight, [Out] int tileTop, [Out] int halfBrickHeight, [Out] int addFrX, [Out] int addFrY, [Out] SpriteEffects tileSpriteEffect, [Out] Texture2D glowTexture, [Out] Rectangle glowSourceRect, [Out] Color glowColor)
		{
			int num = 16;
			tileWidth.m_value = num;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x0026C04C File Offset: 0x0026A24C
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		private void GetTileDrawData(int x, int y, Tile tileCache, ushort typeCache, short tileFrameX, short tileFrameY, [Out] int tileWidth, [Out] int tileHeight, [Out] int tileTop, [Out] int halfBrickHeight, [Out] int addFrX, [Out] int addFrY, [Out] SpriteEffects tileSpriteEffect, [Out] Texture2D glowTexture, [Out] Rectangle glowSourceRect, [Out] Color glowColor)
		{
			int num = 16;
			tileWidth.m_value = num;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x0026C854 File Offset: 0x0026AA54
		private bool IsWindBlocked(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Tile tile;
			ushort wall = tile.wall;
			if (num == 0)
			{
			}
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x000021DB File Offset: 0x000003DB
		private int GetWaterAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x000021DB File Offset: 0x000003DB
		private int GetSmallAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x000021DB File Offset: 0x000003DB
		private int GetBigAnimalCageFrame(int x, int y, int tileFrameX, int tileFrameY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x0026C878 File Offset: 0x0026AA78
		private void GetScreenDrawArea(Vector2 screenPosition, Vector2 offSet, [Out] int firstTileX, [Out] int lastTileX, [Out] int firstTileY, [Out] int lastTileY)
		{
			int num = 15744;
			screenPosition.X = (float)num;
			if (num == 0)
			{
			}
			int screenWidth = Main.screenWidth;
			int num2 = 15744;
			int num3 = 32640;
			offSet.X = (float)num2;
			firstTileX.m_value = num2;
			int screenHeight = Main.screenHeight;
			lastTileX.m_value = num2;
			int num4 = 4;
			screenPosition.X = (float)num4;
			if (num4 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			offSet.X = (float)num4;
			int num5 = 4;
			firstTileX.m_value = num5;
			if (num5 == 0)
			{
			}
			if (num3 == 0)
			{
			}
			lastTileX.m_value = num5;
			if (num5 == 0)
			{
			}
			bool anyUnfinishedSections = Main.sectionManager.AnyUnfinishedSections;
			TimeLogger.DetailedDrawReset();
			if (num5 == 0)
			{
			}
			TimeLogger.DetailedDrawTime(5);
			if (num5 == 0)
			{
			}
			bool anyNeedRefresh = Main.sectionManager.AnyNeedRefresh;
			if (num5 == 0)
			{
			}
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x0026C93C File Offset: 0x0026AB3C
		public void ClearCachedTileDraws(bool solidLayer)
		{
			Dictionary<Point, int> displayDollTileEntityPositions = this._displayDollTileEntityPositions;
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x0026C954 File Offset: 0x0026AB54
		private void AddSpecialLegacyPoint(Point p)
		{
			int[] specialTileX = this._specialTileX;
			int[] specialTileY = this._specialTileY;
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x0026C970 File Offset: 0x0026AB70
		private void AddSpecialLegacyPoint(int x, int y)
		{
			int[] specialTileX = this._specialTileX;
			int[] specialTileY = this._specialTileY;
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x0026C98C File Offset: 0x0026AB8C
		private void ClearLegacyCachedDraws()
		{
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x0026C99C File Offset: 0x0026AB9C
		private Color DrawTiles_GetLightOverride(int j, int i, short sTileHeader, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight, bool fullBrightBlock)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num2 = 17269;
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
				return;
			}
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x0026C9CC File Offset: 0x0026ABCC
		private void DrawTiles_EmitParticles(int j, int i, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight)
		{
			if (!true)
			{
			}
			byte bheader = TileData.GetBHeader3(1073741824);
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x0026D468 File Offset: 0x0026B668
		private void EmitLivingTreeLeaf(int i, int j, int leafGoreType)
		{
			this.EmitLivingTreeLeaf_Below(i, j, leafGoreType);
			if (this._rand.Next(2) != 0)
			{
				return;
			}
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x0026D490 File Offset: 0x0026B690
		private void EmitLivingTreeLeaf_Below(int x, int y, int leafGoreType)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x0026D4CC File Offset: 0x0026B6CC
		private void EmitLivingTreeLeaf_Sideways(int x, int y, int leafGoreType)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x0026D520 File Offset: 0x0026B720
		private void EmitLiquidDrops(int j, int i, byte liquid, ushort typeCache)
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0026D5E0 File Offset: 0x0026B7E0
		private float GetWindCycle(int x, int y, double windCounter)
		{
			if (!true)
			{
			}
			bool settingsEnabled_TilesSwayInWind = Main.SettingsEnabled_TilesSwayInWind;
			if (!true)
			{
			}
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0026D600 File Offset: 0x0026B800
		private bool ShouldSwayInWind(int x, int y, ushort tileType, short frameX)
		{
			int num = 1;
			if (num == 0)
			{
			}
			bool settingsEnabled_TilesSwayInWind = Main.SettingsEnabled_TilesSwayInWind;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x0026D628 File Offset: 0x0026B828
		private void UpdateLeafFrequency()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._leafFrequency = 10;
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x0026D6C4 File Offset: 0x0026B8C4
		private void EnsureWindGridSize()
		{
			if (!true)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			if (!true)
			{
			}
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x0026D6E8 File Offset: 0x0026B8E8
		private void EmitTreeLeaves(int tilePosX, int tilePosY, int grassPosX, int grassPosY)
		{
			bool isActiveAndNotPaused = this._isActiveAndNotPaused;
			if (isActiveAndNotPaused)
			{
				if (!isActiveAndNotPaused)
				{
				}
				Tile tile;
				byte liquid = tile.liquid;
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x0026D7B0 File Offset: 0x0026B9B0
		private void DrawSpecialTilesLegacy(Vector2 screenPosition, Vector2 offSet)
		{
			int specialTilesCount = this._specialTilesCount;
			int num = 8;
			int[] specialTileX = this._specialTileX;
			int[] specialTileY = this._specialTileY;
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (specialTileX == null)
			{
			}
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x0026D97C File Offset: 0x0026BB7C
		private void DrawEntities_DisplayDolls()
		{
			if (!true)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			int key = TileEntity.GetKey(-1073741824, 43134976);
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x0026D9D0 File Offset: 0x0026BBD0
		private void DrawEntities_HatRacks()
		{
			if (!true)
			{
			}
			SamplerState defaultSamplerState = Main.DefaultSamplerState;
			Matrix transform = Main.Transform;
			int key = TileEntity.GetKey(43134976, 1073741824);
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x0026DA24 File Offset: 0x0026BC24
		private void DrawTrees()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x0026DC34 File Offset: 0x0026BE34
		private Texture2D GetTreeTopTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, [Out] EffectPass pass)
		{
			/*
An exception occurred when decompiling this method (06004B2B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D Terraria.GameContent.Drawing.TileDrawing::GetTreeTopTexture(System.Int32,System.Int32,System.Byte,Microsoft.Xna.Framework.Graphics.EffectPass)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:EffectPass(var_0_11, call:EffectPass(TilePaintSystemV2::GetTreeTopEffect, ldfld:TilePaintSystemV2(TileDrawing::_paintSystem, ldloc:TileDrawing(this)), ldloc:int32(treeTextureIndex), ldloc:int32(treeTextureStyle), ldloc:uint8[exp:int32](tileColor)))
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

		// Token: 0x06004B2C RID: 19244 RVA: 0x0026DC54 File Offset: 0x0026BE54
		private Texture2D GetTreeBranchTexture(int treeTextureIndex, int treeTextureStyle, byte tileColor, [Out] EffectPass pass)
		{
			/*
An exception occurred when decompiling this method (06004B2C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Texture2D Terraria.GameContent.Drawing.TileDrawing::GetTreeBranchTexture(System.Int32,System.Int32,System.Byte,Microsoft.Xna.Framework.Graphics.EffectPass)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:EffectPass(var_0_11, call:EffectPass(TilePaintSystemV2::GetTreeBranchEffect, ldfld:TilePaintSystemV2(TileDrawing::_paintSystem, ldloc:TileDrawing(this)), ldloc:int32(treeTextureIndex), ldloc:int32(treeTextureStyle), ldloc:uint8[exp:int32](tileColor)))
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

		// Token: 0x06004B2D RID: 19245 RVA: 0x0026DC74 File Offset: 0x0026BE74
		private void DrawGrass()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			UnifiedRandom rand = this._rand;
			int num3 = 4;
			int num4 = rand.Next(num3);
			Color color = Lighting.GetColor(1073741824, num3);
			long num5 = 0L;
			bool isActiveAndNotPaused = this._isActiveAndNotPaused;
			bool flag2 = this.IsAlchemyPlantHarvestable((int)num5);
			if (!isActiveAndNotPaused)
			{
			}
			double grassWindCounter = this._grassWindCounter;
			if (!isActiveAndNotPaused)
			{
			}
			Texture2D texture2D;
			Color color2;
			if (texture2D == null || color2 != null)
			{
			}
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x0026DD18 File Offset: 0x0026BF18
		private void DrawAnyDirectionalGrass()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int num3 = 32640;
			if (num2 == 0)
			{
			}
			Tile tile;
			bool flag = tile.active();
			int num4 = 4;
			UnifiedRandom unifiedRandom;
			int num5 = unifiedRandom.Next(num4);
			if (num3 == 0)
			{
			}
			Color color = Lighting.GetColor(1073741824, num4);
			long num6 = 0L;
			bool isActiveAndNotPaused = this._isActiveAndNotPaused;
			bool flag2 = this.IsAlchemyPlantHarvestable((int)num6);
			if (!isActiveAndNotPaused)
			{
			}
			if (!isActiveAndNotPaused)
			{
			}
			double grassWindCounter = this._grassWindCounter;
			if (!isActiveAndNotPaused)
			{
			}
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x0026DDC4 File Offset: 0x0026BFC4
		private void DrawAnimatedTile_AdjustForVisionChangers(int i, int j, short tileSHeader, ushort typeCache, short tileFrameX, short tileFrameY, Color tileLight, bool canDoDust)
		{
			Player localPlayer = this._localPlayer;
			if (localPlayer.dangerSense)
			{
				bool flag = TileDrawing.IsTileDangerous(localPlayer, tileSHeader, typeCache, tileFrameX);
				bool isActiveAndNotPaused = this._isActiveAndNotPaused;
				int num = 30;
				UnifiedRandom unifiedRandom;
				if (unifiedRandom.Next(num) == 0)
				{
					if (true)
					{
						return;
					}
					if (!true)
					{
					}
					float x = localPlayer.position.X;
					int num2 = 1;
					if (num2 != 0)
					{
						return;
					}
					if (!true)
					{
					}
				}
			}
			bool findTreasure = this._localPlayer.findTreasure;
			if (findTreasure)
			{
				if (!findTreasure)
				{
				}
				bool flag2 = Main.IsTileSpelunkable(typeCache, tileFrameX, tileFrameY);
				if (this._isActiveAndNotPaused)
				{
					int num3 = 60;
					UnifiedRandom unifiedRandom2;
					if (unifiedRandom2.Next(num3) == 0)
					{
						if (true)
						{
							return;
						}
						int num4 = 1;
						if (num4 == 0)
						{
						}
						if (num4 == 0)
						{
						}
						if (!true)
						{
						}
					}
				}
			}
			bool biomeSight = this._localPlayer.biomeSight;
			if (biomeSight)
			{
				if (!biomeSight)
				{
				}
				if (!biomeSight)
				{
				}
				if (this._isActiveAndNotPaused)
				{
					int num5 = 480;
					UnifiedRandom unifiedRandom3;
					if (unifiedRandom3.Next(num5) == 0)
					{
						if (true)
						{
							return;
						}
						return;
					}
				}
			}
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x0026DEE4 File Offset: 0x0026C0E4
		private float GetWindGridPush(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame)
		{
			/*
An exception occurred when decompiling this method (06004B30)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Drawing.TileDrawing::GetWindGridPush(System.Int32,System.Int32,System.Int32,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:WindGrid(var_0_06, callgetter:WindGrid(TileDrawing::get__windGrid, ldloc:TileDrawing(this)))
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

		// Token: 0x06004B31 RID: 19249 RVA: 0x0026DEF8 File Offset: 0x0026C0F8
		private void GetWindGridPush2Axis(int i, int j, int pushAnimationTimeTotal, float pushForcePerFrame, [Out] float pushX, [Out] float pushY)
		{
			WindGrid windGrid = this._windGrid;
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x0026DF0C File Offset: 0x0026C10C
		private float GetWindGridPushComplex(int i, int j, int pushAnimationTimeTotal, float totalPushForce, int loops, bool flipDirectionPerLoop)
		{
			/*
An exception occurred when decompiling this method (06004B32)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Drawing.TileDrawing::GetWindGridPushComplex(System.Int32,System.Int32,System.Int32,System.Single,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:WindGrid(var_0_06, callgetter:WindGrid(TileDrawing::get__windGrid, ldloc:TileDrawing(this)))
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

		// Token: 0x06004B33 RID: 19251 RVA: 0x0026DF28 File Offset: 0x0026C128
		private void DrawMasterTrophies()
		{
			Tile tile;
			bool flag = tile.active();
			if (4855 == 0)
			{
			}
			Rectangle rectangle;
			Vector2 vector = rectangle.Size();
			if (17024 == 0)
			{
			}
			long num = 0L;
			Color color = Lighting.GetColor(1719664640, (int)num);
			Vector2 screenPosition = Main.screenPosition;
			Vector2 screenPosition2 = Main.screenPosition;
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x0026DF90 File Offset: 0x0026C190
		private void DrawTeleportationPylons()
		{
			Tile tile;
			bool flag = tile.active();
			if (4855 == 0)
			{
			}
			Rectangle rectangle;
			Vector2 vector = rectangle.Size();
			short num;
			if (num == 0)
			{
			}
			int num2 = 49696;
			int num3 = 4;
			UnifiedRandom unifiedRandom;
			int num4 = unifiedRandom.Next(num3);
			int num5 = 10;
			UnifiedRandom unifiedRandom2;
			if (unifiedRandom2.Next(num5) == 0)
			{
				if (num2 == 0)
				{
				}
				Vector2 vector2 = rectangle.Size();
				Rectangle rectangle2;
				TeleportPylonsSystem.SpawnInWorldDust(0, rectangle2);
			}
			Vector2 screenPosition = Main.screenPosition;
			Vector2 screenPosition2 = Main.screenPosition;
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x000021DB File Offset: 0x000003DB
		private void DrawVoidLenses()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x0026E050 File Offset: 0x0026C250
		private void DrawMultiTileGrass()
		{
			if (!true)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			Tile tile;
			bool flag = tile.active();
			Tile tile2;
			ushort type = tile2.type;
			Tile tile3;
			short frameY = tile3.frameY;
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x0026E0A4 File Offset: 0x0026C2A4
		private int ClimbCatTail(int originx, int originy)
		{
			/*
An exception occurred when decompiling this method (06004B37)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Drawing.TileDrawing::ClimbCatTail(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0007:
	stloc:bool(var_3_0D, call:bool(Tile::active, ldloc:Tile[exp:valuetype Terraria.Tile&](var_2)))
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

		// Token: 0x06004B38 RID: 19256 RVA: 0x0026E0C0 File Offset: 0x0026C2C0
		private void DrawMultiTileVines()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			Tile tile;
			bool flag = tile.active();
			if (num2 == 0)
			{
			}
			Tile tile2;
			ushort type = tile2.type;
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x0026E110 File Offset: 0x0026C310
		private void DrawVines()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Camera camera = Main.Camera;
			Vector2 unscaledPosition = camera.UnscaledPosition;
			if (num == 0)
			{
			}
			if (false)
			{
			}
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x0026E140 File Offset: 0x0026C340
		private void DrawReverseVines()
		{
			int num = 1;
			if (num == 0)
			{
			}
			Vector2 unscaledPosition = Main.Camera.UnscaledPosition;
			if (num == 0)
			{
			}
			int num2 = 1;
			if (num2 == 0)
			{
			}
			int value = num2.m_value;
			if (false)
			{
			}
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x0026E178 File Offset: 0x0026C378
		private void DrawMultiTileGrassInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
		{
			int num = 1;
			double sunflowerWindCounter = this._sunflowerWindCounter;
			int num2 = 32640;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			Tile tile;
			ushort type = tile.type;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x0026E1EC File Offset: 0x0026C3EC
		private void DrawVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
		{
			if (8 == 0)
			{
			}
			if (!true)
			{
			}
			double vineWindCounter = this._vineWindCounter;
			int num = 255;
			LightMap lightMap;
			if (lightMap._colors != null && num != 0)
			{
				return;
			}
			int <Height>k__BackingField = lightMap.<Height>k__BackingField;
			if (num == 0)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x0026E2B4 File Offset: 0x0026C4B4
		private void DrawRisingVineStrip(Vector2 screenPosition, Vector2 offSet, int x, int startY)
		{
			if (8 == 0)
			{
			}
			if (!true)
			{
			}
			double vineWindCounter = this._vineWindCounter;
			Tile tile;
			ushort type = tile.type;
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x0026E2FC File Offset: 0x0026C4FC
		private float GetAverageWindGridPush(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame)
		{
			/*
An exception occurred when decompiling this method (06004B3E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Drawing.TileDrawing::GetAverageWindGridPush(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int64(var_0_01, ldc.i4:int64(0))
	brtrue(IL_0000, logicnot:bool(ldloc:int64[exp:bool](var_0_01)))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x0026E310 File Offset: 0x0026C510
		private float GetHighestWindGridPushComplex(int topLeftX, int topLeftY, int sizeX, int sizeY, int totalPushTime, float pushForcePerFrame, int loops, bool swapLoopDir)
		{
			/*
An exception occurred when decompiling this method (06004B3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Drawing.TileDrawing::GetHighestWindGridPushComplex(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Single,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(WindGrid::GetWindTime, callgetter:WindGrid(TileDrawing::get__windGrid, ldloc:TileDrawing(this)), ldloc:int32(topLeftX), ldloc:int32(topLeftY), ldloc:int32(totalPushTime), ldloc:int32(sizeY), ldloc:int32(totalPushTime), ldloc:int32(loops))
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

		// Token: 0x06004B40 RID: 19264 RVA: 0x0026E334 File Offset: 0x0026C534
		private void DrawMultiTileVinesInWind(Vector2 screenPosition, Vector2 offSet, int topLeftX, int topLeftY, int sizeX, int sizeY)
		{
			double sunflowerWindCounter = this._sunflowerWindCounter;
			Tile tile;
			ushort type = tile.type;
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x0026E3D4 File Offset: 0x0026C5D4
		private void EmitAlchemyHerbParticles(int j, int i, int style)
		{
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x0026E598 File Offset: 0x0026C798
		private bool IsAlchemyPlantHarvestable(int style)
		{
			if (style == 0)
			{
			}
			if (style == 0)
			{
			}
			if (style == 0)
			{
				if (style == 0)
				{
				}
				return;
			}
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x0026E5B4 File Offset: 0x0026C7B4
		// Note: this type is marked as 'beforefieldinit'.
		static TileDrawing()
		{
		}

		// Token: 0x04008552 RID: 34130
		public const int MAX_SPECIALS = 9000;

		// Token: 0x04008553 RID: 34131
		private const int MAX_SPECIALS_LEGACY = 1000;

		// Token: 0x04008554 RID: 34132
		private const float FORCE_FOR_MIN_WIND = 0.08f;

		// Token: 0x04008555 RID: 34133
		private const float FORCE_FOR_MAX_WIND = 1.2f;

		// Token: 0x04008556 RID: 34134
		private bool[] cacheSpecialDrawTree;

		// Token: 0x04008557 RID: 34135
		private int _leafFrequency;

		// Token: 0x04008558 RID: 34136
		private object specialLock;

		// Token: 0x04008559 RID: 34137
		private int _specialTilesCount;

		// Token: 0x0400855A RID: 34138
		private int[] _specialTileX;

		// Token: 0x0400855B RID: 34139
		private int[] _specialTileY;

		// Token: 0x0400855C RID: 34140
		private object _specialLock;

		// Token: 0x0400855D RID: 34141
		private double _treeWindCounter;

		// Token: 0x0400855E RID: 34142
		private double _grassWindCounter;

		// Token: 0x0400855F RID: 34143
		private double _sunflowerWindCounter;

		// Token: 0x04008560 RID: 34144
		private double _vineWindCounter;

		// Token: 0x04008561 RID: 34145
		private TilePaintSystemV2 _paintSystem;

		// Token: 0x04008562 RID: 34146
		private ThreadedRenderManager _threadManager;

		// Token: 0x04008563 RID: 34147
		private Color _martianGlow;

		// Token: 0x04008564 RID: 34148
		private Color _meteorGlow;

		// Token: 0x04008565 RID: 34149
		private Color _lavaMossGlow;

		// Token: 0x04008566 RID: 34150
		private Color _kryptonMossGlow;

		// Token: 0x04008567 RID: 34151
		private Color _xenonMossGlow;

		// Token: 0x04008568 RID: 34152
		private Color _argonMossGlow;

		// Token: 0x04008569 RID: 34153
		private Color _violetMossGlow;

		// Token: 0x0400856A RID: 34154
		private bool _isActiveAndNotPaused;

		// Token: 0x0400856B RID: 34155
		private Player _localPlayer;

		// Token: 0x0400856C RID: 34156
		private Color _highQualityLightingRequirement;

		// Token: 0x0400856D RID: 34157
		private Color _mediumQualityLightingRequirement;

		// Token: 0x0400856E RID: 34158
		private static readonly Vector2 _zero;

		// Token: 0x0400856F RID: 34159
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x04008570 RID: 34160
		private Vector3[] _glowPaintColorSlices;

		// Token: 0x04008571 RID: 34161
		private VertexColors LiquidBehindTileColors;

		// Token: 0x04008572 RID: 34162
		private VertexColors LiquidBehindTileColors2;

		// Token: 0x04008573 RID: 34163
		private static WorldGen.GetTreeFoliageDataMethod GetCommonTreeFoliageDataInstance;

		// Token: 0x04008574 RID: 34164
		private static WorldGen.GetTreeFoliageDataMethod GetGemTreeFoliageDataInstance;

		// Token: 0x04008575 RID: 34165
		private static WorldGen.GetTreeFoliageDataMethod GetVanityTreeFoliageDataInstance;

		// Token: 0x04008576 RID: 34166
		private static WorldGen.GetTreeFoliageDataMethod GetAshTreeFoliageDataInstance;

		// Token: 0x04008577 RID: 34167
		private List<DrawData> _voidLensData;

		// Token: 0x020009E9 RID: 2537
		public enum TileCounterType
		{
			// Token: 0x04008579 RID: 34169
			Tree,
			// Token: 0x0400857A RID: 34170
			DisplayDoll,
			// Token: 0x0400857B RID: 34171
			HatRack,
			// Token: 0x0400857C RID: 34172
			WindyGrass,
			// Token: 0x0400857D RID: 34173
			MultiTileGrass,
			// Token: 0x0400857E RID: 34174
			MultiTileVine,
			// Token: 0x0400857F RID: 34175
			Vine,
			// Token: 0x04008580 RID: 34176
			BiomeGrass,
			// Token: 0x04008581 RID: 34177
			VoidLens,
			// Token: 0x04008582 RID: 34178
			ReverseVine,
			// Token: 0x04008583 RID: 34179
			TeleportationPylon,
			// Token: 0x04008584 RID: 34180
			MasterTrophy,
			// Token: 0x04008585 RID: 34181
			AnyDirectionalGrass,
			// Token: 0x04008586 RID: 34182
			Count
		}

		// Token: 0x020009EA RID: 2538
		private struct TileFlameData
		{
			// Token: 0x04008587 RID: 34183
			public Texture2D flameTexture;

			// Token: 0x04008588 RID: 34184
			public ulong flameSeed;

			// Token: 0x04008589 RID: 34185
			public int flameCount;

			// Token: 0x0400858A RID: 34186
			public Color flameColor;

			// Token: 0x0400858B RID: 34187
			public int flameRangeXMin;

			// Token: 0x0400858C RID: 34188
			public int flameRangeXMax;

			// Token: 0x0400858D RID: 34189
			public int flameRangeYMin;

			// Token: 0x0400858E RID: 34190
			public int flameRangeYMax;

			// Token: 0x0400858F RID: 34191
			public float flameRangeMultX;

			// Token: 0x04008590 RID: 34192
			public float flameRangeMultY;
		}
	}
}
