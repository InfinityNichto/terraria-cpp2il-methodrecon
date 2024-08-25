using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000246 RID: 582
	internal sealed class HttpConnection
	{
		// Token: 0x06000EAB RID: 3755 RVA: 0x0002EA84 File Offset: 0x0002CC84
		public HttpConnection(global::System.Net.Sockets.Socket sock, EndPointListener epl, bool secure, X509Certificate cert)
		{
			this.sock = sock;
			this.epl = epl;
			this.cert = cert;
			HttpListener listener = epl.listener;
			global::System.Net.Security.SslStream sslStream;
			this.ssl_stream = sslStream;
			this.stream = sslStream;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		internal global::System.Net.Security.SslStream SslStream
		{
			get
			{
				return this.ssl_stream;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		internal int[] ClientCertificateErrors
		{
			get
			{
				return this.client_cert_errors;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0002EB10 File Offset: 0x0002CD10
		internal global::System.Security.Cryptography.X509Certificates.X509Certificate2 ClientCertificate
		{
			get
			{
				return this.client_cert;
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0002EB24 File Offset: 0x0002CD24
		private void Init()
		{
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0002EB34 File Offset: 0x0002CD34
		public bool IsClosed
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000EB0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpConnection::get_IsClosed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Socket(var_0_06, ldfld:Socket(HttpConnection::sock, ldloc:HttpConnection(this)))
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0002EB48 File Offset: 0x0002CD48
		public int Reuses
		{
			get
			{
				return this.reuses;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0002EB5C File Offset: 0x0002CD5C
		public IPEndPoint LocalEndPoint
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000EB2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.IPEndPoint System.Net.HttpConnection::get_LocalEndPoint()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stfld:IPEndPoint(HttpConnection::local_ep, ldloc:HttpConnection(this), ldloc:EndPoint[exp:IPEndPoint](var_0_13))
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

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0002EB94 File Offset: 0x0002CD94
		public IPEndPoint RemoteEndPoint
		{
			get
			{
				if (this.sock.RemoteEndPoint != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
		public bool IsSecure
		{
			get
			{
				return this.secure;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0002EBC8 File Offset: 0x0002CDC8
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x0002EBDC File Offset: 0x0002CDDC
		public ListenerPrefix Prefix
		{
			get
			{
				return this.prefix;
			}
			set
			{
				this.prefix = value;
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		private void OnTimeout(object unused)
		{
			this.CloseSocket();
			this.Unbind();
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0002EC0C File Offset: 0x0002CE0C
		public void BeginReadRequest()
		{
			if (this.buffer == null)
			{
			}
			int num = this.reuses;
			int num2 = 15000;
			this.s_timeout = num2;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0002EC78 File Offset: 0x0002CE78
		public RequestStream GetRequestStream(bool chunked, long contentlength)
		{
			/*
An exception occurred when decompiling this method (06000EB9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.RequestStream System.Net.HttpConnection::GetRequestStream(System.Boolean,System.Int64)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MemoryStream(var_0_0E, ldfld:MemoryStream(HttpConnection::ms, ldloc:HttpConnection(this)))
	stloc:MemoryStream(var_1_15, ldfld:MemoryStream(HttpConnection::ms, ldloc:HttpConnection(this)))
	stloc:HttpListenerContext(var_2_1C, ldfld:HttpListenerContext(HttpConnection::context, ldloc:HttpConnection(this)))
	stloc:int32(var_3_1E, ldc.i4:int32(1))
	stfld:bool(HttpConnection::chunked, ldloc:HttpConnection(this), ldloc:int32[exp:bool](var_3_1E))
	stloc:HttpListenerResponse(var_4_2C, ldfld:HttpListenerResponse(HttpListenerContext::response, ldloc:HttpListenerContext(var_2_1C)))
	stloc:int32(var_5_2F, ldc.i4:int32(1))
	callsetter:bool(HttpListenerResponse::set_SendChunked, ldloc:HttpListenerResponse(var_4_2C), ldloc:int32[exp:bool](var_5_2F))
	stloc:HttpListenerContext(var_6_40, ldfld:HttpListenerContext(HttpConnection::context, ldloc:HttpConnection(this)))
	stloc:Stream(var_7_48, ldfld:Stream(HttpConnection::stream, ldloc:HttpConnection(this)))
	stloc:int32(var_8_50, ldfld:int32(HttpConnection::position, ldloc:HttpConnection(this)))
	stloc:Stream(var_9_58, ldfld:Stream(HttpConnection::stream, ldloc:HttpConnection(this)))
	stloc:int32(var_10_60, ldfld:int32(HttpConnection::position, ldloc:HttpConnection(this)))
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

		// Token: 0x06000EBA RID: 3770 RVA: 0x0002ECE8 File Offset: 0x0002CEE8
		public ResponseStream GetResponseStream()
		{
			ResponseStream responseStream;
			HttpListener listener;
			do
			{
				responseStream = this.o_stream;
				if (responseStream != null)
				{
					return responseStream;
				}
				HttpListenerContext httpListenerContext = this.context;
				Stream stream = this.stream;
				listener = httpListenerContext.Listener;
				HttpListenerResponse response = httpListenerContext.response;
			}
			while (listener == null);
			bool ignore_write_exceptions = listener.ignore_write_exceptions;
			this.o_stream = responseStream;
			return responseStream;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0002ED30 File Offset: 0x0002CF30
		private static void OnRead(IAsyncResult ares)
		{
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0002ED44 File Offset: 0x0002CF44
		private void OnReadInternal(IAsyncResult ares)
		{
			HttpListenerContext httpListenerContext;
			string error;
			HttpListenerContext httpListenerContext2;
			for (;;)
			{
				Timer timer = this.timer;
				Stream stream = this.stream;
				MemoryStream memoryStream = this.ms;
				byte[] array = this.buffer;
				MemoryStream memoryStream2 = this.ms;
				if (stream == null)
				{
					goto IL_0154;
				}
				MemoryStream memoryStream3 = this.ms;
				bool flag = this.ProcessInput(memoryStream3);
				httpListenerContext = this.context;
				error = httpListenerContext.error;
				if (error != null)
				{
					break;
				}
				httpListenerContext2 = this.context;
				if (httpListenerContext2.error == null)
				{
					goto Block_2;
				}
			}
			int err_status = httpListenerContext.err_status;
			this.SendError(error, err_status);
			int num = 1;
			this.Close(num != 0);
			return;
			Block_2:
			bool flag2 = this.epl.BindContext(httpListenerContext2);
			HttpListenerContext httpListenerContext3 = this.context;
			HttpListener httpListener = this.last_listener;
			HttpListener listener = httpListenerContext3.Listener;
			this.RemoveConnection();
			Hashtable connections = listener.connections;
			HttpListenerContext httpListenerContext4 = this.context;
			this.last_listener = listener;
			int num2 = 1;
			this.context_bound = num2 != 0;
			listener.RegisterContext(httpListenerContext4);
			return;
			IL_0154:
			this.CloseSocket();
			this.Unbind();
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		private void RemoveConnection()
		{
			HttpListener httpListener = this.last_listener;
			if (httpListener != null)
			{
				Hashtable connections = httpListener.connections;
				return;
			}
			this.epl.RemoveConnection(this);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
		private bool ProcessInput(MemoryStream ms)
		{
			bool flag;
			for (;;)
			{
				if (this.context.error != null)
				{
				}
				int num = this.position;
				int num2 = this.position;
				this.position = num2;
				string text;
				if (text == null)
				{
					goto IL_0087;
				}
				flag = text == "";
				HttpConnection.InputState inputState = this.input_state;
				if (inputState != HttpConnection.InputState.RequestLine)
				{
					break;
				}
				if (this.context.error == null)
				{
					goto Block_2;
				}
			}
			return flag;
			Block_2:
			int num3 = this.position;
			IL_0087:
			HttpListenerContext httpListenerContext = this.context;
			this.context.error = "Bad request";
			HttpListenerContext httpListenerContext2 = this.context;
			int num4 = 400;
			httpListenerContext2.err_status = num4;
			return "Bad request" != null;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0002EFB4 File Offset: 0x0002D1B4
		private string ReadLine(byte[] buffer, int offset, int len, int used)
		{
			/*
An exception occurred when decompiling this method (06000EBF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String System.Net.HttpConnection::ReadLine(System.Byte[],System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000E:
	stloc:int32(var_1_0F, ldc.i4:int32(2))
	stloc:int32(var_2_11, ldc.i4:int32(1))
	stloc:LineState(var_3_18, ldfld:LineState(HttpConnection::line_state, ldloc:HttpConnection(this)))
	stfld:LineState(HttpConnection::line_state, ldloc:HttpConnection(this), ldloc:int32[exp:LineState](var_2_11))
	stfld:LineState(HttpConnection::line_state, ldloc:HttpConnection(this), ldloc:int32[exp:LineState](var_1_0F))
	stloc:StringBuilder(var_4_2D, ldfld:StringBuilder(HttpConnection::current_line, ldloc:HttpConnection(this)))
	stloc:LineState(var_6_35, ldfld:LineState(HttpConnection::line_state, ldloc:HttpConnection(this)))
	stloc:StringBuilder(var_7_3D, ldfld:StringBuilder(HttpConnection::current_line, ldloc:HttpConnection(this)))
	stloc:StringBuilder(var_8_45, ldfld:StringBuilder(HttpConnection::current_line, ldloc:HttpConnection(this)))
	stloc:int64(var_9_48, ldc.i4:int64(0))
	callsetter:int32(StringBuilder::set_Length, ldloc:StringBuilder(var_8_45), ldloc:int64[exp:int32](var_9_48))
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

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0002F018 File Offset: 0x0002D218
		public void SendError(string msg, int status)
		{
			HttpListenerResponse response = this.context.response;
			response.StatusCode = status;
			response.ContentType = "text/html";
			string text = HttpStatusDescription.Get(status);
			if (msg != null)
			{
				string text2 = string.Format("<h1>{0} ({1})</h1>", text, msg);
				return;
			}
			string text3 = string.Format("<h1>{0}</h1>", text);
			HttpListenerResponse response2 = this.context.response;
			if (response2.content_encoding == null)
			{
				Encoding @default = Encoding.Default;
				response2.content_encoding = @default;
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0002F098 File Offset: 0x0002D298
		public void SendError()
		{
			HttpListenerContext httpListenerContext = this.context;
			string error = httpListenerContext.error;
			int err_status = httpListenerContext.err_status;
			this.SendError(error, err_status);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0002F0C4 File Offset: 0x0002D2C4
		private void Unbind()
		{
			if (this.context_bound)
			{
				HttpListenerContext httpListenerContext = this.context;
				if (httpListenerContext != null && httpListenerContext.request != null)
				{
					httpListenerContext.Listener.UnregisterContext(httpListenerContext);
				}
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
		public void Close()
		{
			long num = 0L;
			this.Close(num != 0L);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0002F110 File Offset: 0x0002D310
		private void CloseSocket()
		{
			global::System.Net.Sockets.Socket socket = this.sock;
			if (socket != null)
			{
				socket.Close();
				this.RemoveConnection();
				return;
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0002F148 File Offset: 0x0002D348
		internal void Close(bool force_close)
		{
			if (this.sock != null)
			{
				if (this.GetResponseStream() != null)
				{
				}
				if (this.sock != null)
				{
					bool keepAlive = this.context.request.KeepAlive;
					bool flag = this.context.response.headers["connection"] == "close";
					bool flag2 = this.context.request.FlushInput();
					if (this.chunked)
					{
						bool force_close_chunked = this.context.response.force_close_chunked;
					}
					int num = this.reuses;
					this.reuses = num;
					this.Unbind();
					this.Init();
					this.BeginReadRequest();
					return;
				}
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0002F244 File Offset: 0x0002D444
		// Note: this type is marked as 'beforefieldinit'.
		static HttpConnection()
		{
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0002F254 File Offset: 0x0002D454
		[CompilerGenerated]
		private bool <.ctor>b__24_0(object t, X509Certificate c, global::System.Security.Cryptography.X509Certificates.X509Chain ch, global::System.Net.Security.SslPolicyErrors e)
		{
			if (c != null)
			{
				return;
			}
		}

		// Token: 0x04000BF3 RID: 3059
		private static AsyncCallback onread_cb;

		// Token: 0x04000BF4 RID: 3060
		private const int BufferSize = 8192;

		// Token: 0x04000BF5 RID: 3061
		private global::System.Net.Sockets.Socket sock;

		// Token: 0x04000BF6 RID: 3062
		private Stream stream;

		// Token: 0x04000BF7 RID: 3063
		private EndPointListener epl;

		// Token: 0x04000BF8 RID: 3064
		private MemoryStream ms;

		// Token: 0x04000BF9 RID: 3065
		private byte[] buffer;

		// Token: 0x04000BFA RID: 3066
		private HttpListenerContext context;

		// Token: 0x04000BFB RID: 3067
		private StringBuilder current_line;

		// Token: 0x04000BFC RID: 3068
		private ListenerPrefix prefix;

		// Token: 0x04000BFD RID: 3069
		private RequestStream i_stream;

		// Token: 0x04000BFE RID: 3070
		private ResponseStream o_stream;

		// Token: 0x04000BFF RID: 3071
		private bool chunked;

		// Token: 0x04000C00 RID: 3072
		private int reuses;

		// Token: 0x04000C01 RID: 3073
		private bool context_bound;

		// Token: 0x04000C02 RID: 3074
		private bool secure;

		// Token: 0x04000C03 RID: 3075
		private X509Certificate cert;

		// Token: 0x04000C04 RID: 3076
		private int s_timeout = 24464;

		// Token: 0x04000C05 RID: 3077
		private Timer timer;

		// Token: 0x04000C06 RID: 3078
		private IPEndPoint local_ep;

		// Token: 0x04000C07 RID: 3079
		private HttpListener last_listener;

		// Token: 0x04000C08 RID: 3080
		private int[] client_cert_errors;

		// Token: 0x04000C09 RID: 3081
		private global::System.Security.Cryptography.X509Certificates.X509Certificate2 client_cert;

		// Token: 0x04000C0A RID: 3082
		private global::System.Net.Security.SslStream ssl_stream;

		// Token: 0x04000C0B RID: 3083
		private HttpConnection.InputState input_state;

		// Token: 0x04000C0C RID: 3084
		private HttpConnection.LineState line_state;

		// Token: 0x04000C0D RID: 3085
		private int position;

		// Token: 0x02000247 RID: 583
		private enum InputState
		{
			// Token: 0x04000C0F RID: 3087
			RequestLine,
			// Token: 0x04000C10 RID: 3088
			Headers
		}

		// Token: 0x02000248 RID: 584
		private enum LineState
		{
			// Token: 0x04000C12 RID: 3090
			None,
			// Token: 0x04000C13 RID: 3091
			CR,
			// Token: 0x04000C14 RID: 3092
			LF
		}
	}
}
