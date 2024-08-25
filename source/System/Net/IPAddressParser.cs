using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000141 RID: 321
	internal class IPAddressParser
	{
		// Token: 0x060007C1 RID: 1985 RVA: 0x0001B294 File Offset: 0x00019494
		internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse)
		{
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0001B2AC File Offset: 0x000194AC
		internal static string IPv4AddressToString(uint address)
		{
			string text;
			return text;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0001B2BC File Offset: 0x000194BC
		internal static void IPv4AddressToString(uint address, StringBuilder destination)
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0001B2CC File Offset: 0x000194CC
		internal static bool IPv4AddressToString(uint address, Span<char> formatted, [Out] int charsWritten)
		{
			/*
An exception occurred when decompiling this method (060007C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.IPAddressParser::IPv4AddressToString(System.UInt32,System.Span`1<System.Char>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_1_01, ldc.i4:int64(0))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](charsWritten), ldloc:int64[exp:int32](var_1_01))
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

		// Token: 0x060007C5 RID: 1989 RVA: 0x0001B2E4 File Offset: 0x000194E4
		private unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
		{
			/*
An exception occurred when decompiling this method (060007C5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.IPAddressParser::IPv4AddressToStringHelper(System.UInt32,System.Char*)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_02, ldc.i4:int32(46))
	stfld:uint32(uint32::m_value, ldloc:uint32[exp:uint32&](address), ldloc:int32[exp:uint32](var_0_02))
	stfld:uint32(uint32::m_value, ldloc:uint32[exp:uint32&](address), ldloc:int32[exp:uint32](var_0_02))
	stfld:uint32(uint32::m_value, ldloc:uint32[exp:uint32&](address), ldloc:int32[exp:uint32](var_0_02))
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

		// Token: 0x060007C6 RID: 1990 RVA: 0x0001B308 File Offset: 0x00019508
		internal static string IPv6AddressToString(ushort[] address, uint scopeId)
		{
			StringBuilder stringBuilder;
			return StringBuilderCache.GetStringAndRelease(stringBuilder);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0001B31C File Offset: 0x0001951C
		internal static bool IPv6AddressToString(ushort[] address, uint scopeId, Span<char> destination, [Out] int charsWritten)
		{
			StringBuilder stringBuilder;
			int length = stringBuilder.Length;
			StringBuilderCache.Release(stringBuilder);
			int length2 = stringBuilder.Length;
			int length3 = stringBuilder.Length;
			charsWritten.m_value = length3;
			StringBuilderCache.Release(stringBuilder);
			return true;
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0001B358 File Offset: 0x00019558
		internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId)
		{
			StringBuilder stringBuilder = StringBuilderCache.Acquire(65);
			long num = 0L;
			int length = stringBuilder.Length;
			char c = stringBuilder[(int)num];
			int num2 = 58;
			StringBuilder stringBuilder2 = stringBuilder.Append((char)num2);
			if (address == null)
			{
				StringBuilder stringBuilder3;
				return stringBuilder3;
			}
			int num3 = 37;
			StringBuilder stringBuilder4 = stringBuilder.Append((char)num3);
			return stringBuilder;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0001B3A8 File Offset: 0x000195A8
		private unsafe static void FormatIPv4AddressNumber(int number, char* addressString, int offset)
		{
			int num = 1;
			offset.m_value = num;
			if (num == 0)
			{
			}
			int num2 = 10;
			int num3 = Math.DivRem(number, num2, offset);
			addressString->m_value = (char)num;
			while (num3 != 0)
			{
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0001B3D8 File Offset: 0x000195D8
		public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, [Out] long address)
		{
			long num = 0L;
			address.m_value = num;
			return true;
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0001B3F0 File Offset: 0x000195F0
		public unsafe static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, [Out] uint scope)
		{
			/*
An exception occurred when decompiling this method (060007CB)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.IPAddressParser::Ipv6StringToAddress(System.ReadOnlySpan`1<System.Char>,System.UInt16*,System.Int32,System.UInt32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int64(var_7_0B, ldc.i4:int64(0))
	stfld:uint32(uint32::m_value, ldloc:uint32[exp:uint32&](scope), ldloc:int64[exp:uint32](var_7_0B))
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

		// Token: 0x060007CC RID: 1996 RVA: 0x0001B414 File Offset: 0x00019614
		private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer)
		{
			int num = 1;
			if (address != null)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
				return;
			}
			if (num != 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			int num2 = 58;
			StringBuilder stringBuilder = buffer.Append((char)num2);
			StringBuilder stringBuilder2 = buffer.Append("::");
			int num3 = 58;
			StringBuilder stringBuilder3 = buffer.Append((char)num3);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0001B464 File Offset: 0x00019664
		private static void AppendHex(ushort value, StringBuilder buffer)
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
		private static uint ExtractIPv4Address(ushort[] address)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
		private static ushort Reverse(ushort number)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001B474 File Offset: 0x00019674
		public IPAddressParser()
		{
		}

		// Token: 0x04000646 RID: 1606
		private const int MaxIPv4StringLength = 15;
	}
}
