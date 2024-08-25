using System;
using System.Diagnostics;

namespace System.Collections
{
	// Token: 0x020005F6 RID: 1526
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
	[Serializable]
	public class Queue : ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06002E17 RID: 11799 RVA: 0x000656D8 File Offset: 0x000638D8
		public Queue()
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x000656E8 File Offset: 0x000638E8
		public Queue(int capacity)
		{
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000656F8 File Offset: 0x000638F8
		public Queue(int capacity, float growFactor)
		{
			this._version = 17096;
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00065718 File Offset: 0x00063918
		public Queue(ICollection col)
		{
			if (col != null)
			{
				return;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x00065730 File Offset: 0x00063930
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00065744 File Offset: 0x00063944
		public virtual object Clone()
		{
			/*
An exception occurred when decompiling this method (06002E1C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Queue::Clone()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Queue::_size, ldloc:Queue(this)))
	stloc:int32(var_1_0D, ldfld:int32(Queue::_size, ldloc:Queue(this)))
	stloc:object[](var_2_14, ldfld:object[](Queue::_array, ldloc:Queue(this)))
	stloc:int32(var_3_1B, ldfld:int32(Queue::_head, ldloc:Queue(this)))
	stloc:int32(var_4_22, ldfld:int32(Queue::_size, ldloc:Queue(this)))
	stloc:object[](var_5_2A, ldfld:object[](Queue::_array, ldloc:Queue(this)))
	stloc:int32(var_6_32, ldfld:int32(Queue::_head, ldloc:Queue(this)))
	stloc:int32(var_7_3A, ldfld:int32(Queue::_version, ldloc:Queue(this)))
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

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x0006578C File Offset: 0x0006398C
		public virtual bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x0006579C File Offset: 0x0006399C
		public virtual object SyncRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002E1E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Queue::get_SyncRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:object[exp:bool](Queue::_syncRoot, ldloc:Queue(this)))
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

		// Token: 0x06002E1F RID: 11807 RVA: 0x000657B0 File Offset: 0x000639B0
		public virtual void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				return;
			}
			int rank = array.Rank;
			int length = array.Length;
			if (this._size != 0)
			{
				object[] array2 = this._array;
				int head = this._head;
				object[] array3 = this._array;
				int head2 = this._head;
				return;
			}
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000657F8 File Offset: 0x000639F8
		public virtual void Enqueue(object obj)
		{
			object[] array = this._array;
			int size = this._size;
			object[] array2 = this._array;
			int tail = this._tail;
			if (obj == null)
			{
				object[] array3 = this._array;
				int size2 = this._size;
				int version = this._version;
				this._size = size2;
				this._tail = tail;
				this._version = version;
				return;
			}
			if (obj != null)
			{
				int tail2 = this._tail;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00065868 File Offset: 0x00063A68
		public virtual IEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06002E21)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Collections.Queue::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	stloc:int32(var_0_06, ldfld:int32(Queue::_version, ldloc:Queue(this)))
	stloc:object[](var_1_0D, ldfld:object[](Queue::_array, ldloc:Queue(this)))
	brtrue(IL_0000, ldfld:int32[exp:bool](Queue::_size, ldloc:Queue(this)))
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

		// Token: 0x06002E22 RID: 11810 RVA: 0x0006588C File Offset: 0x00063A8C
		public virtual object Dequeue()
		{
			/*
An exception occurred when decompiling this method (06002E22)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Queue::Dequeue()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_09, ldfld:object[](Queue::_array, ldloc:Queue(this)))
	stloc:object[](var_1_10, ldfld:object[](Queue::_array, ldloc:Queue(this)))
	stloc:int32(var_2_17, ldfld:int32(Queue::_size, ldloc:Queue(this)))
	stloc:int32(var_3_1E, ldfld:int32(Queue::_version, ldloc:Queue(this)))
	stfld:int32(Queue::_head, ldloc:Queue(this), ldloc:object[][exp:int32](var_1_10))
	stfld:int32(Queue::_version, ldloc:Queue(this), ldloc:int32(var_2_17))
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

		// Token: 0x06002E23 RID: 11811 RVA: 0x000658C8 File Offset: 0x00063AC8
		public virtual object Peek()
		{
			/*
An exception occurred when decompiling this method (06002E23)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Queue::Peek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_09, ldfld:object[](Queue::_array, ldloc:Queue(this)))
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

		// Token: 0x06002E24 RID: 11812 RVA: 0x000658E0 File Offset: 0x00063AE0
		internal object GetElement(int i)
		{
			/*
An exception occurred when decompiling this method (06002E24)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Queue::GetElement(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_06, ldfld:object[](Queue::_array, ldloc:Queue(this)))
	stloc:int32(var_1_0D, ldfld:int32(Queue::_head, ldloc:Queue(this)))
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

		// Token: 0x06002E25 RID: 11813 RVA: 0x000658FC File Offset: 0x00063AFC
		private void SetCapacity(int capacity)
		{
			int size = this._size;
			int head = this._head;
			int size2 = this._size;
			object[] array = this._array;
		}

		// Token: 0x040019BA RID: 6586
		private object[] _array;

		// Token: 0x040019BB RID: 6587
		private int _head;

		// Token: 0x040019BC RID: 6588
		private int _tail;

		// Token: 0x040019BD RID: 6589
		private int _size;

		// Token: 0x040019BE RID: 6590
		private int _growFactor;

		// Token: 0x040019BF RID: 6591
		private int _version;

		// Token: 0x040019C0 RID: 6592
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x020005F7 RID: 1527
		[Serializable]
		private class QueueEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06002E26 RID: 11814 RVA: 0x00065968 File Offset: 0x00063B68
			internal QueueEnumerator(Queue q)
			{
				this._q = q;
				int version = q._version;
				this._currentElement = version;
				object[] array = q._array;
				this._currentElement = array;
				int size = q._size;
				if (size == 0)
				{
					this._index = size;
				}
			}

			// Token: 0x06002E27 RID: 11815 RVA: 0x000659B0 File Offset: 0x00063BB0
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06002E28 RID: 11816 RVA: 0x000659C4 File Offset: 0x00063BC4
			public virtual bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06002E28)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Queue/QueueEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Queue(var_0_06, ldfld:Queue(QueueEnumerator::_q, ldloc:QueueEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(QueueEnumerator::_version, ldloc:QueueEnumerator(this)))
	stloc:int32(var_2_14, ldfld:int32(Queue::_version, ldloc:Queue(var_0_06)))
	stloc:int32(var_3_1B, ldfld:int32(QueueEnumerator::_index, ldloc:QueueEnumerator(this)))
	stloc:object[](var_4_22, ldfld:object[](Queue::_array, ldloc:Queue(var_0_06)))
	stloc:int32(var_5_2A, ldfld:int32(Queue::_head, ldloc:Queue(var_0_06)))
	stfld:int32(QueueEnumerator::_index, ldloc:QueueEnumerator(this), ldloc:int32(var_5_2A))
	stfld:object(QueueEnumerator::_currentElement, ldloc:QueueEnumerator(this), ldloc:object[][exp:object](var_4_22))
	stloc:int32(var_7_45, ldfld:int32(Queue::_size, ldloc:Queue(var_0_06)))
	stfld:int32(QueueEnumerator::_index, ldloc:QueueEnumerator(this), ldloc:int32(var_7_45))
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

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06002E29 RID: 11817 RVA: 0x00065A24 File Offset: 0x00063C24
			public virtual object Current
			{
				get
				{
					return this._currentElement;
				}
			}

			// Token: 0x06002E2A RID: 11818 RVA: 0x00065A40 File Offset: 0x00063C40
			public virtual void Reset()
			{
				Queue q = this._q;
				int version = this._version;
				int version2 = q._version;
				int size = q._size;
				this._index = size;
				object[] array = q._array;
				this._currentElement = array;
			}

			// Token: 0x040019C1 RID: 6593
			private Queue _q;

			// Token: 0x040019C2 RID: 6594
			private int _index;

			// Token: 0x040019C3 RID: 6595
			private int _version;

			// Token: 0x040019C4 RID: 6596
			private object _currentElement;
		}

		// Token: 0x020005F8 RID: 1528
		internal class QueueDebugView
		{
		}
	}
}
