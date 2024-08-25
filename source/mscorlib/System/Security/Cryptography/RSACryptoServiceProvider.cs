using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x020002F4 RID: 756
	[ComVisible(true)]
	public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
	{
		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x00036C70 File Offset: 0x00034E70
		public override string SignatureAlgorithm
		{
			get
			{
				return "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0000207A File Offset: 0x0000027A
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x00036C84 File Offset: 0x00034E84
		public static bool UseMachineKeyStore
		{
			get
			{
				throw new AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
			set
			{
			}
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00036C94 File Offset: 0x00034E94
		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			HashAlgorithm hashAlgorithm2;
			return hashAlgorithm2.ComputeHash(data, offset, count);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00036CAC File Offset: 0x00034EAC
		protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm)
		{
			HashAlgorithm hashAlgorithm2;
			return hashAlgorithm2.ComputeHash(data);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00036CC0 File Offset: 0x00034EC0
		private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm)
		{
			bool flag = "SHA512" == "MD5";
			return 32771;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00036D00 File Offset: 0x00034F00
		public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			if (data != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				return this.Encrypt(data, true);
			}
			return "data";
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00036D34 File Offset: 0x00034F34
		public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			if (data != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				byte[] array;
				return array;
			}
			return "data";
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00036D5C File Offset: 0x00034F5C
		public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (hash != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				int algorithmId = RSACryptoServiceProvider.GetAlgorithmId(hashAlgorithm);
				return this.SignHash(hash, algorithmId);
			}
			return "hash";
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00036D98 File Offset: 0x00034F98
		public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			if (hash == null)
			{
				return "hash" != null;
			}
			if (signature != null)
			{
				if (!true)
				{
				}
				if (!true)
				{
				}
				if (!true)
				{
				}
				int algorithmId = RSACryptoServiceProvider.GetAlgorithmId(hashAlgorithm);
				return this.VerifyHash(hash, algorithmId, signature);
			}
			return "signature" != null;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00036DE0 File Offset: 0x00034FE0
		private static Exception PaddingModeNotSupported()
		{
			/*
An exception occurred when decompiling this method (06001982)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Exception System.Security.Cryptography.RSACryptoServiceProvider::PaddingModeNotSupported()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:string(var_0_0A, call:string(Environment::GetResourceString, ldstr:string("Specified padding mode is not valid for this algorithm.")))
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

		// Token: 0x06001983 RID: 6531 RVA: 0x00036DF8 File Offset: 0x00034FF8
		public RSACryptoServiceProvider()
		{
			this.privateKeyExportable = true;
			base..ctor();
			long num = 0L;
			this.Common(1024, num != 0L);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00036E20 File Offset: 0x00035020
		public RSACryptoServiceProvider(CspParameters parameters)
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00036E30 File Offset: 0x00035030
		public RSACryptoServiceProvider(int dwKeySize)
		{
			this.privateKeyExportable = true;
			base..ctor();
			long num = 0L;
			this.Common(dwKeySize, num != 0L);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00036E54 File Offset: 0x00035054
		public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
			this.privateKeyExportable = true;
			base..ctor();
			if (parameters != null)
			{
				this.Common(parameters);
				return;
			}
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00036E7C File Offset: 0x0003507C
		private void Common(int dwKeySize, bool parameters)
		{
			base.KeySize = dwKeySize;
			bool useMachineKeyStore = RSACryptoServiceProvider.UseMachineKeyStore;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00036E9C File Offset: 0x0003509C
		private void Common(CspParameters p)
		{
			int flags = p.m_flags;
			this.privateKeyExportable = true;
			if (this.store._keyvalue != null)
			{
				this.persisted = true;
				return;
			}
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00036ECC File Offset: 0x000350CC
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x00036F00 File Offset: 0x00035100
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return "RSA-PKCS1-KeyEx";
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00036F14 File Offset: 0x00035114
		public override int KeySize
		{
			get
			{
				/*
An exception occurred when decompiling this method (0600198B)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Int32 System.Security.Cryptography.RSACryptoServiceProvider::get_KeySize()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_0000:
	brtrue(IL_0000, logicnot:bool(ldfld:RSAManaged[exp:bool](RSACryptoServiceProvider::rsa, ldloc:RSACryptoServiceProvider(this))))
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

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x00036F28 File Offset: 0x00035128
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x00036F3C File Offset: 0x0003513C
		public bool PersistKeyInCsp
		{
			get
			{
				return this.persistKey;
			}
			set
			{
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x00036F4C File Offset: 0x0003514C
		[ComVisible(false)]
		public bool PublicOnly
		{
			get
			{
				return this.rsa.PublicOnly;
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00036F64 File Offset: 0x00035164
		public byte[] Decrypt(byte[] rgb, bool fOAEP)
		{
			while (rgb != null)
			{
				if (!this.m_disposed)
				{
					RSAManaged rsamanaged = this.rsa;
					break;
				}
			}
			throw new ArrayTypeMismatchException();
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00036F8C File Offset: 0x0003518C
		public override byte[] DecryptValue(byte[] rgb)
		{
			/*
An exception occurred when decompiling this method (06001990)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.RSACryptoServiceProvider::DecryptValue(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:bool(var_0_0B, callgetter:bool(RSAManaged::get_IsCrtPossible, ldfld:RSAManaged(RSACryptoServiceProvider::rsa, ldloc:RSACryptoServiceProvider(this))))
	stloc:RSAManaged(var_1_12, ldfld:RSAManaged(RSACryptoServiceProvider::rsa, ldloc:RSACryptoServiceProvider(this)))
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

		// Token: 0x06001991 RID: 6545 RVA: 0x00036FAC File Offset: 0x000351AC
		public byte[] Encrypt(byte[] rgb, bool fOAEP)
		{
			/*
An exception occurred when decompiling this method (06001991)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.RSACryptoServiceProvider::Encrypt(System.Byte[],System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RSAManaged(var_0_06, ldfld:RSAManaged(RSACryptoServiceProvider::rsa, ldloc:RSACryptoServiceProvider(this)))
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

		// Token: 0x06001992 RID: 6546 RVA: 0x00036FC0 File Offset: 0x000351C0
		public override byte[] EncryptValue(byte[] rgb)
		{
			/*
An exception occurred when decompiling this method (06001992)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] System.Security.Cryptography.RSACryptoServiceProvider::EncryptValue(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RSAManaged(var_0_06, ldfld:RSAManaged(RSACryptoServiceProvider::rsa, ldloc:RSACryptoServiceProvider(this)))
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

		// Token: 0x06001993 RID: 6547 RVA: 0x00036FD4 File Offset: 0x000351D4
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			/*
An exception occurred when decompiling this method (06001993)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.RSAParameters System.Security.Cryptography.RSACryptoServiceProvider::ExportParameters(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:RSAManaged(var_1_0E, ldfld:RSAManaged(RSACryptoServiceProvider::rsa, ldloc:RSACryptoServiceProvider(this)))
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

		// Token: 0x06001994 RID: 6548 RVA: 0x00036FF0 File Offset: 0x000351F0
		public override void ImportParameters(RSAParameters parameters)
		{
			byte[] dp = parameters.DP;
			byte[] exponent = parameters.Exponent;
			RSAManaged rsamanaged = this.rsa;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00037014 File Offset: 0x00035214
		private HashAlgorithm GetHash(object halg)
		{
			for (;;)
			{
				if (halg != null)
				{
					object obj;
					if (obj != null)
					{
						break;
					}
					HashAlgorithm hashAlgorithm;
					if (hashAlgorithm != null)
					{
						return hashAlgorithm;
					}
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00037034 File Offset: 0x00035234
		private HashAlgorithm GetHashFromString(string name)
		{
			HashAlgorithm hashAlgorithm;
			if (HashAlgorithm.Create(name) == null)
			{
				string text;
				hashAlgorithm = HashAlgorithm.Create(text);
			}
			return hashAlgorithm;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00037058 File Offset: 0x00035258
		public byte[] SignData(byte[] buffer, object halg)
		{
			while (buffer == null)
			{
			}
			byte[] array;
			return array;
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0003706C File Offset: 0x0003526C
		public byte[] SignData(Stream inputStream, object halg)
		{
			HashAlgorithm hash = this.GetHash(halg);
			byte[] array = hash.ComputeHash(inputStream);
			return PKCS1.Sign_v15(this, hash, array);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00037094 File Offset: 0x00035294
		public byte[] SignData(byte[] buffer, int offset, int count, object halg)
		{
			HashAlgorithm hash = this.GetHash(halg);
			byte[] array = hash.ComputeHash(buffer, offset, count);
			return PKCS1.Sign_v15(this, hash, array);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000370BC File Offset: 0x000352BC
		private string GetHashNameFromOID(string oid)
		{
			bool flag = oid == "1.3.14.3.2.26";
			bool flag2 = oid == "1.2.840.113549.2.5";
			bool flag3 = oid == "2.16.840.1.101.3.4.2.1";
			bool flag4 = oid == "2.16.840.1.101.3.4.2.2";
			bool flag5 = oid == "2.16.840.1.101.3.4.2.3";
			return "SHA512";
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00037118 File Offset: 0x00035318
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			while (rgbHash == null)
			{
			}
			if (str != null)
			{
			}
			HashAlgorithm hashAlgorithm = HashAlgorithm.Create("SHA1");
			return PKCS1.Sign_v15(this, hashAlgorithm, rgbHash);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00037140 File Offset: 0x00035340
		private byte[] SignHash(byte[] rgbHash, int calgHash)
		{
			HashAlgorithm hashAlgorithm = RSACryptoServiceProvider.InternalHashToHashAlgorithm(calgHash);
			return PKCS1.Sign_v15(this, hashAlgorithm, rgbHash);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0003715C File Offset: 0x0003535C
		private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash)
		{
			/*
An exception occurred when decompiling this method (0600199D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.HashAlgorithm System.Security.Cryptography.RSACryptoServiceProvider::InternalHashToHashAlgorithm(System.Int32)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:MD5(var_1_07, call:MD5(MD5::Create))
	stloc:SHA1(var_2_0D, call:SHA1(SHA1::Create))
	stloc:SHA384(var_3_13, call:SHA384(SHA384::Create))
	stloc:SHA256(var_4_19, call:SHA256(SHA256::Create))
	stloc:SHA512(var_5_20, call:SHA512(SHA512::Create))
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

		// Token: 0x0600199E RID: 6558 RVA: 0x0003718C File Offset: 0x0003538C
		public bool VerifyData(byte[] buffer, object halg, byte[] signature)
		{
			while (buffer != null)
			{
				if (signature != null)
				{
					HashAlgorithm hash = this.GetHash(halg);
					byte[] array = hash.ComputeHash(buffer);
					return PKCS1.Verify_v15(this, hash, array, signature);
				}
			}
			return "buffer" != null;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000371C0 File Offset: 0x000353C0
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			while (rgbHash != null)
			{
				if (rgbSignature != null)
				{
					if (str != null)
					{
					}
					HashAlgorithm hashAlgorithm = HashAlgorithm.Create("SHA1");
					return PKCS1.Verify_v15(this, hashAlgorithm, rgbHash, rgbSignature);
				}
			}
			return "rgbHash" != null;
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x000371F0 File Offset: 0x000353F0
		private bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature)
		{
			HashAlgorithm hashAlgorithm = RSACryptoServiceProvider.InternalHashToHashAlgorithm(calgHash);
			return PKCS1.Verify_v15(this, hashAlgorithm, rgbHash, rgbSignature);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00037210 File Offset: 0x00035410
		protected override void Dispose(bool disposing)
		{
			if (!this.m_disposed)
			{
				if (this.persisted && !this.persistKey)
				{
					this.store.Remove();
				}
				RSAManaged rsamanaged = this.rsa;
				if (rsamanaged != null)
				{
					rsamanaged.Clear();
				}
				this.m_disposed = true;
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00037258 File Offset: 0x00035458
		private void OnKeyGenerated(object sender, EventArgs e)
		{
			if (this.persistKey && !this.persisted)
			{
				RSAManaged rsamanaged = this.rsa;
				KeyPairPersistence keyPairPersistence = this.store;
				bool publicOnly = rsamanaged.PublicOnly;
				this.store.Save();
				this.persisted = true;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x0003729C File Offset: 0x0003549C
		[ComVisible(false)]
		public CspKeyContainerInfo CspKeyContainerInfo
		{
			get
			{
				/*
An exception occurred when decompiling this method (060019A3)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.CspKeyContainerInfo System.Security.Cryptography.RSACryptoServiceProvider::get_CspKeyContainerInfo()

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	Block_0:
	stloc:CspParameters(var_0_0B, callgetter:CspParameters(KeyPairPersistence::get_Parameters, ldfld:KeyPairPersistence(RSACryptoServiceProvider::store, ldloc:RSACryptoServiceProvider(this))))
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

		// Token: 0x060019A4 RID: 6564 RVA: 0x000372B4 File Offset: 0x000354B4
		[ComVisible(false)]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			return CryptoConvert.ToCapiPrivateKeyBlob(this);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x000372E0 File Offset: 0x000354E0
		[ComVisible(false)]
		public void ImportCspBlob(byte[] keyBlob)
		{
			if (keyBlob == null)
			{
				return;
			}
			if (CryptoConvert.FromCapiKeyBlob(keyBlob) != null)
			{
				return;
			}
			bool useMachineKeyStore = RSACryptoServiceProvider.UseMachineKeyStore;
		}

		// Token: 0x04000CFD RID: 3325
		private static CspProviderFlags s_UseMachineKeyStore;

		// Token: 0x04000CFE RID: 3326
		private const int PROV_RSA_FULL = 1;

		// Token: 0x04000CFF RID: 3327
		private const int AT_KEYEXCHANGE = 1;

		// Token: 0x04000D00 RID: 3328
		private const int AT_SIGNATURE = 2;

		// Token: 0x04000D01 RID: 3329
		private KeyPairPersistence store;

		// Token: 0x04000D02 RID: 3330
		private bool persistKey;

		// Token: 0x04000D03 RID: 3331
		private bool persisted;

		// Token: 0x04000D04 RID: 3332
		private bool privateKeyExportable;

		// Token: 0x04000D05 RID: 3333
		private bool m_disposed;

		// Token: 0x04000D06 RID: 3334
		private RSAManaged rsa;
	}
}
