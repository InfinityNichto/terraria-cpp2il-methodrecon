using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace System.Security.Cryptography
{
	// Token: 0x02000308 RID: 776
	[ComVisible(true)]
	public abstract class SymmetricAlgorithm : IDisposable
	{
		// Token: 0x06001A27 RID: 6695 RVA: 0x0003834C File Offset: 0x0003654C
		protected SymmetricAlgorithm()
		{
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00038360 File Offset: 0x00036560
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00038374 File Offset: 0x00036574
		public void Clear()
		{
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00038384 File Offset: 0x00036584
		protected virtual void Dispose(bool disposing)
		{
			if (this.KeyValue != null)
			{
			}
			if (this.IVValue != null)
			{
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x000383A4 File Offset: 0x000365A4
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x000383B8 File Offset: 0x000365B8
		public virtual int BlockSize
		{
			get
			{
				return this.BlockSizeValue;
			}
			set
			{
				int skipSize = this.LegalBlockSizesValue.m_skipSize;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x000383E0 File Offset: 0x000365E0
		// (set) Token: 0x06001A2E RID: 6702 RVA: 0x000383F4 File Offset: 0x000365F4
		public virtual int FeedbackSize
		{
			get
			{
				return this.FeedbackSizeValue;
			}
			set
			{
				int blockSizeValue = this.BlockSizeValue;
				this.FeedbackSizeValue = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x0003841C File Offset: 0x0003661C
		// (set) Token: 0x06001A30 RID: 6704 RVA: 0x00038444 File Offset: 0x00036644
		public virtual byte[] IV
		{
			get
			{
				if (this.IVValue == null)
				{
					byte[] ivvalue = this.IVValue;
				}
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				if (value != null)
				{
					int blockSizeValue = this.BlockSizeValue;
					object obj;
					if (obj != null)
					{
						if (obj == null)
						{
							goto IL_002C;
						}
						this.IVValue = obj;
						if (obj == null)
						{
							throw new InvalidCastException();
						}
					}
					return;
				}
				string resourceString = Environment.GetResourceString("Specified initialization vector (IV) does not match the block size for this algorithm.");
				IL_002C:
				throw new InvalidCastException();
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00038484 File Offset: 0x00036684
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x000384AC File Offset: 0x000366AC
		public virtual byte[] Key
		{
			get
			{
				if (this.KeyValue == null)
				{
					byte[] keyValue = this.KeyValue;
				}
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
			set
			{
				/*
An exception occurred when decompiling this method (06001A32)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void System.Security.Cryptography.SymmetricAlgorithm::set_Key(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0013:
	stloc:string(var_2_1D, call:string(Environment::GetResourceString, ldstr:string("Specified key is not a valid size for this algorithm.")))
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
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x000384D8 File Offset: 0x000366D8
		public virtual KeySizes[] LegalBlockSizes
		{
			get
			{
				KeySizes[] legalBlockSizesValue = this.LegalBlockSizesValue;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000384F8 File Offset: 0x000366F8
		public virtual KeySizes[] LegalKeySizes
		{
			get
			{
				KeySizes[] legalKeySizesValue = this.LegalKeySizesValue;
				object obj;
				if (obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00038518 File Offset: 0x00036718
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x0003852C File Offset: 0x0003672C
		public virtual int KeySize
		{
			get
			{
				return this.KeySizeValue;
			}
			set
			{
				bool flag = this.ValidKeySize(value);
				this.KeySizeValue = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00038554 File Offset: 0x00036754
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00038568 File Offset: 0x00036768
		public virtual CipherMode Mode
		{
			get
			{
				return this.ModeValue;
			}
			set
			{
				this.ModeValue = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00038588 File Offset: 0x00036788
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0003859C File Offset: 0x0003679C
		public virtual PaddingMode Padding
		{
			get
			{
				return this.PaddingValue;
			}
			set
			{
				this.PaddingValue = value;
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000385BC File Offset: 0x000367BC
		public bool ValidKeySize(int bitLength)
		{
			/*
An exception occurred when decompiling this method (06001A3B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.SymmetricAlgorithm::ValidKeySize(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:uint8[](var_0_09, ldfld:uint8[](SymmetricAlgorithm::IVValue, ldloc:SymmetricAlgorithm(this)))
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

		// Token: 0x06001A3C RID: 6716 RVA: 0x0000207A File Offset: 0x0000027A
		public static SymmetricAlgorithm Create()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000385D8 File Offset: 0x000367D8
		public static SymmetricAlgorithm Create(string algName)
		{
			if (!true)
			{
			}
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual ICryptoTransform CreateEncryptor()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A3F RID: 6719
		public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

		// Token: 0x06001A40 RID: 6720 RVA: 0x0000207A File Offset: 0x0000027A
		public virtual ICryptoTransform CreateDecryptor()
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x06001A41 RID: 6721
		public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

		// Token: 0x06001A42 RID: 6722
		public abstract void GenerateKey();

		// Token: 0x06001A43 RID: 6723
		public abstract void GenerateIV();

		// Token: 0x04000D2B RID: 3371
		protected int BlockSizeValue;

		// Token: 0x04000D2C RID: 3372
		protected int FeedbackSizeValue;

		// Token: 0x04000D2D RID: 3373
		protected byte[] IVValue;

		// Token: 0x04000D2E RID: 3374
		protected byte[] KeyValue;

		// Token: 0x04000D2F RID: 3375
		protected KeySizes[] LegalBlockSizesValue;

		// Token: 0x04000D30 RID: 3376
		protected KeySizes[] LegalKeySizesValue;

		// Token: 0x04000D31 RID: 3377
		protected int KeySizeValue;

		// Token: 0x04000D32 RID: 3378
		protected CipherMode ModeValue;

		// Token: 0x04000D33 RID: 3379
		protected PaddingMode PaddingValue;
	}
}
