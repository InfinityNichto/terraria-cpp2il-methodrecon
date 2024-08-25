using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004A RID: 74
	internal class RSAManaged : RSA
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00005710 File Offset: 0x00003910
		public RSAManaged(int keySize)
		{
			base.KeySize = keySize;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005738 File Offset: 0x00003938
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000576C File Offset: 0x0000396C
		private void GenerateKeyPair()
		{
			BigInteger bigInteger = 65537U;
			this.e = bigInteger;
			BigInteger bigInteger2 = BigInteger.GeneratePseudoPrime(-1073741824);
			this.p = bigInteger2;
			uint length = bigInteger2.length;
			if (length != 0U)
			{
				uint[] data = bigInteger2.data;
				return;
			}
			BigInteger bigInteger3;
			if (bigInteger3 == null)
			{
			}
			BigInteger bigInteger4 = BigInteger.GeneratePseudoPrime(0);
			this.q = bigInteger4;
			uint length2 = bigInteger4.length;
			if (length2 != 0U)
			{
				uint[] data2 = bigInteger4.data;
			}
			BigInteger bigInteger5 = this.p;
			if (length2 == 0U)
			{
			}
			bool flag = bigInteger5 != bigInteger4;
			BigInteger bigInteger6 = this.p;
			BigInteger bigInteger7 = this.q;
			if (length2 == 0U)
			{
			}
			BigInteger bigInteger8 = bigInteger6 * bigInteger7;
			this.n = bigInteger8;
			int num = bigInteger8.BitCount();
			BigInteger bigInteger9 = this.p;
			BigInteger bigInteger10 = 1;
			BigInteger bigInteger11 = bigInteger9 - bigInteger10;
			BigInteger bigInteger12 = this.q;
			BigInteger bigInteger13 = 1;
			BigInteger bigInteger14 = bigInteger12 - bigInteger13;
			BigInteger bigInteger15 = bigInteger11 * bigInteger14;
			BigInteger bigInteger16 = this.e;
			BigInteger bigInteger17 = BigInteger.Kernel.modInverse(bigInteger16, bigInteger15);
			this.d = bigInteger17;
			BigInteger[] array = BigInteger.Kernel.multiByteDivide(bigInteger17, bigInteger11);
			BigInteger bigInteger18 = this.d;
			this.dp = bigInteger16;
			BigInteger[] array2 = BigInteger.Kernel.multiByteDivide(bigInteger18, bigInteger14);
			BigInteger bigInteger19 = this.p;
			BigInteger bigInteger20 = this.q;
			this.dq = bigInteger16;
			BigInteger bigInteger21 = BigInteger.Kernel.modInverse(bigInteger20, bigInteger19);
			RSAManaged.KeyGeneratedEventHandler keyGenerated = this.KeyGenerated;
			this.qInv = bigInteger21;
			if (keyGenerated != null)
			{
				IntPtr invoke_impl = keyGenerated.invoke_impl;
				IntPtr method_code = keyGenerated.method_code;
				IntPtr method = keyGenerated.method;
				return;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00005918 File Offset: 0x00003B18
		public override int KeySize
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600017E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 Mono.Security.Cryptography.RSAManaged::get_KeySize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0020:
	stloc:string(var_1_2A, call:string(Locale::GetText, ldstr:string("Keypair was disposed")))
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00005950 File Offset: 0x00003B50
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return "RSA-PKCS1-KeyEx";
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00005964 File Offset: 0x00003B64
		public bool PublicOnly
		{
			get
			{
				bool flag = this.keypairGenerated;
				if (flag)
				{
					BigInteger bigInteger = this.d;
					if (!flag)
					{
					}
					return true;
				}
				BigInteger bigInteger2 = this.n;
				if (!flag)
				{
				}
				bool flag2;
				return flag2;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00005998 File Offset: 0x00003B98
		public override string SignatureAlgorithm
		{
			get
			{
				return "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000059AC File Offset: 0x00003BAC
		public override byte[] DecryptValue(byte[] rgb)
		{
			/*
An exception occurred when decompiling this method (06000182)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Cryptography.RSAManaged::DecryptValue(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_019A:
	stloc:string(var_45_1A4, call:string(Locale::GetText, ldstr:string("Missing private key to decrypt value.")))
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

		// Token: 0x06000183 RID: 387 RVA: 0x00005B60 File Offset: 0x00003D60
		public override byte[] EncryptValue(byte[] rgb)
		{
			while (this.m_disposed)
			{
			}
			if (!this.keypairGenerated)
			{
				this.GenerateKeyPair();
			}
			BigInteger bigInteger = this.n;
			BigInteger bigInteger2 = this.e;
			BigInteger bigInteger3;
			if (bigInteger3.length != 0U)
			{
				uint[] data = bigInteger3.data;
				uint length = bigInteger3.length;
			}
			byte[] array;
			return array;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			/*
An exception occurred when decompiling this method (06000184)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.RSAParameters Mono.Security.Cryptography.RSAManaged::ExportParameters(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00FD:
	stloc:string(var_34_107, call:string(Locale::GetText, ldstr:string("Keypair was disposed")))
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

		// Token: 0x06000185 RID: 389 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public override void ImportParameters(RSAParameters parameters)
		{
			/*
An exception occurred when decompiling this method (06000185)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Mono.Security.Cryptography.RSAManaged::ImportParameters(System.Security.Cryptography.RSAParameters)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_01B8:
	stloc:string(var_39_1C2, call:string(Locale::GetText, ldstr:string("Missing Modulus")))
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

		// Token: 0x06000186 RID: 390 RVA: 0x00005E98 File Offset: 0x00004098
		protected override void Dispose(bool disposing)
		{
			bool disposed = this.m_disposed;
			if (!disposed)
			{
				BigInteger bigInteger = this.d;
				if (!disposed)
				{
				}
				BigInteger bigInteger2 = this.d;
				if (bigInteger2.length != 0U)
				{
					uint[] data = bigInteger2.data;
					uint length = bigInteger2.length;
				}
				BigInteger bigInteger3 = this.p;
				if (bigInteger2 == null)
				{
				}
				BigInteger bigInteger4 = this.p;
				if (bigInteger4.length != 0U)
				{
					uint[] data2 = bigInteger4.data;
					uint length2 = bigInteger4.length;
				}
				BigInteger bigInteger5 = this.q;
				if (bigInteger4 == null)
				{
				}
				BigInteger bigInteger6 = this.q;
				if (bigInteger6.length != 0U)
				{
					uint[] data3 = bigInteger6.data;
					uint length3 = bigInteger6.length;
				}
				BigInteger bigInteger7 = this.dp;
				if (bigInteger6 == null)
				{
				}
				BigInteger bigInteger8 = this.dp;
				if (bigInteger8.length != 0U)
				{
					uint[] data4 = bigInteger8.data;
					uint length4 = bigInteger8.length;
				}
				BigInteger bigInteger9 = this.dq;
				if (bigInteger8 == null)
				{
				}
				BigInteger bigInteger10 = this.dq;
				if (bigInteger10.length != 0U)
				{
					uint[] data5 = bigInteger10.data;
					uint length5 = bigInteger10.length;
				}
				BigInteger bigInteger11 = this.qInv;
				if (bigInteger10 == null)
				{
				}
				BigInteger bigInteger12 = this.qInv;
				if (bigInteger12.length != 0U)
				{
					uint[] data6 = bigInteger12.data;
					uint length6 = bigInteger12.length;
				}
				BigInteger bigInteger13 = this.e;
				if (bigInteger12 == null)
				{
				}
				BigInteger bigInteger14 = this.e;
				if (bigInteger14.length != 0U)
				{
					uint[] data7 = bigInteger14.data;
					uint length7 = bigInteger14.length;
				}
				BigInteger bigInteger15 = this.n;
				if (bigInteger14 == null)
				{
				}
				BigInteger bigInteger16 = this.n;
				if (bigInteger16.length != 0U)
				{
					uint[] data8 = bigInteger16.data;
					uint length8 = bigInteger16.length;
				}
			}
			int num = 1;
			this.m_disposed = num != 0;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000187 RID: 391 RVA: 0x00006048 File Offset: 0x00004248
		// (remove) Token: 0x06000188 RID: 392 RVA: 0x0000606C File Offset: 0x0000426C
		public event RSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			[CompilerGenerated]
			add
			{
				if (Delegate.Combine(this.KeyGenerated, value) != null)
				{
				}
			}
			[CompilerGenerated]
			remove
			{
				if (Delegate.Remove(this.KeyGenerated, value) != null)
				{
				}
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006090 File Offset: 0x00004290
		public override string ToXmlString(bool includePrivateParameters)
		{
			if ("<Modulus>" == null)
			{
			}
			if ("<P>" == null)
			{
			}
			if ("<Q>" == null)
			{
			}
			if ("<DP>" == null)
			{
			}
			if ("<DQ>" == null)
			{
			}
			if ("<InverseQ>" == null)
			{
			}
			StringBuilder stringBuilder2;
			StringBuilder stringBuilder = stringBuilder2.Append("<D>");
			if ("<D>" == null)
			{
			}
			if (this != null)
			{
				KeySizes[] legalKeySizesValue = this.LegalKeySizesValue;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000060F8 File Offset: 0x000042F8
		public bool IsCrtPossible
		{
			get
			{
				if (this.keypairGenerated)
				{
					bool flag = this.isCRTpossible;
				}
				return true;
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006118 File Offset: 0x00004318
		private byte[] GetPaddedValue(BigInteger value, int length)
		{
			byte[] bytes = value.GetBytes();
			long num = 0L;
			Array.Clear(bytes, (int)num, 42163096);
			return 42163096;
		}

		// Token: 0x04000157 RID: 343
		private bool isCRTpossible;

		// Token: 0x04000158 RID: 344
		private bool keyBlinding = true;

		// Token: 0x04000159 RID: 345
		private bool keypairGenerated;

		// Token: 0x0400015A RID: 346
		private bool m_disposed;

		// Token: 0x0400015B RID: 347
		private BigInteger d;

		// Token: 0x0400015C RID: 348
		private BigInteger p;

		// Token: 0x0400015D RID: 349
		private BigInteger q;

		// Token: 0x0400015E RID: 350
		private BigInteger dp;

		// Token: 0x0400015F RID: 351
		private BigInteger dq;

		// Token: 0x04000160 RID: 352
		private BigInteger qInv;

		// Token: 0x04000161 RID: 353
		private BigInteger n;

		// Token: 0x04000162 RID: 354
		private BigInteger e;

		// Token: 0x04000163 RID: 355
		[CompilerGenerated]
		private RSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x0200004B RID: 75
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x0600018C RID: 396 RVA: 0x00006144 File Offset: 0x00004344
			public KeyGeneratedEventHandler(object @object, IntPtr method)
			{
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x0600018D RID: 397 RVA: 0x00006194 File Offset: 0x00004394
			public void Invoke(object sender, EventArgs e)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
