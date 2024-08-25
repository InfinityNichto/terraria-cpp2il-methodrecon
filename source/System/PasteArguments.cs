using System;
using System.Text;

namespace System
{
	// Token: 0x0200007D RID: 125
	internal static class PasteArguments
	{
		// Token: 0x060001DF RID: 479 RVA: 0x000063F4 File Offset: 0x000045F4
		internal static void AppendArgument(StringBuilder stringBuilder, string argument)
		{
			if (stringBuilder.Length != 0)
			{
				int num = 32;
				StringBuilder stringBuilder2 = stringBuilder.Append((char)num);
			}
			if (argument._stringLength != 0)
			{
				bool flag = global::System.PasteArguments.ContainsNoWhitespaceOrQuotes(argument);
				StringBuilder stringBuilder3 = stringBuilder.Append(argument);
				return;
			}
			int num2 = 34;
			StringBuilder stringBuilder4 = stringBuilder.Append((char)num2);
			int stringLength = argument._stringLength;
			long num3 = 0L;
			char c = argument[(int)num3];
			int stringLength2 = argument._stringLength;
			char c2 = argument[(int)num3];
			int stringLength3 = argument._stringLength;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000064F0 File Offset: 0x000046F0
		private static bool ContainsNoWhitespaceOrQuotes(string s)
		{
			/*
An exception occurred when decompiling this method (060001E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.PasteArguments::ContainsNoWhitespaceOrQuotes(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_3_0A, call:bool(char::IsWhiteSpace, ldloc:char(var_2)))
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
}
