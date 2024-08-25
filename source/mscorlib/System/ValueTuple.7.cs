using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000121 RID: 289
	[Serializable]
	[StructLayout(3)]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple where TRest : struct
	{
		// Token: 0x06000B64 RID: 2916 RVA: 0x00019590 File Offset: 0x00017790
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000195CC File Offset: 0x000177CC
		public override bool Equals(object obj)
		{
			T2 item = this.Item2;
			if (obj != null)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000195EC File Offset: 0x000177EC
		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			/*
An exception occurred when decompiling this method (06000B66)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.ValueTuple`8::Equals(System.ValueTuple`8<T1,T2,T3,T4,T5,T6,T7,TRest>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T4(var_0_06, ldfld:!T4(ValueTuple`8::Item4, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T2(var_1_0D, ldfld:!T2(ValueTuple`8::Item2, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T2(var_2_14, ldfld:!T2(ValueTuple`8::Item2, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T3(var_3_1B, ldfld:!T3(ValueTuple`8::Item3, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T3(var_4_22, ldfld:!T3(ValueTuple`8::Item3, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T4(var_5_2A, ldfld:!T4(ValueTuple`8::Item4, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T4(var_6_32, ldfld:!T4(ValueTuple`8::Item4, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T5(var_7_3A, ldfld:!T5(ValueTuple`8::Item5, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T5(var_8_42, ldfld:!T5(ValueTuple`8::Item5, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T6(var_9_4A, ldfld:!T6(ValueTuple`8::Item6, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T6(var_10_52, ldfld:!T6(ValueTuple`8::Item6, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
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

		// Token: 0x06000B67 RID: 2919 RVA: 0x00019650 File Offset: 0x00017850
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other != null)
			{
				T2 item = this.Item2;
				T3 item2 = this.Item3;
				T4 item3 = this.Item4;
				T5 item4 = this.Item5;
				T6 item5 = this.Item6;
			}
			long value = 0.m_value;
			throw new InvalidCastException();
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00019694 File Offset: 0x00017894
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				int num;
				return num;
			}
			return 1;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x000196B4 File Offset: 0x000178B4
		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			/*
An exception occurred when decompiling this method (06000B69)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ValueTuple`8::CompareTo(System.ValueTuple`8<T1,T2,T3,T4,T5,T6,T7,TRest>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T2(var_0_09, ldfld:!T2(ValueTuple`8::Item2, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T2(var_1_10, ldfld:!T2(ValueTuple`8::Item2, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T3(var_2_17, ldfld:!T3(ValueTuple`8::Item3, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T3(var_3_1E, ldfld:!T3(ValueTuple`8::Item3, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T4(var_4_25, ldfld:!T4(ValueTuple`8::Item4, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T4(var_5_2D, ldfld:!T4(ValueTuple`8::Item4, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T5(var_6_35, ldfld:!T5(ValueTuple`8::Item5, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T5(var_7_3D, ldfld:!T5(ValueTuple`8::Item5, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
	stloc:!T6(var_8_45, ldfld:!T6(ValueTuple`8::Item6, ldloc:valuetype System.ValueTuple`8&(this)))
	stloc:!T6(var_9_4D, ldfld:!T6(ValueTuple`8::Item6, ldloc:valuetype System.ValueTuple`8<!T1, !T2, !T3, !T4, !T5, !T6, !T7, !TRest>[exp:valuetype System.ValueTuple`8&](other)))
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

		// Token: 0x06000B6A RID: 2922 RVA: 0x00019710 File Offset: 0x00017910
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0001976C File Offset: 0x0001796C
		public override int GetHashCode()
		{
			int num;
			int hashCode = num.GetHashCode();
			int num2;
			int hashCode2 = num2.GetHashCode();
			int num3;
			int hashCode3 = num3.GetHashCode();
			int num4;
			return ValueTuple.CombineHashCodes(num, hashCode, num2, hashCode2, num3, hashCode3, num4);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00019868 File Offset: 0x00017A68
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001987C File Offset: 0x00017A7C
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			T2 item = this.Item2;
			T3 item2 = this.Item3;
			T4 item3 = this.Item4;
			T5 item4 = this.Item5;
			T6 item5 = this.Item6;
			int num;
			return num;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00019904 File Offset: 0x00017B04
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00019918 File Offset: 0x00017B18
		public override string ToString()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			string text6;
			string text7;
			string text8;
			string text9;
			string text10;
			string text11;
			string text12;
			string text13;
			string text14;
			string text15;
			if (("(" == null || "(" != null) && (text == null || text != null) && (", " == null || ", " != null) && (text2 == null || text2 != null) && (", " == null || ", " != null) && (text3 == null || text3 != null) && (", " == null || ", " != null) && (text4 == null || text4 != null) && (", " == null || ", " != null) && (text5 == null || text5 != null) && (", " == null || ", " != null) && (text6 == null || text6 != null) && (", " == null || ", " != null) && (text7 == null || text7 != null) && (", " == null || ", " != null) && (text8 == null || text8 != null) && (", " == null || ", " != null) && text9 != null && (", " == null || ", " != null) && (text10 == null || text10 != null) && (", " == null || ", " != null) && (text11 == null || text11 != null) && (", " == null || ", " != null) && (text12 == null || text12 != null) && (", " == null || ", " != null) && (text13 == null || text13 != null) && (", " == null || ", " != null) && (text14 == null || text14 != null) && (", " == null || ", " != null) && (text15 == null || text15 != null) && (")" == null || ")" != null))
			{
				return ")";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00019AD8 File Offset: 0x00017CD8
		string IValueTupleInternal.ToStringEnd()
		{
			string text;
			string text2;
			string text3;
			string text4;
			string text5;
			string text6;
			string text7;
			string text8;
			string text9;
			string text10;
			string text11;
			string text12;
			string text13;
			string text14;
			string text15;
			if ((text == null || text != null) && (text2 == null || text2 != null) && (text3 == null || text3 != null) && (text4 == null || text4 != null) && (text5 == null || text5 != null) && (text6 == null || text6 != null) && (text7 == null || text7 != null) && (text8 == null || text8 != null) && (text9 == null || text9 != null) && (text10 == null || text10 != null) && (text11 == null || text11 != null) && (text12 == null || text12 != null) && (text13 == null || text13 != null) && (text14 == null || text14 != null) && (text15 == null || text15 != null) && (")" == null || ")" != null))
			{
				return ")";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00019B9C File Offset: 0x00017D9C
		int ITuple.Length
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x04000410 RID: 1040
		public T1 Item1;

		// Token: 0x04000411 RID: 1041
		public T2 Item2;

		// Token: 0x04000412 RID: 1042
		public T3 Item3;

		// Token: 0x04000413 RID: 1043
		public T4 Item4;

		// Token: 0x04000414 RID: 1044
		public T5 Item5;

		// Token: 0x04000415 RID: 1045
		public T6 Item6;

		// Token: 0x04000416 RID: 1046
		public T7 Item7;

		// Token: 0x04000417 RID: 1047
		public TRest Rest;
	}
}
