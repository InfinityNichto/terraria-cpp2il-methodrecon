using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x02000230 RID: 560
	internal class BufferedReadStream : WebReadStream
	{
		// Token: 0x06000E15 RID: 3605 RVA: 0x0002CD6C File Offset: 0x0002AF6C
		public BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer)
			: base(operation, innerStream)
		{
			this.readBuffer = readBuffer;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0002CD88 File Offset: 0x0002AF88
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06000E16)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.BufferedReadStream::ProcessReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)

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

		// Token: 0x06000E17 RID: 3607 RVA: 0x0002CD98 File Offset: 0x0002AF98
		internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, [Out] int result)
		{
			/*
An exception occurred when decompiling this method (06000E17)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Net.BufferedReadStream::TryReadFromBuffer(System.Byte[],System.Int32,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0047:
	stloc:Stream(var_7_4D, ldfld:Stream(WebReadStream::<InnerStream>k__BackingField, ldloc:BufferedReadStream[exp:WebReadStream](this)))
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

		// Token: 0x04000BB2 RID: 2994
		private readonly BufferOffsetSize readBuffer;

		// Token: 0x02000231 RID: 561
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ProcessReadAsync>d__2 : IAsyncStateMachine
		{
			// Token: 0x06000E18 RID: 3608 RVA: 0x0002CDF4 File Offset: 0x0002AFF4
			private void MoveNext()
			{
				BufferedReadStream bufferedReadStream = this.<>4__this;
				BufferOffsetSize readBuffer = bufferedReadStream.readBuffer;
				if (readBuffer != null)
				{
					int num = readBuffer.Size;
					int num2 = this.size;
					byte[] array = readBuffer.Buffer;
					int num3 = readBuffer.Offset;
					byte[] array2 = this.buffer;
					int num4 = this.offset;
					Buffer.BlockCopy(array, num3, array2, num4, 43163648);
					BufferOffsetSize readBuffer2 = bufferedReadStream.readBuffer;
					int num5 = readBuffer2.Offset;
					readBuffer2.Offset = num5;
					int num6 = this.offset;
					int num7 = this.size;
					this.offset = num6;
					this.size = num7;
					return;
				}
				if (bufferedReadStream.<InnerStream>k__BackingField != null)
				{
					byte[] array3 = this.buffer;
					int num8 = this.offset;
					int num9 = this.size;
					CancellationToken cancellationToken = this.cancellationToken;
					return;
				}
			}

			// Token: 0x06000E19 RID: 3609 RVA: 0x0002CEC4 File Offset: 0x0002B0C4
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000BB3 RID: 2995
			public int <>1__state;

			// Token: 0x04000BB4 RID: 2996
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000BB5 RID: 2997
			public CancellationToken cancellationToken;

			// Token: 0x04000BB6 RID: 2998
			public BufferedReadStream <>4__this;

			// Token: 0x04000BB7 RID: 2999
			public int size;

			// Token: 0x04000BB8 RID: 3000
			public byte[] buffer;

			// Token: 0x04000BB9 RID: 3001
			public int offset;

			// Token: 0x04000BBA RID: 3002
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
