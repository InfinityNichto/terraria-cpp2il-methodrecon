using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x02000430 RID: 1072
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x06001CFD RID: 7421 RVA: 0x0004EC80 File Offset: 0x0004CE80
		public LinkedList()
		{
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0004EC94 File Offset: 0x0004CE94
		protected LinkedList(SerializationInfo info, StreamingContext context)
		{
			this._siInfo = info;
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0004ECB0 File Offset: 0x0004CEB0
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0004ECC4 File Offset: 0x0004CEC4
		public LinkedListNode<T> First
		{
			get
			{
				return this.head;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0004ECD8 File Offset: 0x0004CED8
		bool ICollection<T>.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x0004ECE8 File Offset: 0x0004CEE8
		void ICollection<T>.Add(T value)
		{
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x0004ECF8 File Offset: 0x0004CEF8
		public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
		{
			/*
An exception occurred when decompiling this method (06001D03)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.LinkedListNode`1<T> System.Collections.Generic.LinkedList`1::AddAfter(System.Collections.Generic.LinkedListNode`1<T>,T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LinkedList`1(var_0_06, ldfld:class System.Collections.Generic.LinkedList`1<!T>[exp:LinkedList`1](LinkedListNode`1::list, ldloc:class System.Collections.Generic.LinkedListNode`1<!T>[exp:LinkedListNode`1](node)))
	stloc:LinkedListNode`1(var_1_0D, ldfld:class System.Collections.Generic.LinkedListNode`1<!T>[exp:LinkedListNode`1](LinkedListNode`1::next, ldloc:class System.Collections.Generic.LinkedListNode`1<!T>[exp:LinkedListNode`1](node)))
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

		// Token: 0x06001D04 RID: 7428 RVA: 0x0004ED14 File Offset: 0x0004CF14
		public LinkedListNode<T> AddFirst(T value)
		{
			/*
An exception occurred when decompiling this method (06001D04)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.LinkedListNode`1<T> System.Collections.Generic.LinkedList`1::AddFirst(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:SerializationInfo(var_2_23, ldfld:SerializationInfo(LinkedList`1::_siInfo, ldloc:LinkedList`1(this)))
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

		// Token: 0x06001D05 RID: 7429 RVA: 0x0004ED44 File Offset: 0x0004CF44
		public LinkedListNode<T> AddLast(T value)
		{
			/*
An exception occurred when decompiling this method (06001D05)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.LinkedListNode`1<T> System.Collections.Generic.LinkedList`1::AddLast(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0016:
	stloc:SerializationInfo(var_2_1C, ldfld:SerializationInfo(LinkedList`1::_siInfo, ldloc:LinkedList`1(this)))
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

		// Token: 0x06001D06 RID: 7430 RVA: 0x0004ED70 File Offset: 0x0004CF70
		public void AddLast(LinkedListNode<T> node)
		{
			if (this.head != null)
			{
				return;
			}
			node.list = this;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0004ED90 File Offset: 0x0004CF90
		public void Clear()
		{
			LinkedListNode linkedListNode = this.head;
			if (linkedListNode != null)
			{
				while (linkedListNode != null)
				{
				}
			}
			int num = this.version;
			this._syncRoot = num;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002050 File Offset: 0x00000250
		public bool Contains(T value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x0004EDB8 File Offset: 0x0004CFB8
		public void CopyTo(T[] array, int index)
		{
			if (array != null)
			{
				LinkedListNode linkedListNode = this.head;
				if (linkedListNode != null)
				{
					LinkedListNode next = linkedListNode.next;
					LinkedListNode linkedListNode2 = this.head;
				}
				return;
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x0004EDE4 File Offset: 0x0004CFE4
		public LinkedListNode<T> Find(T value)
		{
			/*
An exception occurred when decompiling this method (06001D0A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Generic.LinkedListNode`1<T> System.Collections.Generic.LinkedList`1::Find(T)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T(var_1_10, ldfld:!T(LinkedListNode`1::item, ldloc:LinkedListNode`1(var_0_06)))
	stloc:LinkedListNode`1(var_2_17, ldfld:class System.Collections.Generic.LinkedListNode`1<!T>[exp:LinkedListNode`1](LinkedListNode`1::next, ldloc:LinkedListNode`1(var_0_06)))
	stloc:LinkedListNode`1(var_3_1E, ldfld:class System.Collections.Generic.LinkedListNode`1<!T>[exp:LinkedListNode`1](LinkedList`1::head, ldloc:LinkedList`1(this)))
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

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002050 File Offset: 0x00000250
		public LinkedList<T>.Enumerator GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x0004EE14 File Offset: 0x0004D014
		public bool Remove(T value)
		{
			if (this != null)
			{
			}
			return true;
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0004EE28 File Offset: 0x0004D028
		public void Remove(LinkedListNode<T> node)
		{
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0004EE38 File Offset: 0x0004D038
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			while (info == null)
			{
			}
			int num = this.version;
			info.AddValue("Version", num);
			int num2 = this.count;
			info.AddValue("Count", num2);
			if (this.count != 0)
			{
				Type type;
				info.AddValue("Data", info, type);
				return;
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0004EE84 File Offset: 0x0004D084
		public virtual void OnDeserialization(object sender)
		{
			SerializationInfo siInfo = this._siInfo;
			if (siInfo != null)
			{
				int @int = siInfo.GetInt32("Version");
				if (this._siInfo.GetInt32("Count") != 0)
				{
					Type type;
					object value = this._siInfo.GetValue("Data", type);
					if (value != null && value != null)
					{
						return;
					}
					throw new InvalidCastException();
				}
				else
				{
					this.version = @int;
				}
			}
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0004EEE4 File Offset: 0x0004D0E4
		private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			newNode.next = node;
			LinkedListNode prev = node.prev;
			newNode.prev = prev;
			node.prev.next = newNode;
			node.prev = newNode;
			int num = this.count;
			this.count = num;
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0004EF28 File Offset: 0x0004D128
		private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
		{
			newNode.next = newNode;
			newNode.prev = newNode;
			int num = this.count;
			this.head = newNode;
			this.count = num;
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0004EF58 File Offset: 0x0004D158
		internal void InternalRemoveNode(LinkedListNode<T> node)
		{
			LinkedListNode next = node.next;
			LinkedListNode prev = node.prev;
			next.prev = prev;
			node.prev.next = next;
			LinkedListNode linkedListNode = this.head;
			LinkedListNode next2 = node.next;
			this.head = next2;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0004EFAC File Offset: 0x0004D1AC
		internal void ValidateNewNode(LinkedListNode<T> node)
		{
			while (node != null)
			{
				if (node.list == null)
				{
					return;
				}
			}
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x0004EFC8 File Offset: 0x0004D1C8
		internal void ValidateNode(LinkedListNode<T> node)
		{
			if (node != null)
			{
				LinkedList list = node.list;
				return;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0004EFE0 File Offset: 0x0004D1E0
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0004EFF0 File Offset: 0x0004D1F0
		object ICollection.SyncRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001D17)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Generic.LinkedList`1::System.Collections.ICollection.get_SyncRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:object[exp:bool](LinkedList`1::_syncRoot, ldloc:LinkedList`1(this)))
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

		// Token: 0x06001D18 RID: 7448 RVA: 0x0004F004 File Offset: 0x0004D204
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				return;
			}
			int rank = array.Rank;
			long num = 0L;
			if (array.GetLowerBound((int)num) != 0)
			{
				return;
			}
			int length = array.Length;
			if (array != null)
			{
				return;
			}
			if (array != null)
			{
				LinkedListNode linkedListNode = this.head;
				if (linkedListNode != null)
				{
					if (array != null && array == null)
					{
						throw new ArrayTypeMismatchException();
					}
					LinkedListNode next = linkedListNode.next;
					LinkedListNode linkedListNode2 = this.head;
				}
				return;
			}
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00002050 File Offset: 0x00000250
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x040013D7 RID: 5079
		internal LinkedListNode<T> head;

		// Token: 0x040013D8 RID: 5080
		internal int count;

		// Token: 0x040013D9 RID: 5081
		internal int version;

		// Token: 0x040013DA RID: 5082
		private object _syncRoot;

		// Token: 0x040013DB RID: 5083
		private SerializationInfo _siInfo;

		// Token: 0x040013DC RID: 5084
		private const string VersionName = "Version";

		// Token: 0x040013DD RID: 5085
		private const string CountName = "Count";

		// Token: 0x040013DE RID: 5086
		private const string ValuesName = "Data";

		// Token: 0x02000431 RID: 1073
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
		{
			// Token: 0x06001D1A RID: 7450 RVA: 0x0004F068 File Offset: 0x0004D268
			internal Enumerator(LinkedList<T> list)
			{
				this._list = list;
				int version = list.version;
				this._version = version;
				LinkedListNode head = list.head;
				this._node = head;
			}

			// Token: 0x06001D1B RID: 7451 RVA: 0x00002050 File Offset: 0x00000250
			private Enumerator(SerializationInfo info, StreamingContext context)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00002050 File Offset: 0x00000250
			public T Current
			{
				get
				{
					throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0004F098 File Offset: 0x0004D298
			object IEnumerator.Current
			{
				get
				{
					/*
An exception occurred when decompiling this method (06001D1D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Generic.LinkedList`1/Enumerator::System.Collections.IEnumerator.get_Current()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:LinkedListNode`1(var_0_06, ldfld:class System.Collections.Generic.LinkedListNode`1<!T>[exp:LinkedListNode`1](Enumerator::_node, ldloc:valuetype System.Collections.Generic.LinkedList`1/Enumerator&(this)))
	stloc:int32(var_1_0D, ldfld:int32(Enumerator::_version, ldloc:valuetype System.Collections.Generic.LinkedList`1/Enumerator&(this)))
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

			// Token: 0x06001D1E RID: 7454 RVA: 0x0004F0B4 File Offset: 0x0004D2B4
			public bool MoveNext()
			{
				int version = this._version;
				LinkedListNode node = this._node;
				if (node != null)
				{
					LinkedListNode next = node.next;
					this._node = next;
					return;
				}
			}

			// Token: 0x06001D1F RID: 7455 RVA: 0x0004F0E4 File Offset: 0x0004D2E4
			void IEnumerator.Reset()
			{
				int version = this._version;
			}

			// Token: 0x06001D20 RID: 7456 RVA: 0x0004F0F8 File Offset: 0x0004D2F8
			public void Dispose()
			{
			}

			// Token: 0x06001D21 RID: 7457 RVA: 0x00002050 File Offset: 0x00000250
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x040013DF RID: 5087
			private LinkedList<T> _list;

			// Token: 0x040013E0 RID: 5088
			private LinkedListNode<T> _node;

			// Token: 0x040013E1 RID: 5089
			private int _version;

			// Token: 0x040013E2 RID: 5090
			private T _current;

			// Token: 0x040013E3 RID: 5091
			private int _index;
		}
	}
}
