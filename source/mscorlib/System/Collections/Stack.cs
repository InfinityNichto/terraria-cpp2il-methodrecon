using System;
using System.Diagnostics;

namespace System.Collections
{
	// Token: 0x02000600 RID: 1536
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(Stack.StackDebugView))]
	[Serializable]
	public class Stack : ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06002E94 RID: 11924 RVA: 0x000668E0 File Offset: 0x00064AE0
		public Stack()
		{
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000668F4 File Offset: 0x00064AF4
		public Stack(int initialCapacity)
		{
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x0006690C File Offset: 0x00064B0C
		public virtual int Count
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x00066920 File Offset: 0x00064B20
		public virtual bool IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x00066930 File Offset: 0x00064B30
		public virtual object SyncRoot
		{
			get
			{
				/*
An exception occurred when decompiling this method (06002E98)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Stack::get_SyncRoot()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:object[exp:bool](Stack::_syncRoot, ldloc:Stack(this)))
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

		// Token: 0x06002E99 RID: 11929 RVA: 0x00066944 File Offset: 0x00064B44
		public virtual void Clear()
		{
			object[] array = this._array;
			int size = this._size;
			long num = 0L;
			Array.Clear(array, (int)num, size);
			int version = this._version;
			this._syncRoot = version;
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00066978 File Offset: 0x00064B78
		public virtual object Clone()
		{
			int size = this._size;
			int size2 = this._size;
			object[] array = this._array;
			int size3 = this._size;
			int version = this._version;
			return array;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000669AC File Offset: 0x00064BAC
		public virtual void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				return;
			}
			int rank = array.Rank;
			int length = array.Length;
			int size = this._size;
			int size2 = this._size;
			if (array != null)
			{
				object[] array2 = this._array;
				if (array != null)
				{
					if (array == null)
					{
						throw new ArrayTypeMismatchException();
					}
					int size3 = this._size;
				}
				return;
			}
			object[] array3 = this._array;
			int size4 = this._size;
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00066A14 File Offset: 0x00064C14
		public virtual IEnumerator GetEnumerator()
		{
			/*
An exception occurred when decompiling this method (06002E9C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.IEnumerator System.Collections.Stack::GetEnumerator()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(Stack::_version, ldloc:Stack(this)))
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

		// Token: 0x06002E9D RID: 11933 RVA: 0x00066A28 File Offset: 0x00064C28
		public virtual object Peek()
		{
			/*
An exception occurred when decompiling this method (06002E9D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Stack::Peek()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:object[](var_0_0E, ldfld:object[](Stack::_array, ldloc:Stack(this)))
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

		// Token: 0x06002E9E RID: 11934 RVA: 0x00066A44 File Offset: 0x00064C44
		public virtual object Pop()
		{
			/*
An exception occurred when decompiling this method (06002E9E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Object System.Collections.Stack::Pop()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_10, ldfld:int32(Stack::_version, ldloc:Stack(this)))
	stloc:object[](var_2_17, ldfld:object[](Stack::_array, ldloc:Stack(this)))
	stfld:int32(Stack::_size, ldloc:Stack(this), ldloc:int32(var_0_06))
	stfld:object(Stack::_syncRoot, ldloc:Stack(this), ldloc:int32[exp:object](var_1_10))
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

		// Token: 0x06002E9F RID: 11935 RVA: 0x00066A78 File Offset: 0x00064C78
		public virtual void Push(object obj)
		{
			object[] array = this._array;
			int size = this._size;
			object[] array2 = this._array;
			int size2 = this._size;
			int size3 = this._size;
			this._size = array2;
			if (obj == null || obj != null)
			{
				int version = this._version;
				this._version = version;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x040019DB RID: 6619
		private object[] _array;

		// Token: 0x040019DC RID: 6620
		private int _size;

		// Token: 0x040019DD RID: 6621
		private int _version;

		// Token: 0x040019DE RID: 6622
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x02000601 RID: 1537
		[Serializable]
		private class StackEnumerator : IEnumerator, ICloneable
		{
			// Token: 0x06002EA0 RID: 11936 RVA: 0x00066AD0 File Offset: 0x00064CD0
			internal StackEnumerator(Stack stack)
			{
				this._stack = stack;
				int version = stack._version;
				this._currentElement = version;
			}

			// Token: 0x06002EA1 RID: 11937 RVA: 0x00066AF8 File Offset: 0x00064CF8
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x06002EA2 RID: 11938 RVA: 0x00066B0C File Offset: 0x00064D0C
			public virtual bool MoveNext()
			{
				/*
An exception occurred when decompiling this method (06002EA2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Collections.Stack/StackEnumerator::MoveNext()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stack(var_0_06, ldfld:Stack(StackEnumerator::_stack, ldloc:StackEnumerator(this)))
	stloc:int32(var_1_0D, ldfld:int32(StackEnumerator::_version, ldloc:StackEnumerator(this)))
	stloc:int32(var_2_14, ldfld:int32(Stack::_version, ldloc:Stack(var_0_06)))
	stloc:int32(var_3_1B, ldfld:int32(StackEnumerator::_index, ldloc:StackEnumerator(this)))
	stloc:int32(var_4_22, ldfld:int32(Stack::_size, ldloc:Stack(var_0_06)))
	stfld:int32(StackEnumerator::_index, ldloc:StackEnumerator(this), ldloc:int32(var_4_22))
	stloc:int64(var_5_2D, ldc.i4:int64(0))
	stfld:int32(StackEnumerator::_index, ldloc:StackEnumerator(this), ldloc:int32(var_4_22))
	stfld:object(StackEnumerator::_currentElement, ldloc:StackEnumerator(this), ldloc:int64[exp:object](var_5_2D))
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

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x00066B5C File Offset: 0x00064D5C
			public virtual object Current
			{
				get
				{
					int index = this._index;
					return this._currentElement;
				}
			}

			// Token: 0x06002EA4 RID: 11940 RVA: 0x00066B7C File Offset: 0x00064D7C
			public virtual void Reset()
			{
				Stack stack = this._stack;
				int version = this._version;
				int version2 = stack._version;
				this._index = version2;
			}

			// Token: 0x040019DF RID: 6623
			private Stack _stack;

			// Token: 0x040019E0 RID: 6624
			private int _index;

			// Token: 0x040019E1 RID: 6625
			private int _version;

			// Token: 0x040019E2 RID: 6626
			private object _currentElement;
		}

		// Token: 0x02000602 RID: 1538
		internal class StackDebugView
		{
		}
	}
}
