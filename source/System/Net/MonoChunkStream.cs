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
	// Token: 0x02000266 RID: 614
	internal class MonoChunkStream : WebReadStream
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x0003463C File Offset: 0x0003283C
		protected WebHeaderCollection Headers
		{
			[CompilerGenerated]
			get
			{
				return this.<Headers>k__BackingField;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x00034650 File Offset: 0x00032850
		protected MonoChunkParser Decoder
		{
			[CompilerGenerated]
			get
			{
				return this.<Decoder>k__BackingField;
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00034664 File Offset: 0x00032864
		public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers)
			: base(operation, innerStream)
		{
			this.Headers = headers;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00034680 File Offset: 0x00032880
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (0600108E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.MonoChunkStream::ProcessReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)

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

		// Token: 0x0600108F RID: 4239 RVA: 0x00034690 File Offset: 0x00032890
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002050 File Offset: 0x00000250
		private static void ThrowExpectingChunkTrailer()
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x000346AC File Offset: 0x000328AC
		[DebuggerHidden]
		[CompilerGenerated]
		private Task <>n__0(CancellationToken cancellationToken)
		{
			return base.FinishReading(cancellationToken);
		}

		// Token: 0x04000D07 RID: 3335
		[CompilerGenerated]
		private readonly WebHeaderCollection <Headers>k__BackingField;

		// Token: 0x04000D08 RID: 3336
		[CompilerGenerated]
		private readonly MonoChunkParser <Decoder>k__BackingField;

		// Token: 0x02000267 RID: 615
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ProcessReadAsync>d__7 : IAsyncStateMachine
		{
			// Token: 0x06001092 RID: 4242 RVA: 0x000346C0 File Offset: 0x000328C0
			private void MoveNext()
			{
				MonoChunkStream monoChunkStream = this.<>4__this;
				bool dataAvailable = monoChunkStream.<Decoder>k__BackingField.DataAvailable;
				MonoChunkParser <Decoder>k__BackingField = monoChunkStream.<Decoder>k__BackingField;
				byte[] array = this.buffer;
				int num = this.offset;
				byte[] array2 = this.<moreBytes>5__2;
			}

			// Token: 0x06001093 RID: 4243 RVA: 0x000347A0 File Offset: 0x000329A0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000D09 RID: 3337
			public int <>1__state;

			// Token: 0x04000D0A RID: 3338
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000D0B RID: 3339
			public CancellationToken cancellationToken;

			// Token: 0x04000D0C RID: 3340
			public MonoChunkStream <>4__this;

			// Token: 0x04000D0D RID: 3341
			public byte[] buffer;

			// Token: 0x04000D0E RID: 3342
			public int offset;

			// Token: 0x04000D0F RID: 3343
			public int size;

			// Token: 0x04000D10 RID: 3344
			private byte[] <moreBytes>5__2;

			// Token: 0x04000D11 RID: 3345
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000268 RID: 616
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <FinishReading>d__8 : IAsyncStateMachine
		{
			// Token: 0x06001094 RID: 4244 RVA: 0x000347B0 File Offset: 0x000329B0
			private void MoveNext()
			{
				MonoChunkStream monoChunkStream = this.<>4__this;
			}

			// Token: 0x06001095 RID: 4245 RVA: 0x000348B0 File Offset: 0x00032AB0
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000D12 RID: 3346
			public int <>1__state;

			// Token: 0x04000D13 RID: 3347
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04000D14 RID: 3348
			public MonoChunkStream <>4__this;

			// Token: 0x04000D15 RID: 3349
			public CancellationToken cancellationToken;

			// Token: 0x04000D16 RID: 3350
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04000D17 RID: 3351
			private byte[] <buffer>5__2;

			// Token: 0x04000D18 RID: 3352
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
