using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	// Token: 0x020002BD RID: 701
	public abstract class HashAlgorithm : IDisposable, ICryptoTransform
	{
		// Token: 0x060017B1 RID: 6065 RVA: 0x000332C0 File Offset: 0x000314C0
		protected HashAlgorithm()
		{
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x000332D4 File Offset: 0x000314D4
		public static HashAlgorithm Create()
		{
			return CryptoConfigForwarder.CreateDefaultHashAlgorithm();
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x000332E8 File Offset: 0x000314E8
		public static HashAlgorithm Create(string hashName)
		{
			object obj;
			if (obj != null)
			{
			}
			throw new InvalidCastException();
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00033300 File Offset: 0x00031500
		public virtual int HashSize
		{
			get
			{
				return this.HashSizeValue;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00033314 File Offset: 0x00031514
		public virtual byte[] Hash
		{
			get
			{
				object obj;
				if (this._disposed || this.State != 0 || this.HashValue == null || obj == null || obj != null)
				{
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00033344 File Offset: 0x00031544
		public byte[] ComputeHash(byte[] buffer)
		{
			while (this._disposed || buffer == null)
			{
			}
			return this.CaptureHashCodeAndReinitialize();
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00033364 File Offset: 0x00031564
		public bool TryComputeHash(ReadOnlySpan<byte> source, Span<byte> destination, [Out] int bytesWritten)
		{
			/*
An exception occurred when decompiling this method (060017B7)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.HashAlgorithm::TryComputeHash(System.ReadOnlySpan`1<System.Byte>,System.Span`1<System.Byte>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_0E, ldfld:int32(HashAlgorithm::HashSizeValue, ldloc:HashAlgorithm(this)))
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

		// Token: 0x060017B8 RID: 6072 RVA: 0x00033384 File Offset: 0x00031584
		public byte[] ComputeHash(byte[] buffer, int offset, int count)
		{
			while (buffer == null || this._disposed)
			{
			}
			return this.CaptureHashCodeAndReinitialize();
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000333A8 File Offset: 0x000315A8
		public byte[] ComputeHash(Stream inputStream)
		{
			while (this._disposed)
			{
			}
			return this.CaptureHashCodeAndReinitialize();
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000333C4 File Offset: 0x000315C4
		private byte[] CaptureHashCodeAndReinitialize()
		{
			object obj;
			while (obj != null)
			{
				if (obj == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000333E0 File Offset: 0x000315E0
		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000333F4 File Offset: 0x000315F4
		public void Clear()
		{
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00033404 File Offset: 0x00031604
		protected virtual void Dispose(bool disposing)
		{
			this._disposed = true;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00033418 File Offset: 0x00031618
		public virtual int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x00033428 File Offset: 0x00031628
		public virtual int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00033438 File Offset: 0x00031638
		public virtual bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00033448 File Offset: 0x00031648
		public virtual bool CanReuseTransform
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00033458 File Offset: 0x00031658
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			this.ValidateTransformBlock(inputBuffer, inputOffset, inputCount);
			this.State = 1;
			if (outputBuffer != null)
			{
				Buffer.BlockCopy(inputBuffer, inputOffset, outputBuffer, outputOffset, inputCount);
			}
			return inputCount;
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00033488 File Offset: 0x00031688
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			do
			{
				this.ValidateTransformBlock(inputBuffer, inputOffset, inputCount);
				byte[] array = this.CaptureHashCodeAndReinitialize();
				this.HashValue = array;
			}
			while (inputCount == 0);
			return inputBuffer;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x000334B0 File Offset: 0x000316B0
		private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			while (inputBuffer != null)
			{
				if (!this._disposed)
				{
					return;
				}
			}
		}

		// Token: 0x060017C5 RID: 6085
		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		// Token: 0x060017C6 RID: 6086
		protected abstract byte[] HashFinal();

		// Token: 0x060017C7 RID: 6087
		public abstract void Initialize();

		// Token: 0x060017C8 RID: 6088 RVA: 0x000334CC File Offset: 0x000316CC
		protected virtual void HashCore(ReadOnlySpan<byte> source)
		{
			if (!true)
			{
			}
			if (!true)
			{
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000334E4 File Offset: 0x000316E4
		protected virtual bool TryHashFinal(Span<byte> destination, [Out] int bytesWritten)
		{
			/*
An exception occurred when decompiling this method (060017C9)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Boolean System.Security.Cryptography.HashAlgorithm::TryHashFinal(System.Span`1<System.Byte>,System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:int32(var_0_06, ldfld:int32(HashAlgorithm::HashSizeValue, ldloc:HashAlgorithm(this)))
	stloc:uint8[](var_2_0F, ldfld:uint8[](HashAlgorithm::HashValue, ldloc:HashAlgorithm(this)))
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

		// Token: 0x04000C60 RID: 3168
		private bool _disposed;

		// Token: 0x04000C61 RID: 3169
		protected int HashSizeValue;

		// Token: 0x04000C62 RID: 3170
		protected internal byte[] HashValue;

		// Token: 0x04000C63 RID: 3171
		protected int State;
	}
}
