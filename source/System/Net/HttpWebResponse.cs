using System;
using System.IO;
using System.Runtime.Serialization;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200025D RID: 605
	[Serializable]
	public class HttpWebResponse : WebResponse, ISerializable, IDisposable
	{
		// Token: 0x0600103A RID: 4154 RVA: 0x000335A8 File Offset: 0x000317A8
		public HttpWebResponse()
		{
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000335BC File Offset: 0x000317BC
		internal HttpWebResponse(global::System.Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
		{
			this.uri = uri;
			this.method = method;
			this.statusCode = status;
			string text = HttpStatusDescription.Get(status);
			this.statusDescription = text;
			this.webHeaders = headers;
			if (!true)
			{
			}
			this.version = 1;
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00033604 File Offset: 0x00031804
		internal HttpWebResponse(global::System.Uri uri, string method, WebResponseStream stream, CookieContainer container)
		{
			this.uri = uri;
			this.method = method;
			this.stream = stream;
			if (stream.<Headers>k__BackingField == null)
			{
			}
			Version <Version>k__BackingField = stream.<Version>k__BackingField;
			this.version = <Version>k__BackingField;
			HttpStatusCode <StatusCode>k__BackingField = stream.<StatusCode>k__BackingField;
			this.statusCode = <StatusCode>k__BackingField;
			WebHeaderCollection webHeaderCollection;
			if (stream.<StatusDescription>k__BackingField == null)
			{
				string text = HttpStatusDescription.Get(<StatusCode>k__BackingField);
				webHeaderCollection = this.webHeaders;
			}
			this.contentLength = (long)<StatusCode>k__BackingField;
			bool flag = string.IsNullOrEmpty(webHeaderCollection["Content-Length"]);
			if (container != null)
			{
				this.cookie_container = container;
				this.FillCookies();
			}
			string text2 = this.webHeaders["Content-Encoding"];
			bool flag2 = text2 == "gzip";
			DecompressionMethods auto_decomp = stream.<Request>k__BackingField.auto_decomp;
			bool flag3 = text2 == "deflate";
			DecompressionMethods auto_decomp2 = stream.<Request>k__BackingField.auto_decomp;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000336F0 File Offset: 0x000318F0
		[Obsolete("Serialization is obsoleted for this type", false)]
		protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			int num = 1;
			base..ctor();
			if (num == 0)
			{
			}
			Type type;
			object value = serializationInfo.GetValue("uri", type);
			if (value != null)
			{
				this.uri = value;
				return;
			}
			long @int = serializationInfo.GetInt64("contentLength");
			this.contentLength = @int;
			string @string = serializationInfo.GetString("contentType");
			this.contentType = @string;
			string string2 = serializationInfo.GetString("method");
			this.method = string2;
			string string3 = serializationInfo.GetString("statusDescription");
			this.statusDescription = string3;
			object obj;
			if (obj != null)
			{
				this.cookieCollection = obj;
				return;
			}
			Type type2;
			object value2 = serializationInfo.GetValue("version", type2);
			if (value2 != null)
			{
				this.version = value2;
				return;
			}
			Type type3;
			object value3 = serializationInfo.GetValue("statusCode", type3);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000337B0 File Offset: 0x000319B0
		public string CharacterSet
		{
			get
			{
				if (this != null)
				{
					string text;
					return text;
				}
				return "ISO-8859-1";
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x000337CC File Offset: 0x000319CC
		public string ContentEncoding
		{
			get
			{
				this.CheckDisposed();
				return this.webHeaders["Content-Encoding"];
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x000337F0 File Offset: 0x000319F0
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00033804 File Offset: 0x00031A04
		public override string ContentType
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001041)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.HttpWebResponse::get_ContentType()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_1E, callgetter:string(NameValueCollection::get_Item, ldfld:WebHeaderCollection[exp:NameValueCollection](HttpWebResponse::webHeaders, ldloc:HttpWebResponse(this)), ldstr:string("Content-Type")))
	stfld:string(HttpWebResponse::contentType, ldloc:HttpWebResponse(this), ldloc:string(var_0_1E))
	brtrue(IL_0000, ldloc:string[exp:bool](var_0_1E))
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
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0003383C File Offset: 0x00031A3C
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00033858 File Offset: 0x00031A58
		public virtual CookieCollection Cookies
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001042)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.CookieCollection System.Net.HttpWebResponse::get_Cookies()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	call:void(HttpWebResponse::CheckDisposed, ldloc:HttpWebResponse(this))
	brtrue(IL_0000, ldfld:CookieCollection[exp:bool](HttpWebResponse::cookieCollection, ldloc:HttpWebResponse(this)))
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
			set
			{
				this.CheckDisposed();
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0003386C File Offset: 0x00031A6C
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.webHeaders;
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		private static Exception GetMustImplement()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x00033880 File Offset: 0x00031A80
		[MonoTODO]
		public override bool IsMutuallyAuthenticated
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001046)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpWebResponse::get_IsMutuallyAuthenticated()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Exception(var_0_05, call:Exception(HttpWebResponse::GetMustImplement))
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00033894 File Offset: 0x00031A94
		public DateTime LastModified
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001047)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Net.HttpWebResponse::get_LastModified()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(HttpWebResponse::CheckDisposed, ldloc:HttpWebResponse(this))
	stloc:DateTime(var_0_1B, call:DateTime(MonoHttpDate::Parse, callgetter:string(NameValueCollection::get_Item, ldfld:WebHeaderCollection[exp:NameValueCollection](HttpWebResponse::webHeaders, ldloc:HttpWebResponse(this)), ldstr:string("Last-Modified"))))
	stloc:DateTime(var_2_23, callgetter:DateTime(DateTime::get_Now))
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

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x000338C8 File Offset: 0x00031AC8
		public virtual string Method
		{
			get
			{
				this.CheckDisposed();
				return this.method;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x000338E4 File Offset: 0x00031AE4
		public Version ProtocolVersion
		{
			get
			{
				this.CheckDisposed();
				return this.version;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x00033900 File Offset: 0x00031B00
		public override global::System.Uri ResponseUri
		{
			get
			{
				this.CheckDisposed();
				return this.uri;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0003391C File Offset: 0x00031B1C
		public string Server
		{
			get
			{
				this.CheckDisposed();
				return this.webHeaders["Server"];
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x00033940 File Offset: 0x00031B40
		public virtual HttpStatusCode StatusCode
		{
			get
			{
				return this.statusCode;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00033954 File Offset: 0x00031B54
		public virtual string StatusDescription
		{
			get
			{
				this.CheckDisposed();
				return this.statusDescription;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00033970 File Offset: 0x00031B70
		public override bool SupportsHeaders
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00033980 File Offset: 0x00031B80
		public string GetResponseHeader(string headerName)
		{
			this.CheckDisposed();
			return this.webHeaders[headerName];
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x000339A0 File Offset: 0x00031BA0
		public override Stream GetResponseStream()
		{
			/*
An exception occurred when decompiling this method (06001050)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream System.Net.HttpWebResponse::GetResponseStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	brtrue(IL_0000, ldstr:string[exp:bool]("HEAD"))
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

		// Token: 0x06001051 RID: 4177 RVA: 0x000339D0 File Offset: 0x00031BD0
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x000339E0 File Offset: 0x00031BE0
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			global::System.Uri uri = this.uri;
			serializationInfo.AddValue("uri", uri);
			long num = this.contentLength;
			serializationInfo.AddValue("contentLength", num);
			string text = this.contentType;
			serializationInfo.AddValue("contentType", text);
			string text2 = this.method;
			serializationInfo.AddValue("method", text2);
			string text3 = this.statusDescription;
			serializationInfo.AddValue("statusDescription", text3);
			CookieCollection cookieCollection = this.cookieCollection;
			serializationInfo.AddValue("cookieCollection", cookieCollection);
			Version version = this.version;
			serializationInfo.AddValue("version", version);
			HttpStatusCode httpStatusCode = this.statusCode;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00033A80 File Offset: 0x00031C80
		public override void Close()
		{
			if (this != null)
			{
				return;
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00033A94 File Offset: 0x00031C94
		void IDisposable.Dispose()
		{
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00033AA4 File Offset: 0x00031CA4
		protected override void Dispose(bool disposing)
		{
			this.disposed = true;
			base.Dispose(true);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00033AC0 File Offset: 0x00031CC0
		private void CheckDisposed()
		{
			/*
An exception occurred when decompiling this method (06001056)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpWebResponse::CheckDisposed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Type(var_0_0F, call:Type(object::GetType, ldloc:HttpWebResponse[exp:object](this)))
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

		// Token: 0x06001057 RID: 4183 RVA: 0x00033ADC File Offset: 0x00031CDC
		private void FillCookies()
		{
			WebHeaderCollection webHeaderCollection = this.webHeaders;
			if (webHeaderCollection != null)
			{
				if (webHeaderCollection != null)
				{
					CookieContainer cookieContainer = this.cookie_container;
					global::System.Uri uri = this.uri;
					return;
				}
				long num = 0L;
				if (this.webHeaders != null)
				{
					CookieContainer cookieContainer2 = this.cookie_container;
					global::System.Uri uri2 = this.uri;
					int num2;
					if (num != 0L && num2 != 0)
					{
						return;
					}
				}
			}
		}

		// Token: 0x04000CD4 RID: 3284
		private global::System.Uri uri;

		// Token: 0x04000CD5 RID: 3285
		private WebHeaderCollection webHeaders;

		// Token: 0x04000CD6 RID: 3286
		private CookieCollection cookieCollection;

		// Token: 0x04000CD7 RID: 3287
		private string method;

		// Token: 0x04000CD8 RID: 3288
		private Version version;

		// Token: 0x04000CD9 RID: 3289
		private HttpStatusCode statusCode;

		// Token: 0x04000CDA RID: 3290
		private string statusDescription;

		// Token: 0x04000CDB RID: 3291
		private long contentLength;

		// Token: 0x04000CDC RID: 3292
		private string contentType;

		// Token: 0x04000CDD RID: 3293
		private CookieContainer cookie_container;

		// Token: 0x04000CDE RID: 3294
		private bool disposed;

		// Token: 0x04000CDF RID: 3295
		private Stream stream;
	}
}
