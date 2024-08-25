using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace System.Collections.Concurrent
{
	// Token: 0x02000610 RID: 1552
	[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class ConcurrentQueue<T> : IProducerConsumerCollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
	{
		// Token: 0x06002F57 RID: 12119 RVA: 0x000683FC File Offset: 0x000665FC
		public ConcurrentQueue()
		{
			this._head = 1;
			this._tail = 1;
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00068420 File Offset: 0x00066620
		void ICollection.CopyTo(Array array, int index)
		{
			while (array == null)
			{
				if (array != null)
				{
					return;
				}
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x00068434 File Offset: 0x00066634
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002F5A RID: 12122 RVA: 0x0000207A File Offset: 0x0000027A
		object ICollection.SyncRoot
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00068444 File Offset: 0x00066644
		bool IProducerConsumerCollection<T>.TryAdd(T item)
		{
			return true;
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x0000207A File Offset: 0x0000027A
		bool IProducerConsumerCollection<T>.TryTake([Out] T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00068454 File Offset: 0x00066654
		public T[] ToArray()
		{
			int num = 1;
			int value = num.m_value;
			int value2 = num.m_value;
			long num2 = 0L;
			if (num != 0)
			{
				int value3 = num.m_value;
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x000684A4 File Offset: 0x000666A4
		public int Count
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002F5F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Concurrent.ConcurrentQueue`1::get_Count()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Segment(var_0_06, ldfld:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](ConcurrentQueue`1::_head, ldloc:ConcurrentQueue`1(this)))
	stloc:Segment(var_1_0D, ldfld:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](ConcurrentQueue`1::_tail, ldloc:ConcurrentQueue`1(this)))
	stloc:Segment(var_2_14, ldfld:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](ConcurrentQueue`1::_head, ldloc:ConcurrentQueue`1(this)))
	stloc:Segment(var_3_1B, ldfld:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](ConcurrentQueue`1::_tail, ldloc:ConcurrentQueue`1(this)))
	stloc:Segment(var_4_22, ldfld:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](ConcurrentQueue`1::_head, ldloc:ConcurrentQueue`1(this)))
	stloc:Segment(var_5_2A, ldfld:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](ConcurrentQueue`1::_tail, ldloc:ConcurrentQueue`1(this)))
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

		// Token: 0x06002F60 RID: 12128 RVA: 0x000684DC File Offset: 0x000666DC
		private static int GetCount(ConcurrentQueue<T>.Segment s, int head, int tail)
		{
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000684EC File Offset: 0x000666EC
		private static long GetCount(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			return 0L;
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x000684FC File Offset: 0x000666FC
		public void CopyTo(T[] array, int index)
		{
			if (array != null)
			{
				return;
			}
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x0000207A File Offset: 0x0000027A
		public IEnumerator<T> GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00068538 File Offset: 0x00066738
		private void SnapForObservation([Out] ConcurrentQueue<T>.Segment head, [Out] int headHead, [Out] ConcurrentQueue<T>.Segment tail, [Out] int tailTail)
		{
			object crossSegmentLock = this._crossSegmentLock;
			ConcurrentQueue.Segment head2 = this._head;
			ConcurrentQueue.Segment tail2 = this._tail;
			headHead.m_value = head;
			long num = 0L;
			tailTail.m_value = headHead;
			Monitor.Exit(crossSegmentLock);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x0006859C File Offset: 0x0006679C
		private T GetItemWhenAvailable(ConcurrentQueue<T>.Segment segment, int i)
		{
			/*
An exception occurred when decompiling this method (06002F65)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T System.Collections.Concurrent.ConcurrentQueue`1::GetItemWhenAvailable(System.Collections.Concurrent.ConcurrentQueue`1/Segment<T>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_0_06, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](segment)))
	stloc:int32(var_1_0D, ldfld:int32(Segment::_slotsMask, ldloc:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](segment)))
	stloc:int32(var_2_14, ldfld:int32(Segment::_slotsMask, ldloc:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](segment)))
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_3_1B, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](segment)))
	stloc:int32(var_4_22, ldfld:int32(Segment::_slotsMask, ldloc:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](segment)))
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_5_2A, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:class System.Collections.Concurrent.ConcurrentQueue`1/Segment<!T>[exp:Segment](segment)))
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

		// Token: 0x06002F66 RID: 12134 RVA: 0x0000207A File Offset: 0x0000027A
		private IEnumerator<T> Enumerate(ConcurrentQueue<T>.Segment head, int headHead, ConcurrentQueue<T>.Segment tail, int tailTail)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x000685D4 File Offset: 0x000667D4
		public void Enqueue(T item)
		{
			ConcurrentQueue.Segment tail = this._tail;
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000685EC File Offset: 0x000667EC
		private void EnqueueSlow(T item)
		{
			ConcurrentQueue.Segment tail = this._tail;
			object crossSegmentLock = this._crossSegmentLock;
			ConcurrentQueue.Segment tail2 = this._tail;
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00068664 File Offset: 0x00066864
		public bool TryDequeue([Out] T result)
		{
			ConcurrentQueue.Segment head = this._head;
			return true;
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x0006867C File Offset: 0x0006687C
		private bool TryDequeueSlow([Out] T item)
		{
			ConcurrentQueue.Segment head = this._head;
			object crossSegmentLock = this._crossSegmentLock;
			ConcurrentQueue.Segment head2 = this._head;
			long num = 0L;
			this._head = head2;
			Monitor.Exit(crossSegmentLock);
			if (num == 0L)
			{
				while (2 != 0)
				{
				}
				throw new OutOfMemoryException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x04001A12 RID: 6674
		private object _crossSegmentLock;

		// Token: 0x04001A13 RID: 6675
		private ConcurrentQueue<T>.Segment _tail;

		// Token: 0x04001A14 RID: 6676
		private ConcurrentQueue<T>.Segment _head;

		// Token: 0x02000611 RID: 1553
		[DebuggerDisplay("Capacity = {Capacity}")]
		internal sealed class Segment
		{
			// Token: 0x06002F6B RID: 12139 RVA: 0x000686DC File Offset: 0x000668DC
			public Segment(int boundedLength)
			{
				this._slots = this;
				int slotsMask = this._slotsMask;
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x06002F6C RID: 12140 RVA: 0x00068700 File Offset: 0x00066900
			internal int Capacity
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002F6C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Concurrent.ConcurrentQueue`1/Segment::get_Capacity()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_0_06, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:Segment(this)))
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

			// Token: 0x17000781 RID: 1921
			// (get) Token: 0x06002F6D RID: 12141 RVA: 0x00068714 File Offset: 0x00066914
			internal int FreezeOffset
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002F6D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Concurrent.ConcurrentQueue`1/Segment::get_FreezeOffset()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_0_06, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:Segment(this)))
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

			// Token: 0x06002F6E RID: 12142 RVA: 0x00068728 File Offset: 0x00066928
			internal void EnsureFrozenForEnqueues()
			{
			}

			// Token: 0x06002F6F RID: 12143 RVA: 0x00068738 File Offset: 0x00066938
			public bool TryDequeue([Out] T item)
			{
				int slotsMask = this._slotsMask;
				ConcurrentQueue.Segment.Slot[] slots = this._slots;
				ConcurrentQueue.Segment.Slot[] slots2 = this._slots;
				if (item == null)
				{
					ConcurrentQueue.Segment.Slot[] slots3 = this._slots;
					ConcurrentQueue.Segment.Slot[] slots4 = this._slots;
					return;
				}
			}

			// Token: 0x06002F70 RID: 12144 RVA: 0x00068774 File Offset: 0x00066974
			public bool TryEnqueue(T item)
			{
				/*
An exception occurred when decompiling this method (06002F70)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Concurrent.ConcurrentQueue`1/Segment::TryEnqueue(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Segment::_slotsMask, ldloc:Segment(this)))
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_1_0D, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:Segment(this)))
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_4_16, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:Segment(this)))
	stloc:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[](var_5_1E, ldfld:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot<!T>[][exp:valuetype System.Collections.Concurrent.ConcurrentQueue`1/Segment/Slot[]](Segment::_slots, ldloc:Segment(this)))
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

			// Token: 0x04001A15 RID: 6677
			internal readonly ConcurrentQueue<T>.Segment.Slot[] _slots;

			// Token: 0x04001A16 RID: 6678
			internal readonly int _slotsMask;

			// Token: 0x04001A17 RID: 6679
			internal PaddedHeadAndTail _headAndTail;

			// Token: 0x04001A18 RID: 6680
			internal bool _preservedForObservation;

			// Token: 0x04001A19 RID: 6681
			internal bool _frozenForEnqueues;

			// Token: 0x04001A1A RID: 6682
			internal ConcurrentQueue<T>.Segment _nextSegment;

			// Token: 0x02000612 RID: 1554
			[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
			[StructLayout(3)]
			internal struct Slot
			{
				// Token: 0x04001A1B RID: 6683
				public T Item;

				// Token: 0x04001A1C RID: 6684
				public int SequenceNumber;
			}
		}

		// Token: 0x02000613 RID: 1555
		[CompilerGenerated]
		private sealed class <Enumerate>d__28 : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x06002F71 RID: 12145 RVA: 0x000687A4 File Offset: 0x000669A4
			[DebuggerHidden]
			public <Enumerate>d__28(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06002F72 RID: 12146 RVA: 0x000687C0 File Offset: 0x000669C0
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002F73 RID: 12147 RVA: 0x000687D0 File Offset: 0x000669D0
			private bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06002F73)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Concurrent.ConcurrentQueue`1/<Enumerate>d__28::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32('<Enumerate>d__28'::<>1__state, ldloc:'<Enumerate>d__28'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<Enumerate>d__28'::<i>5__3, ldloc:'<Enumerate>d__28'(this)))
	stloc:int32(var_2_14, ldfld:int32('<Enumerate>d__28'::headHead, ldloc:'<Enumerate>d__28'(this)))
	stloc:int32(var_3_16, ldc.i4:int32(1))
	stfld:int32('<Enumerate>d__28'::<>1__state, ldloc:'<Enumerate>d__28'(this), ldloc:int32(var_3_16))
	stloc:int32(var_4_24, ldfld:int32('<Enumerate>d__28'::<i>5__5, ldloc:'<Enumerate>d__28'(this)))
	stloc:int32(var_5_2C, ldfld:int32('<Enumerate>d__28'::<i>5__5, ldloc:'<Enumerate>d__28'(this)))
	stloc:int32(var_6_34, ldfld:int32('<Enumerate>d__28'::<i>5__5, ldloc:'<Enumerate>d__28'(this)))
	stloc:int32(var_7_3C, ldfld:int32('<Enumerate>d__28'::<i>5__5, ldloc:'<Enumerate>d__28'(this)))
	stloc:int64(var_8_3F, ldc.i4:int64(0))
	stloc:int32(var_9_42, ldc.i4:int32(3))
	stloc:int32(var_10_4A, ldfld:int32('<Enumerate>d__28'::<headTail>5__2, ldloc:'<Enumerate>d__28'(this)))
	stfld:int32('<Enumerate>d__28'::<headTail>5__2, ldloc:'<Enumerate>d__28'(this), ldloc:int64[exp:int32](var_8_3F))
	stloc:int32(var_11_5A, ldfld:int32('<Enumerate>d__28'::headHead, ldloc:'<Enumerate>d__28'(this)))
	stfld:int32('<Enumerate>d__28'::<>1__state, ldloc:'<Enumerate>d__28'(this), ldloc:int32(var_9_42))
	stfld:int32('<Enumerate>d__28'::<i>5__5, ldloc:'<Enumerate>d__28'(this), ldloc:int32(var_9_42))
	stloc:int32(var_14_78, ldfld:int32('<Enumerate>d__28'::headHead, ldloc:'<Enumerate>d__28'(this)))
	stloc:int32(var_16_83, ldfld:int32('<Enumerate>d__28'::headHead, ldloc:'<Enumerate>d__28'(this)))
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

			// Token: 0x17000782 RID: 1922
			// (get) Token: 0x06002F74 RID: 12148 RVA: 0x0000207A File Offset: 0x0000027A
			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06002F75 RID: 12149 RVA: 0x0000207A File Offset: 0x0000027A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06002F76 RID: 12150 RVA: 0x0000207A File Offset: 0x0000027A
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x04001A1D RID: 6685
			private int <>1__state;

			// Token: 0x04001A1E RID: 6686
			private T <>2__current;

			// Token: 0x04001A1F RID: 6687
			public ConcurrentQueue<T>.Segment head;

			// Token: 0x04001A20 RID: 6688
			public ConcurrentQueue<T>.Segment tail;

			// Token: 0x04001A21 RID: 6689
			public int tailTail;

			// Token: 0x04001A22 RID: 6690
			public int headHead;

			// Token: 0x04001A23 RID: 6691
			public ConcurrentQueue<T> <>4__this;

			// Token: 0x04001A24 RID: 6692
			private int <headTail>5__2;

			// Token: 0x04001A25 RID: 6693
			private int <i>5__3;

			// Token: 0x04001A26 RID: 6694
			private ConcurrentQueue<T>.Segment <s>5__4;

			// Token: 0x04001A27 RID: 6695
			private int <i>5__5;
		}
	}
}
