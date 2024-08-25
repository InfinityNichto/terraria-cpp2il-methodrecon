using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000490 RID: 1168
	public struct AsyncTaskMethodBuilder<TResult>
	{
		// Token: 0x06002267 RID: 8807 RVA: 0x0000207A File Offset: 0x0000027A
		public static AsyncTaskMethodBuilder<TResult> Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0004D600 File Offset: 0x0004B800
		[DebuggerStepThrough]
		public void Start<TStateMachine>(TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			if (!true)
			{
			}
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0004D62C File Offset: 0x0004B82C
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0004D63C File Offset: 0x0004B83C
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(TAwaiter awaiter, TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
			bool loggingOn = AsyncCausalityTracer.LoggingOn;
			Task task = this.Task;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x0004D66C File Offset: 0x0004B86C
		public Task<TResult> Task
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600226B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1::get_Task()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Task`1(var_0_0E, ldfld:class System.Threading.Tasks.Task`1<!TResult>[exp:Task`1](AsyncTaskMethodBuilder`1::m_task, ldloc:valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1&(this)))
	stfld:class System.Threading.Tasks.Task`1<!TResult>(AsyncTaskMethodBuilder`1::m_task, ldloc:valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1&(this), ldloc:valuetype System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1&[exp:class System.Threading.Tasks.Task`1<!TResult>](this))
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

		// Token: 0x0600226C RID: 8812 RVA: 0x0004D690 File Offset: 0x0004B890
		public void SetResult(TResult result)
		{
			Task task = this.m_task;
			if (task != null)
			{
				bool loggingOn = AsyncCausalityTracer.LoggingOn;
				int id = task.Id;
				if (!true)
				{
				}
				if (true)
				{
					global::System.Threading.Tasks.Task.RemoveFromActiveTasks(task.Id);
				}
				return;
			}
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0004D6D8 File Offset: 0x0004B8D8
		internal void SetResult(Task<TResult> completedTask)
		{
			long num;
			if (this.m_task != null)
			{
				num = 0L;
				return;
			}
			this.m_task = num;
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0004D6F8 File Offset: 0x0004B8F8
		public void SetException(Exception exception)
		{
			while (exception == null || this.m_task != null)
			{
			}
			bool flag = this.Task.TrySetException(exception);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0004D728 File Offset: 0x0004B928
		internal static Task<TResult> GetTaskForResult(TResult result)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0004D73C File Offset: 0x0004B93C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskMethodBuilder()
		{
			if (!true)
			{
			}
		}

		// Token: 0x040012CC RID: 4812
		internal static readonly Task<TResult> s_defaultResultTask;

		// Token: 0x040012CD RID: 4813
		private AsyncMethodBuilderCore m_coreState;

		// Token: 0x040012CE RID: 4814
		private Task<TResult> m_task;
	}
}
