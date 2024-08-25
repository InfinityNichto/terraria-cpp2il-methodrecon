using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200023C RID: 572
	internal class StackGuard
	{
		// Token: 0x060013EF RID: 5103 RVA: 0x00029D7C File Offset: 0x00027F7C
		internal bool TryBeginInliningScope()
		{
			/*
An exception occurred when decompiling this method (060013EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Tasks.StackGuard::TryBeginInliningScope()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(StackGuard::m_inliningDepth, ldloc:StackGuard(this)))
	stloc:bool(var_2_0E, call:bool(RuntimeHelpers::TryEnsureSufficientExecutionStack))
	stloc:int32(var_3_15, ldfld:int32(StackGuard::m_inliningDepth, ldloc:StackGuard(this)))
	stfld:int32(StackGuard::m_inliningDepth, ldloc:StackGuard(this), ldloc:int32(var_3_15))
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

		// Token: 0x060013F0 RID: 5104 RVA: 0x00029DAC File Offset: 0x00027FAC
		internal void EndInliningScope()
		{
			int inliningDepth = this.m_inliningDepth;
			this.m_inliningDepth = inliningDepth;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00029DC8 File Offset: 0x00027FC8
		public StackGuard()
		{
		}

		// Token: 0x04000A9F RID: 2719
		private int m_inliningDepth;
	}
}
