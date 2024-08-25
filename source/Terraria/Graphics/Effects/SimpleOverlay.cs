using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Shaders;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200078B RID: 1931
	public class SimpleOverlay : Overlay
	{
		// Token: 0x06003F15 RID: 16149 RVA: 0x0023FAF4 File Offset: 0x0023DCF4
		public SimpleOverlay(string textureName, ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this._priority = priority;
			this._layer = layer;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x0023FB30 File Offset: 0x0023DD30
		public SimpleOverlay(string textureName, string shaderName = "Default", EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			base..ctor();
			this._priority = priority;
			this._layer = layer;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x0023FB64 File Offset: 0x0023DD64
		public ScreenShaderData GetShader()
		{
			return this._shader;
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x0023FB78 File Offset: 0x0023DD78
		public override void Draw(SpriteBatch spriteBatch)
		{
			ScreenShaderData shader = this._shader;
			float opacity = this.Opacity;
			ScreenShaderData shader2 = this._shader;
			float x = this.TargetPosition.X;
			float y = this.TargetPosition.Y;
			ScreenShaderData shader3 = this._shader;
			Asset<Texture2D> texture = this._texture;
			int screenWidth = Main.screenWidth;
			int screenHeight = Main.screenHeight;
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x0023FBE0 File Offset: 0x0023DDE0
		public override void Update(GameTime gameTime)
		{
			ScreenShaderData shader = this._shader;
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0023FBF4 File Offset: 0x0023DDF4
		public override void Activate(Vector2 position, params object[] args)
		{
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0023FC04 File Offset: 0x0023DE04
		public override void Deactivate(params object[] args)
		{
			this.Mode = OverlayMode.FadeOut;
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x0023FC18 File Offset: 0x0023DE18
		public override bool IsVisible()
		{
			/*
An exception occurred when decompiling this method (06003F1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Effects.SimpleOverlay::IsVisible()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, callgetter:float32(ScreenShaderData::get_CombinedOpacity, ldfld:ScreenShaderData(SimpleOverlay::_shader, ldloc:SimpleOverlay(this))))
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

		// Token: 0x04007D9C RID: 32156
		private Asset<Texture2D> _texture;

		// Token: 0x04007D9D RID: 32157
		private ScreenShaderData _shader;

		// Token: 0x04007D9E RID: 32158
		public Vector2 TargetPosition;
	}
}
