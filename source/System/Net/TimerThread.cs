using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001FF RID: 511
	internal static class TimerThread
	{
		// Token: 0x06000C88 RID: 3208 RVA: 0x00028008 File Offset: 0x00026208
		static TimerThread()
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x0002802C File Offset: 0x0002622C
		internal static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			if (!true)
			{
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00028050 File Offset: 0x00026250
		internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds)
		{
			if (!true)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000280DC File Offset: 0x000262DC
		private static void Prod()
		{
			if (!true)
			{
			}
			int num = 1;
			long num2 = 0L;
			bool flag;
			if (Interlocked.CompareExchange(flag ? 1 : 0, num, (int)num2) != 0)
			{
				return;
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00028100 File Offset: 0x00026300
		private static void ThreadProc()
		{
			int num = 1;
			Thread currentThread = Thread.CurrentThread;
			int num2 = 1;
			currentThread.IsBackground = num2 != 0;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			int num3 = 1;
			int num4 = 1;
			int num5 = Interlocked.CompareExchange(0, num3, num4);
			if (num == 0)
			{
			}
			if (!false)
			{
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00028254 File Offset: 0x00026454
		private static void StopTimerThread()
		{
			if (!true)
			{
			}
			int num = 2;
			int num2 = Interlocked.Exchange(int.MinValue, num);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00002050 File Offset: 0x00000250
		private static bool IsTickBetween(int start, int end, int comparand)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00028274 File Offset: 0x00026474
		private static void OnDomainUnload(object sender, EventArgs e)
		{
			TimerThread.StopTimerThread();
		}

		// Token: 0x04000ABA RID: 2746
		private const int c_ThreadIdleTimeoutMilliseconds = 30000;

		// Token: 0x04000ABB RID: 2747
		private const int c_CacheScanPerIterations = 32;

		// Token: 0x04000ABC RID: 2748
		private const int c_TickCountResolution = 15;

		// Token: 0x04000ABD RID: 2749
		private static global::System.Collections.Generic.LinkedList<WeakReference> s_Queues;

		// Token: 0x04000ABE RID: 2750
		private static global::System.Collections.Generic.LinkedList<WeakReference> s_NewQueues;

		// Token: 0x04000ABF RID: 2751
		private static int s_ThreadState;

		// Token: 0x04000AC0 RID: 2752
		private static AutoResetEvent s_ThreadReadyEvent;

		// Token: 0x04000AC1 RID: 2753
		private static ManualResetEvent s_ThreadShutdownEvent;

		// Token: 0x04000AC2 RID: 2754
		private static WaitHandle[] s_ThreadEvents;

		// Token: 0x04000AC3 RID: 2755
		private static int s_CacheScanIteration;

		// Token: 0x04000AC4 RID: 2756
		private static Hashtable s_QueuesCache;

		// Token: 0x02000200 RID: 512
		internal abstract class Queue
		{
			// Token: 0x06000C90 RID: 3216 RVA: 0x0002828C File Offset: 0x0002648C
			internal Queue(int durationMilliseconds)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000C91 RID: 3217 RVA: 0x000282A8 File Offset: 0x000264A8
			internal int Duration
			{
				get
				{
					return this.m_DurationMilliseconds;
				}
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
			internal TimerThread.Timer CreateTimer()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000C93 RID: 3219
			internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);

			// Token: 0x04000AC5 RID: 2757
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x02000201 RID: 513
		internal abstract class Timer : IDisposable
		{
			// Token: 0x06000C94 RID: 3220 RVA: 0x000282BC File Offset: 0x000264BC
			internal Timer(int durationMilliseconds)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
				int tickCount = Environment.TickCount;
				this.m_StartTimeMilliseconds = tickCount;
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000C95 RID: 3221 RVA: 0x000282E8 File Offset: 0x000264E8
			internal int Duration
			{
				get
				{
					return this.m_DurationMilliseconds;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x000282FC File Offset: 0x000264FC
			internal int StartTime
			{
				get
				{
					return this.m_StartTimeMilliseconds;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00028310 File Offset: 0x00026510
			internal int Expiration
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000C97)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.TimerThread/Timer::get_Expiration()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Timer::m_StartTimeMilliseconds, ldloc:Timer(this)))
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

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00028324 File Offset: 0x00026524
			internal int TimeRemaining
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000C98)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.TimerThread/Timer::get_TimeRemaining()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_08, ldfld:int32(Timer::m_DurationMilliseconds, ldloc:Timer(this)))
	stloc:int32(var_3_10, callgetter:int32(Environment::get_TickCount))
	stloc:int32(var_4_17, ldfld:int32(Timer::m_StartTimeMilliseconds, ldloc:Timer(this)))
	stloc:int32(var_5_1F, ldfld:int32(Timer::m_StartTimeMilliseconds, ldloc:Timer(this)))
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

			// Token: 0x06000C99 RID: 3225
			internal abstract bool Cancel();

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000C9A RID: 3226
			internal abstract bool HasExpired { get; }

			// Token: 0x06000C9B RID: 3227 RVA: 0x00028354 File Offset: 0x00026554
			public void Dispose()
			{
			}

			// Token: 0x04000AC6 RID: 2758
			private readonly int m_StartTimeMilliseconds;

			// Token: 0x04000AC7 RID: 2759
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x02000202 RID: 514
		internal sealed class Callback : MulticastDelegate
		{
			// Token: 0x06000C9C RID: 3228 RVA: 0x00028364 File Offset: 0x00026564
			public Callback(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000C9D RID: 3229 RVA: 0x000283C4 File Offset: 0x000265C4
			public void Invoke(TimerThread.Timer timer, int timeNoticed, object context)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
			public IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object @object)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x000283E8 File Offset: 0x000265E8
			public void EndInvoke(IAsyncResult result)
			{
			}
		}

		// Token: 0x02000203 RID: 515
		private enum TimerThreadState
		{
			// Token: 0x04000AC9 RID: 2761
			Idle,
			// Token: 0x04000ACA RID: 2762
			Running,
			// Token: 0x04000ACB RID: 2763
			Stopped
		}

		// Token: 0x02000204 RID: 516
		private class TimerQueue : TimerThread.Queue
		{
			// Token: 0x06000CA0 RID: 3232 RVA: 0x000283F8 File Offset: 0x000265F8
			internal TimerQueue(int durationMilliseconds)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
				int tickCount = Environment.TickCount;
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x0002841C File Offset: 0x0002661C
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				int durationMilliseconds = this.m_DurationMilliseconds;
				TimerThread.TimerNode timers = this.m_Timers;
				TimerThread.TimerNode timers2 = this.m_Timers;
				TimerThread.TimerNode next = this.m_Timers.next;
				IntPtr thisHandle = this.m_ThisHandle;
				GCHandle gchandle = GCHandle.Alloc(this);
				this.m_ThisHandle = gchandle;
				TimerThread.TimerNode timers3 = this.m_Timers;
				TimerThread.TimerNode prev = timers3.prev;
				TimerThread.TimerNode prev2 = timers3.prev;
				if (timers3 != null)
				{
					Monitor.Exit(timers2);
				}
				TimerThread.Prod();
				Monitor.Exit(timers2);
				throw new OutOfMemoryException();
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x000284AC File Offset: 0x000266AC
			internal bool Fire([Out] int nextExpiration)
			{
				TimerThread.TimerNode timers = this.m_Timers;
				TimerThread.TimerNode next = timers.next;
				Monitor.Enter(timers, nextExpiration != 0);
				TimerThread.TimerNode next2 = this.m_Timers.next;
				IntPtr thisHandle = this.m_ThisHandle;
				((GCHandle)this.m_ThisHandle).Free();
				long num = 0L;
				int num2 = 6;
				Monitor.Exit(timers);
				if (num == 0L)
				{
					if (num2 == 0)
					{
						return next2.Fire();
					}
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x04000ACC RID: 2764
			private IntPtr m_ThisHandle;

			// Token: 0x04000ACD RID: 2765
			private readonly TimerThread.TimerNode m_Timers;
		}

		// Token: 0x02000205 RID: 517
		private class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x06000CA3 RID: 3235 RVA: 0x0002855C File Offset: 0x0002675C
			internal InfiniteTimerQueue()
			{
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x00028570 File Offset: 0x00026770
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				/*
An exception occurred when decompiling this method (06000CA4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.TimerThread/Timer System.Net.TimerThread/InfiniteTimerQueue::CreateTimer(System.Net.TimerThread/Callback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_07, callgetter:int32(Environment::get_TickCount))
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

		// Token: 0x02000206 RID: 518
		private class TimerNode : TimerThread.Timer
		{
			// Token: 0x06000CA5 RID: 3237 RVA: 0x00028584 File Offset: 0x00026784
			internal TimerNode(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
				int tickCount = Environment.TickCount;
				this.m_StartTimeMilliseconds = tickCount;
				if (callback != null)
				{
					this.m_Callback = callback;
				}
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x000285B8 File Offset: 0x000267B8
			internal TimerNode()
			{
				int tickCount = Environment.TickCount;
				this.m_StartTimeMilliseconds = tickCount;
				this.m_TimerState = TimerThread.TimerNode.TimerState.Sentinel;
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000285E4 File Offset: 0x000267E4
			internal override bool HasExpired
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000CA7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.TimerThread/TimerNode::get_HasExpired()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:TimerState(var_0_06, ldfld:TimerState(TimerNode::m_TimerState, ldloc:TimerNode(this)))
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

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000285F8 File Offset: 0x000267F8
			// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x0002860C File Offset: 0x0002680C
			internal TimerThread.TimerNode Next
			{
				get
				{
					return this.next;
				}
				set
				{
					this.next = value;
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00028620 File Offset: 0x00026820
			// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00028634 File Offset: 0x00026834
			internal TimerThread.TimerNode Prev
			{
				get
				{
					return this.prev;
				}
				set
				{
					this.prev = value;
				}
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x00028648 File Offset: 0x00026848
			internal override bool Cancel()
			{
				if (this.m_TimerState == TimerThread.TimerNode.TimerState.Ready)
				{
					object queueLock = this.m_QueueLock;
					TimerThread.TimerNode.TimerState timerState = this.m_TimerState;
					long num = 0L;
					if (timerState != TimerThread.TimerNode.TimerState.Ready)
					{
					}
					TimerThread.TimerNode timerNode = this.next;
					TimerThread.TimerNode timerNode2 = this.prev;
					timerNode.prev = timerNode2;
					this.prev.next = timerNode;
					this.m_TimerState = TimerThread.TimerNode.TimerState.Cancelled;
					if (timerNode != null)
					{
						Monitor.Exit(queueLock);
					}
					if (num == 0L)
					{
					}
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x000286C4 File Offset: 0x000268C4
			internal bool Fire()
			{
				if (this.m_TimerState != TimerThread.TimerNode.TimerState.Ready)
				{
				}
				int tickCount = Environment.TickCount;
				int startTimeMilliseconds = this.m_StartTimeMilliseconds;
				TimerThread.TimerNode.TimerState timerState = this.m_TimerState;
				object queueLock = this.m_QueueLock;
				if (this.m_TimerState != TimerThread.TimerNode.TimerState.Ready)
				{
				}
				TimerThread.TimerNode timerNode = this.next;
				TimerThread.TimerNode timerNode2 = this.prev;
				int num = 1;
				this.m_TimerState = (TimerThread.TimerNode.TimerState)num;
				long num2 = 0L;
				timerNode.prev = timerNode2;
				TimerThread.TimerNode timerNode3 = this.prev;
				int num3 = 5;
				timerNode3.next = timerNode;
				if (this.m_Callback != null)
				{
					Monitor.Exit(queueLock);
				}
				if (num2 == 0L)
				{
					while (num3 != 0)
					{
					}
					TimerThread.Callback callback = this.m_Callback;
					object context = this.m_Context;
					IntPtr method_code = callback.method_code;
					IntPtr invoke_impl = callback.invoke_impl;
					IntPtr method = callback.method;
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x04000ACE RID: 2766
			private TimerThread.TimerNode.TimerState m_TimerState;

			// Token: 0x04000ACF RID: 2767
			private TimerThread.Callback m_Callback;

			// Token: 0x04000AD0 RID: 2768
			private object m_Context;

			// Token: 0x04000AD1 RID: 2769
			private object m_QueueLock;

			// Token: 0x04000AD2 RID: 2770
			private TimerThread.TimerNode next;

			// Token: 0x04000AD3 RID: 2771
			private TimerThread.TimerNode prev;

			// Token: 0x02000207 RID: 519
			private enum TimerState
			{
				// Token: 0x04000AD5 RID: 2773
				Ready,
				// Token: 0x04000AD6 RID: 2774
				Fired,
				// Token: 0x04000AD7 RID: 2775
				Cancelled,
				// Token: 0x04000AD8 RID: 2776
				Sentinel
			}
		}

		// Token: 0x02000208 RID: 520
		private class InfiniteTimer : TimerThread.Timer
		{
			// Token: 0x06000CAE RID: 3246 RVA: 0x000287A8 File Offset: 0x000269A8
			internal InfiniteTimer()
			{
				int tickCount = Environment.TickCount;
				this.m_StartTimeMilliseconds = tickCount;
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000287CC File Offset: 0x000269CC
			internal override bool HasExpired
			{
				get
				{
				}
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
			internal override bool Cancel()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000AD9 RID: 2777
			private int cancelled;
		}
	}
}
