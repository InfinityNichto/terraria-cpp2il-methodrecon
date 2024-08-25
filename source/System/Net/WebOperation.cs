using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200028A RID: 650
	internal class WebOperation
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00002050 File Offset: 0x00000250
		public HttpWebRequest Request
		{
			[CompilerGenerated]
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00037CA4 File Offset: 0x00035EA4
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x00037CB8 File Offset: 0x00035EB8
		public WebConnection Connection
		{
			[CompilerGenerated]
			get
			{
				return this.<Connection>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<Connection>k__BackingField = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00037CCC File Offset: 0x00035ECC
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x00037CE0 File Offset: 0x00035EE0
		public ServicePoint ServicePoint
		{
			[CompilerGenerated]
			get
			{
				return this.<ServicePoint>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				this.<ServicePoint>k__BackingField = value;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00037CF4 File Offset: 0x00035EF4
		public BufferOffsetSize WriteBuffer
		{
			[CompilerGenerated]
			get
			{
				return this.<WriteBuffer>k__BackingField;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00037D08 File Offset: 0x00035F08
		public bool IsNtlmChallenge
		{
			[CompilerGenerated]
			get
			{
				return this.<IsNtlmChallenge>k__BackingField;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00037D1C File Offset: 0x00035F1C
		internal string ME
		{
			get
			{
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00037D2C File Offset: 0x00035F2C
		public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
		{
			this.<Request>k__BackingField = request;
			this.WriteBuffer = writeBuffer;
			if (!true)
			{
			}
			CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
			this.cts = cancellationTokenSource;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00037D60 File Offset: 0x00035F60
		public bool Aborted
		{
			get
			{
				if (this.disposedInfo == null)
				{
					CancellationTokenSource cancellationTokenSource = this.cts;
					if (cancellationTokenSource == null)
					{
						return true;
					}
					bool isCancellationRequested = cancellationTokenSource.IsCancellationRequested;
				}
				return true;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00037D8C File Offset: 0x00035F8C
		public bool Closed
		{
			get
			{
				bool aborted = this.Aborted;
				return true;
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00037DAC File Offset: 0x00035FAC
		public void Abort()
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00037DD8 File Offset: 0x00035FD8
		public void Close()
		{
			ValueTuple<ExceptionDispatchInfo, bool> valueTuple;
			if (valueTuple != null)
			{
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00037DF0 File Offset: 0x00035FF0
		private void SetCanceled()
		{
			WebCompletionSource<WebRequestStream> webCompletionSource = this.requestTask;
			WebCompletionSource<WebRequestStream> webCompletionSource2 = this.requestWrittenTask;
			WebCompletionSource<WebResponseStream> webCompletionSource3 = this.responseTask;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00037E14 File Offset: 0x00036014
		private void SetError(Exception error)
		{
			WebCompletionSource<WebRequestStream> webCompletionSource = this.requestTask;
			WebCompletionSource<WebRequestStream> webCompletionSource2 = this.requestWrittenTask;
			WebCompletionSource<WebResponseStream> webCompletionSource3 = this.responseTask;
			long num = 0L;
			this.Finish(num != 0L, error);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00037E40 File Offset: 0x00036040
		private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ExceptionDispatchInfo field)
		{
			/*
An exception occurred when decompiling this method (060011FC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.ValueTuple`2<System.Runtime.ExceptionServices.ExceptionDispatchInfo,System.Boolean> System.Net.WebOperation::SetDisposed(System.Runtime.ExceptionServices.ExceptionDispatchInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(SR::GetString, ldstr:string("The request was canceled")))
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

		// Token: 0x060011FD RID: 4605 RVA: 0x00037E58 File Offset: 0x00036058
		internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken)
		{
			bool aborted = this.Aborted;
			ExceptionDispatchInfo exceptionDispatchInfo;
			return exceptionDispatchInfo;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00037E70 File Offset: 0x00036070
		internal void ThrowIfDisposed()
		{
			if (!true)
			{
			}
			CancellationToken none = CancellationToken.None;
			this.ThrowIfDisposed(none);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00037E90 File Offset: 0x00036090
		internal void ThrowIfDisposed(CancellationToken cancellationToken)
		{
			bool aborted = this.Aborted;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00037EA4 File Offset: 0x000360A4
		internal void ThrowIfClosedOrDisposed()
		{
			if (!true)
			{
			}
			CancellationToken none = CancellationToken.None;
			this.ThrowIfClosedOrDisposed(none);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00037EC4 File Offset: 0x000360C4
		internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
		{
			bool aborted = this.Aborted;
			if (this.closedInfo == null)
			{
			}
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00037EE0 File Offset: 0x000360E0
		private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ExceptionDispatchInfo field)
		{
			/*
An exception occurred when decompiling this method (06001202)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Runtime.ExceptionServices.ExceptionDispatchInfo System.Net.WebOperation::CheckThrowDisposed(System.Boolean,System.Runtime.ExceptionServices.ExceptionDispatchInfo)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(CancellationTokenSource::Cancel, ldloc:CancellationTokenSource(var_1_0E))
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

		// Token: 0x06001203 RID: 4611 RVA: 0x00037F04 File Offset: 0x00036104
		internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
		{
			int num = 1;
			if (servicePoint != null)
			{
				if (connection != null)
				{
					int num2;
					if (num2 != 0)
					{
						return;
					}
					long num3 = 0L;
					this.<Connection>k__BackingField = connection;
					this.<ServicePoint>k__BackingField = servicePoint;
					int num4 = 11;
					if (num != 0)
					{
						Monitor.Exit(this);
					}
					if (num3 == 0L)
					{
						if (num4 == 0)
						{
							CancellationToken token = this.cts.Token;
						}
						return;
					}
				}
				throw new OutOfMemoryException();
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00037F64 File Offset: 0x00036164
		public void SetPriorityRequest(WebOperation operation)
		{
			int num = this.requestSent;
			if (this.<ServicePoint>k__BackingField != null)
			{
				int num2 = this.finished;
				if (num2 == 0)
				{
					if (this != null)
					{
						return;
					}
					long num3 = 0L;
					if (num2 != 0)
					{
						Monitor.Exit(this);
					}
					if (num3 == 0L)
					{
						return;
					}
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00037FBC File Offset: 0x000361BC
		public Task<Stream> GetRequestStream()
		{
			/*
An exception occurred when decompiling this method (06001205)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.IO.Stream> System.Net.WebOperation::GetRequestStream()

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

		// Token: 0x06001206 RID: 4614 RVA: 0x00037FCC File Offset: 0x000361CC
		internal Task<WebRequestStream> GetRequestStreamInternal()
		{
			/*
An exception occurred when decompiling this method (06001206)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Net.WebRequestStream> System.Net.WebOperation::GetRequestStreamInternal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Net.WebCompletionSource`1<class System.Net.WebRequestStream>(var_0_06, ldfld:class System.Net.WebCompletionSource`1<class System.Net.WebRequestStream>(WebOperation::requestTask, ldloc:WebOperation(this)))
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

		// Token: 0x06001207 RID: 4615 RVA: 0x00037FE0 File Offset: 0x000361E0
		public Task WaitUntilRequestWritten()
		{
			/*
An exception occurred when decompiling this method (06001207)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Net.WebOperation::WaitUntilRequestWritten()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Net.WebCompletionSource`1<class System.Net.WebRequestStream>(var_0_06, ldfld:class System.Net.WebCompletionSource`1<class System.Net.WebRequestStream>(WebOperation::requestWrittenTask, ldloc:WebOperation(this)))
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

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00037FF4 File Offset: 0x000361F4
		public WebRequestStream WriteStream
		{
			get
			{
				this.ThrowIfDisposed();
				return this.writeStream;
			}
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00038010 File Offset: 0x00036210
		public Task<WebResponseStream> GetResponseStream()
		{
			/*
An exception occurred when decompiling this method (06001209)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Net.WebResponseStream> System.Net.WebOperation::GetResponseStream()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:class System.Net.WebCompletionSource`1<class System.Net.WebResponseStream>(var_0_06, ldfld:class System.Net.WebCompletionSource`1<class System.Net.WebResponseStream>(WebOperation::responseTask, ldloc:WebOperation(this)))
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

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00038024 File Offset: 0x00036224
		internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished
		{
			get
			{
				return this.finishedTask;
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00038038 File Offset: 0x00036238
		internal void Run()
		{
			AsyncVoidMethodBuilder asyncVoidMethodBuilder = AsyncVoidMethodBuilder.Create();
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00038050 File Offset: 0x00036250
		internal void CompleteRequestWritten(WebRequestStream stream, [Optional] Exception error)
		{
			if (error != null)
			{
				this.SetError(error);
				return;
			}
			WebCompletionSource<WebRequestStream> webCompletionSource = this.requestWrittenTask;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00038070 File Offset: 0x00036270
		internal void Finish(bool ok, [Optional] Exception error)
		{
			int num = 1;
			long num2 = 0L;
			if (Interlocked.CompareExchange(0, num, (int)num2) != 0)
			{
				return;
			}
			Monitor.Enter(this, num != 0);
			HttpWebRequest httpWebRequest = this.<Request>k__BackingField;
			long num3 = 0L;
			int num4 = 3;
			if (httpWebRequest != null)
			{
				Monitor.Exit(this);
			}
			if (num3 != 0L)
			{
				throw new OutOfMemoryException();
			}
			while (num4 != 0)
			{
			}
			if (error != null)
			{
				if (this != null)
				{
					this.SetError(error);
				}
				bool flag = this.finishedTask.TrySetException(error);
				return;
			}
			bool aborted = this.Aborted;
			if (this != null)
			{
			}
			if (this != null)
			{
				bool aborted2 = this.Aborted;
				return;
			}
			WebCompletionSource<ValueTuple<bool, WebOperation>> webCompletionSource = this.finishedTask;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0003810C File Offset: 0x0003630C
		[CompilerGenerated]
		private void <RegisterRequest>b__48_0()
		{
			HttpWebRequest httpWebRequest = this.<Request>k__BackingField;
			int num = 1;
			httpWebRequest.finished_reading = num != 0;
		}

		// Token: 0x04000DEE RID: 3566
		[CompilerGenerated]
		private readonly HttpWebRequest <Request>k__BackingField;

		// Token: 0x04000DEF RID: 3567
		[CompilerGenerated]
		private WebConnection <Connection>k__BackingField;

		// Token: 0x04000DF0 RID: 3568
		[CompilerGenerated]
		private ServicePoint <ServicePoint>k__BackingField;

		// Token: 0x04000DF1 RID: 3569
		[CompilerGenerated]
		private readonly BufferOffsetSize <WriteBuffer>k__BackingField;

		// Token: 0x04000DF2 RID: 3570
		[CompilerGenerated]
		private readonly bool <IsNtlmChallenge>k__BackingField;

		// Token: 0x04000DF3 RID: 3571
		internal readonly int ID;

		// Token: 0x04000DF4 RID: 3572
		private CancellationTokenSource cts;

		// Token: 0x04000DF5 RID: 3573
		private WebCompletionSource<WebRequestStream> requestTask;

		// Token: 0x04000DF6 RID: 3574
		private WebCompletionSource<WebRequestStream> requestWrittenTask;

		// Token: 0x04000DF7 RID: 3575
		private WebCompletionSource<WebResponseStream> responseTask;

		// Token: 0x04000DF8 RID: 3576
		private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask;

		// Token: 0x04000DF9 RID: 3577
		private WebRequestStream writeStream;

		// Token: 0x04000DFA RID: 3578
		private WebResponseStream responseStream;

		// Token: 0x04000DFB RID: 3579
		private ExceptionDispatchInfo disposedInfo;

		// Token: 0x04000DFC RID: 3580
		private ExceptionDispatchInfo closedInfo;

		// Token: 0x04000DFD RID: 3581
		private WebOperation priorityRequest;

		// Token: 0x04000DFE RID: 3582
		private int requestSent;

		// Token: 0x04000DFF RID: 3583
		private int finished;

		// Token: 0x0200028B RID: 651
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <GetRequestStream>d__50 : IAsyncStateMachine
		{
			// Token: 0x0600120F RID: 4623 RVA: 0x0003812C File Offset: 0x0003632C
			private void MoveNext()
			{
				WebCompletionSource<WebRequestStream> requestTask = this.<>4__this.requestTask;
			}

			// Token: 0x06001210 RID: 4624 RVA: 0x00038150 File Offset: 0x00036350
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E00 RID: 3584
			public int <>1__state;

			// Token: 0x04000E01 RID: 3585
			public AsyncTaskMethodBuilder<Stream> <>t__builder;

			// Token: 0x04000E02 RID: 3586
			public WebOperation <>4__this;

			// Token: 0x04000E03 RID: 3587
			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200028C RID: 652
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <Run>d__58 : IAsyncStateMachine
		{
			// Token: 0x06001211 RID: 4625 RVA: 0x00038160 File Offset: 0x00036360
			private void MoveNext()
			{
				WebOperation webOperation = this.<>4__this;
				Task task = this.<>u__2.m_task;
			}

			// Token: 0x06001212 RID: 4626 RVA: 0x000382C4 File Offset: 0x000364C4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E04 RID: 3588
			public int <>1__state;

			// Token: 0x04000E05 RID: 3589
			public AsyncVoidMethodBuilder <>t__builder;

			// Token: 0x04000E06 RID: 3590
			public WebOperation <>4__this;

			// Token: 0x04000E07 RID: 3591
			private WebRequestStream <requestStream>5__2;

			// Token: 0x04000E08 RID: 3592
			private WebResponseStream <stream>5__3;

			// Token: 0x04000E09 RID: 3593
			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E0A RID: 3594
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
