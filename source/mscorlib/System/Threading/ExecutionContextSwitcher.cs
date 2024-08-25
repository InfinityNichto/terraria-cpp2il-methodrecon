using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;

namespace System.Threading
{
	// Token: 0x020001EB RID: 491
	internal struct ExecutionContextSwitcher
	{
		// Token: 0x06001180 RID: 4480 RVA: 0x00025404 File Offset: 0x00023604
		[HandleProcessCorruptedStateExceptions]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal bool UndoNoThrow()
		{
			/*
An exception occurred when decompiling this method (06001180)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ExecutionContextSwitcher::UndoNoThrow()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ExecutionContextSwitcher::Undo, ldloc:valuetype System.Threading.ExecutionContextSwitcher&(this))
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

		// Token: 0x06001181 RID: 4481 RVA: 0x0002541C File Offset: 0x0002361C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal void Undo()
		{
			Thread thread = this.thread;
			if (thread != null)
			{
				bool flag = this.outerECBelongsToScope;
				ExecutionContext executionContext = thread.m_ExecutionContext;
				thread.m_ExecutionContextBelongsToOuterScope = flag;
				if (thread == null)
				{
				}
				return;
			}
		}

		// Token: 0x04000976 RID: 2422
		internal ExecutionContext.Reader outerEC;

		// Token: 0x04000977 RID: 2423
		internal bool outerECBelongsToScope;

		// Token: 0x04000978 RID: 2424
		internal object hecsw;

		// Token: 0x04000979 RID: 2425
		internal Thread thread;
	}
}
