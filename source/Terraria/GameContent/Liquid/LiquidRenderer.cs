using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;
using Terraria.Graphics.Light;
using Terraria.Utilities;

namespace Terraria.GameContent.Liquid
{
	// Token: 0x020009FF RID: 2559
	public class LiquidRenderer
	{
		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06004B91 RID: 19345 RVA: 0x0026F04C File Offset: 0x0026D24C
		// (remove) Token: 0x06004B92 RID: 19346 RVA: 0x0026F074 File Offset: 0x0026D274
		public event Action<Color[], Rectangle> WaveFilters
		{
			[CompilerGenerated]
			add
			{
				Delegate @delegate = Delegate.Combine(this.WaveFilters, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
			[CompilerGenerated]
			remove
			{
				Delegate @delegate = Delegate.Remove(this.WaveFilters, value);
				if (@delegate != null && @delegate == null)
				{
					return;
				}
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x0026F09C File Offset: 0x0026D29C
		private static TileData Tiles
		{
			get
			{
				/*
An exception occurred when decompiling this method (06004B93)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Terraria.TileData Terraria.GameContent.Liquid.LiquidRenderer::get_Tiles()

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

		// Token: 0x06004B94 RID: 19348 RVA: 0x0026F0AC File Offset: 0x0026D2AC
		public static void LoadContent()
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x0026F0BC File Offset: 0x0026D2BC
		public LiquidRenderer()
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x0026F0D4 File Offset: 0x0026D2D4
		public void PrepareAssets()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
				string text2;
				string text = "Images/Misc/water_" + text2;
				return;
			}
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x0026F110 File Offset: 0x0026D310
		private void InternalPrepareDraw(Rectangle drawArea)
		{
			int y = this._cache.FrameOffset.Y;
			bool isVisible = this._drawCache.IsVisible;
			Vector2 liquidOffset = this._drawCacheForShimmer.LiquidOffset;
			Color[] waveMask = this._waveMask;
			LiquidRenderer.LiquidCache[] cache = this._cache;
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x0026F2F4 File Offset: 0x0026D4F4
		public void DrawNormalLiquids(SpriteBatch spriteBatch, Vector2 drawOffset, int waterStyle, float globalAlpha, bool isBackgroundDraw)
		{
			if (!true)
			{
			}
			LightMap lightMap;
			int <Height>k__BackingField = lightMap.<Height>k__BackingField;
			if (true)
			{
				return;
			}
			if (!true)
			{
			}
			Vector3[] colors = lightMap._colors;
			if (colors != null)
			{
				return;
			}
			if (colors == null)
			{
			}
			if (!true)
			{
			}
			if (<Height>k__BackingField == 0)
			{
			}
			if (!true)
			{
			}
			int num = 17279;
			if (num == 0)
			{
				return;
			}
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06004B99 RID: 19353 RVA: 0x0026F3B8 File Offset: 0x0026D5B8
		public void DrawShimmer(SpriteBatch spriteBatch, Vector2 drawOffset, bool isBackgroundDraw)
		{
			do
			{
				spriteBatch.End();
				spriteBatch.Flush();
				int num = 1;
				if (num == 0)
				{
				}
				if (num == 0)
				{
				}
			}
			while (true);
			if (!true)
			{
			}
			LiquidRenderer.SpecialLiquidDrawCache[] drawCacheForShimmer = this._drawCacheForShimmer;
			Vector2 liquidOffset = drawCacheForShimmer.LiquidOffset;
			if (drawCacheForShimmer != null)
			{
				int num2;
				if (drawCacheForShimmer != null)
				{
					num2 = 1280;
					return;
				}
				int animationFrame = this._animationFrame;
				if (num2 == 0)
				{
				}
				if (num2 == 0)
				{
				}
				if (80 == 0)
				{
				}
			}
			spriteBatch.End();
			spriteBatch.Flush();
		}

		// Token: 0x06004B9A RID: 19354 RVA: 0x0026F42C File Offset: 0x0026D62C
		public static void SetShimmerVertexColors_Sparkle(VertexColors colors, float opacity, int x, int y, bool top)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x0026F43C File Offset: 0x0026D63C
		public static void SetShimmerVertexColors(VertexColors colors, float opacity, int x, int y)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x0026F44C File Offset: 0x0026D64C
		public static float GetShimmerWave(float worldPositionX, float worldPositionY)
		{
			/*
An exception occurred when decompiling this method (06004B9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Liquid.LiquidRenderer::GetShimmerWave(System.Single,System.Single)

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

		// Token: 0x06004B9D RID: 19357 RVA: 0x0026F45C File Offset: 0x0026D65C
		public static Color GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY)
		{
			if (!true)
			{
			}
			Color color;
			Vector4 vector = color.ToVector4();
			if (!true)
			{
			}
			float shimmerGlitterOpacity = LiquidRenderer.GetShimmerGlitterOpacity(true, worldPositionX, worldPositionY);
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x0026F488 File Offset: 0x0026D688
		public static void GetShimmerGlitterColor(bool top, float worldPositionX, float worldPositionY, Color color, float opacity)
		{
			if (!true)
			{
			}
			double num = Main.hue2rgb((double)worldPositionX, 0.3333333333333333, -0.3333333333333333);
			double num2 = Main.hue2rgb(num, 0.3333333333333333, -0.3333333333333333);
			double num3 = Main.hue2rgb(num2, 0.3333333333333333, -0.3333333333333333);
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x0026F500 File Offset: 0x0026D700
		public static float GetShimmerGlitterOpacity(bool top, float worldPositionX, float worldPositionY)
		{
			/*
An exception occurred when decompiling this method (06004B9F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Liquid.LiquidRenderer::GetShimmerGlitterOpacity(System.Boolean,System.Single,System.Single)

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

		// Token: 0x06004BA0 RID: 19360 RVA: 0x000021DB File Offset: 0x000003DB
		private static uint SimpleWhiteNoise(uint x, uint y)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x0026F510 File Offset: 0x0026D710
		public int GetShimmerFrame(bool top, float worldPositionX, float worldPositionY)
		{
			/*
An exception occurred when decompiling this method (06004BA1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Terraria.GameContent.Liquid.LiquidRenderer::GetShimmerFrame(System.Boolean,System.Single,System.Single)

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

		// Token: 0x06004BA2 RID: 19362 RVA: 0x0026F520 File Offset: 0x0026D720
		public static Vector4 GetShimmerBaseColor(float worldPositionX, float worldPositionY)
		{
			/*
An exception occurred when decompiling this method (06004BA2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Vector4 Terraria.GameContent.Liquid.LiquidRenderer::GetShimmerBaseColor(System.Single,System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_07, call:float32(LiquidRenderer::GetShimmerWave, ldloc:float32(worldPositionX), ldloc:float32(worldPositionY)))
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

		// Token: 0x06004BA3 RID: 19363 RVA: 0x0026F538 File Offset: 0x0026D738
		public static void GetShimmerColor(float worldPositionX, float worldPositionY, Color baseColor, float opcacity)
		{
			if (!true)
			{
			}
			float shimmerWave = LiquidRenderer.GetShimmerWave(worldPositionX, worldPositionY);
			baseColor.R = (byte)17279;
			baseColor.G = (byte)17279;
			baseColor.B = (byte)17279;
			baseColor.A = (byte)17279;
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x0026F57C File Offset: 0x0026D77C
		public bool HasFullWater(int x, int y)
		{
			Rectangle drawArea = this._drawArea;
			int width = this._drawArea.Width;
			int height = this._drawArea.Height;
			bool isVisible = this._drawCache.IsVisible;
			if (36 != 0)
			{
				return;
			}
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x0026F5BC File Offset: 0x0026D7BC
		public float GetVisibleLiquid(int x, int y)
		{
			/*
An exception occurred when decompiling this method (06004BA5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.GameContent.Liquid.LiquidRenderer::GetVisibleLiquid(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_5_3E, ldfld:float32(LiquidCache::RightWall, ldloc:valuetype Terraria.GameContent.Liquid.LiquidRenderer/LiquidCache[][exp:valuetype Terraria.GameContent.Liquid.LiquidRenderer/LiquidCache&](var_4_31)))
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

		// Token: 0x06004BA6 RID: 19366 RVA: 0x0026F608 File Offset: 0x0026D808
		public void Update(GameTime gameTime)
		{
			if (!true)
			{
			}
			TimeSpan elapsedGameTime = gameTime.elapsedGameTime;
			float frameState = this._frameState;
			this._animationFrame = 32768;
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x0026F634 File Offset: 0x0026D834
		public void PrepareDraw(Rectangle drawArea)
		{
			this.InternalPrepareDraw(drawArea);
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x0026F648 File Offset: 0x0026D848
		public void SetWaveMaskData(Texture2D texture)
		{
			int height = this._drawArea.Height;
			int width = this._drawArea.Width;
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x000021DB File Offset: 0x000003DB
		public Rectangle GetCachedDrawArea()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x0026F6CC File Offset: 0x0026D8CC
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidRenderer()
		{
		}

		// Token: 0x040085BF RID: 34239
		public static LiquidRenderer Instance;

		// Token: 0x040085C0 RID: 34240
		private const int ANIMATION_FRAME_COUNT = 16;

		// Token: 0x040085C1 RID: 34241
		private const int CACHE_PADDING = 2;

		// Token: 0x040085C2 RID: 34242
		private const int CACHE_PADDING_2 = 4;

		// Token: 0x040085C3 RID: 34243
		private static readonly int[] WATERFALL_LENGTH;

		// Token: 0x040085C4 RID: 34244
		private static readonly float[] DEFAULT_OPACITY;

		// Token: 0x040085C5 RID: 34245
		private static readonly byte[] WAVE_MASK_STRENGTH;

		// Token: 0x040085C6 RID: 34246
		private static readonly byte[] VISCOSITY_MASK;

		// Token: 0x040085C7 RID: 34247
		[CompilerGenerated]
		private Action<Color[], Rectangle> WaveFilters;

		// Token: 0x040085C8 RID: 34248
		public const float MIN_LIQUID_SIZE = 0.25f;

		// Token: 0x040085C9 RID: 34249
		private static readonly Asset<Texture2D>[] _liquidTextures;

		// Token: 0x040085CA RID: 34250
		private LiquidRenderer.LiquidCache[] _cache;

		// Token: 0x040085CB RID: 34251
		private LiquidRenderer.LiquidDrawCache[] _drawCache;

		// Token: 0x040085CC RID: 34252
		private LiquidRenderer.SpecialLiquidDrawCache[] _drawCacheForShimmer;

		// Token: 0x040085CD RID: 34253
		private int _animationFrame;

		// Token: 0x040085CE RID: 34254
		private Rectangle _drawArea;

		// Token: 0x040085CF RID: 34255
		private readonly UnifiedRandom _random;

		// Token: 0x040085D0 RID: 34256
		private Color[] _waveMask;

		// Token: 0x040085D1 RID: 34257
		private float _frameState;

		// Token: 0x02000A00 RID: 2560
		private struct LiquidCache
		{
			// Token: 0x040085D2 RID: 34258
			public float LiquidLevel;

			// Token: 0x040085D3 RID: 34259
			public float VisibleLiquidLevel;

			// Token: 0x040085D4 RID: 34260
			public float Opacity;

			// Token: 0x040085D5 RID: 34261
			public bool IsSolid;

			// Token: 0x040085D6 RID: 34262
			public bool IsHalfBrick;

			// Token: 0x040085D7 RID: 34263
			public bool HasLiquid;

			// Token: 0x040085D8 RID: 34264
			public bool HasVisibleLiquid;

			// Token: 0x040085D9 RID: 34265
			public bool HasWall;

			// Token: 0x040085DA RID: 34266
			public Point FrameOffset;

			// Token: 0x040085DB RID: 34267
			public bool HasLeftEdge;

			// Token: 0x040085DC RID: 34268
			public bool HasRightEdge;

			// Token: 0x040085DD RID: 34269
			public bool HasTopEdge;

			// Token: 0x040085DE RID: 34270
			public bool HasBottomEdge;

			// Token: 0x040085DF RID: 34271
			public float LeftWall;

			// Token: 0x040085E0 RID: 34272
			public float RightWall;

			// Token: 0x040085E1 RID: 34273
			public float BottomWall;

			// Token: 0x040085E2 RID: 34274
			public float TopWall;

			// Token: 0x040085E3 RID: 34275
			public float VisibleLeftWall;

			// Token: 0x040085E4 RID: 34276
			public float VisibleRightWall;

			// Token: 0x040085E5 RID: 34277
			public float VisibleBottomWall;

			// Token: 0x040085E6 RID: 34278
			public float VisibleTopWall;

			// Token: 0x040085E7 RID: 34279
			public byte Type;

			// Token: 0x040085E8 RID: 34280
			public byte VisibleType;
		}

		// Token: 0x02000A01 RID: 2561
		private struct LiquidDrawCache
		{
			// Token: 0x040085E9 RID: 34281
			public Rectangle SourceRectangle;

			// Token: 0x040085EA RID: 34282
			public Vector2 LiquidOffset;

			// Token: 0x040085EB RID: 34283
			public bool IsVisible;

			// Token: 0x040085EC RID: 34284
			public float Opacity;

			// Token: 0x040085ED RID: 34285
			public byte Type;

			// Token: 0x040085EE RID: 34286
			public bool IsSurfaceLiquid;

			// Token: 0x040085EF RID: 34287
			public bool HasWall;
		}

		// Token: 0x02000A02 RID: 2562
		private struct SpecialLiquidDrawCache
		{
			// Token: 0x040085F0 RID: 34288
			public int X;

			// Token: 0x040085F1 RID: 34289
			public int Y;

			// Token: 0x040085F2 RID: 34290
			public Rectangle SourceRectangle;

			// Token: 0x040085F3 RID: 34291
			public Vector2 LiquidOffset;

			// Token: 0x040085F4 RID: 34292
			public bool IsVisible;

			// Token: 0x040085F5 RID: 34293
			public float Opacity;

			// Token: 0x040085F6 RID: 34294
			public byte Type;

			// Token: 0x040085F7 RID: 34295
			public bool IsSurfaceLiquid;

			// Token: 0x040085F8 RID: 34296
			public bool HasWall;
		}
	}
}
