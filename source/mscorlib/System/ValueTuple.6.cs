using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000120 RID: 288
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<ValueTuple<T1, T2, T3, T4, T5>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5>>, IValueTupleInternal, ITuple
	{
		// Token: 0x06000B56 RID: 2902 RVA: 0x00019290 File Offset: 0x00017490
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000192BC File Offset: 0x000174BC
		public override bool Equals(object obj)
		{
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000192D8 File Offset: 0x000174D8
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5> other)
		{
			/*
An exception occurred when decompiling this method (06000B58)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ValueTuple`5::Equals(System.ValueTuple`5<T1,T2,T3,T4,T5>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T3(var_0_06, ldfld:!T3(ValueTuple`5::Item3, ldloc:valuetype System.ValueTuple`5&(this)))
	stloc:!T2(var_1_0D, ldfld:!T2(ValueTuple`5::Item2, ldloc:valuetype System.ValueTuple`5&(this)))
	stloc:!T2(var_2_14, ldfld:!T2(ValueTuple`5::Item2, ldloc:valuetype System.ValueTuple`5<!T1, !T2, !T3, !T4, !T5>[exp:valuetype System.ValueTuple`5&](other)))
	stloc:!T3(var_3_1B, ldfld:!T3(ValueTuple`5::Item3, ldloc:valuetype System.ValueTuple`5&(this)))
	stloc:!T3(var_4_22, ldfld:!T3(ValueTuple`5::Item3, ldloc:valuetype System.ValueTuple`5<!T1, !T2, !T3, !T4, !T5>[exp:valuetype System.ValueTuple`5&](other)))
	stloc:!T4(var_5_2A, ldfld:!T4(ValueTuple`5::Item4, ldloc:valuetype System.ValueTuple`5&(this)))
	stloc:!T4(var_6_32, ldfld:!T4(ValueTuple`5::Item4, ldloc:valuetype System.ValueTuple`5<!T1, !T2, !T3, !T4, !T5>[exp:valuetype System.ValueTuple`5&](other)))
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

		// Token: 0x06000B59 RID: 2905 RVA: 0x0001931C File Offset: 0x0001751C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
				T2 item = this.Item2;
				T3 item2 = this.Item3;
				T4 item3 = this.Item4;
			}
			long value = 0.m_value;
			throw new InvalidCastException();
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00019350 File Offset: 0x00017550
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00019370 File Offset: 0x00017570
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other)
		{
			/*
An exception occurred when decompiling this method (06000B5B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ValueTuple`5::CompareTo(System.ValueTuple`5<T1,T2,T3,T4,T5>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T2(var_0_09, ldfld:!T2(ValueTuple`5::Item2, ldloc:valuetype System.ValueTuple`5&(this)))
	stloc:!T2(var_1_10, ldfld:!T2(ValueTuple`5::Item2, ldloc:valuetype System.ValueTuple`5<!T1, !T2, !T3, !T4, !T5>[exp:valuetype System.ValueTuple`5&](other)))
	stloc:!T3(var_2_17, ldfld:!T3(ValueTuple`5::Item3, ldloc:valuetype System.ValueTuple`5&(this)))
	stloc:!T3(var_3_1E, ldfld:!T3(ValueTuple`5::Item3, ldloc:valuetype System.ValueTuple`5<!T1, !T2, !T3, !T4, !T5>[exp:valuetype System.ValueTuple`5&](other)))
	stloc:!T4(var_4_25, ldfld:!T4(ValueTuple`5::Item4, ldloc:valuetype System.ValueTuple`5&(this)))
	stloc:!T4(var_5_2D, ldfld:!T4(ValueTuple`5::Item4, ldloc:valuetype System.ValueTuple`5<!T1, !T2, !T3, !T4, !T5>[exp:valuetype System.ValueTuple`5&](other)))
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

		// Token: 0x06000B5C RID: 2908 RVA: 0x000193AC File Offset: 0x000175AC
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000193F0 File Offset: 0x000175F0
		public override int GetHashCode()
		{
			int num;
			int hashCode = num.GetHashCode();
			int num2;
			int hashCode2 = num2.GetHashCode();
			int num3;
			return ValueTuple.CombineHashCodes(num, hashCode, num2, hashCode2, num3);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00019418 File Offset: 0x00017618
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001942C File Offset: 0x0001762C
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			T2 item = this.Item2;
			T3 item2 = this.Item3;
			T4 item3 = this.Item4;
			int num;
			return num;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00019450 File Offset: 0x00017650
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00019464 File Offset: 0x00017664
		public override string ToString()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			if (("(" == null || "(" != null) && (text == null || text != null) && (", " == null || ", " != null) && (text2 == null || text2 != null) && (", " == null || ", " != null) && (text3 == null || text3 != null) && (", " == null || ", " != null) && (text4 == null || text4 != null) && (", " == null || ", " != null) && (text5 == null || text5 != null) && (text5 == null || text5 != null))
			{
				string text6;
				return text6;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000194F8 File Offset: 0x000176F8
		string IValueTupleInternal.ToStringEnd()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			if ((text == null || text != null) && (", " == null || ", " != null) && (text2 == null || text2 != null) && (", " == null || ", " != null) && (text3 == null || text3 != null) && (", " == null || ", " != null) && (text4 == null || text4 != null) && (", " == null || ", " != null) && (text5 == null || text5 != null) && (")" == null || ")" != null))
			{
				string text6;
				return text6;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00019580 File Offset: 0x00017780
		int ITuple.Length
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x0400040B RID: 1035
		public T1 Item1;

		// Token: 0x0400040C RID: 1036
		public T2 Item2;

		// Token: 0x0400040D RID: 1037
		public T3 Item3;

		// Token: 0x0400040E RID: 1038
		public T4 Item4;

		// Token: 0x0400040F RID: 1039
		public T5 Item5;
	}
}
