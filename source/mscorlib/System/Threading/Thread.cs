using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x020001F8 RID: 504
	[StructLayout(0)]
	public sealed class Thread : CriticalFinalizerObject
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x00025FEC File Offset: 0x000241EC
		private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args)
		{
			!0 <CurrentValue>k__BackingField = args.<CurrentValue>k__BackingField;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00026000 File Offset: 0x00024200
		private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args)
		{
			!0 <CurrentValue>k__BackingField = args.<CurrentValue>k__BackingField;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00026014 File Offset: 0x00024214
		public Thread(ThreadStart start)
		{
			do
			{
				base..ctor();
			}
			while (start == null);
			long num = 0L;
			this.SetStartHelper(start, (int)num);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00026034 File Offset: 0x00024234
		public Thread(ParameterizedThreadStart start)
		{
			do
			{
				base..ctor();
			}
			while (start == null);
			long num = 0L;
			this.SetStartHelper(start, (int)num);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00026054 File Offset: 0x00024254
		public Thread(ParameterizedThreadStart start, int maxStackSize)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00026074 File Offset: 0x00024274
		public void Start()
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00026084 File Offset: 0x00024284
		public void Start(object parameter)
		{
			if (this.m_Delegate != null)
			{
			}
			this.m_ThreadStartArg = parameter;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000260AC File Offset: 0x000242AC
		private void Start(StackCrawlMark stackMark)
		{
			MulticastDelegate @delegate = this.m_Delegate;
			if (@delegate == null || @delegate.m_target != null)
			{
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000260D4 File Offset: 0x000242D4
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal ExecutionContext.Reader GetExecutionContextReader()
		{
			/*
An exception occurred when decompiling this method (060011EF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.ExecutionContext/Reader System.Threading.Thread::GetExecutionContextReader()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ExecutionContext(var_0_06, ldfld:ExecutionContext(Thread::m_ExecutionContext, ldloc:Thread(this)))
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

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x000260E8 File Offset: 0x000242E8
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x000260FC File Offset: 0x000242FC
		internal bool ExecutionContextBelongsToCurrentScope
		{
			get
			{
				/*
An exception occurred when decompiling this method (060011F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.Thread::get_ExecutionContextBelongsToCurrentScope()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_06, ldfld:bool(Thread::m_ExecutionContextBelongsToOuterScope, ldloc:Thread(this)))
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
			set
			{
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0002610C File Offset: 0x0002430C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		internal ExecutionContext GetMutableExecutionContext()
		{
			ExecutionContext executionContext;
			do
			{
				executionContext = this.m_ExecutionContext;
			}
			while (executionContext == null || !this.m_ExecutionContextBelongsToOuterScope);
			ExecutionContext executionContext2 = executionContext.CreateMutableCopy();
			this.m_ExecutionContext = executionContext2;
			return executionContext2;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0002613C File Offset: 0x0002433C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
			this.m_ExecutionContext = value;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00026150 File Offset: 0x00024350
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
			this.m_ExecutionContext = value;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00026164 File Offset: 0x00024364
		public void Interrupt()
		{
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00026174 File Offset: 0x00024374
		private void InterruptInternal()
		{
		}

		// Token: 0x170001B2 RID: 434
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x00026184 File Offset: 0x00024384
		public ThreadPriority Priority
		{
			set
			{
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00026194 File Offset: 0x00024394
		private void SetPriorityNative(int priority)
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0000207A File Offset: 0x0000027A
		private bool JoinInternal(int millisecondsTimeout)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000261A4 File Offset: 0x000243A4
		public void Join()
		{
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000261B4 File Offset: 0x000243B4
		private static void SleepInternal(int millisecondsTimeout)
		{
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000261C4 File Offset: 0x000243C4
		public static void Sleep(int millisecondsTimeout)
		{
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000261DC File Offset: 0x000243DC
		public static void Sleep(TimeSpan timeout)
		{
			double totalMilliseconds = timeout.TotalMilliseconds;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0000207A File Offset: 0x0000027A
		private static bool YieldInternal()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0000207A File Offset: 0x0000027A
		public static bool Yield()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00026204 File Offset: 0x00024404
		private void SetStartHelper(Delegate start, int maxStackSize)
		{
			int processDefaultStackSize = Thread.GetProcessDefaultStackSize(maxStackSize);
			if (start != null)
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00026230 File Offset: 0x00024430
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x00026240 File Offset: 0x00024440
		public CultureInfo CurrentUICulture
		{
			get
			{
				CultureInfo cultureInfo;
				return cultureInfo;
			}
			set
			{
				while (value == null)
				{
				}
				int num = 1;
				bool flag = CultureInfo.VerifyCultureName(value, num != 0);
				Thread.nativeInitCultureAccessors();
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00026264 File Offset: 0x00024464
		internal CultureInfo GetCurrentUICultureNoAppX()
		{
			if (true)
			{
			}
			if (!true)
			{
			}
			CultureInfo defaultThreadCurrentUICulture = CultureInfo.DefaultThreadCurrentUICulture;
			if (defaultThreadCurrentUICulture != null)
			{
				return defaultThreadCurrentUICulture;
			}
			if (!true)
			{
			}
			return CultureInfo.UserDefaultUICulture;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x00026290 File Offset: 0x00024490
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000262A0 File Offset: 0x000244A0
		public CultureInfo CurrentCulture
		{
			get
			{
				CultureInfo cultureInfo;
				return cultureInfo;
			}
			set
			{
				int num;
				do
				{
					num = 1;
				}
				while (value == null);
				if (num == 0 && num == 0)
				{
					Thread.nativeInitCultureAccessors();
				}
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x000262C0 File Offset: 0x000244C0
		private CultureInfo GetCurrentCultureNoAppX()
		{
			if (true)
			{
			}
			if (!true)
			{
			}
			CultureInfo defaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentCulture;
			if (defaultThreadCurrentCulture != null)
			{
				return defaultThreadCurrentCulture;
			}
			if (!true)
			{
			}
			return CultureInfo.UserDefaultCulture;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000262EC File Offset: 0x000244EC
		private static void nativeInitCultureAccessors()
		{
			if (!true)
			{
			}
			CultureInfo cultureInfo = CultureInfo.ConstructCurrentCulture();
			CultureInfo cultureInfo2 = CultureInfo.ConstructCurrentUICulture();
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0002630C File Offset: 0x0002450C
		public static void MemoryBarrier()
		{
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0002631C File Offset: 0x0002451C
		private void ConstructInternalThread()
		{
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0002632C File Offset: 0x0002452C
		private InternalThread Internal
		{
			get
			{
				while (this.internal_thread != null)
				{
				}
				return this.internal_thread;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00026348 File Offset: 0x00024548
		public static Context CurrentContext
		{
			get
			{
				return AppDomain.InternalGetContext();
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0002635C File Offset: 0x0002455C
		private static void GetCurrentThread_icall(Thread thread)
		{
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000207A File Offset: 0x0000027A
		private static Thread GetCurrentThread()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x0000207A File Offset: 0x0000027A
		public static Thread CurrentThread
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0000207A File Offset: 0x0000027A
		public static int GetDomainID()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0000207A File Offset: 0x0000027A
		private bool Thread_internal(MulticastDelegate start)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0002636C File Offset: 0x0002456C
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00026380 File Offset: 0x00024580
		public bool IsThreadPoolThread
		{
			get
			{
				while (this.internal_thread != null)
				{
				}
				return this.internal_thread.threadpool_thread;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000263A0 File Offset: 0x000245A0
		internal bool IsThreadPoolThreadInternal
		{
			get
			{
				while (this.internal_thread != null)
				{
				}
				return this.internal_thread.threadpool_thread;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x000263C0 File Offset: 0x000245C0
		public bool IsAlive
		{
			get
			{
				if (this.internal_thread == null)
				{
					InternalThread internalThread = this.internal_thread;
					return;
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x000263E0 File Offset: 0x000245E0
		public bool IsBackground
		{
			set
			{
				ThreadState threadState = this.ValidateThreadState();
				if (this.internal_thread == null)
				{
					InternalThread internalThread = this.internal_thread;
				}
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0000207A File Offset: 0x0000027A
		private static string GetName_internal(InternalThread thread)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00026404 File Offset: 0x00024604
		private unsafe static void SetName_icall(InternalThread thread, char* name, int nameLength)
		{
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00026414 File Offset: 0x00024614
		private static void SetName_internal(InternalThread thread, string name)
		{
			if (name != null)
			{
				int offsetToStringData = RuntimeHelpers.OffsetToStringData;
				int stringLength = name._stringLength;
				return;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00026434 File Offset: 0x00024634
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x00026450 File Offset: 0x00024650
		public string Name
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001219)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Threading.Thread::get_Name()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InternalThread(var_0_0E, ldfld:InternalThread(Thread::internal_thread, ldloc:Thread(this)))
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
			set
			{
				while (this.internal_thread != null)
				{
				}
				Thread.SetName_internal(this.internal_thread, value);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x00026474 File Offset: 0x00024674
		public ThreadState ThreadState
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600121B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.ThreadState System.Threading.Thread::get_ThreadState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InternalThread(var_0_0E, ldfld:InternalThread(Thread::internal_thread, ldloc:Thread(this)))
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

		// Token: 0x0600121C RID: 4636 RVA: 0x00026490 File Offset: 0x00024690
		private static void Abort_internal(InternalThread thread, object stateInfo)
		{
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x000264A0 File Offset: 0x000246A0
		public void Abort()
		{
			if (this.internal_thread == null)
			{
				InternalThread internalThread = this.internal_thread;
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x000264BC File Offset: 0x000246BC
		private static void SpinWait_nop()
		{
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x000264CC File Offset: 0x000246CC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void SpinWait(int iterations)
		{
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000264DC File Offset: 0x000246DC
		private void StartInternal(object principal, StackCrawlMark stackMark)
		{
			MulticastDelegate @delegate = this.m_Delegate;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000264F0 File Offset: 0x000246F0
		private static void SetState(InternalThread thread, ThreadState set)
		{
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00026500 File Offset: 0x00024700
		private static void ClrState(InternalThread thread, ThreadState clr)
		{
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0000207A File Offset: 0x0000027A
		private static ThreadState GetState(InternalThread thread)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0000207A File Offset: 0x0000027A
		private static int SystemMaxStackStize()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00026510 File Offset: 0x00024710
		private static int GetProcessDefaultStackSize(int maxStackSize)
		{
			int num = 1;
			int pageSize = Environment.GetPageSize();
			if (num != 0)
			{
			}
			return Math.Min(0, pageSize);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00026538 File Offset: 0x00024738
		private void SetStart(MulticastDelegate start, int maxStackSize)
		{
			InternalThread internalThread;
			do
			{
				internalThread = this.internal_thread;
				this.m_Delegate = start;
			}
			while (internalThread != null);
			this.internal_thread.stack_size = maxStackSize;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x00026564 File Offset: 0x00024764
		public int ManagedThreadId
		{
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
			get
			{
				while (this.internal_thread != null)
				{
				}
				return this.internal_thread.managed_id;
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00026584 File Offset: 0x00024784
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public static void BeginCriticalRegion()
		{
			Thread currentThread;
			do
			{
				currentThread = Thread.CurrentThread;
			}
			while (currentThread.internal_thread != null);
			int critical_region_level = currentThread.internal_thread.critical_region_level;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000265AC File Offset: 0x000247AC
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static void EndCriticalRegion()
		{
			Thread currentThread;
			do
			{
				currentThread = Thread.CurrentThread;
			}
			while (currentThread.internal_thread != null);
			int critical_region_level = currentThread.internal_thread.critical_region_level;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000265D4 File Offset: 0x000247D4
		public void SetApartmentState(ApartmentState state)
		{
			bool flag = this.TrySetApartmentState(state);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000265EC File Offset: 0x000247EC
		public bool TrySetApartmentState(ApartmentState state)
		{
			InternalThread internalThread2;
			do
			{
				ThreadState threadState = this.ThreadState;
				InternalThread internalThread;
				if (this.internal_thread == null)
				{
					internalThread = this.internal_thread;
				}
				byte apartment_state = internalThread.apartment_state;
				if (internalThread == null)
				{
					internalThread2 = this.internal_thread;
					byte apartment_state2 = internalThread2.apartment_state;
				}
			}
			while (internalThread2 != null);
			this.internal_thread.apartment_state = (byte)state;
			return true;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0002663C File Offset: 0x0002483C
		[ComVisible(false)]
		public override int GetHashCode()
		{
			while (this.internal_thread != null)
			{
			}
			return this.internal_thread.managed_id;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0002665C File Offset: 0x0002485C
		private ThreadState ValidateThreadState()
		{
			/*
An exception occurred when decompiling this method (0600122D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.ThreadState System.Threading.Thread::ValidateThreadState()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InternalThread(var_0_0E, ldfld:InternalThread(Thread::internal_thread, ldloc:Thread(this)))
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

		// Token: 0x040009A0 RID: 2464
		private static LocalDataStoreMgr s_LocalDataStoreMgr;

		// Token: 0x040009A1 RID: 2465
		[ThreadStatic]
		private static LocalDataStoreHolder s_LocalDataStore;

		// Token: 0x040009A2 RID: 2466
		[ThreadStatic]
		internal static CultureInfo m_CurrentCulture;

		// Token: 0x040009A3 RID: 2467
		[ThreadStatic]
		internal static CultureInfo m_CurrentUICulture;

		// Token: 0x040009A4 RID: 2468
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

		// Token: 0x040009A5 RID: 2469
		private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

		// Token: 0x040009A6 RID: 2470
		private InternalThread internal_thread;

		// Token: 0x040009A7 RID: 2471
		private object m_ThreadStartArg;

		// Token: 0x040009A8 RID: 2472
		private object pending_exception;

		// Token: 0x040009A9 RID: 2473
		[ThreadStatic]
		private static Thread current_thread;

		// Token: 0x040009AA RID: 2474
		private MulticastDelegate m_Delegate;

		// Token: 0x040009AB RID: 2475
		private ExecutionContext m_ExecutionContext;

		// Token: 0x040009AC RID: 2476
		private bool m_ExecutionContextBelongsToOuterScope;

		// Token: 0x040009AD RID: 2477
		private IPrincipal principal;

		// Token: 0x040009AE RID: 2478
		private int principal_version;
	}
}
