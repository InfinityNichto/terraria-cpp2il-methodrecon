using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System
{
	// Token: 0x020000EE RID: 238
	internal static class ParseNumbers
	{
		// Token: 0x060008D6 RID: 2262 RVA: 0x000158FC File Offset: 0x00013AFC
		public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags)
		{
			long num;
			return num;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0001590C File Offset: 0x00013B0C
		public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, int currPos)
		{
			int num = 10;
			currPos.m_value = num;
			long num2;
			return num2;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001594C File Offset: 0x00013B4C
		public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags)
		{
			int num;
			return num;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0001595C File Offset: 0x00013B5C
		public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, int currPos)
		{
			int num = 10;
			currPos.m_value = num;
			return "Value was either too large or too small for an Int32.";
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000159A8 File Offset: 0x00013BA8
		private static void EatWhiteSpace(ReadOnlySpan<char> s, int i)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000159B8 File Offset: 0x00013BB8
		private static long GrabLongs(int radix, ReadOnlySpan<char> s, int i, bool isUnsigned)
		{
			return 0L;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000159F8 File Offset: 0x00013BF8
		private static int GrabInts(int radix, ReadOnlySpan<char> s, int i, bool isUnsigned)
		{
			/*
An exception occurred when decompiling this method (060008DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.ParseNumbers::GrabInts(System.Int32,System.ReadOnlySpan`1<System.Char>,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ParseNumbers::ThrowOverflowInt32Exception)
	call:void(ParseNumbers::ThrowOverflowUInt32Exception)
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

		// Token: 0x060008DD RID: 2269 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowOverflowInt32Exception()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowOverflowInt64Exception()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowOverflowUInt32Exception()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0000207A File Offset: 0x0000027A
		private static void ThrowOverflowUInt64Exception()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00015A28 File Offset: 0x00013C28
		private static bool IsDigit(char c, int radix, [Out] int result)
		{
		}
	}
}
