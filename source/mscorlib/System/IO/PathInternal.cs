using System;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x0200053A RID: 1338
	internal static class PathInternal
	{
		// Token: 0x06002776 RID: 10102 RVA: 0x000558A4 File Offset: 0x00053AA4
		internal static int GetRootLength(ReadOnlySpan<char> path)
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x0000207A File Offset: 0x0000027A
		internal static bool IsDirectorySeparator(char c)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000558B4 File Offset: 0x00053AB4
		internal static bool EndsInDirectorySeparator(ReadOnlySpan<char> path)
		{
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x000558C4 File Offset: 0x00053AC4
		internal static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path)
		{
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000558D4 File Offset: 0x00053AD4
		internal static string TrimEndingDirectorySeparator(string path)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000558F4 File Offset: 0x00053AF4
		internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
		{
			/*
An exception occurred when decompiling this method (0600277B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ReadOnlySpan`1<System.Char> System.IO.PathInternal::TrimEndingDirectorySeparator(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x0600277C RID: 10108 RVA: 0x00055914 File Offset: 0x00053B14
		internal static bool IsRoot(ReadOnlySpan<char> path)
		{
			/*
An exception occurred when decompiling this method (0600277C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IO.PathInternal::IsRoot(System.ReadOnlySpan`1<System.Char>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x00055924 File Offset: 0x00053B24
		internal static bool IsCaseSensitive
		{
			get
			{
				if (!true)
				{
				}
				return true;
			}
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00055938 File Offset: 0x00053B38
		private static bool GetIsCaseSensitive()
		{
			if (!true)
			{
			}
			string tempPath = Path.GetTempPath();
			string text = Guid.NewGuid().ToString("N");
			string text2 = "CASESENSITIVETEST" + "N";
			bool flag = File.Exists(Path.Combine(tempPath, text2).ToLowerInvariant());
			long num = 0L;
			int num2 = 2;
			if (num != 0L || num2 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000559B8 File Offset: 0x00053BB8
		public static bool IsPartiallyQualified(string path)
		{
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000559C8 File Offset: 0x00053BC8
		// Note: this type is marked as 'beforefieldinit'.
		static PathInternal()
		{
			bool isCaseSensitive = PathInternal.GetIsCaseSensitive();
		}

		// Token: 0x0400158D RID: 5517
		private static readonly bool s_isCaseSensitive;
	}
}
