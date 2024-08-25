using System;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x02000313 RID: 787
	[ComVisible(true)]
	public sealed class MD5CryptoServiceProvider : MD5
	{
		// Token: 0x06001ABA RID: 6842 RVA: 0x000399E0 File Offset: 0x00037BE0
		public MD5CryptoServiceProvider()
		{
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x000399F4 File Offset: 0x00037BF4
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00039A28 File Offset: 0x00037C28
		protected override void Dispose(bool disposing)
		{
			if (this._ProcessingBuffer != null)
			{
			}
			if (this._H != null)
			{
			}
			long num;
			if (this.buff != null)
			{
				num = 0L;
			}
			base.Dispose(num != 0L);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x00039A58 File Offset: 0x00037C58
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
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
			this.ProcessBlock(rgb, (int)num);
			if (cbSize != 0)
			{
				byte[] processingBuffer2 = this._ProcessingBuffer;
				this._ProcessingBufferCount = cbSize;
			}
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00039AC4 File Offset: 0x00037CC4
		protected override byte[] HashFinal()
		{
			/*
An exception occurred when decompiling this method (06001ABE)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.MD5CryptoServiceProvider::HashFinal()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_1_09, ldfld:uint8[](MD5CryptoServiceProvider::_ProcessingBuffer, ldloc:MD5CryptoServiceProvider(this)))
	stloc:int32(var_2_10, ldfld:int32(MD5CryptoServiceProvider::_ProcessingBufferCount, ldloc:MD5CryptoServiceProvider(this)))
	stloc:int64(var_3_12, ldc.i4:int64(0))
	call:void(MD5CryptoServiceProvider::ProcessFinalBlock, ldloc:MD5CryptoServiceProvider(this), ldloc:uint8[](var_1_09), ldloc:int64[exp:int32](var_3_12), ldloc:int32(var_2_10))
	stloc:uint32[](var_6_28, ldfld:uint32[](MD5CryptoServiceProvider::_H, ldloc:MD5CryptoServiceProvider(this)))
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

		// Token: 0x06001ABF RID: 6847 RVA: 0x00039AFC File Offset: 0x00037CFC
		public override void Initialize()
		{
			uint[] h = this._H;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x00039B10 File Offset: 0x00037D10
		private void ProcessBlock(byte[] inputBuffer, int inputOffset)
		{
			uint[] array = this.buff;
			ulong num = this.count;
			this.count = num;
			int num2 = 32;
			uint[] h = this._H;
			if (num2 == 0)
			{
				uint[] array2 = this.buff;
			}
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00039B48 File Offset: 0x00037D48
		private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			ulong num = this.count;
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00039B68 File Offset: 0x00037D68
		internal void AddLength(ulong length, byte[] buffer, int position)
		{
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00039B78 File Offset: 0x00037D78
		// Note: this type is marked as 'beforefieldinit'.
		static MD5CryptoServiceProvider()
		{
		}

		// Token: 0x04000D9A RID: 3482
		private const int BLOCK_SIZE_BYTES = 64;

		// Token: 0x04000D9B RID: 3483
		private uint[] _H;

		// Token: 0x04000D9C RID: 3484
		private uint[] buff;

		// Token: 0x04000D9D RID: 3485
		private ulong count;

		// Token: 0x04000D9E RID: 3486
		private byte[] _ProcessingBuffer;

		// Token: 0x04000D9F RID: 3487
		private int _ProcessingBufferCount;

		// Token: 0x04000DA0 RID: 3488
		private static readonly uint[] K;
	}
}
