using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200010F RID: 271
	[Serializable]
	public class Tuple<T1, T2, T3, T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x060009FF RID: 2559 RVA: 0x000178CC File Offset: 0x00015ACC
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item2 = item3;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x000178F4 File Offset: 0x00015AF4
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			/*
An exception occurred when decompiling this method (06000A01)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Tuple`4::System.Collections.IStructuralEquatable.Equals(System.Object,System.Collections.IEqualityComparer)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0011:
	stloc:int64(var_2_17, ldfld:int64(int64::m_value, ldc.i4:int32[exp:int64&](0)))
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

		// Token: 0x06000A02 RID: 2562 RVA: 0x0000207A File Offset: 0x0000027A
		int IComparable.CompareTo(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00017918 File Offset: 0x00015B18
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
				T1 item = this.m_Item1;
			}
			return 1;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00017954 File Offset: 0x00015B54
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return int.MinValue;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0001797C File Offset: 0x00015B7C
		public override string ToString()
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001798C File Offset: 0x00015B8C
		string ITupleInternal.ToString(StringBuilder sb)
		{
			/*
An exception occurred when decompiling this method (06000A07)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Tuple`4::System.ITupleInternal.ToString(System.Text.StringBuilder)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T1(var_0_06, ldfld:!T1(Tuple`4::m_Item1, ldloc:Tuple`4(this)))
	stloc:StringBuilder(var_1_12, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string[exp:object](", ")))
	stloc:StringBuilder(var_2_1E, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string(", ")))
	stloc:StringBuilder(var_3_26, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldloc:StringBuilder[exp:object](var_2_1E)))
	stloc:StringBuilder(var_4_32, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string(", ")))
	stloc:!T2(var_5_3A, ldfld:!T2(Tuple`4::m_Item2, ldloc:Tuple`4(this)))
	stloc:StringBuilder(var_6_44, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldloc:StringBuilder[exp:object](var_4_32)))
	stloc:StringBuilder(var_7_51, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string(", ")))
	stloc:StringBuilder(var_8_5B, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldloc:StringBuilder[exp:object](var_7_51)))
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x000179F8 File Offset: 0x00015BF8
		int ITuple.Length
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x040003D4 RID: 980
		private readonly T1 m_Item1;

		// Token: 0x040003D5 RID: 981
		private readonly T2 m_Item2;

		// Token: 0x040003D6 RID: 982
		private readonly T3 m_Item3;

		// Token: 0x040003D7 RID: 983
		private readonly T4 m_Item4;
	}
}
