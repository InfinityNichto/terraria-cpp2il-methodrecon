using System;
using System.Security.Cryptography;
using Cpp2IlInjected;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000051 RID: 81
	public class ARC4Managed : RC4, ICryptoTransform, IDisposable
	{
		// Token: 0x06000225 RID: 549 RVA: 0x0000900C File Offset: 0x0000720C
		public ARC4Managed()
		{
			if ("getFilesDir" == null)
			{
			}
			base..ctor();
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00009028 File Offset: 0x00007228
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000905C File Offset: 0x0000725C
		protected override void Dispose(bool disposing)
		{
			bool disposed = this.m_disposed;
			if (!disposed)
			{
				if (this.key != null)
				{
				}
				byte[] array = this.state;
				if (!disposed)
				{
				}
				GC.SuppressFinalize(this);
				this.m_disposed = true;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00009094 File Offset: 0x00007294
		// (set) Token: 0x06000229 RID: 553 RVA: 0x000090BC File Offset: 0x000072BC
		public override byte[] Key
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
				while (value == null)
				{
				}
				object obj;
				if (obj != null && obj == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600022A RID: 554 RVA: 0x000090D8 File Offset: 0x000072D8
		public bool CanReuseTransform
		{
			get
			{
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000090E8 File Offset: 0x000072E8
		public override void GenerateIV()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000090F8 File Offset: 0x000072F8
		public override void GenerateKey()
		{
			int keySizeValue = this.KeySizeValue;
			byte[] array;
			this.KeyValue = array;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00009114 File Offset: 0x00007314
		public bool CanTransformMultipleBlocks
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00009124 File Offset: 0x00007324
		public int InputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00009134 File Offset: 0x00007334
		public int OutputBlockSize
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00009144 File Offset: 0x00007344
		private void KeySetup(byte[] key)
		{
			byte[] array = this.state;
			byte[] array2 = this.state;
			byte[] array3 = this.state;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000916C File Offset: 0x0000736C
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			if (inputBuffer != null)
			{
				return;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000918C File Offset: 0x0000738C
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			/*
An exception occurred when decompiling this method (06000234)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Security.Cryptography.ARC4Managed::TransformBlock(System.Byte[],System.Int32,System.Int32,System.Byte[],System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_001B:
	stloc:string(var_0_25, call:string(Locale::GetText, ldstr:string("Overflow")))
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

		// Token: 0x06000235 RID: 565 RVA: 0x000091C0 File Offset: 0x000073C0
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			byte b = this.x;
			byte[] array = this.state;
			byte b2 = this.y;
			this.x = b;
			this.y = b2;
			array.m_value = b2;
			byte[] array2 = this.state;
			byte b3 = this.y;
			byte[] array3 = this.state;
			byte b4 = this.x;
			byte b5 = this.y;
			return inputCount;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		// Token: 0x0400024E RID: 590
		private byte[] key;

		// Token: 0x0400024F RID: 591
		private byte[] state;

		// Token: 0x04000250 RID: 592
		private byte x;

		// Token: 0x04000251 RID: 593
		private byte y;

		// Token: 0x04000252 RID: 594
		private bool m_disposed;
	}
}
