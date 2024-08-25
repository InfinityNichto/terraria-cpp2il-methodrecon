using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x0200011F RID: 287
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4> : IEquatable<ValueTuple<T1, T2, T3, T4>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4>>, IValueTupleInternal, ITuple
	{
		// Token: 0x06000B48 RID: 2888 RVA: 0x00018FD8 File Offset: 0x000171D8
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			this.Item2 = item3;
			this.Item3 = item4;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00018FF4 File Offset: 0x000171F4
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0001900C File Offset: 0x0001720C
		public bool Equals(ValueTuple<T1, T2, T3, T4> other)
		{
			/*
An exception occurred when decompiling this method (06000B4A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ValueTuple`4::Equals(System.ValueTuple`4<T1,T2,T3,T4>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T3(var_0_06, ldfld:!T3(ValueTuple`4::Item3, ldloc:valuetype System.ValueTuple`4&(this)))
	stloc:!T2(var_1_0D, ldfld:!T2(ValueTuple`4::Item2, ldloc:valuetype System.ValueTuple`4&(this)))
	stloc:!T2(var_2_14, ldfld:!T2(ValueTuple`4::Item2, ldloc:valuetype System.ValueTuple`4<!T1, !T2, !T3, !T4>[exp:valuetype System.ValueTuple`4&](other)))
	stloc:!T3(var_4_1D, ldfld:!T3(ValueTuple`4::Item3, ldloc:valuetype System.ValueTuple`4&(this)))
	stloc:!T3(var_5_25, ldfld:!T3(ValueTuple`4::Item3, ldloc:valuetype System.ValueTuple`4<!T1, !T2, !T3, !T4>[exp:valuetype System.ValueTuple`4&](other)))
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

		// Token: 0x06000B4B RID: 2891 RVA: 0x00019040 File Offset: 0x00017240
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
				T2 item = this.Item2;
				T3 item2 = this.Item3;
			}
			long value = 0.m_value;
			throw new InvalidCastException();
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0001906C File Offset: 0x0001726C
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0001908C File Offset: 0x0001728C
		public int CompareTo(ValueTuple<T1, T2, T3, T4> other)
		{
			/*
An exception occurred when decompiling this method (06000B4D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ValueTuple`4::CompareTo(System.ValueTuple`4<T1,T2,T3,T4>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:!T3(var_2_17, ldfld:!T3(ValueTuple`4::Item3, ldloc:valuetype System.ValueTuple`4&(this)))
	stloc:!T3(var_3_1E, ldfld:!T3(ValueTuple`4::Item3, ldloc:valuetype System.ValueTuple`4<!T1, !T2, !T3, !T4>[exp:valuetype System.ValueTuple`4&](other)))
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

		// Token: 0x06000B4E RID: 2894 RVA: 0x000190B8 File Offset: 0x000172B8
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000190F0 File Offset: 0x000172F0
		public override int GetHashCode()
		{
			if (this.Item2 != null)
			{
			}
			long num = 0L;
			if (this.Item3 != null)
			{
			}
			long num2 = 0L;
			int num3;
			int num4;
			return ValueTuple.CombineHashCodes(num3, num4, (int)num, (int)num2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0001911C File Offset: 0x0001731C
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00019130 File Offset: 0x00017330
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			T2 item = this.Item2;
			T3 item2 = this.Item3;
			int num;
			return num;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0001914C File Offset: 0x0001734C
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00019160 File Offset: 0x00017360
		public override string ToString()
		{
			string text;
			string text2;
			if (("(" == null || "(" != null) && (text == null || text != null) && (", " == null || ", " != null) && (text2 == null || text2 != null) && (", " == null || ", " != null))
			{
				T2 item = this.Item2;
				if (item == null || item == null || item == null)
				{
				}
				if (", " == null || ", " != null)
				{
					T3 item2 = this.Item3;
					if (item2 == null || item2 == null || item2 == null)
					{
					}
					if (")" == null || ")" != null)
					{
						string text3;
						return text3;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000191F8 File Offset: 0x000173F8
		string IValueTupleInternal.ToStringEnd()
		{
			string text;
			string text2;
			if ((text == null || text != null) && (", " == null || ", " != null) && (text2 == null || text2 != null) && (", " == null || ", " != null))
			{
				T2 item = this.Item2;
				if (item == null || item == null || item == null)
				{
				}
				if (", " == null || ", " != null)
				{
					T3 item2 = this.Item3;
					if (item2 == null || item2 == null || item2 == null)
					{
					}
					if (")" == null || ")" != null)
					{
						string text3;
						return text3;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00019280 File Offset: 0x00017480
		int ITuple.Length
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x04000407 RID: 1031
		public T1 Item1;

		// Token: 0x04000408 RID: 1032
		public T2 Item2;

		// Token: 0x04000409 RID: 1033
		public T3 Item3;

		// Token: 0x0400040A RID: 1034
		public T4 Item4;
	}
}
