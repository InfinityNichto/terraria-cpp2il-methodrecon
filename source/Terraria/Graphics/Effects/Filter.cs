using System;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000783 RID: 1923
	public class Filter : GameEffect
	{
		// Token: 0x06003EF1 RID: 16113 RVA: 0x0023F760 File Offset: 0x0023D960
		public Filter(ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow)
		{
			this._shader = shader;
			this._priority = priority;
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x0023F784 File Offset: 0x0023D984
		public void Update(GameTime gameTime)
		{
			ScreenShaderData shader = this._shader;
			float opacity = this.Opacity;
			ScreenShaderData shader2 = this._shader;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x0023F7A8 File Offset: 0x0023D9A8
		public void Apply()
		{
			ScreenShaderData shader = this._shader;
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0023F7BC File Offset: 0x0023D9BC
		public ScreenShaderData GetShader()
		{
			return this._shader;
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0023F7D0 File Offset: 0x0023D9D0
		public override void Activate(Vector2 position, params object[] args)
		{
			float opacity = this.Opacity;
			ScreenShaderData shader = this._shader;
			ScreenShaderData shader2 = this._shader;
			this.Active = true;
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0023F7FC File Offset: 0x0023D9FC
		public override void Deactivate(params object[] args)
		{
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0023F80C File Offset: 0x0023DA0C
		public bool IsInUse()
		{
			return !this.Active || true;
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0023F824 File Offset: 0x0023DA24
		public bool IsActive()
		{
			return this.Active;
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0023F838 File Offset: 0x0023DA38
		public override bool IsVisible()
		{
			/*
An exception occurred when decompiling this method (06003EF9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Terraria.Graphics.Effects.Filter::IsVisible()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_0B, callgetter:float32(ScreenShaderData::get_CombinedOpacity, ldfld:ScreenShaderData(Filter::_shader, ldloc:Filter(this))))
	stloc:bool(var_1_12, ldfld:bool(Filter::IsHidden, ldloc:Filter(this)))
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

		// Token: 0x04007D7A RID: 32122
		public bool Active;

		// Token: 0x04007D7B RID: 32123
		private ScreenShaderData _shader;

		// Token: 0x04007D7C RID: 32124
		public bool IsHidden;
	}
}
