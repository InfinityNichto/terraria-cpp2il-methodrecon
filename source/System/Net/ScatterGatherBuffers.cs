using System;

namespace System.Net
{
	// Token: 0x020001FB RID: 507
	internal class ScatterGatherBuffers
	{
		// Token: 0x06000C74 RID: 3188 RVA: 0x00027BD0 File Offset: 0x00025DD0
		internal ScatterGatherBuffers()
		{
			this.nextChunkLength = 1024;
			base..ctor();
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00027BF0 File Offset: 0x00025DF0
		internal ScatterGatherBuffers(long totalSize)
		{
			long num = 0L;
			base..ctor();
			ScatterGatherBuffers.MemoryChunk memoryChunk = this.AllocateMemoryChunk((int)num);
			this.currentChunk = memoryChunk;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00027C14 File Offset: 0x00025E14
		internal BufferOffsetSize[] GetBuffers()
		{
			while (this.headChunk != null)
			{
				ScatterGatherBuffers.MemoryChunk memoryChunk = this.headChunk;
				if (memoryChunk == null)
				{
					IL_002A:
					throw new ArrayTypeMismatchException();
				}
				byte[] buffer = memoryChunk.Buffer;
				int freeOffset = memoryChunk.FreeOffset;
				if (memoryChunk.Next == null)
				{
					break;
				}
			}
			goto IL_002A;
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00027C50 File Offset: 0x00025E50
		private bool Empty
		{
			get
			{
				if (this.headChunk != null)
				{
					int num = this.chunkCount;
				}
				return true;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00027C70 File Offset: 0x00025E70
		internal int Length
		{
			get
			{
				return this.totalLength;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00027C84 File Offset: 0x00025E84
		internal void Write(byte[] buffer, int offset, int count)
		{
			if (this.headChunk != null && this.chunkCount != 0)
			{
				ScatterGatherBuffers.MemoryChunk memoryChunk = this.currentChunk;
				byte[] buffer2 = memoryChunk.Buffer;
				int freeOffset = memoryChunk.FreeOffset;
			}
			ScatterGatherBuffers.MemoryChunk memoryChunk2 = this.AllocateMemoryChunk(count);
			ScatterGatherBuffers.MemoryChunk memoryChunk3 = this.currentChunk;
			if (memoryChunk3 != null)
			{
				memoryChunk3.Next = memoryChunk2;
			}
			this.currentChunk = memoryChunk2;
			int freeOffset2 = memoryChunk2.FreeOffset;
			byte[] buffer3 = memoryChunk2.Buffer;
			int num = this.totalLength;
			ScatterGatherBuffers.MemoryChunk memoryChunk4 = this.currentChunk;
			this.totalLength = num;
			int freeOffset3 = memoryChunk4.FreeOffset;
			memoryChunk4.FreeOffset = freeOffset3;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00027D18 File Offset: 0x00025F18
		private ScatterGatherBuffers.MemoryChunk AllocateMemoryChunk(int newSize)
		{
			/*
An exception occurred when decompiling this method (06000C7A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.ScatterGatherBuffers/MemoryChunk System.Net.ScatterGatherBuffers::AllocateMemoryChunk(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0022:
	stloc:int32(var_3_28, ldfld:int32(ScatterGatherBuffers::nextChunkLength, ldloc:ScatterGatherBuffers(this)))
	stfld:int32(ScatterGatherBuffers::chunkCount, ldloc:ScatterGatherBuffers(this), ldloc:int32(var_2_1B))
	stfld:int32(ScatterGatherBuffers::nextChunkLength, ldloc:ScatterGatherBuffers(this), ldloc:int32(var_3_28))
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

		// Token: 0x04000AB0 RID: 2736
		private ScatterGatherBuffers.MemoryChunk headChunk;

		// Token: 0x04000AB1 RID: 2737
		private ScatterGatherBuffers.MemoryChunk currentChunk;

		// Token: 0x04000AB2 RID: 2738
		private int nextChunkLength;

		// Token: 0x04000AB3 RID: 2739
		private int totalLength;

		// Token: 0x04000AB4 RID: 2740
		private int chunkCount;

		// Token: 0x020001FC RID: 508
		private class MemoryChunk
		{
			// Token: 0x06000C7B RID: 3195 RVA: 0x00027D5C File Offset: 0x00025F5C
			internal MemoryChunk(int bufferSize)
			{
			}

			// Token: 0x04000AB5 RID: 2741
			internal byte[] Buffer;

			// Token: 0x04000AB6 RID: 2742
			internal int FreeOffset;

			// Token: 0x04000AB7 RID: 2743
			internal ScatterGatherBuffers.MemoryChunk Next;
		}
	}
}
