using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x02000557 RID: 1367
	[Serializable]
	public abstract class Stream : MarshalByRefObject, IDisposable
	{
		// Token: 0x060028A3 RID: 10403 RVA: 0x00058514 File Offset: 0x00056714
		internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			int num = 1;
			if (num == 0)
			{
			}
			if (num == 0)
			{
			}
			SemaphoreSlim semaphoreSlim;
			return semaphoreSlim;
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060028A4 RID: 10404
		public abstract bool CanRead { get; }

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060028A5 RID: 10405
		public abstract bool CanSeek { get; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x0005852C File Offset: 0x0005672C
		public virtual bool CanTimeout
		{
			get
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060028A7 RID: 10407
		public abstract bool CanWrite { get; }

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060028A8 RID: 10408
		public abstract long Length { get; }

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060028A9 RID: 10409
		// (set) Token: 0x060028AA RID: 10410
		public abstract long Position { get; set; }

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual int ReadTimeout
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual int WriteTimeout
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0005853C File Offset: 0x0005673C
		public void CopyTo(Stream destination)
		{
			int copyBufferSize = this.GetCopyBufferSize();
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x00058550 File Offset: 0x00056750
		public virtual void CopyTo(Stream destination, int bufferSize)
		{
			StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (this != null)
			{
				return;
			}
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x00058570 File Offset: 0x00056770
		private int GetCopyBufferSize()
		{
			return 1;
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x00058580 File Offset: 0x00056780
		public virtual void Close()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00058594 File Offset: 0x00056794
		public void Dispose()
		{
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000585A4 File Offset: 0x000567A4
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060028B5 RID: 10421
		public abstract void Flush();

		// Token: 0x060028B6 RID: 10422 RVA: 0x000585B4 File Offset: 0x000567B4
		public virtual Task FlushAsync(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000585C8 File Offset: 0x000567C8
		public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			long num = 0L;
			return this.BeginReadInternal(buffer, offset, count, callback, state, num != 0L, true);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000585E8 File Offset: 0x000567E8
		internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			/*
An exception occurred when decompiling this method (060028B8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.IO.Stream::BeginReadInternal(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:Exception(var_2_1A, call:Exception(Error::GetReadNotSupported))
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

		// Token: 0x060028B9 RID: 10425 RVA: 0x00058610 File Offset: 0x00056810
		public virtual int EndRead(IAsyncResult asyncResult)
		{
			if (asyncResult != null)
			{
				Stream.ReadWriteTask activeReadWriteTask = this._activeReadWriteTask;
				if (activeReadWriteTask != null)
				{
					bool isRead = activeReadWriteTask._isRead;
					long num = 0L;
					int num2 = this._asyncActiveSemaphore.Release();
					if (num == 0L)
					{
					}
				}
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x00058650 File Offset: 0x00056850
		public Task<int> ReadAsync(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (060028BA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.IO.Stream::ReadAsync(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CancellationToken(var_1_0A, callgetter:CancellationToken(CancellationToken::get_None))
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

		// Token: 0x060028BB RID: 10427 RVA: 0x00058668 File Offset: 0x00056868
		public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Task task;
			return task;
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x00058678 File Offset: 0x00056878
		public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, [Optional] CancellationToken cancellationToken)
		{
			ReadOnlyMemory<byte> readOnlyMemory = buffer;
			if (this == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.task);
			}
			return 38;
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0005869C File Offset: 0x0005689C
		private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (!true)
			{
			}
			if (count != 0 || !true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000586BC File Offset: 0x000568BC
		public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			long num = 0L;
			return this.BeginWriteInternal(buffer, offset, count, callback, state, num != 0L, true);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000586DC File Offset: 0x000568DC
		internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm)
		{
			/*
An exception occurred when decompiling this method (060028BF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.IAsyncResult System.IO.Stream::BeginWriteInternal(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object,System.Boolean,System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0015:
	stloc:Exception(var_2_1A, call:Exception(Error::GetWriteNotSupported))
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

		// Token: 0x060028C0 RID: 10432 RVA: 0x00058704 File Offset: 0x00056904
		private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			bool isCompleted = asyncWaiter.IsCompleted;
			this.RunReadWriteTask(readWriteTask);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00058728 File Offset: 0x00056928
		private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			this._activeReadWriteTask = readWriteTask;
			if (!true)
			{
			}
			if (!true)
			{
			}
			long num = 0L;
			readWriteTask.m_taskScheduler = 1;
			readWriteTask.ScheduleAndStart(num != 0L);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00058754 File Offset: 0x00056954
		private void FinishTrackingAsyncOperation()
		{
			int num = this._asyncActiveSemaphore.Release();
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00058770 File Offset: 0x00056970
		public virtual void EndWrite(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
			{
				return;
			}
			Stream.ReadWriteTask activeReadWriteTask = this._activeReadWriteTask;
			if (activeReadWriteTask == null || activeReadWriteTask._isRead)
			{
				return;
			}
			long num = 0L;
			int num2 = this._asyncActiveSemaphore.Release();
			if (num == 0L)
			{
				return;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000587BC File Offset: 0x000569BC
		public Task WriteAsync(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (060028C4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.IO.Stream::WriteAsync(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
	stloc:CancellationToken(var_1_0A, callgetter:CancellationToken(CancellationToken::get_None))
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

		// Token: 0x060028C5 RID: 10437 RVA: 0x000587D4 File Offset: 0x000569D4
		public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			Task task;
			return task;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000587EC File Offset: 0x000569EC
		public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, [Optional] CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (060028C6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.ValueTask System.IO.Stream::WriteAsync(System.ReadOnlyMemory`1<System.Byte>,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_1:
	call:void(ThrowHelper::ThrowArgumentNullException, ldc.i4:ExceptionArgument(38))
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

		// Token: 0x060028C7 RID: 10439 RVA: 0x0005880C File Offset: 0x00056A0C
		private Task FinishWriteAsync(Task writeTask, byte[] localBuffer)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00058828 File Offset: 0x00056A28
		private Task BeginEndWriteAsync(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (060028C8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.IO.Stream::BeginEndWriteAsync(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	brtrue(IL_0000, ldc.i4:bool(1))
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

		// Token: 0x060028C9 RID: 10441
		public abstract long Seek(long offset, SeekOrigin origin);

		// Token: 0x060028CA RID: 10442
		public abstract void SetLength(long value);

		// Token: 0x060028CB RID: 10443
		public abstract int Read(byte[] buffer, int offset, int count);

		// Token: 0x060028CC RID: 10444 RVA: 0x00058844 File Offset: 0x00056A44
		public virtual int Read(Span<byte> buffer)
		{
			/*
An exception occurred when decompiling this method (060028CC)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Stream::Read(System.Span`1<System.Byte>)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentOutOfRangeException)
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

		// Token: 0x060028CD RID: 10445 RVA: 0x0005886C File Offset: 0x00056A6C
		public virtual int ReadByte()
		{
			/*
An exception occurred when decompiling this method (060028CD)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.IO.Stream::ReadByte()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldloc:Stream[exp:bool](this)))
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

		// Token: 0x060028CE RID: 10446
		public abstract void Write(byte[] buffer, int offset, int count);

		// Token: 0x060028CF RID: 10447 RVA: 0x0005887C File Offset: 0x00056A7C
		public virtual void Write(ReadOnlySpan<byte> buffer)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00058894 File Offset: 0x00056A94
		public virtual void WriteByte(byte value)
		{
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000588A4 File Offset: 0x00056AA4
		internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (callback != null)
			{
				IntPtr invoke_impl = callback.invoke_impl;
				IntPtr method_code = callback.method_code;
				IntPtr method = callback.method;
			}
			while (callback != null)
			{
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000588D4 File Offset: 0x00056AD4
		internal static int BlockingEndRead(IAsyncResult asyncResult)
		{
			int num;
			return num;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000588E4 File Offset: 0x00056AE4
		internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (callback != null)
			{
				IntPtr invoke_impl = callback.invoke_impl;
				IntPtr method_code = callback.method_code;
				IntPtr method = callback.method;
			}
			while (callback != null)
			{
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00058914 File Offset: 0x00056B14
		internal static void BlockingEndWrite(IAsyncResult asyncResult)
		{
			Stream.SynchronousAsyncResult.EndWrite(asyncResult);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00058928 File Offset: 0x00056B28
		private bool HasOverriddenBeginEndRead()
		{
			return true;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00058938 File Offset: 0x00056B38
		private bool HasOverriddenBeginEndWrite()
		{
			return true;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00058948 File Offset: 0x00056B48
		protected Stream()
		{
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0005895C File Offset: 0x00056B5C
		// Note: this type is marked as 'beforefieldinit'.
		static Stream()
		{
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0005896C File Offset: 0x00056B6C
		[CompilerGenerated]
		internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination)
		{
			AsyncValueTaskMethodBuilder asyncValueTaskMethodBuilder = AsyncValueTaskMethodBuilder.Create();
			ValueTask valueTask;
			return valueTask;
		}

		// Token: 0x040015F2 RID: 5618
		public static readonly Stream Null;

		// Token: 0x040015F3 RID: 5619
		[NonSerialized]
		private Stream.ReadWriteTask _activeReadWriteTask;

		// Token: 0x040015F4 RID: 5620
		[NonSerialized]
		private SemaphoreSlim _asyncActiveSemaphore;

		// Token: 0x02000558 RID: 1368
		private struct ReadWriteParameters
		{
			// Token: 0x040015F5 RID: 5621
			internal byte[] Buffer;

			// Token: 0x040015F6 RID: 5622
			internal int Offset;

			// Token: 0x040015F7 RID: 5623
			internal int Count;
		}

		// Token: 0x02000559 RID: 1369
		private sealed class ReadWriteTask : Task<int>, ITaskCompletionAction
		{
			// Token: 0x060028DA RID: 10458 RVA: 0x00058980 File Offset: 0x00056B80
			internal void ClearBeginState()
			{
			}

			// Token: 0x060028DB RID: 10459 RVA: 0x00058990 File Offset: 0x00056B90
			public ReadWriteTask(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback)
			{
				if (!true)
				{
				}
				CancellationToken none = CancellationToken.None;
				this._stream = stream;
				this._buffer = buffer;
				this._offset = offset;
				ExecutionContext executionContext = ExecutionContext.Capture();
				this._context = executionContext;
				base.AddCompletionAction(this);
			}

			// Token: 0x060028DC RID: 10460 RVA: 0x000589D8 File Offset: 0x00056BD8
			private static void InvokeAsyncCallback(object completedTask)
			{
				if (completedTask != null)
				{
				}
			}

			// Token: 0x060028DD RID: 10461 RVA: 0x000589F0 File Offset: 0x00056BF0
			void ITaskCompletionAction.Invoke(Task completingTask)
			{
				if (this._context != null)
				{
					return;
				}
				AsyncCallback callback = this._callback;
				IntPtr invoke_impl = callback.invoke_impl;
				IntPtr method_code = callback.method_code;
				IntPtr method = callback.method;
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x060028DE RID: 10462 RVA: 0x00058A28 File Offset: 0x00056C28
			bool ITaskCompletionAction.InvokeMayRunArbitraryCode
			{
				get
				{
					return true;
				}
			}

			// Token: 0x040015F8 RID: 5624
			internal readonly bool _isRead;

			// Token: 0x040015F9 RID: 5625
			internal readonly bool _apm;

			// Token: 0x040015FA RID: 5626
			internal Stream _stream;

			// Token: 0x040015FB RID: 5627
			internal byte[] _buffer;

			// Token: 0x040015FC RID: 5628
			internal readonly int _offset;

			// Token: 0x040015FD RID: 5629
			internal readonly int _count;

			// Token: 0x040015FE RID: 5630
			private AsyncCallback _callback;

			// Token: 0x040015FF RID: 5631
			private ExecutionContext _context;

			// Token: 0x04001600 RID: 5632
			private static ContextCallback s_invokeAsyncCallback;
		}

		// Token: 0x0200055A RID: 1370
		private sealed class NullStream : Stream
		{
			// Token: 0x060028DF RID: 10463 RVA: 0x00058A38 File Offset: 0x00056C38
			internal NullStream()
			{
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x060028E0 RID: 10464 RVA: 0x00058A4C File Offset: 0x00056C4C
			public override bool CanRead
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x060028E1 RID: 10465 RVA: 0x00058A5C File Offset: 0x00056C5C
			public override bool CanWrite
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x060028E2 RID: 10466 RVA: 0x00058A6C File Offset: 0x00056C6C
			public override bool CanSeek
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x060028E3 RID: 10467 RVA: 0x00058A7C File Offset: 0x00056C7C
			public override long Length
			{
				get
				{
					return 0L;
				}
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x060028E4 RID: 10468 RVA: 0x00058A8C File Offset: 0x00056C8C
			// (set) Token: 0x060028E5 RID: 10469 RVA: 0x00058A9C File Offset: 0x00056C9C
			public override long Position
			{
				get
				{
					return 0L;
				}
				set
				{
				}
			}

			// Token: 0x060028E6 RID: 10470 RVA: 0x00058AAC File Offset: 0x00056CAC
			public override void CopyTo(Stream destination, int bufferSize)
			{
				StreamHelpers.ValidateCopyToArgs(this, destination, bufferSize);
			}

			// Token: 0x060028E7 RID: 10471 RVA: 0x00058AC4 File Offset: 0x00056CC4
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060028E8 RID: 10472 RVA: 0x00058AD4 File Offset: 0x00056CD4
			public override void Flush()
			{
			}

			// Token: 0x060028E9 RID: 10473 RVA: 0x00058AE4 File Offset: 0x00056CE4
			public override Task FlushAsync(CancellationToken cancellationToken)
			{
				if (!true)
				{
				}
				Task task;
				return task;
			}

			// Token: 0x060028EA RID: 10474 RVA: 0x00058AFC File Offset: 0x00056CFC
			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				return base.BlockingBeginRead(buffer, offset, count, callback, state);
			}

			// Token: 0x060028EB RID: 10475 RVA: 0x00058B20 File Offset: 0x00056D20
			public override int EndRead(IAsyncResult asyncResult)
			{
				while (asyncResult == null)
				{
				}
				return Stream.BlockingEndRead(asyncResult);
			}

			// Token: 0x060028EC RID: 10476 RVA: 0x00058B38 File Offset: 0x00056D38
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				return base.BlockingBeginWrite(buffer, offset, count, callback, state);
			}

			// Token: 0x060028ED RID: 10477 RVA: 0x00058B5C File Offset: 0x00056D5C
			public override void EndWrite(IAsyncResult asyncResult)
			{
				while (asyncResult == null)
				{
				}
				Stream.BlockingEndWrite(asyncResult);
			}

			// Token: 0x060028EE RID: 10478 RVA: 0x00058B74 File Offset: 0x00056D74
			public override int Read(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x060028EF RID: 10479 RVA: 0x00058B84 File Offset: 0x00056D84
			public override int Read(Span<byte> buffer)
			{
			}

			// Token: 0x060028F0 RID: 10480 RVA: 0x00058B94 File Offset: 0x00056D94
			public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				if (!true)
				{
				}
				return 1;
			}

			// Token: 0x060028F1 RID: 10481 RVA: 0x00058BA8 File Offset: 0x00056DA8
			public override ValueTask<int> ReadAsync(Memory<byte> buffer, [Optional] CancellationToken cancellationToken)
			{
			}

			// Token: 0x060028F2 RID: 10482 RVA: 0x0000207A File Offset: 0x0000027A
			public override int ReadByte()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x060028F3 RID: 10483 RVA: 0x00058BB8 File Offset: 0x00056DB8
			public override void Write(byte[] buffer, int offset, int count)
			{
			}

			// Token: 0x060028F4 RID: 10484 RVA: 0x00058BC8 File Offset: 0x00056DC8
			public override void Write(ReadOnlySpan<byte> buffer)
			{
			}

			// Token: 0x060028F5 RID: 10485 RVA: 0x00058BD8 File Offset: 0x00056DD8
			public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
			{
				if (!true)
				{
				}
				Task task;
				return task;
			}

			// Token: 0x060028F6 RID: 10486 RVA: 0x00058BF0 File Offset: 0x00056DF0
			public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, [Optional] CancellationToken cancellationToken)
			{
				/*
An exception occurred when decompiling this method (060028F6)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.ValueTask System.IO.Stream/NullStream::WriteAsync(System.ReadOnlyMemory`1<System.Byte>,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(ThrowHelper::ThrowArgumentNullException, ldc.i4:ExceptionArgument(38))
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

			// Token: 0x060028F7 RID: 10487 RVA: 0x00058C08 File Offset: 0x00056E08
			public override void WriteByte(byte value)
			{
			}

			// Token: 0x060028F8 RID: 10488 RVA: 0x00058C18 File Offset: 0x00056E18
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x060028F9 RID: 10489 RVA: 0x00058C28 File Offset: 0x00056E28
			public override void SetLength(long length)
			{
			}

			// Token: 0x060028FA RID: 10490 RVA: 0x00058C38 File Offset: 0x00056E38
			// Note: this type is marked as 'beforefieldinit'.
			static NullStream()
			{
				if (!true)
				{
				}
			}

			// Token: 0x04001601 RID: 5633
			private static readonly Task<int> s_zeroTask;
		}

		// Token: 0x0200055B RID: 1371
		private sealed class SynchronousAsyncResult : IAsyncResult
		{
			// Token: 0x060028FB RID: 10491 RVA: 0x00058C48 File Offset: 0x00056E48
			internal SynchronousAsyncResult(int bytesRead, object asyncStateObject)
			{
				this._bytesRead = bytesRead;
				this._stateObject = asyncStateObject;
			}

			// Token: 0x060028FC RID: 10492 RVA: 0x00058C6C File Offset: 0x00056E6C
			internal SynchronousAsyncResult(object asyncStateObject)
			{
				this._stateObject = asyncStateObject;
				this._isWrite = true;
			}

			// Token: 0x060028FD RID: 10493 RVA: 0x00058C90 File Offset: 0x00056E90
			internal SynchronousAsyncResult(Exception ex, object asyncStateObject, bool isWrite)
			{
				ExceptionDispatchInfo exceptionDispatchInfo = ExceptionDispatchInfo.Capture(ex);
				this._exceptionInfo = exceptionDispatchInfo;
				this._stateObject = asyncStateObject;
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x060028FE RID: 10494 RVA: 0x00058CB8 File Offset: 0x00056EB8
			public bool IsCompleted
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x060028FF RID: 10495 RVA: 0x00058CC8 File Offset: 0x00056EC8
			public WaitHandle AsyncWaitHandle
			{
				get
				{
					/*
An exception occurred when decompiling this method (060028FF)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.WaitHandle System.IO.Stream/SynchronousAsyncResult::get_AsyncWaitHandle()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0005:
	brtrue(IL_0000, ldloc:int32[exp:bool](var_0_01))
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

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x06002900 RID: 10496 RVA: 0x00058CDC File Offset: 0x00056EDC
			public object AsyncState
			{
				get
				{
					return this._stateObject;
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x06002901 RID: 10497 RVA: 0x00058CF0 File Offset: 0x00056EF0
			public bool CompletedSynchronously
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06002902 RID: 10498 RVA: 0x00058D00 File Offset: 0x00056F00
			internal void ThrowIfError()
			{
				ExceptionDispatchInfo exceptionInfo = this._exceptionInfo;
				if (exceptionInfo != null)
				{
					exceptionInfo.Throw();
					return;
				}
			}

			// Token: 0x06002903 RID: 10499 RVA: 0x00058D20 File Offset: 0x00056F20
			internal static int EndRead(IAsyncResult asyncResult)
			{
				return "IAsyncResult object did not come from the corresponding async method on this type.";
			}

			// Token: 0x06002904 RID: 10500 RVA: 0x00058D34 File Offset: 0x00056F34
			internal static void EndWrite(IAsyncResult asyncResult)
			{
				if (asyncResult != null)
				{
					return;
				}
			}

			// Token: 0x04001602 RID: 5634
			private readonly object _stateObject;

			// Token: 0x04001603 RID: 5635
			private readonly bool _isWrite;

			// Token: 0x04001604 RID: 5636
			private ManualResetEvent _waitHandle;

			// Token: 0x04001605 RID: 5637
			private ExceptionDispatchInfo _exceptionInfo;

			// Token: 0x04001606 RID: 5638
			private bool _endXxxCalled;

			// Token: 0x04001607 RID: 5639
			private int _bytesRead;

			// Token: 0x0200055C RID: 1372
			[CompilerGenerated]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06002905 RID: 10501 RVA: 0x0001B05E File Offset: 0x0001925E
				// Note: this type is marked as 'beforefieldinit'.
				static <>c()
				{
				}

				// Token: 0x06002906 RID: 10502 RVA: 0x0001B05E File Offset: 0x0001925E
				public <>c()
				{
				}

				// Token: 0x06002907 RID: 10503 RVA: 0x000273E5 File Offset: 0x000255E5
				internal ManualResetEvent <get_AsyncWaitHandle>b__12_0()
				{
					return null;
				}

				// Token: 0x04001608 RID: 5640
				public static readonly Stream.SynchronousAsyncResult.<>c <>9;

				// Token: 0x04001609 RID: 5641
				public static Func<ManualResetEvent> <>9__12_0;
			}
		}

		// Token: 0x0200055D RID: 1373
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06002908 RID: 10504 RVA: 0x00058D48 File Offset: 0x00056F48
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x06002909 RID: 10505 RVA: 0x00058D58 File Offset: 0x00056F58
			public <>c()
			{
			}

			// Token: 0x0600290A RID: 10506 RVA: 0x0000207A File Offset: 0x0000027A
			internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600290B RID: 10507 RVA: 0x00058D6C File Offset: 0x00056F6C
			internal void <FlushAsync>b__37_0(object state)
			{
			}

			// Token: 0x0600290C RID: 10508 RVA: 0x00058D80 File Offset: 0x00056F80
			internal int <BeginReadInternal>b__40_0(object <p0>)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x0600290D RID: 10509 RVA: 0x0000207A File Offset: 0x0000027A
			internal IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600290E RID: 10510 RVA: 0x0000207A File Offset: 0x0000027A
			internal int <BeginEndReadAsync>b__45_1(Stream stream, IAsyncResult asyncResult)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x0600290F RID: 10511 RVA: 0x00058DB0 File Offset: 0x00056FB0
			internal int <BeginWriteInternal>b__48_0(object <p0>)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!false)
				{
				}
				throw new OutOfMemoryException();
			}

			// Token: 0x06002910 RID: 10512 RVA: 0x00058DE4 File Offset: 0x00056FE4
			internal void <RunReadWriteTaskWhenReady>b__49_0(Task t, object state)
			{
				if (state != null)
				{
				}
			}

			// Token: 0x06002911 RID: 10513 RVA: 0x0000207A File Offset: 0x0000027A
			internal IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x06002912 RID: 10514 RVA: 0x00058DFC File Offset: 0x00056FFC
			internal VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, IAsyncResult asyncResult)
			{
			}

			// Token: 0x0400160A RID: 5642
			public static readonly Stream.<>c <>9;

			// Token: 0x0400160B RID: 5643
			public static Func<SemaphoreSlim> <>9__4_0;

			// Token: 0x0400160C RID: 5644
			public static Action<object> <>9__37_0;

			// Token: 0x0400160D RID: 5645
			public static Func<object, int> <>9__40_0;

			// Token: 0x0400160E RID: 5646
			public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__45_0;

			// Token: 0x0400160F RID: 5647
			public static Func<Stream, IAsyncResult, int> <>9__45_1;

			// Token: 0x04001610 RID: 5648
			public static Func<object, int> <>9__48_0;

			// Token: 0x04001611 RID: 5649
			public static Action<Task, object> <>9__49_0;

			// Token: 0x04001612 RID: 5650
			public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__58_0;

			// Token: 0x04001613 RID: 5651
			public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__58_1;
		}

		// Token: 0x0200055E RID: 1374
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <FinishWriteAsync>d__57 : IAsyncStateMachine
		{
			// Token: 0x06002913 RID: 10515 RVA: 0x00058E0C File Offset: 0x0005700C
			private void MoveNext()
			{
				Task task = this.writeTask;
				long num = 0L;
				ConfiguredTaskAwaitable configuredTaskAwaitable = task.ConfigureAwait(num != 0L);
			}

			// Token: 0x06002914 RID: 10516 RVA: 0x00058E40 File Offset: 0x00057040
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04001614 RID: 5652
			public int <>1__state;

			// Token: 0x04001615 RID: 5653
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001616 RID: 5654
			public Task writeTask;

			// Token: 0x04001617 RID: 5655
			public byte[] localBuffer;

			// Token: 0x04001618 RID: 5656
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200055F RID: 1375
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <<ReadAsync>g__FinishReadAsync|44_0>d : IAsyncStateMachine
		{
			// Token: 0x06002915 RID: 10517 RVA: 0x00058E50 File Offset: 0x00057050
			private void MoveNext()
			{
				Task<int> task = this.readTask;
			}

			// Token: 0x06002916 RID: 10518 RVA: 0x00058E98 File Offset: 0x00057098
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04001619 RID: 5657
			public int <>1__state;

			// Token: 0x0400161A RID: 5658
			public AsyncValueTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400161B RID: 5659
			public Task<int> readTask;

			// Token: 0x0400161C RID: 5660
			public byte[] localBuffer;

			// Token: 0x0400161D RID: 5661
			public Memory<byte> localDestination;

			// Token: 0x0400161E RID: 5662
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
