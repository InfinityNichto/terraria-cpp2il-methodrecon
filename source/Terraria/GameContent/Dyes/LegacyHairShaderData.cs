using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x0200081A RID: 2074
	public class LegacyHairShaderData : HairShaderData
	{
		// Token: 0x060042A2 RID: 17058 RVA: 0x0024BE00 File Offset: 0x0024A000
		public LegacyHairShaderData()
		{
			this._shaderDisabled = true;
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x0024BE14 File Offset: 0x0024A014
		public override Color GetColor(Player player, Color lightColor)
		{
			LegacyHairShaderData.ColorProcessingMethod colorProcessor;
			do
			{
				colorProcessor = this._colorProcessor;
				IntPtr invoke_impl = colorProcessor.invoke_impl;
				IntPtr method_code = colorProcessor.method_code;
				IntPtr method = colorProcessor.method;
			}
			while (colorProcessor == null);
			if (colorProcessor == null)
			{
				return;
			}
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x0024BE48 File Offset: 0x0024A048
		public LegacyHairShaderData UseLegacyMethod(LegacyHairShaderData.ColorProcessingMethod colorProcessor)
		{
			this._colorProcessor = colorProcessor;
			return this;
		}

		// Token: 0x040080EF RID: 33007
		private LegacyHairShaderData.ColorProcessingMethod _colorProcessor;

		// Token: 0x0200081B RID: 2075
		public sealed class ColorProcessingMethod : MulticastDelegate
		{
			// Token: 0x060042A5 RID: 17061 RVA: 0x0024BE60 File Offset: 0x0024A060
			public ColorProcessingMethod(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060042A6 RID: 17062 RVA: 0x0024BEC0 File Offset: 0x0024A0C0
			public Color Invoke(Player player, Color color, bool lighting)
			{
				/*
An exception occurred when decompiling this method (060042A6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.Color Terraria.GameContent.Dyes.LegacyHairShaderData/ColorProcessingMethod::Invoke(Terraria.Player,Microsoft.Xna.Framework.Graphics.Color,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:ColorProcessingMethod[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:ColorProcessingMethod[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:ColorProcessingMethod[exp:Delegate](this)))
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

			// Token: 0x060042A7 RID: 17063 RVA: 0x000021DB File Offset: 0x000003DB
			public IAsyncResult BeginInvoke(Player player, Color color, bool lighting, AsyncCallback callback, object @object)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060042A8 RID: 17064 RVA: 0x0024BEE4 File Offset: 0x0024A0E4
			public Color EndInvoke(bool lighting, IAsyncResult result)
			{
				Color color;
				return color;
			}
		}
	}
}
