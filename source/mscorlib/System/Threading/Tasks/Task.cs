using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace System.Threading.Tasks
{
	// Token: 0x0200022A RID: 554
	[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
	[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<>))]
	public class Task<TResult> : Task
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x00028474 File Offset: 0x00026674
		internal Task()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0002848C File Offset: 0x0002668C
		internal Task(object state, TaskCreationOptions options)
		{
			if (!true)
			{
			}
			base..ctor(state, options, true);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000284A8 File Offset: 0x000266A8
		internal Task(TResult result)
		{
			if (!true)
			{
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000284B8 File Offset: 0x000266B8
		internal Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
		{
			if (!true)
			{
			}
			base..ctor(canceled, creationOptions, ct);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000284D4 File Offset: 0x000266D4
		public Task(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
		{
			if (!true)
			{
			}
			Task task = Task.InternalCurrentIfAttached(creationOptions);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000284EC File Offset: 0x000266EC
		internal Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (!true)
			{
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000284FC File Offset: 0x000266FC
		internal Task(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			if (!true)
			{
			}
			base..ctor(valueSelector, state, parent, cancellationToken, creationOptions, internalOptions, scheduler);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00028520 File Offset: 0x00026720
		internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			while (parent != null && internalOptions == InternalTaskOptions.None)
			{
			}
			return "function";
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0002853C File Offset: 0x0002673C
		internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
		{
			while (parent != null && internalOptions == InternalTaskOptions.None)
			{
			}
			return "function";
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00028558 File Offset: 0x00026758
		internal bool TrySetResult(TResult result)
		{
			bool isCompleted = base.IsCompleted;
			bool flag = base.AtomicStateUpdate(1024, 1376);
			if (this.m_result != null)
			{
			}
			base.FinishStageThree();
			return true;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00028590 File Offset: 0x00026790
		internal void DangerousSetResult(TResult result)
		{
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x0000207A File Offset: 0x0000027A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public TResult Result
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0000207A File Offset: 0x0000027A
		internal TResult ResultOnSuccess
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000285A0 File Offset: 0x000267A0
		internal TResult GetResultCore(bool waitCompletionNotification)
		{
			/*
An exception occurred when decompiling this method (06001343)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TResult System.Threading.Tasks.Task`1::GetResultCore(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, callgetter:bool(Task::get_IsCompleted, ldloc:Task`1[exp:Task](this)))
	stloc:bool(var_2_0D, call:bool(Task::NotifyDebuggerOfWaitCompletionIfNecessary, ldloc:Task`1[exp:Task](this)))
	stloc:bool(var_3_14, callgetter:bool(Task::get_IsCompletedSuccessfully, ldloc:Task`1[exp:Task](this)))
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

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0000207A File Offset: 0x0000027A
		public new static TaskFactory<TResult> Factory
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000285C4 File Offset: 0x000267C4
		internal override void InnerInvoke()
		{
			if (this != null)
			{
				return;
			}
			if (this != null)
			{
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0000207A File Offset: 0x0000027A
		public new TaskAwaiter<TResult> GetAwaiter()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0000207A File Offset: 0x0000027A
		public new ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0000207A File Offset: 0x0000027A
		public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000285D8 File Offset: 0x000267D8
		internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			while (continuationAction != null && scheduler == null)
			{
			}
			return "continuationAction";
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000285F0 File Offset: 0x000267F0
		public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			if (!true)
			{
			}
			TaskScheduler taskScheduler = TaskScheduler.Current;
			return this;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0002860C File Offset: 0x0002680C
		internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions)
		{
			while (scheduler == null)
			{
			}
			return "continuationFunction";
		}

		// Token: 0x04000A3E RID: 2622
		internal TResult m_result;

		// Token: 0x04000A3F RID: 2623
		private static TaskFactory<TResult> s_defaultFactory;
	}
}
