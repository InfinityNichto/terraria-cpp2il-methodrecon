using System;

namespace Ionic.Zlib
{
	// Token: 0x02000045 RID: 69
	internal sealed class InflateBlocks
	{
		// Token: 0x0600037A RID: 890 RVA: 0x0000CA84 File Offset: 0x0000AC84
		internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
		{
			this._codec = codec;
			this.end = w;
			this.checkfn = checkfn;
			uint num = this.Reset();
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		internal uint Reset()
		{
			uint num = this.check;
			if (this.checkfn != null)
			{
				ZlibCodec codec = this._codec;
				this.check = 1U;
				codec._Adler32 = 1U;
			}
			return num;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
		internal int Process(int r)
		{
			ZlibCodec codec = this._codec;
			int num = this.readAt;
			int num2 = this.bitk;
			int[] array = this.hufts;
			int nextIn = codec.NextIn;
			long totalBytesIn = codec.TotalBytesIn;
			return "invalid stored block lengths";
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000D244 File Offset: 0x0000B444
		internal void Free()
		{
			uint num = this.Reset();
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000D258 File Offset: 0x0000B458
		internal void SetDictionary(byte[] d, int start, int n)
		{
			byte[] array = this.window;
			long num = 0L;
			Array.Copy(d, start, array, (int)num, n);
			this.readAt = n;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000D280 File Offset: 0x0000B480
		internal int SyncPoint()
		{
			/*
An exception occurred when decompiling this method (0600037F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.Zlib.InflateBlocks::SyncPoint()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:InflateBlockMode(var_0_06, ldfld:InflateBlockMode(InflateBlocks::mode, ldloc:InflateBlocks(this)))
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

		// Token: 0x06000380 RID: 896 RVA: 0x0000D294 File Offset: 0x0000B494
		internal int Flush(int r)
		{
			long num = 0L;
			if (num != 0L)
			{
				int num2 = this.readAt;
			}
			int num3 = this.readAt;
			int num4 = 112;
			if (num4 != 0)
			{
				ZlibCodec codec = this._codec;
				int availableBytesOut = codec.AvailableBytesOut;
				long totalBytesOut = codec.TotalBytesOut;
				codec.AvailableBytesOut = num4;
				codec.TotalBytesOut = (long)availableBytesOut;
				object obj = this.checkfn;
				ZlibCodec codec2;
				if (obj != null)
				{
					uint num5 = this.check;
					byte[] array = this.window;
					if (obj == null)
					{
					}
					uint num6;
					this.check = num6;
					codec._Adler32 = num6;
					int num7 = this.readAt;
					codec2 = this._codec;
				}
				byte[] array2 = this.window;
				byte[] outputBuffer = codec2.OutputBuffer;
				int nextOut = codec2.NextOut;
				ZlibCodec codec3 = this._codec;
				int nextOut2 = codec3.NextOut;
				codec3.NextOut = nextOut2;
				int num8 = this.readAt;
				this.readAt = nextOut2;
				if (num == 0L)
				{
					int num9 = this.end;
					int num10 = this.writeAt;
				}
				return r;
			}
			return r;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000D38C File Offset: 0x0000B58C
		// Note: this type is marked as 'beforefieldinit'.
		static InflateBlocks()
		{
		}

		// Token: 0x04000239 RID: 569
		private const int MANY = 1440;

		// Token: 0x0400023A RID: 570
		internal static readonly int[] border;

		// Token: 0x0400023B RID: 571
		private InflateBlocks.InflateBlockMode mode;

		// Token: 0x0400023C RID: 572
		internal int left;

		// Token: 0x0400023D RID: 573
		internal int table;

		// Token: 0x0400023E RID: 574
		internal int index;

		// Token: 0x0400023F RID: 575
		internal int[] blens;

		// Token: 0x04000240 RID: 576
		internal int[] bb;

		// Token: 0x04000241 RID: 577
		internal int[] tb;

		// Token: 0x04000242 RID: 578
		internal InflateCodes codes;

		// Token: 0x04000243 RID: 579
		internal int last;

		// Token: 0x04000244 RID: 580
		internal ZlibCodec _codec;

		// Token: 0x04000245 RID: 581
		internal int bitk;

		// Token: 0x04000246 RID: 582
		internal int bitb;

		// Token: 0x04000247 RID: 583
		internal int[] hufts;

		// Token: 0x04000248 RID: 584
		internal byte[] window;

		// Token: 0x04000249 RID: 585
		internal int end;

		// Token: 0x0400024A RID: 586
		internal int readAt;

		// Token: 0x0400024B RID: 587
		internal int writeAt;

		// Token: 0x0400024C RID: 588
		internal object checkfn;

		// Token: 0x0400024D RID: 589
		internal uint check;

		// Token: 0x0400024E RID: 590
		internal InfTree inftree;

		// Token: 0x02000046 RID: 70
		private enum InflateBlockMode
		{
			// Token: 0x04000250 RID: 592
			TYPE,
			// Token: 0x04000251 RID: 593
			LENS,
			// Token: 0x04000252 RID: 594
			STORED,
			// Token: 0x04000253 RID: 595
			TABLE,
			// Token: 0x04000254 RID: 596
			BTREE,
			// Token: 0x04000255 RID: 597
			DTREE,
			// Token: 0x04000256 RID: 598
			CODES,
			// Token: 0x04000257 RID: 599
			DRY,
			// Token: 0x04000258 RID: 600
			DONE,
			// Token: 0x04000259 RID: 601
			BAD
		}
	}
}
