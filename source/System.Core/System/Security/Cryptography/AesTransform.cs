using System;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000005 RID: 5
	internal class AesTransform : SymmetricTransform
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000023BC File Offset: 0x000005BC
		public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv)
			: base(algo, encryption, iv)
		{
			if (key != null)
			{
				if (iv != null)
				{
				}
				long num = 257L;
				this.Nk = (int)num;
				int num2 = 14;
				this.Nr = num2;
				return;
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002480 File Offset: 0x00000680
		protected override void ECB(byte[] input, byte[] output)
		{
			bool encrypt = this.encrypt;
			uint[] array = this.expandedKey;
			if (encrypt)
			{
				this.Encrypt128(input, output, array);
				return;
			}
			this.Decrypt128(input, output, array);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000024B4 File Offset: 0x000006B4
		private uint SubByte(uint a)
		{
			/*
An exception occurred when decompiling this method (0600002C)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.UInt32 System.Security.Cryptography.AesTransform::SubByte(System.UInt32)

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

		// Token: 0x0600002D RID: 45 RVA: 0x000024C4 File Offset: 0x000006C4
		private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
			int nr = this.Nr;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000024E4 File Offset: 0x000006E4
		private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey)
		{
			int nr = this.Nr;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002504 File Offset: 0x00000704
		// Note: this type is marked as 'beforefieldinit'.
		static AesTransform()
		{
		}

		// Token: 0x04000002 RID: 2
		private uint[] expandedKey;

		// Token: 0x04000003 RID: 3
		private int Nk;

		// Token: 0x04000004 RID: 4
		private int Nr;

		// Token: 0x04000005 RID: 5
		private static readonly uint[] Rcon;

		// Token: 0x04000006 RID: 6
		private static readonly byte[] SBox;

		// Token: 0x04000007 RID: 7
		private static readonly byte[] iSBox;

		// Token: 0x04000008 RID: 8
		private static readonly uint[] T0;

		// Token: 0x04000009 RID: 9
		private static readonly uint[] T1;

		// Token: 0x0400000A RID: 10
		private static readonly uint[] T2;

		// Token: 0x0400000B RID: 11
		private static readonly uint[] T3;

		// Token: 0x0400000C RID: 12
		private static readonly uint[] iT0;

		// Token: 0x0400000D RID: 13
		private static readonly uint[] iT1;

		// Token: 0x0400000E RID: 14
		private static readonly uint[] iT2;

		// Token: 0x0400000F RID: 15
		private static readonly uint[] iT3;
	}
}
