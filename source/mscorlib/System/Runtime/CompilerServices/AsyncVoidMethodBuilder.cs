using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
	// Token: 0x0200048E RID: 1166
	public struct AsyncVoidMethodBuilder
	{
		// Token: 0x06002257 RID: 8791 RVA: 0x0004D450 File Offset: 0x0004B650
		public static AsyncVoidMethodBuilder Create()
		{
			/*
An exception occurred when decompiling this method (06002257)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.CompilerServices.AsyncVoidMethodBuilder System.Runtime.CompilerServices.AsyncVoidMethodBuilder::Create()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000B:
	stfld:SynchronizationContext(AsyncVoidMethodBuilder::m_synchronizationContext, ldloc:AsyncVoidMethodBuilder[exp:valuetype System.Runtime.CompilerServices.AsyncVoidMethodBuilder&](var_0), ldloc:SynchronizationContext(var_2_07))
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

		// Token: 0x06002258 RID: 8792 RVA: 0x0004D470 File Offset: 0x0004B670
		[DebuggerStepThrough]
		public void Start<TStateMachine>(TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			RuntimeHelpers.PrepareConstrainedRegions();
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x0004D498 File Offset: 0x0004B698
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0004D4A8 File Offset: 0x0004B6A8
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(TAwaiter awaiter, TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			bool loggingOn = AsyncCausalityTracer.LoggingOn;
			Task task = this.Task;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0004D4F4 File Offset: 0x0004B6F4
		public void SetResult()
		{
			bool loggingOn = AsyncCausalityTracer.LoggingOn;
			int id = this.Task.Id;
			this.NotifySynchronizationContextOfCompletion();
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x0004D520 File Offset: 0x0004B720
		public void SetException(Exception exception)
		{
			if (exception != null)
			{
				bool loggingOn = AsyncCausalityTracer.LoggingOn;
				int id = this.Task.Id;
				this.NotifySynchronizationContextOfCompletion();
				return;
			}
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x0004D564 File Offset: 0x0004B764
		private void NotifySynchronizationContextOfCompletion()
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x0004D574 File Offset: 0x0004B774
		internal Task Task
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600225E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Runtime.CompilerServices.AsyncVoidMethodBuilder::get_Task()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:Task[exp:bool](AsyncVoidMethodBuilder::m_task, ldloc:valuetype System.Runtime.CompilerServices.AsyncVoidMethodBuilder&(this)))
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

		// Token: 0x040012C7 RID: 4807
		private SynchronizationContext m_synchronizationContext;

		// Token: 0x040012C8 RID: 4808
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x040012C9 RID: 4809
		private Task m_task;
	}
}
