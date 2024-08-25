using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x0200020F RID: 527
	[ComVisible(true)]
	public sealed class Timer : MarshalByRefObject, IDisposable
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0002772C File Offset: 0x0002592C
		private static Timer.Scheduler scheduler
		{
			get
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				return 1;
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00027740 File Offset: 0x00025940
		public Timer(TimerCallback callback, object state, int dueTime, int period)
		{
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00027754 File Offset: 0x00025954
		public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
		{
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00027768 File Offset: 0x00025968
		private void Init(TimerCallback callback, object state, long dueTime, long period)
		{
			while (callback == null)
			{
			}
			this.callback = callback;
			this.state = state;
			bool flag = this.Change(dueTime, period, true);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00027794 File Offset: 0x00025994
		public bool Change(int dueTime, int period)
		{
			long num = 0L;
			bool flag = this.Change((long)dueTime, (long)period, num != 0L);
			return true;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000277B0 File Offset: 0x000259B0
		public bool Change(TimeSpan dueTime, TimeSpan period)
		{
			return true;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000277C0 File Offset: 0x000259C0
		public void Dispose()
		{
			if (this.disposed)
			{
				return;
			}
			this.disposed = true;
			Timer.scheduler.Remove(this);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000277E8 File Offset: 0x000259E8
		private bool Change(long dueTime, long period, bool first)
		{
			/*
An exception occurred when decompiling this method (060012B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Timer::Change(System.Int64,System.Int64,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003A:
	stloc:string(var_0_44, call:string(Environment::GetResourceString, ldstr:string("Cannot access a disposed object.")))
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

		// Token: 0x060012B8 RID: 4792 RVA: 0x0002783C File Offset: 0x00025A3C
		internal void KeepRootedWhileScheduled()
		{
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0000207A File Offset: 0x0000027A
		private static long GetTimeMonotonic()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000A0B RID: 2571
		private TimerCallback callback;

		// Token: 0x04000A0C RID: 2572
		private object state;

		// Token: 0x04000A0D RID: 2573
		private long due_time_ms;

		// Token: 0x04000A0E RID: 2574
		private long period_ms;

		// Token: 0x04000A0F RID: 2575
		private long next_run;

		// Token: 0x04000A10 RID: 2576
		private bool disposed;

		// Token: 0x04000A11 RID: 2577
		private bool is_dead;

		// Token: 0x04000A12 RID: 2578
		private bool is_added;

		// Token: 0x02000210 RID: 528
		private struct TimerComparer : IComparer, IComparer<Timer>
		{
			// Token: 0x060012BA RID: 4794 RVA: 0x0002784C File Offset: 0x00025A4C
			int IComparer.Compare(object x, object y)
			{
				if (x != null)
				{
				}
				if (y != null)
				{
				}
				return 1;
			}

			// Token: 0x060012BB RID: 4795 RVA: 0x00027864 File Offset: 0x00025A64
			public int Compare(Timer tx, Timer ty)
			{
				int num = 1;
				long next_run = tx.next_run;
				long next_run2 = ty.next_run;
				if (num == 0)
				{
				}
				int num2;
				return num2;
			}
		}

		// Token: 0x02000211 RID: 529
		private sealed class Scheduler
		{
			// Token: 0x060012BC RID: 4796 RVA: 0x00027888 File Offset: 0x00025A88
			private void InitScheduler()
			{
			}

			// Token: 0x060012BD RID: 4797 RVA: 0x00027898 File Offset: 0x00025A98
			private void WakeupScheduler()
			{
				bool flag = this.changed.Set();
			}

			// Token: 0x060012BE RID: 4798 RVA: 0x000278B4 File Offset: 0x00025AB4
			private void SchedulerThread()
			{
				Thread currentThread = Thread.CurrentThread;
				Monitor.Enter(this, false);
				bool flag = this.changed.Reset();
				int num = this.RunSchedulerLoop();
				long num2 = 0L;
				if (true)
				{
					Monitor.Exit(this);
				}
				if (num2 == 0L)
				{
					ManualResetEvent manualResetEvent = this.changed;
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x060012BF RID: 4799 RVA: 0x00027918 File Offset: 0x00025B18
			public static Timer.Scheduler Instance
			{
				get
				{
					if (!true)
					{
					}
					return 1;
				}
			}

			// Token: 0x060012C0 RID: 4800 RVA: 0x0002792C File Offset: 0x00025B2C
			private Scheduler()
			{
				this.InitScheduler();
			}

			// Token: 0x060012C1 RID: 4801 RVA: 0x0002794C File Offset: 0x00025B4C
			public void Remove(Timer timer)
			{
				timer.is_dead = true;
				long num = 0L;
				this.needReSort = true;
				Monitor.Exit(this);
				if (num == 0L)
				{
					return;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x060012C2 RID: 4802 RVA: 0x00027994 File Offset: 0x00025B94
			public void Change(Timer timer, long new_next_run)
			{
				if (timer.is_dead)
				{
				}
			}

			// Token: 0x060012C3 RID: 4803 RVA: 0x0000207A File Offset: 0x0000027A
			private void Add(Timer timer)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060012C4 RID: 4804 RVA: 0x000279D8 File Offset: 0x00025BD8
			private void InternalRemove(Timer timer)
			{
				timer.is_dead = true;
				this.needReSort = true;
			}

			// Token: 0x060012C5 RID: 4805 RVA: 0x000279F4 File Offset: 0x00025BF4
			private static void TimerCB(object o)
			{
				if (o != null)
				{
				}
			}

			// Token: 0x060012C6 RID: 4806 RVA: 0x00027A0C File Offset: 0x00025C0C
			private void FireTimer(Timer timer)
			{
				if (timer.period_ms == 0L)
				{
					long due_time_ms = timer.due_time_ms;
					return;
				}
				long period_ms = timer.period_ms;
				long num = 0L;
				timer.next_run = period_ms;
				timer.is_dead = num != 0L;
			}

			// Token: 0x060012C7 RID: 4807 RVA: 0x00027A44 File Offset: 0x00025C44
			private int RunSchedulerLoop()
			{
				/*
An exception occurred when decompiling this method (060012C7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Threading.Timer/Scheduler::RunSchedulerLoop()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_008A:
	stfld:int64(Scheduler::current_next_run, ldloc:Scheduler(this), ldloc:int64(var_3))
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

			// Token: 0x060012C8 RID: 4808 RVA: 0x00027AE8 File Offset: 0x00025CE8
			// Note: this type is marked as 'beforefieldinit'.
			static Scheduler()
			{
			}

			// Token: 0x04000A13 RID: 2579
			private static readonly Timer.Scheduler instance;

			// Token: 0x04000A14 RID: 2580
			private bool needReSort = true;

			// Token: 0x04000A15 RID: 2581
			private List<Timer> list;

			// Token: 0x04000A16 RID: 2582
			private long current_next_run;

			// Token: 0x04000A17 RID: 2583
			private ManualResetEvent changed;
		}
	}
}
