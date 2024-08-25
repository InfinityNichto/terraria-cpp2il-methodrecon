using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2IlInjected;

namespace System.Collections.Concurrent
{
	// Token: 0x02000616 RID: 1558
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(IDictionaryDebugView<, >))]
	[Serializable]
	public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06002F7A RID: 12154 RVA: 0x00068898 File Offset: 0x00066A98
		private static bool IsValueWriteAtomic()
		{
			Type type;
			bool isValueType = type.IsValueType;
			TypeCode typeCode = Type.GetTypeCode(type);
			return true;
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000688C0 File Offset: 0x00066AC0
		public ConcurrentDictionary()
		{
			IEqualityComparer comparer = this._comparer;
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x000688D4 File Offset: 0x00066AD4
		public ConcurrentDictionary(IEqualityComparer<TKey> comparer)
		{
			IEqualityComparer comparer2 = this._comparer;
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000688E8 File Offset: 0x00066AE8
		private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection)
		{
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00068958 File Offset: 0x00066B58
		internal ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
		{
			long num = 0L;
			if (comparer == null)
			{
			}
			this._growLockArray = num != 0L;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00068984 File Offset: 0x00066B84
		public bool TryAdd(TKey key, TValue value)
		{
			/*
An exception occurred when decompiling this method (06002F7F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2::TryAdd(TKey,TValue)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEqualityComparer`1(var_0_06, ldfld:class System.Collections.Generic.IEqualityComparer`1<!TKey>[exp:IEqualityComparer`1](ConcurrentDictionary`2::_comparer, ldloc:ConcurrentDictionary`2(this)))
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

		// Token: 0x06002F80 RID: 12160 RVA: 0x0000207A File Offset: 0x0000027A
		public bool ContainsKey(TKey key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x0000207A File Offset: 0x0000027A
		public bool TryRemove(TKey key, [Out] TValue value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00068998 File Offset: 0x00066B98
		private bool TryRemoveInternal(TKey key, [Out] TValue value, bool matchValue, TValue oldValue)
		{
			IEqualityComparer comparer = this._comparer;
			ConcurrentDictionary.Tables tables = this._tables;
			ConcurrentDictionary.Node[] buckets = tables._buckets;
			object[] locks = tables._locks;
			ConcurrentDictionary.Tables tables2 = this._tables;
			if (this == null)
			{
			}
			object[] locks2 = tables._locks;
			ConcurrentDictionary.Tables tables3 = this._tables;
			if (false)
			{
				IEqualityComparer comparer2 = this._comparer;
			}
			if (11 != 0)
			{
			}
			ConcurrentDictionary.Node[] buckets2 = tables._buckets;
			int[] countPerLock = tables._countPerLock;
			if (false || !false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00068A1C File Offset: 0x00066C1C
		public bool TryGetValue(TKey key, [Out] TValue value)
		{
			/*
An exception occurred when decompiling this method (06002F83)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2::TryGetValue(TKey,TValue)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEqualityComparer`1(var_0_06, ldfld:class System.Collections.Generic.IEqualityComparer`1<!TKey>[exp:IEqualityComparer`1](ConcurrentDictionary`2::_comparer, ldloc:ConcurrentDictionary`2(this)))
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

		// Token: 0x06002F84 RID: 12164 RVA: 0x00068A30 File Offset: 0x00066C30
		private bool TryGetValueInternal(TKey key, int hashcode, [Out] TValue value)
		{
			/*
An exception occurred when decompiling this method (06002F84)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2::TryGetValueInternal(TKey,System.Int32,TValue)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Tables(var_0_06, ldfld:class System.Collections.Concurrent.ConcurrentDictionary`2/Tables<!TKey, !TValue>[exp:Tables](ConcurrentDictionary`2::_tables, ldloc:ConcurrentDictionary`2(this)))
	stloc:class System.Collections.Concurrent.ConcurrentDictionary`2/Node[](var_1_0D, ldfld:class System.Collections.Concurrent.ConcurrentDictionary`2/Node<!TKey, !TValue>[][exp:class System.Collections.Concurrent.ConcurrentDictionary`2/Node[]](Tables::_buckets, ldloc:Tables(var_0_06)))
	stloc:class System.Collections.Concurrent.ConcurrentDictionary`2/Node[](var_2_14, ldfld:class System.Collections.Concurrent.ConcurrentDictionary`2/Node<!TKey, !TValue>[][exp:class System.Collections.Concurrent.ConcurrentDictionary`2/Node[]](Tables::_buckets, ldloc:Tables(var_0_06)))
	stloc:IEqualityComparer`1(var_3_1B, ldfld:class System.Collections.Generic.IEqualityComparer`1<!TKey>[exp:IEqualityComparer`1](ConcurrentDictionary`2::_comparer, ldloc:ConcurrentDictionary`2(this)))
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

		// Token: 0x06002F85 RID: 12165 RVA: 0x00068A5C File Offset: 0x00066C5C
		public void Clear()
		{
			object[] locks = this._tables._locks;
			int[] countPerLock = this._tables._countPerLock;
			IEqualityComparer comparer = this._comparer;
			if (!false)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00068AB0 File Offset: 0x00066CB0
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			if (array != null)
			{
				object[] locks = this._tables._locks;
				int[] countPerLock = this._tables._countPerLock;
				return;
			}
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00068AF8 File Offset: 0x00066CF8
		public KeyValuePair<TKey, TValue>[] ToArray()
		{
			long num = 0L;
			object[] locks = this._tables._locks;
			int[] countPerLock = this._tables._countPerLock;
			if (num != 0L)
			{
			}
			if (!false)
			{
				throw new OverflowException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00068B44 File Offset: 0x00066D44
		private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index)
		{
			ConcurrentDictionary.Node[] buckets = this._tables._buckets;
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00068B60 File Offset: 0x00066D60
		private void CopyToEntries(DictionaryEntry[] array, int index)
		{
			ConcurrentDictionary.Node[] buckets = this._tables._buckets;
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00068B7C File Offset: 0x00066D7C
		private void CopyToObjects(object[] array, int index)
		{
			ConcurrentDictionary.Node[] buckets = this._tables._buckets;
			if (this == null || this != null)
			{
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0000207A File Offset: 0x0000027A
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00068BA4 File Offset: 0x00066DA4
		private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, [Out] TValue resultingValue)
		{
			int num = 1;
			ConcurrentDictionary.Tables tables = this._tables;
			ConcurrentDictionary.Node[] buckets = tables._buckets;
			object[] locks = tables._locks;
			if (num == 0)
			{
			}
			object[] locks2 = tables._locks;
			ConcurrentDictionary.Tables tables2 = this._tables;
			long num2 = 0L;
			ConcurrentDictionary.Node[] buckets2 = tables._buckets;
			long num3 = 0L;
			IEqualityComparer comparer;
			if (num2 != 0L)
			{
				comparer = this._comparer;
			}
			ConcurrentDictionary.Node[] buckets3 = tables._buckets;
			num3.m_value = comparer;
			int[] countPerLock = tables._countPerLock;
			int[] countPerLock2 = tables._countPerLock;
			long num4 = 0L;
			object[] locks3;
			if (buckets3 != null)
			{
				locks3 = tables._locks;
			}
			if (num4 == 0L)
			{
				if (locks3 == null)
				{
				}
				if (false)
				{
				}
				ConcurrentDictionary.Node[] buckets4 = tables._buckets;
				throw new OverflowException();
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000784 RID: 1924
		public TValue this[TKey key]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				IEqualityComparer comparer = this._comparer;
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowKeyNotFoundException(object key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowKeyNullException()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x00068C80 File Offset: 0x00066E80
		public int Count
		{
			get
			{
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00068CA4 File Offset: 0x00066EA4
		private int GetCountInternal()
		{
			/*
An exception occurred when decompiling this method (06002F92)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Concurrent.ConcurrentDictionary`2::GetCountInternal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32[](var_0_0B, ldfld:int32[](Tables::_countPerLock, ldfld:class System.Collections.Concurrent.ConcurrentDictionary`2/Tables<!TKey, !TValue>[exp:Tables](ConcurrentDictionary`2::_tables, ldloc:ConcurrentDictionary`2(this))))
	stloc:int32[](var_2_19, ldfld:int32[](Tables::_countPerLock, ldfld:class System.Collections.Concurrent.ConcurrentDictionary`2/Tables<!TKey, !TValue>[exp:Tables](ConcurrentDictionary`2::_tables, ldloc:ConcurrentDictionary`2(this))))
	stloc:int32[](var_3_25, ldfld:int32[](Tables::_countPerLock, ldfld:class System.Collections.Concurrent.ConcurrentDictionary`2/Tables<!TKey, !TValue>[exp:Tables](ConcurrentDictionary`2::_tables, ldloc:ConcurrentDictionary`2(this))))
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

		// Token: 0x06002F93 RID: 12179 RVA: 0x00068CDC File Offset: 0x00066EDC
		public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
		{
			/*
An exception occurred when decompiling this method (06002F93)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TValue System.Collections.Concurrent.ConcurrentDictionary`2::GetOrAdd(TKey,System.Func`2<TKey,TValue>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEqualityComparer`1(var_0_09, ldfld:class System.Collections.Generic.IEqualityComparer`1<!TKey>[exp:IEqualityComparer`1](ConcurrentDictionary`2::_comparer, ldloc:ConcurrentDictionary`2(this)))
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

		// Token: 0x06002F94 RID: 12180 RVA: 0x00068CF4 File Offset: 0x00066EF4
		public TValue GetOrAdd(TKey key, TValue value)
		{
			/*
An exception occurred when decompiling this method (06002F94)

ICSharpCode.Decompiler.DecompilerException: Error decompiling TValue System.Collections.Concurrent.ConcurrentDictionary`2::GetOrAdd(TKey,TValue)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEqualityComparer`1(var_0_06, ldfld:class System.Collections.Generic.IEqualityComparer`1<!TKey>[exp:IEqualityComparer`1](ConcurrentDictionary`2::_comparer, ldloc:ConcurrentDictionary`2(this)))
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

		// Token: 0x06002F95 RID: 12181 RVA: 0x00068D08 File Offset: 0x00066F08
		void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
		{
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x0000207A File Offset: 0x0000027A
		bool IDictionary<TKey, TValue>.Remove(TKey key)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x0000207A File Offset: 0x0000027A
		public ICollection<TKey> Keys
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06002F98 RID: 12184 RVA: 0x0000207A File Offset: 0x0000027A
		public ICollection<TValue> Values
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00068D18 File Offset: 0x00066F18
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x00068D28 File Offset: 0x00066F28
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06002F9B RID: 12187 RVA: 0x00068D38 File Offset: 0x00066F38
		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x0000207A File Offset: 0x0000027A
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x0000207A File Offset: 0x0000027A
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x00068D48 File Offset: 0x00066F48
		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
			}
			if (key == null)
			{
				return;
			}
			if (value != null && value == null)
			{
				throw new InvalidCastException();
			}
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x00068D74 File Offset: 0x00066F74
		bool IDictionary.Contains(object key)
		{
			if (key == null)
			{
			}
			if (key != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x0000207A File Offset: 0x0000027A
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x00068D8C File Offset: 0x00066F8C
		bool IDictionary.IsFixedSize
		{
			get
			{
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x00068D9C File Offset: 0x00066F9C
		bool IDictionary.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x0000207A File Offset: 0x0000027A
		ICollection IDictionary.Keys
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00068DAC File Offset: 0x00066FAC
		void IDictionary.Remove(object key)
		{
			if (key == null)
			{
			}
			if (key != null)
			{
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x0000207A File Offset: 0x0000027A
		ICollection IDictionary.Values
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700078D RID: 1933
		object IDictionary.this[object key]
		{
			get
			{
				if (key == null)
				{
				}
				if (key != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				if (key == null)
				{
				}
				if (key == null)
				{
					return;
				}
				if (value == null)
				{
					throw new InvalidCastException();
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00068E0C File Offset: 0x0006700C
		void ICollection.CopyTo(Array array, int index)
		{
			if (array != null)
			{
				ConcurrentDictionary.Tables tables = this._tables;
				object[] locks = tables._locks;
				int[] countPerLock = tables._countPerLock;
				object[] locks2 = tables._locks;
				return;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x00068E70 File Offset: 0x00067070
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x0000207A File Offset: 0x0000027A
		object ICollection.SyncRoot
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00068E80 File Offset: 0x00067080
		private void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
			ConcurrentDictionary.Tables tables2 = this._tables;
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x0000207A File Offset: 0x0000027A
		private static int GetBucket(int hashcode, int bucketCount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00068F70 File Offset: 0x00067170
		private static void GetBucketAndLockNo(int hashcode, [Out] int bucketNo, [Out] int lockNo, int bucketCount, int lockCount)
		{
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x00068F80 File Offset: 0x00067180
		private static int DefaultConcurrencyLevel
		{
			get
			{
				if (!true)
				{
				}
				return PlatformHelper.ProcessorCount;
			}
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00068F98 File Offset: 0x00067198
		private void AcquireAllLocks(int locksAcquired)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			ConcurrentDictionary.Node[] buckets = this._tables._buckets;
			object[] locks = this._tables._locks;
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00068FC8 File Offset: 0x000671C8
		private void AcquireLocks(int fromInclusive, int toExclusive, int locksAcquired)
		{
			object[] locks = this._tables._locks;
			long num = 0L;
			if (locks != null)
			{
			}
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00069000 File Offset: 0x00067200
		private void ReleaseLocks(int fromInclusive, int toExclusive)
		{
			object[] locks = this._tables._locks;
			Monitor.Exit(this);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x00069020 File Offset: 0x00067220
		private ReadOnlyCollection<TKey> GetKeys()
		{
			ConcurrentDictionary.Node[] buckets = this._tables._buckets;
			ConcurrentDictionary.Tables tables = this._tables;
			ConcurrentDictionary.Node[] buckets2 = tables._buckets;
			if (tables != null)
			{
				ConcurrentDictionary.Node[] buckets3 = tables._buckets;
				int[] countPerLock = tables._countPerLock;
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00069070 File Offset: 0x00067270
		private ReadOnlyCollection<TValue> GetValues()
		{
			ConcurrentDictionary.Node[] buckets = this._tables._buckets;
			ConcurrentDictionary.Tables tables = this._tables;
			ConcurrentDictionary.Node[] buckets2 = tables._buckets;
			if (tables != null)
			{
				object[] locks = tables._locks;
				int[] countPerLock = tables._countPerLock;
			}
			if (!false)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x000690C0 File Offset: 0x000672C0
		[OnSerializing]
		private void OnSerializing(StreamingContext context)
		{
			ConcurrentDictionary.Tables tables = this._tables;
			StreamingContextStates state = context.m_state;
			object[] locks = tables._locks;
			ConcurrentDictionary.Node[] buckets = tables._buckets;
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x000690EC File Offset: 0x000672EC
		[OnSerialized]
		private void OnSerialized(StreamingContext context)
		{
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x000690FC File Offset: 0x000672FC
		[OnDeserialized]
		private void OnDeserialized(StreamingContext context)
		{
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00069114 File Offset: 0x00067314
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentDictionary()
		{
		}

		// Token: 0x04001A2B RID: 6699
		[NonSerialized]
		private ConcurrentDictionary<TKey, TValue>.Tables _tables;

		// Token: 0x04001A2C RID: 6700
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x04001A2D RID: 6701
		[NonSerialized]
		private readonly bool _growLockArray;

		// Token: 0x04001A2E RID: 6702
		[NonSerialized]
		private int _budget;

		// Token: 0x04001A2F RID: 6703
		private KeyValuePair<TKey, TValue>[] _serializationArray;

		// Token: 0x04001A30 RID: 6704
		private int _serializationConcurrencyLevel;

		// Token: 0x04001A31 RID: 6705
		private int _serializationCapacity;

		// Token: 0x04001A32 RID: 6706
		private static readonly bool s_isValueWriteAtomic;

		// Token: 0x02000617 RID: 1559
		private sealed class Tables
		{
			// Token: 0x06002FB8 RID: 12216 RVA: 0x00069124 File Offset: 0x00067324
			internal Tables(ConcurrentDictionary<TKey, TValue>.Node[] buckets, object[] locks, int[] countPerLock)
			{
				this._buckets = buckets;
				this._locks = locks;
				this._countPerLock = countPerLock;
			}

			// Token: 0x04001A33 RID: 6707
			internal readonly ConcurrentDictionary<TKey, TValue>.Node[] _buckets;

			// Token: 0x04001A34 RID: 6708
			internal readonly object[] _locks;

			// Token: 0x04001A35 RID: 6709
			internal int[] _countPerLock;
		}

		// Token: 0x02000618 RID: 1560
		[Serializable]
		private sealed class Node
		{
			// Token: 0x06002FB9 RID: 12217 RVA: 0x0006914C File Offset: 0x0006734C
			internal Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
			{
				this._key = key;
				this._value = value;
				this._next = next;
				this._hashcode = hashcode;
			}

			// Token: 0x04001A36 RID: 6710
			internal readonly TKey _key;

			// Token: 0x04001A37 RID: 6711
			internal TValue _value;

			// Token: 0x04001A38 RID: 6712
			internal ConcurrentDictionary<TKey, TValue>.Node _next;

			// Token: 0x04001A39 RID: 6713
			internal readonly int _hashcode;
		}

		// Token: 0x02000619 RID: 1561
		[Serializable]
		private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06002FBA RID: 12218 RVA: 0x0006917C File Offset: 0x0006737C
			internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
			{
				this._enumerator = dictionary;
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x06002FBB RID: 12219 RVA: 0x00069198 File Offset: 0x00067398
			public DictionaryEntry Entry
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002FBB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.DictionaryEntry System.Collections.Concurrent.ConcurrentDictionary`2/DictionaryEnumerator::get_Entry()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEnumerator`1(var_0_06, ldfld:class System.Collections.Generic.IEnumerator`1<valuetype System.Collections.Generic.KeyValuePair`2<!TKey, !TValue>>[exp:IEnumerator`1](DictionaryEnumerator::_enumerator, ldloc:DictionaryEnumerator(this)))
	stloc:IEnumerator`1(var_1_0D, ldfld:class System.Collections.Generic.IEnumerator`1<valuetype System.Collections.Generic.KeyValuePair`2<!TKey, !TValue>>[exp:IEnumerator`1](DictionaryEnumerator::_enumerator, ldloc:DictionaryEnumerator(this)))
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

			// Token: 0x17000792 RID: 1938
			// (get) Token: 0x06002FBC RID: 12220 RVA: 0x000691B4 File Offset: 0x000673B4
			public object Key
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002FBC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Concurrent.ConcurrentDictionary`2/DictionaryEnumerator::get_Key()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEnumerator`1(var_0_06, ldfld:class System.Collections.Generic.IEnumerator`1<valuetype System.Collections.Generic.KeyValuePair`2<!TKey, !TValue>>[exp:IEnumerator`1](DictionaryEnumerator::_enumerator, ldloc:DictionaryEnumerator(this)))
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

			// Token: 0x17000793 RID: 1939
			// (get) Token: 0x06002FBD RID: 12221 RVA: 0x000691C8 File Offset: 0x000673C8
			public object Value
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002FBD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Concurrent.ConcurrentDictionary`2/DictionaryEnumerator::get_Value()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEnumerator`1(var_0_06, ldfld:class System.Collections.Generic.IEnumerator`1<valuetype System.Collections.Generic.KeyValuePair`2<!TKey, !TValue>>[exp:IEnumerator`1](DictionaryEnumerator::_enumerator, ldloc:DictionaryEnumerator(this)))
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

			// Token: 0x17000794 RID: 1940
			// (get) Token: 0x06002FBE RID: 12222 RVA: 0x0000207A File Offset: 0x0000027A
			public object Current
			{
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06002FBF RID: 12223 RVA: 0x000691DC File Offset: 0x000673DC
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06002FBF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2/DictionaryEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IEnumerator`1(var_0_06, ldfld:class System.Collections.Generic.IEnumerator`1<valuetype System.Collections.Generic.KeyValuePair`2<!TKey, !TValue>>[exp:IEnumerator`1](DictionaryEnumerator::_enumerator, ldloc:DictionaryEnumerator(this)))
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

			// Token: 0x06002FC0 RID: 12224 RVA: 0x000691F0 File Offset: 0x000673F0
			public void Reset()
			{
				IEnumerator enumerator = this._enumerator;
			}

			// Token: 0x04001A3A RID: 6714
			private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator;
		}

		// Token: 0x0200061A RID: 1562
		[CompilerGenerated]
		private sealed class <GetEnumerator>d__35 : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator
		{
			// Token: 0x06002FC1 RID: 12225 RVA: 0x00069208 File Offset: 0x00067408
			[DebuggerHidden]
			public <GetEnumerator>d__35(int <>1__state)
			{
				this.<>1__state = <>1__state;
			}

			// Token: 0x06002FC2 RID: 12226 RVA: 0x00069224 File Offset: 0x00067424
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			// Token: 0x06002FC3 RID: 12227 RVA: 0x00069234 File Offset: 0x00067434
			private bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06002FC3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Concurrent.ConcurrentDictionary`2/<GetEnumerator>d__35::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:int32(var_2_19, ldc.i4:int32(1))
	stfld:int32('<GetEnumerator>d__35'::<>1__state, ldloc:'<GetEnumerator>d__35'(this), ldloc:int32(var_2_19))
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

			// Token: 0x17000795 RID: 1941
			// (get) Token: 0x06002FC4 RID: 12228 RVA: 0x0000207A File Offset: 0x0000027A
			KeyValuePair<TKey, TValue> IEnumerator<KeyValuePair<TKey, TValue>>.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x06002FC5 RID: 12229 RVA: 0x0000207A File Offset: 0x0000027A
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000796 RID: 1942
			// (get) Token: 0x06002FC6 RID: 12230 RVA: 0x0000207A File Offset: 0x0000027A
			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x04001A3B RID: 6715
			private int <>1__state;

			// Token: 0x04001A3C RID: 6716
			private KeyValuePair<TKey, TValue> <>2__current;

			// Token: 0x04001A3D RID: 6717
			public ConcurrentDictionary<TKey, TValue> <>4__this;

			// Token: 0x04001A3E RID: 6718
			private ConcurrentDictionary<TKey, TValue>.Node[] <buckets>5__2;

			// Token: 0x04001A3F RID: 6719
			private int <i>5__3;

			// Token: 0x04001A40 RID: 6720
			private ConcurrentDictionary<TKey, TValue>.Node <current>5__4;
		}
	}
}
