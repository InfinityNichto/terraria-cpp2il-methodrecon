using System;
using System.Collections.Specialized;
using System.IO;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200024E RID: 590
	public sealed class HttpListenerRequest
	{
		// Token: 0x06000F15 RID: 3861 RVA: 0x0002FF3C File Offset: 0x0002E13C
		internal HttpListenerRequest(HttpListenerContext context)
		{
			this.context = context;
			if (!true)
			{
			}
			this.version = 1;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0002FF60 File Offset: 0x0002E160
		internal void SetRequestLine(string req)
		{
			int num = 1;
			if (num == 0)
			{
			}
			this.raw_url = num;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		private void CreateQueryString(string query)
		{
			if (query != null)
			{
				int stringLength = query._stringLength;
				if (stringLength != 0)
				{
					long num = 0L;
					char c = query[(int)num];
					int num2 = 1;
					string text = query.Substring(num2);
					if (stringLength == 0)
					{
					}
					string text3;
					string text2 = WebUtility.UrlDecode(text3);
					string text5;
					string text4 = WebUtility.UrlDecode(text5);
					global::System.Collections.Specialized.NameValueCollection nameValueCollection = this.query_string;
					return;
				}
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00030024 File Offset: 0x0002E224
		private static bool MaybeUri(string s)
		{
			string text;
			return HttpListenerRequest.IsPredefinedScheme(text);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0003003C File Offset: 0x0002E23C
		private static bool IsPredefinedScheme(string scheme)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00030064 File Offset: 0x0002E264
		internal bool FinishInitialization()
		{
			string userHostName = this.UserHostName;
			Version version = this.version;
			if (userHostName != null && userHostName._stringLength != 0)
			{
				bool flag = HttpListenerRequest.MaybeUri(this.raw_url.ToLowerInvariant());
				string text = this.raw_url;
				if (userHostName == null)
				{
					string text2 = this.raw_url;
					if (userHostName == null)
					{
						goto IL_004E;
					}
				}
				if (userHostName._stringLength != 0)
				{
					goto IL_0060;
				}
				IL_004E:
				IPEndPoint localEndPoint = this.context.cnc.LocalEndPoint;
				IL_0060:
				int num = 58;
				string text3;
				int num2 = text3.IndexOf((char)num);
				long num3 = 0L;
				string text4 = text3.Substring((int)num3, num2);
				HttpConnection cnc = this.context.cnc;
				bool secure = cnc.secure;
				if (cnc.LocalEndPoint._port == 0)
				{
				}
				string query = this.url.Query;
				this.CreateQueryString(query);
				string text5 = this.raw_url;
				string scheme = this.url.Scheme;
				string authority = this.url.Authority;
				string localPath = this.url.LocalPath;
				string query2 = this.url.Query;
				global::System.Uri requestUri = HttpListenerRequestUriBuilder.GetRequestUri(text5, scheme, authority, localPath, query2);
				this.url = requestUri;
				Version version2 = this.version;
				if (this.headers["Transfer-Encoding"] == null)
				{
					goto IL_0152;
				}
				this.is_chunked = "chunked" != null;
				int num4;
				if (num4 == 0)
				{
					goto IL_0159;
				}
				HttpListenerContext httpListenerContext = this.context;
				string text6;
				this.context.error = text6;
			}
			if ("Invalid host name" != null)
			{
				goto IL_0159;
			}
			IL_0152:
			if ("Invalid host name" == null)
			{
				goto IL_0160;
			}
			IL_0159:
			int num5;
			if (num5 == 0)
			{
			}
			IL_0160:
			int num6;
			if (num6 != 0)
			{
				int num7;
				while (num7 != 0)
				{
				}
				return;
			}
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000301DC File Offset: 0x0002E3DC
		internal static string Unquote(string str)
		{
			string text;
			return text.Trim();
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000301F8 File Offset: 0x0002E3F8
		internal void AddHeader(string header)
		{
			int num = 58;
			int num2 = header.IndexOf((char)num);
			HttpListenerContext httpListenerContext = this.context;
			int num3 = 400;
			httpListenerContext.err_status = num3;
			httpListenerContext.error = "Bad Request";
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00030440 File Offset: 0x0002E640
		internal bool FlushInput()
		{
			long num = this.content_length;
			int num2 = 2048;
			long num3 = Math.Min(num, (long)num2);
			if (this.is_chunked)
			{
				Stream inputStream = this.InputStream;
				Stream inputStream2 = this.InputStream;
				return;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00030488 File Offset: 0x0002E688
		public string[] AcceptTypes
		{
			get
			{
				return this.accept_types;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x0003049C File Offset: 0x0002E69C
		public int ClientCertificateError
		{
			get
			{
				HttpConnection cnc;
				global::System.Security.Cryptography.X509Certificates.X509Certificate2 client_cert;
				do
				{
					cnc = this.context.cnc;
					client_cert = cnc.client_cert;
				}
				while (client_cert == null);
				if (cnc.client_cert_errors == null || client_cert != null)
				{
					return;
				}
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x000304CC File Offset: 0x0002E6CC
		public Encoding ContentEncoding
		{
			get
			{
				Encoding @default;
				if (this.content_encoding == null)
				{
					@default = Encoding.Default;
					this.content_encoding = @default;
				}
				return @default;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000304F0 File Offset: 0x0002E6F0
		public long ContentLength64
		{
			get
			{
				if (this.is_chunked)
				{
				}
				return this.content_length;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0003050C File Offset: 0x0002E70C
		public string ContentType
		{
			get
			{
				return this.headers["content-type"];
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0003052C File Offset: 0x0002E72C
		public CookieCollection Cookies
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F23)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.CookieCollection System.Net.HttpListenerRequest::get_Cookies()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:CookieCollection[exp:bool](HttpListenerRequest::cookies, ldloc:HttpListenerRequest(this)))
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

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00030540 File Offset: 0x0002E740
		public bool HasEntityBody
		{
			get
			{
				long num = this.content_length;
				return true;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00030558 File Offset: 0x0002E758
		public global::System.Collections.Specialized.NameValueCollection Headers
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F25)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Collections.Specialized.NameValueCollection System.Net.HttpListenerRequest::get_Headers()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:WebHeaderCollection(var_0_06, ldfld:WebHeaderCollection(HttpListenerRequest::headers, ldloc:HttpListenerRequest(this)))
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0003056C File Offset: 0x0002E76C
		public string HttpMethod
		{
			get
			{
				return this.method;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00030580 File Offset: 0x0002E780
		public Stream InputStream
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F27)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream System.Net.HttpListenerRequest::get_InputStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001C:
	stloc:HttpConnection(var_2_27, ldfld:HttpConnection(HttpListenerContext::cnc, ldfld:HttpListenerContext(HttpListenerRequest::context, ldloc:HttpListenerRequest(this))))
	stfld:Stream(HttpListenerRequest::input_stream, ldloc:HttpListenerRequest(this), ldloc:RequestStream[exp:Stream](var_3))
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

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x000305BC File Offset: 0x0002E7BC
		[MonoTODO("Always returns false")]
		public bool IsAuthenticated
		{
			get
			{
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x000305CC File Offset: 0x0002E7CC
		public bool IsLocal
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F29)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpListenerRequest::get_IsLocal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IPEndPoint(var_0_10, callgetter:IPEndPoint(HttpConnection::get_LocalEndPoint, ldfld:HttpConnection(HttpListenerContext::cnc, ldfld:HttpListenerContext(HttpListenerRequest::context, ldloc:HttpListenerRequest(this)))))
	stloc:HttpListenerContext(var_1_17, ldfld:HttpListenerContext(HttpListenerRequest::context, ldloc:HttpListenerRequest(this)))
	stloc:IPAddress(var_2_1E, ldfld:IPAddress(IPEndPoint::_address, ldloc:IPEndPoint(var_0_10)))
	stloc:IPAddress(var_3_2F, ldfld:IPAddress(IPEndPoint::_address, callgetter:IPEndPoint(HttpConnection::get_RemoteEndPoint, ldfld:HttpConnection(HttpListenerContext::cnc, ldloc:HttpListenerContext(var_1_17)))))
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00030608 File Offset: 0x0002E808
		public bool IsSecureConnection
		{
			get
			{
				return this.context.cnc.secure;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00030628 File Offset: 0x0002E828
		public bool KeepAlive
		{
			get
			{
				if (!this.ka_set)
				{
					this.ka_set = true;
					bool flag = string.IsNullOrEmpty(this.headers["Connection"]);
					Version version = this.version;
					if ("Connection" == null)
					{
					}
					bool flag2;
					return flag2;
				}
				return this.keep_alive;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000306A4 File Offset: 0x0002E8A4
		public IPEndPoint LocalEndPoint
		{
			get
			{
				return this.context.cnc.LocalEndPoint;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000306C4 File Offset: 0x0002E8C4
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000306D8 File Offset: 0x0002E8D8
		public global::System.Collections.Specialized.NameValueCollection QueryString
		{
			get
			{
				return this.query_string;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000306EC File Offset: 0x0002E8EC
		public string RawUrl
		{
			get
			{
				return this.raw_url;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00030700 File Offset: 0x0002E900
		public IPEndPoint RemoteEndPoint
		{
			get
			{
				return this.context.cnc.RemoteEndPoint;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
		[MonoTODO("Always returns Guid.Empty")]
		public Guid RequestTraceIdentifier
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00030720 File Offset: 0x0002E920
		public global::System.Uri Url
		{
			get
			{
				return this.url;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00030734 File Offset: 0x0002E934
		public global::System.Uri UrlReferrer
		{
			get
			{
				return this.referrer;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00030748 File Offset: 0x0002E948
		public string UserAgent
		{
			get
			{
				return this.headers["user-agent"];
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00030768 File Offset: 0x0002E968
		public string UserHostAddress
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000F35)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.HttpListenerRequest::get_UserHostAddress()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:IPEndPoint(var_0_10, callgetter:IPEndPoint(HttpConnection::get_LocalEndPoint, ldfld:HttpConnection(HttpListenerContext::cnc, ldfld:HttpListenerContext(HttpListenerRequest::context, ldloc:HttpListenerRequest(this)))))
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00030788 File Offset: 0x0002E988
		public string UserHostName
		{
			get
			{
				return this.headers["host"];
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000307A8 File Offset: 0x0002E9A8
		public string[] UserLanguages
		{
			get
			{
				return this.user_languages;
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000307BC File Offset: 0x0002E9BC
		public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
		{
			/*
An exception occurred when decompiling this method (06000F38)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.Net.HttpListenerRequest::BeginGetClientCertificate(System.AsyncCallback,System.Object)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:GCCDelegate[exp:bool](HttpListenerRequest::gcc_delegate, ldloc:HttpListenerRequest(this)))
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

		// Token: 0x06000F39 RID: 3897 RVA: 0x000307D0 File Offset: 0x0002E9D0
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
		{
			/*
An exception occurred when decompiling this method (06000F39)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509Certificate2 System.Net.HttpListenerRequest::EndGetClientCertificate(System.IAsyncResult)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, logicnot:bool(ldfld:GCCDelegate[exp:bool](HttpListenerRequest::gcc_delegate, ldloc:HttpListenerRequest(this))))
}

   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1852
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1878
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.FlattenBasicBlocks(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1846
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

		// Token: 0x06000F3A RID: 3898 RVA: 0x000307E8 File Offset: 0x0002E9E8
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 GetClientCertificate()
		{
			return this.context.cnc.client_cert;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00030808 File Offset: 0x0002EA08
		[MonoTODO]
		public string ServiceName
		{
			get
			{
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
		public TransportContext TransportContext
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00030818 File Offset: 0x0002EA18
		[MonoTODO]
		public bool IsWebSocketRequest
		{
			get
			{
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00002050 File Offset: 0x00000250
		public Task<global::System.Security.Cryptography.X509Certificates.X509Certificate2> GetClientCertificateAsync()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00030828 File Offset: 0x0002EA28
		// Note: this type is marked as 'beforefieldinit'.
		static HttpListenerRequest()
		{
			Encoding ascii = Encoding.ASCII;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x00030840 File Offset: 0x0002EA40
		internal HttpListenerRequest()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000C32 RID: 3122
		private string[] accept_types;

		// Token: 0x04000C33 RID: 3123
		private Encoding content_encoding;

		// Token: 0x04000C34 RID: 3124
		private long content_length;

		// Token: 0x04000C35 RID: 3125
		private bool cl_set;

		// Token: 0x04000C36 RID: 3126
		private CookieCollection cookies;

		// Token: 0x04000C37 RID: 3127
		private WebHeaderCollection headers;

		// Token: 0x04000C38 RID: 3128
		private string method;

		// Token: 0x04000C39 RID: 3129
		private Stream input_stream;

		// Token: 0x04000C3A RID: 3130
		private Version version;

		// Token: 0x04000C3B RID: 3131
		private global::System.Collections.Specialized.NameValueCollection query_string;

		// Token: 0x04000C3C RID: 3132
		private string raw_url;

		// Token: 0x04000C3D RID: 3133
		private global::System.Uri url;

		// Token: 0x04000C3E RID: 3134
		private global::System.Uri referrer;

		// Token: 0x04000C3F RID: 3135
		private string[] user_languages;

		// Token: 0x04000C40 RID: 3136
		private HttpListenerContext context;

		// Token: 0x04000C41 RID: 3137
		private bool is_chunked;

		// Token: 0x04000C42 RID: 3138
		private bool ka_set;

		// Token: 0x04000C43 RID: 3139
		private bool keep_alive;

		// Token: 0x04000C44 RID: 3140
		private HttpListenerRequest.GCCDelegate gcc_delegate;

		// Token: 0x04000C45 RID: 3141
		private static byte[] _100continue;

		// Token: 0x04000C46 RID: 3142
		private static char[] separators;

		// Token: 0x0200024F RID: 591
		private class Context : TransportContext
		{
			// Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
			public override global::System.Security.Authentication.ExtendedProtection.ChannelBinding GetChannelBinding(global::System.Security.Authentication.ExtendedProtection.ChannelBindingKind kind)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000F42 RID: 3906 RVA: 0x00030854 File Offset: 0x0002EA54
			public Context()
			{
			}
		}

		// Token: 0x02000250 RID: 592
		private sealed class GCCDelegate : MulticastDelegate
		{
			// Token: 0x06000F43 RID: 3907 RVA: 0x00030868 File Offset: 0x0002EA68
			public GCCDelegate(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x06000F44 RID: 3908 RVA: 0x000308BC File Offset: 0x0002EABC
			public global::System.Security.Cryptography.X509Certificates.X509Certificate2 Invoke()
			{
				/*
An exception occurred when decompiling this method (06000F44)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509Certificate2 System.Net.HttpListenerRequest/GCCDelegate::Invoke()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:native int(var_0_06, ldfld:native int(Delegate::method_code, ldloc:GCCDelegate[exp:Delegate](this)))
	stloc:native int(var_1_0D, ldfld:native int(Delegate::invoke_impl, ldloc:GCCDelegate[exp:Delegate](this)))
	stloc:native int(var_2_14, ldfld:native int(Delegate::method, ldloc:GCCDelegate[exp:Delegate](this)))
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

			// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
			public IAsyncResult BeginInvoke(AsyncCallback callback, object @object)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
			public global::System.Security.Cryptography.X509Certificates.X509Certificate2 EndInvoke(IAsyncResult result)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}
	}
}
