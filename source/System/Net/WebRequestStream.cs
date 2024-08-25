using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x0200028F RID: 655
	internal class WebRequestStream : WebConnectionStream
	{
		// Token: 0x0600122B RID: 4651 RVA: 0x00038584 File Offset: 0x00036784
		public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel)
			: base(connection, operation)
		{
			this.InnerStream = stream;
			bool internalAllowBuffering = operation.<Request>k__BackingField.InternalAllowBuffering;
			this.allowBuffering = true;
			BufferOffsetSize <WriteBuffer>k__BackingField;
			if (operation.<Request>k__BackingField.sendChunked)
			{
				<WriteBuffer>k__BackingField = operation.<WriteBuffer>k__BackingField;
			}
			this.sendChunked = <WriteBuffer>k__BackingField != null;
			if (<WriteBuffer>k__BackingField != null || operation.<WriteBuffer>k__BackingField == null)
			{
			}
			bool keepAlive = this.<Request>k__BackingField.keepAlive;
			this.KeepAlive = keepAlive;
			if (tunnel != null)
			{
				Version <ProxyVersion>k__BackingField = tunnel.<ProxyVersion>k__BackingField;
				return;
			}
			if (tunnel != null)
			{
				Version <ProxyVersion>k__BackingField2 = tunnel.<ProxyVersion>k__BackingField;
			}
			if (!keepAlive)
			{
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0003860C File Offset: 0x0003680C
		internal Stream InnerStream
		{
			[CompilerGenerated]
			get
			{
				return this.<InnerStream>k__BackingField;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00038620 File Offset: 0x00036820
		public bool KeepAlive
		{
			[CompilerGenerated]
			get
			{
				return this.<KeepAlive>k__BackingField;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00038634 File Offset: 0x00036834
		public override bool CanRead
		{
			get
			{
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x00038644 File Offset: 0x00036844
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00038654 File Offset: 0x00036854
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x00038668 File Offset: 0x00036868
		internal bool SendChunked
		{
			get
			{
				return this.sendChunked;
			}
			set
			{
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00038678 File Offset: 0x00036878
		internal bool HasWriteBuffer
		{
			get
			{
				return this.<Operation>k__BackingField.<WriteBuffer>k__BackingField == null || true;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00038698 File Offset: 0x00036898
		internal int WriteBufferLength
		{
			get
			{
				BufferOffsetSize <WriteBuffer>k__BackingField = this.<Operation>k__BackingField.<WriteBuffer>k__BackingField;
				int size;
				if (<WriteBuffer>k__BackingField != null)
				{
					size = <WriteBuffer>k__BackingField.Size;
					return size;
				}
				if (size != 0)
				{
					return size;
				}
				return size;
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x000386C4 File Offset: 0x000368C4
		internal BufferOffsetSize GetWriteBuffer()
		{
			/*
An exception occurred when decompiling this method (06001234)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.BufferOffsetSize System.Net.WebRequestStream::GetWriteBuffer()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:MemoryStream(var_1_20, ldfld:MemoryStream(WebRequestStream::writeBuffer, ldloc:WebRequestStream(this)))
	stloc:MemoryStream(var_2_27, ldfld:MemoryStream(WebRequestStream::writeBuffer, ldloc:WebRequestStream(this)))
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

		// Token: 0x06001235 RID: 4661 RVA: 0x000386F8 File Offset: 0x000368F8
		private Task FinishWriting(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x00038714 File Offset: 0x00036914
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001236)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.Net.WebRequestStream::WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0024:
	stloc:string(var_5_2E, call:string(SR::GetString, ldstr:string("Cannot re-call BeginGetRequestStream/BeginGetResponse while a previous call is still in progress.")))
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

		// Token: 0x06001237 RID: 4663 RVA: 0x00038750 File Offset: 0x00036950
		private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0003876C File Offset: 0x0003696C
		private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x00038788 File Offset: 0x00036988
		private void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000387A8 File Offset: 0x000369A8
		internal Task Initialize(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000387C4 File Offset: 0x000369C4
		private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000387E0 File Offset: 0x000369E0
		internal Task WriteRequestAsync(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000387FC File Offset: 0x000369FC
		private Task WriteChunkTrailer_inner(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x00038818 File Offset: 0x00036A18
		private Task WriteChunkTrailer()
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00038834 File Offset: 0x00036A34
		internal void KillBuffer()
		{
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x00038844 File Offset: 0x00036A44
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, [Out] int result)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x00038858 File Offset: 0x00036A58
		protected override void Close_internal(bool disposed)
		{
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x000388D8 File Offset: 0x00036AD8
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestStream()
		{
		}

		// Token: 0x04000E17 RID: 3607
		private static byte[] crlf;

		// Token: 0x04000E18 RID: 3608
		private MemoryStream writeBuffer;

		// Token: 0x04000E19 RID: 3609
		private bool requestWritten;

		// Token: 0x04000E1A RID: 3610
		private bool allowBuffering;

		// Token: 0x04000E1B RID: 3611
		private bool sendChunked;

		// Token: 0x04000E1C RID: 3612
		private WebCompletionSource pendingWrite;

		// Token: 0x04000E1D RID: 3613
		private long totalWritten;

		// Token: 0x04000E1E RID: 3614
		private byte[] headers;

		// Token: 0x04000E1F RID: 3615
		private bool headersSent;

		// Token: 0x04000E20 RID: 3616
		private int completeRequestWritten;

		// Token: 0x04000E21 RID: 3617
		private int chunkTrailerWritten;

		// Token: 0x04000E22 RID: 3618
		internal readonly string ME;

		// Token: 0x04000E23 RID: 3619
		[CompilerGenerated]
		private readonly Stream <InnerStream>k__BackingField;

		// Token: 0x04000E24 RID: 3620
		[CompilerGenerated]
		private readonly bool <KeepAlive>k__BackingField;

		// Token: 0x02000290 RID: 656
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <FinishWriting>d__31 : IAsyncStateMachine
		{
			// Token: 0x06001244 RID: 4676 RVA: 0x000388E8 File Offset: 0x00036AE8
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				int num;
				if (num == 0)
				{
					WebOperation <Operation>k__BackingField = webRequestStream.<Operation>k__BackingField;
					CancellationToken cancellationToken = this.cancellationToken;
					<Operation>k__BackingField.ThrowIfClosedOrDisposed(cancellationToken);
					if (webRequestStream.sendChunked)
					{
						CancellationToken cancellationToken2 = this.cancellationToken;
						Task task = webRequestStream.WriteChunkTrailer_inner(cancellationToken2);
						long num2 = 0L;
						ConfiguredTaskAwaitable configuredTaskAwaitable = task.ConfigureAwait(num2 != 0L);
						return;
					}
					WebOperation <Operation>k__BackingField2 = webRequestStream.<Operation>k__BackingField;
				}
			}

			// Token: 0x06001245 RID: 4677 RVA: 0x00038994 File Offset: 0x00036B94
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E25 RID: 3621
			public int <>1__state;

			// Token: 0x04000E26 RID: 3622
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E27 RID: 3623
			public WebRequestStream <>4__this;

			// Token: 0x04000E28 RID: 3624
			public CancellationToken cancellationToken;

			// Token: 0x04000E29 RID: 3625
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000291 RID: 657
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WriteAsyncInner>d__33 : IAsyncStateMachine
		{
			// Token: 0x06001246 RID: 4678 RVA: 0x000389A4 File Offset: 0x00036BA4
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				TaskAwaiter taskAwaiter = this.<>u__2;
			}

			// Token: 0x06001247 RID: 4679 RVA: 0x00038A98 File Offset: 0x00036C98
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E2A RID: 3626
			public int <>1__state;

			// Token: 0x04000E2B RID: 3627
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E2C RID: 3628
			public WebRequestStream <>4__this;

			// Token: 0x04000E2D RID: 3629
			public byte[] buffer;

			// Token: 0x04000E2E RID: 3630
			public int offset;

			// Token: 0x04000E2F RID: 3631
			public int size;

			// Token: 0x04000E30 RID: 3632
			public CancellationToken cancellationToken;

			// Token: 0x04000E31 RID: 3633
			public WebCompletionSource completion;

			// Token: 0x04000E32 RID: 3634
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E33 RID: 3635
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000292 RID: 658
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ProcessWrite>d__34 : IAsyncStateMachine
		{
			// Token: 0x06001248 RID: 4680 RVA: 0x00038AA8 File Offset: 0x00036CA8
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				CancellationToken cancellationToken = this.cancellationToken;
				webRequestStream.<Operation>k__BackingField.ThrowIfClosedOrDisposed(cancellationToken);
				if (webRequestStream.sendChunked)
				{
					int num = 1;
					webRequestStream.requestWritten = num != 0;
					int num2 = this.size;
					Encoding ascii = Encoding.ASCII;
					int num3 = this.size;
					CodePageDataItem dataItem = ascii.dataItem;
					CodePageDataItem dataItem2 = ascii.dataItem;
					byte[] array = this.buffer;
					int num4 = this.offset;
					int num5 = this.size;
					CodePageDataItem dataItem3 = ascii.dataItem;
					if (num3 == 0)
					{
					}
					CodePageDataItem dataItem4 = ascii.dataItem;
					int num6 = this.size;
					if (webRequestStream.allowBuffering)
					{
						if (webRequestStream.writeBuffer == null)
						{
						}
						byte[] array2 = this.buffer;
						int num7 = this.offset;
						int num8 = this.size;
					}
					long totalWritten = webRequestStream.totalWritten;
					webRequestStream.totalWritten = totalWritten;
					string text;
					this.size = text;
					Stream <InnerStream>k__BackingField = webRequestStream.<InnerStream>k__BackingField;
					CancellationToken cancellationToken2 = this.cancellationToken;
					return;
				}
				HttpWebRequest <Request>k__BackingField = webRequestStream.<Request>k__BackingField;
				long totalWritten2 = webRequestStream.totalWritten;
				if (webRequestStream.allowBuffering)
				{
					if (webRequestStream.writeBuffer == null)
					{
					}
					byte[] array3 = this.buffer;
					int num9 = this.offset;
					int num10 = this.size;
					long totalWritten3 = webRequestStream.totalWritten;
					HttpWebRequest <Request>k__BackingField2 = webRequestStream.<Request>k__BackingField;
					webRequestStream.totalWritten = totalWritten3;
					HttpWebRequest <Request>k__BackingField3 = webRequestStream.<Request>k__BackingField;
					long totalWritten4 = webRequestStream.totalWritten;
					MemoryStream writeBuffer = webRequestStream.writeBuffer;
					int num11 = 1;
					webRequestStream.requestWritten = num11 != 0;
					this.buffer = writeBuffer;
					long totalWritten5 = webRequestStream.totalWritten;
					return;
				}
				long totalWritten6 = webRequestStream.totalWritten;
				webRequestStream.totalWritten = totalWritten6;
				byte[] array4 = this.buffer;
				int num12 = this.offset;
			}

			// Token: 0x06001249 RID: 4681 RVA: 0x00038C58 File Offset: 0x00036E58
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E34 RID: 3636
			public int <>1__state;

			// Token: 0x04000E35 RID: 3637
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E36 RID: 3638
			public WebRequestStream <>4__this;

			// Token: 0x04000E37 RID: 3639
			public CancellationToken cancellationToken;

			// Token: 0x04000E38 RID: 3640
			public int size;

			// Token: 0x04000E39 RID: 3641
			public byte[] buffer;

			// Token: 0x04000E3A RID: 3642
			public int offset;

			// Token: 0x04000E3B RID: 3643
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000293 RID: 659
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <Initialize>d__36 : IAsyncStateMachine
		{
			// Token: 0x0600124A RID: 4682 RVA: 0x00038C68 File Offset: 0x00036E68
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				TaskAwaiter taskAwaiter = this.<>u__2;
			}

			// Token: 0x0600124B RID: 4683 RVA: 0x00038D88 File Offset: 0x00036F88
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E3C RID: 3644
			public int <>1__state;

			// Token: 0x04000E3D RID: 3645
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E3E RID: 3646
			public WebRequestStream <>4__this;

			// Token: 0x04000E3F RID: 3647
			public CancellationToken cancellationToken;

			// Token: 0x04000E40 RID: 3648
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E41 RID: 3649
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000294 RID: 660
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <SetHeadersAsync>d__37 : IAsyncStateMachine
		{
			// Token: 0x0600124C RID: 4684 RVA: 0x00038D98 File Offset: 0x00036F98
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				WebOperation <Operation>k__BackingField = webRequestStream.<Operation>k__BackingField;
				CancellationToken cancellationToken = this.cancellationToken;
				<Operation>k__BackingField.ThrowIfClosedOrDisposed(cancellationToken);
				if (webRequestStream.headersSent)
				{
					return;
				}
				HttpWebRequest <Request>k__BackingField = webRequestStream.<Request>k__BackingField;
				WebOperation <Operation>k__BackingField2 = webRequestStream.<Operation>k__BackingField;
				bool flag = this.setInternalLength;
				bool <IsNtlmChallenge>k__BackingField = <Operation>k__BackingField2.<IsNtlmChallenge>k__BackingField;
				if (!flag)
				{
					return;
				}
				BufferOffsetSize <WriteBuffer>k__BackingField = <Operation>k__BackingField2.<WriteBuffer>k__BackingField;
				if (<WriteBuffer>k__BackingField != null)
				{
					HttpWebRequest <Request>k__BackingField2 = webRequestStream.<Request>k__BackingField;
					int size = <WriteBuffer>k__BackingField.Size;
					return;
				}
				WebOperation <Operation>k__BackingField3;
				if (webRequestStream.writeBuffer != null)
				{
					HttpWebRequest <Request>k__BackingField3 = webRequestStream.<Request>k__BackingField;
					<Operation>k__BackingField3 = webRequestStream.<Operation>k__BackingField;
					<Request>k__BackingField3.contentLength = <WriteBuffer>k__BackingField;
				}
				if (<Operation>k__BackingField3.<WriteBuffer>k__BackingField != null || webRequestStream.writeBuffer != null)
				{
					HttpWebRequest <Request>k__BackingField4 = webRequestStream.<Request>k__BackingField;
					bool sendChunked = webRequestStream.sendChunked;
					HttpWebRequest <Request>k__BackingField5 = webRequestStream.<Request>k__BackingField;
					int num = 1;
					webRequestStream.headersSent = num != 0;
					byte[] requestHeaders = <Request>k__BackingField5.GetRequestHeaders();
					Stream <InnerStream>k__BackingField = webRequestStream.<InnerStream>k__BackingField;
					webRequestStream.headers = requestHeaders;
					CancellationToken cancellationToken2 = this.cancellationToken;
					return;
				}
			}

			// Token: 0x0600124D RID: 4685 RVA: 0x00038EE4 File Offset: 0x000370E4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E42 RID: 3650
			public int <>1__state;

			// Token: 0x04000E43 RID: 3651
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E44 RID: 3652
			public WebRequestStream <>4__this;

			// Token: 0x04000E45 RID: 3653
			public CancellationToken cancellationToken;

			// Token: 0x04000E46 RID: 3654
			public bool setInternalLength;

			// Token: 0x04000E47 RID: 3655
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000295 RID: 661
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WriteRequestAsync>d__38 : IAsyncStateMachine
		{
			// Token: 0x0600124E RID: 4686 RVA: 0x00038EF4 File Offset: 0x000370F4
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				TaskAwaiter taskAwaiter = this.<>u__2;
			}

			// Token: 0x0600124F RID: 4687 RVA: 0x00039094 File Offset: 0x00037294
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E48 RID: 3656
			public int <>1__state;

			// Token: 0x04000E49 RID: 3657
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E4A RID: 3658
			public WebRequestStream <>4__this;

			// Token: 0x04000E4B RID: 3659
			public CancellationToken cancellationToken;

			// Token: 0x04000E4C RID: 3660
			private BufferOffsetSize <buffer>5__2;

			// Token: 0x04000E4D RID: 3661
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E4E RID: 3662
			private TaskAwaiter <>u__2;
		}

		// Token: 0x02000296 RID: 662
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WriteChunkTrailer_inner>d__39 : IAsyncStateMachine
		{
			// Token: 0x06001250 RID: 4688 RVA: 0x000390A4 File Offset: 0x000372A4
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				int num;
				if (num == 0)
				{
					WebOperation <Operation>k__BackingField = webRequestStream.<Operation>k__BackingField;
					CancellationToken cancellationToken = this.cancellationToken;
					<Operation>k__BackingField.ThrowIfClosedOrDisposed(cancellationToken);
					Encoding ascii = Encoding.ASCII;
					Stream <InnerStream>k__BackingField = webRequestStream.<InnerStream>k__BackingField;
					CancellationToken cancellationToken2 = this.cancellationToken;
					CodePageDataItem dataItem = ascii.dataItem;
					return;
				}
			}

			// Token: 0x06001251 RID: 4689 RVA: 0x00039114 File Offset: 0x00037314
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E4F RID: 3663
			public int <>1__state;

			// Token: 0x04000E50 RID: 3664
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E51 RID: 3665
			public WebRequestStream <>4__this;

			// Token: 0x04000E52 RID: 3666
			public CancellationToken cancellationToken;

			// Token: 0x04000E53 RID: 3667
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000297 RID: 663
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <WriteChunkTrailer>d__40 : IAsyncStateMachine
		{
			// Token: 0x06001252 RID: 4690 RVA: 0x00039124 File Offset: 0x00037324
			private void MoveNext()
			{
				WebRequestStream webRequestStream = this.<>4__this;
				CancellationToken token = this.<cts>5__2.Token;
				Task task;
				this.<timeoutTask>5__3 = task;
			}

			// Token: 0x06001253 RID: 4691 RVA: 0x00039230 File Offset: 0x00037430
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000E54 RID: 3668
			public int <>1__state;

			// Token: 0x04000E55 RID: 3669
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000E56 RID: 3670
			public WebRequestStream <>4__this;

			// Token: 0x04000E57 RID: 3671
			private CancellationTokenSource <cts>5__2;

			// Token: 0x04000E58 RID: 3672
			private Task <timeoutTask>5__3;

			// Token: 0x04000E59 RID: 3673
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000E5A RID: 3674
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
