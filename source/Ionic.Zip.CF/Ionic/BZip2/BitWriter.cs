using System;
using System.IO;

namespace Ionic.BZip2
{
	// Token: 0x02000034 RID: 52
	internal class BitWriter
	{
		// Token: 0x0600029F RID: 671 RVA: 0x00009398 File Offset: 0x00007598
		public BitWriter(Stream s)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000093AC File Offset: 0x000075AC
		public byte RemainingBits
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002A0)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte Ionic.BZip2.BitWriter::get_RemainingBits()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint32(var_0_06, ldfld:uint32(BitWriter::accumulator, ldloc:BitWriter(this)))
	stloc:Stream(var_1_0D, ldfld:Stream(BitWriter::output, ldloc:BitWriter(this)))
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000093C8 File Offset: 0x000075C8
		public int NumRemainingBits
		{
			get
			{
				return this.nAccumulatedBits;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000093DC File Offset: 0x000075DC
		public int TotalBytesWrittenOut
		{
			get
			{
				return this.totalBytesWrittenOut;
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000093F0 File Offset: 0x000075F0
		public void Reset()
		{
			Stream stream = this.output;
			Stream stream2 = this.output;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000940C File Offset: 0x0000760C
		public void WriteBits(int nbits, uint value)
		{
			uint num = this.accumulator;
			Stream stream = this.output;
			Stream stream2 = this.output;
			int num2 = this.totalBytesWrittenOut;
			this.totalBytesWrittenOut = num2;
			this.output = num2;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00009444 File Offset: 0x00007644
		public void WriteByte(byte b)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009454 File Offset: 0x00007654
		public void WriteInt(uint u)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009464 File Offset: 0x00007664
		public void Flush()
		{
			long num = 0L;
			long num2 = 0L;
			this.WriteBits((int)num, (uint)num2);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00009480 File Offset: 0x00007680
		public void FinishAndPad()
		{
			long num = 0L;
			long num2 = 0L;
			this.WriteBits((int)num, (uint)num2);
			int num3 = this.nAccumulatedBits;
			Stream stream = this.output;
			int num4 = this.totalBytesWrittenOut;
			this.totalBytesWrittenOut = num4;
		}

		// Token: 0x0400014B RID: 331
		private uint accumulator;

		// Token: 0x0400014C RID: 332
		private int nAccumulatedBits;

		// Token: 0x0400014D RID: 333
		private Stream output;

		// Token: 0x0400014E RID: 334
		private int totalBytesWrittenOut;
	}
}
