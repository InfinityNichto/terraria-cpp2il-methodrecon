using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x0200011E RID: 286
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple
	{
		// Token: 0x06000B3A RID: 2874 RVA: 0x00018DD0 File Offset: 0x00016FD0
		public ValueTuple(T1 item1, T2 item2, T3 item3)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00018DF4 File Offset: 0x00016FF4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00018E10 File Offset: 0x00017010
		public bool Equals(ValueTuple<T1, T2, T3> other)
		{
			/*
An exception occurred when decompiling this method (06000B3C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ValueTuple`3::Equals(System.ValueTuple`3<T1,T2,T3>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T3(var_0_06, ldfld:!T3(ValueTuple`3::Item3, ldloc:valuetype System.ValueTuple`3&(this)))
	stloc:!T2(var_1_0D, ldfld:!T2(ValueTuple`3::Item2, ldloc:valuetype System.ValueTuple`3&(this)))
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

		// Token: 0x06000B3D RID: 2877 RVA: 0x00018E2C File Offset: 0x0001702C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
				T2 item = this.Item2;
			}
			long value = 0.m_value;
			throw new InvalidCastException();
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00018E50 File Offset: 0x00017050
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00018E6C File Offset: 0x0001706C
		public int CompareTo(ValueTuple<T1, T2, T3> other)
		{
			/*
An exception occurred when decompiling this method (06000B3F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ValueTuple`3::CompareTo(System.ValueTuple`3<T1,T2,T3>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T2(var_0_09, ldfld:!T2(ValueTuple`3::Item2, ldloc:valuetype System.ValueTuple`3&(this)))
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

		// Token: 0x06000B40 RID: 2880 RVA: 0x00018E84 File Offset: 0x00017084
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00018EB4 File Offset: 0x000170B4
		public override int GetHashCode()
		{
			int num;
			int num2;
			return ValueTuple.CombineHashCodes(0, num, num2);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00018ECC File Offset: 0x000170CC
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00018EE0 File Offset: 0x000170E0
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			T2 item = this.Item2;
			int num;
			return num;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00018EF8 File Offset: 0x000170F8
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00018F0C File Offset: 0x0001710C
		public override string ToString()
		{
			string text;
			string text2;
			if (("(" == null || "(" != null) && (", " == null || ", " != null) && (text == null || text != null) && (", " == null || ", " != null) && (text2 == null || text2 != null) && (")" == null || ")" != null))
			{
				string text3;
				return text3;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00018F6C File Offset: 0x0001716C
		string IValueTupleInternal.ToStringEnd()
		{
			int num = 1;
			if (num == 0 || (num != 0 && num == 0))
			{
			}
			string text;
			string text2;
			if ((", " == null || ", " != null) && (text == null || text != null) && (", " == null || ", " != null) && (text2 == null || text2 != null) && (")" == null || ")" != null))
			{
				string text3;
				return text3;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00018FC8 File Offset: 0x000171C8
		int ITuple.Length
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x04000404 RID: 1028
		public T1 Item1;

		// Token: 0x04000405 RID: 1029
		public T2 Item2;

		// Token: 0x04000406 RID: 1030
		public T3 Item3;
	}
}
