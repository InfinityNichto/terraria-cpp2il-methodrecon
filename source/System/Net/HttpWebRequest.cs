using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net
{
	// Token: 0x02000255 RID: 597
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x00031458 File Offset: 0x0002F658
		static HttpWebRequest()
		{
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00031468 File Offset: 0x0002F668
		public HttpWebRequest(global::System.Uri uri)
		{
			this.pipelined = true;
			this.method = "GET";
			this.initialMethod = "GET";
			if ("GET" == null)
			{
			}
			this.version = "GET";
			this.readWriteTimeout = 37856;
			if (37856 == 0)
			{
			}
			base..ctor();
			this.requestUri = uri;
			this.actualUri = uri;
			IWebProxy internalDefaultWebProxy = WebRequest.InternalDefaultWebProxy;
			this.proxy = internalDefaultWebProxy;
			this.<ThrowOnError>k__BackingField = true;
			this.ResetAuthorization();
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000314E8 File Offset: 0x0002F6E8
		internal HttpWebRequest(global::System.Uri uri, Mono.Net.Security.MobileTlsProvider tlsProvider, [Optional] MonoTlsSettings settings)
		{
			this.tlsProvider = tlsProvider;
			this.tlsSettings = settings;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00031504 File Offset: 0x0002F704
		[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			/*
An exception occurred when decompiling this method (06000F8C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.HttpWebRequest::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stfld:bool(HttpWebRequest::keepAlive, ldloc:HttpWebRequest(this), ldc.i4:bool(1))
	stfld:int32(HttpWebRequest::maxAutoRedirect, ldloc:HttpWebRequest(this), ldc.i4:int32(50))
	stfld:string(HttpWebRequest::method, ldloc:HttpWebRequest(this), ldstr:string("GET"))
	stfld:string(HttpWebRequest::initialMethod, ldloc:HttpWebRequest(this), ldstr:string("GET"))
	stfld:bool(HttpWebRequest::pipelined, ldloc:HttpWebRequest(this), ldc.i4:bool(1))
	stfld:Version(HttpWebRequest::version, ldloc:HttpWebRequest(this), ldc.i4:int32[exp:Version](257))
	stfld:int32(HttpWebRequest::readWriteTimeout, ldloc:HttpWebRequest(this), ldc.i4:int32(37856))
	call:void(WebRequest::.ctor, ldloc:HttpWebRequest[exp:WebRequest](this))
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

		// Token: 0x06000F8D RID: 3981 RVA: 0x00031558 File Offset: 0x0002F758
		private void ResetAuthorization()
		{
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0003156C File Offset: 0x0002F76C
		private void SetSpecialHeaders(string HeaderName, string value)
		{
			if (!true)
			{
			}
			string text = WebHeaderCollection.CheckBadChars(value, true);
			this.webHeaders.RemoveInternal(HeaderName);
			if (text._stringLength != 0)
			{
				this.webHeaders.AddInternal(HeaderName, text);
				return;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x000315A8 File Offset: 0x0002F7A8
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x000315C8 File Offset: 0x0002F7C8
		public string Accept
		{
			get
			{
				return this.webHeaders["Accept"];
			}
			set
			{
				this.CheckRequestStarted();
				this.SetSpecialHeaders("Accept", value);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x000315E8 File Offset: 0x0002F7E8
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x000315FC File Offset: 0x0002F7FC
		public global::System.Uri Address
		{
			get
			{
				return this.actualUri;
			}
			internal set
			{
				this.actualUri = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00031610 File Offset: 0x0002F810
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00031624 File Offset: 0x0002F824
		public virtual bool AllowAutoRedirect
		{
			get
			{
				return this.allowAutoRedirect;
			}
			set
			{
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00031634 File Offset: 0x0002F834
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00031648 File Offset: 0x0002F848
		public virtual bool AllowWriteStreamBuffering
		{
			get
			{
				return this.allowBuffering;
			}
			set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00031658 File Offset: 0x0002F858
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x0003166C File Offset: 0x0002F86C
		public virtual bool AllowReadStreamBuffering
		{
			get
			{
				return this.allowReadStreamBuffering;
			}
			set
			{
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
		private static Exception GetMustImplement()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0003167C File Offset: 0x0002F87C
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x00031690 File Offset: 0x0002F890
		public DecompressionMethods AutomaticDecompression
		{
			get
			{
				return this.auto_decomp;
			}
			set
			{
				this.CheckRequestStarted();
				this.auto_decomp = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x000316AC File Offset: 0x0002F8AC
		internal bool InternalAllowBuffering
		{
			get
			{
				if (this.allowBuffering)
				{
					return this.MethodWithBuffer;
				}
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x000316CC File Offset: 0x0002F8CC
		private bool MethodWithBuffer
		{
			get
			{
				bool flag = this.method != "HEAD";
				bool flag2 = this.method != "GET";
				bool flag3 = this.method != "MKCOL";
				bool flag4 = this.method != "CONNECT";
				return this.method != "TRACE";
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00031730 File Offset: 0x0002F930
		internal Mono.Net.Security.MobileTlsProvider TlsProvider
		{
			get
			{
				return this.tlsProvider;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00031744 File Offset: 0x0002F944
		internal MonoTlsSettings TlsSettings
		{
			get
			{
				return this.tlsSettings;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00031758 File Offset: 0x0002F958
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x0003176C File Offset: 0x0002F96C
		public global::System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FA0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.X509Certificates.X509CertificateCollection System.Net.HttpWebRequest::get_ClientCertificates()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, ldfld:X509CertificateCollection[exp:bool](HttpWebRequest::certificates, ldloc:HttpWebRequest(this)))
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
				while (value == null)
				{
				}
				this.certificates = value;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00031784 File Offset: 0x0002F984
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x000317A4 File Offset: 0x0002F9A4
		public string Connection
		{
			get
			{
				return this.webHeaders["Connection"];
			}
			set
			{
				this.CheckRequestStarted();
				bool flag = string.IsNullOrWhiteSpace(value);
				WebHeaderCollection webHeaderCollection = this.webHeaders;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x000317E8 File Offset: 0x0002F9E8
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x000317FC File Offset: 0x0002F9FC
		public override string ConnectionGroupName
		{
			get
			{
				return this.connectionGroup;
			}
			set
			{
				this.connectionGroup = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00031810 File Offset: 0x0002FA10
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00031824 File Offset: 0x0002FA24
		public override long ContentLength
		{
			get
			{
				return this.contentLength;
			}
			set
			{
				this.CheckRequestStarted();
				this.contentLength = value;
				this.haveContentLength = true;
			}
		}

		// Token: 0x17000369 RID: 873
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00031848 File Offset: 0x0002FA48
		internal long InternalContentLength
		{
			set
			{
				this.contentLength = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0003185C File Offset: 0x0002FA5C
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00031870 File Offset: 0x0002FA70
		internal bool ThrowOnError
		{
			[CompilerGenerated]
			get
			{
				return this.<ThrowOnError>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00031880 File Offset: 0x0002FA80
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x000318A0 File Offset: 0x0002FAA0
		public override string ContentType
		{
			get
			{
				return this.webHeaders["Content-Type"];
			}
			set
			{
				this.SetSpecialHeaders("Content-Type", value);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x000318BC File Offset: 0x0002FABC
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x000318D0 File Offset: 0x0002FAD0
		public HttpContinueDelegate ContinueDelegate
		{
			get
			{
				return this.continueDelegate;
			}
			set
			{
				this.continueDelegate = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x000318E4 File Offset: 0x0002FAE4
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x000318F8 File Offset: 0x0002FAF8
		public virtual CookieContainer CookieContainer
		{
			get
			{
				return this.cookieContainer;
			}
			set
			{
				this.cookieContainer = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0003190C File Offset: 0x0002FB0C
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00031920 File Offset: 0x0002FB20
		public override ICredentials Credentials
		{
			get
			{
				return this.credentials;
			}
			set
			{
				this.credentials = value;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00031934 File Offset: 0x0002FB34
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00031970 File Offset: 0x0002FB70
		public DateTime Date
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FB3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Net.HttpWebRequest::get_Date()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CultureInfo(var_2_1B, callgetter:CultureInfo(CultureInfo::get_InvariantCulture))
	stloc:DateTime(var_3_2D, call:DateTime(DateTime::ToLocalTime, call:DateTime[exp:valuetype [mscorlib]System.DateTime&](DateTime::ParseExact, ldloc:string(var_0_10), ldstr:string("r"), ldloc:CultureInfo[exp:IFormatProvider](var_2_1B))))
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
			set
			{
				this.SetDateHeaderHelper("Date", value);
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0003198C File Offset: 0x0002FB8C
		private void SetDateHeaderHelper(string headerName, DateTime dateTime)
		{
			if (!true)
			{
			}
			string text = HttpProtocolUtils.date2string(dateTime);
			this.SetSpecialHeaders(headerName, text);
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x000319AC File Offset: 0x0002FBAC
		// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x000319BC File Offset: 0x0002FBBC
		[MonoTODO]
		public static int DefaultMaximumErrorResponseLength
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FB6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.HttpWebRequest::get_DefaultMaximumErrorResponseLength()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x000319CC File Offset: 0x0002FBCC
		// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x000319EC File Offset: 0x0002FBEC
		public string Expect
		{
			get
			{
				return this.webHeaders["Expect"];
			}
			set
			{
				this.CheckRequestStarted();
				if (value != null)
				{
					string text = value.Trim().ToLower();
					if (text != null && text._stringLength != 0)
					{
						bool flag = text == "100-continue";
						this.webHeaders.CheckUpdate("Expect", value);
						return;
					}
				}
				this.webHeaders.RemoveInternal("Expect");
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00031A48 File Offset: 0x0002FC48
		public virtual bool HaveResponse
		{
			get
			{
				return this.haveResponse;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00031A5C File Offset: 0x0002FC5C
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00031A70 File Offset: 0x0002FC70
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.webHeaders;
			}
			set
			{
				this.CheckRequestStarted();
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00031A88 File Offset: 0x0002FC88
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x00031AD8 File Offset: 0x0002FCD8
		public string Host
		{
			get
			{
				global::System.Uri uri = this.actualUri;
				if (!this.hostHasPort)
				{
					bool isDefaultPort = this.actualUri.IsDefaultPort;
					return uri.Host;
				}
				string host = uri.Host;
				string text = uri.Port.ToString();
				return host + ":" + text;
			}
			set
			{
				do
				{
					this.CheckRequestStarted();
				}
				while (value == null);
				bool flag;
				this.hostUri = flag;
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00031B04 File Offset: 0x0002FD04
		private bool TryGetHostUri(string hostName, [Out] global::System.Uri hostUri)
		{
			string scheme = this.actualUri.Scheme;
			string pathAndQuery = this.actualUri.PathAndQuery;
			return global::System.Uri.TryCreate(scheme + "://" + hostName + pathAndQuery, global::System.UriKind.Absolute, hostUri);
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x00031B40 File Offset: 0x0002FD40
		// (set) Token: 0x06000FC1 RID: 4033 RVA: 0x00031B78 File Offset: 0x0002FD78
		public DateTime IfModifiedSince
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FC0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.DateTime System.Net.HttpWebRequest::get_IfModifiedSince()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001D:
	stloc:DateTime(var_4_24, callgetter:DateTime(DateTime::get_Now))
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
			set
			{
				this.CheckRequestStarted();
				string text;
				this.webHeaders.SetInternal("If-Modified-Since", text);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x00031B9C File Offset: 0x0002FD9C
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00031BB0 File Offset: 0x0002FDB0
		public bool KeepAlive
		{
			get
			{
				return this.keepAlive;
			}
			set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x00031BC0 File Offset: 0x0002FDC0
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00031BD4 File Offset: 0x0002FDD4
		public int MaximumAutomaticRedirections
		{
			get
			{
				return this.maxAutoRedirect;
			}
			set
			{
				this.maxAutoRedirect = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00031BE8 File Offset: 0x0002FDE8
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x00031BFC File Offset: 0x0002FDFC
		[MonoTODO("Use this")]
		public int MaximumResponseHeadersLength
		{
			get
			{
				return this.maxResponseHeadersLength;
			}
			set
			{
				this.CheckRequestStarted();
				this.maxResponseHeadersLength = value;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000FC8 RID: 4040 RVA: 0x00031C18 File Offset: 0x0002FE18
		// (set) Token: 0x06000FC9 RID: 4041 RVA: 0x00031C2C File Offset: 0x0002FE2C
		[MonoTODO("Use this")]
		public static int DefaultMaximumResponseHeadersLength
		{
			get
			{
				if (!true)
				{
				}
				return 1;
			}
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x00031C3C File Offset: 0x0002FE3C
		// (set) Token: 0x06000FCB RID: 4043 RVA: 0x00031C50 File Offset: 0x0002FE50
		public int ReadWriteTimeout
		{
			get
			{
				return this.readWriteTimeout;
			}
			set
			{
				this.CheckRequestStarted();
				this.readWriteTimeout = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00031C6C File Offset: 0x0002FE6C
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00031C80 File Offset: 0x0002FE80
		[MonoTODO]
		public int ContinueTimeout
		{
			get
			{
				return this.continueTimeout;
			}
			set
			{
				this.CheckRequestStarted();
				this.continueTimeout = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x00031C9C File Offset: 0x0002FE9C
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		public string MediaType
		{
			get
			{
				return this.mediaType;
			}
			set
			{
				this.mediaType = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00031CC4 File Offset: 0x0002FEC4
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00031CD8 File Offset: 0x0002FED8
		public override string Method
		{
			get
			{
				return this.method;
			}
			set
			{
				bool flag = string.IsNullOrEmpty(value);
				bool flag2 = HttpValidationHelpers.IsInvalidMethodOrHeaderString(value);
				string text = value.ToUpperInvariant();
				this.method = text;
				bool flag3 = text != "HEAD";
				bool flag4 = this.method != "GET";
				bool flag5 = this.method != "POST";
				bool flag6 = this.method != "PUT";
				bool flag7 = this.method != "DELETE";
				bool flag8 = this.method != "CONNECT";
				bool flag9 = this.method != "TRACE";
				bool flag10 = this.method != "MKCOL";
				this.method = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00031D94 File Offset: 0x0002FF94
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00031DA8 File Offset: 0x0002FFA8
		public bool Pipelined
		{
			get
			{
				return this.pipelined;
			}
			set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00031DCC File Offset: 0x0002FFCC
		public override bool PreAuthenticate
		{
			get
			{
				return this.preAuthenticate;
			}
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00031DDC File Offset: 0x0002FFDC
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00031DF0 File Offset: 0x0002FFF0
		public Version ProtocolVersion
		{
			get
			{
				return this.version;
			}
			set
			{
				if (!true)
				{
				}
				bool flag = value != value;
				if (!true)
				{
				}
				bool flag2 = value != value;
				this.force_version = true;
				this.version = value;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00031E24 File Offset: 0x00030024
		// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00031E38 File Offset: 0x00030038
		public override IWebProxy Proxy
		{
			get
			{
				return this.proxy;
			}
			set
			{
				this.CheckRequestStarted();
				this.proxy = value;
				ServicePoint servicePoint = this.GetServicePoint();
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00031E5C File Offset: 0x0003005C
		// (set) Token: 0x06000FDB RID: 4059 RVA: 0x00031E7C File Offset: 0x0003007C
		public string Referer
		{
			get
			{
				return this.webHeaders["Referer"];
			}
			set
			{
				this.CheckRequestStarted();
				if (value != null && value.Trim()._stringLength != 0)
				{
					this.webHeaders.SetInternal("Referer", value);
					return;
				}
				this.webHeaders.RemoveInternal("Referer");
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00031EC4 File Offset: 0x000300C4
		public override global::System.Uri RequestUri
		{
			get
			{
				return this.requestUri;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00031ED8 File Offset: 0x000300D8
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00031EEC File Offset: 0x000300EC
		public bool SendChunked
		{
			get
			{
				return this.sendChunked;
			}
			set
			{
				this.CheckRequestStarted();
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00031F00 File Offset: 0x00030100
		public ServicePoint ServicePoint
		{
			get
			{
				return this.GetServicePoint();
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00031F14 File Offset: 0x00030114
		internal ServicePoint ServicePointNoLock
		{
			get
			{
				return this.servicePoint;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00031F28 File Offset: 0x00030128
		public virtual bool SupportsCookieContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00031F38 File Offset: 0x00030138
		// (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00031F4C File Offset: 0x0003014C
		public override int Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				this.timeout = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00031F60 File Offset: 0x00030160
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00031F80 File Offset: 0x00030180
		public string TransferEncoding
		{
			get
			{
				return this.webHeaders["Transfer-Encoding"];
			}
			set
			{
				this.CheckRequestStarted();
				bool flag = string.IsNullOrWhiteSpace(value);
				this.webHeaders.RemoveInternal("Transfer-Encoding");
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00031FE0 File Offset: 0x000301E0
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00031FF0 File Offset: 0x000301F0
		public override bool UseDefaultCredentials
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000FE6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpWebRequest::get_UseDefaultCredentials()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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
			set
			{
				if (!true)
				{
				}
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000FE8 RID: 4072 RVA: 0x00032004 File Offset: 0x00030204
		// (set) Token: 0x06000FE9 RID: 4073 RVA: 0x00032024 File Offset: 0x00030224
		public string UserAgent
		{
			get
			{
				return this.webHeaders["User-Agent"];
			}
			set
			{
				this.webHeaders.SetInternal(value, value);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000FEA RID: 4074 RVA: 0x00032040 File Offset: 0x00030240
		// (set) Token: 0x06000FEB RID: 4075 RVA: 0x00032054 File Offset: 0x00030254
		public bool UnsafeAuthenticatedConnectionSharing
		{
			get
			{
				return this.unsafe_auth_blah;
			}
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00032064 File Offset: 0x00030264
		internal bool GotRequestStream
		{
			get
			{
				return this.gotRequestStream;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00032078 File Offset: 0x00030278
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x0003208C File Offset: 0x0003028C
		internal bool ExpectContinue
		{
			get
			{
				return this.expectContinue;
			}
			set
			{
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0003209C File Offset: 0x0003029C
		internal global::System.Uri AuthUri
		{
			get
			{
				return this.actualUri;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x000320B0 File Offset: 0x000302B0
		internal bool ProxyQuery
		{
			get
			{
				ServicePoint servicePoint = this.servicePoint;
				if (servicePoint.usesProxy)
				{
					bool useConnect = servicePoint.useConnect;
					return;
				}
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x000320D4 File Offset: 0x000302D4
		internal ServerCertValidationCallback ServerCertValidationCallback
		{
			get
			{
				return this.certValidationCallback;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x000320E8 File Offset: 0x000302E8
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00032108 File Offset: 0x00030308
		public global::System.Net.Security.RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get
			{
				ServerCertValidationCallback serverCertValidationCallback = this.certValidationCallback;
				if (serverCertValidationCallback != null)
				{
					return serverCertValidationCallback.m_ValidationCallback;
				}
			}
			set
			{
				if (value != null)
				{
					return;
				}
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0003211C File Offset: 0x0003031C
		internal ServicePoint GetServicePoint()
		{
			object obj = this.locker;
			if (this.hostChanged)
			{
				global::System.Uri uri = this.actualUri;
				IWebProxy webProxy = this.proxy;
				ServicePoint servicePoint = ServicePointManager.FindServicePoint(uri, webProxy);
				this.servicePoint = servicePoint;
				return servicePoint;
			}
			ServicePoint servicePoint2 = this.servicePoint;
			while (servicePoint2 == null)
			{
			}
			long num = 0L;
			if (servicePoint2 != null)
			{
				Monitor.Exit(obj);
			}
			if (num == 0L)
			{
				return this.servicePoint;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x000321A0 File Offset: 0x000303A0
		public void AddRange(int range)
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x000321B0 File Offset: 0x000303B0
		public void AddRange(int from, int to)
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x000321C0 File Offset: 0x000303C0
		public void AddRange(string rangeSpecifier, int range)
		{
			this.AddRange(rangeSpecifier, (long)range);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000321D8 File Offset: 0x000303D8
		public void AddRange(string rangeSpecifier, int from, int to)
		{
			this.AddRange(rangeSpecifier, (long)from, (long)to);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000321F0 File Offset: 0x000303F0
		public void AddRange(long range)
		{
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00032200 File Offset: 0x00030400
		public void AddRange(long from, long to)
		{
			this.AddRange("bytes", from, to);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0003221C File Offset: 0x0003041C
		public void AddRange(string rangeSpecifier, long range)
		{
			while (rangeSpecifier != null)
			{
				bool flag = WebHeaderCollection.IsValidToken(rangeSpecifier);
				string text = this.webHeaders["Range"];
				if (text == null)
				{
					string text2 = text + "=";
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					string text3;
					this.webHeaders.ChangeInternal("Range", text3);
					return;
				}
				long num = 0L;
				int num2;
				if (string.Compare(text.Substring((int)num, num2), rangeSpecifier, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return;
				}
			}
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00032288 File Offset: 0x00030488
		public void AddRange(string rangeSpecifier, long from, long to)
		{
			if (rangeSpecifier != null)
			{
				bool flag = WebHeaderCollection.IsValidToken(rangeSpecifier);
				string text = this.webHeaders["Range"];
				string text2;
				this.webHeaders.ChangeInternal("Range", text2);
				return;
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000322C4 File Offset: 0x000304C4
		private WebOperation SendRequest(bool redirecting, global::System.Net.BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			object obj = this.locker;
			Monitor.Enter(obj, redirecting);
			int num;
			if (!this.requestSent || this.currentOperation == null)
			{
				num = 1;
			}
			long num2 = 0L;
			if (num != 0)
			{
				Monitor.Exit(obj);
			}
			if (num2 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00032320 File Offset: 0x00030520
		private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken)
		{
			int num4;
			do
			{
				bool flag = this.method == "GET";
				bool flag2 = this.method == "CONNECT";
				bool flag3 = this.method == "HEAD";
				bool flag4 = this.method == "TRACE";
				if (this.method == null)
				{
					goto IL_00F2;
				}
				long num = this.contentLength;
				if (!this.sendChunked && !this.allowBuffering && this.keepAlive)
				{
					goto IL_00FF;
				}
				string transferEncoding = this.TransferEncoding;
				if (transferEncoding != null && !this.sendChunked)
				{
					bool flag5 = transferEncoding.Trim() != "";
				}
				object obj = this.locker;
				if (this.getResponseCalled)
				{
					goto IL_00FF;
				}
				string text;
				if (this.currentOperation == null)
				{
					text = this.method;
					int num2 = 1;
					this.gotRequestStream = num2 != 0;
					this.initialMethod = text;
				}
				long num3 = 0L;
				num4 = 21;
				if (text != null)
				{
					Monitor.Exit(obj);
				}
				if (num3 != 0L)
				{
					goto IL_00F9;
				}
			}
			while (num4 != 0);
			WebOperation webOperation;
			return webOperation.GetRequestStream();
			IL_00F2:
			WebException ex = HttpWebRequest.CreateRequestAbortedException();
			IL_00F9:
			throw new OutOfMemoryException();
			IL_00FF:
			return "Content-Length not set";
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0003245C File Offset: 0x0003065C
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			Task task;
			return TaskToApm.Begin(task, callback, state);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00032474 File Offset: 0x00030674
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (asyncResult != null)
			{
				return;
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00032488 File Offset: 0x00030688
		public override Stream GetRequestStream()
		{
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
		[MonoTODO]
		public Stream GetRequestStream([Out] TransportContext context)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00032498 File Offset: 0x00030698
		public override Task<Stream> GetRequestStreamAsync()
		{
			Task task;
			return task;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000324A8 File Offset: 0x000306A8
		internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001004)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<T> System.Net.HttpWebRequest::RunWithTimeout<T>(System.Func`2<System.Threading.CancellationToken,System.Threading.Tasks.Task`1<T>>,System.Int32,System.Action,System.Func`1<System.Boolean>,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CancellationToken(var_1_09, callgetter:CancellationToken(CancellationTokenSource::get_Token, ldloc:CancellationTokenSource(var_0)))
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

		// Token: 0x06001005 RID: 4101 RVA: 0x000324C0 File Offset: 0x000306C0
		private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
		{
			/*
An exception occurred when decompiling this method (06001005)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<T> System.Net.HttpWebRequest::RunWithTimeoutWorker<T>(System.Threading.Tasks.Task`1<T>,System.Int32,System.Action,System.Func`1<System.Boolean>,System.Threading.CancellationTokenSource)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0009:
	stloc:Timer(var_0_10, ldfld:Timer(CancellationTokenSource::_timer, ldloc:CancellationTokenSource(cts)))
	stloc:object(var_1_1D, ldfld:object(MarshalByRefObject::_identity, ldfld:Timer[exp:MarshalByRefObject](CancellationTokenSource::_timer, ldloc:CancellationTokenSource(cts))))
	stloc:TimerCallback(var_2_2A, ldfld:TimerCallback(Timer::callback, ldfld:Timer(CancellationTokenSource::_timer, ldloc:CancellationTokenSource(cts))))
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

		// Token: 0x06001006 RID: 4102 RVA: 0x000324F8 File Offset: 0x000306F8
		private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			int num = this.timeout;
			throw new NullReferenceException();
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00032514 File Offset: 0x00030714
		private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001007)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Net.HttpWebResponse> System.Net.HttpWebRequest::MyGetResponseAsync(System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06001008 RID: 4104 RVA: 0x00032524 File Offset: 0x00030724
		private Task<ValueTuple<HttpWebResponse, bool, bool, global::System.Net.BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001008)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.ValueTuple`5<System.Net.HttpWebResponse,System.Boolean,System.Boolean,System.Net.BufferOffsetSize,System.Net.WebOperation>> System.Net.HttpWebRequest::GetResponseFromData(System.Net.WebResponseStream,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06001009 RID: 4105 RVA: 0x00032534 File Offset: 0x00030734
		internal static Exception FlattenException(Exception e)
		{
			AggregateException ex;
			ReadOnlyCollection<Exception> innerExceptions = ex.m_innerExceptions;
			return ex._innerException;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00032550 File Offset: 0x00030750
		private WebException GetWebException(Exception e)
		{
			long num = 0L;
			long num2 = 0L;
			int num3 = Interlocked.CompareExchange(0, (int)num, (int)num2);
			return HttpWebRequest.GetWebException(e, num != 0L);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00032574 File Offset: 0x00030774
		private static WebException GetWebException(Exception e, bool aborted)
		{
			if (!true)
			{
			}
			Exception ex;
			if (ex != null)
			{
			}
			return HttpWebRequest.CreateRequestAbortedException();
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00002050 File Offset: 0x00000250
		internal static WebException CreateRequestAbortedException()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0003258C File Offset: 0x0003078C
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			string transferEncoding = this.TransferEncoding;
			if (transferEncoding != null && !this.sendChunked)
			{
				bool flag = transferEncoding.Trim() != "";
			}
			Task task;
			return TaskToApm.Begin(task, callback, state);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000325CC File Offset: 0x000307CC
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (asyncResult != null)
			{
				return;
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000325E0 File Offset: 0x000307E0
		public Stream EndGetRequestStream(IAsyncResult asyncResult, [Out] TransportContext context)
		{
			/*
An exception occurred when decompiling this method (0600100F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IO.Stream System.Net.HttpWebRequest::EndGetRequestStream(System.IAsyncResult,System.Net.TransportContext)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:IAsyncResult[exp:bool](asyncResult)))
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

		// Token: 0x06001010 RID: 4112 RVA: 0x000325F0 File Offset: 0x000307F0
		public override WebResponse GetResponse()
		{
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x00032600 File Offset: 0x00030800
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x00032614 File Offset: 0x00030814
		internal bool FinishedReading
		{
			get
			{
				return this.finished_reading;
			}
			set
			{
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Aborted
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00032624 File Offset: 0x00030824
		public override void Abort()
		{
			int num = 1;
			long num2 = 0L;
			int num3 = 1;
			int num4 = Interlocked.CompareExchange(1073741824, num, (int)num2);
			WebOperation webOperation = this.currentOperation;
			this.haveResponse = num3 != 0;
			if (webOperation != null)
			{
				webOperation.Abort();
			}
			if (this.responseTask != null)
			{
			}
			if (this.webResponse != null)
			{
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00032674 File Offset: 0x00030874
		private void CheckRequestStarted()
		{
			while (this.requestSent)
			{
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0003268C File Offset: 0x0003088C
		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			HttpContinueDelegate httpContinueDelegate = this.continueDelegate;
			if (httpContinueDelegate != null)
			{
				IntPtr invoke_impl = httpContinueDelegate.invoke_impl;
				IntPtr method_code = httpContinueDelegate.method_code;
				IntPtr intPtr = httpContinueDelegate.method;
				return;
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000326BC File Offset: 0x000308BC
		private void RewriteRedirectToGet()
		{
			WebHeaderCollection webHeaderCollection = this.webHeaders;
			this.method = "GET";
			webHeaderCollection.RemoveInternal("Transfer-Encoding");
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000326E8 File Offset: 0x000308E8
		private bool Redirect(HttpStatusCode code, WebResponse response)
		{
			int num = this.redirects;
			this.redirects = num;
			bool flag = this.method == "POST";
			this.RewriteRedirectToGet();
			string text2;
			string text = "Invalid status code: " + text2;
			bool flag2 = this.method != "GET";
			if (this.allowBuffering)
			{
				bool methodWithBuffer = this.MethodWithBuffer;
			}
			if (this.ResendContentFactory == null)
			{
				int writeBufferLength = this.writeStream.WriteBufferLength;
				long num2 = this.contentLength;
			}
			bool flag3 = this.method == "GET";
			string text3;
			if (text3 != null)
			{
				global::System.Uri uri = this.actualUri;
				string scheme = uri.Scheme;
				string text4;
				return text4 != scheme;
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000327CC File Offset: 0x000309CC
		private string GetHeaders()
		{
			/*
An exception occurred when decompiling this method (0600101B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.HttpWebRequest::GetHeaders()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_025F:
	brtrue(IL_0000, ldfld:bool(HttpWebRequest::gotRequestStream, ldloc:HttpWebRequest(this)))
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

		// Token: 0x0600101C RID: 4124 RVA: 0x00032A44 File Offset: 0x00030C44
		private void DoPreAuthenticate()
		{
			if (this.proxy != null)
			{
				global::System.Uri uri = this.actualUri;
				return;
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x00032ADC File Offset: 0x00030CDC
		internal byte[] GetRequestHeaders()
		{
			bool useConnect;
			global::System.Uri uri;
			do
			{
				ServicePoint servicePoint = this.servicePoint;
				if (!servicePoint.usesProxy)
				{
					goto IL_004D;
				}
				useConnect = servicePoint.useConnect;
				uri = this.actualUri;
			}
			while (useConnect);
			string scheme = uri.Scheme;
			string host = this.Host;
			string pathAndQuery = this.actualUri.PathAndQuery;
			string text = string.Format("{0}://{1}{2}", scheme, host, pathAndQuery);
			IL_004D:
			string pathAndQuery2 = this.actualUri.PathAndQuery;
			if (!this.force_version)
			{
				ServicePoint servicePoint2 = this.servicePoint;
				ServicePoint servicePoint3 = this.servicePoint;
				Version version = this.version;
				ServicePoint servicePoint4 = this.servicePoint;
				this.actualVersion = servicePoint4;
			}
			Version version2 = this.version;
			this.actualVersion = version2;
			string text2 = this.method;
			if ((text2 == null || text2 != null) && (pathAndQuery2 == null || pathAndQuery2 != null))
			{
				int major = this.actualVersion._Major;
				int minor = this.actualVersion._Minor;
				string headers = this.GetHeaders();
				Encoding utf = Encoding.UTF8;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00032BCC File Offset: 0x00030DCC
		private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, global::System.Net.BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			if (372 != 0)
			{
				HttpWebRequest.NtlmAuthState ntlm_auth_state = this.auth_state.ntlm_auth_state;
				return "NTLM";
			}
			return "NTLM";
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00032C5C File Offset: 0x00030E5C
		private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			bool flag;
			return flag;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00032C6C File Offset: 0x00030E6C
		private ValueTuple<Task<global::System.Net.BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			/*
An exception occurred when decompiling this method (06001020)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ValueTuple`2<System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>,System.Net.WebException> System.Net.HttpWebRequest::GetRewriteHandler(System.Net.HttpWebResponse,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	stloc:BufferOffsetSize(var_1_27, call:BufferOffsetSize(WebRequestStream::GetWriteBuffer, ldfld:WebRequestStream(HttpWebRequest::writeStream, ldloc:HttpWebRequest(this))))
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

		// Token: 0x06001021 RID: 4129 RVA: 0x00032CA0 File Offset: 0x00030EA0
		private ValueTuple<bool, bool, Task<global::System.Net.BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			/*
An exception occurred when decompiling this method (06001021)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ValueTuple`4<System.Boolean,System.Boolean,System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize>,System.Net.WebException> System.Net.HttpWebRequest::CheckFinalStatus(System.Net.HttpWebResponse)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_9:
	stloc:int32(var_11_C4, ldfld:int32(HttpWebRequest::redirects, ldloc:HttpWebRequest(this)))
	stloc:int32(var_12_CC, ldfld:int32(HttpWebRequest::maxAutoRedirect, ldloc:HttpWebRequest(this)))
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x00032D7C File Offset: 0x00030F7C
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x00032D90 File Offset: 0x00030F90
		internal bool ReuseConnection
		{
			[CompilerGenerated]
			get
			{
				return this.<ReuseConnection>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00002050 File Offset: 0x00000250
		internal static StringBuilder GenerateConnectionGroup(string connectionGroupName, bool unsafeConnectionGroup, bool isInternalGroup)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00032DA0 File Offset: 0x00030FA0
		[CompilerGenerated]
		private bool <RunWithTimeout>b__242_0<T>()
		{
			return this.Aborted;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00032DB4 File Offset: 0x00030FB4
		[CompilerGenerated]
		private Task<global::System.Net.BufferOffsetSize> <GetRewriteHandler>b__271_0()
		{
			/*
An exception occurred when decompiling this method (06001026)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Net.BufferOffsetSize> System.Net.HttpWebRequest::<GetRewriteHandler>b__271_0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x06001027 RID: 4135 RVA: 0x00032DC4 File Offset: 0x00030FC4
		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public HttpWebRequest()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000C64 RID: 3172
		private global::System.Uri requestUri;

		// Token: 0x04000C65 RID: 3173
		private global::System.Uri actualUri;

		// Token: 0x04000C66 RID: 3174
		private bool hostChanged;

		// Token: 0x04000C67 RID: 3175
		private bool allowAutoRedirect;

		// Token: 0x04000C68 RID: 3176
		private bool allowBuffering;

		// Token: 0x04000C69 RID: 3177
		private bool allowReadStreamBuffering;

		// Token: 0x04000C6A RID: 3178
		private global::System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates;

		// Token: 0x04000C6B RID: 3179
		private string connectionGroup;

		// Token: 0x04000C6C RID: 3180
		private bool haveContentLength;

		// Token: 0x04000C6D RID: 3181
		private long contentLength;

		// Token: 0x04000C6E RID: 3182
		private HttpContinueDelegate continueDelegate;

		// Token: 0x04000C6F RID: 3183
		private CookieContainer cookieContainer;

		// Token: 0x04000C70 RID: 3184
		private ICredentials credentials;

		// Token: 0x04000C71 RID: 3185
		private bool haveResponse;

		// Token: 0x04000C72 RID: 3186
		private bool requestSent;

		// Token: 0x04000C73 RID: 3187
		private WebHeaderCollection webHeaders;

		// Token: 0x04000C74 RID: 3188
		private bool keepAlive;

		// Token: 0x04000C75 RID: 3189
		private int maxAutoRedirect;

		// Token: 0x04000C76 RID: 3190
		private string mediaType;

		// Token: 0x04000C77 RID: 3191
		private string method;

		// Token: 0x04000C78 RID: 3192
		private string initialMethod;

		// Token: 0x04000C79 RID: 3193
		private bool pipelined;

		// Token: 0x04000C7A RID: 3194
		private bool preAuthenticate;

		// Token: 0x04000C7B RID: 3195
		private bool usedPreAuth;

		// Token: 0x04000C7C RID: 3196
		private Version version;

		// Token: 0x04000C7D RID: 3197
		private bool force_version;

		// Token: 0x04000C7E RID: 3198
		private Version actualVersion;

		// Token: 0x04000C7F RID: 3199
		private IWebProxy proxy;

		// Token: 0x04000C80 RID: 3200
		private bool sendChunked;

		// Token: 0x04000C81 RID: 3201
		private ServicePoint servicePoint;

		// Token: 0x04000C82 RID: 3202
		private int timeout;

		// Token: 0x04000C83 RID: 3203
		private int continueTimeout;

		// Token: 0x04000C84 RID: 3204
		private WebRequestStream writeStream;

		// Token: 0x04000C85 RID: 3205
		private HttpWebResponse webResponse;

		// Token: 0x04000C86 RID: 3206
		private WebCompletionSource responseTask;

		// Token: 0x04000C87 RID: 3207
		private WebOperation currentOperation;

		// Token: 0x04000C88 RID: 3208
		private int aborted;

		// Token: 0x04000C89 RID: 3209
		private bool gotRequestStream;

		// Token: 0x04000C8A RID: 3210
		private int redirects;

		// Token: 0x04000C8B RID: 3211
		private bool expectContinue;

		// Token: 0x04000C8C RID: 3212
		private bool getResponseCalled;

		// Token: 0x04000C8D RID: 3213
		private object locker;

		// Token: 0x04000C8E RID: 3214
		private bool finished_reading;

		// Token: 0x04000C8F RID: 3215
		private DecompressionMethods auto_decomp;

		// Token: 0x04000C90 RID: 3216
		private int maxResponseHeadersLength;

		// Token: 0x04000C91 RID: 3217
		private static int defaultMaxResponseHeadersLength;

		// Token: 0x04000C92 RID: 3218
		private static int defaultMaximumErrorResponseLength;

		// Token: 0x04000C93 RID: 3219
		private static global::System.Net.Cache.RequestCachePolicy defaultCachePolicy;

		// Token: 0x04000C94 RID: 3220
		private int readWriteTimeout;

		// Token: 0x04000C95 RID: 3221
		private Mono.Net.Security.MobileTlsProvider tlsProvider;

		// Token: 0x04000C96 RID: 3222
		private MonoTlsSettings tlsSettings;

		// Token: 0x04000C97 RID: 3223
		private ServerCertValidationCallback certValidationCallback;

		// Token: 0x04000C98 RID: 3224
		private bool hostHasPort;

		// Token: 0x04000C99 RID: 3225
		private global::System.Uri hostUri;

		// Token: 0x04000C9A RID: 3226
		private HttpWebRequest.AuthorizationState auth_state;

		// Token: 0x04000C9B RID: 3227
		private HttpWebRequest.AuthorizationState proxy_auth_state;

		// Token: 0x04000C9C RID: 3228
		[NonSerialized]
		internal Func<Stream, Task> ResendContentFactory;

		// Token: 0x04000C9D RID: 3229
		internal readonly int ID;

		// Token: 0x04000C9E RID: 3230
		[CompilerGenerated]
		private bool <ThrowOnError>k__BackingField;

		// Token: 0x04000C9F RID: 3231
		private bool unsafe_auth_blah;

		// Token: 0x04000CA0 RID: 3232
		[CompilerGenerated]
		private bool <ReuseConnection>k__BackingField;

		// Token: 0x02000256 RID: 598
		private enum NtlmAuthState
		{
			// Token: 0x04000CA2 RID: 3234
			None,
			// Token: 0x04000CA3 RID: 3235
			Challenge,
			// Token: 0x04000CA4 RID: 3236
			Response
		}

		// Token: 0x02000257 RID: 599
		private struct AuthorizationState
		{
			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06001028 RID: 4136 RVA: 0x00032DD8 File Offset: 0x00030FD8
			public bool IsCompleted
			{
				get
				{
					return this.isCompleted;
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06001029 RID: 4137 RVA: 0x00032DEC File Offset: 0x00030FEC
			public HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				get
				{
					return this.ntlm_auth_state;
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x0600102A RID: 4138 RVA: 0x00032E00 File Offset: 0x00031000
			public bool IsNtlmAuthenticated
			{
				get
				{
					if (this.isCompleted)
					{
						HttpWebRequest.NtlmAuthState ntlmAuthState = this.ntlm_auth_state;
						return;
					}
				}
			}

			// Token: 0x0600102B RID: 4139 RVA: 0x00032E20 File Offset: 0x00031020
			public AuthorizationState(HttpWebRequest request, bool isProxy)
			{
				this.request = request;
			}

			// Token: 0x0600102C RID: 4140 RVA: 0x00032E34 File Offset: 0x00031034
			public bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				/*
An exception occurred when decompiling this method (0600102C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpWebRequest/AuthorizationState::CheckAuthorization(System.Net.WebResponse,System.Net.HttpStatusCode)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_004E:
	stloc:bool(var_6_54, ldfld:bool(AuthorizationState::isProxy, ldloc:valuetype System.Net.HttpWebRequest/AuthorizationState&(this)))
	stloc:NtlmAuthState(var_8_5C, ldfld:NtlmAuthState(AuthorizationState::ntlm_auth_state, ldloc:valuetype System.Net.HttpWebRequest/AuthorizationState&(this)))
	stfld:NtlmAuthState(AuthorizationState::ntlm_auth_state, ldloc:valuetype System.Net.HttpWebRequest/AuthorizationState&(this), ldloc:NtlmAuthState(var_8_5C))
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

			// Token: 0x0600102D RID: 4141 RVA: 0x00032EAC File Offset: 0x000310AC
			public void Reset()
			{
				bool flag = this.isProxy;
			}

			// Token: 0x0600102E RID: 4142 RVA: 0x00032EC0 File Offset: 0x000310C0
			public override string ToString()
			{
				bool flag = this.isProxy;
				bool flag2 = this.isCompleted;
				HttpWebRequest.NtlmAuthState ntlmAuthState = this.ntlm_auth_state;
				string text;
				return text;
			}

			// Token: 0x04000CA5 RID: 3237
			private readonly HttpWebRequest request;

			// Token: 0x04000CA6 RID: 3238
			private readonly bool isProxy;

			// Token: 0x04000CA7 RID: 3239
			private bool isCompleted;

			// Token: 0x04000CA8 RID: 3240
			private HttpWebRequest.NtlmAuthState ntlm_auth_state;
		}

		// Token: 0x02000258 RID: 600
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c__241<T>
		{
			// Token: 0x0600102F RID: 4143 RVA: 0x00032EE4 File Offset: 0x000310E4
			// Note: this type is marked as 'beforefieldinit'.
			static <>c__241()
			{
			}

			// Token: 0x06001030 RID: 4144 RVA: 0x00032EF4 File Offset: 0x000310F4
			public <>c__241()
			{
			}

			// Token: 0x06001031 RID: 4145 RVA: 0x00032F08 File Offset: 0x00031108
			internal int? <RunWithTimeoutWorker>b__241_0(Task<T> t)
			{
				/*
An exception occurred when decompiling this method (06001031)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Nullable`1<System.Int32> System.Net.HttpWebRequest/<>c__241`1::<RunWithTimeoutWorker>b__241_0(System.Threading.Tasks.Task`1<T>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(callgetter:AggregateException[exp:bool](Task::get_Exception, ldloc:class [mscorlib]System.Threading.Tasks.Task`1<!T>[exp:Task](t))))
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

			// Token: 0x04000CA9 RID: 3241
			public static readonly HttpWebRequest.<>c__241<T> <>9;

			// Token: 0x04000CAA RID: 3242
			public static Func<Task<T>, int?> <>9__241_0;
		}

		// Token: 0x02000259 RID: 601
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <RunWithTimeoutWorker>d__241<T> : IAsyncStateMachine
		{
			// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
			private void MoveNext()
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000CAB RID: 3243
			public int <>1__state;

			// Token: 0x04000CAC RID: 3244
			public AsyncTaskMethodBuilder<T> <>t__builder;

			// Token: 0x04000CAD RID: 3245
			public Task<T> workerTask;

			// Token: 0x04000CAE RID: 3246
			public int timeout;

			// Token: 0x04000CAF RID: 3247
			public CancellationTokenSource cts;

			// Token: 0x04000CB0 RID: 3248
			public Action abort;

			// Token: 0x04000CB1 RID: 3249
			public Func<bool> aborted;

			// Token: 0x04000CB2 RID: 3250
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200025A RID: 602
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <MyGetResponseAsync>d__243 : IAsyncStateMachine
		{
			// Token: 0x06001034 RID: 4148 RVA: 0x00032F1C File Offset: 0x0003111C
			private void MoveNext()
			{
				HttpWebRequest httpWebRequest = this.<>4__this;
			}

			// Token: 0x06001035 RID: 4149 RVA: 0x000332E0 File Offset: 0x000314E0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000CB3 RID: 3251
			public int <>1__state;

			// Token: 0x04000CB4 RID: 3252
			public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder;

			// Token: 0x04000CB5 RID: 3253
			public HttpWebRequest <>4__this;

			// Token: 0x04000CB6 RID: 3254
			public CancellationToken cancellationToken;

			// Token: 0x04000CB7 RID: 3255
			private WebCompletionSource <completion>5__2;

			// Token: 0x04000CB8 RID: 3256
			private WebOperation <operation>5__3;

			// Token: 0x04000CB9 RID: 3257
			private WebException <throwMe>5__4;

			// Token: 0x04000CBA RID: 3258
			private HttpWebResponse <response>5__5;

			// Token: 0x04000CBB RID: 3259
			private WebResponseStream <stream>5__6;

			// Token: 0x04000CBC RID: 3260
			private bool <redirect>5__7;

			// Token: 0x04000CBD RID: 3261
			private bool <mustReadAll>5__8;

			// Token: 0x04000CBE RID: 3262
			private WebOperation <ntlm>5__9;

			// Token: 0x04000CBF RID: 3263
			private global::System.Net.BufferOffsetSize <writeBuffer>5__10;

			// Token: 0x04000CC0 RID: 3264
			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000CC1 RID: 3265
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			// Token: 0x04000CC2 RID: 3266
			private TaskAwaiter<WebResponseStream> <>u__3;

			// Token: 0x04000CC3 RID: 3267
			[TupleElementNames(new string[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
			private ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, global::System.Net.BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter <>u__4;
		}

		// Token: 0x0200025B RID: 603
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <GetResponseFromData>d__244 : IAsyncStateMachine
		{
			// Token: 0x06001036 RID: 4150 RVA: 0x000332F0 File Offset: 0x000314F0
			private void MoveNext()
			{
				HttpWebRequest httpWebRequest = this.<>4__this;
				global::System.Uri actualUri = httpWebRequest.actualUri;
				string method = httpWebRequest.method;
				WebResponseStream webResponseStream = this.stream;
				CookieContainer cookieContainer = httpWebRequest.cookieContainer;
				object locker = httpWebRequest.locker;
				HttpWebResponse httpWebResponse = this.<response>5__2;
				ValueTuple<bool, bool, Task<global::System.Net.BufferOffsetSize>, WebException> valueTuple = httpWebRequest.CheckFinalStatus(httpWebResponse);
				long num = 0L;
				Monitor.Exit(locker);
				if (num != 0L)
				{
					throw new OutOfMemoryException();
				}
				if (this.<throwMe>5__3 != null)
				{
					if (this.<mustReadAll>5__5)
					{
						WebResponseStream webResponseStream2 = this.stream;
						CancellationToken cancellationToken = this.cancellationToken;
						long num2 = 0L;
						Task task = webResponseStream2.ReadAllAsync(num2 != 0L, cancellationToken);
						long num3 = 0L;
						ConfiguredTaskAwaitable configuredTaskAwaitable = task.ConfigureAwait(num3 != 0L);
						return;
					}
					throw new OutOfMemoryException();
				}
				else
				{
					IWebProxy webProxy;
					if (webProxy != null)
					{
						int num4 = 1;
						this.<>1__state = num4;
						Task task2;
						this.<>u__2.m_task = task2;
						return;
					}
					return;
				}
			}

			// Token: 0x06001037 RID: 4151 RVA: 0x00033510 File Offset: 0x00031710
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000CC4 RID: 3268
			public int <>1__state;

			// Token: 0x04000CC5 RID: 3269
			[TupleElementNames(new string[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
			public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, global::System.Net.BufferOffsetSize, WebOperation>> <>t__builder;

			// Token: 0x04000CC6 RID: 3270
			public HttpWebRequest <>4__this;

			// Token: 0x04000CC7 RID: 3271
			public WebResponseStream stream;

			// Token: 0x04000CC8 RID: 3272
			public CancellationToken cancellationToken;

			// Token: 0x04000CC9 RID: 3273
			private HttpWebResponse <response>5__2;

			// Token: 0x04000CCA RID: 3274
			private WebException <throwMe>5__3;

			// Token: 0x04000CCB RID: 3275
			private bool <redirect>5__4;

			// Token: 0x04000CCC RID: 3276
			private bool <mustReadAll>5__5;

			// Token: 0x04000CCD RID: 3277
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000CCE RID: 3278
			private ConfiguredTaskAwaitable<global::System.Net.BufferOffsetSize>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x0200025C RID: 604
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <<GetRewriteHandler>b__271_0>d : IAsyncStateMachine
		{
			// Token: 0x06001038 RID: 4152 RVA: 0x00033520 File Offset: 0x00031720
			private void MoveNext()
			{
				Func<Stream, Task> resendContentFactory = this.<>4__this.ResendContentFactory;
			}

			// Token: 0x06001039 RID: 4153 RVA: 0x00033598 File Offset: 0x00031798
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000CCF RID: 3279
			public int <>1__state;

			// Token: 0x04000CD0 RID: 3280
			public AsyncTaskMethodBuilder<global::System.Net.BufferOffsetSize> <>t__builder;

			// Token: 0x04000CD1 RID: 3281
			public HttpWebRequest <>4__this;

			// Token: 0x04000CD2 RID: 3282
			private MemoryStream <ms>5__2;

			// Token: 0x04000CD3 RID: 3283
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
