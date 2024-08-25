using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002B5 RID: 693
	public class CryptoStream : Stream, IDisposable
	{
		// Token: 0x06001782 RID: 6018 RVA: 0x00032638 File Offset: 0x00030838
		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode)
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00032648 File Offset: 0x00030848
		public CryptoStream(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen)
		{
			if (!true)
			{
			}
			base..ctor();
			this._transformMode = mode;
			this._stream = stream;
			this._transform = transform;
			if (mode == CryptoStreamMode.Read)
			{
				if (!true)
				{
				}
				this._canRead = true;
				return;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x000326A4 File Offset: 0x000308A4
		public override bool CanRead
		{
			get
			{
				return this._canRead;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x000326B8 File Offset: 0x000308B8
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x000326C8 File Offset: 0x000308C8
		public override bool CanWrite
		{
			get
			{
				return this._canWrite;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x0000207A File Offset: 0x0000027A
		public override long Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0000207A File Offset: 0x0000027A
		public override long Position
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x000326DC File Offset: 0x000308DC
		public bool HasFlushedFinalBlock
		{
			get
			{
				return this._finalBlockTransformed;
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000326F0 File Offset: 0x000308F0
		public void FlushFinalBlock()
		{
			while (this._finalBlockTransformed)
			{
			}
			ICryptoTransform transform = this._transform;
			byte[] inputBuffer = this._inputBuffer;
			int inputBufferIndex = this._inputBufferIndex;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0003279C File Offset: 0x0003099C
		public override void Flush()
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000327AC File Offset: 0x000309AC
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			Type type;
			bool flag = base.GetType() != type;
			return base.FlushAsync(cancellationToken);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0000207A File Offset: 0x0000027A
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0000207A File Offset: 0x0000027A
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000327D4 File Offset: 0x000309D4
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckReadArguments(buffer, offset, count);
			return this.ReadAsyncInternal(buffer, offset, count, cancellationToken);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000327F8 File Offset: 0x000309F8
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!true)
			{
			}
			CancellationToken none = CancellationToken.None;
			IAsyncResult asyncResult;
			return asyncResult;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00032814 File Offset: 0x00030A14
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00032828 File Offset: 0x00030A28
		private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001793)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Security.Cryptography.CryptoStream::ReadAsyncInternal(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)

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

		// Token: 0x06001794 RID: 6036 RVA: 0x00032838 File Offset: 0x00030A38
		public override int ReadByte()
		{
			int outputBufferIndex = this._outputBufferIndex;
			byte[] outputBuffer = this._outputBuffer;
			int outputBufferIndex2 = this._outputBufferIndex;
			this._outputBufferIndex = outputBufferIndex2;
			return base.ReadByte();
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00032868 File Offset: 0x00030A68
		public override void WriteByte(byte value)
		{
			int inputBufferIndex = this._inputBufferIndex;
			byte[] outputBuffer = this._outputBuffer;
			byte[] inputBuffer = this._inputBuffer;
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00032894 File Offset: 0x00030A94
		public override int Read(byte[] buffer, int offset, int count)
		{
			/*
An exception occurred when decompiling this method (06001796)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.CryptoStream::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(CryptoStream::CheckReadArguments, ldloc:CryptoStream(this), ldloc:uint8[](buffer), ldloc:int32(offset), ldloc:int32(count))
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

		// Token: 0x06001797 RID: 6039 RVA: 0x000328AC File Offset: 0x00030AAC
		private void CheckReadArguments(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000328BC File Offset: 0x00030ABC
		private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			/*
An exception occurred when decompiling this method (06001798)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Security.Cryptography.CryptoStream::ReadAsyncCore(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken,System.Boolean)

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

		// Token: 0x06001799 RID: 6041 RVA: 0x000328CC File Offset: 0x00030ACC
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			this.CheckWriteArguments(buffer, offset, count);
			return this.WriteAsyncInternal(buffer, offset, count, cancellationToken);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000328F0 File Offset: 0x00030AF0
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (!true)
			{
			}
			CancellationToken none = CancellationToken.None;
			IAsyncResult asyncResult;
			return asyncResult;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0003290C File Offset: 0x00030B0C
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00032920 File Offset: 0x00030B20
		private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00032938 File Offset: 0x00030B38
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.CheckWriteArguments(buffer, offset, count);
			Task task;
			task.GetAwaiter().GetResult();
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0003295C File Offset: 0x00030B5C
		private void CheckWriteArguments(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0003296C File Offset: 0x00030B6C
		private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00032988 File Offset: 0x00030B88
		public void Clear()
		{
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00032998 File Offset: 0x00030B98
		protected override void Dispose(bool disposing)
		{
			if (!this._finalBlockTransformed)
			{
				this.FlushFinalBlock();
			}
			if (!this._leaveOpen)
			{
				Stream stream = this._stream;
				stream.Dispose();
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000329CC File Offset: 0x00030BCC
		private void InitializeBuffer()
		{
			ICryptoTransform transform = this._transform;
			if (transform != null)
			{
				return;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x000329FC File Offset: 0x00030BFC
		private SemaphoreSlim AsyncActiveSemaphore
		{
			get
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
		}

		// Token: 0x04000C1D RID: 3101
		private readonly Stream _stream;

		// Token: 0x04000C1E RID: 3102
		private readonly ICryptoTransform _transform;

		// Token: 0x04000C1F RID: 3103
		private readonly CryptoStreamMode _transformMode;

		// Token: 0x04000C20 RID: 3104
		private byte[] _inputBuffer;

		// Token: 0x04000C21 RID: 3105
		private int _inputBufferIndex;

		// Token: 0x04000C22 RID: 3106
		private int _inputBlockSize;

		// Token: 0x04000C23 RID: 3107
		private byte[] _outputBuffer;

		// Token: 0x04000C24 RID: 3108
		private int _outputBufferIndex;

		// Token: 0x04000C25 RID: 3109
		private int _outputBlockSize;

		// Token: 0x04000C26 RID: 3110
		private bool _canRead;

		// Token: 0x04000C27 RID: 3111
		private bool _canWrite;

		// Token: 0x04000C28 RID: 3112
		private bool _finalBlockTransformed;

		// Token: 0x04000C29 RID: 3113
		private SemaphoreSlim _lazyAsyncActiveSemaphore;

		// Token: 0x04000C2A RID: 3114
		private readonly bool _leaveOpen;

		// Token: 0x020002B6 RID: 694
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ReadAsyncInternal>d__37 : IAsyncStateMachine
		{
			// Token: 0x060017A4 RID: 6052 RVA: 0x00032A14 File Offset: 0x00030C14
			private void MoveNext()
			{
				CryptoStream cryptoStream = this.<>4__this;
				TaskAwaiter<int> taskAwaiter = this.<>u__2;
			}

			// Token: 0x060017A5 RID: 6053 RVA: 0x00032AF4 File Offset: 0x00030CF4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000C2B RID: 3115
			public int <>1__state;

			// Token: 0x04000C2C RID: 3116
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000C2D RID: 3117
			public CryptoStream <>4__this;

			// Token: 0x04000C2E RID: 3118
			public byte[] buffer;

			// Token: 0x04000C2F RID: 3119
			public int offset;

			// Token: 0x04000C30 RID: 3120
			public int count;

			// Token: 0x04000C31 RID: 3121
			public CancellationToken cancellationToken;

			// Token: 0x04000C32 RID: 3122
			private SemaphoreSlim <semaphore>5__2;

			// Token: 0x04000C33 RID: 3123
			private ForceAsyncAwaiter <>u__1;

			// Token: 0x04000C34 RID: 3124
			private TaskAwaiter<int> <>u__2;
		}

		// Token: 0x020002B7 RID: 695
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ReadAsyncCore>d__42 : IAsyncStateMachine
		{
			// Token: 0x060017A6 RID: 6054 RVA: 0x00032B04 File Offset: 0x00030D04
			private void MoveNext()
			{
				CryptoStream cryptoStream = this.<>4__this;
			}

			// Token: 0x060017A7 RID: 6055 RVA: 0x00032EB4 File Offset: 0x000310B4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000C35 RID: 3125
			public int <>1__state;

			// Token: 0x04000C36 RID: 3126
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000C37 RID: 3127
			public int count;

			// Token: 0x04000C38 RID: 3128
			public int offset;

			// Token: 0x04000C39 RID: 3129
			public CryptoStream <>4__this;

			// Token: 0x04000C3A RID: 3130
			public byte[] buffer;

			// Token: 0x04000C3B RID: 3131
			public bool useAsync;

			// Token: 0x04000C3C RID: 3132
			public CancellationToken cancellationToken;

			// Token: 0x04000C3D RID: 3133
			private int <bytesToDeliver>5__2;

			// Token: 0x04000C3E RID: 3134
			private int <currentOutputIndex>5__3;

			// Token: 0x04000C3F RID: 3135
			private int <numWholeBlocksInBytes>5__4;

			// Token: 0x04000C40 RID: 3136
			private byte[] <tempInputBuffer>5__5;

			// Token: 0x04000C41 RID: 3137
			private byte[] <tempOutputBuffer>5__6;

			// Token: 0x04000C42 RID: 3138
			private ValueTaskAwaiter<int> <>u__1;
		}

		// Token: 0x020002B8 RID: 696
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WriteAsyncInternal>d__46 : IAsyncStateMachine
		{
			// Token: 0x060017A8 RID: 6056 RVA: 0x00032EC4 File Offset: 0x000310C4
			private void MoveNext()
			{
				CryptoStream cryptoStream = this.<>4__this;
				TaskAwaiter taskAwaiter = this.<>u__2;
			}

			// Token: 0x060017A9 RID: 6057 RVA: 0x00032FB4 File Offset: 0x000311B4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000C43 RID: 3139
			public int <>1__state;

			// Token: 0x04000C44 RID: 3140
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000C45 RID: 3141
			public CryptoStream <>4__this;

			// Token: 0x04000C46 RID: 3142
			public byte[] buffer;

			// Token: 0x04000C47 RID: 3143
			public int offset;

			// Token: 0x04000C48 RID: 3144
			public int count;

			// Token: 0x04000C49 RID: 3145
			public CancellationToken cancellationToken;

			// Token: 0x04000C4A RID: 3146
			private SemaphoreSlim <semaphore>5__2;

			// Token: 0x04000C4B RID: 3147
			private ForceAsyncAwaiter <>u__1;

			// Token: 0x04000C4C RID: 3148
			private TaskAwaiter <>u__2;
		}

		// Token: 0x020002B9 RID: 697
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WriteAsyncCore>d__49 : IAsyncStateMachine
		{
			// Token: 0x060017AA RID: 6058 RVA: 0x00032FC4 File Offset: 0x000311C4
			private void MoveNext()
			{
				CryptoStream cryptoStream = this.<>4__this;
			}

			// Token: 0x060017AB RID: 6059 RVA: 0x00033264 File Offset: 0x00031464
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000C4D RID: 3149
			public int <>1__state;

			// Token: 0x04000C4E RID: 3150
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000C4F RID: 3151
			public int count;

			// Token: 0x04000C50 RID: 3152
			public int offset;

			// Token: 0x04000C51 RID: 3153
			public CryptoStream <>4__this;

			// Token: 0x04000C52 RID: 3154
			public byte[] buffer;

			// Token: 0x04000C53 RID: 3155
			public bool useAsync;

			// Token: 0x04000C54 RID: 3156
			public CancellationToken cancellationToken;

			// Token: 0x04000C55 RID: 3157
			private int <bytesToWrite>5__2;

			// Token: 0x04000C56 RID: 3158
			private int <currentInputIndex>5__3;

			// Token: 0x04000C57 RID: 3159
			private int <numOutputBytes>5__4;

			// Token: 0x04000C58 RID: 3160
			private ValueTaskAwaiter <>u__1;

			// Token: 0x04000C59 RID: 3161
			private int <numWholeBlocksInBytes>5__5;

			// Token: 0x04000C5A RID: 3162
			private byte[] <tempOutputBuffer>5__6;
		}

		// Token: 0x020002BA RID: 698
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060017AC RID: 6060 RVA: 0x00033274 File Offset: 0x00031474
			// Note: this type is marked as 'beforefieldinit'.
			static <>c()
			{
			}

			// Token: 0x060017AD RID: 6061 RVA: 0x00033284 File Offset: 0x00031484
			public <>c()
			{
			}

			// Token: 0x060017AE RID: 6062 RVA: 0x0000207A File Offset: 0x0000027A
			internal SemaphoreSlim <get_AsyncActiveSemaphore>b__54_0()
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000C5B RID: 3163
			public static readonly CryptoStream.<>c <>9;

			// Token: 0x04000C5C RID: 3164
			public static Func<SemaphoreSlim> <>9__54_0;
		}
	}
}
