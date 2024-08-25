using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Threading
{
	// Token: 0x02000200 RID: 512
	internal sealed class ThreadPoolWorkQueue
	{
		// Token: 0x06001239 RID: 4665 RVA: 0x00026818 File Offset: 0x00024A18
		public ThreadPoolWorkQueue()
		{
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0000207A File Offset: 0x0000027A
		public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0002682C File Offset: 0x00024A2C
		internal void EnsureThreadRequested()
		{
			int num = 1;
			int num2 = this.numOutstandingThreadRequests;
			if (num == 0)
			{
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00026848 File Offset: 0x00024A48
		internal void MarkThreadRequestSatisfied()
		{
			int num = this.numOutstandingThreadRequests;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0002685C File Offset: 0x00024A5C
		public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
		{
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00026888 File Offset: 0x00024A88
		internal bool LocalFindAndPop(IThreadPoolWorkItem callback)
		{
			bool flag;
			return flag;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0000207A File Offset: 0x0000027A
		public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, [Out] IThreadPoolWorkItem callback, [Out] bool missedSteal)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00026898 File Offset: 0x00024A98
		internal static bool Dispatch()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int tickCount = Environment.TickCount;
			int tickCount2 = Environment.TickCount;
			if (num == 0)
			{
			}
			long num3;
			if (num != 0)
			{
				int value = 1.m_value;
				long num2 = 0L;
				num3 = 0L;
				int num4 = 9;
				if (num2 != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num4 != 0)
				{
					return false;
				}
			}
			long value2 = num3.m_value;
			int num5 = 1;
			while (num5 != 0)
			{
			}
			if (value2 != 0L)
			{
			}
			return false;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0002693C File Offset: 0x00024B3C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolWorkQueue()
		{
		}

		// Token: 0x040009B8 RID: 2488
		internal ThreadPoolWorkQueue.QueueSegment queueHead;

		// Token: 0x040009B9 RID: 2489
		internal ThreadPoolWorkQueue.QueueSegment queueTail;

		// Token: 0x040009BA RID: 2490
		internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues;

		// Token: 0x040009BB RID: 2491
		private int numOutstandingThreadRequests;

		// Token: 0x02000201 RID: 513
		internal class SparseArray<T> where T : class
		{
			// Token: 0x06001242 RID: 4674 RVA: 0x0002694C File Offset: 0x00024B4C
			internal SparseArray(int initialSize)
			{
				this.m_array = this;
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x06001243 RID: 4675 RVA: 0x0000207A File Offset: 0x0000027A
			internal T[] Current
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06001244 RID: 4676 RVA: 0x0000207A File Offset: 0x0000027A
			internal int Add(T e)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001245 RID: 4677 RVA: 0x0000207A File Offset: 0x0000027A
			internal void Remove(T e)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040009BC RID: 2492
			private T[] m_array;
		}

		// Token: 0x02000202 RID: 514
		internal class WorkStealingQueue
		{
			// Token: 0x06001246 RID: 4678 RVA: 0x00026968 File Offset: 0x00024B68
			public void LocalPush(IThreadPoolWorkItem obj)
			{
				int num = 1;
				int tailIndex = this.m_tailIndex;
				int tailIndex2 = this.m_tailIndex;
				int headIndex = this.m_headIndex;
				int mask = this.m_mask;
				int tailIndex3 = this.m_tailIndex;
				this.m_headIndex = num;
				int mask2 = this.m_mask;
				this.m_tailIndex = mask;
			}

			// Token: 0x06001247 RID: 4679 RVA: 0x00026AC4 File Offset: 0x00024CC4
			public bool LocalFindAndPop(IThreadPoolWorkItem obj)
			{
				IThreadPoolWorkItem[] array = this.m_array;
				int tailIndex = this.m_tailIndex;
				int mask = this.m_mask;
				int tailIndex2 = this.m_tailIndex;
				int headIndex = this.m_headIndex;
				IThreadPoolWorkItem[] array2 = this.m_array;
				int mask2 = this.m_mask;
				IThreadPoolWorkItem[] array3 = this.m_array;
				int mask3 = this.m_mask;
				IThreadPoolWorkItem[] array4 = this.m_array;
				int mask4 = this.m_mask;
				int tailIndex3 = this.m_tailIndex;
				int tailIndex4 = this.m_tailIndex;
				int headIndex2 = this.m_headIndex;
				int headIndex3 = this.m_headIndex;
				long num = 0L;
				int num2 = 8;
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (num2 == 0)
				{
					int headIndex4 = this.m_headIndex;
					throw new OutOfMemoryException();
				}
				bool flag;
				return flag;
			}

			// Token: 0x06001248 RID: 4680 RVA: 0x00026B7C File Offset: 0x00024D7C
			public bool LocalPop([Out] IThreadPoolWorkItem obj)
			{
				int tailIndex = this.m_tailIndex;
				int headIndex = this.m_headIndex;
				int headIndex2 = this.m_headIndex;
				int mask = this.m_mask;
				IThreadPoolWorkItem[] array = this.m_array;
				while (mask == 0)
				{
				}
				int headIndex3 = this.m_headIndex;
				int mask2 = this.m_mask;
				IThreadPoolWorkItem[] array2 = this.m_array;
				if (headIndex != 0)
				{
					IThreadPoolWorkItem[] array3 = this.m_array;
					if (false)
					{
						throw new OutOfMemoryException();
					}
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06001249 RID: 4681 RVA: 0x00026C0C File Offset: 0x00024E0C
			public bool TrySteal([Out] IThreadPoolWorkItem obj, bool missedSteal)
			{
				long num = 0L;
				return this.TrySteal(obj, missedSteal, (int)num);
			}

			// Token: 0x0600124A RID: 4682 RVA: 0x00026C24 File Offset: 0x00024E24
			private bool TrySteal([Out] IThreadPoolWorkItem obj, bool missedSteal, int millisecondsTimeout)
			{
				int num = 1;
				int headIndex = this.m_headIndex;
				int tailIndex = this.m_tailIndex;
				int tailIndex2 = this.m_tailIndex;
				int mask = this.m_mask;
				IThreadPoolWorkItem[] array = this.m_array;
				long num2;
				if (mask != 0)
				{
					IThreadPoolWorkItem[] array2 = this.m_array;
					num2 = 0L;
					missedSteal.m_value = num != 0;
				}
				if (num2 == 0L)
				{
					throw new OutOfMemoryException();
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x0600124B RID: 4683 RVA: 0x00026CA8 File Offset: 0x00024EA8
			public WorkStealingQueue()
			{
			}

			// Token: 0x040009BD RID: 2493
			internal IThreadPoolWorkItem[] m_array;

			// Token: 0x040009BE RID: 2494
			private int m_mask = 31;

			// Token: 0x040009BF RID: 2495
			private int m_headIndex;

			// Token: 0x040009C0 RID: 2496
			private int m_tailIndex;

			// Token: 0x040009C1 RID: 2497
			private SpinLock m_foreignLock = 31;
		}

		// Token: 0x02000203 RID: 515
		internal class QueueSegment
		{
			// Token: 0x0600124C RID: 4684 RVA: 0x00026CD0 File Offset: 0x00024ED0
			private void GetIndexes([Out] int upper, [Out] int lower)
			{
				int num = this.indexes;
			}

			// Token: 0x0600124D RID: 4685 RVA: 0x0000207A File Offset: 0x0000027A
			private bool CompareExchangeIndexes(int prevUpper, int newUpper, int prevLower, int newLower)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600124E RID: 4686 RVA: 0x00026CE4 File Offset: 0x00024EE4
			[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
			public QueueSegment()
			{
			}

			// Token: 0x0600124F RID: 4687 RVA: 0x00026CF8 File Offset: 0x00024EF8
			public bool IsUsedUp()
			{
				/*
An exception occurred when decompiling this method (0600124F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ThreadPoolWorkQueue/QueueSegment::IsUsedUp()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(QueueSegment::indexes, ldloc:QueueSegment(this)))
	stloc:class System.Threading.IThreadPoolWorkItem[](var_1_0D, ldfld:class System.Threading.IThreadPoolWorkItem[](QueueSegment::nodes, ldloc:QueueSegment(this)))
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

			// Token: 0x06001250 RID: 4688 RVA: 0x00026D14 File Offset: 0x00024F14
			public bool TryEnqueue(IThreadPoolWorkItem node)
			{
				/*
An exception occurred when decompiling this method (06001250)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ThreadPoolWorkQueue/QueueSegment::TryEnqueue(System.Threading.IThreadPoolWorkItem)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(QueueSegment::indexes, ldloc:QueueSegment(this)))
	stloc:class System.Threading.IThreadPoolWorkItem[](var_1_0D, ldfld:class System.Threading.IThreadPoolWorkItem[](QueueSegment::nodes, ldloc:QueueSegment(this)))
	stloc:class System.Threading.IThreadPoolWorkItem[](var_2_14, ldfld:class System.Threading.IThreadPoolWorkItem[](QueueSegment::nodes, ldloc:QueueSegment(this)))
	stfld:QueueSegment(QueueSegment::Next, ldloc:QueueSegment(this), ldloc:IThreadPoolWorkItem[exp:QueueSegment](node))
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

			// Token: 0x06001251 RID: 4689 RVA: 0x00026D44 File Offset: 0x00024F44
			public bool TryDequeue([Out] IThreadPoolWorkItem node)
			{
				/*
An exception occurred when decompiling this method (06001251)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Threading.ThreadPoolWorkQueue/QueueSegment::TryDequeue(System.Threading.IThreadPoolWorkItem)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:class System.Threading.IThreadPoolWorkItem[](var_4_20, ldfld:class System.Threading.IThreadPoolWorkItem[](QueueSegment::nodes, ldloc:QueueSegment(this)))
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

			// Token: 0x040009C2 RID: 2498
			internal readonly IThreadPoolWorkItem[] nodes;

			// Token: 0x040009C3 RID: 2499
			private int indexes;

			// Token: 0x040009C4 RID: 2500
			public ThreadPoolWorkQueue.QueueSegment Next;
		}
	}
}
