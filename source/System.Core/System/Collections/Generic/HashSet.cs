using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200002C RID: 44
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x0600012D RID: 301 RVA: 0x00003E68 File Offset: 0x00002068
		public HashSet()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00003E78 File Offset: 0x00002078
		public HashSet(IEqualityComparer<T> comparer)
		{
			if (comparer == null)
			{
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003E90 File Offset: 0x00002090
		public HashSet(IEnumerable<T> collection)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003EA0 File Offset: 0x000020A0
		public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
			while (collection == null)
			{
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003EC8 File Offset: 0x000020C8
		protected HashSet(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003EDC File Offset: 0x000020DC
		private void CopyFrom(HashSet<T> source)
		{
			int count = source._count;
			if (count != 0)
			{
				int[] buckets = source._buckets;
				int num = HashHelpers.ExpandPrime(int.MinValue);
				int lastIndex = source._lastIndex;
				HashSet.Slot[] slots = source._slots;
				return;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003F68 File Offset: 0x00002168
		void ICollection<T>.Add(T item)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003F78 File Offset: 0x00002178
		public void Clear()
		{
			int lastIndex = this._lastIndex;
			HashSet.Slot[] slots = this._slots;
			long num = 0L;
			Array.Clear(slots, (int)num, lastIndex);
			int[] buckets = this._buckets;
			long num2 = 0L;
			Array.Clear(buckets, (int)num2, lastIndex);
			SerializationInfo siInfo = this._siInfo;
			this._siInfo = siInfo;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003FC0 File Offset: 0x000021C0
		public bool Contains(T item)
		{
			if (this._buckets != null)
			{
				int[] buckets = this._buckets;
				HashSet.Slot[] slots = this._slots;
				return;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003FEC File Offset: 0x000021EC
		public void CopyTo(T[] array, int arrayIndex)
		{
			int count = this._count;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004000 File Offset: 0x00002200
		public bool Remove(T item)
		{
			/*
An exception occurred when decompiling this method (06000137)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Generic.HashSet`1::Remove(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:int32[](var_6_2A, ldfld:int32[](HashSet`1::_buckets, ldloc:HashSet`1(this)))
	stloc:int32(var_7_32, ldfld:int32(HashSet`1::_freeList, ldloc:HashSet`1(this)))
	stloc:int32(var_9_3E, ldfld:int32(HashSet`1::_count, ldloc:HashSet`1(this)))
	stloc:SerializationInfo(var_10_46, ldfld:SerializationInfo(HashSet`1::_siInfo, ldloc:HashSet`1(this)))
	stfld:int32(HashSet`1::_count, ldloc:HashSet`1(this), ldloc:int32(var_9_3E))
	stfld:SerializationInfo(HashSet`1::_siInfo, ldloc:HashSet`1(this), ldloc:SerializationInfo(var_10_46))
	stfld:int32(HashSet`1::_freeList, ldloc:HashSet`1(this), ldloc:int32[][exp:int32](var_0_06))
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		public int Count
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00004070 File Offset: 0x00002270
		bool ICollection<T>.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		public HashSet<T>.Enumerator GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004080 File Offset: 0x00002280
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			SerializationInfo siInfo = this._siInfo;
			if (this._buckets != null)
			{
				return;
			}
			long num = 0L;
			info.AddValue("Capacity", (int)num);
			if (this._buckets != null)
			{
				int count = this._count;
				Type type;
				info.AddValue("Elements", info, type);
				return;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000040CC File Offset: 0x000022CC
		public virtual void OnDeserialization(object sender)
		{
			if ("Version" != null)
			{
				object obj;
				if (obj != null)
				{
					if (obj == null)
					{
						return;
					}
				}
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
				int num;
				if (num != 0)
				{
					object obj2;
					if (obj2 != null && obj != null)
					{
						return;
					}
					throw new InvalidCastException();
				}
				else
				{
					int num2;
					this._siInfo = num2;
				}
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		public bool Add(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00004114 File Offset: 0x00002314
		public void UnionWith(IEnumerable<T> other)
		{
			if (other != null)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000414C File Offset: 0x0000234C
		public void CopyTo(T[] array)
		{
			int count = this._count;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004160 File Offset: 0x00002360
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			if (array != null)
			{
				int lastIndex = this._lastIndex;
				HashSet.Slot[] slots = this._slots;
				return;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		public IEqualityComparer<T> Comparer
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00004184 File Offset: 0x00002384
		public void TrimExcess()
		{
			int count = this._count;
			if (count != 0)
			{
				int prime = HashHelpers.GetPrime(count);
				int lastIndex = this._lastIndex;
				HashSet.Slot[] slots = this._slots;
				int lastIndex2 = this._lastIndex;
				return;
			}
			SerializationInfo siInfo = this._siInfo;
			this._siInfo = siInfo;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000041E8 File Offset: 0x000023E8
		private int Initialize(int capacity)
		{
			if (!true)
			{
			}
			return HashHelpers.GetPrime(capacity);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00004200 File Offset: 0x00002400
		private void IncreaseCapacity()
		{
			int count = this._count;
			if (!true)
			{
			}
			int num = HashHelpers.ExpandPrime(count);
			int count2 = this._count;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00004228 File Offset: 0x00002428
		private void SetCapacity(int newSize)
		{
			if (this._slots != null)
			{
				int lastIndex = this._lastIndex;
			}
			int lastIndex2 = this._lastIndex;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004250 File Offset: 0x00002450
		private bool AddIfNotPresent(T value)
		{
			/*
An exception occurred when decompiling this method (06000148)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	stloc:int32[](var_0_0E, ldfld:int32[](HashSet`1::_buckets, ldloc:HashSet`1(this)))
	stloc:valuetype System.Collections.Generic.HashSet`1/Slot[](var_1_15, ldfld:valuetype System.Collections.Generic.HashSet`1/Slot<!T>[][exp:valuetype System.Collections.Generic.HashSet`1/Slot[]](HashSet`1::_slots, ldloc:HashSet`1(this)))
	stloc:int32(var_3_1A, ldc.i4:int32(12))
	stfld:int32(HashSet`1::_freeList, ldloc:HashSet`1(this), ldloc:int32(var_3_1A))
	stloc:int32(var_4_28, ldfld:int32(HashSet`1::_lastIndex, ldloc:HashSet`1(this)))
	stloc:int32[](var_5_30, ldfld:int32[](HashSet`1::_buckets, ldloc:HashSet`1(this)))
	stloc:valuetype System.Collections.Generic.HashSet`1/Slot[](var_6_38, ldfld:valuetype System.Collections.Generic.HashSet`1/Slot<!T>[][exp:valuetype System.Collections.Generic.HashSet`1/Slot[]](HashSet`1::_slots, ldloc:HashSet`1(this)))
	stloc:int32(var_7_40, ldfld:int32(HashSet`1::_lastIndex, ldloc:HashSet`1(this)))
	stfld:int32(HashSet`1::_lastIndex, ldloc:HashSet`1(this), ldloc:int32(var_3_1A))
	stloc:int32[](var_8_4F, ldfld:int32[](HashSet`1::_buckets, ldloc:HashSet`1(this)))
	stloc:int32(var_10_5A, ldfld:int32(HashSet`1::_count, ldloc:HashSet`1(this)))
	stloc:SerializationInfo(var_11_62, ldfld:SerializationInfo(HashSet`1::_siInfo, ldloc:HashSet`1(this)))
	stfld:int32(HashSet`1::_count, ldloc:HashSet`1(this), ldloc:int32(var_10_5A))
	stfld:SerializationInfo(HashSet`1::_siInfo, ldloc:HashSet`1(this), ldloc:SerializationInfo(var_11_62))
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

		// Token: 0x06000149 RID: 329 RVA: 0x000042D4 File Offset: 0x000024D4
		private void AddValue(int index, int hashCode, T value)
		{
			int[] buckets = this._buckets;
			HashSet.Slot[] slots = this._slots;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000042F4 File Offset: 0x000024F4
		private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
		{
			/*
An exception occurred when decompiling this method (0600014A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Generic.HashSet`1::AreEqualityComparersEqual(System.Collections.Generic.HashSet`1<T>,System.Collections.Generic.HashSet`1<T>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(HashSet`1::_count, ldloc:class System.Collections.Generic.HashSet`1<!T>[exp:HashSet`1](set2)))
	stloc:int32(var_1_0D, ldfld:int32(HashSet`1::_count, ldloc:class System.Collections.Generic.HashSet`1<!T>[exp:HashSet`1](set2)))
	stloc:int32(var_2_14, ldfld:int32(HashSet`1::_count, ldloc:class System.Collections.Generic.HashSet`1<!T>[exp:HashSet`1](set2)))
	stloc:int32(var_3_1B, ldfld:int32(HashSet`1::_count, ldloc:class System.Collections.Generic.HashSet`1<!T>[exp:HashSet`1](set2)))
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

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		private int InternalGetHashCode(T item)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040000A4 RID: 164
		private const int Lower31BitMask = 2147483647;

		// Token: 0x040000A5 RID: 165
		private const int StackAllocThreshold = 100;

		// Token: 0x040000A6 RID: 166
		private const int ShrinkThreshold = 3;

		// Token: 0x040000A7 RID: 167
		private const string CapacityName = "Capacity";

		// Token: 0x040000A8 RID: 168
		private const string ElementsName = "Elements";

		// Token: 0x040000A9 RID: 169
		private const string ComparerName = "Comparer";

		// Token: 0x040000AA RID: 170
		private const string VersionName = "Version";

		// Token: 0x040000AB RID: 171
		private int[] _buckets;

		// Token: 0x040000AC RID: 172
		private HashSet<T>.Slot[] _slots;

		// Token: 0x040000AD RID: 173
		private int _count;

		// Token: 0x040000AE RID: 174
		private int _lastIndex;

		// Token: 0x040000AF RID: 175
		private int _freeList;

		// Token: 0x040000B0 RID: 176
		private IEqualityComparer<T> _comparer;

		// Token: 0x040000B1 RID: 177
		private int _version;

		// Token: 0x040000B2 RID: 178
		private SerializationInfo _siInfo;

		// Token: 0x0200002D RID: 45
		internal struct Slot
		{
			// Token: 0x040000B3 RID: 179
			internal int hashCode;

			// Token: 0x040000B4 RID: 180
			internal int next;

			// Token: 0x040000B5 RID: 181
			internal T value;
		}

		// Token: 0x0200002E RID: 46
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
		{
			// Token: 0x0600014C RID: 332 RVA: 0x0000431C File Offset: 0x0000251C
			internal Enumerator(HashSet<T> set)
			{
				SerializationInfo siInfo = set._siInfo;
				this._version = siInfo;
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00004338 File Offset: 0x00002538
			public void Dispose()
			{
			}

			// Token: 0x0600014E RID: 334 RVA: 0x00004348 File Offset: 0x00002548
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (0600014E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Enumerator::_version, ldloc:valuetype System.Collections.Generic.HashSet`1/Enumerator&(this)))
	stloc:int32(var_1_0D, ldfld:int32(Enumerator::_index, ldloc:valuetype System.Collections.Generic.HashSet`1/Enumerator&(this)))
	stfld:int32(Enumerator::_index, ldloc:valuetype System.Collections.Generic.HashSet`1/Enumerator&(this), ldloc:int32(var_1_0D))
	stloc:int64(var_2_16, ldc.i4:int64(0))
	stfld:int32(Enumerator::_index, ldloc:valuetype System.Collections.Generic.HashSet`1/Enumerator&(this), ldloc:int64[exp:int32](var_2_16))
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

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x0600014F RID: 335 RVA: 0x00004374 File Offset: 0x00002574
			public T Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000150 RID: 336 RVA: 0x00004388 File Offset: 0x00002588
			object IEnumerator.Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (06000150)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T(var_0_0E, ldfld:!T(Enumerator::_current, ldloc:valuetype System.Collections.Generic.HashSet`1/Enumerator&(this)))
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

			// Token: 0x06000151 RID: 337 RVA: 0x000043A4 File Offset: 0x000025A4
			void IEnumerator.Reset()
			{
				int version = this._version;
			}

			// Token: 0x040000B6 RID: 182
			private HashSet<T> _set;

			// Token: 0x040000B7 RID: 183
			private int _index;

			// Token: 0x040000B8 RID: 184
			private int _version;

			// Token: 0x040000B9 RID: 185
			private T _current;
		}
	}
}
