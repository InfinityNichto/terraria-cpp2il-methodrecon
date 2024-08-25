using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000192 RID: 402
	internal sealed class HttpListenerRequestUriBuilder
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x00022C74 File Offset: 0x00020E74
		static HttpListenerRequestUriBuilder()
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00022C8C File Offset: 0x00020E8C
		private HttpListenerRequestUriBuilder(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
		{
			this.cookedUriScheme = cookedUriScheme;
			if (!true)
			{
			}
			string text = HttpListenerRequestUriBuilder.AddSlashToAsteriskOnlyPath(cookedUriPath);
			this.cookedUriPath = text;
			if (cookedUriQuery != null)
			{
				this.cookedUriQuery = cookedUriQuery;
				return;
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00022CC8 File Offset: 0x00020EC8
		public static global::System.Uri GetRequestUri(string rawUri, string cookedUriScheme, string cookedUriHost, string cookedUriPath, string cookedUriQuery)
		{
			global::System.Uri uri;
			return uri;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00022CD8 File Offset: 0x00020ED8
		private global::System.Uri Build()
		{
			this.BuildRequestUriUsingCookedPath();
			global::System.Uri uri = this.requestUri;
			this.BuildRequestUriUsingRawPath();
			this.BuildRequestUriUsingRawPath();
			global::System.Uri uri2 = this.requestUri;
			this.BuildRequestUriUsingCookedPath();
			return this.requestUri;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00022D14 File Offset: 0x00020F14
		private void BuildRequestUriUsingCookedPath()
		{
			string text = this.cookedUriScheme;
			if ((text == null || text != null) && (text == null || text != null))
			{
				string text2 = this.cookedUriHost;
				if (text2 == null || text2 != null)
				{
					string text3 = this.cookedUriPath;
					if (text3 == null || text3 != null)
					{
						string text4 = this.cookedUriQuery;
						if (text4 == null || text4 != null)
						{
							return;
						}
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00022DC0 File Offset: 0x00020FC0
		private void BuildRequestUriUsingRawPath()
		{
			int num = 1;
			string text = this.rawUri;
			if (num == 0)
			{
			}
			string path = HttpListenerRequestUriBuilder.GetPath(text);
			this.rawPath = path;
			string text2 = this.rawPath;
			string text3 = this.cookedUriScheme;
			if ((text3 == null || text3 != null) && (text3 == null || text3 != null))
			{
				string text4 = this.cookedUriHost;
				if ((text4 == null || text4 != null) && ("/" == null || "/" != null))
				{
					string text5 = this.cookedUriQuery;
					if (text5 == null || text5 != null)
					{
						return;
					}
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00022EB8 File Offset: 0x000210B8
		private static Encoding GetEncoding(HttpListenerRequestUriBuilder.EncodingType type)
		{
			if (!true)
			{
			}
			return 1;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00022ECC File Offset: 0x000210CC
		private HttpListenerRequestUriBuilder.ParsingResult BuildRequestUriUsingRawPath(Encoding encoding)
		{
			int num = 1;
			string text = this.cookedUriScheme;
			StringBuilder stringBuilder = this.requestUriString;
			if (num == 0)
			{
			}
			StringBuilder stringBuilder2 = stringBuilder.Append(text);
			StringBuilder stringBuilder3 = this.requestUriString;
			string text2 = this.cookedUriHost;
			StringBuilder stringBuilder4 = stringBuilder3.Append(text2);
			if (this.ParseRawPath(encoding) == HttpListenerRequestUriBuilder.ParsingResult.Success)
			{
				string text3 = this.cookedUriQuery;
				StringBuilder stringBuilder5 = this.requestUriString.Append(text3);
				StringBuilder stringBuilder6 = this.requestUriString;
			}
			string text4 = this.rawPath;
			if ((text4 == null || text4 != null) && (encoding == null || encoding != null))
			{
				bool on = Logging.On;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00022F60 File Offset: 0x00021160
		private HttpListenerRequestUriBuilder.ParsingResult ParseRawPath(Encoding encoding)
		{
			/*
An exception occurred when decompiling this method (06000A56)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.HttpListenerRequestUriBuilder/ParsingResult System.Net.HttpListenerRequestUriBuilder::ParseRawPath(System.Text.Encoding)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(HttpListenerRequestUriBuilder::rawPath, ldloc:HttpListenerRequestUriBuilder(this)))
	stloc:int32(var_1_0D, ldfld:int32(string::_stringLength, ldloc:string(var_0_06)))
	stloc:int64(var_2_0F, ldc.i4:int64(0))
	stloc:char(var_3_17, callgetter:char(string::get_Chars, ldloc:string(var_0_06), ldloc:int64[exp:int32](var_2_0F)))
	stloc:char(var_4_24, callgetter:char(string::get_Chars, ldfld:string(HttpListenerRequestUriBuilder::rawPath, ldloc:HttpListenerRequestUriBuilder(this)), ldloc:int64[exp:int32](var_2_0F)))
	stloc:bool(var_5_2D, call:bool(HttpListenerRequestUriBuilder::EmptyDecodeAndAppendRawOctetsList, ldloc:HttpListenerRequestUriBuilder(this), ldloc:Encoding(encoding)))
	stloc:string(var_6_35, ldfld:string(HttpListenerRequestUriBuilder::rawPath, ldloc:HttpListenerRequestUriBuilder(this)))
	stloc:bool(var_8_3F, call:bool(HttpListenerRequestUriBuilder::AppendUnicodeCodePointValuePercentEncoded, ldloc:HttpListenerRequestUriBuilder(this), ldloc:string(var_7)))
	stloc:bool(var_9_48, call:bool(HttpListenerRequestUriBuilder::EmptyDecodeAndAppendRawOctetsList, ldloc:HttpListenerRequestUriBuilder(this), ldloc:Encoding(encoding)))
	stloc:StringBuilder(var_10_57, call:StringBuilder(StringBuilder::Append, ldfld:StringBuilder(HttpListenerRequestUriBuilder::requestUriString, ldloc:HttpListenerRequestUriBuilder(this)), ldloc:bool[exp:char](var_8_3F)))
	stloc:string(var_11_5F, ldfld:string(HttpListenerRequestUriBuilder::rawPath, ldloc:HttpListenerRequestUriBuilder(this)))
	stloc:int32(var_12_62, ldc.i4:int32(2))
	stloc:string(var_13_6F, call:string(string::Substring, ldloc:string(var_11_5F), ldloc:bool[exp:int32](var_8_3F), ldloc:int32(var_12_62)))
	stloc:int32(var_15_7C, ldfld:int32(string::_stringLength, ldfld:string(HttpListenerRequestUriBuilder::rawPath, ldloc:HttpListenerRequestUriBuilder(this))))
	stloc:bool(var_16_85, call:bool(HttpListenerRequestUriBuilder::EmptyDecodeAndAppendRawOctetsList, ldloc:HttpListenerRequestUriBuilder(this), ldloc:Encoding(encoding)))
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

		// Token: 0x06000A57 RID: 2647 RVA: 0x00022FFC File Offset: 0x000211FC
		private bool AppendUnicodeCodePointValuePercentEncoded(string codePoint)
		{
			string text = char.ConvertFromUtf32(43163648);
			StringBuilder stringBuilder = this.requestUriString;
			if (codePoint == null || codePoint != null)
			{
				bool on = Logging.On;
				if (codePoint == null || codePoint != null)
				{
					return "Can't convert percent encoded value '{0}'." != null;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002050 File Offset: 0x00000250
		private bool AddPercentEncodedOctetToRawOctetsList(Encoding encoding, string escapedCharacter)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00023054 File Offset: 0x00021254
		private bool EmptyDecodeAndAppendRawOctetsList(Encoding encoding)
		{
			if (this.rawOctets._size != 0)
			{
				StringBuilder stringBuilder = this.requestUriString;
				List<byte> list = this.rawOctets;
				HttpListenerRequestUriBuilder.AppendOctetsPercentEncoded(stringBuilder, list);
				List<byte> list2 = this.rawOctets;
				int version = list2._version;
				list2._syncRoot = version;
			}
			string octetsAsString = HttpListenerRequestUriBuilder.GetOctetsAsString(this.rawOctets);
			if (octetsAsString == null || octetsAsString != null)
			{
				return "Can't convert bytes '{0}' into UTF-16 characters: {1}" != null;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x000230DC File Offset: 0x000212DC
		private static void AppendOctetsPercentEncoded(StringBuilder target, IEnumerable<byte> octets)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002313C File Offset: 0x0002133C
		private static string GetOctetsAsString(IEnumerable<byte> octets)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			long num = 0L;
			int num2 = 6;
			if (num != 0L || num2 == 0)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00023174 File Offset: 0x00021374
		private static string GetPath(string uriString)
		{
			long num = 0L;
			int num2 = 63;
			long num3 = 0L;
			string text;
			int num4 = text.IndexOf((char)num2);
			int stringLength = text._stringLength;
			return HttpListenerRequestUriBuilder.AddSlashToAsteriskOnlyPath(text.Substring((int)num, (int)num3));
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x000231BC File Offset: 0x000213BC
		private static string AddSlashToAsteriskOnlyPath(string path)
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x000231CC File Offset: 0x000213CC
		private void LogWarning(string methodName, string message, params object[] args)
		{
			bool on = Logging.On;
		}

		// Token: 0x040007F2 RID: 2034
		private static readonly bool useCookedRequestUrl;

		// Token: 0x040007F3 RID: 2035
		private static readonly Encoding utf8Encoding;

		// Token: 0x040007F4 RID: 2036
		private static readonly Encoding ansiEncoding;

		// Token: 0x040007F5 RID: 2037
		private readonly string rawUri;

		// Token: 0x040007F6 RID: 2038
		private readonly string cookedUriScheme;

		// Token: 0x040007F7 RID: 2039
		private readonly string cookedUriHost;

		// Token: 0x040007F8 RID: 2040
		private readonly string cookedUriPath;

		// Token: 0x040007F9 RID: 2041
		private readonly string cookedUriQuery;

		// Token: 0x040007FA RID: 2042
		private StringBuilder requestUriString;

		// Token: 0x040007FB RID: 2043
		private List<byte> rawOctets;

		// Token: 0x040007FC RID: 2044
		private string rawPath;

		// Token: 0x040007FD RID: 2045
		private global::System.Uri requestUri;

		// Token: 0x02000193 RID: 403
		private enum ParsingResult
		{
			// Token: 0x040007FF RID: 2047
			Success,
			// Token: 0x04000800 RID: 2048
			InvalidString,
			// Token: 0x04000801 RID: 2049
			EncodingError
		}

		// Token: 0x02000194 RID: 404
		private enum EncodingType
		{
			// Token: 0x04000803 RID: 2051
			Primary,
			// Token: 0x04000804 RID: 2052
			Secondary
		}
	}
}
