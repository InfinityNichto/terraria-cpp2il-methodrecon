using System;
using Cpp2IlInjected;

namespace System.Collections.Specialized
{
	// Token: 0x02000418 RID: 1048
	[Serializable]
	public class ListDictionary : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x06001C28 RID: 7208 RVA: 0x0004D1AC File Offset: 0x0004B3AC
		public ListDictionary()
		{
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0004D1C0 File Offset: 0x0004B3C0
		public ListDictionary(IComparer comparer)
		{
			this.comparer = comparer;
		}

		// Token: 0x17000641 RID: 1601
		public object this[object key]
		{
			get
			{
				while (key == null)
				{
				}
				IComparer comparer = this.comparer;
				ListDictionary.DictionaryNode dictionaryNode = this.head;
				ListDictionary.DictionaryNode next2;
				if (comparer != null)
				{
					if (dictionaryNode == null)
					{
						goto IL_0047;
					}
					object key2 = dictionaryNode.key;
					if (comparer == null)
					{
						goto IL_004A;
					}
					ListDictionary.DictionaryNode next = dictionaryNode.next;
					if (next == null)
					{
						goto IL_0047;
					}
					IComparer comparer2 = this.comparer;
					object key3 = next.key;
					next2 = next.next;
				}
				while (next2 != null)
				{
				}
				IL_0047:
				IL_004A:
				return next2.value;
			}
			set
			{
				while (key == null)
				{
				}
				ListDictionary.DictionaryNode dictionaryNode = this.head;
				if (dictionaryNode == null)
				{
					int num = this.count;
					this.count = num;
					return;
				}
				IComparer comparer = this.comparer;
				object key2 = dictionaryNode.key;
				if (comparer != null)
				{
					return;
				}
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x0004D288 File Offset: 0x0004B488
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00002050 File Offset: 0x00000250
		public ICollection Keys
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x0004D29C File Offset: 0x0004B49C
		public bool IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x0004D2AC File Offset: 0x0004B4AC
		public bool IsFixedSize
		{
			get
			{
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x0004D2BC File Offset: 0x0004B4BC
		public bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x0004D2CC File Offset: 0x0004B4CC
		public object SyncRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001C31)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Specialized.ListDictionary::get_SyncRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:object[exp:bool](ListDictionary::_syncRoot, ldloc:ListDictionary(this)))
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00002050 File Offset: 0x00000250
		public ICollection Values
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0004D2E0 File Offset: 0x0004B4E0
		public void Add(object key, object value)
		{
			while (key == null)
			{
			}
			ListDictionary.DictionaryNode dictionaryNode = this.head;
			if (dictionaryNode == null)
			{
				int num = this.count;
				this.count = num;
				return;
			}
			IComparer comparer = this.comparer;
			object key2 = dictionaryNode.key;
			if (comparer != null)
			{
				return;
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0004D338 File Offset: 0x0004B538
		public void Clear()
		{
			int num = this.version;
			this.version = num;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0004D354 File Offset: 0x0004B554
		public bool Contains(object key)
		{
			for (;;)
			{
				if (key != null)
				{
					ListDictionary.DictionaryNode dictionaryNode = this.head;
					if (dictionaryNode == null)
					{
						return;
					}
					IComparer comparer = this.comparer;
					object key2 = dictionaryNode.key;
					if (comparer != null)
					{
					}
					if (comparer == null)
					{
						return;
					}
					if (dictionaryNode.next == null)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0004D390 File Offset: 0x0004B590
		public void CopyTo(Array array, int index)
		{
			while (array != null)
			{
				int length = array.Length;
				int num = this.count;
				ListDictionary.DictionaryNode dictionaryNode = this.head;
				if (dictionaryNode != null)
				{
					object key = dictionaryNode.key;
					object value = dictionaryNode.value;
					if (dictionaryNode.next != null)
					{
						continue;
					}
				}
				return;
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
		public IDictionaryEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06001C37)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IDictionaryEnumerator System.Collections.Specialized.ListDictionary::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ListDictionary::version, ldloc:ListDictionary(this)))
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

		// Token: 0x06001C38 RID: 7224 RVA: 0x0004D3E4 File Offset: 0x0004B5E4
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06001C38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Collections.Specialized.ListDictionary::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ListDictionary::version, ldloc:ListDictionary(this)))
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

		// Token: 0x06001C39 RID: 7225 RVA: 0x0004D3F8 File Offset: 0x0004B5F8
		public void Remove(object key)
		{
			while (key == null)
			{
			}
			ListDictionary.DictionaryNode dictionaryNode = this.head;
			if (dictionaryNode == null)
			{
				return;
			}
			IComparer comparer = this.comparer;
			object key2 = dictionaryNode.key;
			if (comparer != null)
			{
				return;
			}
		}

		// Token: 0x04001396 RID: 5014
		private ListDictionary.DictionaryNode head;

		// Token: 0x04001397 RID: 5015
		private int version;

		// Token: 0x04001398 RID: 5016
		private int count;

		// Token: 0x04001399 RID: 5017
		private readonly IComparer comparer;

		// Token: 0x0400139A RID: 5018
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x02000419 RID: 1049
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001C3A RID: 7226 RVA: 0x0004D450 File Offset: 0x0004B650
			public NodeEnumerator(ListDictionary list)
			{
				this._list = list;
				int version = list.version;
				this._start = true;
				this._version = version;
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0004D480 File Offset: 0x0004B680
			public object Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001C3B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Specialized.ListDictionary/NodeEnumerator::get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DictionaryEntry(var_0_06, callgetter:DictionaryEntry(NodeEnumerator::get_Entry, ldloc:NodeEnumerator(this)))
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

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0004D494 File Offset: 0x0004B694
			public DictionaryEntry Entry
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001C3C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.DictionaryEntry System.Collections.Specialized.ListDictionary/NodeEnumerator::get_Entry()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object(var_1_10, ldfld:object(DictionaryNode::key, ldloc:DictionaryNode(var_0_06)))
	stloc:object(var_2_17, ldfld:object(DictionaryNode::value, ldloc:DictionaryNode(var_0_06)))
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

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0004D4B8 File Offset: 0x0004B6B8
			public object Key
			{
				get
				{
					ListDictionary.DictionaryNode current;
					do
					{
						current = this._current;
					}
					while (current == null);
					return current.key;
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
			public object Value
			{
				get
				{
					ListDictionary.DictionaryNode current;
					do
					{
						current = this._current;
					}
					while (current == null);
					return current.value;
				}
			}

			// Token: 0x06001C3F RID: 7231 RVA: 0x0004D4F8 File Offset: 0x0004B6F8
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06001C3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Specialized.ListDictionary/NodeEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:DictionaryNode(var_5_37, ldfld:DictionaryNode(DictionaryNode::next, ldloc:DictionaryNode(var_4_2A)))
	stfld:DictionaryNode(NodeEnumerator::_current, ldloc:NodeEnumerator(this), ldloc:DictionaryNode(var_5_37))
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

			// Token: 0x06001C40 RID: 7232 RVA: 0x0004D548 File Offset: 0x0004B748
			public void Reset()
			{
				ListDictionary list = this._list;
				int version = this._version;
				int version2 = list.version;
				this._start = true;
			}

			// Token: 0x0400139B RID: 5019
			private ListDictionary _list;

			// Token: 0x0400139C RID: 5020
			private ListDictionary.DictionaryNode _current;

			// Token: 0x0400139D RID: 5021
			private int _version;

			// Token: 0x0400139E RID: 5022
			private bool _start;
		}

		// Token: 0x0200041A RID: 1050
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06001C41 RID: 7233 RVA: 0x0004D574 File Offset: 0x0004B774
			public NodeKeyValueCollection(ListDictionary list, bool isKeys)
			{
				this._list = list;
			}

			// Token: 0x06001C42 RID: 7234 RVA: 0x0004D590 File Offset: 0x0004B790
			void ICollection.CopyTo(Array array, int index)
			{
				for (;;)
				{
					if (array != null)
					{
						ListDictionary.DictionaryNode head = this._list.head;
						if (head == null)
						{
							break;
						}
						bool isKeys = this._isKeys;
						array.SetValue(array, index);
						if (head.next == null)
						{
							break;
						}
					}
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
			int ICollection.Count
			{
				get
				{
					for (;;)
					{
						ListDictionary.DictionaryNode head = this._list.head;
						if (head == null || head.next == null)
						{
							return;
						}
					}
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x06001C44 RID: 7236 RVA: 0x0004D5F0 File Offset: 0x0004B7F0
			bool ICollection.IsSynchronized
			{
				get
				{
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x06001C45 RID: 7237 RVA: 0x0004D600 File Offset: 0x0004B800
			object ICollection.SyncRoot
			{
				get
				{
					return this._list.SyncRoot;
				}
			}

			// Token: 0x06001C46 RID: 7238 RVA: 0x0004D618 File Offset: 0x0004B818
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06001C46)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Collections.Specialized.ListDictionary/NodeKeyValueCollection::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ListDictionary(var_0_06, ldfld:ListDictionary(NodeKeyValueCollection::_list, ldloc:NodeKeyValueCollection(this)))
	stloc:bool(var_1_0D, ldfld:bool(NodeKeyValueCollection::_isKeys, ldloc:NodeKeyValueCollection(this)))
	stloc:int32(var_2_14, ldfld:int32(ListDictionary::version, ldloc:ListDictionary(var_0_06)))
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

			// Token: 0x0400139F RID: 5023
			private ListDictionary _list;

			// Token: 0x040013A0 RID: 5024
			private bool _isKeys;

			// Token: 0x0200041B RID: 1051
			private class NodeKeyValueEnumerator : IEnumerator
			{
				// Token: 0x06001C47 RID: 7239 RVA: 0x0000205C File Offset: 0x0000025C
				public NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
				{
				}

				// Token: 0x17000650 RID: 1616
				// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0000205E File Offset: 0x0000025E
				public object Current
				{
					get
					{
						return null;
					}
				}

				// Token: 0x06001C49 RID: 7241 RVA: 0x0004D63C File Offset: 0x0004B83C
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x06001C4A RID: 7242 RVA: 0x0000205C File Offset: 0x0000025C
				public void Reset()
				{
				}

				// Token: 0x040013A1 RID: 5025
				private ListDictionary _list;

				// Token: 0x040013A2 RID: 5026
				private ListDictionary.DictionaryNode _current;

				// Token: 0x040013A3 RID: 5027
				private int _version;

				// Token: 0x040013A4 RID: 5028
				private bool _isKeys;

				// Token: 0x040013A5 RID: 5029
				private bool _start;
			}
		}

		// Token: 0x0200041C RID: 1052
		[Serializable]
		public class DictionaryNode
		{
			// Token: 0x06001C4B RID: 7243 RVA: 0x0004D654 File Offset: 0x0004B854
			public DictionaryNode()
			{
			}

			// Token: 0x040013A6 RID: 5030
			public object key;

			// Token: 0x040013A7 RID: 5031
			public object value;

			// Token: 0x040013A8 RID: 5032
			public ListDictionary.DictionaryNode next;
		}
	}
}
