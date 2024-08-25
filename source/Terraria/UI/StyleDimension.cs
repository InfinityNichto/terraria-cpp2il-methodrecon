using System;
using Cpp2IlInjected;

namespace Terraria.UI
{
	// Token: 0x0200071B RID: 1819
	public struct StyleDimension
	{
		// Token: 0x06003C2D RID: 15405 RVA: 0x00235B30 File Offset: 0x00233D30
		public StyleDimension(float pixels, float precent)
		{
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x00235B40 File Offset: 0x00233D40
		public void Set(float pixels, float precent)
		{
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x00235B50 File Offset: 0x00233D50
		public float GetValue(float containerSize)
		{
			/*
An exception occurred when decompiling this method (06003C2F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single Terraria.UI.StyleDimension::GetValue(System.Single)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:float32(var_0_06, ldfld:float32(StyleDimension::Pixels, ldloc:valuetype Terraria.UI.StyleDimension&(this)))
	stloc:float32(var_1_0D, ldfld:float32(StyleDimension::Precent, ldloc:valuetype Terraria.UI.StyleDimension&(this)))
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

		// Token: 0x06003C30 RID: 15408 RVA: 0x000021DB File Offset: 0x000003DB
		public static StyleDimension FromPixels(float pixels)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x000021DB File Offset: 0x000003DB
		public static StyleDimension FromPercent(float percent)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x000021DB File Offset: 0x000003DB
		public static StyleDimension FromPixelsAndPercent(float pixels, float percent)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x00235B6C File Offset: 0x00233D6C
		// Note: this type is marked as 'beforefieldinit'.
		static StyleDimension()
		{
		}

		// Token: 0x04007B7C RID: 31612
		public static StyleDimension Fill;

		// Token: 0x04007B7D RID: 31613
		public static StyleDimension Empty;

		// Token: 0x04007B7E RID: 31614
		public float Pixels;

		// Token: 0x04007B7F RID: 31615
		public float Precent;
	}
}
