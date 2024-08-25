using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x0200011D RID: 285
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple
	{
		// Token: 0x06000B2C RID: 2860 RVA: 0x00018C3C File Offset: 0x00016E3C
		public ValueTuple(T1 item1, T2 item2)
		{
			this.Item2 = item2;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00018C50 File Offset: 0x00016E50
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00018C6C File Offset: 0x00016E6C
		public bool Equals(ValueTuple<T1, T2> other)
		{
			/*
An exception occurred when decompiling this method (06000B2E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ValueTuple`2::Equals(System.ValueTuple`2<T1,T2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T2(var_1_08, ldfld:!T2(ValueTuple`2::Item2, ldloc:valuetype System.ValueTuple`2&(this)))
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

		// Token: 0x06000B2F RID: 2863 RVA: 0x00018C84 File Offset: 0x00016E84
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
				T2 item = this.Item2;
			}
			long value = 0.m_value;
			throw new InvalidCastException();
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00018CA8 File Offset: 0x00016EA8
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00018CC4 File Offset: 0x00016EC4
		public int CompareTo(ValueTuple<T1, T2> other)
		{
			/*
An exception occurred when decompiling this method (06000B31)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ValueTuple`2::CompareTo(System.ValueTuple`2<T1,T2>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:!T2(var_0_09, ldfld:!T2(ValueTuple`2::Item2, ldloc:valuetype System.ValueTuple`2&(this)))
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

		// Token: 0x06000B32 RID: 2866 RVA: 0x00018CDC File Offset: 0x00016EDC
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00018D00 File Offset: 0x00016F00
		public override int GetHashCode()
		{
			if (this.Item2 != null)
			{
			}
			long num = 0L;
			int num2;
			return ValueTuple.CombineHashCodes(num2, (int)num);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00018D20 File Offset: 0x00016F20
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00018D34 File Offset: 0x00016F34
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			T2 item = this.Item2;
			int num;
			return num;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00018D4C File Offset: 0x00016F4C
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00018D60 File Offset: 0x00016F60
		public override string ToString()
		{
			if ("(" != null)
			{
			}
			string text;
			if ((text == null || text != null) && (", " == null || ", " != null))
			{
				T2 item = this.Item2;
				if (item == null || item == null || item == null)
				{
				}
				if (item == null || item != null)
				{
					string text2;
					return text2;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00018DA8 File Offset: 0x00016FA8
		string IValueTupleInternal.ToStringEnd()
		{
			if (this.Item2 != null)
			{
			}
			string text;
			return text;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00018DC0 File Offset: 0x00016FC0
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x04000402 RID: 1026
		public T1 Item1;

		// Token: 0x04000403 RID: 1027
		public T2 Item2;
	}
}
