using System;
using System.Net.WebSockets;
using System.Security.Principal;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200024C RID: 588
	public sealed class HttpListenerContext
	{
		// Token: 0x06000EF7 RID: 3831 RVA: 0x0002FC98 File Offset: 0x0002DE98
		internal HttpListenerContext(HttpConnection cnc)
		{
			this.err_status = 400;
			base..ctor();
			this.cnc = cnc;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0002FCC0 File Offset: 0x0002DEC0
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x0002FCD4 File Offset: 0x0002DED4
		internal int ErrorStatus
		{
			get
			{
				return this.err_status;
			}
			set
			{
				this.err_status = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0002FCE8 File Offset: 0x0002DEE8
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		internal string ErrorMessage
		{
			get
			{
				return this.error;
			}
			set
			{
				this.error = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0002FD10 File Offset: 0x0002DF10
		internal bool HaveError
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000EFC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.HttpListenerContext::get_HaveError()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_06, ldfld:string(HttpListenerContext::error, ldloc:HttpListenerContext(this)))
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

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0002FD24 File Offset: 0x0002DF24
		internal HttpConnection Connection
		{
			get
			{
				return this.cnc;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x0002FD38 File Offset: 0x0002DF38
		public HttpListenerRequest Request
		{
			get
			{
				return this.request;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0002FD4C File Offset: 0x0002DF4C
		public HttpListenerResponse Response
		{
			get
			{
				return this.response;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0002FD60 File Offset: 0x0002DF60
		public IPrincipal User
		{
			get
			{
				return this.user;
			}
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0002FD74 File Offset: 0x0002DF74
		internal void ParseAuthentication(AuthenticationSchemes expectedSchemes)
		{
			string text = this.request.headers["Authorization"];
			if (text != null)
			{
				int stringLength = text._stringLength;
				string[] array;
				if (string.Compare(array, "basic", true) == 0)
				{
					IPrincipal principal;
					this.user = principal;
				}
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0002FDB8 File Offset: 0x0002DFB8
		internal IPrincipal ParseBasicAuthentication(string authData)
		{
			/*
An exception occurred when decompiling this method (06000F02)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Principal.IPrincipal System.Net.HttpListenerContext::ParseBasicAuthentication(System.String)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Encoding(var_1_07, callgetter:Encoding(Encoding::get_Default))
	stloc:uint8[](var_2_0E, call:uint8[](Convert::FromBase64String, ldloc:string(authData)))
	stloc:int32(var_8_17, ldc.i4:int32(92))
	stloc:int32(var_9_22, call:int32(string::IndexOf, ldloc:string(var_7), ldloc:int32[exp:char](var_8_17)))
	stloc:string(var_10_2D, call:string(string::Substring, ldloc:string(var_7), ldloc:int32(var_9_22)))
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

		// Token: 0x06000F03 RID: 3843 RVA: 0x00002050 File Offset: 0x00000250
		[MonoTODO]
		public Task<global::System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
		[MonoTODO]
		public Task<global::System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, TimeSpan keepAliveInterval)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
		[MonoTODO]
		public Task<global::System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
		[MonoTODO]
		public Task<global::System.Net.WebSockets.HttpListenerWebSocketContext> AcceptWebSocketAsync(string subProtocol, int receiveBufferSize, TimeSpan keepAliveInterval, ArraySegment<byte> internalBuffer)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0002FDFC File Offset: 0x0002DFFC
		internal HttpListenerContext()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000C29 RID: 3113
		private HttpListenerRequest request;

		// Token: 0x04000C2A RID: 3114
		private HttpListenerResponse response;

		// Token: 0x04000C2B RID: 3115
		private IPrincipal user;

		// Token: 0x04000C2C RID: 3116
		private HttpConnection cnc;

		// Token: 0x04000C2D RID: 3117
		private string error;

		// Token: 0x04000C2E RID: 3118
		private int err_status;

		// Token: 0x04000C2F RID: 3119
		internal HttpListener Listener;
	}
}
