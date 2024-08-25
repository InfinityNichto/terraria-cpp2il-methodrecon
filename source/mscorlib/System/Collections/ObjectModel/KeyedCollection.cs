using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Collections.ObjectModel
{
	// Token: 0x02000620 RID: 1568
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	[Serializable]
	public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		// Token: 0x0600300B RID: 12299 RVA: 0x000699A0 File Offset: 0x00067BA0
		protected KeyedCollection()
		{
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000699B0 File Offset: 0x00067BB0
		protected KeyedCollection(IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000699C0 File Offset: 0x00067BC0
		protected KeyedCollection(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
		{
			IEqualityComparer equalityComparer = this.comparer;
			Dictionary dictionary = this.dict;
			if (comparer == null)
			{
			}
			this.dict = this;
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x000699E8 File Offset: 0x00067BE8
		private new List<TItem> Items
		{
			get
			{
				if (this != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x170007AA RID: 1962
		public TItem this[TKey key]
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00069A00 File Offset: 0x00067C00
		public bool Contains(TKey key)
		{
			if (key != null)
			{
				if (this.keyCount != 0)
				{
				}
				Dictionary dictionary = this.dict;
				if (!false)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x00069A38 File Offset: 0x00067C38
		public bool TryGetValue(TKey key, [Out] TItem item)
		{
			if (key != null)
			{
				int num = this.keyCount;
				if (num != 0)
				{
				}
				while (num == 0)
				{
				}
				long num2 = 0L;
				int num3 = 9;
				if (num2 != 0L || num3 == 0)
				{
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x00069A70 File Offset: 0x00067C70
		protected IDictionary<TKey, TItem> Dictionary
		{
			get
			{
				/*
An exception occurred when decompiling this method (06003012)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.IDictionary`2<TKey,TItem> System.Collections.ObjectModel.KeyedCollection`2::get_Dictionary()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(KeyedCollection`2::keyCount, ldloc:KeyedCollection`2(this)))
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

		// Token: 0x06003013 RID: 12307 RVA: 0x00069A84 File Offset: 0x00067C84
		protected override void ClearItems()
		{
			if (this.keyCount != 0)
			{
			}
		}

		// Token: 0x06003014 RID: 12308
		protected abstract TKey GetKeyForItem(TItem item);

		// Token: 0x06003015 RID: 12309 RVA: 0x00069A9C File Offset: 0x00067C9C
		protected override void InsertItem(int index, TItem item)
		{
			if (this != null)
			{
			}
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00069AAC File Offset: 0x00067CAC
		protected override void RemoveItem(int index)
		{
			if (this != null)
			{
			}
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x00069ABC File Offset: 0x00067CBC
		protected override void SetItem(int index, TItem item)
		{
			Dictionary dictionary = this.dict;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00069AE4 File Offset: 0x00067CE4
		private void AddKey(TKey key, TItem item)
		{
			if (this.keyCount != 0)
			{
				return;
			}
			int num = this.keyCount;
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00069B04 File Offset: 0x00067D04
		private void CreateDictionary()
		{
			Dictionary dictionary = this.dict;
			this.keyCount = this;
			while (this == null)
			{
			}
			int num = this.keyCount;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00069B48 File Offset: 0x00067D48
		private void RemoveKey(TKey key)
		{
			if (this.keyCount != 0)
			{
				return;
			}
		}

		// Token: 0x04001A44 RID: 6724
		private readonly IEqualityComparer<TKey> comparer;

		// Token: 0x04001A45 RID: 6725
		private Dictionary<TKey, TItem> dict;

		// Token: 0x04001A46 RID: 6726
		private int keyCount;

		// Token: 0x04001A47 RID: 6727
		private readonly int threshold;
	}
}
