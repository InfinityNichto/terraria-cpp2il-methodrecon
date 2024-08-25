using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Net.Security;

namespace System.Net
{
	// Token: 0x02000280 RID: 640
	internal class WebConnection : IDisposable
	{
		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0003699C File Offset: 0x00034B9C
		public ServicePoint ServicePoint
		{
			[CompilerGenerated]
			get
			{
				return this.<ServicePoint>k__BackingField;
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x000369B0 File Offset: 0x00034BB0
		public WebConnection(ServicePoint sPoint)
		{
			this.ServicePoint = sPoint;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000369CC File Offset: 0x00034BCC
		[Conditional("MONO_WEB_DEBUG")]
		internal static void Debug(string message, params object[] args)
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000369DC File Offset: 0x00034BDC
		[Conditional("MONO_WEB_DEBUG")]
		internal static void Debug(string message)
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x000369EC File Offset: 0x00034BEC
		private bool CanReuse()
		{
			global::System.Net.Sockets.Socket socket = this.socket;
			bool flag;
			return flag;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00036A04 File Offset: 0x00034C04
		private bool CheckReusable()
		{
			global::System.Net.Sockets.Socket socket = this.socket;
			if (socket == null || socket.is_connected)
			{
				return;
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00036A2C File Offset: 0x00034C2C
		private Task Connect(WebOperation operation, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00036A48 File Offset: 0x00034C48
		private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001195)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Boolean> System.Net.WebConnection::CreateStream(System.Net.WebOperation,System.Boolean,System.Threading.CancellationToken)

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

		// Token: 0x06001196 RID: 4502 RVA: 0x00036A58 File Offset: 0x00034C58
		internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001196)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Net.WebRequestStream> System.Net.WebConnection::InitConnection(System.Net.WebOperation,System.Threading.CancellationToken)

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

		// Token: 0x06001197 RID: 4503 RVA: 0x00036A68 File Offset: 0x00034C68
		internal static WebException GetException(WebExceptionStatus status, Exception error)
		{
			/*
An exception occurred when decompiling this method (06001197)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.WebException System.Net.WebConnection::GetException(System.Net.WebExceptionStatus,System.Exception)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:WebExceptionStatus[exp:bool](status)))
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

		// Token: 0x06001198 RID: 4504 RVA: 0x00036A78 File Offset: 0x00034C78
		internal static bool ReadLine(byte[] buffer, int start, int max, string output)
		{
			int num;
			int num2;
			do
			{
				num = 1;
			}
			while (num2 == 0);
			if (num != 0)
			{
				return;
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00036AA8 File Offset: 0x00034CA8
		internal bool CanReuseConnection(WebOperation operation)
		{
			WebOperation webOperation;
			if (this.disposed == 0)
			{
				webOperation = this.currentOperation;
				if (webOperation == null)
				{
					goto IL_0022;
				}
			}
			long num = 0L;
			if (webOperation != null)
			{
				Monitor.Exit(this);
			}
			if (num != 0L)
			{
				throw new OutOfMemoryException();
			}
			IL_0022:
			HttpWebRequest <Request>k__BackingField;
			NetworkCredential networkCredential;
			if (this.ntlm_authenticated)
			{
				<Request>k__BackingField = operation.<Request>k__BackingField;
				networkCredential = this.ntlm_credentials;
				if (<Request>k__BackingField != null)
				{
				}
			}
			while (<Request>k__BackingField == null)
			{
			}
			while (networkCredential == null)
			{
			}
			while (<Request>k__BackingField == null)
			{
			}
			string text;
			bool flag = networkCredential.Domain != text;
			string userName = networkCredential.UserName;
			string text2;
			bool flag2 = text2 != text2;
			string text3;
			bool flag3 = networkCredential.Password != text3;
			bool unsafe_auth_blah = <Request>k__BackingField.unsafe_auth_blah;
			bool flag4 = this.unsafe_sharing;
			return flag3;
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00036B64 File Offset: 0x00034D64
		private bool PrepareSharingNtlm(WebOperation operation)
		{
			/*
An exception occurred when decompiling this method (0600119A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebConnection::PrepareSharingNtlm(System.Net.WebOperation)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0050:
	stloc:bool(var_9_59, ldfld:bool(HttpWebRequest::unsafe_auth_blah, ldloc:HttpWebRequest(var_0)))
	stloc:bool(var_10_61, ldfld:bool(WebConnection::unsafe_sharing, ldloc:WebConnection(this)))
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

		// Token: 0x0600119B RID: 4507 RVA: 0x00036BD4 File Offset: 0x00034DD4
		private void Reset()
		{
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00036C0C File Offset: 0x00034E0C
		private void Close(bool reset)
		{
			Monitor.Enter(this, reset);
			this.CloseSocket();
			this.Reset();
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00036C58 File Offset: 0x00034E58
		private void CloseSocket()
		{
			Stream stream = this.networkStream;
			if (stream != null)
			{
				stream.Dispose();
			}
			Mono.Net.Security.MonoTlsStream monoTlsStream = this.monoTlsStream;
			if (monoTlsStream != null)
			{
				monoTlsStream.Dispose();
			}
			global::System.Net.Sockets.Socket socket = this.socket;
			if (socket != null)
			{
				socket.Dispose();
			}
			long num = 0L;
			Monitor.Exit(this);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x00036CD8 File Offset: 0x00034ED8
		public bool Closed
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600119E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebConnection::get_Closed()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(WebConnection::disposed, ldloc:WebConnection(this)))
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

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00036CEC File Offset: 0x00034EEC
		public bool Busy
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600119F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.WebConnection::get_Busy()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:WebOperation(var_0_06, ldfld:WebOperation(WebConnection::currentOperation, ldloc:WebConnection(this)))
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

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00036D00 File Offset: 0x00034F00
		public DateTime IdleSince
		{
			get
			{
				DateTime dateTime = this.idleSince;
				DateTime dateTime2;
				return dateTime2;
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00036D18 File Offset: 0x00034F18
		public bool StartOperation(WebOperation operation, bool reused)
		{
			int num = this.disposed;
			if (num != 0 || this != null)
			{
				long num2 = 0L;
				int num3 = 3;
				if (num != 0)
				{
					Monitor.Exit(this);
				}
				if (num2 != 0L)
				{
					goto IL_0083;
				}
				if (num3 == 0)
				{
					operation.Run();
				}
			}
			DateTime utcNow = DateTime.UtcNow;
			TimeSpan timeSpan = TimeSpan.FromDays(3650.0);
			DateTime dateTime = utcNow + timeSpan;
			this.idleSince = dateTime;
			bool flag = this.PrepareSharingNtlm(operation);
			int num4 = 1;
			this.Close(num4 != 0);
			ServicePoint servicePoint = this.<ServicePoint>k__BackingField;
			operation.RegisterRequest(servicePoint, this);
			IL_0083:
			throw new OutOfMemoryException();
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00036DC0 File Offset: 0x00034FC0
		public bool Continue(WebOperation next)
		{
			bool is_connected;
			if (this.disposed == 0)
			{
				global::System.Net.Sockets.Socket socket = this.socket;
				if (socket != null)
				{
					is_connected = socket.is_connected;
					if (is_connected)
					{
						bool flag = this.PrepareSharingNtlm(next);
						this.currentOperation = next;
						if (next == null)
						{
							return true;
						}
						ServicePoint servicePoint = this.<ServicePoint>k__BackingField;
						next.RegisterRequest(servicePoint, this);
					}
				}
				this.Close(true);
			}
			long num = 0L;
			if (is_connected)
			{
				Monitor.Exit(this);
			}
			if (num == 0L)
			{
				if (3 == 0)
				{
					next.Run();
				}
				return true;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00036E50 File Offset: 0x00035050
		private void Dispose(bool disposing)
		{
			int num;
			if (num != 0)
			{
				return;
			}
			int num2 = 1;
			this.Close(num2 != 0);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00036E6C File Offset: 0x0003506C
		public void Dispose()
		{
			long num = 0L;
			this.Dispose(num != 0L);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00036E84 File Offset: 0x00035084
		private void ResetNtlm()
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00036E94 File Offset: 0x00035094
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00036EA8 File Offset: 0x000350A8
		internal bool NtlmAuthenticated
		{
			get
			{
				return this.ntlm_authenticated;
			}
			set
			{
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00036EB8 File Offset: 0x000350B8
		internal NetworkCredential NtlmCredential
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				this.ntlm_credentials = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00036ECC File Offset: 0x000350CC
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00036EE0 File Offset: 0x000350E0
		internal bool UnsafeAuthenticatedConnectionSharing
		{
			get
			{
				return this.unsafe_sharing;
			}
			set
			{
			}
		}

		// Token: 0x04000D9A RID: 3482
		private NetworkCredential ntlm_credentials;

		// Token: 0x04000D9B RID: 3483
		private bool ntlm_authenticated;

		// Token: 0x04000D9C RID: 3484
		private bool unsafe_sharing;

		// Token: 0x04000D9D RID: 3485
		private Stream networkStream;

		// Token: 0x04000D9E RID: 3486
		private global::System.Net.Sockets.Socket socket;

		// Token: 0x04000D9F RID: 3487
		private Mono.Net.Security.MonoTlsStream monoTlsStream;

		// Token: 0x04000DA0 RID: 3488
		private WebConnectionTunnel tunnel;

		// Token: 0x04000DA1 RID: 3489
		private int disposed;

		// Token: 0x04000DA2 RID: 3490
		[CompilerGenerated]
		private readonly ServicePoint <ServicePoint>k__BackingField;

		// Token: 0x04000DA3 RID: 3491
		internal readonly int ID;

		// Token: 0x04000DA4 RID: 3492
		private DateTime idleSince;

		// Token: 0x04000DA5 RID: 3493
		private WebOperation currentOperation;

		// Token: 0x02000281 RID: 641
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060011AC RID: 4524 RVA: 0x00036EF0 File Offset: 0x000350F0
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060011AD RID: 4525 RVA: 0x00036F00 File Offset: 0x00035100
			public <>c()
			{
			}

			// Token: 0x060011AE RID: 4526 RVA: 0x00036F14 File Offset: 0x00035114
			internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state)
			{
				if (state != null)
				{
				}
				IAsyncResult asyncResult;
				return asyncResult;
			}

			// Token: 0x060011AF RID: 4527 RVA: 0x00036F2C File Offset: 0x0003512C
			internal void <Connect>b__16_1(IAsyncResult asyncResult)
			{
			}

			// Token: 0x04000DA6 RID: 3494
			public static readonly WebConnection.<>c <>9;

			// Token: 0x04000DA7 RID: 3495
			public static Func<IPEndPoint, AsyncCallback, object, IAsyncResult> <>9__16_0;

			// Token: 0x04000DA8 RID: 3496
			public static Action<IAsyncResult> <>9__16_1;
		}

		// Token: 0x02000282 RID: 642
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <Connect>d__16 : IAsyncStateMachine
		{
			// Token: 0x060011B0 RID: 4528 RVA: 0x00036F44 File Offset: 0x00035144
			private void MoveNext()
			{
				WebConnection webConnection = this.<>4__this;
				IPHostEntry hostEntry = webConnection.<ServicePoint>k__BackingField.HostEntry;
				if (hostEntry != null)
				{
					IPAddress[] addressList = hostEntry.addressList;
					ushort[] numbers = addressList._numbers;
					if (numbers != null)
					{
						this.<>7__wrap2 = addressList;
						return;
					}
				}
				bool usesProxy = webConnection.<ServicePoint>k__BackingField.usesProxy;
			}

			// Token: 0x060011B1 RID: 4529 RVA: 0x000370E8 File Offset: 0x000352E8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000DA9 RID: 3497
			public int <>1__state;

			// Token: 0x04000DAA RID: 3498
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000DAB RID: 3499
			public WebConnection <>4__this;

			// Token: 0x04000DAC RID: 3500
			public WebOperation operation;

			// Token: 0x04000DAD RID: 3501
			public CancellationToken cancellationToken;

			// Token: 0x04000DAE RID: 3502
			private Exception <connectException>5__2;

			// Token: 0x04000DAF RID: 3503
			private IPAddress[] <>7__wrap2;

			// Token: 0x04000DB0 RID: 3504
			private int <>7__wrap3;

			// Token: 0x04000DB1 RID: 3505
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000283 RID: 643
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <CreateStream>d__18 : IAsyncStateMachine
		{
			// Token: 0x060011B2 RID: 4530 RVA: 0x000370F8 File Offset: 0x000352F8
			private void MoveNext()
			{
				WebConnection webConnection = this.<>4__this;
			}

			// Token: 0x060011B3 RID: 4531 RVA: 0x00037258 File Offset: 0x00035458
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000DB2 RID: 3506
			public int <>1__state;

			// Token: 0x04000DB3 RID: 3507
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			// Token: 0x04000DB4 RID: 3508
			public WebConnection <>4__this;

			// Token: 0x04000DB5 RID: 3509
			public WebOperation operation;

			// Token: 0x04000DB6 RID: 3510
			public bool reused;

			// Token: 0x04000DB7 RID: 3511
			public CancellationToken cancellationToken;

			// Token: 0x04000DB8 RID: 3512
			private global::System.Net.Sockets.NetworkStream <stream>5__2;

			// Token: 0x04000DB9 RID: 3513
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000DBA RID: 3514
			private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000284 RID: 644
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <InitConnection>d__19 : IAsyncStateMachine
		{
			// Token: 0x060011B4 RID: 4532 RVA: 0x00037268 File Offset: 0x00035468
			private void MoveNext()
			{
				WebConnection webConnection = this.<>4__this;
				Task task = this.<>u__2.m_task;
			}

			// Token: 0x060011B5 RID: 4533 RVA: 0x000373C8 File Offset: 0x000355C8
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000DBB RID: 3515
			public int <>1__state;

			// Token: 0x04000DBC RID: 3516
			public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder;

			// Token: 0x04000DBD RID: 3517
			public WebOperation operation;

			// Token: 0x04000DBE RID: 3518
			public CancellationToken cancellationToken;

			// Token: 0x04000DBF RID: 3519
			public WebConnection <>4__this;

			// Token: 0x04000DC0 RID: 3520
			private bool <reused>5__2;

			// Token: 0x04000DC1 RID: 3521
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000DC2 RID: 3522
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
