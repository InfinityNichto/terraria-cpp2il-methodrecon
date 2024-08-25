using System;

namespace System
{
	// Token: 0x0200007B RID: 123
	internal static class IPv6AddressHelper
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00006200 File Offset: 0x00004400
		internal static ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006214 File Offset: 0x00004414
		internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers)
		{
			/*
An exception occurred when decompiling this method (060001D7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.IPv6AddressHelper::ShouldHaveIpv4Embedded(System.ReadOnlySpan`1<System.UInt16>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	brtrue(IL_000F, ldc.i4:bool(1))
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

		// Token: 0x060001D8 RID: 472 RVA: 0x00006234 File Offset: 0x00004434
		internal unsafe static bool IsValidStrict(char* name, int start, int end)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00006278 File Offset: 0x00004478
		internal unsafe static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, string scopeId)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000062E4 File Offset: 0x000044E4
		internal static string ParseCanonicalName(string str, int start, bool isLoopback, string scopeId)
		{
			long num = 0L;
			if (num != 0L)
			{
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			if ("x" != null)
			{
				while ("x" != null)
				{
				}
			}
			int num2 = 58;
			isLoopback.m_value = num2 != 0;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num3 = 46;
			isLoopback.m_value = num3 != 0;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num4 = 46;
			isLoopback.m_value = num4 != 0;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num5 = 46;
			isLoopback.m_value = num5 != 0;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			int num6 = 58;
			isLoopback.m_value = num6 != 0;
			int num7 = 93;
			isLoopback.m_value = num7 != 0;
			ThrowHelper.ThrowArgumentOutOfRangeException();
			string text;
			return text;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00006390 File Offset: 0x00004590
		private static bool IsLoopback(ReadOnlySpan<ushort> numbers)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000063A4 File Offset: 0x000045A4
		private unsafe static bool InternalIsValid(char* name, int start, int end, bool validateStrictAddress)
		{
			bool flag;
			return flag;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000063E4 File Offset: 0x000045E4
		internal unsafe static bool IsValid(char* name, int start, int end)
		{
			bool flag;
			return flag;
		}
	}
}
