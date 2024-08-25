using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Net
{
	// Token: 0x02000222 RID: 546
	internal static class UnsafeNclNativeMethods
	{
		// Token: 0x02000223 RID: 547
		internal static class HttpApi
		{
			// Token: 0x06000DDA RID: 3546 RVA: 0x0002C470 File Offset: 0x0002A670
			// Note: this type is marked as 'beforefieldinit'.
			static HttpApi()
			{
				if (("Cache-Control" == null || "Cache-Control" != null) && ("Connection" == null || "Connection" != null) && ("Date" == null || "Date" != null) && ("Keep-Alive" == null || "Keep-Alive" != null) && ("Pragma" == null || "Pragma" != null) && ("Pragma" == null || "Pragma" != null) && ("Transfer-Encoding" == null || "Transfer-Encoding" != null) && ("Upgrade" == null || "Upgrade" != null) && ("Via" == null || "Via" != null) && ("Warning" == null || "Warning" != null) && ("Content-Length" == null || "Content-Length" != null) && ("Content-Type" == null || "Content-Type" != null) && ("Content-Encoding" == null || "Content-Encoding" != null) && ("Content-Language" == null || "Content-Language" != null) && ("Content-Location" == null || "Content-Location" != null) && ("Content-MD5" == null || "Content-MD5" != null) && ("Content-Range" == null || "Content-Range" != null) && ("Expires" == null || "Expires" != null) && ("Last-Modified" == null || "Last-Modified" != null) && ("Accept-Ranges" == null || "Accept-Ranges" != null) && ("Age" == null || "Age" != null) && ("ETag" == null || "ETag" != null) && ("Location" == null || "Location" != null) && ("Proxy-Authenticate" == null || "Proxy-Authenticate" != null) && ("Retry-After" == null || "Retry-After" != null) && ("Server" == null || "Server" != null) && ("Set-Cookie" == null || "Set-Cookie" != null) && ("Vary" == null || "Vary" != null) && ("WWW-Authenticate" == null || "WWW-Authenticate" != null))
				{
					return;
				}
				throw new ArrayTypeMismatchException();
			}

			// Token: 0x04000B80 RID: 2944
			private const int HttpHeaderRequestMaximum = 41;

			// Token: 0x04000B81 RID: 2945
			private const int HttpHeaderResponseMaximum = 30;

			// Token: 0x04000B82 RID: 2946
			private static string[] m_Strings;

			// Token: 0x02000224 RID: 548
			internal static class HTTP_REQUEST_HEADER_ID
			{
				// Token: 0x06000DDB RID: 3547 RVA: 0x0000205E File Offset: 0x0000025E
				internal static string ToString(int position)
				{
					return null;
				}

				// Token: 0x06000DDC RID: 3548 RVA: 0x0000205C File Offset: 0x0000025C
				// Note: this type is marked as 'beforefieldinit'.
				static HTTP_REQUEST_HEADER_ID()
				{
				}

				// Token: 0x04000B83 RID: 2947
				private static string[] m_Strings;
			}

			// Token: 0x02000225 RID: 549
			internal static class HTTP_RESPONSE_HEADER_ID
			{
				// Token: 0x06000DDD RID: 3549 RVA: 0x0000205C File Offset: 0x0000025C
				static HTTP_RESPONSE_HEADER_ID()
				{
				}

				// Token: 0x06000DDE RID: 3550 RVA: 0x0002C65C File Offset: 0x0002A85C
				internal static int IndexOfKnownHeader(string HeaderName)
				{
					return 0;
				}

				// Token: 0x06000DDF RID: 3551 RVA: 0x0000205E File Offset: 0x0000025E
				internal static string ToString(int position)
				{
					return null;
				}

				// Token: 0x04000B84 RID: 2948
				private static Hashtable m_Hashtable;
			}

			// Token: 0x02000226 RID: 550
			internal enum Enum
			{
				// Token: 0x04000B86 RID: 2950
				HttpHeaderCacheControl,
				// Token: 0x04000B87 RID: 2951
				HttpHeaderConnection,
				// Token: 0x04000B88 RID: 2952
				HttpHeaderDate,
				// Token: 0x04000B89 RID: 2953
				HttpHeaderKeepAlive,
				// Token: 0x04000B8A RID: 2954
				HttpHeaderPragma,
				// Token: 0x04000B8B RID: 2955
				HttpHeaderTrailer,
				// Token: 0x04000B8C RID: 2956
				HttpHeaderTransferEncoding,
				// Token: 0x04000B8D RID: 2957
				HttpHeaderUpgrade,
				// Token: 0x04000B8E RID: 2958
				HttpHeaderVia,
				// Token: 0x04000B8F RID: 2959
				HttpHeaderWarning,
				// Token: 0x04000B90 RID: 2960
				HttpHeaderAllow,
				// Token: 0x04000B91 RID: 2961
				HttpHeaderContentLength,
				// Token: 0x04000B92 RID: 2962
				HttpHeaderContentType,
				// Token: 0x04000B93 RID: 2963
				HttpHeaderContentEncoding,
				// Token: 0x04000B94 RID: 2964
				HttpHeaderContentLanguage,
				// Token: 0x04000B95 RID: 2965
				HttpHeaderContentLocation,
				// Token: 0x04000B96 RID: 2966
				HttpHeaderContentMd5,
				// Token: 0x04000B97 RID: 2967
				HttpHeaderContentRange,
				// Token: 0x04000B98 RID: 2968
				HttpHeaderExpires,
				// Token: 0x04000B99 RID: 2969
				HttpHeaderLastModified,
				// Token: 0x04000B9A RID: 2970
				HttpHeaderAcceptRanges,
				// Token: 0x04000B9B RID: 2971
				HttpHeaderAge,
				// Token: 0x04000B9C RID: 2972
				HttpHeaderEtag,
				// Token: 0x04000B9D RID: 2973
				HttpHeaderLocation,
				// Token: 0x04000B9E RID: 2974
				HttpHeaderProxyAuthenticate,
				// Token: 0x04000B9F RID: 2975
				HttpHeaderRetryAfter,
				// Token: 0x04000BA0 RID: 2976
				HttpHeaderServer,
				// Token: 0x04000BA1 RID: 2977
				HttpHeaderSetCookie,
				// Token: 0x04000BA2 RID: 2978
				HttpHeaderVary,
				// Token: 0x04000BA3 RID: 2979
				HttpHeaderWwwAuthenticate,
				// Token: 0x04000BA4 RID: 2980
				HttpHeaderResponseMaximum,
				// Token: 0x04000BA5 RID: 2981
				HttpHeaderMaximum = 41
			}
		}

		// Token: 0x02000227 RID: 551
		internal static class SecureStringHelper
		{
			// Token: 0x06000DE0 RID: 3552 RVA: 0x0002C674 File Offset: 0x0002A874
			internal static string CreateString(SecureString secureString)
			{
				int num;
				IntPtr intPtr;
				if (num != 0)
				{
					if ("Sunfury" == null)
					{
					}
					string text = Marshal.PtrToStringUni(intPtr);
					long num2 = 0L;
					if ("Sunfury" == null)
					{
					}
					Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
					if (num2 != 0L)
					{
						throw new OutOfMemoryException();
					}
				}
				long num3 = 0L;
				if ("Sunfury" == null)
				{
				}
				Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
				if (num3 == 0L)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06000DE1 RID: 3553 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
			internal static SecureString CreateSecureString(string plainString)
			{
				/*
An exception occurred when decompiling this method (06000DE1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.SecureString System.Net.UnsafeNclNativeMethods/SecureStringHelper::CreateSecureString(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_1_0A, callgetter:int32(RuntimeHelpers::get_OffsetToStringData))
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
		}
	}
}
