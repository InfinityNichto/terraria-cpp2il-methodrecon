using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200063A RID: 1594
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[Serializable]
	public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		// Token: 0x060030A3 RID: 12451 RVA: 0x0006A7E8 File Offset: 0x000689E8
		public List()
		{
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x0006A7FC File Offset: 0x000689FC
		public List(int capacity)
		{
			if (capacity == 0)
			{
				return;
			}
			this._items = 12;
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0006A824 File Offset: 0x00068A24
		public List(IEnumerable<T> collection)
		{
			if (collection == null)
			{
			}
			if (collection != null)
			{
				return;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x0006A858 File Offset: 0x00068A58
		public int Capacity
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				int size = this._size;
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x0006A87C File Offset: 0x00068A7C
		public int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x0006A890 File Offset: 0x00068A90
		bool IList.IsFixedSize
		{
			get
			{
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x0006A8A0 File Offset: 0x00068AA0
		bool ICollection<T>.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x0006A8B0 File Offset: 0x00068AB0
		bool IList.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060030AC RID: 12460 RVA: 0x0006A8C0 File Offset: 0x00068AC0
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x0006A8D0 File Offset: 0x00068AD0
		object ICollection.SyncRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (060030AD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Generic.List`1::System.Collections.ICollection.get_SyncRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:object[exp:bool](List`1::_syncRoot, ldloc:List`1(this)))
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

		// Token: 0x170007DD RID: 2013
		public T this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0006A8E4 File Offset: 0x00068AE4
		private static bool IsCompatibleObject(object value)
		{
			if (value != null)
			{
				return true;
			}
		}

		// Token: 0x170007DE RID: 2014
		object IList.this[int index]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0000207A File Offset: 0x0000027A
		public void Add(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0000207A File Offset: 0x0000027A
		private void AddWithResize(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0006A918 File Offset: 0x00068B18
		int IList.Add(object item)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0006A93C File Offset: 0x00068B3C
		public void AddRange(IEnumerable<T> collection)
		{
			int size = this._size;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0000207A File Offset: 0x0000027A
		public ReadOnlyCollection<T> AsReadOnly()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0000207A File Offset: 0x0000027A
		public void Clear()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0006A950 File Offset: 0x00068B50
		public bool Contains(T item)
		{
			if (this._size != 0)
			{
				return;
			}
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0006A968 File Offset: 0x00068B68
		bool IList.Contains(object item)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0006A97C File Offset: 0x00068B7C
		public void CopyTo(T[] array)
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0000207A File Offset: 0x0000027A
		void ICollection.CopyTo(Array array, int arrayIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0000207A File Offset: 0x0000027A
		public void CopyTo(T[] array, int arrayIndex)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x0000207A File Offset: 0x0000027A
		private void EnsureCapacity(int min)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0000207A File Offset: 0x0000027A
		public T Find(Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x0000207A File Offset: 0x0000027A
		public void ForEach(Action<T> action)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0000207A File Offset: 0x0000027A
		public List<T>.Enumerator GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0000207A File Offset: 0x0000027A
		public int IndexOf(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0006A98C File Offset: 0x00068B8C
		int IList.IndexOf(object item)
		{
			throw new InvalidCastException();
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0000207A File Offset: 0x0000027A
		public void Insert(int index, T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0006A9A0 File Offset: 0x00068BA0
		void IList.Insert(int index, object item)
		{
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0000207A File Offset: 0x0000027A
		public void InsertRange(int index, IEnumerable<T> collection)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x0006A9C0 File Offset: 0x00068BC0
		public bool Remove(T item)
		{
			return true;
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0006A9D0 File Offset: 0x00068BD0
		void IList.Remove(object item)
		{
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x0000207A File Offset: 0x0000027A
		public int RemoveAll(Predicate<T> match)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x0000207A File Offset: 0x0000027A
		public void RemoveAt(int index)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0000207A File Offset: 0x0000027A
		public void RemoveRange(int index, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x0006A9E4 File Offset: 0x00068BE4
		public void Reverse()
		{
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0000207A File Offset: 0x0000027A
		public void Reverse(int index, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0006A9F4 File Offset: 0x00068BF4
		public void Sort()
		{
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0006AA04 File Offset: 0x00068C04
		public void Sort(IComparer<T> comparer)
		{
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0000207A File Offset: 0x0000027A
		public void Sort(int index, int count, IComparer<T> comparer)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0000207A File Offset: 0x0000027A
		public void Sort(Comparison<T> comparison)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x0000207A File Offset: 0x0000027A
		public T[] ToArray()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x0000207A File Offset: 0x0000027A
		public void TrimExcess()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x0000207A File Offset: 0x0000027A
		private void AddEnumerable(IEnumerable<T> enumerable)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0006AA14 File Offset: 0x00068C14
		// Note: this type is marked as 'beforefieldinit'.
		static List()
		{
		}

		// Token: 0x04001A6F RID: 6767
		private const int DefaultCapacity = 4;

		// Token: 0x04001A70 RID: 6768
		private T[] _items;

		// Token: 0x04001A71 RID: 6769
		private int _size;

		// Token: 0x04001A72 RID: 6770
		private int _version;

		// Token: 0x04001A73 RID: 6771
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x04001A74 RID: 6772
		private static readonly T[] s_emptyArray;

		// Token: 0x0200063B RID: 1595
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x060030D8 RID: 12504 RVA: 0x0006AA24 File Offset: 0x00068C24
			internal Enumerator(List<T> list)
			{
				this._list = list;
				int version = list._version;
				this._version = version;
			}

			// Token: 0x060030D9 RID: 12505 RVA: 0x0006AA48 File Offset: 0x00068C48
			public void Dispose()
			{
			}

			// Token: 0x060030DA RID: 12506 RVA: 0x0006AA58 File Offset: 0x00068C58
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (060030DA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Generic.List`1/Enumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Enumerator::_version, ldloc:valuetype System.Collections.Generic.List`1/Enumerator&(this)))
	stloc:int32(var_2_0F, ldfld:int32(Enumerator::_version, ldloc:valuetype System.Collections.Generic.List`1/Enumerator&(this)))
	call:void(ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion)
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

			// Token: 0x060030DB RID: 12507 RVA: 0x0006AA80 File Offset: 0x00068C80
			private bool MoveNextRare()
			{
				/*
An exception occurred when decompiling this method (060030DB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Generic.List`1/Enumerator::MoveNextRare()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Enumerator::_version, ldloc:valuetype System.Collections.Generic.List`1/Enumerator&(this)))
	call:void(ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion)
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

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x060030DC RID: 12508 RVA: 0x0006AA9C File Offset: 0x00068C9C
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x060030DD RID: 12509 RVA: 0x0006AAB0 File Offset: 0x00068CB0
			object IEnumerator.Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (060030DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Generic.List`1/Enumerator::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	call:void(ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen)
	stloc:!T(var_1_15, ldfld:!T(Enumerator::_current, ldloc:valuetype System.Collections.Generic.List`1/Enumerator&(this)))
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

			// Token: 0x060030DE RID: 12510 RVA: 0x0006AAD4 File Offset: 0x00068CD4
			void IEnumerator.Reset()
			{
				int version = this._version;
				ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion();
			}

			// Token: 0x04001A75 RID: 6773
			private List<T> _list;

			// Token: 0x04001A76 RID: 6774
			private int _index;

			// Token: 0x04001A77 RID: 6775
			private int _version;

			// Token: 0x04001A78 RID: 6776
			private T _current;
		}
	}
}
