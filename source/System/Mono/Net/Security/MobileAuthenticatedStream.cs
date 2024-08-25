using System;
using System.Diagnostics;
using System.IO;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000057 RID: 87
	internal abstract class MobileAuthenticatedStream : global::System.Net.Security.AuthenticatedStream, IDisposable
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x0000451C File Offset: 0x0000271C
		public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, global::System.Net.Security.SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
		{
			if (!true)
			{
			}
			base..ctor(innerStream, leaveInnerStreamOpen);
			this.SslStream = owner;
			this.Settings = settings;
			this.Provider = provider;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00004558 File Offset: 0x00002758
		public global::System.Net.Security.SslStream SslStream
		{
			[CompilerGenerated]
			get
			{
				return this.<SslStream>k__BackingField;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000456C File Offset: 0x0000276C
		public MonoTlsSettings Settings
		{
			[CompilerGenerated]
			get
			{
				return this.<Settings>k__BackingField;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00004580 File Offset: 0x00002780
		public MobileTlsProvider Provider
		{
			[CompilerGenerated]
			get
			{
				return this.<Provider>k__BackingField;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00004594 File Offset: 0x00002794
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000045A8 File Offset: 0x000027A8
		internal string TargetHost
		{
			[CompilerGenerated]
			get
			{
				return this.<TargetHost>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<TargetHost>k__BackingField = value;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000045BC File Offset: 0x000027BC
		internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
		{
			do
			{
				ExceptionDispatchInfo exceptionDispatchInfo = this.lastException;
				if (exceptionDispatchInfo != null)
				{
					exceptionDispatchInfo.Throw();
				}
			}
			while (this.shutdown);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000045E4 File Offset: 0x000027E4
		internal static Exception GetSSPIException(Exception e)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000045F4 File Offset: 0x000027F4
		internal static Exception GetIOException(Exception e, string message)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		internal static Exception GetInternalError()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		internal static Exception GetInvalidNestedCallException()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004604 File Offset: 0x00002804
		internal ExceptionDispatchInfo SetException(Exception e)
		{
			return ExceptionDispatchInfo.Capture(e);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004618 File Offset: 0x00002818
		public void AuthenticateAsClient(string targetHost, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, global::System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			CancellationToken none = CancellationToken.None;
			Task task;
			task.Wait();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004638 File Offset: 0x00002838
		public void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, global::System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			CancellationToken none = CancellationToken.None;
			Task task;
			task.Wait();
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004658 File Offset: 0x00002858
		public Task AuthenticateAsClientAsync(string targetHost, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, global::System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			CancellationToken none = CancellationToken.None;
			Task task;
			return task;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004670 File Offset: 0x00002870
		private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06000102 RID: 258
		protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

		// Token: 0x06000103 RID: 259 RVA: 0x0000468C File Offset: 0x0000288C
		public override int Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06000103)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Net.Security.MobileAuthenticatedStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CancellationToken(var_1_07, callgetter:CancellationToken(CancellationToken::get_None))
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

		// Token: 0x06000104 RID: 260 RVA: 0x000046A0 File Offset: 0x000028A0
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (!true)
			{
			}
			CancellationToken none = CancellationToken.None;
			Task<int> task;
			task.Wait();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000046C0 File Offset: 0x000028C0
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Task<int> task;
			return task;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000046D0 File Offset: 0x000028D0
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000046E0 File Offset: 0x000028E0
		private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06000107)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> Mono.Net.Security.MobileAuthenticatedStream::StartOperation(Mono.Net.Security.MobileAuthenticatedStream/OperationType,Mono.Net.Security.AsyncProtocolRequest,System.Threading.CancellationToken)

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

		// Token: 0x06000108 RID: 264 RVA: 0x000046F0 File Offset: 0x000028F0
		internal int InternalRead(byte[] buffer, int offset, int size, [Out] bool outWantMore)
		{
			/*
An exception occurred when decompiling this method (06000108)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Net.Security.MobileAuthenticatedStream::InternalRead(System.Byte[],System.Int32,System.Int32,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_000F:
	stloc:BufferOffsetSize2(var_1_15, ldfld:BufferOffsetSize2(MobileAuthenticatedStream::readBuffer, ldloc:MobileAuthenticatedStream(this)))
	stloc:valuetype [mscorlib]System.ValueTuple`2<int32, bool>(var_2_21, call:ValueTuple`2[exp:valuetype [mscorlib]System.ValueTuple`2<int32, bool>](MobileAuthenticatedStream::InternalRead, ldloc:MobileAuthenticatedStream(this), ldloc:AsyncProtocolRequest(var_0), ldloc:BufferOffsetSize2[exp:BufferOffsetSize](var_1_15), ldloc:uint8[](buffer), ldloc:int32(offset), ldloc:int32(size)))
	stfld:bool(bool::m_value, ldloc:bool[exp:bool&](outWantMore), ldloc:AsyncProtocolRequest[exp:bool](var_0))
	stloc:ExceptionDispatchInfo(var_4_30, call:ExceptionDispatchInfo(ExceptionDispatchInfo::Capture, ldloc:Exception(var_3)))
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

		// Token: 0x06000109 RID: 265 RVA: 0x00004734 File Offset: 0x00002934
		private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size)
		{
			/*
An exception occurred when decompiling this method (06000109)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ValueTuple`2<System.Int32,System.Boolean> Mono.Net.Security.MobileAuthenticatedStream::InternalRead(Mono.Net.Security.AsyncProtocolRequest,Mono.Net.Security.BufferOffsetSize,System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:int32(var_1_1D, call:int32(Math::Min, ldloc:int32(var_0_09), ldloc:int32(size)))
	stloc:uint8[](var_2_24, ldfld:uint8[](BufferOffsetSize::Buffer, ldloc:BufferOffsetSize(internalBuffer)))
	stloc:int32(var_3_2B, ldfld:int32(BufferOffsetSize::Offset, ldloc:BufferOffsetSize(internalBuffer)))
	call:void(Buffer::BlockCopy, ldloc:uint8[][exp:Array](var_2_24), ldloc:int32(var_3_2B), ldloc:uint8[][exp:Array](buffer), ldloc:int32(offset), ldloc:int32(var_1_1D))
	stloc:int32(var_4_3D, ldfld:int32(BufferOffsetSize::Offset, ldloc:BufferOffsetSize(internalBuffer)))
	stloc:int32(var_5_45, ldfld:int32(BufferOffsetSize::TotalBytes, ldloc:BufferOffsetSize(internalBuffer)))
	stloc:bool(var_6_4D, ldfld:bool(BufferOffsetSize::Complete, ldloc:BufferOffsetSize(internalBuffer)))
	stfld:int32(BufferOffsetSize::Offset, ldloc:BufferOffsetSize(internalBuffer), ldloc:int32(var_4_3D))
	stfld:int32(BufferOffsetSize::TotalBytes, ldloc:BufferOffsetSize(internalBuffer), ldloc:int32(var_5_45))
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

		// Token: 0x0600010A RID: 266 RVA: 0x000047A0 File Offset: 0x000029A0
		internal bool InternalWrite(byte[] buffer, int offset, int size)
		{
			MobileAuthenticatedStream.Operation operation = this.operation;
			AsyncProtocolRequest asyncProtocolRequest;
			if (this.asyncHandshakeRequest == null && this.asyncWriteRequest == null)
			{
				MobileTlsContext mobileTlsContext = this.xobileTlsContext;
				asyncProtocolRequest = this.asyncReadRequest;
				if (asyncProtocolRequest == null)
				{
					MobileAuthenticatedStream.Operation operation2 = this.operation;
				}
			}
			BufferOffsetSize2 bufferOffsetSize = this.writeBuffer;
			return this.InternalWrite(asyncProtocolRequest, bufferOffsetSize, buffer, offset, size);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004814 File Offset: 0x00002A14
		private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size)
		{
			/*
An exception occurred when decompiling this method (0600010B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Net.Security.MobileAuthenticatedStream::InternalWrite(Mono.Net.Security.AsyncProtocolRequest,Mono.Net.Security.BufferOffsetSize2,System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_003B:
	call:void(BufferOffsetSize2::Reset, ldloc:BufferOffsetSize2(internalBuffer))
	call:void(BufferOffsetSize2::AppendData, ldloc:BufferOffsetSize2(internalBuffer), ldloc:uint8[](buffer), ldloc:int32(offset), ldc.i4:int32(0))
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

		// Token: 0x0600010C RID: 268 RVA: 0x00004870 File Offset: 0x00002A70
		internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (0600010C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> Mono.Net.Security.MobileAuthenticatedStream::InnerRead(System.Boolean,System.Int32,System.Threading.CancellationToken)

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

		// Token: 0x0600010D RID: 269 RVA: 0x00004880 File Offset: 0x00002A80
		internal Task InnerWrite(bool sync, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000489C File Offset: 0x00002A9C
		internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate)
		{
			object obj = this.ioLock;
			MobileAuthenticatedStream.Operation operation = this.operation;
			if (status != AsyncOperationStatus.Initialize)
			{
				MobileTlsContext mobileTlsContext = this.xobileTlsContext;
				MobileTlsContext mobileTlsContext2 = this.xobileTlsContext;
				int num = 2;
				this.operation = (MobileAuthenticatedStream.Operation)num;
				int num2 = 3;
				this.operation = (MobileAuthenticatedStream.Operation)num2;
				while (status != AsyncOperationStatus.Initialize)
				{
				}
			}
			MobileTlsContext mobileTlsContext3 = this.xobileTlsContext;
			if (mobileTlsContext3 != null)
			{
			}
			long num3 = 0L;
			Monitor.Exit(obj);
			if (num3 == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000493C File Offset: 0x00002B3C
		internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer)
		{
			object obj = this.ioLock;
			MobileAuthenticatedStream.Operation operation = this.operation;
			MobileTlsContext mobileTlsContext = this.xobileTlsContext;
			this.operation = MobileAuthenticatedStream.Operation.Read;
			byte[] buffer = userBuffer.Buffer;
			int offset = userBuffer.Offset;
			int totalBytes = userBuffer.TotalBytes;
			ExceptionDispatchInfo exceptionDispatchInfo = this.lastException;
			if (exceptionDispatchInfo != null)
			{
				exceptionDispatchInfo.Throw();
			}
			long num = 0L;
			this.operation = MobileAuthenticatedStream.Operation.Authenticated;
			if (2 != 0)
			{
				Monitor.Exit(obj);
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000049D4 File Offset: 0x00002BD4
		internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer)
		{
			object obj = this.ioLock;
			MobileAuthenticatedStream.Operation operation = this.operation;
			MobileTlsContext mobileTlsContext = this.xobileTlsContext;
			this.operation = MobileAuthenticatedStream.Operation.Write;
			byte[] buffer = userBuffer.Buffer;
			int offset = userBuffer.Offset;
			int totalBytes = userBuffer.TotalBytes;
			ExceptionDispatchInfo exceptionDispatchInfo = this.lastException;
			if (exceptionDispatchInfo != null)
			{
				exceptionDispatchInfo.Throw();
			}
			long num = 0L;
			this.operation = MobileAuthenticatedStream.Operation.Authenticated;
			if (2 != 0)
			{
				Monitor.Exit(obj);
			}
			if (num == 0L)
			{
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00004A6C File Offset: 0x00002C6C
		public override bool IsAuthenticated
		{
			get
			{
				object obj = this.ioLock;
				if (this.xobileTlsContext == null || this.lastException != null)
				{
				}
				long num = 0L;
				Monitor.Exit(obj);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004ABC File Offset: 0x00002CBC
		protected override void Dispose(bool disposing)
		{
			object obj = this.ioLock;
			Monitor.Enter(obj, disposing);
			MobileTlsContext mobileTlsContext = this.xobileTlsContext;
			if (mobileTlsContext != null)
			{
				mobileTlsContext.Dispose();
				return;
			}
			long num = 0L;
			long num2;
			if ("MobileAuthenticatedStream" != null)
			{
				num2 = 0L;
				Monitor.Exit(obj);
			}
			if (num == 0L)
			{
				base.Dispose(num2 != 0L);
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004B58 File Offset: 0x00002D58
		public override void Flush()
		{
			Stream innerStream = this._InnerStream;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004B6C File Offset: 0x00002D6C
		public X509Certificate LocalCertificate
		{
			get
			{
				object obj = this.ioLock;
				long num = 0L;
				this.CheckThrow(true, num != 0L);
				X509Certificate internalLocalCertificate = this.InternalLocalCertificate;
				long num2 = 0L;
				Monitor.Exit(obj);
				if (num2 == 0L)
				{
					return internalLocalCertificate;
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public X509Certificate InternalLocalCertificate
		{
			get
			{
				object obj = this.ioLock;
				ExceptionDispatchInfo exceptionDispatchInfo = this.lastException;
				if (exceptionDispatchInfo != null)
				{
					exceptionDispatchInfo.Throw();
				}
				MobileTlsContext mobileTlsContext = this.xobileTlsContext;
				if (mobileTlsContext != null && mobileTlsContext.<IsServer>k__BackingField)
				{
					X509Certificate <LocalServerCertificate>k__BackingField = mobileTlsContext.<LocalServerCertificate>k__BackingField;
				}
				long num = 0L;
				Monitor.Exit(obj);
				if (num == 0L)
				{
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004C2C File Offset: 0x00002E2C
		public override void SetLength(long value)
		{
			Stream innerStream = this._InnerStream;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004C40 File Offset: 0x00002E40
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000118)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Net.Security.MobileAuthenticatedStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](this)))
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00004C58 File Offset: 0x00002E58
		public override bool CanTimeout
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000119)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Net.Security.MobileAuthenticatedStream::get_CanTimeout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](this)))
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00004C6C File Offset: 0x00002E6C
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600011A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Mono.Net.Security.MobileAuthenticatedStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](this)))
	stloc:bool(var_2_0F, ldfld:bool(MobileAuthenticatedStream::shutdown, ldloc:MobileAuthenticatedStream(this)))
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

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00004C88 File Offset: 0x00002E88
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00004C98 File Offset: 0x00002E98
		public override long Length
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600011C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Mono.Net.Security.MobileAuthenticatedStream::get_Length()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](this)))
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00004CAC File Offset: 0x00002EAC
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		public override long Position
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600011D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int64 Mono.Net.Security.MobileAuthenticatedStream::get_Position()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](this)))
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
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004CC0 File Offset: 0x00002EC0
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00004CD4 File Offset: 0x00002ED4
		public override int ReadTimeout
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600011F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Net.Security.MobileAuthenticatedStream::get_ReadTimeout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](this)))
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
				Stream innerStream = this._InnerStream;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00004CE8 File Offset: 0x00002EE8
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00004CFC File Offset: 0x00002EFC
		public override int WriteTimeout
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000121)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Net.Security.MobileAuthenticatedStream::get_WriteTimeout()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_06, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](this)))
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
				Stream innerStream = this._InnerStream;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00004D10 File Offset: 0x00002F10
		// Note: this type is marked as 'beforefieldinit'.
		static MobileAuthenticatedStream()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004D20 File Offset: 0x00002F20
		[CompilerGenerated]
		private void <InnerWrite>b__67_0()
		{
			Stream innerStream = this._InnerStream;
			BufferOffsetSize2 bufferOffsetSize = this.writeBuffer;
			byte[] buffer = bufferOffsetSize.Buffer;
			int offset = bufferOffsetSize.Offset;
			int totalBytes = bufferOffsetSize.TotalBytes;
		}

		// Token: 0x040000CD RID: 205
		private MobileTlsContext xobileTlsContext;

		// Token: 0x040000CE RID: 206
		private ExceptionDispatchInfo lastException;

		// Token: 0x040000CF RID: 207
		private AsyncProtocolRequest asyncHandshakeRequest;

		// Token: 0x040000D0 RID: 208
		private AsyncProtocolRequest asyncReadRequest;

		// Token: 0x040000D1 RID: 209
		private AsyncProtocolRequest asyncWriteRequest;

		// Token: 0x040000D2 RID: 210
		private BufferOffsetSize2 readBuffer;

		// Token: 0x040000D3 RID: 211
		private BufferOffsetSize2 writeBuffer;

		// Token: 0x040000D4 RID: 212
		private object ioLock;

		// Token: 0x040000D5 RID: 213
		private int closeRequested;

		// Token: 0x040000D6 RID: 214
		private bool shutdown;

		// Token: 0x040000D7 RID: 215
		private MobileAuthenticatedStream.Operation operation;

		// Token: 0x040000D8 RID: 216
		private static int uniqueNameInteger;

		// Token: 0x040000D9 RID: 217
		[CompilerGenerated]
		private readonly global::System.Net.Security.SslStream <SslStream>k__BackingField;

		// Token: 0x040000DA RID: 218
		[CompilerGenerated]
		private readonly MonoTlsSettings <Settings>k__BackingField;

		// Token: 0x040000DB RID: 219
		[CompilerGenerated]
		private readonly MobileTlsProvider <Provider>k__BackingField;

		// Token: 0x040000DC RID: 220
		[CompilerGenerated]
		private string <TargetHost>k__BackingField;

		// Token: 0x040000DD RID: 221
		private static int nextId;

		// Token: 0x040000DE RID: 222
		internal readonly int ID;

		// Token: 0x02000058 RID: 88
		private enum Operation
		{
			// Token: 0x040000E0 RID: 224
			None,
			// Token: 0x040000E1 RID: 225
			Handshake,
			// Token: 0x040000E2 RID: 226
			Authenticated,
			// Token: 0x040000E3 RID: 227
			Renegotiate,
			// Token: 0x040000E4 RID: 228
			Read,
			// Token: 0x040000E5 RID: 229
			Write,
			// Token: 0x040000E6 RID: 230
			Close
		}

		// Token: 0x02000059 RID: 89
		private enum OperationType
		{
			// Token: 0x040000E8 RID: 232
			Read,
			// Token: 0x040000E9 RID: 233
			Write,
			// Token: 0x040000EA RID: 234
			Renegotiate,
			// Token: 0x040000EB RID: 235
			Shutdown
		}

		// Token: 0x0200005A RID: 90
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ProcessAuthentication>d__48 : IAsyncStateMachine
		{
			// Token: 0x06000125 RID: 293 RVA: 0x00004D54 File Offset: 0x00002F54
			private void MoveNext()
			{
				do
				{
					MobileAuthenticatedStream mobileAuthenticatedStream = this.<>4__this;
					MonoSslAuthenticationOptions monoSslAuthenticationOptions = this.options;
				}
				while (this.options != null || this.options.<ServerCertSelectionDelegate>k__BackingField != null);
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00004E7C File Offset: 0x0000307C
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000EC RID: 236
			public int <>1__state;

			// Token: 0x040000ED RID: 237
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040000EE RID: 238
			public MonoSslAuthenticationOptions options;

			// Token: 0x040000EF RID: 239
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x040000F0 RID: 240
			public bool runSynchronously;

			// Token: 0x040000F1 RID: 241
			public CancellationToken cancellationToken;

			// Token: 0x040000F2 RID: 242
			private ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200005B RID: 91
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <StartOperation>d__57 : IAsyncStateMachine
		{
			// Token: 0x06000127 RID: 295 RVA: 0x00004E8C File Offset: 0x0000308C
			private void MoveNext()
			{
				MobileAuthenticatedStream mobileAuthenticatedStream = this.<>4__this;
				MobileAuthenticatedStream.OperationType operationType = this.type;
				if (mobileAuthenticatedStream == null)
				{
					if (mobileAuthenticatedStream == null)
					{
						if (mobileAuthenticatedStream != null)
						{
							if (operationType == MobileAuthenticatedStream.OperationType.Read)
							{
							}
							Exception invalidNestedCallException = MobileAuthenticatedStream.GetInvalidNestedCallException();
							if (operationType == MobileAuthenticatedStream.OperationType.Read)
							{
							}
							Exception invalidNestedCallException2 = MobileAuthenticatedStream.GetInvalidNestedCallException();
						}
						return;
					}
				}
				else
				{
					Exception invalidNestedCallException3 = MobileAuthenticatedStream.GetInvalidNestedCallException();
					Exception invalidNestedCallException4 = MobileAuthenticatedStream.GetInvalidNestedCallException();
				}
				Exception invalidNestedCallException5 = MobileAuthenticatedStream.GetInvalidNestedCallException();
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00004F38 File Offset: 0x00003138
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000F3 RID: 243
			public int <>1__state;

			// Token: 0x040000F4 RID: 244
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040000F5 RID: 245
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x040000F6 RID: 246
			public MobileAuthenticatedStream.OperationType type;

			// Token: 0x040000F7 RID: 247
			public AsyncProtocolRequest asyncRequest;

			// Token: 0x040000F8 RID: 248
			public CancellationToken cancellationToken;

			// Token: 0x040000F9 RID: 249
			private ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200005C RID: 92
		[CompilerGenerated]
		private sealed class <>c__DisplayClass66_0
		{
			// Token: 0x06000129 RID: 297 RVA: 0x00004F48 File Offset: 0x00003148
			public <>c__DisplayClass66_0()
			{
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00004F5C File Offset: 0x0000315C
			internal int <InnerRead>b__0()
			{
				/*
An exception occurred when decompiling this method (0600012A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Net.Security.MobileAuthenticatedStream/<>c__DisplayClass66_0::<InnerRead>b__0()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MobileAuthenticatedStream(var_0_06, ldfld:MobileAuthenticatedStream('<>c__DisplayClass66_0'::<>4__this, ldloc:'<>c__DisplayClass66_0'(this)))
	stloc:int32(var_1_0D, ldfld:int32('<>c__DisplayClass66_0'::len, ldloc:'<>c__DisplayClass66_0'(this)))
	stloc:Stream(var_2_14, ldfld:Stream(AuthenticatedStream::_InnerStream, ldloc:MobileAuthenticatedStream[exp:AuthenticatedStream](var_0_06)))
	stloc:BufferOffsetSize2(var_3_1B, ldfld:BufferOffsetSize2(MobileAuthenticatedStream::readBuffer, ldloc:MobileAuthenticatedStream(var_0_06)))
	stloc:uint8[](var_4_22, ldfld:uint8[](BufferOffsetSize::Buffer, ldloc:BufferOffsetSize2[exp:BufferOffsetSize](var_3_1B)))
	stloc:int32(var_5_2A, ldfld:int32(BufferOffsetSize::Offset, ldloc:BufferOffsetSize2[exp:BufferOffsetSize](var_3_1B)))
	stloc:int32(var_6_32, ldfld:int32(BufferOffsetSize::TotalBytes, ldloc:BufferOffsetSize2[exp:BufferOffsetSize](var_3_1B)))
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

			// Token: 0x040000FA RID: 250
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x040000FB RID: 251
			public int len;
		}

		// Token: 0x0200005D RID: 93
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <InnerRead>d__66 : IAsyncStateMachine
		{
			// Token: 0x0600012B RID: 299 RVA: 0x00004F9C File Offset: 0x0000319C
			private void MoveNext()
			{
				MobileAuthenticatedStream mobileAuthenticatedStream = this.<>4__this;
				MobileAuthenticatedStream mobileAuthenticatedStream2 = this.<>4__this;
				BufferOffsetSize2 readBuffer = mobileAuthenticatedStream.readBuffer;
				int num = this.requestedSize;
				int offset = readBuffer.Offset;
				int totalBytes = readBuffer.TotalBytes;
				byte[] buffer = readBuffer.Buffer;
				if (readBuffer == null)
				{
				}
				if (Math.Min(0, num) == 0)
				{
					return;
				}
				if (this.sync)
				{
					return;
				}
				Stream innerStream = mobileAuthenticatedStream._InnerStream;
				BufferOffsetSize2 readBuffer2 = mobileAuthenticatedStream.readBuffer;
				CancellationToken cancellationToken = this.cancellationToken;
				byte[] buffer2 = readBuffer2.Buffer;
				int offset2 = readBuffer2.Offset;
				int totalBytes2 = readBuffer2.TotalBytes;
				BufferOffsetSize2 readBuffer3 = mobileAuthenticatedStream.readBuffer;
				int size = readBuffer3.Size;
				bool complete = readBuffer3.Complete;
				readBuffer3.Complete = size != 0;
				int num2 = 1;
				readBuffer3.Complete = num2 != 0;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00005068 File Offset: 0x00003268
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x040000FC RID: 252
			public int <>1__state;

			// Token: 0x040000FD RID: 253
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040000FE RID: 254
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x040000FF RID: 255
			public CancellationToken cancellationToken;

			// Token: 0x04000100 RID: 256
			public int requestedSize;

			// Token: 0x04000101 RID: 257
			public bool sync;

			// Token: 0x04000102 RID: 258
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200005E RID: 94
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <InnerWrite>d__67 : IAsyncStateMachine
		{
			// Token: 0x0600012D RID: 301 RVA: 0x00005078 File Offset: 0x00003278
			private void MoveNext()
			{
				MobileAuthenticatedStream mobileAuthenticatedStream = this.<>4__this;
				if (mobileAuthenticatedStream.writeBuffer.Size != 0)
				{
					if (this.sync)
					{
						return;
					}
					Stream innerStream = mobileAuthenticatedStream._InnerStream;
					long num = 0L;
					Task task;
					ConfiguredTaskAwaitable configuredTaskAwaitable = task.ConfigureAwait(num != 0L);
					BufferOffsetSize2 writeBuffer = mobileAuthenticatedStream.writeBuffer;
					int size = writeBuffer.Size;
					bool complete = writeBuffer.Complete;
					writeBuffer.TotalBytes = size;
				}
			}

			// Token: 0x0600012E RID: 302 RVA: 0x000050EC File Offset: 0x000032EC
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000103 RID: 259
			public int <>1__state;

			// Token: 0x04000104 RID: 260
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000105 RID: 261
			public CancellationToken cancellationToken;

			// Token: 0x04000106 RID: 262
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x04000107 RID: 263
			public bool sync;

			// Token: 0x04000108 RID: 264
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
