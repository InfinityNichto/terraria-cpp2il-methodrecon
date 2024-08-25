using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Numerics
{
	// Token: 0x02000005 RID: 5
	internal static class BigNumber
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000024F8 File Offset: 0x000006F8
		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, [Out] int digits)
		{
			/*
An exception occurred when decompiling this method (06000026)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char System.Numerics.BigNumber::ParseFormatSpecifier(System.ReadOnlySpan`1<System.Char>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](digits), ldloc:int32(var_0_01))
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

		// Token: 0x06000027 RID: 39 RVA: 0x00002524 File Offset: 0x00000724
		private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, [Out] int charsWritten, [Out] bool spanSuccess)
		{
			int num = 1;
			byte[] array;
			if (array != null)
			{
			}
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			byte[] array2;
			if (array2 == null)
			{
			}
			ThrowHelper.ThrowArgumentOutOfRangeException();
			ThrowHelper.ThrowArgumentOutOfRangeException();
			string text;
			return text;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002570 File Offset: 0x00000770
		internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info)
		{
			if (format != null)
			{
				char rawStringData = format.GetRawStringData();
				int stringLength = format._stringLength;
				while (format != null)
				{
				}
			}
			string text;
			return text;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002594 File Offset: 0x00000794
		private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, [Out] int charsWritten, [Out] bool spanSuccess)
		{
			string text;
			return text;
		}
	}
}
