using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net
{
	// Token: 0x02000244 RID: 580
	internal class FixedSizeReadStream : WebReadStream
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
		public long ContentLength
		{
			[CompilerGenerated]
			get
			{
				return this.<ContentLength>k__BackingField;
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
		public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength)
			: base(operation, innerStream)
		{
			this.ContentLength = contentLength;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0002EA00 File Offset: 0x0002CC00
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06000EA8)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task`1<System.Int32> System.Net.FixedSizeReadStream::ProcessReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)

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

		// Token: 0x04000BE9 RID: 3049
		[CompilerGenerated]
		private readonly long <ContentLength>k__BackingField;

		// Token: 0x04000BEA RID: 3050
		private long position;

		// Token: 0x02000245 RID: 581
		[CompilerGenerated]
		[StructLayout(3)]
		private struct <ProcessReadAsync>d__5 : IAsyncStateMachine
		{
			// Token: 0x06000EA9 RID: 3753 RVA: 0x0002EA10 File Offset: 0x0002CC10
			private void MoveNext()
			{
				FixedSizeReadStream fixedSizeReadStream = this.<>4__this;
				long <ContentLength>k__BackingField = fixedSizeReadStream.<ContentLength>k__BackingField;
				long position = fixedSizeReadStream.position;
				Stream <InnerStream>k__BackingField = fixedSizeReadStream.<InnerStream>k__BackingField;
				byte[] array = this.buffer;
				int num = this.offset;
				CancellationToken cancellationToken = this.cancellationToken;
			}

			// Token: 0x06000EAA RID: 3754 RVA: 0x0002EA74 File Offset: 0x0002CC74
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			// Token: 0x04000BEB RID: 3051
			public int <>1__state;

			// Token: 0x04000BEC RID: 3052
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04000BED RID: 3053
			public CancellationToken cancellationToken;

			// Token: 0x04000BEE RID: 3054
			public FixedSizeReadStream <>4__this;

			// Token: 0x04000BEF RID: 3055
			public int size;

			// Token: 0x04000BF0 RID: 3056
			public byte[] buffer;

			// Token: 0x04000BF1 RID: 3057
			public int offset;

			// Token: 0x04000BF2 RID: 3058
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
