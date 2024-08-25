using System;

namespace System.Net
{
	// Token: 0x02000127 RID: 295
	internal static class HttpValidationHelpers
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x0001942C File Offset: 0x0001762C
		internal static string CheckBadHeaderNameChars(string name)
		{
			/*
An exception occurred when decompiling this method (060006EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.HttpValidationHelpers::CheckBadHeaderNameChars(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, ldc.i4:bool(1))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 355
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1683
*/;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00019440 File Offset: 0x00017640
		internal static bool ContainsNonAsciiChars(string token)
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00019454 File Offset: 0x00017654
		internal static bool IsValidToken(string token)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001946C File Offset: 0x0001766C
		public static string CheckBadHeaderValueChars(string value)
		{
			string text;
			int num3;
			do
			{
				int stringLength = text._stringLength;
				long num = 0L;
				long num2 = 0L;
				char c = text[(int)num2];
				if (num == 0L)
				{
					num3 = 1;
				}
				int stringLength2 = text._stringLength;
			}
			while (num3 != 0);
			return text;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000194A8 File Offset: 0x000176A8
		public static bool IsInvalidMethodOrHeaderString(string stringValue)
		{
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000194BC File Offset: 0x000176BC
		// Note: this type is marked as 'beforefieldinit'.
		static HttpValidationHelpers()
		{
		}

		// Token: 0x04000566 RID: 1382
		private static readonly char[] s_httpTrimCharacters;
	}
}
