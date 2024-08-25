using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000640 RID: 1600
	internal class LowLevelDictionary<TKey, TValue>
	{
		// Token: 0x060030F5 RID: 12533 RVA: 0x0006AC88 File Offset: 0x00068E88
		public LowLevelDictionary()
		{
			LowLevelDictionary.Entry[] buckets = this._buckets;
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x0006AC9C File Offset: 0x00068E9C
		public LowLevelDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
			this._comparer = comparer;
		}

		// Token: 0x170007E5 RID: 2021
		public TKey this[TKey key]
		{
			set
			{
				int version = this._version;
				this._version = version;
				if (this != null)
				{
					this._numEntries = value;
					return;
				}
			}
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x0006ACE0 File Offset: 0x00068EE0
		public void Clear(int capacity = 17)
		{
			int version = this._version;
			this._version = version;
			this._buckets = this;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x0006AD04 File Offset: 0x00068F04
		public bool Remove(TKey key)
		{
			LowLevelDictionary.Entry[] buckets = this._buckets;
			if (buckets != null)
			{
				IEqualityComparer comparer = this._comparer;
			}
			long num = 0L;
			if (buckets != null)
			{
			}
			LowLevelDictionary.Entry[] buckets2 = this._buckets;
			if (num != 0L)
			{
				int numEntries = this._numEntries;
				this._numEntries = numEntries;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0006AD4C File Offset: 0x00068F4C
		private LowLevelDictionary<TKey, TValue>.Entry Find(TKey key)
		{
			/*
An exception occurred when decompiling this method (060030FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.LowLevelDictionary`2/Entry<TKey,TValue> System.Collections.Generic.LowLevelDictionary`2::Find(TKey)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.LowLevelDictionary`2/Entry[](var_0_06, ldfld:class System.Collections.Generic.LowLevelDictionary`2/Entry<!TKey, !TValue>[][exp:class System.Collections.Generic.LowLevelDictionary`2/Entry[]](LowLevelDictionary`2::_buckets, ldloc:LowLevelDictionary`2(this)))
	stloc:IEqualityComparer`1(var_1_0D, ldfld:class System.Collections.Generic.IEqualityComparer`1<!TKey>[exp:IEqualityComparer`1](LowLevelDictionary`2::_comparer, ldloc:LowLevelDictionary`2(this)))
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

		// Token: 0x060030FB RID: 12539 RVA: 0x0006AD68 File Offset: 0x00068F68
		private LowLevelDictionary<TKey, TValue>.Entry UncheckedAdd(TKey key, TValue value)
		{
			this._buckets = key;
			this._numEntries = value;
			LowLevelDictionary.Entry[] buckets = this._buckets;
			if (this == null || this != null)
			{
				int numEntries = this._numEntries;
				LowLevelDictionary.Entry[] buckets2 = this._buckets;
				this._numEntries = numEntries;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x0006ADAC File Offset: 0x00068FAC
		private void ExpandBuckets()
		{
			LowLevelDictionary.Entry[] buckets = this._buckets;
			LowLevelDictionary.Entry[] buckets2 = this._buckets;
			if (this != null)
			{
				LowLevelDictionary.Entry[] buckets3 = this._buckets;
				this._buckets = this;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x0006ADEC File Offset: 0x00068FEC
		private int GetBucket(TKey key, int numBuckets = 0)
		{
			/*
An exception occurred when decompiling this method (060030FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Generic.LowLevelDictionary`2::GetBucket(TKey,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Collections.Generic.LowLevelDictionary`2/Entry[](var_1_10, ldfld:class System.Collections.Generic.LowLevelDictionary`2/Entry<!TKey, !TValue>[][exp:class System.Collections.Generic.LowLevelDictionary`2/Entry[]](LowLevelDictionary`2::_buckets, ldloc:LowLevelDictionary`2(this)))
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

		// Token: 0x04001A84 RID: 6788
		private LowLevelDictionary<TKey, TValue>.Entry[] _buckets;

		// Token: 0x04001A85 RID: 6789
		private int _numEntries;

		// Token: 0x04001A86 RID: 6790
		private int _version;

		// Token: 0x04001A87 RID: 6791
		private IEqualityComparer<TKey> _comparer;

		// Token: 0x02000641 RID: 1601
		private sealed class Entry
		{
			// Token: 0x060030FE RID: 12542 RVA: 0x0006AE0C File Offset: 0x0006900C
			public Entry()
			{
			}

			// Token: 0x04001A88 RID: 6792
			public TKey _key;

			// Token: 0x04001A89 RID: 6793
			public TValue _value;

			// Token: 0x04001A8A RID: 6794
			public LowLevelDictionary<TKey, TValue>.Entry _next;
		}

		// Token: 0x02000642 RID: 1602
		private sealed class DefaultComparer<T> : IEqualityComparer<T>
		{
			// Token: 0x060030FF RID: 12543 RVA: 0x0006AE20 File Offset: 0x00069020
			public bool Equals(T x, T y)
			{
				/*
An exception occurred when decompiling this method (060030FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Generic.LowLevelDictionary`2/DefaultComparer`1::Equals(T,T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:DefaultComparer`1[exp:bool](this)))
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

			// Token: 0x06003100 RID: 12544 RVA: 0x0000207A File Offset: 0x0000027A
			public int GetHashCode(T obj)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06003101 RID: 12545 RVA: 0x0006AE30 File Offset: 0x00069030
			public DefaultComparer()
			{
			}
		}
	}
}
