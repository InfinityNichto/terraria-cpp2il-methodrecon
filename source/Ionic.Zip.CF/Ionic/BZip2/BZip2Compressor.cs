using System;
using Cpp2IlInjected;
using Ionic.Crc;

namespace Ionic.BZip2
{
	// Token: 0x02000035 RID: 53
	internal class BZip2Compressor
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x000094B8 File Offset: 0x000076B8
		public BZip2Compressor(BitWriter writer)
		{
			if (!true)
			{
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000094C8 File Offset: 0x000076C8
		public BZip2Compressor(BitWriter writer, int blockSize)
		{
			int num = 1;
			base..ctor();
			this.blockSize100k = blockSize;
			this.bw = writer;
			if (num == 0)
			{
			}
			this.crc.Reset();
			bool[] inUse = this.cstate.inUse;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00009508 File Offset: 0x00007708
		private void Reset()
		{
			this.crc.Reset();
			bool[] inUse = this.cstate.inUse;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000952C File Offset: 0x0000772C
		public int BlockSize
		{
			get
			{
				return this.blockSize100k;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00009540 File Offset: 0x00007740
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00009554 File Offset: 0x00007754
		public uint Crc32
		{
			get
			{
				return this.<Crc32>k__BackingField;
			}
			private set
			{
				this.<Crc32>k__BackingField = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00009568 File Offset: 0x00007768
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x0000957C File Offset: 0x0000777C
		public int AvailableBytesOut
		{
			get
			{
				return this.<AvailableBytesOut>k__BackingField;
			}
			private set
			{
				this.<AvailableBytesOut>k__BackingField = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00009590 File Offset: 0x00007790
		public int UncompressedBytes
		{
			get
			{
				/*
An exception occurred when decompiling this method (060002B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.BZip2.BZip2Compressor::get_UncompressedBytes()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(BZip2Compressor::last, ldloc:BZip2Compressor(this)))
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

		// Token: 0x060002B2 RID: 690 RVA: 0x000095A4 File Offset: 0x000077A4
		public int Fill(byte[] buffer, int offset, int count)
		{
			int num = this.last;
			return this.write0(buffer);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000095C4 File Offset: 0x000077C4
		private int write0(byte b)
		{
			int num = this.currentByte;
			int num2 = this.runLength;
			this.runLength = num2;
			long num3 = 0L;
			bool flag = this.AddRunToOutputBlock(num3 != 0L);
			int num4 = this.runLength;
			this.last = num4;
			long num5 = 0L;
			bool flag2 = this.AddRunToOutputBlock(num5 != 0L);
			int num6 = 1;
			this.last = num6;
			return num6;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000961C File Offset: 0x0000781C
		private bool AddRunToOutputBlock(bool final)
		{
			/*
An exception occurred when decompiling this method (060002B4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean Ionic.BZip2.BZip2Compressor::AddRunToOutputBlock(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(BZip2Compressor::runs, ldloc:BZip2Compressor(this)))
	stloc:int32(var_1_0D, ldfld:int32(BZip2Compressor::last, ldloc:BZip2Compressor(this)))
	stfld:int32(BZip2Compressor::runs, ldloc:BZip2Compressor(this), ldloc:int32(var_0_06))
	stloc:CompressionState(var_2_1B, ldfld:CompressionState(BZip2Compressor::cstate, ldloc:BZip2Compressor(this)))
	stloc:int32(var_3_22, ldfld:int32(BZip2Compressor::currentByte, ldloc:BZip2Compressor(this)))
	stloc:int32(var_4_24, ldc.i4:int32(1))
	stloc:bool[](var_5_2C, ldfld:bool[](CompressionState::inUse, ldloc:CompressionState(var_2_1B)))
	stloc:uint8[](var_6_34, ldfld:uint8[](CompressionState::block, ldloc:CompressionState(var_2_1B)))
	stfld:int32[](CompressionState::mtfFreq, ldloc:CompressionState(var_2_1B), ldloc:int32[exp:int32[]](var_4_24))
	stloc:int32(var_7_44, ldfld:int32(BZip2Compressor::runLength, ldloc:BZip2Compressor(this)))
	call:void(CRC32::UpdateCRC, ldfld:CRC32(BZip2Compressor::crc, ldloc:BZip2Compressor(this)), ldloc:int32[exp:uint8](var_3_22), ldloc:int32(var_7_44))
	stfld:int32[](CompressionState::mtfFreq, ldloc:CompressionState(var_2_1B), ldloc:int32[exp:int32[]](var_3_22))
	stfld:bool(bool::m_value, ldloc:bool[][exp:bool&](var_5_2C), ldloc:int32[exp:bool](var_3_22))
	stfld:bool(bool::m_value, ldloc:bool[][exp:bool&](var_5_2C), ldloc:int32[exp:bool](var_3_22))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_4_24), ldloc:int32(var_3_22))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_4_24), ldloc:int32(var_3_22))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_4_24), ldloc:int32(var_3_22))
	stloc:CompressionState(var_8_89, ldfld:CompressionState(BZip2Compressor::cstate, ldloc:BZip2Compressor(this)))
	stloc:int32(var_9_8C, ldc.i4:int32(1))
	stloc:bool[](var_10_95, ldfld:bool[](CompressionState::inUse, ldloc:CompressionState(var_8_89)))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_9_8C), ldloc:int32(var_3_22))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_9_8C), ldloc:int32(var_3_22))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_9_8C), ldloc:int32(var_3_22))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_9_8C), ldloc:int32(var_3_22))
	stfld:int32(int32::m_value, ldloc:int32[exp:int32&](var_9_8C), ldloc:bool[][exp:int32](var_5_2C))
	stloc:int32(var_11_C6, ldfld:int32(BZip2Compressor::outBlockFillThreshold, ldloc:BZip2Compressor(this)))
	stfld:int32(BZip2Compressor::last, ldloc:BZip2Compressor(this), ldloc:bool[][exp:int32](var_10_95))
	stloc:int32(var_12_D6, ldfld:int32(BZip2Compressor::outBlockFillThreshold, ldloc:BZip2Compressor(this)))
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

		// Token: 0x060002B5 RID: 693 RVA: 0x00009700 File Offset: 0x00007900
		public void CompressAndWrite()
		{
			int num = this.runLength;
			int num2 = 1;
			bool flag = this.AddRunToOutputBlock(num2 != 0);
			int num3 = this.last;
			this.blockSort();
			BitWriter bitWriter = this.bw;
			int num4 = 8;
			int num5 = 49;
			bitWriter.WriteBits(num4, (uint)num5);
			BitWriter bitWriter2 = this.bw;
			int num6 = 8;
			int num7 = 65;
			bitWriter2.WriteBits(num6, (uint)num7);
			BitWriter bitWriter3 = this.bw;
			int num8 = 8;
			int num9 = 89;
			bitWriter3.WriteBits(num8, (uint)num9);
			BitWriter bitWriter4 = this.bw;
			int num10 = 8;
			int num11 = 38;
			bitWriter4.WriteBits(num10, (uint)num11);
			BitWriter bitWriter5 = this.bw;
			int num12 = 8;
			int num13 = 83;
			bitWriter5.WriteBits(num12, (uint)num13);
			BitWriter bitWriter6 = this.bw;
			int num14 = 8;
			int num15 = 89;
			bitWriter6.WriteBits(num14, (uint)num15);
			int crc32Result = this.crc.Crc32Result;
			BitWriter bitWriter7 = this.bw;
			this.<Crc32>k__BackingField = (uint)crc32Result;
			bitWriter7.WriteInt((uint)crc32Result);
			BitWriter bitWriter8 = this.bw;
			bool flag2 = this.blockRandomised;
			int num16 = 1;
			bitWriter8.WriteBits(num16, flag2 ? 1U : 0U);
			this.moveToFrontCodeAndSend();
			this.crc.Reset();
			bool[] inUse = this.cstate.inUse;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000982C File Offset: 0x00007A2C
		private void randomiseBlock()
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			int num = this.last;
			bool[] inUse = compressionState.inUse;
			byte[] block = compressionState.block;
			long num2 = 0L;
			long num3 = 0L;
			if (num2 == 0L)
			{
				if (num2 == 0L)
				{
				}
				int num4 = Rand.Rnums((int)num3);
			}
			int num5 = 1;
			this.blockRandomised = num5 != 0;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000987C File Offset: 0x00007A7C
		private void mainSort()
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			int num = this.last;
			char[] quadrant = compressionState.quadrant;
			int[] mainSort_runningOrder = compressionState.mainSort_runningOrder;
			int[] mainSort_copy = compressionState.mainSort_copy;
			int[] ftab = compressionState.ftab;
			byte[] block = compressionState.block;
			bool[] mainSort_bigDone = compressionState.mainSort_bigDone;
			int num2 = this.workLimit;
			int[] fmap = compressionState.fmap;
			bool flag = this.firstAttempt;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00009944 File Offset: 0x00007B44
		private void blockSort()
		{
			int num = 1;
			if (num == 0)
			{
			}
			int num2 = this.last;
			int num3 = 1;
			this.workLimit = num;
			this.firstAttempt = num3 != 0;
			this.mainSort();
			if (this.firstAttempt)
			{
				int num4 = this.workDone;
				bool flag = this.firstAttempt;
				this.randomiseBlock();
				this.mainSort();
			}
			BZip2Compressor.CompressionState compressionState = this.cstate;
			int num5 = this.last;
			int[] fmap = compressionState.fmap;
			this.origPtr = num3;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000099C4 File Offset: 0x00007BC4
		private bool mainSimpleSort(BZip2Compressor.CompressionState dataShadow, int lo, int hi, int d)
		{
			for (;;)
			{
				if (!true)
				{
				}
				bool flag = this.firstAttempt;
				int num = this.workDone;
				bool flag2 = this.firstAttempt;
				int num2 = this.last;
				byte[] block = dataShadow.block;
				char[] quadrant = dataShadow.quadrant;
				if (!flag2)
				{
				}
				if (true)
				{
					return;
				}
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00009A14 File Offset: 0x00007C14
		private static void vswap(int[] fmap, int p1, int p2, int n)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00009A24 File Offset: 0x00007C24
		private static byte med3(byte a, byte b, byte c)
		{
			return a;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00009A34 File Offset: 0x00007C34
		private void mainQSort3(BZip2Compressor.CompressionState dataShadow, int loSt, int hiSt, int dSt)
		{
			long num = 0L;
			int num2 = 1;
			if (num == 0L)
			{
			}
			if (num2 == 0)
			{
			}
			if (num2 == 0)
			{
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00009A58 File Offset: 0x00007C58
		private void generateMTFValues()
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			int num = this.last;
			long num2 = 0L;
			bool[] inUse = compressionState.inUse;
			byte[] unseqToSeq = compressionState.unseqToSeq;
			byte[] block = compressionState.block;
			int[] fmap = compressionState.fmap;
			char[] sfmap = compressionState.sfmap;
			int[] mtfFreq = compressionState.mtfFreq;
			byte[] generateMTFValues_yy = compressionState.generateMTFValues_yy;
			this.nInUse = (int)num2;
			int[] mtfFreq2 = compressionState.mtfFreq;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00009ACC File Offset: 0x00007CCC
		private static void hbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00009ADC File Offset: 0x00007CDC
		private void sendMTFValues()
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			int num = this.nInUse;
			byte[][] sendMTFValues_len = compressionState.sendMTFValues_len;
			if (compressionState == null)
			{
			}
			if (compressionState.unseqToSeq == null)
			{
			}
			int num2 = this.nMTF;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00009B70 File Offset: 0x00007D70
		private void sendMTFValues0(int nGroups, int alphaSize)
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			int num = this.nMTF;
			byte[][] sendMTFValues_len = compressionState.sendMTFValues_len;
			int[] mtfFreq = compressionState.mtfFreq;
			long num2 = 0L;
			int[] mtfFreq2 = compressionState.mtfFreq;
			if (num2 == 0L)
			{
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00009BB0 File Offset: 0x00007DB0
		private static void hbMakeCodeLengths(byte[] len, int[] freq, BZip2Compressor.CompressionState state1, int alphaSize, int maxLen)
		{
			int[] heap = state1.heap;
			int[] weight = state1.weight;
			int[] parent = state1.parent;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00009BF0 File Offset: 0x00007DF0
		private int sendMTFValues1(int nGroups, int alphaSize)
		{
			/*
An exception occurred when decompiling this method (060002C2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Ionic.BZip2.BZip2Compressor::sendMTFValues1(System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0055:
	stloc:int32(var_12_5D, call:int32(Math::Min, ldc.i4:int32(0), ldloc:int64[exp:int32](var_9_44)))
	stloc:int32(var_15_6F, ldfld:int32(BZip2Compressor::nMTF, ldloc:BZip2Compressor(this)))
	stloc:CompressionState(var_16_77, ldfld:CompressionState(BZip2Compressor::cstate, ldloc:BZip2Compressor(this)))
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

		// Token: 0x060002C3 RID: 707 RVA: 0x00009C78 File Offset: 0x00007E78
		private void sendMTFValues2(int nGroups, int nSelectors)
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			byte[] sendMTFValues2_pos = compressionState.sendMTFValues2_pos;
			byte[] selector = compressionState.selector;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009CA8 File Offset: 0x00007EA8
		private void sendMTFValues3(int nGroups, int alphaSize)
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			int[][] sendMTFValues_code = compressionState.sendMTFValues_code;
			byte[][] sendMTFValues_len = compressionState.sendMTFValues_len;
			int[] mtfFreq = compressionState.mtfFreq;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009CF8 File Offset: 0x00007EF8
		private void sendMTFValues4()
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			bool[] inUse = compressionState.inUse;
			bool[] sentMTFValues4_inUse = compressionState.sentMTFValues4_inUse16;
			long num = 0L;
			BitWriter bitWriter = this.bw;
			int num2 = 16;
			bitWriter.WriteBits(num2, (uint)num);
			if (compressionState.mtfFreq != null)
			{
				long num3 = 0L;
				BitWriter bitWriter2 = this.bw;
				int num4 = 16;
				bitWriter2.WriteBits(num4, (uint)num3);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009D5C File Offset: 0x00007F5C
		private void sendMTFValues5(int nGroups, int nSelectors)
		{
			BitWriter bitWriter = this.bw;
			int num = 3;
			bitWriter.WriteBits(num, (uint)nGroups);
			BitWriter bitWriter2 = this.bw;
			int num2 = 15;
			bitWriter2.WriteBits(num2, (uint)nSelectors);
			BZip2Compressor.CompressionState compressionState = this.cstate;
			byte[] selectorMtf = compressionState.selectorMtf;
			int[] mtfFreq = compressionState.mtfFreq;
			BitWriter bitWriter3 = this.bw;
			BitWriter bitWriter4;
			if (mtfFreq != null)
			{
				int num3 = 1;
				int num4 = 1;
				bitWriter3.WriteBits(num3, (uint)num4);
				bitWriter4 = this.bw;
			}
			int num5 = 1;
			long num6 = 0L;
			bitWriter4.WriteBits(num5, (uint)num6);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00009DE0 File Offset: 0x00007FE0
		private void sendMTFValues6(int nGroups, int alphaSize)
		{
			BZip2Compressor.CompressionState compressionState = this.cstate;
			byte[][] sendMTFValues_len = compressionState.sendMTFValues_len;
			int[] mtfFreq = compressionState.mtfFreq;
			BitWriter bitWriter = this.bw;
			int num = 5;
			bitWriter.WriteBits(num, (uint)alphaSize);
			int[] mtfFreq2 = compressionState.mtfFreq;
			BitWriter bitWriter2 = this.bw;
			int num2 = 2;
			int num3 = 2;
			bitWriter2.WriteBits(num2, (uint)num3);
			BitWriter bitWriter3 = this.bw;
			int num4 = 2;
			int num5 = 3;
			bitWriter3.WriteBits(num4, (uint)num5);
			BitWriter bitWriter4 = this.bw;
			int num6 = 1;
			long num7 = 0L;
			bitWriter4.WriteBits(num6, (uint)num7);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00009E70 File Offset: 0x00008070
		private void sendMTFValues7(int nSelectors)
		{
			int num = this.nMTF;
			BZip2Compressor.CompressionState compressionState = this.cstate;
			byte[][] sendMTFValues_len = compressionState.sendMTFValues_len;
			byte[] selector = compressionState.selector;
			char[] sfmap = compressionState.sfmap;
			int[][] sendMTFValues_code = compressionState.sendMTFValues_code;
			if (compressionState == null)
			{
			}
			long num2 = 0L;
			int num3 = Math.Min(0, 43151360);
			this.bw.WriteBits(43151360, (uint)num2);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00009ED4 File Offset: 0x000080D4
		private void moveToFrontCodeAndSend()
		{
			BitWriter bitWriter = this.bw;
			int num = this.origPtr;
			bitWriter.WriteBits(24, (uint)num);
			this.generateMTFValues();
			this.sendMTFValues();
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00009F04 File Offset: 0x00008104
		// Note: this type is marked as 'beforefieldinit'.
		static BZip2Compressor()
		{
		}

		// Token: 0x0400014F RID: 335
		private int blockSize100k;

		// Token: 0x04000150 RID: 336
		private int currentByte;

		// Token: 0x04000151 RID: 337
		private int runLength;

		// Token: 0x04000152 RID: 338
		private int last;

		// Token: 0x04000153 RID: 339
		private int outBlockFillThreshold;

		// Token: 0x04000154 RID: 340
		private BZip2Compressor.CompressionState cstate;

		// Token: 0x04000155 RID: 341
		private readonly CRC32 crc;

		// Token: 0x04000156 RID: 342
		private BitWriter bw;

		// Token: 0x04000157 RID: 343
		private int runs;

		// Token: 0x04000158 RID: 344
		private int workDone;

		// Token: 0x04000159 RID: 345
		private int workLimit;

		// Token: 0x0400015A RID: 346
		private bool firstAttempt;

		// Token: 0x0400015B RID: 347
		private bool blockRandomised;

		// Token: 0x0400015C RID: 348
		private int origPtr;

		// Token: 0x0400015D RID: 349
		private int nInUse;

		// Token: 0x0400015E RID: 350
		private int nMTF;

		// Token: 0x0400015F RID: 351
		private static readonly int SETMASK;

		// Token: 0x04000160 RID: 352
		private static readonly int CLEARMASK;

		// Token: 0x04000161 RID: 353
		private static readonly byte GREATER_ICOST;

		// Token: 0x04000162 RID: 354
		private static readonly byte LESSER_ICOST;

		// Token: 0x04000163 RID: 355
		private static readonly int SMALL_THRESH;

		// Token: 0x04000164 RID: 356
		private static readonly int DEPTH_THRESH;

		// Token: 0x04000165 RID: 357
		private static readonly int WORK_FACTOR;

		// Token: 0x04000166 RID: 358
		private static readonly int[] increments;

		// Token: 0x04000167 RID: 359
		private uint <Crc32>k__BackingField;

		// Token: 0x04000168 RID: 360
		private int <AvailableBytesOut>k__BackingField;

		// Token: 0x02000036 RID: 54
		private class CompressionState
		{
			// Token: 0x060002CB RID: 715 RVA: 0x00002122 File Offset: 0x00000322
			public CompressionState(int blockSize100k)
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}

			// Token: 0x04000169 RID: 361
			public readonly bool[] inUse;

			// Token: 0x0400016A RID: 362
			public readonly byte[] unseqToSeq;

			// Token: 0x0400016B RID: 363
			public readonly int[] mtfFreq;

			// Token: 0x0400016C RID: 364
			public readonly byte[] selector;

			// Token: 0x0400016D RID: 365
			public readonly byte[] selectorMtf;

			// Token: 0x0400016E RID: 366
			public readonly byte[] generateMTFValues_yy;

			// Token: 0x0400016F RID: 367
			public byte[][] sendMTFValues_len;

			// Token: 0x04000170 RID: 368
			public int[][] sendMTFValues_rfreq;

			// Token: 0x04000171 RID: 369
			public readonly int[] sendMTFValues_fave;

			// Token: 0x04000172 RID: 370
			public readonly short[] sendMTFValues_cost;

			// Token: 0x04000173 RID: 371
			public int[][] sendMTFValues_code;

			// Token: 0x04000174 RID: 372
			public readonly byte[] sendMTFValues2_pos;

			// Token: 0x04000175 RID: 373
			public readonly bool[] sentMTFValues4_inUse16;

			// Token: 0x04000176 RID: 374
			public readonly int[] stack_ll;

			// Token: 0x04000177 RID: 375
			public readonly int[] stack_hh;

			// Token: 0x04000178 RID: 376
			public readonly int[] stack_dd;

			// Token: 0x04000179 RID: 377
			public readonly int[] mainSort_runningOrder;

			// Token: 0x0400017A RID: 378
			public readonly int[] mainSort_copy;

			// Token: 0x0400017B RID: 379
			public readonly bool[] mainSort_bigDone;

			// Token: 0x0400017C RID: 380
			public int[] heap;

			// Token: 0x0400017D RID: 381
			public int[] weight;

			// Token: 0x0400017E RID: 382
			public int[] parent;

			// Token: 0x0400017F RID: 383
			public readonly int[] ftab;

			// Token: 0x04000180 RID: 384
			public byte[] block;

			// Token: 0x04000181 RID: 385
			public int[] fmap;

			// Token: 0x04000182 RID: 386
			public char[] sfmap;

			// Token: 0x04000183 RID: 387
			public char[] quadrant;
		}
	}
}
