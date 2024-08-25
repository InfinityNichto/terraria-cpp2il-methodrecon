using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading.Tasks
{
	// Token: 0x0200021A RID: 538
	internal static class TaskToApm
	{
		// Token: 0x060012E0 RID: 4832 RVA: 0x00027D40 File Offset: 0x00025F40
		public static IAsyncResult Begin(Task task, AsyncCallback callback, object state)
		{
			/*
An exception occurred when decompiling this method (060012E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Threading.Tasks.TaskToApm::Begin(System.Threading.Tasks.Task,System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	brtrue(IL_0014, ldloc:Task[exp:bool](task))
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

		// Token: 0x060012E1 RID: 4833 RVA: 0x00027D64 File Offset: 0x00025F64
		public static void End(IAsyncResult asyncResult)
		{
			while (asyncResult == null || asyncResult == null)
			{
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0000207A File Offset: 0x0000027A
		public static TResult End<TResult>(IAsyncResult cpp2il__autoParamName__idx_1)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x00027D7C File Offset: 0x00025F7C
		private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult)
		{
		}

		// Token: 0x0200021B RID: 539
		private sealed class TaskWrapperAsyncResult : IAsyncResult
		{
			// Token: 0x060012E4 RID: 4836 RVA: 0x00027D8C File Offset: 0x00025F8C
			internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously)
			{
				this.Task = task;
				this._state = state;
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00027DB0 File Offset: 0x00025FB0
			object IAsyncResult.AsyncState
			{
				get
				{
					return this._state;
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00027DC4 File Offset: 0x00025FC4
			bool IAsyncResult.CompletedSynchronously
			{
				get
				{
					return this._completedSynchronously;
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00027DD8 File Offset: 0x00025FD8
			bool IAsyncResult.IsCompleted
			{
				get
				{
					return this.Task.IsCompleted;
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00027DF0 File Offset: 0x00025FF0
			WaitHandle IAsyncResult.AsyncWaitHandle
			{
				get
				{
					/*
An exception occurred when decompiling this method (060012E8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.WaitHandle System.Threading.Tasks.TaskToApm/TaskWrapperAsyncResult::System.IAsyncResult.get_AsyncWaitHandle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Task(var_0_06, ldfld:Task(TaskWrapperAsyncResult::Task, ldloc:TaskWrapperAsyncResult(this)))
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

			// Token: 0x04000A1D RID: 2589
			internal readonly Task Task;

			// Token: 0x04000A1E RID: 2590
			private readonly object _state;

			// Token: 0x04000A1F RID: 2591
			private readonly bool _completedSynchronously;
		}

		// Token: 0x0200021C RID: 540
		[CompilerGenerated]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x060012E9 RID: 4841 RVA: 0x00027E04 File Offset: 0x00026004
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x060012EA RID: 4842 RVA: 0x00027E18 File Offset: 0x00026018
			internal void <InvokeCallbackWhenTaskCompletes>b__0()
			{
				AsyncCallback asyncCallback = this.callback;
				IAsyncResult asyncResult = this.asyncResult;
				IntPtr invoke_impl = asyncCallback.invoke_impl;
				IntPtr method_code = asyncCallback.method_code;
				IntPtr method = asyncCallback.method;
			}

			// Token: 0x04000A20 RID: 2592
			public AsyncCallback callback;

			// Token: 0x04000A21 RID: 2593
			public IAsyncResult asyncResult;
		}
	}
}
