using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000074 RID: 116
	[Preserve]
	internal static class StringUtils
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x0000B654 File Offset: 0x00009854
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			if (provider == null || provider != null)
			{
				string text;
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000B670 File Offset: 0x00009870
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			if ((provider == null || provider != null) && (arg0 == null || arg0 != null))
			{
				string text;
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000B690 File Offset: 0x00009890
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			if ((provider == null || provider != null) && (arg0 == null || arg0 != null) && (arg1 == null || arg1 != null))
			{
				string text;
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000B6B8 File Offset: 0x000098B8
		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			if ((provider == null || provider != null) && (arg0 == null || arg0 != null) && (arg1 == null || arg1 != null) && (arg2 == null || arg2 != null))
			{
				string text;
				return text;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000B6E8 File Offset: 0x000098E8
		private static string FormatWith(this string format, IFormatProvider provider, params object[] args)
		{
			ValidationUtils.ArgumentNotNull("format", "format");
			string text;
			return text;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000B708 File Offset: 0x00009908
		public static bool IsWhiteSpace(string s)
		{
			if (true)
			{
				char c;
				bool flag = char.IsWhiteSpace(c);
				return;
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000212A File Offset: 0x0000032A
		public static string NullEmptyString(string s)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000B728 File Offset: 0x00009928
		public static StringWriter CreateStringWriter(int capacity)
		{
			/*
An exception occurred when decompiling this method (0600042C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.StringWriter Newtonsoft.Json.Utilities.StringUtils::CreateStringWriter(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_1_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x0600042D RID: 1069 RVA: 0x0000B740 File Offset: 0x00009940
		public static int? GetLength(string value)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000B750 File Offset: 0x00009950
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000B760 File Offset: 0x00009960
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			while (source == null)
			{
			}
			return "source";
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000B778 File Offset: 0x00009978
		public static string ToCamelCase(string s)
		{
			char c;
			bool flag = char.IsUpper(c);
			long num = 0L;
			bool flag2 = char.IsUpper(c);
			if (num != 0L)
			{
				bool flag3 = char.IsUpper(c);
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			char c2 = char.ToLower(c, invariantCulture);
			string text;
			return text;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000B7C4 File Offset: 0x000099C4
		public static bool IsHighSurrogate(char c)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000B7D8 File Offset: 0x000099D8
		public static bool IsLowSurrogate(char c)
		{
			if (!true)
			{
			}
			bool flag;
			return flag;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000B7EC File Offset: 0x000099EC
		public static bool StartsWith(this string source, char value)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000B7FC File Offset: 0x000099FC
		public static bool EndsWith(this string source, char value)
		{
		}

		// Token: 0x04000203 RID: 515
		public const string CarriageReturnLineFeed = "\r\n";

		// Token: 0x04000204 RID: 516
		public const string Empty = "";

		// Token: 0x04000205 RID: 517
		public const char CarriageReturn = '\r';

		// Token: 0x04000206 RID: 518
		public const char LineFeed = '\n';

		// Token: 0x04000207 RID: 519
		public const char Tab = '\t';

		// Token: 0x02000075 RID: 117
		[CompilerGenerated]
		private sealed class <>c__DisplayClass15_0<TSource>
		{
			// Token: 0x06000435 RID: 1077 RVA: 0x0000B80C File Offset: 0x00009A0C
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x0000B820 File Offset: 0x00009A20
			internal bool <ForgivingCaseSensitiveFind>b__0(TSource s)
			{
				Func func = this.valueSelector;
				string text = this.testValue;
				bool flag;
				return flag;
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x0000B83C File Offset: 0x00009A3C
			internal bool <ForgivingCaseSensitiveFind>b__1(TSource s)
			{
				Func func = this.valueSelector;
				string text = this.testValue;
				bool flag;
				return flag;
			}

			// Token: 0x04000208 RID: 520
			public Func<TSource, string> valueSelector;

			// Token: 0x04000209 RID: 521
			public string testValue;
		}
	}
}
