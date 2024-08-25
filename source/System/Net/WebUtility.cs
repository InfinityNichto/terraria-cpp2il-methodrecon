using System;
using System.Globalization;
using System.IO;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x020001E0 RID: 480
	public static class WebUtility
	{
		// Token: 0x06000BE4 RID: 3044 RVA: 0x00026B60 File Offset: 0x00024D60
		public static string HtmlEncode(string value)
		{
			/*
An exception occurred when decompiling this method (06000BE4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.WebUtility::HtmlEncode(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_3_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00026B78 File Offset: 0x00024D78
		public static void HtmlEncode(string value, TextWriter output)
		{
			int num;
			do
			{
				num = 1;
				if (value == null)
				{
					return;
				}
			}
			while (output == null);
			if (num == 0)
			{
			}
			long num2 = 0L;
			int num3 = WebUtility.IndexOfHtmlEncodingChars(value, (int)num2);
			if (num == 0)
			{
			}
			global::System.Net.Configuration.UnicodeEncodingConformance htmlEncodeConformance = WebUtility.HtmlEncodeConformance;
			int stringLength = value._stringLength;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00026BC8 File Offset: 0x00024DC8
		public static string HtmlDecode(string value)
		{
			/*
An exception occurred when decompiling this method (06000BE6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.WebUtility::HtmlDecode(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CultureInfo(var_3_0A, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00026BE0 File Offset: 0x00024DE0
		public static void HtmlDecode(string value, TextWriter output)
		{
			int num;
			do
			{
				num = 1;
				if (value == null)
				{
					return;
				}
			}
			while (output == null);
			if (num == 0)
			{
			}
			bool flag = WebUtility.StringRequiresHtmlDecoding(value);
			if (num == 0)
			{
			}
			global::System.Net.Configuration.UnicodeDecodingConformance htmlDecodeConformance = WebUtility.HtmlDecodeConformance;
			int stringLength = value._stringLength;
			long num2 = 0L;
			char c = value[(int)num2];
			if (num == 0)
			{
			}
			long num3 = 0L;
			int num4;
			char c2 = value[num4];
			string text = value.Substring(num4, (int)num3);
			int stringLength2 = text._stringLength;
			long num5 = 0L;
			char c3 = text[(int)num5];
			int num6 = 1;
			char c4 = text[num6];
			int num7 = 1;
			char c5 = text[num7];
			int num8 = 2;
			string text2 = text.Substring(num8);
			NumberFormatInfo invariantInfo = NumberFormatInfo.InvariantInfo;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00026CBC File Offset: 0x00024EBC
		private static int IndexOfHtmlEncodingChars(string s, int startPos)
		{
			if (!true)
			{
			}
			global::System.Net.Configuration.UnicodeEncodingConformance htmlEncodeConformance = WebUtility.HtmlEncodeConformance;
			return RuntimeHelpers.OffsetToStringData;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00026CE0 File Offset: 0x00024EE0
		private static global::System.Net.Configuration.UnicodeDecodingConformance HtmlDecodeConformance
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000BE9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Configuration.UnicodeDecodingConformance System.Net.WebUtility::get_HtmlDecodeConformance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
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
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00026CF8 File Offset: 0x00024EF8
		private static global::System.Net.Configuration.UnicodeEncodingConformance HtmlEncodeConformance
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000BEA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.Configuration.UnicodeEncodingConformance System.Net.WebUtility::get_HtmlEncodeConformance()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0006:
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
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00026D10 File Offset: 0x00024F10
		private static byte[] UrlEncode(byte[] bytes, int offset, int count, bool alwaysCreateNewReturnValue)
		{
			if (!true)
			{
			}
			byte[] array;
			object obj;
			if (array == null || obj == null || obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00026D30 File Offset: 0x00024F30
		private static byte[] UrlEncode(byte[] bytes, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000BEC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Net.WebUtility::UrlEncode(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0008:
	brtrue(IL_0000, ldloc:uint8[][exp:bool](bytes))
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

		// Token: 0x06000BED RID: 3053 RVA: 0x00026D4C File Offset: 0x00024F4C
		public static string UrlEncode(string value)
		{
			/*
An exception occurred when decompiling this method (06000BED)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.WebUtility::UrlEncode(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_UTF8))
	stloc:Encoding(var_3_0F, callgetter:Encoding(Encoding::get_UTF8))
	stloc:CodePageDataItem(var_4_16, ldfld:CodePageDataItem(Encoding::dataItem, ldloc:Encoding(var_1_07)))
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

		// Token: 0x06000BEE RID: 3054 RVA: 0x00026D74 File Offset: 0x00024F74
		public static byte[] UrlEncodeToBytes(byte[] value, int offset, int count)
		{
			if (!true)
			{
			}
			byte[] array;
			return array;
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00026D88 File Offset: 0x00024F88
		private static string UrlDecodeInternal(string value, Encoding encoding)
		{
			string text;
			return text;
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00026DA0 File Offset: 0x00024FA0
		private static byte[] UrlDecodeInternal(byte[] bytes, int offset, int count)
		{
			if (!true)
			{
				return;
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00026DBC File Offset: 0x00024FBC
		public static string UrlDecode(string encodedValue)
		{
			Encoding utf = Encoding.UTF8;
			string text;
			return text;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00026DD4 File Offset: 0x00024FD4
		public static byte[] UrlDecodeToBytes(byte[] encodedValue, int offset, int count)
		{
			if (!true)
			{
			}
			byte[] array;
			return array;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00026DE8 File Offset: 0x00024FE8
		private static void ConvertSmpToUtf16(uint smpChar, [Out] char leadingSurrogate, [Out] char trailingSurrogate)
		{
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00026DF8 File Offset: 0x00024FF8
		private unsafe static int GetNextUnicodeScalarValueFromUtf16Surrogate(char* pch, int charsRemaining)
		{
			return 65533;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002050 File Offset: 0x00000250
		private static int HexToInt(char h)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		private static char IntToHex(int n)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00026E0C File Offset: 0x0002500C
		private static bool IsUrlSafeChar(char ch)
		{
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00026E1C File Offset: 0x0002501C
		private static bool ValidateUrlEncodingParameters(byte[] bytes, int offset, int count)
		{
			while (offset != 0)
			{
			}
			return "offset" != null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00026E38 File Offset: 0x00025038
		private static bool StringRequiresHtmlDecoding(string s)
		{
			/*
An exception occurred when decompiling this method (06000BF9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebUtility::StringRequiresHtmlDecoding(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
	stloc:bool(var_6_1B, call:bool(char::IsSurrogate, ldloc:char(var_5)))
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

		// Token: 0x06000BFA RID: 3066 RVA: 0x00026E68 File Offset: 0x00025068
		// Note: this type is marked as 'beforefieldinit'.
		static WebUtility()
		{
		}

		// Token: 0x04000A1E RID: 2590
		private const char HIGH_SURROGATE_START = '\ud800';

		// Token: 0x04000A1F RID: 2591
		private const char LOW_SURROGATE_START = '\udc00';

		// Token: 0x04000A20 RID: 2592
		private const char LOW_SURROGATE_END = '\udfff';

		// Token: 0x04000A21 RID: 2593
		private const int UNICODE_PLANE00_END = 65535;

		// Token: 0x04000A22 RID: 2594
		private const int UNICODE_PLANE01_START = 65536;

		// Token: 0x04000A23 RID: 2595
		private const int UNICODE_PLANE16_END = 1114111;

		// Token: 0x04000A24 RID: 2596
		private const int UnicodeReplacementChar = 65533;

		// Token: 0x04000A25 RID: 2597
		private static readonly char[] _htmlEntityEndingChars;

		// Token: 0x04000A26 RID: 2598
		private static global::System.Net.Configuration.UnicodeDecodingConformance _htmlDecodeConformance;

		// Token: 0x04000A27 RID: 2599
		private static global::System.Net.Configuration.UnicodeEncodingConformance _htmlEncodeConformance;

		// Token: 0x020001E1 RID: 481
		private class UrlDecoder
		{
			// Token: 0x06000BFB RID: 3067 RVA: 0x00026E78 File Offset: 0x00025078
			private void FlushBytes()
			{
				int numBytes = this._numBytes;
				Encoding encoding = this._encoding;
				int numChars = this._numChars;
				byte[] byteBuffer = this._byteBuffer;
				char[] charBuffer = this._charBuffer;
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x00026EAC File Offset: 0x000250AC
			internal UrlDecoder(int bufferSize, Encoding encoding)
			{
				this._bufferSize = bufferSize;
				this._encoding = encoding;
			}

			// Token: 0x06000BFD RID: 3069 RVA: 0x00026ED0 File Offset: 0x000250D0
			internal void AddChar(char ch)
			{
				int numBytes = this._numBytes;
				this.FlushBytes();
				char[] charBuffer = this._charBuffer;
			}

			// Token: 0x06000BFE RID: 3070 RVA: 0x00026EF4 File Offset: 0x000250F4
			internal void AddByte(byte b)
			{
				if (this._byteBuffer == null)
				{
					int bufferSize = this._bufferSize;
				}
			}

			// Token: 0x06000BFF RID: 3071 RVA: 0x00026F10 File Offset: 0x00025110
			internal string GetString()
			{
				int numBytes = this._numBytes;
				this.FlushBytes();
				int numChars = this._numChars;
				char[] charBuffer = this._charBuffer;
				string text;
				return text;
			}

			// Token: 0x04000A28 RID: 2600
			private int _bufferSize;

			// Token: 0x04000A29 RID: 2601
			private int _numChars;

			// Token: 0x04000A2A RID: 2602
			private char[] _charBuffer;

			// Token: 0x04000A2B RID: 2603
			private int _numBytes;

			// Token: 0x04000A2C RID: 2604
			private byte[] _byteBuffer;

			// Token: 0x04000A2D RID: 2605
			private Encoding _encoding;
		}

		// Token: 0x020001E2 RID: 482
		private static class HtmlEntities
		{
			// Token: 0x06000C00 RID: 3072 RVA: 0x00026F40 File Offset: 0x00025140
			public static char Lookup(string entity)
			{
				int num;
				long num2;
				do
				{
					num = 1;
					if (num == 0)
					{
					}
				}
				while (num2 == 0L);
				if (num == 0)
				{
				}
				if (num == 0)
				{
					return;
				}
			}

			// Token: 0x06000C01 RID: 3073 RVA: 0x00026F5C File Offset: 0x0002515C
			private static long CalculateKeyValue(string s)
			{
				return 0L;
			}

			// Token: 0x06000C02 RID: 3074 RVA: 0x00026F6C File Offset: 0x0002516C
			// Note: this type is marked as 'beforefieldinit'.
			static HtmlEntities()
			{
			}

			// Token: 0x04000A2E RID: 2606
			private static readonly long[] entities;

			// Token: 0x04000A2F RID: 2607
			private static readonly char[] entities_values;
		}
	}
}
