using System;
using System.Collections;
using System.Text;
using Cpp2IlInjected;

namespace System.Net
{
	// Token: 0x02000263 RID: 611
	internal class MonoChunkParser
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x00034204 File Offset: 0x00032404
		public MonoChunkParser(WebHeaderCollection headers)
		{
			this.headers = headers;
			this.chunkSize = 1;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00034228 File Offset: 0x00032428
		public void WriteAndReadBack(byte[] buffer, int offset, int size, int read)
		{
			this.InternalWrite(buffer, offset, size);
			int num = this.ReadFromChunks(buffer, offset, size);
			read.m_value = num;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00034250 File Offset: 0x00032450
		public int Read(byte[] buffer, int offset, int size)
		{
			return this.ReadFromChunks(buffer, offset, size);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00034268 File Offset: 0x00032468
		private int ReadFromChunks(byte[] buffer, int offset, int size)
		{
			ArrayList arrayList = this.chunks;
			ArrayList arrayList2 = this.chunks;
			if (arrayList2 != null)
			{
			}
			object[] items = arrayList2._items;
			int size2 = arrayList2._size;
			int size3 = arrayList2._size;
			arrayList2._size = size3;
			ArrayList arrayList3 = this.chunks;
			return size;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000342C8 File Offset: 0x000324C8
		public void Write(byte[] buffer, int offset, int size)
		{
			this.InternalWrite(buffer, offset, size);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x000342E0 File Offset: 0x000324E0
		private void InternalWrite(byte[] buffer, int offset, int size)
		{
			MonoChunkParser.State state = this.state;
			MonoChunkParser.State state2 = this.GetChunkSize(buffer, offset, size);
			this.state = state2;
			StringBuilder stringBuilder = this.saved;
			long num = 0L;
			stringBuilder.Length = (int)num;
			MonoChunkParser.State state3 = this.state;
			MonoChunkParser.State state4 = this.ReadBody(buffer, offset, size);
			this.state = state4;
			MonoChunkParser.State state5 = this.ReadCRLF(buffer, offset, size);
			this.state = state5;
			MonoChunkParser.State state6 = this.ReadTrailer(buffer, offset, size);
			this.state = state6;
			StringBuilder stringBuilder2 = this.saved;
			long num2 = 0L;
			stringBuilder2.Length = (int)num2;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x0003436C File Offset: 0x0003256C
		public bool WantMore
		{
			get
			{
				int num = this.chunkSize;
				int num2 = this.totalWritten;
				if (num == 0)
				{
					MonoChunkParser.State state = this.state;
				}
				return true;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00034394 File Offset: 0x00032594
		public bool DataAvailable
		{
			get
			{
				ArrayList arrayList = this.chunks;
				ArrayList arrayList2 = this.chunks;
				if (arrayList2 != null)
				{
					object[] items = arrayList2._items;
					if (items != null && items != null)
					{
						int size = arrayList2._size;
					}
				}
				MonoChunkParser.State state = this.state;
				throw new InvalidCastException();
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x000343DC File Offset: 0x000325DC
		public int TotalDataSize
		{
			get
			{
				return this.totalWritten;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x000343F0 File Offset: 0x000325F0
		public int ChunkLeft
		{
			get
			{
				/*
An exception occurred when decompiling this method (06001082)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.MonoChunkParser::get_ChunkLeft()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(MonoChunkParser::chunkSize, ldloc:MonoChunkParser(this)))
	stloc:int32(var_1_0D, ldfld:int32(MonoChunkParser::totalWritten, ldloc:MonoChunkParser(this)))
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
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0003440C File Offset: 0x0003260C
		private MonoChunkParser.State ReadBody(byte[] buffer, int offset, int size)
		{
			if (this.chunkSize != 0)
			{
				int num = this.chunkRead;
				ArrayList arrayList = this.chunks;
				int num2 = this.chunkSize;
				return;
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00034438 File Offset: 0x00032638
		private MonoChunkParser.State GetChunkSize(byte[] buffer, int offset, int size)
		{
			int num = 1;
			int num2 = 1;
			offset.m_value = num;
			if (!this.sawCR)
			{
				this.sawCR = num2 != 0;
				return "Missing \\n";
			}
			MonoChunkParser.ThrowProtocolViolation("2 CR found");
			MonoChunkParser.ThrowProtocolViolation("Missing \\n");
			return "Missing \\n";
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00034528 File Offset: 0x00032728
		private static string RemoveChunkExtension(string input)
		{
			string text;
			return text;
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0003453C File Offset: 0x0003273C
		private MonoChunkParser.State ReadCRLF(byte[] buffer, int offset, int size)
		{
			/*
An exception occurred when decompiling this method (06001086)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.MonoChunkParser/State System.Net.MonoChunkParser::ReadCRLF(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001C:
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](offset), ldloc:int32(var_1))
	call:void(MonoChunkParser::ThrowProtocolViolation, ldstr:string("Expecting \\r"))
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

		// Token: 0x06001087 RID: 4231 RVA: 0x00034578 File Offset: 0x00032778
		private MonoChunkParser.State ReadTrailer(byte[] buffer, int offset, int size)
		{
			/*
An exception occurred when decompiling this method (06001087)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Net.MonoChunkParser/State System.Net.MonoChunkParser::ReadTrailer(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001A:
	stloc:int32(var_4_20, ldfld:int32(MonoChunkParser::trailerState, ldloc:MonoChunkParser(this)))
	stloc:StringBuilder(var_6_35, call:StringBuilder(StringBuilder::Append, ldfld:StringBuilder(MonoChunkParser::saved, ldloc:MonoChunkParser(this)), ldloc:int64[exp:char](var_2_0F)))
	stloc:int32(var_7_42, callgetter:int32(StringBuilder::get_Length, ldfld:StringBuilder(MonoChunkParser::saved, ldloc:MonoChunkParser(this))))
	call:void(MonoChunkParser::ThrowProtocolViolation, ldstr:string("Error reading trailer (too long)."))
	stloc:StringBuilder(var_9_57, ldfld:StringBuilder(MonoChunkParser::saved, ldloc:MonoChunkParser(this)))
	stloc:WebHeaderCollection(var_11_5F, ldfld:WebHeaderCollection(MonoChunkParser::headers, ldloc:MonoChunkParser(this)))
	call:void(MonoChunkParser::ThrowProtocolViolation, ldstr:string("Error reading trailer."))
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

		// Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
		private static void ThrowProtocolViolation(string message)
		{
			throw new global::Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x04000CF5 RID: 3317
		private WebHeaderCollection headers;

		// Token: 0x04000CF6 RID: 3318
		private int chunkSize;

		// Token: 0x04000CF7 RID: 3319
		private int chunkRead;

		// Token: 0x04000CF8 RID: 3320
		private int totalWritten;

		// Token: 0x04000CF9 RID: 3321
		private MonoChunkParser.State state;

		// Token: 0x04000CFA RID: 3322
		private StringBuilder saved;

		// Token: 0x04000CFB RID: 3323
		private bool sawCR;

		// Token: 0x04000CFC RID: 3324
		private bool gotit;

		// Token: 0x04000CFD RID: 3325
		private int trailerState;

		// Token: 0x04000CFE RID: 3326
		private ArrayList chunks;

		// Token: 0x02000264 RID: 612
		private enum State
		{
			// Token: 0x04000D00 RID: 3328
			None,
			// Token: 0x04000D01 RID: 3329
			PartialSize,
			// Token: 0x04000D02 RID: 3330
			Body,
			// Token: 0x04000D03 RID: 3331
			BodyFinished,
			// Token: 0x04000D04 RID: 3332
			Trailer
		}

		// Token: 0x02000265 RID: 613
		private class Chunk
		{
			// Token: 0x06001089 RID: 4233 RVA: 0x000345F8 File Offset: 0x000327F8
			public Chunk(byte[] chunk)
			{
				this.Bytes = chunk;
			}

			// Token: 0x0600108A RID: 4234 RVA: 0x00034614 File Offset: 0x00032814
			public int Read(byte[] buffer, int offset, int size)
			{
				/*
An exception occurred when decompiling this method (0600108A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Net.MonoChunkParser/Chunk::Read(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_06, ldfld:uint8[](Chunk::Bytes, ldloc:Chunk(this)))
	stloc:int32(var_1_0D, ldfld:int32(Chunk::Offset, ldloc:Chunk(this)))
	stloc:int32(var_2_14, ldfld:int32(Chunk::Offset, ldloc:Chunk(this)))
	stfld:int32(Chunk::Offset, ldloc:Chunk(this), ldloc:int32(var_2_14))
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

			// Token: 0x04000D05 RID: 3333
			public byte[] Bytes;

			// Token: 0x04000D06 RID: 3334
			public int Offset;
		}
	}
}
