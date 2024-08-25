using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200010E RID: 270
	[Serializable]
	public class Tuple<T1, T2, T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000177A8 File Offset: 0x000159A8
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0000207A File Offset: 0x0000027A
		public T2 Item2
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000177BC File Offset: 0x000159BC
		public T3 Item3
		{
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000177D0 File Offset: 0x000159D0
		public Tuple(T1 item1, T2 item2, T3 item3)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item2 = item3;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000177F8 File Offset: 0x000159F8
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			/*
An exception occurred when decompiling this method (060009F7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Tuple`3::System.Collections.IStructuralEquatable.Equals(System.Object,System.Collections.IEqualityComparer)

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

		// Token: 0x060009F8 RID: 2552 RVA: 0x0000207A File Offset: 0x0000027A
		int IComparable.CompareTo(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0001781C File Offset: 0x00015A1C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
			}
			return 1;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0001783C File Offset: 0x00015A3C
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			T1 item = this.m_Item1;
			T2 item2 = this.m_Item2;
			int num;
			return num;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00017858 File Offset: 0x00015A58
		public override string ToString()
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00017868 File Offset: 0x00015A68
		string ITupleInternal.ToString(StringBuilder sb)
		{
			/*
An exception occurred when decompiling this method (060009FD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Tuple`3::System.ITupleInternal.ToString(System.Text.StringBuilder)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T1(var_0_06, ldfld:!T1(Tuple`3::m_Item1, ldloc:Tuple`3(this)))
	stloc:StringBuilder(var_1_12, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string[exp:object](", ")))
	stloc:StringBuilder(var_2_1E, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string(", ")))
	stloc:StringBuilder(var_3_26, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldloc:StringBuilder[exp:object](var_2_1E)))
	stloc:StringBuilder(var_4_32, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string(", ")))
	stloc:!T2(var_5_3A, ldfld:!T2(Tuple`3::m_Item2, ldloc:Tuple`3(this)))
	stloc:StringBuilder(var_6_44, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldloc:StringBuilder[exp:object](var_4_32)))
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000178BC File Offset: 0x00015ABC
		int ITuple.Length
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x040003D1 RID: 977
		private readonly T1 m_Item1;

		// Token: 0x040003D2 RID: 978
		private readonly T2 m_Item2;

		// Token: 0x040003D3 RID: 979
		private readonly T3 m_Item3;
	}
}
