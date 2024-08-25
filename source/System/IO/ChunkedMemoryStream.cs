using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace System.IO
{
	// Token: 0x02000439 RID: 1081
	internal sealed class ChunkedMemoryStream : Stream
	{
		// Token: 0x06001D8E RID: 7566 RVA: 0x0004F6EC File Offset: 0x0004D8EC
		internal ChunkedMemoryStream()
		{
			if (!true)
			{
			}
			base..ctor();
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0004F704 File Offset: 0x0004D904
		public byte[] ToArray()
		{
			/*
An exception occurred when decompiling this method (06001D8F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.IO.ChunkedMemoryStream::ToArray()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_2_17, ldfld:uint8[](MemoryChunk::_buffer, ldloc:MemoryChunk(var_1_0D)))
	stloc:int32(var_3_1E, ldfld:int32(MemoryChunk::_freeOffset, ldloc:MemoryChunk(var_1_0D)))
	stloc:int32(var_4_25, ldfld:int32(MemoryChunk::_freeOffset, ldloc:MemoryChunk(var_1_0D)))
	brtrue(IL_0000, ldfld:MemoryChunk[exp:bool](MemoryChunk::_next, ldloc:MemoryChunk(var_1_0D)))
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

		// Token: 0x06001D90 RID: 7568 RVA: 0x0004F740 File Offset: 0x0004D940
		public override void Write(byte[] buffer, int offset, int count)
		{
			ChunkedMemoryStream.MemoryChunk currentChunk = this._currentChunk;
			if (currentChunk != null)
			{
				byte[] buffer2 = currentChunk._buffer;
				int freeOffset = currentChunk._freeOffset;
			}
			this.AppendChunk((long)count);
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			if (!true)
			{
			}
			Task task;
			return task;
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0004F7E0 File Offset: 0x0004D9E0
		private void AppendChunk(long count)
		{
			ChunkedMemoryStream.MemoryChunk currentChunk = this._currentChunk;
			if (currentChunk != null)
			{
				byte[] buffer = currentChunk._buffer;
				return;
			}
			int num = 16;
			long num2 = Math.Min(count, (long)num);
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0004F814 File Offset: 0x0004DA14
		public override bool CanRead
		{
			get
			{
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0004F824 File Offset: 0x0004DA24
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0004F834 File Offset: 0x0004DA34
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x00002050 File Offset: 0x00000250
		public override long Length
		{
			get
			{
				throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0004F844 File Offset: 0x0004DA44
		public override void Flush()
		{
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0004F854 File Offset: 0x0004DA54
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			/*
An exception occurred when decompiling this method (06001D98)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Threading.Tasks.Task System.IO.ChunkedMemoryStream::FlushAsync(System.Threading.CancellationToken)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0003:
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

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0004F868 File Offset: 0x0004DA68
		public override void SetLength(long value)
		{
			while (this._currentChunk != null)
			{
			}
			this.AppendChunk(value);
		}

		// Token: 0x04001400 RID: 5120
		private ChunkedMemoryStream.MemoryChunk _headChunk;

		// Token: 0x04001401 RID: 5121
		private ChunkedMemoryStream.MemoryChunk _currentChunk;

		// Token: 0x04001402 RID: 5122
		private int _totalLength;

		// Token: 0x0200043A RID: 1082
		private sealed class MemoryChunk
		{
			// Token: 0x06001D9E RID: 7582 RVA: 0x0004F884 File Offset: 0x0004DA84
			internal MemoryChunk(int bufferSize)
			{
			}

			// Token: 0x04001403 RID: 5123
			internal readonly byte[] _buffer;

			// Token: 0x04001404 RID: 5124
			internal int _freeOffset;

			// Token: 0x04001405 RID: 5125
			internal ChunkedMemoryStream.MemoryChunk _next;
		}
	}
}
