using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x02000090 RID: 144
	internal static class UriHelper
	{
		// Token: 0x06000280 RID: 640 RVA: 0x0000A128 File Offset: 0x00008328
		internal unsafe static bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase)
		{
			/*
An exception occurred when decompiling this method (06000280)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.UriHelper::TestForSubPath(System.Char*,System.UInt16,System.Char*,System.UInt16,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_2_09, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:CultureInfo(var_5_12, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
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

		// Token: 0x06000281 RID: 641 RVA: 0x0000A150 File Offset: 0x00008350
		internal static char[] EscapeString(string input, int start, int end, char[] dest, int destPos, bool isUriString, char force1, char force2, char rsvd)
		{
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			char c;
			return c;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000A1A0 File Offset: 0x000083A0
		private unsafe static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, int destPos, int prevInputPos)
		{
			/*
An exception occurred when decompiling this method (06000282)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char[] System.UriHelper::EnsureDestinationSize(System.Char*,System.Char[],System.Int32,System.Int16,System.Int16,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	brtrue(IL_0000, logicnot:bool(ldloc:char*[exp:bool](pStr)))
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

		// Token: 0x06000283 RID: 643 RVA: 0x0000A1B4 File Offset: 0x000083B4
		internal static char[] UnescapeString(string input, int start, int end, char[] dest, int destPosition, char rsvd1, char rsvd2, char rsvd3, global::System.UnescapeMode unescapeMode, global::System.UriParser syntax, bool isQuery)
		{
			int num = 1;
			int offsetToStringData = RuntimeHelpers.OffsetToStringData;
			if (num == 0)
			{
			}
			char[] array;
			return array;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000A1D0 File Offset: 0x000083D0
		internal unsafe static char[] UnescapeString(char* pStr, int start, int end, char[] dest, int destPosition, char rsvd1, char rsvd2, char rsvd3, global::System.UnescapeMode unescapeMode, global::System.UriParser syntax, bool isQuery)
		{
			if (!true)
			{
			}
			int num = 10;
			if (end != 0)
			{
			}
			if (num != 0)
			{
				return global::System.UriHelper.EscapedAscii('\0', (char)end);
			}
			string @string = SR.GetString("Invalid URI: There is an invalid sequence in the string.");
			string string2 = SR.GetString("Invalid URI: There is an invalid sequence in the string.");
			throw new InvalidCastException();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000A27C File Offset: 0x0000847C
		internal unsafe static void MatchUTF8Sequence(char* pDest, char[] dest, int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing)
		{
			int num = 1;
			if (unescapedChars != null && num != 0)
			{
				return;
			}
			Encoding utf = Encoding.UTF8;
			CodePageDataItem dataItem = utf.dataItem;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000A2FC File Offset: 0x000084FC
		internal static void EscapeAsciiChar(char ch, char[] to, int pos)
		{
			int num = 1;
			int num2 = 37;
			pos.m_value = num;
			if (num2 == 0)
			{
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000A318 File Offset: 0x00008518
		internal static char EscapedAscii(char digit, char next)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000A334 File Offset: 0x00008534
		internal static bool IsNotSafeForUnescape(char ch)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A344 File Offset: 0x00008544
		private static bool IsReservedUnreservedOrHash(char c)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A35C File Offset: 0x0000855C
		internal static bool IsUnreserved(char c)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000A378 File Offset: 0x00008578
		internal static bool Is3986Unreserved(char c)
		{
			if (!true)
			{
			}
			return true;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000A38C File Offset: 0x0000858C
		// Note: this type is marked as 'beforefieldinit'.
		static UriHelper()
		{
		}

		// Token: 0x04000222 RID: 546
		private static readonly char[] HexUpperChars;
	}
}
