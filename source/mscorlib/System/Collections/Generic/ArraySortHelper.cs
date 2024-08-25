using System;
using Cpp2IlInjected;

namespace System.Collections.Generic
{
	// Token: 0x0200064F RID: 1615
	internal class ArraySortHelper<T>
	{
		// Token: 0x06003151 RID: 12625 RVA: 0x0006B254 File Offset: 0x00069454
		public void Sort(T[] keys, int index, int length, IComparer<T> comparer)
		{
			if (comparer == null)
			{
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0006B280 File Offset: 0x00069480
		public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			throw new OutOfMemoryException();
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0006B294 File Offset: 0x00069494
		internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer)
		{
			if (keys == null)
			{
			}
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x0006B2B4 File Offset: 0x000694B4
		internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer)
		{
			/*
An exception occurred when decompiling this method (06003154)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Collections.Generic.ArraySortHelper`1::InternalBinarySearch(T[],System.Int32,System.Int32,T,System.Collections.Generic.IComparer`1<T>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:class System.Collections.Generic.IComparer`1<!T>[exp:bool](comparer)))
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

		// Token: 0x06003155 RID: 12629 RVA: 0x0006B2C4 File Offset: 0x000694C4
		private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b)
		{
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x0006B2D4 File Offset: 0x000694D4
		private static void Swap(T[] a, int i, int j)
		{
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x0006B2E4 File Offset: 0x000694E4
		internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer)
		{
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x0006B2FC File Offset: 0x000694FC
		private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer)
		{
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x0006B328 File Offset: 0x00069528
		private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer)
		{
			return hi;
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x0006B344 File Offset: 0x00069544
		private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer)
		{
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x0006B358 File Offset: 0x00069558
		private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer)
		{
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x0006B368 File Offset: 0x00069568
		private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer)
		{
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600315D RID: 12637 RVA: 0x0000207A File Offset: 0x0000027A
		public static ArraySortHelper<T> Default
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0006B378 File Offset: 0x00069578
		public ArraySortHelper()
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0006B38C File Offset: 0x0006958C
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySortHelper()
		{
		}

		// Token: 0x04001AA5 RID: 6821
		private static readonly ArraySortHelper<T> s_defaultArraySortHelper;
	}
}
