using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x0200010D RID: 269
	[Serializable]
	public class Tuple<T1, T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00017694 File Offset: 0x00015894
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x000176A8 File Offset: 0x000158A8
		public T2 Item2
		{
			get
			{
				/*
An exception occurred when decompiling this method (060009E7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling T2 System.Tuple`2::get_Item2()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T2(var_0_06, ldfld:!T2(Tuple`2::m_Item2, ldloc:Tuple`2(this)))
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
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000176BC File Offset: 0x000158BC
		public Tuple(T1 item1, T2 item2)
		{
			this.m_Item1 = item1;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0000207A File Offset: 0x0000027A
		public override bool Equals(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000176D8 File Offset: 0x000158D8
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			/*
An exception occurred when decompiling this method (060009EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Tuple`2::System.Collections.IStructuralEquatable.Equals(System.Object,System.Collections.IEqualityComparer)

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

		// Token: 0x060009EB RID: 2539 RVA: 0x0000207A File Offset: 0x0000027A
		int IComparable.CompareTo(object obj)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000176FC File Offset: 0x000158FC
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
				T1 item = this.m_Item1;
			}
			return 1;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0000207A File Offset: 0x0000027A
		public override int GetHashCode()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00017730 File Offset: 0x00015930
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			T1 item = this.m_Item1;
			T2 item2 = this.m_Item2;
			int num;
			return num;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0001774C File Offset: 0x0001594C
		public override string ToString()
		{
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0001775C File Offset: 0x0001595C
		string ITupleInternal.ToString(StringBuilder sb)
		{
			/*
An exception occurred when decompiling this method (060009F0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Tuple`2::System.ITupleInternal.ToString(System.Text.StringBuilder)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:!T1(var_0_06, ldfld:!T1(Tuple`2::m_Item1, ldloc:Tuple`2(this)))
	stloc:StringBuilder(var_1_12, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string[exp:object](", ")))
	stloc:StringBuilder(var_2_1E, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldstr:string(", ")))
	stloc:!T2(var_3_25, ldfld:!T2(Tuple`2::m_Item2, ldloc:Tuple`2(this)))
	stloc:StringBuilder(var_4_2D, call:StringBuilder(StringBuilder::Append, ldloc:StringBuilder(sb), ldloc:StringBuilder[exp:object](var_2_1E)))
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00017798 File Offset: 0x00015998
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x040003CF RID: 975
		private readonly T1 m_Item1;

		// Token: 0x040003D0 RID: 976
		private readonly T2 m_Item2;
	}
}
