using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001DE RID: 478
	[DebuggerDisplay("Current Count = {m_currentCount}")]
	[ComVisible(false)]
	public class SemaphoreSlim : IDisposable
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x000246B8 File Offset: 0x000228B8
		public int CurrentCount
		{
			get
			{
				return this.m_currentCount;
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000246CC File Offset: 0x000228CC
		public SemaphoreSlim(int initialCount)
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x000246DC File Offset: 0x000228DC
		public SemaphoreSlim(int initialCount, int maxCount)
		{
			this.m_maxCount = maxCount;
			this.m_currentCount = initialCount;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00024714 File Offset: 0x00022914
		public void Wait()
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00024724 File Offset: 0x00022924
		public bool Wait(int millisecondsTimeout)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00024734 File Offset: 0x00022934
		public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			int num2;
			for (;;)
			{
				int num = 1;
				this.CheckDispose();
				if (millisecondsTimeout != 0)
				{
					int tickCount = Environment.TickCount;
				}
				if (this.m_currentCount == 0)
				{
				}
				if (num == 0)
				{
				}
				if (this.m_currentCount == 0)
				{
					break;
				}
				Monitor.Enter(this.m_lockObj, num2 != 0);
				if (num != 0)
				{
					int waitCount = this.m_waitCount;
					this.m_waitCount = num;
				}
				SemaphoreSlim.TaskNode asyncHead = this.m_asyncHead;
				if (asyncHead != null)
				{
					Task<bool> task = this.WaitAsync(millisecondsTimeout, cancellationToken);
				}
				if (this.m_currentCount != 0)
				{
					goto Block_4;
				}
			}
			num2 = 20;
			bool flag;
			return flag;
			Block_4:
			if (false)
			{
				int currentCount = this.m_currentCount;
				int currentCount2 = this.m_currentCount;
				SemaphoreSlim.TaskNode asyncHead;
				this.m_currentCount = asyncHead;
				bool flag2;
				return flag2;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0002483C File Offset: 0x00022A3C
		private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			if (this.m_currentCount == 0)
			{
				int tickCount = Environment.TickCount;
				object lockObj = this.m_lockObj;
				long num = 0L;
				bool flag = Monitor.Wait(lockObj, millisecondsTimeout, num != 0L);
				return;
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0000207A File Offset: 0x0000027A
		public Task WaitAsync()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00024874 File Offset: 0x00022A74
		public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			this.CheckDispose();
			if (cancellationToken != null)
			{
				return Task.FromCancellation(cancellationToken);
			}
			object lockObj = this.m_lockObj;
			int currentCount = this.m_currentCount;
			int currentCount2 = this.m_currentCount;
			ManualResetEvent waitHandle = this.m_waitHandle;
			if (waitHandle != null && this.m_currentCount == 0)
			{
				bool flag = this.m_waitHandle.Reset();
			}
			long num = 0L;
			if (num == 0L && waitHandle != null)
			{
				while (num == 0L)
				{
				}
				Task<bool> task;
				return task;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000248E4 File Offset: 0x00022AE4
		private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			/*
An exception occurred when decompiling this method (06001149)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.SemaphoreSlim/TaskNode System.Threading.SemaphoreSlim::CreateAndAddAsyncWaiter()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TaskNode(var_0_0E, ldfld:TaskNode(SemaphoreSlim::m_asyncTail, ldloc:SemaphoreSlim(this)))
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

		// Token: 0x0600114A RID: 4426 RVA: 0x00024900 File Offset: 0x00022B00
		private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			SemaphoreSlim.TaskNode asyncHead = this.m_asyncHead;
			SemaphoreSlim.TaskNode prev = task.Prev;
			SemaphoreSlim.TaskNode next = task.Next;
			if (next != null)
			{
				SemaphoreSlim.TaskNode prev2 = task.Prev;
				next.Prev = prev2;
			}
			SemaphoreSlim.TaskNode prev3 = task.Prev;
			if (prev3 != null)
			{
				prev3.Next = next;
			}
			SemaphoreSlim.TaskNode next2 = task.Next;
			this.m_asyncHead = next2;
			SemaphoreSlim.TaskNode asyncTail = this.m_asyncTail;
			this.m_asyncTail = prev3;
			return true;
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00024968 File Offset: 0x00022B68
		private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (0600114B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Boolean> System.Threading.SemaphoreSlim::WaitUntilCountOrTimeoutAsync(System.Threading.SemaphoreSlim/TaskNode,System.Int32,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x0600114C RID: 4428 RVA: 0x00024978 File Offset: 0x00022B78
		public int Release()
		{
			return this.Release(1);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0002498C File Offset: 0x00022B8C
		public int Release(int releaseCount)
		{
			this.CheckDispose();
			Monitor.Enter(this.m_lockObj, releaseCount != 0);
			int currentCount = this.m_currentCount;
			int maxCount = this.m_maxCount;
			int waitCount = this.m_waitCount;
			Monitor.PulseAll(this.m_lockObj);
			Monitor.Pulse(this.m_lockObj);
			SemaphoreSlim.TaskNode asyncHead = this.m_asyncHead;
			if (asyncHead != null)
			{
				SemaphoreSlim.TaskNode asyncHead2 = this.m_asyncHead;
				if (asyncHead2 != null)
				{
					bool flag = this.RemoveAsyncWaiter(asyncHead2);
					if (asyncHead == null)
					{
					}
					long num = 0L;
					ThreadPool.UnsafeQueueCustomWorkItem(asyncHead2, num != 0L);
				}
			}
			ManualResetEvent waitHandle = this.m_waitHandle;
			long num2;
			if (currentCount == 0 && waitHandle != null)
			{
				bool flag2 = this.m_waitHandle.Set();
				num2 = 0L;
			}
			if (asyncHead != null)
			{
			}
			if (num2 == 0L)
			{
				string resourceString = SemaphoreSlim.GetResourceString("The releaseCount argument must be greater than zero.");
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00024A50 File Offset: 0x00022C50
		private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
			long num = 0L;
			ThreadPool.UnsafeQueueCustomWorkItem(waiterTask, num != 0L);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00024A68 File Offset: 0x00022C68
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00024A7C File Offset: 0x00022C7C
		protected virtual void Dispose(bool disposing)
		{
			if (this.m_waitHandle != null)
			{
				ManualResetEvent waitHandle = this.m_waitHandle;
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00024A98 File Offset: 0x00022C98
		private static void CancellationTokenCanceledEventHandler(object obj)
		{
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00024AC4 File Offset: 0x00022CC4
		private void CheckDispose()
		{
			/*
An exception occurred when decompiling this method (06001152)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Threading.SemaphoreSlim::CheckDispose()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:string(var_0_13, call:string(SemaphoreSlim::GetResourceString, ldstr:string("The semaphore has been disposed.")))
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

		// Token: 0x06001153 RID: 4435 RVA: 0x00024AE4 File Offset: 0x00022CE4
		private static string GetResourceString(string str)
		{
			string text;
			return text;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00024AF4 File Offset: 0x00022CF4
		// Note: this type is marked as 'beforefieldinit'.
		static SemaphoreSlim()
		{
		}

		// Token: 0x0400094D RID: 2381
		private int m_currentCount;

		// Token: 0x0400094E RID: 2382
		private readonly int m_maxCount;

		// Token: 0x0400094F RID: 2383
		private int m_waitCount;

		// Token: 0x04000950 RID: 2384
		private object m_lockObj;

		// Token: 0x04000951 RID: 2385
		private ManualResetEvent m_waitHandle;

		// Token: 0x04000952 RID: 2386
		private SemaphoreSlim.TaskNode m_asyncHead;

		// Token: 0x04000953 RID: 2387
		private SemaphoreSlim.TaskNode m_asyncTail;

		// Token: 0x04000954 RID: 2388
		private static readonly Task<bool> s_trueTask;

		// Token: 0x04000955 RID: 2389
		private static readonly Task<bool> s_falseTask;

		// Token: 0x04000956 RID: 2390
		private static Action<object> s_cancellationTokenCanceledEventHandler;

		// Token: 0x020001DF RID: 479
		private sealed class TaskNode : Task<bool>, IThreadPoolWorkItem
		{
			// Token: 0x06001155 RID: 4437 RVA: 0x00024B04 File Offset: 0x00022D04
			internal TaskNode()
			{
			}

			// Token: 0x06001156 RID: 4438 RVA: 0x00024B14 File Offset: 0x00022D14
			void IThreadPoolWorkItem.ExecuteWorkItem()
			{
			}

			// Token: 0x06001157 RID: 4439 RVA: 0x00024B24 File Offset: 0x00022D24
			void IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae)
			{
			}

			// Token: 0x04000957 RID: 2391
			internal SemaphoreSlim.TaskNode Prev;

			// Token: 0x04000958 RID: 2392
			internal SemaphoreSlim.TaskNode Next;
		}

		// Token: 0x020001E0 RID: 480
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WaitUntilCountOrTimeoutAsync>d__32 : IAsyncStateMachine
		{
			// Token: 0x06001158 RID: 4440 RVA: 0x00024B34 File Offset: 0x00022D34
			private void MoveNext()
			{
				int num = 1;
				SemaphoreSlim semaphoreSlim = this.<>4__this;
				Task task = this.<>u__2.m_task;
				this.<>1__state = num;
			}

			// Token: 0x06001159 RID: 4441 RVA: 0x00024CE8 File Offset: 0x00022EE8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000959 RID: 2393
			public int <>1__state;

			// Token: 0x0400095A RID: 2394
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x0400095B RID: 2395
			public CancellationToken cancellationToken;

			// Token: 0x0400095C RID: 2396
			public SemaphoreSlim.TaskNode asyncWaiter;

			// Token: 0x0400095D RID: 2397
			public int millisecondsTimeout;

			// Token: 0x0400095E RID: 2398
			public SemaphoreSlim <>4__this;

			// Token: 0x0400095F RID: 2399
			private CancellationTokenSource <cts>5__2;

			// Token: 0x04000960 RID: 2400
			private object <>7__wrap2;

			// Token: 0x04000961 RID: 2401
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000962 RID: 2402
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
