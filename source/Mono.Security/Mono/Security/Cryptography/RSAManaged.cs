using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200005D RID: 93
	public class RSAManaged : RSA
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00009DF0 File Offset: 0x00007FF0
		public RSAManaged()
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00009E00 File Offset: 0x00008000
		public RSAManaged(int keySize)
		{
			this.keyBlinding = true;
			base..ctor();
			base.KeySize = keySize;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00009E28 File Offset: 0x00008028
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00009E5C File Offset: 0x0000805C
		private void GenerateKeyPair()
		{
			BigInteger bigInteger = 65537U;
			this.e = bigInteger;
			BigInteger bigInteger2 = BigInteger.GeneratePseudoPrime(int.MinValue);
			long num = 65537L;
			this.p = bigInteger2;
			uint num2 = bigInteger2 % (uint)num;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000A018 File Offset: 0x00008218
		public override int KeySize
		{
			get
			{
				/*
An exception occurred when decompiling this method (06000289)

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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000A050 File Offset: 0x00008250
		public override string KeyExchangeAlgorithm
		{
			get
			{
				return "RSA-PKCS1-KeyEx";
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000A064 File Offset: 0x00008264
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000A098 File Offset: 0x00008298
		public override string SignatureAlgorithm
		{
			get
			{
				return "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A0AC File Offset: 0x000082AC
		public override byte[] DecryptValue(byte[] rgb)
		{
			/*
An exception occurred when decompiling this method (0600028D)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Byte[] Mono.Security.Cryptography.RSAManaged::DecryptValue(System.Byte[])

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_01BE:
	stloc:string(var_39_1C8, call:string(Locale::GetText, ldstr:string("Missing private key to decrypt value.")))
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

		// Token: 0x0600028E RID: 654 RVA: 0x0000A284 File Offset: 0x00008484
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
			bigInteger3.Clear();
			byte[] array;
			return array;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000A2BC File Offset: 0x000084BC
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			/*
An exception occurred when decompiling this method (0600028F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.RSAParameters Mono.Security.Cryptography.RSAManaged::ExportParameters(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00F2:
	stloc:string(var_34_FC, call:string(Locale::GetText, ldstr:string("Keypair was disposed")))
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

		// Token: 0x06000290 RID: 656 RVA: 0x0000A3C8 File Offset: 0x000085C8
		public override void ImportParameters(RSAParameters parameters)
		{
			/*
An exception occurred when decompiling this method (06000290)

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

		// Token: 0x06000291 RID: 657 RVA: 0x0000A598 File Offset: 0x00008798
		protected override void Dispose(bool disposing)
		{
			bool disposed = this.m_disposed;
			if (!disposed)
			{
				BigInteger bigInteger = this.d;
				if (!disposed)
				{
				}
				this.d.Clear();
				BigInteger bigInteger2 = this.p;
				if (!disposed)
				{
				}
				this.p.Clear();
				BigInteger bigInteger3 = this.q;
				if (!disposed)
				{
				}
				this.q.Clear();
				BigInteger bigInteger4 = this.dp;
				if (!disposed)
				{
				}
				this.dp.Clear();
				BigInteger bigInteger5 = this.dq;
				if (!disposed)
				{
				}
				this.dq.Clear();
				BigInteger bigInteger6 = this.qInv;
				if (!disposed)
				{
				}
				this.qInv.Clear();
				BigInteger bigInteger7 = this.e;
				if (!disposed)
				{
				}
				this.e.Clear();
				BigInteger bigInteger8 = this.n;
				if (!disposed)
				{
				}
				this.n.Clear();
			}
			this.m_disposed = true;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A668 File Offset: 0x00008868
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
			if ("<D>" == null)
			{
			}
			if (this != null)
			{
				KeySizes[] legalKeySizesValue = this.LegalKeySizesValue;
			}
			throw new OutOfMemoryException();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000A6C4 File Offset: 0x000088C4
		private byte[] GetPaddedValue(BigInteger value, int length)
		{
			byte[] bytes = value.GetBytes();
			long num = 0L;
			Array.Clear(bytes, (int)num, 42163096);
			return 42163096;
		}

		// Token: 0x0400026D RID: 621
		private bool isCRTpossible;

		// Token: 0x0400026E RID: 622
		private bool keyBlinding;

		// Token: 0x0400026F RID: 623
		private bool keypairGenerated;

		// Token: 0x04000270 RID: 624
		private bool m_disposed;

		// Token: 0x04000271 RID: 625
		private BigInteger d;

		// Token: 0x04000272 RID: 626
		private BigInteger p;

		// Token: 0x04000273 RID: 627
		private BigInteger q;

		// Token: 0x04000274 RID: 628
		private BigInteger dp;

		// Token: 0x04000275 RID: 629
		private BigInteger dq;

		// Token: 0x04000276 RID: 630
		private BigInteger qInv;

		// Token: 0x04000277 RID: 631
		private BigInteger n;

		// Token: 0x04000278 RID: 632
		private BigInteger e;

		// Token: 0x04000279 RID: 633
		[CompilerGenerated]
		private RSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x0200005E RID: 94
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x06000294 RID: 660 RVA: 0x0000A6F0 File Offset: 0x000088F0
			public KeyGeneratedEventHandler(object @object, IntPtr method)
			{
			}

			// Token: 0x06000295 RID: 661 RVA: 0x0000A710 File Offset: 0x00008910
			public void Invoke(object sender, EventArgs e)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
