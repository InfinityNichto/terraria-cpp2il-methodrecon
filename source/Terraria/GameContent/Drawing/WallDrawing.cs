using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x020009EB RID: 2539
	public class WallDrawing
	{
		// Token: 0x06004B44 RID: 19268 RVA: 0x0026E5CC File Offset: 0x0026C7CC
		public WallDrawing(TilePaintSystemV2 paintSystem)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			this._threadManager = 1;
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this._paintSystem = paintSystem;
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x0026E608 File Offset: 0x0026C808
		public void Update()
		{
			if (!true)
			{
			}
			if (!true)
			{
				if (!true)
				{
				}
				bool flag = Main.ShouldShowInvisibleWalls();
				this._shouldShowInvisibleWalls = true;
			}
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x000021DB File Offset: 0x000003DB
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void DrawWalls(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x0026E630 File Offset: 0x0026C830
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		[Il2CppSetOption(Option.NullChecks, false)]
		public void DrawWalls()
		{
			if (!true)
			{
			}
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
			float gfxQuality = Main.gfxQuality;
			Vector2 screenPosition = Main.screenPosition;
			if (!true)
			{
			}
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x0026E6D8 File Offset: 0x0026C8D8
		private int DrawWallsThreaded(Vector2 screenPosition, Vector2 offSet, int firstTileX, int firstTileY, int lastTileX, int lastTileY)
		{
			int num = 1;
			if (num == 0)
			{
			}
			Main.FlushBatches();
			if (num == 0)
			{
			}
			int num2 = 4;
			TileBatch tileBatch = this._threadManager.DrawThreads.tileBatch;
			Matrix transform = Main.Transform;
			SpriteBatch spriteBatch = this._threadManager.DrawThreads.spriteBatch;
			Matrix transform2 = Main.Transform;
			SpriteBatch spriteBatch2 = this._threadManager.DrawThreads.spriteBatch2;
			Matrix transform3 = Main.Transform;
			if (!true)
			{
			}
			if (this._threadManager.DrawThreads == null)
			{
			}
			return num2;
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x0026E760 File Offset: 0x0026C960
		private void ProcessBatchFinished(int index)
		{
			TileDrawing tileDrawing = this._threadManager.DrawThreads.tileDrawing;
			double sunflowerWindCounter = tileDrawing._sunflowerWindCounter;
			double sunflowerWindCounter2 = tileDrawing._sunflowerWindCounter;
			double treeWindCounter = tileDrawing._treeWindCounter;
			double treeWindCounter2 = tileDrawing._treeWindCounter;
			double grassWindCounter = tileDrawing._grassWindCounter;
			double grassWindCounter2 = tileDrawing._grassWindCounter;
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0026E7AC File Offset: 0x0026C9AC
		private ThreadedRenderManager.BatchProcessCallback ProcessBatchFinishedCallback
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004B4A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ThreadedRenderManager/BatchProcessCallback Terraria.GameContent.Drawing.WallDrawing::get_ProcessBatchFinishedCallback()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:BatchProcessCallback[exp:bool](WallDrawing::_processBatchFinishedCallback, ldloc:WallDrawing(this)))
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

		// Token: 0x06004B4B RID: 19275 RVA: 0x0026E7C0 File Offset: 0x0026C9C0
		private void WaitDrawThreads(int numThreads)
		{
			if (!true)
			{
			}
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.BatchProcessCallback processBatchFinishedCallback = this.ProcessBatchFinishedCallback;
			threadManager.WaitAndProcessInOrder(processBatchFinishedCallback, numThreads);
			Matrix transform = Main.Transform;
			Matrix transform2 = Main.Transform;
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x0026E7F8 File Offset: 0x0026C9F8
		private void GetWallDrawTexture(ushort wallType, byte wallColor, [Out] Texture2D drawTexture, [Out] EffectPass pass)
		{
			if (!true)
			{
			}
			Effect effect = this.WallEffects._effect;
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x0026E814 File Offset: 0x0026CA14
		protected bool FullTile(Tile tileCache, int x, int y)
		{
			bool shouldShowInvisibleWalls = this._shouldShowInvisibleWalls;
			if (!shouldShowInvisibleWalls)
			{
				return;
			}
			if (!shouldShowInvisibleWalls)
			{
			}
			Tile tile;
			bool isLoaded = tile.IsLoaded;
			int num;
			int num2;
			if (num != 0 || num2 != 0)
			{
				return;
			}
		}

		// Token: 0x04008591 RID: 34193
		private TileData _tileArray;

		// Token: 0x04008592 RID: 34194
		private TilePaintSystemV2 _paintSystem;

		// Token: 0x04008593 RID: 34195
		private VertexColors _glowPaintColors;

		// Token: 0x04008594 RID: 34196
		private Rectangle outlineLeftRect;

		// Token: 0x04008595 RID: 34197
		private Rectangle outlineRightRect;

		// Token: 0x04008596 RID: 34198
		private Rectangle outlineUpRect;

		// Token: 0x04008597 RID: 34199
		private Rectangle outlineDownRect;

		// Token: 0x04008598 RID: 34200
		private bool _shouldShowInvisibleWalls;

		// Token: 0x04008599 RID: 34201
		private EffectPass[] WallEffects;

		// Token: 0x0400859A RID: 34202
		private ThreadedRenderManager _threadManager;

		// Token: 0x0400859B RID: 34203
		public ThreadLocal<WallDrawing.WallDrawInfo> _currentWallDrawInfo;

		// Token: 0x0400859C RID: 34204
		private int drawThreadTest;

		// Token: 0x0400859D RID: 34205
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;

		// Token: 0x020009EC RID: 2540
		public class WallDrawInfo
		{
			// Token: 0x06004B4E RID: 19278 RVA: 0x0026E84C File Offset: 0x0026CA4C
			public WallDrawInfo()
			{
			}

			// Token: 0x0400859E RID: 34206
			public SpriteBatch wallSpriteBatch;

			// Token: 0x0400859F RID: 34207
			public SpriteBatch wallSpriteBatch2;

			// Token: 0x040085A0 RID: 34208
			public TileBatch wallTileBatch;
		}

		// Token: 0x020009ED RID: 2541
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004B4F RID: 19279 RVA: 0x0026E860 File Offset: 0x0026CA60
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06004B50 RID: 19280 RVA: 0x0026E870 File Offset: 0x0026CA70
			public <>c()
			{
			}

			// Token: 0x06004B51 RID: 19281 RVA: 0x000021DB File Offset: 0x000003DB
			internal WallDrawing.WallDrawInfo <.ctor>b__0_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040085A1 RID: 34209
			public static readonly WallDrawing.<>c <>9;

			// Token: 0x040085A2 RID: 34210
			public static Func<WallDrawing.WallDrawInfo> <>9__0_0;
		}
	}
}
