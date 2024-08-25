using System;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Drawing;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics.Light
{
	// Token: 0x0200077C RID: 1916
	public class TileLightScanner
	{
		// Token: 0x06003ECC RID: 16076 RVA: 0x0023E7FC File Offset: 0x0023C9FC
		public TileLightScanner()
		{
			FastRandom fastRandom = FastRandom.CreateWithRandomSeed();
			this._random = fastRandom;
			if (!true)
			{
			}
			this._threadManager = 1;
			base..ctor();
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x0023E828 File Offset: 0x0023CA28
		private void ExportBatchFinished(int index)
		{
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06003ECE RID: 16078 RVA: 0x0023E838 File Offset: 0x0023CA38
		private ThreadedRenderManager.BatchProcessCallback ExportBatchFinishedCallback
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003ECE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling ThreadedRenderManager/BatchProcessCallback Terraria.Graphics.Light.TileLightScanner::get_ExportBatchFinishedCallback()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:BatchProcessCallback[exp:bool](TileLightScanner::_processBatchFinishedCallback, ldloc:TileLightScanner(this)))
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

		// Token: 0x06003ECF RID: 16079 RVA: 0x0023E84C File Offset: 0x0023CA4C
		private void ExportToThreaded(Rectangle area, LightMap outputMap)
		{
			LightingEngine lightingEngine = this._threadManager.DrawThreads.lightingEngine;
			WallDrawing wallDrawing = this._threadManager.DrawThreads.wallDrawing;
			TileDrawing tileDrawing = this._threadManager.DrawThreads.tileDrawing;
			ThreadedRenderManager threadManager = this._threadManager;
			ThreadedRenderManager.BatchProcessCallback exportBatchFinishedCallback = this.ExportBatchFinishedCallback;
			int num = 3;
			threadManager.WaitAndProcess(exportBatchFinishedCallback, num);
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x0023E8AC File Offset: 0x0023CAAC
		public void ExportTo(Rectangle area, LightMap outputMap)
		{
			if (!true)
			{
			}
			if (true)
			{
				this.ExportToThreaded(area, outputMap);
				return;
			}
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x0023E8C8 File Offset: 0x0023CAC8
		[Il2CppSetOption(Option.NullChecks, false)]
		[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
		public void ExportTo(int startX, int startY, int endX, int endY, int lightStartX, int lightStartY, LightMap outputMap)
		{
			if (!true)
			{
			}
			bool flag = Main.ShouldShowInvisibleWalls();
			int <Height>k__BackingField = outputMap.<Height>k__BackingField;
			int underworldLayer = Main.UnderworldLayer;
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x0023EDEC File Offset: 0x0023CFEC
		private bool IsTileNullOrTouchingNull(int x, int y)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 1;
			bool flag = WorldGen.InWorld(x, y, num2);
			if (num == 0)
			{
				return;
			}
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x0023EE10 File Offset: 0x0023D010
		public void Update()
		{
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x0023EE20 File Offset: 0x0023D020
		public LightMaskMode GetMaskMode(int x, int y)
		{
			if (!true)
			{
			}
			LightMaskMode lightMaskMode;
			return lightMaskMode;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x0023EE34 File Offset: 0x0023D034
		private LightMaskMode GetTileMask(Tile tile)
		{
			/*
An exception occurred when decompiling this method (06003ED5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.Graphics.Light.LightMaskMode Terraria.Graphics.Light.TileLightScanner::GetTileMask(Terraria.Tile)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_07, call:bool(TileLightScanner::LightIsBlocked, ldloc:TileLightScanner(this), ldloc:Tile(tile)))
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

		// Token: 0x06003ED6 RID: 16086 RVA: 0x0023EE4C File Offset: 0x0023D04C
		public void GetTileLight(int x, int y, [Out] Vector3 outputColor)
		{
			if (!true)
			{
			}
			int num = 1;
			if (num == 0)
			{
			}
			outputColor.Z = (float)num;
			if (num == 0)
			{
			}
			if (32752 == 0)
			{
			}
			int underworldLayer = Main.UnderworldLayer;
			Tile tile;
			this.ApplyHellLight(tile, x, y, outputColor);
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x0023EE90 File Offset: 0x0023D090
		private void ApplyLiquidLight(Tile tile, Vector3 lightColor)
		{
			if (!true)
			{
			}
			float y = lightColor.Y;
			float z = lightColor.Z;
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x0023EEC0 File Offset: 0x0023D0C0
		private bool LightIsBlocked(Tile tile)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				bool drawInvisibleWalls = this._drawInvisibleWalls;
				bool flag;
				return flag;
			}
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0023EEE4 File Offset: 0x0023D0E4
		private void ApplyWallLight(Tile tile, int x, int y, FastRandom localRandom, Vector3 lightColor)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x0023EF38 File Offset: 0x0023D138
		private void ApplyTileLight(Tile tile, int x, int y, FastRandom localRandom, Vector3 lightColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num != 0)
			{
				return;
			}
			if (426 == 0)
			{
				float y2 = lightColor.Y;
				float z = lightColor.Z;
			}
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x0023F484 File Offset: 0x0023D684
		private void ApplySurfaceLight(Tile tile, int x, int y, Vector3 lightColor)
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = 17279;
			if (num == 0)
			{
			}
			bool drawInvisibleWalls;
			if (num != 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
					drawInvisibleWalls = this._drawInvisibleWalls;
					if (!drawInvisibleWalls)
					{
						return;
					}
				}
				return;
			}
			if (!drawInvisibleWalls)
			{
			}
			if (drawInvisibleWalls)
			{
				if (!drawInvisibleWalls)
				{
				}
				Tile tile2;
				byte liquid = tile2.liquid;
				if (!drawInvisibleWalls)
				{
				}
				Tile tile3;
				byte liquid2 = tile3.liquid;
				if (!drawInvisibleWalls)
				{
				}
				Tile tile4;
				byte liquid3 = tile4.liquid;
				if (!drawInvisibleWalls)
				{
				}
				Tile tile5;
				byte liquid4 = tile5.liquid;
			}
			if (!drawInvisibleWalls)
			{
			}
			if (!drawInvisibleWalls)
			{
			}
			if (!drawInvisibleWalls)
			{
			}
			float[] liquidAlpha = Main.liquidAlpha;
			if (!drawInvisibleWalls)
			{
			}
			if (num2 == 0)
			{
			}
			float[] liquidAlpha2 = Main.liquidAlpha;
		}

		// Token: 0x06003EDC RID: 16092 RVA: 0x0023F550 File Offset: 0x0023D750
		private void ApplyHellLight(Tile tile, int x, int y, Vector3 lightColor)
		{
			if (!true)
			{
			}
			Tile tile2;
			byte liquid = tile2.liquid;
		}

		// Token: 0x04007D6B RID: 32107
		private FastRandom _random;

		// Token: 0x04007D6C RID: 32108
		private bool _drawInvisibleWalls;

		// Token: 0x04007D6D RID: 32109
		private ThreadedRenderManager _threadManager;

		// Token: 0x04007D6E RID: 32110
		private ThreadedRenderManager.BatchProcessCallback _processBatchFinishedCallback;
	}
}
