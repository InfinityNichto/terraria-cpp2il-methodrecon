using System;

namespace System.Security.Cryptography
{
	// Token: 0x02000318 RID: 792
	internal class SHA1Internal
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x0003A048 File Offset: 0x00038248
		public SHA1Internal()
		{
			uint[] h = this._H;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0003A064 File Offset: 0x00038264
		public void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			int processingBufferCount = this._ProcessingBufferCount;
			if (processingBufferCount != 0)
			{
				byte[] processingBuffer = this._ProcessingBuffer;
				Buffer.BlockCopy(rgb, ibStart, processingBuffer, processingBufferCount, cbSize);
				int processingBufferCount2 = this._ProcessingBufferCount;
				return;
			}
			long num;
			this.ProcessBlock(rgb, (uint)num);
			if (cbSize != 0)
			{
				byte[] processingBuffer2 = this._ProcessingBuffer;
				this._ProcessingBufferCount = cbSize;
			}
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0003A0D0 File Offset: 0x000382D0
		public byte[] HashFinal()
		{
			/*
An exception occurred when decompiling this method (06001AE2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.SHA1Internal::HashFinal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_1_09, ldfld:uint8[](SHA1Internal::_ProcessingBuffer, ldloc:SHA1Internal(this)))
	stloc:int32(var_2_10, ldfld:int32(SHA1Internal::_ProcessingBufferCount, ldloc:SHA1Internal(this)))
	stloc:int64(var_3_12, ldc.i4:int64(0))
	call:void(SHA1Internal::ProcessFinalBlock, ldloc:SHA1Internal(this), ldloc:uint8[](var_1_09), ldloc:int64[exp:int32](var_3_12), ldloc:int32(var_2_10))
	stloc:uint32[](var_5_25, ldfld:uint32[](SHA1Internal::_H, ldloc:SHA1Internal(this)))
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

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0003A104 File Offset: 0x00038304
		public void Initialize()
		{
			uint[] h = this._H;
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0003A118 File Offset: 0x00038318
		private void ProcessBlock(byte[] inputBuffer, uint inputOffset)
		{
			uint[] h = this._H;
			ulong num = this.count;
			uint[] array = this.buff;
			this.count = num;
			SHA1Internal.InitialiseBuff(array, inputBuffer, inputOffset);
			SHA1Internal.FillBuff(array);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0003A15C File Offset: 0x0003835C
		private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset)
		{
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0003A16C File Offset: 0x0003836C
		private static void FillBuff(uint[] buff)
		{
			uint value = buff.m_value;
			uint value2 = buff.m_value;
			uint value3 = buff.m_value;
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0003A194 File Offset: 0x00038394
		private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			ulong num = this.count;
			byte[] processingBuffer = this._ProcessingBuffer;
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0003A1B8 File Offset: 0x000383B8
		internal void AddLength(ulong length, byte[] buffer, int position)
		{
		}

		// Token: 0x04000DAE RID: 3502
		private const int BLOCK_SIZE_BYTES = 64;

		// Token: 0x04000DAF RID: 3503
		private uint[] _H;

		// Token: 0x04000DB0 RID: 3504
		private ulong count;

		// Token: 0x04000DB1 RID: 3505
		private byte[] _ProcessingBuffer;

		// Token: 0x04000DB2 RID: 3506
		private int _ProcessingBufferCount;

		// Token: 0x04000DB3 RID: 3507
		private uint[] buff;
	}
}
