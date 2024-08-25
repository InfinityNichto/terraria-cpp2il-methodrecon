using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004C RID: 76
	internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
	{
		// Token: 0x0600018E RID: 398 RVA: 0x000061B8 File Offset: 0x000043B8
		public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV)
		{
			this.algo = symmAlgo;
			this.BlockSizeByte = symmAlgo;
			if (rgbIV != null)
			{
				object obj;
				if (obj != null)
				{
					if (obj == null)
					{
						throw new InvalidCastException();
					}
				}
				int blockSizeByte = this.BlockSizeByte;
				SymmetricAlgorithm symmetricAlgorithm = this.algo;
				this.padmode = symmetricAlgorithm;
				int blockSizeByte2 = this.BlockSizeByte;
				int num = Math.Min(this.BlockSizeByte, blockSizeByte2);
				int blockSizeByte3 = this.BlockSizeByte;
				SymmetricAlgorithm symmetricAlgorithm2 = this.algo;
				this.FeedBackByte = symmetricAlgorithm2;
				int blockSizeByte4 = this.BlockSizeByte;
				int blockSizeByte5 = this.BlockSizeByte;
				return;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006258 File Offset: 0x00004458
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000628C File Offset: 0x0000448C
		void IDisposable.Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000062A0 File Offset: 0x000044A0
		protected virtual void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				byte[] array = this.temp;
				int blockSizeByte = this.BlockSizeByte;
				long num = 0L;
				Array.Clear(array, (int)num, blockSizeByte);
				byte[] array2 = this.temp2;
				int blockSizeByte2 = this.BlockSizeByte;
				long num2 = 0L;
				Array.Clear(array2, (int)num2, blockSizeByte2);
				this.m_disposed = true;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000062F0 File Offset: 0x000044F0
		public virtual bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00006300 File Offset: 0x00004500
		public virtual bool CanReuseTransform
		{
			get
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00006310 File Offset: 0x00004510
		public virtual int InputBlockSize
		{
			get
			{
				return this.BlockSizeByte;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00006324 File Offset: 0x00004524
		public virtual int OutputBlockSize
		{
			get
			{
				return this.BlockSizeByte;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006338 File Offset: 0x00004538
		protected virtual void Transform(byte[] input, byte[] output)
		{
			SymmetricAlgorithm symmetricAlgorithm = this.algo;
		}

		// Token: 0x06000197 RID: 407
		protected abstract void ECB(byte[] input, byte[] output);

		// Token: 0x06000198 RID: 408 RVA: 0x00006364 File Offset: 0x00004564
		protected virtual void CBC(byte[] input, byte[] output)
		{
			if (this.encrypt)
			{
				int blockSizeByte = this.BlockSizeByte;
				byte[] array = this.temp;
				byte[] array2 = this.temp;
				byte[] array3 = this.temp;
				int blockSizeByte2 = this.BlockSizeByte;
				return;
			}
			byte[] array4 = this.temp2;
			int blockSizeByte3 = this.BlockSizeByte;
			long num = 0L;
			long num2 = 0L;
			Buffer.BlockCopy(input, (int)num, array4, (int)num2, blockSizeByte3);
			int blockSizeByte4 = this.BlockSizeByte;
			byte[] array5 = this.temp;
			output.m_value = array5;
			byte[] array6 = this.temp;
			byte[] array7 = this.temp2;
			long num3 = 0L;
			long num4 = 0L;
			Buffer.BlockCopy(array7, (int)num3, array6, (int)num4, blockSizeByte4);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006400 File Offset: 0x00004600
		protected virtual void CFB(byte[] input, byte[] output)
		{
			int blockSizeByte = this.BlockSizeByte;
			int num3;
			if (this.encrypt)
			{
				long num = 0L;
				byte[] array = this.temp;
				byte[] array2 = this.temp2;
				byte[] array3 = this.temp2;
				long num2 = 0L;
				int blockSizeByte2 = this.BlockSizeByte;
				byte[] array4 = this.temp;
				int blockSizeByte3 = this.BlockSizeByte;
				byte[] array5 = this.temp;
				num3 = 1;
				Buffer.BlockCopy(output, (int)num, array5, (int)num2, num3);
				return;
			}
			long num4 = 0L;
			int num5 = 1;
			this.encrypt = num5 != 0;
			byte[] array6 = this.temp;
			byte[] array7 = this.temp2;
			int blockSizeByte4 = this.BlockSizeByte;
			byte[] array8 = this.temp;
			int num6 = 1;
			long num7 = 0L;
			Buffer.BlockCopy(array8, num6, array8, (int)num7, num3);
			int blockSizeByte5 = this.BlockSizeByte;
			byte[] array9 = this.temp;
			int num8 = 1;
			Buffer.BlockCopy(input, (int)num4, array9, (int)num7, num8);
			byte[] array10 = this.temp2;
			output.m_value = array10;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000207A File Offset: 0x0000027A
		protected virtual void OFB(byte[] input, byte[] output)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000207A File Offset: 0x0000027A
		protected virtual void CTS(byte[] input, byte[] output)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000064DC File Offset: 0x000046DC
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputBuffer != null)
			{
				return;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000064FC File Offset: 0x000046FC
		public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			for (;;)
			{
				if (!this.m_disposed)
				{
					this.CheckInput(inputBuffer, inputOffset, inputCount);
					if (outputBuffer != null && !this.encrypt)
					{
						break;
					}
				}
			}
			if (this.padmode == (PaddingMode)0)
			{
				PaddingMode paddingMode = this.padmode;
			}
			int blockSizeByte = this.BlockSizeByte;
			int blockSizeByte2 = this.BlockSizeByte;
			return this.InternalTransformBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000655C File Offset: 0x0000475C
		private bool KeepLastBlock
		{
			get
			{
				while (!this.encrypt)
				{
				}
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00006574 File Offset: 0x00004774
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			/*
An exception occurred when decompiling this method (0600019F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Security.Cryptography.SymmetricTransform::InternalTransformBlock(System.Byte[],System.Int32,System.Int32,System.Byte[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_2:
	stloc:PaddingMode(var_18_BF, ldfld:PaddingMode(SymmetricTransform::padmode, ldloc:SymmetricTransform(this)))
	stloc:uint8[](var_19_C7, ldfld:uint8[](SymmetricTransform::workBuff, ldloc:SymmetricTransform(this)))
	stloc:int64(var_20_CA, ldc.i4:int64(0))
	call:void(Buffer::BlockCopy, ldloc:uint8[][exp:Array](inputBuffer), ldloc:int32(inputOffset), ldloc:uint8[][exp:Array](var_19_C7), ldloc:int64[exp:int32](var_20_CA), ldloc:int32(var_17_AC))
	stloc:int32(var_21_DA, ldc.i4:int32(1))
	stfld:bool(SymmetricTransform::lastBlock, ldloc:SymmetricTransform(this), ldloc:int32[exp:bool](var_21_DA))
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

		// Token: 0x060001A0 RID: 416 RVA: 0x00006664 File Offset: 0x00004864
		private void Random(byte[] buffer, int start, int length)
		{
			if (this._rng == null)
			{
				RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
				this._rng = randomNumberGenerator;
			}
			RandomNumberGenerator rng = this._rng;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00006690 File Offset: 0x00004890
		private void ThrowBadPaddingException(PaddingMode padding, int length, int position)
		{
			/*
An exception occurred when decompiling this method (060001A1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Mono.Security.Cryptography.SymmetricTransform::ThrowBadPaddingException(System.Security.Cryptography.PaddingMode,System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Locale::GetText, ldstr:string("Bad {0} padding.")))
	stloc:string(var_3_17, call:string(Locale::GetText, ldstr:string(" Invalid length {0}.")))
	stloc:string(var_6_23, call:string(string::Concat, ldloc:string(var_2), ldloc:string(var_5)))
	stloc:string(var_7_2F, call:string(Locale::GetText, ldstr:string(" Error found at position {0}.")))
	stloc:string(var_10_3D, call:string(string::Concat, ldloc:string(var_6_23), ldloc:string(var_9)))
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

		// Token: 0x060001A2 RID: 418 RVA: 0x000066DC File Offset: 0x000048DC
		protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			int blockSizeByte = this.BlockSizeByte;
			PaddingMode paddingMode = this.padmode;
			int blockSizeByte2 = this.BlockSizeByte;
			int blockSizeByte3 = this.BlockSizeByte;
			PaddingMode paddingMode2 = this.padmode;
			return inputBuffer;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006720 File Offset: 0x00004920
		protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (this.lastBlock)
			{
				int blockSizeByte = this.BlockSizeByte;
			}
			int blockSizeByte2 = this.BlockSizeByte;
			int blockSizeByte3 = this.BlockSizeByte;
			byte[] array3;
			if (this.lastBlock)
			{
				byte[] array = this.workBuff;
				byte[] array2 = this.workout;
				array3 = this.workout;
				int blockSizeByte4 = this.BlockSizeByte;
			}
			return array3;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000067AC File Offset: 0x000049AC
		public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			/*
An exception occurred when decompiling this method (060001A4)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Cryptography.SymmetricTransform::TransformFinalBlock(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	call:void(SymmetricTransform::CheckInput, ldloc:SymmetricTransform(this), ldloc:uint8[](inputBuffer), ldloc:int32(inputOffset), ldloc:int32(inputCount))
	brtrue(IL_0000, logicnot:bool(ldfld:bool(SymmetricTransform::encrypt, ldloc:SymmetricTransform(this))))
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

		// Token: 0x04000164 RID: 356
		protected SymmetricAlgorithm algo;

		// Token: 0x04000165 RID: 357
		protected bool encrypt;

		// Token: 0x04000166 RID: 358
		protected int BlockSizeByte;

		// Token: 0x04000167 RID: 359
		protected byte[] temp;

		// Token: 0x04000168 RID: 360
		protected byte[] temp2;

		// Token: 0x04000169 RID: 361
		private byte[] workBuff;

		// Token: 0x0400016A RID: 362
		private byte[] workout;

		// Token: 0x0400016B RID: 363
		protected PaddingMode padmode;

		// Token: 0x0400016C RID: 364
		protected int FeedBackByte;

		// Token: 0x0400016D RID: 365
		private bool m_disposed;

		// Token: 0x0400016E RID: 366
		protected bool lastBlock;

		// Token: 0x0400016F RID: 367
		private RandomNumberGenerator _rng;
	}
}
