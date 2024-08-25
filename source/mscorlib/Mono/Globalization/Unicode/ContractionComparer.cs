using System;
using System.Collections.Generic;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000034 RID: 52
	internal class ContractionComparer : IComparer<Contraction>
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00003094 File Offset: 0x00001294
		public int Compare(Contraction c1, Contraction c2)
		{
			/*
An exception occurred when decompiling this method (060000AA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Globalization.Unicode.ContractionComparer::Compare(Mono.Globalization.Unicode.Contraction,Mono.Globalization.Unicode.Contraction)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:char[](var_0_06, ldfld:char[](Contraction::Source, ldloc:Contraction(c1)))
	stloc:char[](var_1_0D, ldfld:char[](Contraction::Source, ldloc:Contraction(c2)))
	stloc:int32(var_3_16, ldfld:int32(Contraction::Index, ldloc:Contraction(c1)))
	stloc:int32(var_4_1D, ldfld:int32(Contraction::Index, ldloc:Contraction(c2)))
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

		// Token: 0x060000AB RID: 171 RVA: 0x000030C0 File Offset: 0x000012C0
		public ContractionComparer()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000030D4 File Offset: 0x000012D4
		// Note: this type is marked as 'beforefieldinit'.
		static ContractionComparer()
		{
		}

		// Token: 0x040000E1 RID: 225
		public static readonly ContractionComparer Instance;
	}
}
