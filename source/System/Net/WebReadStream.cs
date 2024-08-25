using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200028D RID: 653
	internal abstract class WebReadStream : Stream
	{
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000382D4 File Offset: 0x000364D4
		public WebOperation Operation
		{
			[CompilerGenerated]
			get
			{
				return this.<Operation>k__BackingField;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x000382E8 File Offset: 0x000364E8
		protected Stream InnerStream
		{
			[CompilerGenerated]
			get
			{
				return this.<InnerStream>k__BackingField;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x000382FC File Offset: 0x000364FC
		internal string ME
		{
			get
			{
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0003830C File Offset: 0x0003650C
		public WebReadStream(WebOperation operation, Stream innerStream)
		{
			if (!true)
			{
			}
			base..ctor();
			this.Operation = operation;
			this.InnerStream = innerStream;
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x00002050 File Offset: 0x00000250
		public override long Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
		public override long Position
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00038330 File Offset: 0x00036530
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x00038340 File Offset: 0x00036540
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00038350 File Offset: 0x00036550
		public override bool CanWrite
		{
			get
			{
			}
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00002050 File Offset: 0x00000250
		public override void SetLength(long value)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00002050 File Offset: 0x00000250
		public override void Flush()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00038360 File Offset: 0x00036560
		protected Exception GetException(Exception e)
		{
			if (!true)
			{
			}
			Exception ex = HttpWebRequest.FlattenException(e);
			if (ex != null)
			{
			}
			bool aborted = this.<Operation>k__BackingField.Aborted;
			WebException ex2 = HttpWebRequest.CreateRequestAbortedException();
			if (ex != null)
			{
			}
			return ex;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00038394 File Offset: 0x00036594
		public override int Read(byte[] buffer, int offset, int size)
		{
			this.<Operation>k__BackingField.ThrowIfClosedOrDisposed();
			if (buffer != null)
			{
				CancellationToken none = CancellationToken.None;
				return "offset";
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000383C0 File Offset: 0x000365C0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			do
			{
				this.<Operation>k__BackingField.ThrowIfClosedOrDisposed();
			}
			while (buffer == null);
			CancellationToken none = CancellationToken.None;
			IAsyncResult asyncResult;
			return asyncResult;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000383EC File Offset: 0x000365EC
		public override int EndRead(IAsyncResult r)
		{
			if (r != null)
			{
				return TaskToApm.End<int>(r);
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00038404 File Offset: 0x00036604
		public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001225)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.WebReadStream::ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)

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

		// Token: 0x06001226 RID: 4646
		protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

		// Token: 0x06001227 RID: 4647 RVA: 0x00038414 File Offset: 0x00036614
		internal virtual Task FinishReading(CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001227)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Net.WebReadStream::FinishReading(System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0014:
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

		// Token: 0x06001228 RID: 4648 RVA: 0x00038438 File Offset: 0x00036638
		protected override void Dispose(bool disposing)
		{
			long num;
			if (!this.disposed)
			{
				Stream stream = this.<InnerStream>k__BackingField;
				this.disposed = true;
				if (stream != null)
				{
					num = 0L;
					stream.Dispose();
				}
			}
			base.Dispose(num != 0L);
		}

		// Token: 0x04000E0B RID: 3595
		[CompilerGenerated]
		private readonly WebOperation <Operation>k__BackingField;

		// Token: 0x04000E0C RID: 3596
		[CompilerGenerated]
		private readonly Stream <InnerStream>k__BackingField;

		// Token: 0x04000E0D RID: 3597
		private bool disposed;

		// Token: 0x0200028E RID: 654
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ReadAsync>d__28 : IAsyncStateMachine
		{
			// Token: 0x06001229 RID: 4649 RVA: 0x00038470 File Offset: 0x00036670
			private void MoveNext()
			{
				WebReadStream webReadStream = this.<>4__this;
				WebOperation <Operation>k__BackingField = webReadStream.<Operation>k__BackingField;
				CancellationToken cancellationToken = this.cancellationToken;
				<Operation>k__BackingField.ThrowIfDisposed(cancellationToken);
				if (this.buffer != null)
				{
					int num = this.offset;
					int num2 = this.size;
					Task task = this.<>u__2.m_task;
					this.<>1__state = num;
					return;
				}
			}

			// Token: 0x0600122A RID: 4650 RVA: 0x00038574 File Offset: 0x00036774
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E0E RID: 3598
			public int <>1__state;

			// Token: 0x04000E0F RID: 3599
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000E10 RID: 3600
			public WebReadStream <>4__this;

			// Token: 0x04000E11 RID: 3601
			public CancellationToken cancellationToken;

			// Token: 0x04000E12 RID: 3602
			public byte[] buffer;

			// Token: 0x04000E13 RID: 3603
			public int offset;

			// Token: 0x04000E14 RID: 3604
			public int size;

			// Token: 0x04000E15 RID: 3605
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E16 RID: 3606
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
