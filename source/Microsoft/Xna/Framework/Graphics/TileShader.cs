using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200036E RID: 878
	public class TileShader : Effect
	{
		// Token: 0x060016DF RID: 5855 RVA: 0x00063F68 File Offset: 0x00062168
		public TileShader(GraphicsDevice device)
			: base(device)
		{
			this._invertSpecialGroupResult = "invertSpecialGroupResult";
			if ("invertSpecialGroupResult" == null || "invertSpecialGroupResult" != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00063F9C File Offset: 0x0006219C
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
			string name = pass.Name;
			uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00064018 File Offset: 0x00062218
		public static TileShader CreateNew()
		{
			/*
An exception occurred when decompiling this method (060016E1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.TileShader Microsoft.Xna.Framework.Graphics.TileShader::CreateNew()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	call:void(Debug::LogError, ldstr:string[exp:object]("Attempting to create shader not on main thread!"))
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

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0006403C File Offset: 0x0006223C
		public static TileShader Effect
		{
			get
			{
				/*
An exception occurred when decompiling this method (060016E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Microsoft.Xna.Framework.Graphics.TileShader Microsoft.Xna.Framework.Graphics.TileShader::get_Effect()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TileShader(var_0_05, call:TileShader(TileShader::CreateNew))
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

		// Token: 0x060016E3 RID: 5859 RVA: 0x000021DB File Offset: 0x000003DB
		private static void LoadPass(List<EffectPass> passes, string pass)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00064050 File Offset: 0x00062250
		// Note: this type is marked as 'beforefieldinit'.
		static TileShader()
		{
			int num = Shader.PropertyToID("_leafHueTestOffset");
			int num2 = Shader.PropertyToID("_leafMinHue");
			int num3 = Shader.PropertyToID("_leafMaxHue");
			int num4 = Shader.PropertyToID("_leafMinSat");
			int num5 = Shader.PropertyToID("_leafMaxSat");
			int num6 = Shader.PropertyToID("_invertSpecialGroupResult");
		}

		// Token: 0x0400256C RID: 9580
		private EffectParameter _leafMinHueOffset;

		// Token: 0x0400256D RID: 9581
		private EffectParameter _leafMinHue;

		// Token: 0x0400256E RID: 9582
		private EffectParameter _leafMaxHue;

		// Token: 0x0400256F RID: 9583
		private EffectParameter _leafMinSat;

		// Token: 0x04002570 RID: 9584
		private EffectParameter _leafMaxSat;

		// Token: 0x04002571 RID: 9585
		private EffectParameter _invertSpecialGroupResult;

		// Token: 0x04002572 RID: 9586
		private static int _leafHueTestOffsetId;

		// Token: 0x04002573 RID: 9587
		private static int _leafMinHueId;

		// Token: 0x04002574 RID: 9588
		private static int _leafMaxHueId;

		// Token: 0x04002575 RID: 9589
		private static int _leafMinSatId;

		// Token: 0x04002576 RID: 9590
		private static int _leafMaxSatId;

		// Token: 0x04002577 RID: 9591
		private static int _invertSpecialGroupResultId;

		// Token: 0x04002578 RID: 9592
		private static TileShader _effect;
	}
}
