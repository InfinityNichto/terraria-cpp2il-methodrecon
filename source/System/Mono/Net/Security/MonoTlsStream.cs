using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000065 RID: 101
	internal class MonoTlsStream : IDisposable
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00005820 File Offset: 0x00003A20
		internal global::System.Net.HttpWebRequest Request
		{
			get
			{
				return this.request;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00005834 File Offset: 0x00003A34
		internal global::System.Net.WebExceptionStatus ExceptionStatus
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00005848 File Offset: 0x00003A48
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0000585C File Offset: 0x00003A5C
		internal bool CertificateValidationFailed
		{
			[CompilerGenerated]
			get
			{
				return this.<CertificateValidationFailed>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000586C File Offset: 0x00003A6C
		public MonoTlsStream(global::System.Net.HttpWebRequest request, global::System.Net.Sockets.NetworkStream networkStream)
		{
			this.networkStream = networkStream;
			this.request = request;
			MonoTlsSettings tlsSettings = request.tlsSettings;
			this.settings = tlsSettings;
			MobileTlsProvider providerInternal;
			if (request.tlsProvider == null)
			{
				providerInternal = MonoTlsProviderFactory.GetProviderInternal();
			}
			this.provider = providerInternal;
			this.status = global::System.Net.WebExceptionStatus.SecureChannelFailure;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000058B8 File Offset: 0x00003AB8
		internal Task<Stream> CreateStream(global::System.Net.WebConnectionTunnel tunnel, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06000187)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.IO.Stream> Mono.Net.Security.MonoTlsStream::CreateStream(System.Net.WebConnectionTunnel,System.Threading.CancellationToken)

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

		// Token: 0x06000188 RID: 392 RVA: 0x000058C8 File Offset: 0x00003AC8
		public void Dispose()
		{
			this.CloseSslStream();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000058DC File Offset: 0x00003ADC
		private void CloseSslStream()
		{
			object obj = this.sslStreamLock;
			global::System.Net.Security.SslStream sslStream = this.sslStream;
			if (sslStream != null)
			{
				sslStream.Dispose();
				return;
			}
			long num = 0L;
			Monitor.Exit(obj);
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0400011E RID: 286
		private readonly MobileTlsProvider provider;

		// Token: 0x0400011F RID: 287
		private readonly global::System.Net.Sockets.NetworkStream networkStream;

		// Token: 0x04000120 RID: 288
		private readonly global::System.Net.HttpWebRequest request;

		// Token: 0x04000121 RID: 289
		private readonly MonoTlsSettings settings;

		// Token: 0x04000122 RID: 290
		private global::System.Net.Security.SslStream sslStream;

		// Token: 0x04000123 RID: 291
		private readonly object sslStreamLock;

		// Token: 0x04000124 RID: 292
		private global::System.Net.WebExceptionStatus status;

		// Token: 0x04000125 RID: 293
		[CompilerGenerated]
		private bool <CertificateValidationFailed>k__BackingField;

		// Token: 0x02000066 RID: 102
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <CreateStream>d__18 : IAsyncStateMachine
		{
			// Token: 0x0600018A RID: 394 RVA: 0x00005930 File Offset: 0x00003B30
			private void MoveNext()
			{
				MonoTlsStream monoTlsStream = this.<>4__this;
				Task task = this.<>u__1.m_task;
			}

			// Token: 0x0600018B RID: 395 RVA: 0x00005A9C File Offset: 0x00003C9C
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000126 RID: 294
			public int <>1__state;

			// Token: 0x04000127 RID: 295
			public AsyncTaskMethodBuilder<Stream> <>t__builder;

			// Token: 0x04000128 RID: 296
			public MonoTlsStream <>4__this;

			// Token: 0x04000129 RID: 297
			public global::System.Net.WebConnectionTunnel tunnel;

			// Token: 0x0400012A RID: 298
			public CancellationToken cancellationToken;

			// Token: 0x0400012B RID: 299
			private global::System.Net.Sockets.Socket <socket>5__2;

			// Token: 0x0400012C RID: 300
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
