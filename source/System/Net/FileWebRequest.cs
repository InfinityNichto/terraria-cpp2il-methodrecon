using System;
using System.IO;
using System.Runtime.Serialization;
using System.Threading;

namespace System.Net
{
	// Token: 0x0200021A RID: 538
	[Serializable]
	public class FileWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06000D59 RID: 3417 RVA: 0x0002AF88 File Offset: 0x00029188
		internal FileWebRequest(global::System.Uri uri)
		{
			this.m_timeout = 34464;
			this.m_method = "GET";
			if ("GET" == null)
			{
			}
			base..ctor();
			string scheme = uri.Scheme;
			if (34464 == 0)
			{
			}
			this.m_uri = uri;
			this.m_fileAccess = FileAccess.Read;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0002AFD4 File Offset: 0x000291D4
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			int num = 34464;
			this.m_timeout = num;
			this.m_method = "GET";
			if ("GET" == null)
			{
			}
			base..ctor(serializationInfo, streamingContext);
			if ("GET" == null)
			{
			}
			object obj;
			if (obj != null)
			{
				this.m_headers = obj;
				return;
			}
			Type type;
			object value = serializationInfo.GetValue("proxy", type);
			if (value != null)
			{
				if (value != null)
				{
					this.m_proxy = value;
					if (value != null)
					{
						goto IL_0061;
					}
				}
				throw new InvalidCastException();
			}
			IL_0061:
			Type type2;
			object value2 = serializationInfo.GetValue("uri", type2);
			if (value2 != null)
			{
				this.m_uri = value2;
				throw new InvalidCastException();
			}
			string @string = serializationInfo.GetString("connectionGroupName");
			this.m_connectionGroupName = @string;
			string string2 = serializationInfo.GetString("method");
			this.m_method = string2;
			long @int = serializationInfo.GetInt64("contentLength");
			this.m_contentLength = @int;
			int int2 = serializationInfo.GetInt32("timeout");
			this.m_timeout = int2;
			int int3 = serializationInfo.GetInt32("fileAccess");
			this.m_fileAccess = (FileAccess)int3;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0002B0CC File Offset: 0x000292CC
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0002B0DC File Offset: 0x000292DC
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			WebHeaderCollection headers = this.m_headers;
			if (!true)
			{
			}
			IWebProxy proxy = this.m_proxy;
			global::System.Uri uri = this.m_uri;
			Type type;
			serializationInfo.AddValue("uri", uri, type);
			string connectionGroupName = this.m_connectionGroupName;
			serializationInfo.AddValue("connectionGroupName", connectionGroupName);
			string method = this.m_method;
			serializationInfo.AddValue("method", method);
			long contentLength = this.m_contentLength;
			serializationInfo.AddValue("contentLength", contentLength);
			int timeout = this.m_timeout;
			serializationInfo.AddValue("timeout", timeout);
			FileAccess fileAccess = this.m_fileAccess;
			long num = 0L;
			serializationInfo.AddValue("preauthenticate", num != 0L);
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0002B180 File Offset: 0x00029380
		internal bool Aborted
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000D5D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.FileWebRequest::get_Aborted()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(FileWebRequest::m_Aborted, ldloc:FileWebRequest(this)))
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0002B194 File Offset: 0x00029394
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0002B1A8 File Offset: 0x000293A8
		public override string ConnectionGroupName
		{
			get
			{
				return this.m_connectionGroupName;
			}
			set
			{
				this.m_connectionGroupName = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0002B1BC File Offset: 0x000293BC
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x0002B1D0 File Offset: 0x000293D0
		public override long ContentLength
		{
			get
			{
				return this.m_contentLength;
			}
			set
			{
				this.m_contentLength = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x0002B1F0 File Offset: 0x000293F0
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x0002B210 File Offset: 0x00029410
		public override string ContentType
		{
			get
			{
				return this.m_headers["Content-Type"];
			}
			set
			{
				this.m_headers["Content-Type"] = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0002B230 File Offset: 0x00029430
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x0002B244 File Offset: 0x00029444
		public override ICredentials Credentials
		{
			get
			{
				return this.m_credentials;
			}
			set
			{
				this.m_credentials = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0002B258 File Offset: 0x00029458
		public override WebHeaderCollection Headers
		{
			get
			{
				return this.m_headers;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0002B26C File Offset: 0x0002946C
		// (set) Token: 0x06000D68 RID: 3432 RVA: 0x0002B280 File Offset: 0x00029480
		public override string Method
		{
			get
			{
				return this.m_method;
			}
			set
			{
				if (!true)
				{
				}
				bool flag = ValidationHelper.IsBlankString(value);
				this.m_method = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0002B2AC File Offset: 0x000294AC
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x0002B2C0 File Offset: 0x000294C0
		public override bool PreAuthenticate
		{
			get
			{
				return this.m_preauthenticate;
			}
			set
			{
				this.m_preauthenticate = true;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0002B2D4 File Offset: 0x000294D4
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x0002B2E8 File Offset: 0x000294E8
		public override IWebProxy Proxy
		{
			get
			{
				return this.m_proxy;
			}
			set
			{
				this.m_proxy = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0002B2FC File Offset: 0x000294FC
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x0002B310 File Offset: 0x00029510
		public override int Timeout
		{
			get
			{
				return this.m_timeout;
			}
			set
			{
				this.m_timeout = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0002B330 File Offset: 0x00029530
		public override global::System.Uri RequestUri
		{
			get
			{
				return this.m_uri;
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0002B344 File Offset: 0x00029544
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			if (this.m_Aborted == 0)
			{
				bool flag = this.CanGetRequestStream();
				WebResponse response = this.m_response;
				if (this.m_writePending)
				{
					goto IL_006F;
				}
				int num = 1;
				long num2 = 0L;
				this.m_writePending = num != 0;
				int num3 = 14;
				if (num != 0)
				{
					Monitor.Exit(this);
				}
				if (num2 != 0L)
				{
					goto IL_007B;
				}
				if (num3 == 0)
				{
					LazyAsyncResult readAResult = this.m_ReadAResult;
					LazyAsyncResult readAResult2 = this.m_ReadAResult;
				}
			}
			WebException requestAbortedException = ExceptionHelper.RequestAbortedException;
			string @string = SR.GetString("Cannot send a content-body with this verb-type.");
			string string2 = SR.GetString("This operation cannot be performed after the request has been submitted.");
			IL_006F:
			string string3 = SR.GetString("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress.");
			IL_007B:
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0002B414 File Offset: 0x00029614
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			if (this.m_Aborted == 0)
			{
				if (this.m_readPending)
				{
					goto IL_0040;
				}
				int num = 1;
				long num2 = 0L;
				this.m_readPending = num != 0;
				if (num != 0)
				{
					Monitor.Exit(this);
				}
				if (num2 != 0L)
				{
					goto IL_004C;
				}
				LazyAsyncResult writeAResult = this.m_WriteAResult;
				LazyAsyncResult writeAResult2 = this.m_WriteAResult;
			}
			WebException requestAbortedException = ExceptionHelper.RequestAbortedException;
			IL_0040:
			string @string = SR.GetString("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress.");
			IL_004C:
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0002B4B4 File Offset: 0x000296B4
		private bool CanGetRequestStream()
		{
			/*
An exception occurred when decompiling this method (06000D72)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.FileWebRequest::CanGetRequestStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000A:
	stloc:bool(var_1_15, ldfld:bool(KnownHttpVerb::ContentBodyNotAllowed, call:KnownHttpVerb(KnownHttpVerb::Parse, ldloc:string(var_0_06))))
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

		// Token: 0x06000D73 RID: 3443 RVA: 0x0002B4D8 File Offset: 0x000296D8
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			if (asyncResult != null)
			{
				object obj;
				if (obj != null)
				{
				}
				string @string = SR.GetString("The AsyncResult is not valid.");
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0002B524 File Offset: 0x00029724
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			if (asyncResult != null)
			{
				object obj;
				if (obj != null)
				{
				}
				string @string = SR.GetString("The AsyncResult is not valid.");
				throw new InvalidCastException();
			}
			throw new InvalidCastException();
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0002B570 File Offset: 0x00029770
		public override Stream GetRequestStream()
		{
			if (this.m_stream != null)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0002B5B4 File Offset: 0x000297B4
		public override WebResponse GetResponse()
		{
			int num = 1;
			this.m_syncHint = num != 0;
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			if (num != 0)
			{
			}
			if (this.m_response != null)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0002B60C File Offset: 0x0002980C
		private static void GetRequestStreamCallback(object state)
		{
			if (state != null)
			{
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0002B62C File Offset: 0x0002982C
		private static void GetResponseCallback(object state)
		{
			if (state != null)
			{
			}
			long num = 0L;
			int num2 = 3;
			if (num == 0L)
			{
				if (num2 == 0)
				{
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0002B670 File Offset: 0x00029870
		internal void UnblockReader()
		{
			ManualResetEvent readerEvent = this.m_readerEvent;
			if (readerEvent != null)
			{
				bool flag = readerEvent.Set();
			}
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				if (3 == 0)
				{
				}
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0002B6BC File Offset: 0x000298BC
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0002B6D0 File Offset: 0x000298D0
		public override bool UseDefaultCredentials
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000D7A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.FileWebRequest::get_UseDefaultCredentials()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
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
				/*
An exception occurred when decompiling this method (06000D7B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Net.FileWebRequest::set_UseDefaultCredentials(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:NotSupportedException(var_1_07, callgetter:NotSupportedException(ExceptionHelper::get_PropertyNotSupportedException))
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

		// Token: 0x06000D7C RID: 3452 RVA: 0x0002B6E4 File Offset: 0x000298E4
		public override void Abort()
		{
			int num = Interlocked.Increment(Logging.On ? 1 : 0);
			LazyAsyncResult writeAResult = this.m_WriteAResult;
			LazyAsyncResult readAResult = this.m_ReadAResult;
			Stream stream = this.m_stream;
			if (readAResult == null || readAResult.m_IntCompleted == 0)
			{
			}
			if (writeAResult == null || writeAResult.m_IntCompleted == 0)
			{
			}
			if (stream != null)
			{
				if (stream == null)
				{
					return;
				}
				if (stream == null)
				{
					throw new InvalidCastException();
				}
				if (stream != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
			else
			{
				WebResponse response = this.m_response;
				if (response == null)
				{
					return;
				}
				if (response == null)
				{
					throw new InvalidCastException();
				}
				if (response != null)
				{
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0002B7A0 File Offset: 0x000299A0
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebRequest()
		{
		}

		// Token: 0x04000B50 RID: 2896
		private static WaitCallback s_GetRequestStreamCallback;

		// Token: 0x04000B51 RID: 2897
		private static WaitCallback s_GetResponseCallback;

		// Token: 0x04000B52 RID: 2898
		private string m_connectionGroupName;

		// Token: 0x04000B53 RID: 2899
		private long m_contentLength;

		// Token: 0x04000B54 RID: 2900
		private ICredentials m_credentials;

		// Token: 0x04000B55 RID: 2901
		private FileAccess m_fileAccess;

		// Token: 0x04000B56 RID: 2902
		private WebHeaderCollection m_headers;

		// Token: 0x04000B57 RID: 2903
		private string m_method;

		// Token: 0x04000B58 RID: 2904
		private bool m_preauthenticate;

		// Token: 0x04000B59 RID: 2905
		private IWebProxy m_proxy;

		// Token: 0x04000B5A RID: 2906
		private ManualResetEvent m_readerEvent;

		// Token: 0x04000B5B RID: 2907
		private bool m_readPending;

		// Token: 0x04000B5C RID: 2908
		private WebResponse m_response;

		// Token: 0x04000B5D RID: 2909
		private Stream m_stream;

		// Token: 0x04000B5E RID: 2910
		private bool m_syncHint;

		// Token: 0x04000B5F RID: 2911
		private int m_timeout;

		// Token: 0x04000B60 RID: 2912
		private global::System.Uri m_uri;

		// Token: 0x04000B61 RID: 2913
		private bool m_writePending;

		// Token: 0x04000B62 RID: 2914
		private bool m_writing;

		// Token: 0x04000B63 RID: 2915
		private LazyAsyncResult m_WriteAResult;

		// Token: 0x04000B64 RID: 2916
		private LazyAsyncResult m_ReadAResult;

		// Token: 0x04000B65 RID: 2917
		private int m_Aborted;
	}
}
