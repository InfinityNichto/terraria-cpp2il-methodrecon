using System;
using System.IO;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000156 RID: 342
	public class FtpWebResponse : WebResponse, IDisposable
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x0001E730 File Offset: 0x0001C930
		internal FtpWebResponse(Stream responseStream, long contentLength, global::System.Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			this._statusCode = statusCode;
			this._statusLine = statusLine;
			this._lastModified = lastModified;
			this._bannerMessage = bannerMessage;
			this._responseStream = responseStream;
			this._responseUri = responseUri;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x0001E77C File Offset: 0x0001C97C
		internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
		{
			this._statusCode = statusCode;
			this._statusLine = statusLine;
			this._exitMessage = exitMessage;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0001E7A0 File Offset: 0x0001C9A0
		public override Stream GetResponseStream()
		{
			/*
An exception occurred when decompiling this method (06000899)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream System.Net.FtpWebResponse::GetResponseStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:Stream[exp:bool](FtpWebResponse::_responseStream, ldloc:FtpWebResponse(this)))
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

		// Token: 0x0600089A RID: 2202 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
		internal void SetResponseStream(Stream stream)
		{
			if (stream != null)
			{
				if (!true)
				{
				}
				this._responseStream = stream;
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
		public override void Close()
		{
			if (!true)
			{
			}
			bool isEnabled = NetEventSource.IsEnabled;
			if (!true)
			{
			}
			if (this._responseStream != null)
			{
			}
			bool isEnabled2 = NetEventSource.IsEnabled;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		public override long ContentLength
		{
			get
			{
				return this._contentLength;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0001E810 File Offset: 0x0001CA10
		public override WebHeaderCollection Headers
		{
			get
			{
				while (this._ftpRequestHeaders != null)
				{
				}
				if (this._ftpRequestHeaders != null)
				{
				}
				long num = 0L;
				Monitor.Exit(this);
				if (num == 0L)
				{
					return this._ftpRequestHeaders;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0001E860 File Offset: 0x0001CA60
		public override bool SupportsHeaders
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0001E870 File Offset: 0x0001CA70
		public override global::System.Uri ResponseUri
		{
			get
			{
				return this._responseUri;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0001E884 File Offset: 0x0001CA84
		public FtpStatusCode StatusCode
		{
			get
			{
				return this._statusCode;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0001E898 File Offset: 0x0001CA98
		public string StatusDescription
		{
			get
			{
				return this._statusLine;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0001E8AC File Offset: 0x0001CAAC
		public DateTime LastModified
		{
			get
			{
				DateTime lastModified = this._lastModified;
				DateTime dateTime;
				return dateTime;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0001E8C4 File Offset: 0x0001CAC4
		public string BannerMessage
		{
			get
			{
				return this._bannerMessage;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
		public string WelcomeMessage
		{
			get
			{
				return this._welcomeMessage;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0001E8EC File Offset: 0x0001CAEC
		public string ExitMessage
		{
			get
			{
				return this._exitMessage;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0001E900 File Offset: 0x0001CB00
		internal FtpWebResponse()
		{
			throw new NotSupportedException();
		}

		// Token: 0x040006EF RID: 1775
		internal Stream _responseStream;

		// Token: 0x040006F0 RID: 1776
		private long _contentLength;

		// Token: 0x040006F1 RID: 1777
		private global::System.Uri _responseUri;

		// Token: 0x040006F2 RID: 1778
		private FtpStatusCode _statusCode;

		// Token: 0x040006F3 RID: 1779
		private string _statusLine;

		// Token: 0x040006F4 RID: 1780
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x040006F5 RID: 1781
		private DateTime _lastModified;

		// Token: 0x040006F6 RID: 1782
		private string _bannerMessage;

		// Token: 0x040006F7 RID: 1783
		private string _welcomeMessage;

		// Token: 0x040006F8 RID: 1784
		private string _exitMessage;

		// Token: 0x02000157 RID: 343
		internal sealed class EmptyStream : MemoryStream
		{
			// Token: 0x060008A7 RID: 2215 RVA: 0x0001E914 File Offset: 0x0001CB14
			internal EmptyStream()
			{
				if (!true)
				{
				}
			}
		}
	}
}
