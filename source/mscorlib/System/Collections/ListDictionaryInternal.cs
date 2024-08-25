using System;
using Cpp2IlInjected;

namespace System.Collections
{
	// Token: 0x020005ED RID: 1517
	[Serializable]
	internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x06002DCA RID: 11722 RVA: 0x00064E7C File Offset: 0x0006307C
		public ListDictionaryInternal()
		{
		}

		// Token: 0x17000705 RID: 1797
		public object this[object key]
		{
			get
			{
				while (key == null)
				{
				}
				ListDictionaryInternal.DictionaryNode dictionaryNode = this.head;
				ListDictionaryInternal.DictionaryNode next;
				if (dictionaryNode != null)
				{
					object key2 = dictionaryNode.key;
					next = dictionaryNode.next;
					while (next != null)
					{
					}
				}
				return next.value;
			}
			set
			{
				for (;;)
				{
					if (key != null)
					{
						ListDictionaryInternal.DictionaryNode dictionaryNode = this.head;
						if (dictionaryNode == null)
						{
							goto IL_001D;
						}
						object key2 = dictionaryNode.key;
						if (dictionaryNode.next == null)
						{
							break;
						}
					}
				}
				return;
				IL_001D:
				int num = this.count;
				this.count = num;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x00064F00 File Offset: 0x00063100
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002DCE RID: 11726 RVA: 0x0000207A File Offset: 0x0000027A
		public ICollection Keys
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x00064F14 File Offset: 0x00063114
		public bool IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06002DD0 RID: 11728 RVA: 0x00064F24 File Offset: 0x00063124
		public bool IsFixedSize
		{
			get
			{
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x00064F34 File Offset: 0x00063134
		public bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002DD2 RID: 11730 RVA: 0x00064F44 File Offset: 0x00063144
		public object SyncRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002DD2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.ListDictionaryInternal::get_SyncRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:object[exp:bool](ListDictionaryInternal::_syncRoot, ldloc:ListDictionaryInternal(this)))
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

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x0000207A File Offset: 0x0000027A
		public ICollection Values
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00064F58 File Offset: 0x00063158
		public void Add(object key, object value)
		{
			for (;;)
			{
				if (key != null)
				{
					ListDictionaryInternal.DictionaryNode dictionaryNode = this.head;
					if (dictionaryNode == null)
					{
						goto IL_001D;
					}
					object key2 = dictionaryNode.key;
					if (dictionaryNode.next == null)
					{
						break;
					}
				}
			}
			return;
			IL_001D:
			int num = this.count;
			this.count = num;
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00064FA0 File Offset: 0x000631A0
		public void Clear()
		{
			int num = this.version;
			this.version = num;
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00064FBC File Offset: 0x000631BC
		public bool Contains(object key)
		{
			for (;;)
			{
				if (key != null)
				{
					ListDictionaryInternal.DictionaryNode dictionaryNode = this.head;
					if (dictionaryNode == null)
					{
						break;
					}
					object key2 = dictionaryNode.key;
					if (dictionaryNode.next == null)
					{
						break;
					}
				}
			}
			return true;
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00064FE8 File Offset: 0x000631E8
		public void CopyTo(Array array, int index)
		{
			while (array != null)
			{
				int rank = array.Rank;
				int length = array.Length;
				int num = this.count;
				ListDictionaryInternal.DictionaryNode dictionaryNode = this.head;
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

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00065034 File Offset: 0x00063234
		public IDictionaryEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06002DD8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IDictionaryEnumerator System.Collections.ListDictionaryInternal::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ListDictionaryInternal::version, ldloc:ListDictionaryInternal(this)))
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

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00065048 File Offset: 0x00063248
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06002DD9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Collections.ListDictionaryInternal::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(ListDictionaryInternal::version, ldloc:ListDictionaryInternal(this)))
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

		// Token: 0x06002DDA RID: 11738 RVA: 0x0006505C File Offset: 0x0006325C
		public void Remove(object key)
		{
			while (key == null)
			{
			}
			ListDictionaryInternal.DictionaryNode dictionaryNode = this.head;
			if (dictionaryNode != null)
			{
				object key2 = dictionaryNode.key;
				return;
			}
		}

		// Token: 0x040019A3 RID: 6563
		private ListDictionaryInternal.DictionaryNode head;

		// Token: 0x040019A4 RID: 6564
		private int version;

		// Token: 0x040019A5 RID: 6565
		private int count;

		// Token: 0x040019A6 RID: 6566
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020005EE RID: 1518
		private class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06002DDB RID: 11739 RVA: 0x000650B0 File Offset: 0x000632B0
			public NodeEnumerator(ListDictionaryInternal list)
			{
				this.list = list;
				int num = list.version;
				this.start = true;
				this.version = num;
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000650E0 File Offset: 0x000632E0
			public object Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002DDC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.ListDictionaryInternal/NodeEnumerator::get_Current()

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

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06002DDD RID: 11741 RVA: 0x000650F4 File Offset: 0x000632F4
			public DictionaryEntry Entry
			{
				get
				{
					/*
An exception occurred when decompiling this method (06002DDD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.DictionaryEntry System.Collections.ListDictionaryInternal/NodeEnumerator::get_Entry()

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

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06002DDE RID: 11742 RVA: 0x00065118 File Offset: 0x00063318
			public object Key
			{
				get
				{
					ListDictionaryInternal.DictionaryNode dictionaryNode;
					do
					{
						dictionaryNode = this.current;
					}
					while (dictionaryNode == null);
					return dictionaryNode.key;
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06002DDF RID: 11743 RVA: 0x00065138 File Offset: 0x00063338
			public object Value
			{
				get
				{
					ListDictionaryInternal.DictionaryNode dictionaryNode;
					do
					{
						dictionaryNode = this.current;
					}
					while (dictionaryNode == null);
					return dictionaryNode.value;
				}
			}

			// Token: 0x06002DE0 RID: 11744 RVA: 0x00065158 File Offset: 0x00063358
			public bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06002DE0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.ListDictionaryInternal/NodeEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:DictionaryNode(var_5_37, ldfld:DictionaryNode(DictionaryNode::next, ldloc:DictionaryNode(var_4_2A)))
	stfld:DictionaryNode(NodeEnumerator::current, ldloc:NodeEnumerator(this), ldloc:DictionaryNode(var_5_37))
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

			// Token: 0x06002DE1 RID: 11745 RVA: 0x000651A8 File Offset: 0x000633A8
			public void Reset()
			{
				ListDictionaryInternal listDictionaryInternal = this.list;
				int num = this.version;
				int num2 = listDictionaryInternal.version;
				this.start = true;
			}

			// Token: 0x040019A7 RID: 6567
			private ListDictionaryInternal list;

			// Token: 0x040019A8 RID: 6568
			private ListDictionaryInternal.DictionaryNode current;

			// Token: 0x040019A9 RID: 6569
			private int version;

			// Token: 0x040019AA RID: 6570
			private bool start;
		}

		// Token: 0x020005EF RID: 1519
		private class NodeKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x06002DE2 RID: 11746 RVA: 0x000651D4 File Offset: 0x000633D4
			public NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys)
			{
				this.list = list;
			}

			// Token: 0x06002DE3 RID: 11747 RVA: 0x000651F0 File Offset: 0x000633F0
			void ICollection.CopyTo(Array array, int index)
			{
				while (array != null)
				{
					long num = 0L;
					int length = array.Length;
					ListDictionaryInternal listDictionaryInternal = this.list;
					int count = listDictionaryInternal.count;
					ListDictionaryInternal.DictionaryNode head = listDictionaryInternal.head;
					if (head != null)
					{
						bool flag = this.isKeys;
						array.SetValue(num, index);
						if (head.next != null)
						{
							continue;
						}
					}
					return;
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x06002DE4 RID: 11748 RVA: 0x00065240 File Offset: 0x00063440
			int ICollection.Count
			{
				get
				{
					for (;;)
					{
						ListDictionaryInternal.DictionaryNode head = this.list.head;
						if (head == null || head.next == null)
						{
							return;
						}
					}
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x00065268 File Offset: 0x00063468
			bool ICollection.IsSynchronized
			{
				get
				{
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x00065278 File Offset: 0x00063478
			object ICollection.SyncRoot
			{
				get
				{
					return this.list.SyncRoot;
				}
			}

			// Token: 0x06002DE7 RID: 11751 RVA: 0x00065290 File Offset: 0x00063490
			IEnumerator IEnumerable.GetEnumerator()
			{
				/*
An exception occurred when decompiling this method (06002DE7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Collections.ListDictionaryInternal/NodeKeyValueCollection::System.Collections.IEnumerable.GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:ListDictionaryInternal(var_0_06, ldfld:ListDictionaryInternal(NodeKeyValueCollection::list, ldloc:NodeKeyValueCollection(this)))
	stloc:bool(var_1_0D, ldfld:bool(NodeKeyValueCollection::isKeys, ldloc:NodeKeyValueCollection(this)))
	stloc:int32(var_2_14, ldfld:int32(ListDictionaryInternal::version, ldloc:ListDictionaryInternal(var_0_06)))
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

			// Token: 0x040019AB RID: 6571
			private ListDictionaryInternal list;

			// Token: 0x040019AC RID: 6572
			private bool isKeys;

			// Token: 0x020005F0 RID: 1520
			private class NodeKeyValueEnumerator : IEnumerator
			{
				// Token: 0x06002DE8 RID: 11752 RVA: 0x0001B05E File Offset: 0x0001925E
				public NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys)
				{
				}

				// Token: 0x17000714 RID: 1812
				// (get) Token: 0x06002DE9 RID: 11753 RVA: 0x000273E5 File Offset: 0x000255E5
				public object Current
				{
					get
					{
						return null;
					}
				}

				// Token: 0x06002DEA RID: 11754 RVA: 0x000652B4 File Offset: 0x000634B4
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x06002DEB RID: 11755 RVA: 0x0001B05E File Offset: 0x0001925E
				public void Reset()
				{
				}

				// Token: 0x040019AD RID: 6573
				private ListDictionaryInternal list;

				// Token: 0x040019AE RID: 6574
				private ListDictionaryInternal.DictionaryNode current;

				// Token: 0x040019AF RID: 6575
				private int version;

				// Token: 0x040019B0 RID: 6576
				private bool isKeys;

				// Token: 0x040019B1 RID: 6577
				private bool start;
			}
		}

		// Token: 0x020005F1 RID: 1521
		[Serializable]
		private class DictionaryNode
		{
			// Token: 0x06002DEC RID: 11756 RVA: 0x000652CC File Offset: 0x000634CC
			public DictionaryNode()
			{
			}

			// Token: 0x040019B2 RID: 6578
			public object key;

			// Token: 0x040019B3 RID: 6579
			public object value;

			// Token: 0x040019B4 RID: 6580
			public ListDictionaryInternal.DictionaryNode next;
		}
	}
}
