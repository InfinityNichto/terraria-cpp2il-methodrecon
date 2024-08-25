using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x020002EF RID: 751
	[ComVisible(true)]
	public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable
	{
		// Token: 0x06001928 RID: 6440 RVA: 0x00035E0C File Offset: 0x0003400C
		internal RijndaelManagedTransform(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode)
		{
			int num = 1;
			long num2 = 0L;
			base..ctor();
			if (rgbKey != null)
			{
				this.m_transformMode = transformMode;
				this.m_blockSizeBytes = blockSize;
				this.m_cipherMode = mode;
				this.m_transformMode = (RijndaelManagedTransformMode)PaddingValue;
				this.m_Nb = (int)num2;
				this.m_Nk = num;
				int nb = this.m_Nb;
				int nb2 = this.m_Nb;
				int nb3 = this.m_Nb;
				int nb4 = this.m_Nb;
				int nb5 = this.m_Nb;
				int nb6 = this.m_Nb;
				int nb7 = this.m_Nb;
				int nb8 = this.m_Nb;
				int nb9 = this.m_Nb;
				int nb10 = this.m_Nb;
				int nb11 = this.m_Nb;
				int nb12 = this.m_Nb;
				int nb13 = this.m_Nb;
				int[] encryptindex = this.m_encryptindex;
				int nb14 = this.m_Nb;
				int[] encryptindex2 = this.m_encryptindex;
				int nb15 = this.m_Nb;
				int nb16 = this.m_Nb;
				int nb17 = this.m_Nb;
				int[] decryptindex = this.m_decryptindex;
				int nb18 = this.m_Nb;
				int[] decryptindex2 = this.m_decryptindex;
				CipherMode cipherMode = this.m_cipherMode;
				return;
			}
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00035F88 File Offset: 0x00034188
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00035F9C File Offset: 0x0003419C
		public void Clear()
		{
			this.Dispose(true);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00035FB0 File Offset: 0x000341B0
		private void Dispose(bool disposing)
		{
			if (this.m_IV != null)
			{
			}
			if (this.m_lastBlockBuffer != null)
			{
			}
			if (this.m_encryptKeyExpansion != null)
			{
			}
			if (this.m_decryptKeyExpansion != null)
			{
			}
			if (this.m_depadBuffer != null)
			{
			}
			if (this.m_shiftRegister != null)
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x00035FF0 File Offset: 0x000341F0
		public int BlockSizeValue
		{
			get
			{
				return this.m_blockSizeBits;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00036004 File Offset: 0x00034204
		public int InputBlockSize
		{
			get
			{
				return this.m_inputBlockSize;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00036018 File Offset: 0x00034218
		public int OutputBlockSize
		{
			get
			{
				return this.m_outputBlockSize;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x0003602C File Offset: 0x0003422C
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0003603C File Offset: 0x0003423C
		public bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0003604C File Offset: 0x0003424C
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			/*
An exception occurred when decompiling this method (06001931)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.RijndaelManagedTransform::TransformBlock(System.Byte[],System.Int32,System.Int32,System.Byte[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00B6:
	stloc:string(var_18_C0, call:string(Environment::GetResourceString, ldstr:string("Non-negative number required.")))
	stloc:string(var_19_CC, call:string(Environment::GetResourceString, ldstr:string("Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.")))
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

		// Token: 0x06001932 RID: 6450 RVA: 0x00036128 File Offset: 0x00034328
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			/*
An exception occurred when decompiling this method (06001932)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.RijndaelManagedTransform::TransformFinalBlock(System.Byte[],System.Int32,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0061:
	stloc:string(var_12_6B, call:string(Environment::GetResourceString, ldstr:string("Length of the data to decrypt is invalid.")))
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

		// Token: 0x06001933 RID: 6451 RVA: 0x000361A4 File Offset: 0x000343A4
		public void Reset()
		{
			CipherMode cipherMode = this.m_cipherMode;
			int[] iv = this.m_IV;
			int[] lastBlockBuffer = this.m_lastBlockBuffer;
			int blockSizeBytes = this.m_blockSizeBytes;
			long num = 0L;
			long num2 = 0L;
			bool flag = Buffer.InternalBlockCopy(iv, (int)num, lastBlockBuffer, (int)num2, blockSizeBytes);
			CipherMode cipherMode2 = this.m_cipherMode;
			int nb = this.m_Nb;
			int[] iv2 = this.m_IV;
			byte[] shiftRegister = this.m_shiftRegister;
			long num3 = 0L;
			long num4 = 0L;
			bool flag2 = Buffer.InternalBlockCopy(iv2, (int)num3, shiftRegister, (int)num4, blockSizeBytes);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00036218 File Offset: 0x00034418
		private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			int inputBlockSize = this.m_inputBlockSize;
			string resourceString = Environment.GetResourceString("Input buffer contains insufficient data.");
			if (this.m_encryptindex != null)
			{
			}
			int[] encryptKeyExpansion = this.m_encryptKeyExpansion;
			if (encryptKeyExpansion != null)
			{
			}
			if (encryptKeyExpansion == null)
			{
			}
			int inputBlockSize2 = this.m_inputBlockSize;
			CipherMode cipherMode = this.m_cipherMode;
			byte[] shiftRegister = this.m_shiftRegister;
			int blockSizeBytes = this.m_blockSizeBytes;
			int nb = this.m_Nb;
			int blockSizeBytes2 = this.m_blockSizeBytes;
			CipherMode cipherMode2 = this.m_cipherMode;
			int nb2 = this.m_Nb;
			int[] lastBlockBuffer = this.m_lastBlockBuffer;
			CipherMode cipherMode3 = this.m_cipherMode;
			int inputBlockSize3 = this.m_inputBlockSize;
			int nb3 = this.m_Nb;
			int nb4 = this.m_Nb;
			CipherMode cipherMode4 = this.m_cipherMode;
			if (this.m_lastBlockBuffer != null)
			{
				int nb5 = this.m_Nb;
				int inputBlockSize4 = this.m_inputBlockSize;
				int inputBlockSize5 = this.m_inputBlockSize;
				int inputBlockSize6 = this.m_inputBlockSize;
				int inputBlockSize7 = this.m_inputBlockSize;
			}
			int blockSizeBytes3 = this.m_blockSizeBytes;
			int blockSizeBytes4 = this.m_blockSizeBytes;
			int outputBlockSize = this.m_outputBlockSize;
			byte[] shiftRegister2 = this.m_shiftRegister;
			int blockSizeBytes5 = this.m_blockSizeBytes;
			int outputBlockSize2 = this.m_outputBlockSize;
			byte[] shiftRegister3 = this.m_shiftRegister;
			int inputBlockSize8 = this.m_inputBlockSize;
			RNGCryptoServiceProvider staticRandomNumberGenerator = Utils.StaticRandomNumberGenerator;
			return "Length of the data to encrypt is invalid.";
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00036368 File Offset: 0x00034568
		private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			return "Input buffer contains insufficient data.";
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x000364A0 File Offset: 0x000346A0
		private unsafe void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp)
		{
			int nb = this.m_Nb;
			work->m_value = nb;
			int nr = this.m_Nr;
			int nr2 = this.m_Nr;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000364D8 File Offset: 0x000346D8
		private unsafe void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp)
		{
			int nr = this.m_Nr;
			int nk = this.m_Nk;
			int nr2 = this.m_Nr;
			int nr3 = this.m_Nr;
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00036510 File Offset: 0x00034710
		private void GenerateKeyExpansion(byte[] rgbKey)
		{
			int blockSizeBits = this.m_blockSizeBits;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0000207A File Offset: 0x0000027A
		private static int rot1(int val)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0000207A File Offset: 0x0000027A
		private static int rot2(int val)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0000207A File Offset: 0x0000027A
		private static int rot3(int val)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00036688 File Offset: 0x00034888
		private static int SubWord(int a)
		{
			/*
An exception occurred when decompiling this method (0600193C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.RijndaelManagedTransform::SubWord(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
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

		// Token: 0x0600193D RID: 6461 RVA: 0x0000207A File Offset: 0x0000027A
		private static int MulX(int x)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00036698 File Offset: 0x00034898
		// Note: this type is marked as 'beforefieldinit'.
		static RijndaelManagedTransform()
		{
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000366A8 File Offset: 0x000348A8
		internal RijndaelManagedTransform()
		{
			throw new NotSupportedException();
		}

		// Token: 0x04000CD9 RID: 3289
		private CipherMode m_cipherMode;

		// Token: 0x04000CDA RID: 3290
		private PaddingMode m_paddingValue;

		// Token: 0x04000CDB RID: 3291
		private RijndaelManagedTransformMode m_transformMode;

		// Token: 0x04000CDC RID: 3292
		private int m_blockSizeBits;

		// Token: 0x04000CDD RID: 3293
		private int m_blockSizeBytes;

		// Token: 0x04000CDE RID: 3294
		private int m_inputBlockSize;

		// Token: 0x04000CDF RID: 3295
		private int m_outputBlockSize;

		// Token: 0x04000CE0 RID: 3296
		private int[] m_encryptKeyExpansion;

		// Token: 0x04000CE1 RID: 3297
		private int[] m_decryptKeyExpansion;

		// Token: 0x04000CE2 RID: 3298
		private int m_Nr;

		// Token: 0x04000CE3 RID: 3299
		private int m_Nb;

		// Token: 0x04000CE4 RID: 3300
		private int m_Nk;

		// Token: 0x04000CE5 RID: 3301
		private int[] m_encryptindex;

		// Token: 0x04000CE6 RID: 3302
		private int[] m_decryptindex;

		// Token: 0x04000CE7 RID: 3303
		private int[] m_IV;

		// Token: 0x04000CE8 RID: 3304
		private int[] m_lastBlockBuffer;

		// Token: 0x04000CE9 RID: 3305
		private byte[] m_depadBuffer;

		// Token: 0x04000CEA RID: 3306
		private byte[] m_shiftRegister;

		// Token: 0x04000CEB RID: 3307
		private static readonly byte[] s_Sbox;

		// Token: 0x04000CEC RID: 3308
		private static readonly int[] s_Rcon;

		// Token: 0x04000CED RID: 3309
		private static readonly int[] s_T;

		// Token: 0x04000CEE RID: 3310
		private static readonly int[] s_TF;

		// Token: 0x04000CEF RID: 3311
		private static readonly int[] s_iT;

		// Token: 0x04000CF0 RID: 3312
		private static readonly int[] s_iTF;
	}
}
