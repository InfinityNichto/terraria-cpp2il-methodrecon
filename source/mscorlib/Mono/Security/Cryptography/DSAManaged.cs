using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200004D RID: 77
	internal class DSAManaged : DSA
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x000067D4 File Offset: 0x000049D4
		public DSAManaged(int dwKeySize)
		{
			this.KeySizeValue = dwKeySize;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000067F4 File Offset: 0x000049F4
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00006828 File Offset: 0x00004A28
		private void Generate()
		{
			int keySizeValue = this.KeySizeValue;
			this.GenerateParams(keySizeValue);
			this.GenerateKeyPair();
			DSAManaged.KeyGeneratedEventHandler keyGenerated = this.KeyGenerated;
			this.keypairGenerated = true;
			if (keyGenerated != null)
			{
				IntPtr invoke_impl = keyGenerated.invoke_impl;
				IntPtr method_code = keyGenerated.method_code;
				IntPtr method = keyGenerated.method;
				return;
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00006874 File Offset: 0x00004A74
		private void GenerateKeyPair()
		{
			if (!true)
			{
			}
			BigInteger bigInteger = BigInteger.GenerateRandom(160);
			this.x = bigInteger;
			if (!true)
			{
			}
			long num = 0L;
			bool flag = bigInteger == (uint)num;
			BigInteger bigInteger2 = this.x;
			BigInteger bigInteger3 = this.q;
			if (!true)
			{
			}
			BigInteger.Sign sign = BigInteger.Kernel.Compare(bigInteger2, bigInteger3);
			this.x.Randomize();
			BigInteger bigInteger4 = this.x;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00006900 File Offset: 0x00004B00
		private void add(byte[] a, byte[] b, int value)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00006910 File Offset: 0x00004B10
		private void GenerateParams(int keyLength)
		{
			SHA1 sha = SHA1.Create();
			if (this.rng == null)
			{
				RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
				this.rng = randomNumberGenerator;
			}
			byte[] array2;
			byte[] array = sha.ComputeHash(array2);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00006A8C File Offset: 0x00004C8C
		private RandomNumberGenerator Random
		{
			get
			{
				RandomNumberGenerator randomNumberGenerator;
				if (this.rng == null)
				{
					randomNumberGenerator = RandomNumberGenerator.Create();
					this.rng = randomNumberGenerator;
				}
				return randomNumberGenerator;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00006AB0 File Offset: 0x00004CB0
		public override int KeySize
		{
			get
			{
				int num;
				if (this.keypairGenerated)
				{
					num = this.p.BitCount();
					return num;
				}
				return num;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00006AD4 File Offset: 0x00004CD4
		public override string KeyExchangeAlgorithm
		{
			get
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00006AE4 File Offset: 0x00004CE4
		public bool PublicOnly
		{
			get
			{
				if (this.keypairGenerated)
				{
					BigInteger bigInteger = this.x;
					bool flag;
					return flag;
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00006B04 File Offset: 0x00004D04
		public override string SignatureAlgorithm
		{
			get
			{
				return "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00006B18 File Offset: 0x00004D18
		private byte[] NormalizeArray(byte[] array)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00006B28 File Offset: 0x00004D28
		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			/*
An exception occurred when decompiling this method (060001B1)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Security.Cryptography.DSAParameters Mono.Security.Cryptography.DSAManaged::ExportParameters(System.Boolean)

 ---> System.Exception: Basic block has to end with unconditional control flow. 
{
	IL_00F7:
	stloc:string(var_26_101, call:string(Locale::GetText, ldstr:string("Keypair was disposed")))
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

		// Token: 0x060001B2 RID: 434 RVA: 0x00006C38 File Offset: 0x00004E38
		public override void ImportParameters(DSAParameters parameters)
		{
			if (!this.m_disposed)
			{
				if (parameters.Q == null || parameters.G == null)
				{
					string text = Locale.GetText("Missing mandatory DSA parameters (P, Q or G).");
					return;
				}
				byte[] array;
				if (parameters.X == null)
				{
					array = parameters.Y;
					if (array == null)
					{
						return;
					}
				}
				byte[] array2 = parameters.Q;
				byte[] array3 = parameters.G;
				if (parameters.X != null)
				{
					return;
				}
				if (parameters.Y != null)
				{
					return;
				}
				BigInteger bigInteger = this.g;
				BigInteger bigInteger2 = this.p;
				BigInteger bigInteger3;
				this.y = bigInteger3;
				if (parameters.J != null)
				{
					return;
				}
				BigInteger bigInteger4 = this.p;
				if (array == null)
				{
				}
				BigInteger bigInteger5 = 1;
				BigInteger bigInteger6 = bigInteger4 - bigInteger5;
				BigInteger bigInteger7 = this.q;
				BigInteger[] array4 = BigInteger.Kernel.multiByteDivide(bigInteger6, bigInteger7);
				this.j_missing = true;
				this.j = array;
				int num;
				if (parameters.Seed != null)
				{
					num = parameters.Counter;
					this.counter = num;
					return;
				}
				if (num == 0)
				{
				}
				BigInteger bigInteger8 = 0;
				this.seed = bigInteger8;
				this.keypairGenerated = true;
				return;
			}
			else
			{
				string text2 = Locale.GetText("Keypair was disposed");
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00006D48 File Offset: 0x00004F48
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			bool disposed = this.m_disposed;
			if (!disposed)
			{
				if (rgbHash == null)
				{
					goto IL_00CB;
				}
				if (!disposed)
				{
					this.Generate();
				}
				BigInteger bigInteger = this.x;
				if (!disposed)
				{
				}
				if (!disposed)
				{
				}
				BigInteger bigInteger2 = BigInteger.GenerateRandom(160);
				BigInteger bigInteger3 = this.q;
				if (!disposed)
				{
				}
				BigInteger.Sign sign = BigInteger.Kernel.Compare(bigInteger2, bigInteger3);
				bigInteger2.Randomize();
				BigInteger bigInteger4 = this.g;
				BigInteger bigInteger5 = this.p;
				BigInteger bigInteger6 = bigInteger4.ModPow(bigInteger2, bigInteger5);
				BigInteger bigInteger7 = this.q;
				BigInteger bigInteger8 = this.q;
				BigInteger bigInteger9 = BigInteger.Kernel.modInverse(bigInteger2, bigInteger8);
				BigInteger bigInteger10 = this.x * bigInteger7;
				BigInteger bigInteger12;
				BigInteger bigInteger11 = bigInteger9 * bigInteger12;
				BigInteger bigInteger13 = this.q;
				BigInteger[] array = BigInteger.Kernel.multiByteDivide(bigInteger11, bigInteger13);
				byte[] bytes = bigInteger7.GetBytes();
			}
			string text = Locale.GetText("Keypair was disposed");
			IL_00CB:
			return "invalid hash length";
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006E28 File Offset: 0x00005028
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			if (!this.m_disposed)
			{
				if (rgbHash == null)
				{
					goto IL_00E1;
				}
				if (rgbSignature == null)
				{
					return "invalid hash length" != null;
				}
				if (this.keypairGenerated)
				{
					BigInteger bigInteger = 0;
					BigInteger bigInteger2 = this.q;
					BigInteger bigInteger3 = 0;
					BigInteger bigInteger4 = this.q;
					BigInteger bigInteger5 = this.q;
					BigInteger bigInteger6 = this.q;
					BigInteger bigInteger7;
					BigInteger[] array = BigInteger.Kernel.multiByteDivide(bigInteger7, bigInteger6);
					BigInteger bigInteger8 = this.q;
					BigInteger bigInteger9;
					BigInteger[] array2 = BigInteger.Kernel.multiByteDivide(bigInteger9, bigInteger8);
					BigInteger bigInteger10 = this.g;
					BigInteger bigInteger11 = this.p;
					BigInteger bigInteger12 = this.y;
					BigInteger bigInteger13 = this.p;
					BigInteger bigInteger15;
					BigInteger bigInteger14 = bigInteger12.ModPow(bigInteger15, bigInteger13);
					BigInteger bigInteger17;
					BigInteger bigInteger16 = bigInteger17 * bigInteger14;
					BigInteger bigInteger18 = this.p;
					BigInteger[] array3 = BigInteger.Kernel.multiByteDivide(bigInteger16, bigInteger18);
					BigInteger bigInteger19 = this.q;
					BigInteger[] array4 = BigInteger.Kernel.multiByteDivide(array3, bigInteger19);
					bool flag;
					return flag;
				}
			}
			string text = Locale.GetText("Keypair was disposed");
			IL_00E1:
			return "rgbHash" != null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00006FB4 File Offset: 0x000051B4
		protected override void Dispose(bool disposing)
		{
			bool disposed = this.m_disposed;
			if (!disposed)
			{
				BigInteger bigInteger = this.x;
				if (!disposed)
				{
				}
				BigInteger bigInteger2 = this.x;
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
				BigInteger bigInteger7 = this.g;
				if (bigInteger6 == null)
				{
				}
				BigInteger bigInteger8 = this.g;
				if (bigInteger8.length != 0U)
				{
					uint[] data4 = bigInteger8.data;
					uint length4 = bigInteger8.length;
				}
				BigInteger bigInteger9 = this.j;
				if (bigInteger8 == null)
				{
				}
				BigInteger bigInteger10 = this.j;
				if (bigInteger10.length != 0U)
				{
					uint[] data5 = bigInteger10.data;
					uint length5 = bigInteger10.length;
				}
				BigInteger bigInteger11 = this.seed;
				if (bigInteger10 == null)
				{
				}
				BigInteger bigInteger12 = this.seed;
				if (bigInteger12.length != 0U)
				{
					uint[] data6 = bigInteger12.data;
					uint length6 = bigInteger12.length;
				}
				BigInteger bigInteger13 = this.y;
				if (bigInteger12 == null)
				{
				}
				BigInteger bigInteger14 = this.y;
				if (bigInteger14.length != 0U)
				{
					uint[] data7 = bigInteger14.data;
					uint length7 = bigInteger14.length;
				}
			}
			int num = 1;
			this.m_disposed = num != 0;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001B6 RID: 438 RVA: 0x00007130 File Offset: 0x00005330
		// (remove) Token: 0x060001B7 RID: 439 RVA: 0x00007154 File Offset: 0x00005354
		public event DSAManaged.KeyGeneratedEventHandler KeyGenerated
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

		// Token: 0x04000170 RID: 368
		private bool keypairGenerated;

		// Token: 0x04000171 RID: 369
		private bool m_disposed;

		// Token: 0x04000172 RID: 370
		private BigInteger p;

		// Token: 0x04000173 RID: 371
		private BigInteger q;

		// Token: 0x04000174 RID: 372
		private BigInteger g;

		// Token: 0x04000175 RID: 373
		private BigInteger x;

		// Token: 0x04000176 RID: 374
		private BigInteger y;

		// Token: 0x04000177 RID: 375
		private BigInteger j;

		// Token: 0x04000178 RID: 376
		private BigInteger seed;

		// Token: 0x04000179 RID: 377
		private int counter;

		// Token: 0x0400017A RID: 378
		private bool j_missing;

		// Token: 0x0400017B RID: 379
		private RandomNumberGenerator rng;

		// Token: 0x0400017C RID: 380
		[CompilerGenerated]
		private DSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x0200004E RID: 78
		public sealed class KeyGeneratedEventHandler : MulticastDelegate
		{
			// Token: 0x060001B8 RID: 440 RVA: 0x00007178 File Offset: 0x00005378
			public KeyGeneratedEventHandler(object @object, IntPtr method)
			{
				this.method_ptr = method;
				this.m_target = @object;
				this.method = method;
				this.method_code = this;
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x000071D8 File Offset: 0x000053D8
			public void Invoke(object sender, EventArgs e)
			{
				IntPtr method_code = this.method_code;
				IntPtr invoke_impl = this.invoke_impl;
				IntPtr method = this.method;
			}
		}
	}
}
