using System;
using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace System.Xml
{
	// Token: 0x02000095 RID: 149
	public class XmlConvert
	{
		// Token: 0x060006D6 RID: 1750 RVA: 0x0001790C File Offset: 0x00015B0C
		public static string EncodeName(string name)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00017920 File Offset: 0x00015B20
		public static string DecodeName(string name)
		{
			if (!true)
			{
			}
			MatchCollection matchCollection;
			IEnumerator enumerator = matchCollection.GetEnumerator();
			if (enumerator != null)
			{
			}
			if (enumerator != null)
			{
			}
			long num = 0L;
			if (enumerator != null)
			{
			}
			if (num == 0L)
			{
			}
			if (42180112 == 0)
			{
			}
			char c;
			if (c != '\0')
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00017964 File Offset: 0x00015B64
		private static string EncodeName(string name, bool first, bool local)
		{
			int num = 1;
			bool flag = string.IsNullOrEmpty("X4");
			if (num == 0)
			{
			}
			MatchCollection matchCollection;
			IEnumerator enumerator = matchCollection.GetEnumerator();
			if (enumerator != null)
			{
			}
			char c;
			if (c == '\0')
			{
			}
			long num2 = 0L;
			long num3 = 0L;
			if (c == '\0')
			{
			}
			if (num3 == 0L)
			{
			}
			if (enumerator != null)
			{
			}
			int num4 = 64673;
			if ("_x" == null)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (num4 == 0)
			{
			}
			CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
			if ("X8" != null)
			{
			}
			if (num4 == 0)
			{
			}
			CultureInfo invariantCulture3 = CultureInfo.InvariantCulture;
			if (num2 != 0L)
			{
			}
			if (num4 != 0)
			{
			}
			if (enumerator != null)
			{
			}
			if (enumerator != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00003FFD File Offset: 0x000021FD
		private static int FromHex(char digit)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00017A18 File Offset: 0x00015C18
		internal static byte[] FromBinHexString(string s, bool allowOddCount)
		{
			long num = 0L;
			char[] array;
			return BinHexDecoder.Decode(array, num != 0L);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00017A30 File Offset: 0x00015C30
		internal static string ToBinHexString(byte[] inArray)
		{
			string text;
			return text;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00017A40 File Offset: 0x00015C40
		public static string VerifyName(string name)
		{
			/*
An exception occurred when decompiling this method (060006DC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlConvert::VerifyName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:Exception(var_1_13, call:Exception(XmlConvert::CreateInvalidNameCharException, ldstr:string("The empty string '' is not a valid name."), ldc.i4:int32(-1073741824), ldc.i4:ExceptionType(1)))
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

		// Token: 0x060006DD RID: 1757 RVA: 0x00017A60 File Offset: 0x00015C60
		internal static Exception TryVerifyName(string name)
		{
			/*
An exception occurred when decompiling this method (060006DD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Xml.XmlConvert::TryVerifyName(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
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

		// Token: 0x060006DE RID: 1758 RVA: 0x00017A70 File Offset: 0x00015C70
		internal static string VerifyQName(string name, ExceptionType exceptionType)
		{
			/*
An exception occurred when decompiling this method (060006DE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlConvert::VerifyQName(System.String,System.Xml.ExceptionType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
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

		// Token: 0x060006DF RID: 1759 RVA: 0x00017A80 File Offset: 0x00015C80
		public static string VerifyNCName(string name)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00017A94 File Offset: 0x00015C94
		internal static string VerifyNCName(string name, ExceptionType exceptionType)
		{
			/*
An exception occurred when decompiling this method (060006E0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Xml.XmlConvert::VerifyNCName(System.String,System.Xml.ExceptionType)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
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

		// Token: 0x060006E1 RID: 1761 RVA: 0x00017AA4 File Offset: 0x00015CA4
		internal static Exception TryVerifyNCName(string name)
		{
			if (!true)
			{
			}
			int num;
			if (num != 0)
			{
			}
			if (!true)
			{
			}
			Exception ex;
			return ex;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00017AC0 File Offset: 0x00015CC0
		internal static Exception TryVerifyTOKEN(string token)
		{
			int num = 1;
			if (num == 0 || num == 0)
			{
				return;
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00017ADC File Offset: 0x00015CDC
		internal static Exception TryVerifyNMTOKEN(string name)
		{
			/*
An exception occurred when decompiling this method (060006E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Xml.XmlConvert::TryVerifyNMTOKEN(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldc.i4:bool(1)))
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

		// Token: 0x060006E4 RID: 1764 RVA: 0x00017AEC File Offset: 0x00015CEC
		internal static Exception TryVerifyNormalizedString(string str)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00017B00 File Offset: 0x00015D00
		public static string ToString(bool value)
		{
			return 1;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00017B10 File Offset: 0x00015D10
		public static string ToString(decimal value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00017B28 File Offset: 0x00015D28
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00017B40 File Offset: 0x00015D40
		public static string ToString(short value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00017B58 File Offset: 0x00015D58
		public static string ToString(int value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00017B70 File Offset: 0x00015D70
		public static string ToString(long value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00017B88 File Offset: 0x00015D88
		public static string ToString(byte value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00017BA0 File Offset: 0x00015DA0
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00017BB8 File Offset: 0x00015DB8
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00017BD0 File Offset: 0x00015DD0
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			string text;
			return text;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00017BE8 File Offset: 0x00015DE8
		public static string ToString(float value)
		{
			return "INF";
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00017C18 File Offset: 0x00015E18
		public static string ToString(double value)
		{
			return "INF";
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00017C48 File Offset: 0x00015E48
		public static string ToString(TimeSpan value)
		{
			string text;
			return text;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00017C58 File Offset: 0x00015E58
		public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption)
		{
			DateTime dateTime;
			long ticks = dateTime.Ticks;
			string text;
			return text;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00017C7C File Offset: 0x00015E7C
		public static string ToString(DateTimeOffset value)
		{
			string text;
			return text;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00017C8C File Offset: 0x00015E8C
		public static bool ToBoolean(string s)
		{
			if (!true)
			{
			}
			string text;
			bool flag = text == "1";
			bool flag2 = text == "true";
			return true;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00017CE0 File Offset: 0x00015EE0
		internal static Exception TryToBoolean(string s, [Out] bool result)
		{
			if (!true)
			{
			}
			string text;
			bool flag = text == "0";
			bool flag2 = text == "false";
			long num = 0L;
			if ((num != 0L && num == 0L) || "Boolean" == null || "Boolean" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00017D28 File Offset: 0x00015F28
		public static char ToChar(string s)
		{
			char c;
			return c;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00017D38 File Offset: 0x00015F38
		internal static Exception TryToChar(string s, [Out] char result)
		{
			if (!true)
			{
			}
			if ("Char" == null || "Char" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00017D5C File Offset: 0x00015F5C
		public static decimal ToDecimal(string s)
		{
			/*
An exception occurred when decompiling this method (060006F8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Decimal System.Xml.XmlConvert::ToDecimal(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NumberFormatInfo(var_1_07, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:Decimal(var_2_11, call:Decimal(Decimal::Parse, ldloc:string(s), ldc.i4:NumberStyles(39), ldloc:NumberFormatInfo[exp:IFormatProvider](var_1_07)))
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

		// Token: 0x060006F9 RID: 1785 RVA: 0x00017D7C File Offset: 0x00015F7C
		internal static Exception TryToDecimal(string s, [Out] decimal result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("Decimal" == null || "Decimal" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00017DA4 File Offset: 0x00015FA4
		internal static decimal ToInteger(string s)
		{
			/*
An exception occurred when decompiling this method (060006FA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Decimal System.Xml.XmlConvert::ToInteger(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NumberFormatInfo(var_1_07, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:Decimal(var_2_10, call:Decimal(Decimal::Parse, ldloc:string(s), ldc.i4:NumberStyles(7), ldloc:NumberFormatInfo[exp:IFormatProvider](var_1_07)))
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

		// Token: 0x060006FB RID: 1787 RVA: 0x00017DC4 File Offset: 0x00015FC4
		internal static Exception TryToInteger(string s, [Out] decimal result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("Integer" == null || "Integer" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00017DEC File Offset: 0x00015FEC
		internal static Exception TryToSByte(string s, [Out] sbyte result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("SByte" == null || "SByte" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00017E14 File Offset: 0x00016014
		internal static Exception TryToInt16(string s, [Out] short result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("Int16" == null || "Int16" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00017E3C File Offset: 0x0001603C
		public static int ToInt32(string s)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			int num;
			return num;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00017E54 File Offset: 0x00016054
		internal static Exception TryToInt32(string s, [Out] int result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("Int32" == null || "Int32" != null)
			{
				return "The string '{0}' is not a valid {1} value.";
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00017E84 File Offset: 0x00016084
		public static long ToInt64(string s)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			long num;
			return num;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00017E9C File Offset: 0x0001609C
		internal static Exception TryToInt64(string s, [Out] long result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("Int64" == null || "Int64" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00017EC4 File Offset: 0x000160C4
		internal static Exception TryToByte(string s, [Out] byte result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("Byte" == null || "Byte" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00017EEC File Offset: 0x000160EC
		internal static Exception TryToUInt16(string s, [Out] ushort result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("UInt16" == null || "UInt16" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00017F14 File Offset: 0x00016114
		internal static Exception TryToUInt32(string s, [Out] uint result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("UInt32" == null || "UInt32" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00017F3C File Offset: 0x0001613C
		internal static Exception TryToUInt64(string s, [Out] ulong result)
		{
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			if ("UInt64" == null || "UInt64" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00017F64 File Offset: 0x00016164
		public static float ToSingle(string s)
		{
			/*
An exception occurred when decompiling this method (06000706)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Single System.Xml.XmlConvert::ToSingle(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("-INF")))
	stloc:bool(var_2_1A, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("INF")))
	stloc:NumberFormatInfo(var_4_22, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:float32(var_5_31, call:float32(float32::Parse, ldloc:string(var_0), ldc.i4:NumberStyles(164), ldloc:NumberFormatInfo[exp:IFormatProvider](var_4_22)))
	stloc:int64(var_6_34, ldc.i4:int64(0))
	stloc:char(var_7_3E, callgetter:char(string::get_Chars, ldloc:string(var_0), ldloc:int64[exp:int32](var_6_34)))
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

		// Token: 0x06000707 RID: 1799 RVA: 0x00017FB0 File Offset: 0x000161B0
		internal static Exception TryToSingle(string s, [Out] float result)
		{
			if (!true)
			{
			}
			string text;
			bool flag = text == "-INF";
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			long num = 0L;
			if ((num != 0L && num == 0L) || "Single" == null || "Single" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00017FFC File Offset: 0x000161FC
		public static double ToDouble(string s)
		{
			/*
An exception occurred when decompiling this method (06000708)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Double System.Xml.XmlConvert::ToDouble(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:bool(var_1_0E, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("-INF")))
	stloc:bool(var_2_1A, call:bool(string::op_Equality, ldloc:string(var_0), ldstr:string("INF")))
	stloc:NumberFormatInfo(var_4_22, callgetter:NumberFormatInfo(NumberFormatInfo::get_InvariantInfo))
	stloc:float64(var_5_31, call:float64(float64::Parse, ldloc:string(var_0), ldc.i4:NumberStyles(167), ldloc:NumberFormatInfo[exp:IFormatProvider](var_4_22)))
	stloc:int64(var_6_34, ldc.i4:int64(0))
	stloc:char(var_7_3E, callgetter:char(string::get_Chars, ldloc:string(var_0), ldloc:int64[exp:int32](var_6_34)))
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

		// Token: 0x06000709 RID: 1801 RVA: 0x00018048 File Offset: 0x00016248
		internal static Exception TryToDouble(string s, [Out] double result)
		{
			if (!true)
			{
			}
			string text;
			bool flag = text == "-INF";
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
			long num = 0L;
			if ((num != 0L && num == 0L) || "Double" == null || "Double" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00018094 File Offset: 0x00016294
		internal static Exception TryToTimeSpan(string s, [Out] TimeSpan result)
		{
			Exception ex;
			if (ex == null || !true)
			{
			}
			Exception ex2;
			return ex2;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00003FFD File Offset: 0x000021FD
		public static Guid ToGuid(string s)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000180A8 File Offset: 0x000162A8
		internal static Exception TryToGuid(string s, [Out] Guid result)
		{
			long num = 0L;
			if ((num != 0L && num == 0L) || "Guid" == null || "Guid" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000180D4 File Offset: 0x000162D4
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			DateTime dateTime;
			if (value.Kind != DateTimeKind.Unspecified)
			{
				return dateTime;
			}
			return dateTime;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000180F0 File Offset: 0x000162F0
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			DateTime dateTime;
			if (value.Kind != DateTimeKind.Unspecified)
			{
				return dateTime;
			}
			return dateTime;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001810C File Offset: 0x0001630C
		internal static Uri ToUri(string s)
		{
			string text;
			if (text._stringLength != 0)
			{
				int num = text.IndexOf("##", StringComparison.Ordinal);
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001813C File Offset: 0x0001633C
		internal static Exception TryToUri(string s, [Out] Uri result)
		{
			string text;
			if (text._stringLength != 0)
			{
				int num = text.IndexOf("##", StringComparison.Ordinal);
			}
			if ((text != null && text == null) || "Uri" == null || "Uri" != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00018178 File Offset: 0x00016378
		internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0001818C File Offset: 0x0001638C
		internal static string TrimString(string value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000181A0 File Offset: 0x000163A0
		internal static string TrimStringStart(string value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000181B4 File Offset: 0x000163B4
		internal static string TrimStringEnd(string value)
		{
			if (!true)
			{
			}
			string text;
			return text;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000181C8 File Offset: 0x000163C8
		internal static string[] SplitString(string value)
		{
			if (!true)
			{
			}
			string[] array;
			return array;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000181DC File Offset: 0x000163DC
		internal static bool IsNegativeZero(double value)
		{
			return true;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00003FFD File Offset: 0x000021FD
		private static long DoubleToInt64Bits(double value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000181EC File Offset: 0x000163EC
		internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos)
		{
			if (arg != null)
			{
			}
			if (res == null || res != null)
			{
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00018208 File Offset: 0x00016408
		internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType)
		{
			if (!true)
			{
			}
			Exception ex;
			return ex;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001821C File Offset: 0x0001641C
		internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos)
		{
			/*
An exception occurred when decompiling this method (0600071A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Xml.XmlConvert::CreateException(System.String,System.String[],System.Xml.ExceptionType,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(ldloc:string[exp:bool](res)))
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

		// Token: 0x0600071B RID: 1819 RVA: 0x00018230 File Offset: 0x00016430
		internal static Exception CreateInvalidSurrogatePairException(char low, char hi)
		{
			if (!true)
			{
			}
			Exception ex;
			return ex;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00018244 File Offset: 0x00016444
		internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType)
		{
			if (!true)
			{
			}
			Exception ex;
			return ex;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00018258 File Offset: 0x00016458
		internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			string text;
			if (text == null || text != null)
			{
				CultureInfo invariantCulture2 = CultureInfo.InvariantCulture;
				string text2;
				if (text2 == null || text2 != null)
				{
					Exception ex;
					return ex;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0001828C File Offset: 0x0001648C
		internal static Exception CreateInvalidHighSurrogateCharException(char hi)
		{
			if (!true)
			{
			}
			Exception ex;
			return ex;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000182A0 File Offset: 0x000164A0
		internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType)
		{
			if (!true)
			{
			}
			Exception ex;
			return ex;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000182B4 File Offset: 0x000164B4
		internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos)
		{
			if (!true)
			{
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			Exception ex;
			return ex;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000182D0 File Offset: 0x000164D0
		internal static Exception CreateInvalidCharException(char invChar, char nextChar)
		{
			if (!true)
			{
			}
			Exception ex;
			return ex;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000182E4 File Offset: 0x000164E4
		internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType)
		{
			Exception ex;
			return ex;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000182F4 File Offset: 0x000164F4
		internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType)
		{
			Exception ex;
			return ex;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00003FFD File Offset: 0x000021FD
		internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00018304 File Offset: 0x00016504
		// Note: this type is marked as 'beforefieldinit'.
		static XmlConvert()
		{
			XmlCharType instance = XmlCharType.Instance;
		}

		// Token: 0x040003A1 RID: 929
		private static XmlCharType xmlCharType;

		// Token: 0x040003A2 RID: 930
		internal static char[] crt;

		// Token: 0x040003A3 RID: 931
		private static readonly int c_EncodedCharLength;

		// Token: 0x040003A4 RID: 932
		private static Regex c_EncodeCharPattern;

		// Token: 0x040003A5 RID: 933
		private static Regex c_DecodeCharPattern;

		// Token: 0x040003A6 RID: 934
		internal static readonly char[] WhitespaceChars;
	}
}
