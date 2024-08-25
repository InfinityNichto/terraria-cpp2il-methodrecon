using System;
using System.IO;
using Cpp2IlInjected;
using Ionic.Crc;

namespace Ionic.BZip2
{
	// Token: 0x02000037 RID: 55
	public class BZip2InputStream : Stream
	{
		// Token: 0x060002CC RID: 716 RVA: 0x00009F14 File Offset: 0x00008114
		public BZip2InputStream(Stream input)
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00009F24 File Offset: 0x00008124
		public BZip2InputStream(Stream input, bool leaveOpen)
		{
			this.input = input;
			this.init();
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00009F44 File Offset: 0x00008144
		public override int Read(byte[] buffer, int offset, int count)
		{
			while (this.input == null)
			{
			}
			return "offset ({0}) must be > 0";
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009F60 File Offset: 0x00008160
		private void MakeMaps()
		{
			BZip2InputStream.DecompressionState decompressionState = this.data;
			long num = 0L;
			bool[] inUse = decompressionState.inUse;
			byte[] seqToUnseq = decompressionState.seqToUnseq;
			this.nInUse = (int)num;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00009F90 File Offset: 0x00008190
		public override int ReadByte()
		{
			long num = this.totalBytesRead;
			int num2 = this.currentChar;
			uint num3 = this.storedBlockCRC;
			this.totalBytesRead = num;
			this.SetupRandPartB();
			this.SetupRandPartC();
			this.SetupNoRandPartC();
			this.SetupNoRandPartB();
			return num2;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00009FD4 File Offset: 0x000081D4
		public override bool CanRead
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002D1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.BZip2.BZip2InputStream::get_CanRead()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_0E, ldfld:Stream(BZip2InputStream::input, ldloc:BZip2InputStream(this)))
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00009FF0 File Offset: 0x000081F0
		public override bool CanSeek
		{
			get
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000A000 File Offset: 0x00008200
		public override bool CanWrite
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002D3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.BZip2.BZip2InputStream::get_CanWrite()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:Stream(var_0_0E, ldfld:Stream(BZip2InputStream::input, ldloc:BZip2InputStream(this)))
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

		// Token: 0x060002D4 RID: 724 RVA: 0x0000A01C File Offset: 0x0000821C
		public override void Flush()
		{
			while (this._disposed)
			{
			}
			Stream stream = this.input;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002122 File Offset: 0x00000322
		public override long Length
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000A038 File Offset: 0x00008238
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00002122 File Offset: 0x00000322
		public override long Position
		{
			get
			{
				return this.totalBytesRead;
			}
			set
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002122 File Offset: 0x00000322
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002122 File Offset: 0x00000322
		public override void SetLength(long value)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002122 File Offset: 0x00000322
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000A04C File Offset: 0x0000824C
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed)
			{
				if (this.input != null)
				{
				}
				this._disposed = true;
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000A098 File Offset: 0x00008298
		private void init()
		{
			if (this.input != null)
			{
				int num = 66;
				long num2 = 0L;
				this.CheckMagicChar((char)num, (int)num2);
				int num3 = 90;
				int num4 = 1;
				this.CheckMagicChar((char)num3, num4);
				int num5 = 104;
				int num6 = 2;
				this.CheckMagicChar((char)num5, num6);
				Stream stream = this.input;
				this.InitBlock();
				this.SetupBlock();
				return;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000A0F0 File Offset: 0x000082F0
		private void CheckMagicChar(char expected, int position)
		{
			Stream stream = this.input;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000A114 File Offset: 0x00008314
		private void InitBlock()
		{
			int bits = this.GetBits(8);
			int bits2 = this.GetBits(8);
			int bits3 = this.GetBits(8);
			int bits4 = this.GetBits(8);
			int bits5 = this.GetBits(8);
			int bits6 = this.GetBits(8);
			this.complete();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000A1A4 File Offset: 0x000083A4
		private void EndBlock()
		{
			int crc32Result = this.crc.Crc32Result;
			uint num = this.storedBlockCRC;
			this.computedBlockCRC = (uint)crc32Result;
			uint num2 = this.computedCombinedCRC;
			this.computedCombinedCRC = num2;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000A1E0 File Offset: 0x000083E0
		private void complete()
		{
			uint num = this.bsGetInt();
			uint num2 = this.computedCombinedCRC;
			this.storedCombinedCRC = num;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000A20C File Offset: 0x0000840C
		public override void Close()
		{
			if (this.input == null || !this._leaveOpen)
			{
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000A238 File Offset: 0x00008438
		private int GetBits(int n)
		{
			/*
An exception occurred when decompiling this method (060002E2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.BZip2.BZip2InputStream::GetBits(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(BZip2InputStream::bsBuff, ldloc:BZip2InputStream(this)))
	stloc:CRC32(var_1_0D, ldfld:CRC32(BZip2InputStream::crc, ldloc:BZip2InputStream(this)))
	stloc:Stream(var_2_14, ldfld:Stream(BZip2InputStream::input, ldloc:BZip2InputStream(this)))
	stfld:int32(BZip2InputStream::bsBuff, ldloc:BZip2InputStream(this), ldloc:int32(var_0_06))
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

		// Token: 0x060002E3 RID: 739 RVA: 0x0000A260 File Offset: 0x00008460
		private bool bsGetBit()
		{
			/*
An exception occurred when decompiling this method (060002E3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.BZip2.BZip2InputStream::bsGetBit()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(BZip2InputStream::GetBits, ldloc:BZip2InputStream(this), ldc.i4:int32(1)))
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

		// Token: 0x060002E4 RID: 740 RVA: 0x0000A274 File Offset: 0x00008474
		private char bsGetUByte()
		{
			/*
An exception occurred when decompiling this method (060002E4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Char Ionic.BZip2.BZip2InputStream::bsGetUByte()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(BZip2InputStream::GetBits, ldloc:BZip2InputStream(this), ldc.i4:int32(8)))
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

		// Token: 0x060002E5 RID: 741 RVA: 0x0000A288 File Offset: 0x00008488
		private uint bsGetInt()
		{
			/*
An exception occurred when decompiling this method (060002E5)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 Ionic.BZip2.BZip2InputStream::bsGetInt()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_07, call:int32(BZip2InputStream::GetBits, ldloc:BZip2InputStream(this), ldc.i4:int32(8)))
	stloc:int32(var_1_0F, call:int32(BZip2InputStream::GetBits, ldloc:BZip2InputStream(this), ldc.i4:int32(8)))
	stloc:int32(var_2_17, call:int32(BZip2InputStream::GetBits, ldloc:BZip2InputStream(this), ldc.i4:int32(8)))
	stloc:int32(var_3_1F, call:int32(BZip2InputStream::GetBits, ldloc:BZip2InputStream(this), ldc.i4:int32(8)))
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

		// Token: 0x060002E6 RID: 742 RVA: 0x0000A2B4 File Offset: 0x000084B4
		private static void hbCreateDecodeTables(int[] limit, int[] bbase, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
			if (alphaSize == 0)
			{
			}
			if (alphaSize == 0)
			{
			}
			bbase.m_value = alphaSize;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000A2D8 File Offset: 0x000084D8
		private void recvDecodingTables()
		{
			BZip2InputStream.DecompressionState decompressionState;
			long num5;
			byte[] seqToUnseq;
			int bits2;
			int num8;
			do
			{
				decompressionState = this.data;
				long num = 0L;
				bool[] inUse = decompressionState.inUse;
				byte[] recvDecodingTables_pos = decompressionState.recvDecodingTables_pos;
				int num2 = 1;
				int bits = this.GetBits(num2);
				int num3 = 1;
				int num4 = 1;
				if (this.GetBits(num4) != 0)
				{
					num.m_value = (long)num3;
				}
				BZip2InputStream.DecompressionState decompressionState2 = this.data;
				num5 = 0L;
				bool[] inUse2 = decompressionState2.inUse;
				seqToUnseq = decompressionState2.seqToUnseq;
				int num6 = 3;
				this.nInUse = (int)num5;
				bits2 = this.GetBits(num6);
				int num7 = 15;
				int bits3 = this.GetBits(num7);
				num8 = 1;
			}
			while (this.GetBits(num8) != 0);
			byte[] selectorMtf = decompressionState.selectorMtf;
			seqToUnseq.m_value = selectorMtf;
			byte[] selectorMtf2 = decompressionState.selectorMtf;
			byte[] selector = decompressionState.selector;
			char[][] temp_charArray2d = decompressionState.temp_charArray2d;
			int num9 = 5;
			int bits4 = this.GetBits(num9);
			int num10 = 1;
			if (this.GetBits(num10) != 0)
			{
				int num11 = 1;
				int bits5 = this.GetBits(num11);
				return;
			}
			this.createHuffmanDecodingTables((int)num5, bits2);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000A3E0 File Offset: 0x000085E0
		private void createHuffmanDecodingTables(int alphaSize, int nGroups)
		{
			BZip2InputStream.DecompressionState decompressionState = this.data;
			char[][] temp_charArray2d = decompressionState.temp_charArray2d;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000A428 File Offset: 0x00008628
		private void getAndMoveToFrontDecode()
		{
			int num = 1;
			BZip2InputStream.DecompressionState decompressionState = this.data;
			int num2 = 24;
			int bits = this.GetBits(num2);
			this.origPtr = bits;
			if (num == 0)
			{
			}
			int num3 = this.blockSize100k;
			this.recvDecodingTables();
			byte[] getAndMoveToFrontDecode_yy = decompressionState.getAndMoveToFrontDecode_yy;
			int num4 = this.blockSize100k;
			long num5 = 0L;
			int[] unzftab = decompressionState.unzftab;
			if (num5 == 0L)
			{
			}
			int num6 = this.nInUse;
			long num7 = 0L;
			int andMoveToFrontDecode = this.getAndMoveToFrontDecode0((int)num7);
			int num8 = this.bsBuff;
			CRC32 crc = this.crc;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000A564 File Offset: 0x00008764
		private int getAndMoveToFrontDecode0(int groupNo)
		{
			/*
An exception occurred when decompiling this method (060002EA)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.BZip2.BZip2InputStream::getAndMoveToFrontDecode0(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:DecompressionState(var_0_06, ldfld:DecompressionState(BZip2InputStream::data, ldloc:BZip2InputStream(this)))
	stloc:uint8[](var_1_0D, ldfld:uint8[](DecompressionState::selector, ldloc:DecompressionState(var_0_06)))
	stloc:int32[][](var_2_14, ldfld:int32[][](DecompressionState::gLimit, ldloc:DecompressionState(var_0_06)))
	stloc:int32[](var_3_1B, ldfld:int32[](DecompressionState::gMinlen, ldloc:DecompressionState(var_0_06)))
	stloc:int32(var_4_23, call:int32(BZip2InputStream::GetBits, ldloc:BZip2InputStream(this), ldloc:int32(groupNo)))
	stloc:int32(var_5_2B, ldfld:int32(BZip2InputStream::bsBuff, ldloc:BZip2InputStream(this)))
	stloc:CRC32(var_6_33, ldfld:CRC32(BZip2InputStream::crc, ldloc:BZip2InputStream(this)))
	stloc:Stream(var_7_3B, ldfld:Stream(BZip2InputStream::input, ldloc:BZip2InputStream(this)))
	stfld:int32(BZip2InputStream::bsBuff, ldloc:BZip2InputStream(this), ldloc:int32(var_5_2B))
	stfld:CRC32(BZip2InputStream::crc, ldloc:BZip2InputStream(this), ldloc:CRC32(var_6_33))
	stloc:int32[][](var_8_53, ldfld:int32[][](DecompressionState::gBase, ldloc:DecompressionState(var_0_06)))
	stloc:int32[][](var_9_5B, ldfld:int32[][](DecompressionState::gPerm, ldloc:DecompressionState(var_0_06)))
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

		// Token: 0x060002EB RID: 747 RVA: 0x0000A5D0 File Offset: 0x000087D0
		private void SetupBlock()
		{
			BZip2InputStream.DecompressionState decompressionState = this.data;
			if (decompressionState == null)
			{
				return;
			}
			int num = this.last;
			int[] unzftab = decompressionState.unzftab;
			int num2 = this.last;
			int[] cftab = decompressionState.cftab;
			long num3 = 0L;
			num2.m_value = (int)num3;
			int num4 = this.last;
			byte[] ll = decompressionState.ll8;
			bool flag = this.blockRandomised;
			this.su_tPos = cftab;
			if (flag)
			{
				this.SetupRandPartA();
				return;
			}
			this.SetupNoRandPartA();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000A65C File Offset: 0x0000885C
		private void SetupRandPartA()
		{
			int num = this.su_i2;
			int num2 = this.last;
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000A70C File Offset: 0x0000890C
		private void SetupNoRandPartA()
		{
			int num = this.su_i2;
			int num2 = this.last;
			int num3 = 5;
			this.currentState = (BZip2InputStream.CState)num3;
			this.EndBlock();
			this.InitBlock();
			this.SetupBlock();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000A790 File Offset: 0x00008990
		private void SetupRandPartB()
		{
			int num = this.su_ch2;
			int num2 = this.su_i2;
			int num3 = this.su_count;
			this.su_count = num3;
			int num4 = 2;
			this.currentState = (BZip2InputStream.CState)num4;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000A860 File Offset: 0x00008A60
		private void SetupRandPartC()
		{
			int num = this.su_j2;
			char c = this.su_z;
			int num2 = this.su_ch2;
			CRC32 crc = this.crc;
			this.currentChar = num2;
			crc.UpdateCRC((byte)num2);
			int num3 = this.su_j2;
			this.su_j2 = num3;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000A8CC File Offset: 0x00008ACC
		private void SetupNoRandPartB()
		{
			int num = this.su_ch2;
			int num2 = this.su_i2;
			int num3 = this.su_count;
			this.su_count = num3;
			this.SetupNoRandPartA();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000A93C File Offset: 0x00008B3C
		private void SetupNoRandPartC()
		{
			int num = this.su_j2;
			char c = this.su_z;
			int num2 = this.su_ch2;
			CRC32 crc = this.crc;
			this.currentChar = num2;
			crc.UpdateCRC((byte)num2);
			int num3 = this.su_j2;
			int num4 = 7;
			this.currentState = (BZip2InputStream.CState)num4;
			this.su_j2 = num3;
		}

		// Token: 0x04000184 RID: 388
		private bool _disposed;

		// Token: 0x04000185 RID: 389
		private bool _leaveOpen;

		// Token: 0x04000186 RID: 390
		private long totalBytesRead;

		// Token: 0x04000187 RID: 391
		private int last;

		// Token: 0x04000188 RID: 392
		private int origPtr;

		// Token: 0x04000189 RID: 393
		private int blockSize100k;

		// Token: 0x0400018A RID: 394
		private bool blockRandomised;

		// Token: 0x0400018B RID: 395
		private int bsBuff;

		// Token: 0x0400018C RID: 396
		private int bsLive;

		// Token: 0x0400018D RID: 397
		private readonly CRC32 crc;

		// Token: 0x0400018E RID: 398
		private int nInUse;

		// Token: 0x0400018F RID: 399
		private Stream input;

		// Token: 0x04000190 RID: 400
		private int currentChar;

		// Token: 0x04000191 RID: 401
		private BZip2InputStream.CState currentState;

		// Token: 0x04000192 RID: 402
		private uint storedBlockCRC;

		// Token: 0x04000193 RID: 403
		private uint storedCombinedCRC;

		// Token: 0x04000194 RID: 404
		private uint computedBlockCRC;

		// Token: 0x04000195 RID: 405
		private uint computedCombinedCRC;

		// Token: 0x04000196 RID: 406
		private int su_count;

		// Token: 0x04000197 RID: 407
		private int su_ch2;

		// Token: 0x04000198 RID: 408
		private int su_chPrev;

		// Token: 0x04000199 RID: 409
		private int su_i2;

		// Token: 0x0400019A RID: 410
		private int su_j2;

		// Token: 0x0400019B RID: 411
		private int su_rNToGo;

		// Token: 0x0400019C RID: 412
		private int su_rTPos;

		// Token: 0x0400019D RID: 413
		private int su_tPos;

		// Token: 0x0400019E RID: 414
		private char su_z;

		// Token: 0x0400019F RID: 415
		private BZip2InputStream.DecompressionState data;

		// Token: 0x02000038 RID: 56
		private enum CState
		{
			// Token: 0x040001A1 RID: 417
			EOF,
			// Token: 0x040001A2 RID: 418
			START_BLOCK,
			// Token: 0x040001A3 RID: 419
			RAND_PART_A,
			// Token: 0x040001A4 RID: 420
			RAND_PART_B,
			// Token: 0x040001A5 RID: 421
			RAND_PART_C,
			// Token: 0x040001A6 RID: 422
			NO_RAND_PART_A,
			// Token: 0x040001A7 RID: 423
			NO_RAND_PART_B,
			// Token: 0x040001A8 RID: 424
			NO_RAND_PART_C
		}

		// Token: 0x02000039 RID: 57
		private sealed class DecompressionState
		{
			// Token: 0x060002F2 RID: 754 RVA: 0x0000A9A8 File Offset: 0x00008BA8
			public DecompressionState(int blockSize100k)
			{
				if (!true)
				{
				}
				base..ctor();
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0000A9C0 File Offset: 0x00008BC0
			public int[] initTT(int length)
			{
				/*
An exception occurred when decompiling this method (060002F3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32[] Ionic.BZip2.BZip2InputStream/DecompressionState::initTT(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:int32[][exp:bool](DecompressionState::tt, ldloc:DecompressionState(this))))
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

			// Token: 0x040001A9 RID: 425
			public readonly bool[] inUse;

			// Token: 0x040001AA RID: 426
			public readonly byte[] seqToUnseq;

			// Token: 0x040001AB RID: 427
			public readonly byte[] selector;

			// Token: 0x040001AC RID: 428
			public readonly byte[] selectorMtf;

			// Token: 0x040001AD RID: 429
			public readonly int[] unzftab;

			// Token: 0x040001AE RID: 430
			public readonly int[][] gLimit;

			// Token: 0x040001AF RID: 431
			public readonly int[][] gBase;

			// Token: 0x040001B0 RID: 432
			public readonly int[][] gPerm;

			// Token: 0x040001B1 RID: 433
			public readonly int[] gMinlen;

			// Token: 0x040001B2 RID: 434
			public readonly int[] cftab;

			// Token: 0x040001B3 RID: 435
			public readonly byte[] getAndMoveToFrontDecode_yy;

			// Token: 0x040001B4 RID: 436
			public readonly char[][] temp_charArray2d;

			// Token: 0x040001B5 RID: 437
			public readonly byte[] recvDecodingTables_pos;

			// Token: 0x040001B6 RID: 438
			public int[] tt;

			// Token: 0x040001B7 RID: 439
			public byte[] ll8;
		}
	}
}
